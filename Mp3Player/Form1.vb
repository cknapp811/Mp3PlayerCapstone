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
    Dim PlaySwapper As String = True
    Dim TotalSeconds As String
    Dim ExpandMp3 As Boolean = False
    Dim playstate As Long
    Dim TrcBarValue As Integer

    <DllImport("user32.dll")> Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function


    Private Sub tbVolume_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbVolume.ValueChanged
        TrcBarValue = tbVolume.Value
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            paths = OpenFileDialog1.SafeFileNames
            fileNames = OpenFileDialog1.FileNames
            For i As Integer = 0 To fileNames.Length - 1
                song.songTitle = System.IO.Path.GetFileName(fileNames(i))
                song.songDir = Path.GetDirectoryName(fileNames(i))
                ListBox2.Items.Add(song.songTitle)
                ListBox2.SelectedIndex = 0
            Next
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        Try
            If PlaySwapper = True Then
                PlaySwapper = False
                ListBox2.SelectedItem = 0
                PlayToolStripMenuItem.Text = "Pause"
                AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
                playstate = WMPPlayState.wmppsPlaying
                SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
                SeekBar.Value = 0
                SeekTimer.Start()
            ElseIf playstate = 3 Then
                AxWindowsMediaPlayer1.Ctlcontrols.pause()
                PlayToolStripMenuItem.Text = "Play"
                playstate = WMPPlayState.wmppsPaused
                SeekTimer.Stop()
            ElseIf playstate = 2 Then
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                PlayToolStripMenuItem.Text = "Pause"
                playstate = WMPPlayState.wmppsPlaying
                SeekTimer.Start()
            End If

        Catch ex As Exception
            PlayToolStripMenuItem.Text = "Play"
            PlaySwapper = True
            MsgBox("ERROR" & vbCrLf & "PLEASE MAKE SURE A SONG IS SELECTED OR PLAYLIST IS LOADED" & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        SeekTimer.Stop()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If (Me.ListBox2.TopIndex <> ListBox2.SelectedIndex) Then
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex - 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
            SeekBar.Value = 0
            SeekTimer.Start()
        End If
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If ((Me.ListBox2.Items.Count - 1) <> Me.ListBox2.SelectedIndex) Then
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
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
            SeekBar.Value = 0

            If ((Me.ListBox2.Items.Count - 1) <> Me.ListBox2.SelectedIndex) Then
                Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
                ListBox2.SelectedIndex = 0
                AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                SeekTimer.Start()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeekBar.Value = 0
        tbVolume.Maximum = 100
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
                    ListBox2.SelectedIndex = 0
                End If
            End While
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
            ToolStripMenuItem2.Text = "+"
            ExpandMp3 = True
            Me.Size = New System.Drawing.Size(457, 125)
        Else
            ToolStripMenuItem2.Text = "-"
            ExpandMp3 = False
            Me.Size = New System.Drawing.Size(457, 300)
        End If
    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        Dim TrcBarDirection As Integer = tbVolume.Value()
19:     If tbVolume.Value > TrcBarValue Then
20:         For TrcBarDirection = 0 To TrcBarDirection
21:             SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
22:         Next
23:     Else : For TrcBarDirection = 0 To TrcBarValue
24:             SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
25:         Next
26:     End If
    End Sub
End Class


