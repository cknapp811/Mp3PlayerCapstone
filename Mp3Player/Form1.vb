Imports WMPLib
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319
    Dim paths As String()
    Dim fileNames As String()
    Dim song As Song = New Song()
    Dim SeekSeconds As String
    Dim SeekMinutes As Integer
    Dim TotalSeconds As String
    Dim ExpandMp3 As Boolean = False
    Dim TrcBarValue As Integer
    Dim PlayPauseInit As Boolean = True
    Dim playstate As Long
    Dim RandomIndex As New Random

    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub tbVolume_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbVolume.ValueChanged
        TrcBarValue = tbVolume.Value
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        If shuffleButton.ForeColor = Color.Green Then
                Dim i As Integer = ListBox2.Items.Count
                Dim SelectedItem As System.Object = ListBox2.Items.Item(RandomIndex.Next(i))
                ListBox2.SelectedItem = SelectedItem
        End If
        If PlayPauseInit = True Then
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
            PlayPauseInit = False
        End If
        If playstate = WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            playstate = WMPPlayState.wmppsPaused
            PlayToolStripMenuItem.Text = "4"
            SeekTimer.Stop()
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            playstate = WMPPlayState.wmppsPlaying
            PlayToolStripMenuItem.Text = ";"
            SeekTimer.Start()
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        SeekMinutes = 0
        SeekSeconds = 0
        CurrentSeek.Text = "0:00"
        TotalLength.Text = "0:00"
        PlayToolStripMenuItem.Text = "4"
        playstate = WMPPlayState.wmppsStopped
        PlayPauseInit = True
        SeekBar.Value = 0
        SeekTimer.Dispose()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        If (Me.ListBox2.TopIndex <> ListBox2.SelectedIndex) Then
            SeekTimer.Stop()
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex - 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
            SeekMinutes = 0
            SeekSeconds = 0
            CurrentSeek.Text = "0:00"
            TotalLength.Text = "0:00"
            SeekBar.Value = 0
            SeekTimer.Start()
        End If
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If shuffleButton.ForeColor = Color.Green Then
            Dim i As Integer = ListBox2.Items.Count
            Dim songIndex As Integer = ListBox2.SelectedIndex
            Dim SelectedItem As System.Object = ListBox2.Items.Item(RandomIndex.Next(i))
            ListBox2.SelectedItem = SelectedItem
        End If
        If ((Me.ListBox2.Items.Count - 1) <> Me.ListBox2.SelectedIndex) Then
            SeekTimer.Stop()
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
            SeekMinutes = 0
            SeekSeconds = 0
            CurrentSeek.Text = "0:00"
            TotalLength.Text = "0:00"
            SeekBar.Value = 0
            SeekTimer.Start()
        End If
    End Sub

    Private Sub SeekTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles SeekTimer.Tick
        SeekBar.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        If (SeekBar.Value < SeekBar.Maximum) Then
            SeekBar.Value = SeekBar.Value + 1
            If SeekSeconds = 59 Then
                SeekMinutes = SeekMinutes + 1
                SeekSeconds = "00"
            End If
            If SeekSeconds < 9 Then
                SeekSeconds = ("0" & SeekSeconds + 1)
            Else : SeekSeconds = SeekSeconds + 1
            End If
            CurrentSeek.Text = SeekMinutes & ":" & SeekSeconds
            TotalSeconds = Math.Floor((AxWindowsMediaPlayer1.currentMedia.duration) Mod 60)
            TotalLength.Text = Math.Floor((AxWindowsMediaPlayer1.currentMedia.duration) / 60) & ":" & TotalSeconds
        Else
            SeekTimer.Stop()
            If (Me.ListBox2.Items.Count - 1 <> Me.ListBox2.SelectedIndex) Then
                If shuffleButton.ForeColor = Color.Green Then
                    Dim i As Integer = ListBox2.Items.Count
                    Dim SelectedItem As System.Object = ListBox2.Items.Item(RandomIndex.Next(i))
                    ListBox2.SelectedItem = SelectedItem
                Else
                    Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
                End If
                AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                SeekMinutes = 0
                SeekSeconds = 0
                SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
                CurrentSeek.Text = "0:00"
                TotalLength.Text = "0:00"
                SeekBar.Value = 0
                SeekTimer.Start()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeekBar.Value = 0
        tbVolume.Maximum = 100
        PictureBox1.Image = Nothing

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            paths = OpenFileDialog1.SafeFileNames
            fileNames = OpenFileDialog1.FileNames
            For i As Integer = 0 To fileNames.Length - 1
                song.songTitle = System.IO.Path.GetFileName(fileNames(i))
                song.songDir = Path.GetDirectoryName(fileNames(i))
                ListBox2.Items.Add(song.songTitle)
            Next
            ListBox2.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadListToolStripMenuItem1.Click
        Dim oReader As StreamReader
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim HasLine As Boolean = True
            oReader = New StreamReader(OpenFileDialog2.FileName, True)
            While HasLine
                Dim strReader As String = oReader.ReadLine
                If strReader Is Nothing Then
                    HasLine = False
                Else
                    song.songTitle = strReader.Split("=")(0)
                    song.songDir = strReader.Split("=")(1)
                    ListBox2.Items.Add(song.songTitle)
                End If
            End While
            ListBox2.SelectedIndex = 0
        End If
    End Sub

    Private Sub SaveListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveListToolStripMenuItem1.Click
        Dim saveAsPlaylist As New SaveFileDialog()
        saveAsPlaylist.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        saveAsPlaylist.FilterIndex = 1
        saveAsPlaylist.RestoreDirectory = True
        If saveAsPlaylist.ShowDialog() = DialogResult.OK Then
            Dim FileName As Object = saveAsPlaylist.FileName
            Using SW As New IO.StreamWriter(FileName, False)
                For Each objMp3 As String In Me.ListBox2.Items
                    SW.WriteLine(objMp3 & "=" & song.songDir)
                Next
            End Using
        End If
    End Sub

    Private Sub ClearListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem1.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ExpandMp3 = False Then
            ExpandMp3 = True
            ToolStripMenuItem1.Text = "6"
            PlayListToolStripMenuItem.Text = ""
            OpenToolStripMenuItem.Text = ""
            Me.Size = New System.Drawing.Size(Me.Width, 165)
        Else
            ExpandMp3 = False
            ToolStripMenuItem1.Text = "5"
            PlayListToolStripMenuItem.Text = "Play List"
            OpenToolStripMenuItem.Text = "Add Music"
            Me.Size = New System.Drawing.Size(Me.Width, 300)
        End If
    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        Dim TrcBarDirection As Integer = tbVolume.Value()
        If tbVolume.Value > TrcBarValue Then
            For TrcBarDirection = 0 To TrcBarDirection
                SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
            Next
        Else : For TrcBarDirection = 0 To TrcBarValue
                SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
            Next
        End If
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub EMC2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMC2ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.EMC2
    End Sub

    Private Sub OrbeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrbeToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.orbe
    End Sub

    Private Sub shuffleButton_Click(sender As Object, e As EventArgs) Handles shuffleButton.Click
        If shuffleButton.ForeColor = Color.Red Then
            shuffleButton.ForeColor = Color.Green
            shuffleButton.Text = "Shuffle On"
        ElseIf shuffleButton.ForeColor = Color.Green Then
            shuffleButton.ForeColor = Color.Red
            shuffleButton.Text = "Shuffle Off"
        End If

        
        'AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
        'SeekTimer.Start()
    End Sub
End Class


