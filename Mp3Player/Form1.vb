Imports WMPLib
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
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
    Dim DirLoad As String = My.Settings.PlaylistLoad
    Dim ShuffleList As Boolean = False
    Dim RepeatSong As Boolean = False

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Sub VolUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolUp.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub

    Private Sub VolDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolDown.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub

    Private Sub VolMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolMute.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
    End Sub

    Private Sub Listbox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        resetGUI()
        AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
        SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
        SongTitle.Location = New Point(0, SongTitle.Location.Y)
        PlayPauseInit = False
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        playstate = WMPPlayState.wmppsPlaying
        PlayToolStripMenuItem.Text = ";"
        SeekTimer.Start()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        Try
            If PlayPauseInit = True Then
                AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
                SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
                SongTitle.Location = New Point(0, SongTitle.Location.Y)
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
        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & "You must first load a playlist or select a song." & vbCrLf & "Error code: " & ex.Message)
        End Try
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        PlayToolStripMenuItem.Text = "4"
        playstate = WMPPlayState.wmppsStopped
        PlayPauseInit = True
        SeekBar.Value = 0
        SeekTimer.Dispose()
        resetGUI()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        If (Me.ListBox2.TopIndex <> ListBox2.SelectedIndex) Then
            SeekTimer.Stop()
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex - 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
            resetGUI()
            SeekTimer.Start()
        End If
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If ShuffleList = True Then
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
            resetGUI()
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
            If TotalSeconds < 9 Then
                TotalSeconds = ("0" & TotalSeconds)
            Else : TotalSeconds = TotalSeconds
            End If
            TotalLength.Text = Math.Floor((AxWindowsMediaPlayer1.currentMedia.duration) / 60) & ":" & TotalSeconds
        Else
            SeekTimer.Stop()
            resetGUI()
            SongTitle.Location = New Point((Me.Width / 2), SongTitle.Location.Y)
            If (Me.ListBox2.Items.Count - 1 <> Me.ListBox2.SelectedIndex) Then
                If ShuffleList = True Then
                    Dim i As Integer = ListBox2.Items.Count
                    Dim SelectedItem As System.Object = ListBox2.Items.Item(RandomIndex.Next(i))
                    ListBox2.SelectedItem = SelectedItem
                ElseIf RepeatSong = True Then
                    Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex
                Else
                    Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
                End If
                AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
                AxWindowsMediaPlayer1.Ctlcontrols.play()
                SongTitle.Text = AxWindowsMediaPlayer1.currentMedia.name
                SeekTimer.Start()
            End If
        End If
        If SongTitle.Location.X >= (Me.Width * 1.75 - SongTitle.Location.X) Then
            SongTitle.Location = New Point(SongTitle.Location.X - Me.Width * 1.75, SongTitle.Location.Y)
        Else
            SongTitle.Location = New Point(SongTitle.Location.X + 15, SongTitle.Location.Y)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SongTitle.Parent = PictureBox1
        SongTitle.BackColor = Color.Transparent
        SendMessage(SeekBar.Handle, 1040, (3 * Rnd()), 0)
        SeekBar.Value = 0
        PictureBox1.Image = Nothing
        Dim HasLine As Boolean = True
        Dim oReader As StreamReader
        If My.Computer.FileSystem.FileExists(DirLoad) Then
            oReader = New StreamReader(DirLoad, True)
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
        Else
            If DirLoad = Nothing Then
                MsgBox("Welcome!" & vbCrLf & "Please Add Songs and Save a Playlist!!")
            Else : MsgBox("Error: The playlist does not exists!" & vbCrLf & "Are you sure it wasnt moved or deleted?" & vbCrLf & "Attempting Fetch: " & DirLoad)
            End If
        End If
        InitSongOptionsSelected()
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
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
        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim oReader As StreamReader
            Dim HasLine As Boolean = True
            oReader = New StreamReader(OpenFileDialog2.FileName, True)
            My.Settings.PlaylistLoad = OpenFileDialog2.FileName
            My.Settings.Save()
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
        Try
            If saveAsPlaylist.ShowDialog() = DialogResult.OK Then
                Dim FileName As Object = saveAsPlaylist.FileName
                My.Settings.PlaylistLoad = FileName
                My.Settings.Save()
                Using SW As New IO.StreamWriter(FileName, False)
                    For Each objMp3 As String In Me.ListBox2.Items
                        SW.WriteLine(objMp3 & "=" & song.songDir)
                    Next
                End Using
            End If
        Catch ex As Exception
            MsgBox("ERROR" & vbCrLf & "You cannot overwrite a playlist that is currently in use!" & vbCrLf & "Error Code: " & ex.Message)
        End Try
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
            Me.Size = New System.Drawing.Size(Me.Width, 175)
        Else
            ExpandMp3 = False
            ToolStripMenuItem1.Text = "5"
            PlayListToolStripMenuItem.Text = "Play List"
            OpenToolStripMenuItem.Text = "Add Music"
            Me.Size = New System.Drawing.Size(Me.Width, 415)
        End If
    End Sub

    Private Sub resetGUI()
        SendMessage(SeekBar.Handle, 1040, (3 * Rnd()), 0)
        SongTitle.Location = New Point(0, SongTitle.Location.Y)
        SeekMinutes = 0
        SeekSeconds = 0
        CurrentSeek.Text = "0:00"
        TotalLength.Text = "0:00"
        SeekBar.Value = 0
    End Sub


    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        SongTitle.Image = Nothing
        PictureBox1.BackColor = Color.LightGray
        CurrentSeek.BackColor = Color.LightGray
        CurrentSeek.ForeColor = Color.Black
        TotalLength.BackColor = Color.LightGray
        TotalLength.ForeColor = Color.Black
        SongTitle.ForeColor = Color.Black
        MenuStrip1.BackColor = Color.LightGray
        OptionsToolStripMenuItem.BackColor = Color.LightGray
        VolDown.BackColor = Color.LightGray
        VolUp.BackColor = Color.LightGray
        VolMute.BackColor = Color.LightGray
        OpenToolStripMenuItem.BackColor = Color.LightGray
        MenuStrip3.BackColor = Color.LightGray
        PlayListToolStripMenuItem.BackColor = Color.LightGray
    End Sub

    Private Sub EMC2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMC2ToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.EMC2
        SongTitle.Image = Nothing
        PictureBox1.BackColor = Nothing
        CurrentSeek.BackColor = Color.Black
        CurrentSeek.ForeColor = Color.Honeydew
        TotalLength.BackColor = Color.Black
        TotalLength.ForeColor = Color.Honeydew
        SongTitle.ForeColor = Color.Honeydew
        MenuStrip1.BackColor = Color.DarkGreen
        OptionsToolStripMenuItem.BackColor = Color.DarkGreen
        VolDown.BackColor = Color.DarkGreen
        VolUp.BackColor = Color.DarkGreen
        VolMute.BackColor = Color.DarkGreen
        OpenToolStripMenuItem.BackColor = Color.DarkGreen
        MenuStrip3.BackColor = Color.DarkGreen
        PlayListToolStripMenuItem.BackColor = Color.DarkGreen
    End Sub

    Private Sub BrickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrickToolStripMenuItem.Click
        PictureBox1.Image = My.Resources.brickWall
        SongTitle.Image = Nothing
        PictureBox1.BackColor = Nothing
        CurrentSeek.BackColor = Color.DarkGray
        CurrentSeek.ForeColor = Color.Black
        TotalLength.BackColor = Color.DarkGray
        TotalLength.ForeColor = Color.Black
        CurrentSeek.BackColor = Color.DarkGray
        TotalLength.BackColor = Color.DarkGray
        MenuStrip1.BackColor = Color.DarkGray
        OptionsToolStripMenuItem.BackColor = Color.DarkGray
        SongTitle.ForeColor = Color.GhostWhite
        VolDown.BackColor = Color.DarkGray
        VolUp.BackColor = Color.DarkGray
        VolMute.BackColor = Color.DarkGray
        OpenToolStripMenuItem.BackColor = Color.DarkGray
        MenuStrip3.BackColor = Color.DarkGray
        PlayListToolStripMenuItem.BackColor = Color.DarkGray
    End Sub

    Private Sub IChooseYouToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IChooseYouToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Yellow
        PictureBox1.Image = Nothing
        CurrentSeek.BackColor = PictureBox1.BackColor
        TotalLength.BackColor = PictureBox1.BackColor
        CurrentSeek.ForeColor = Color.Black
        TotalLength.ForeColor = Color.Black
        Me.BackColor = Color.Yellow
        MenuStrip1.BackColor = Color.Sienna
        OptionsToolStripMenuItem.BackColor = Color.Sienna
        SongTitle.ForeColor = Color.Black
        SongTitle.Image = My.Resources.pikachu_58698
        VolDown.BackColor = Color.Sienna
        VolUp.BackColor = Color.Sienna
        VolMute.BackColor = Color.Sienna
        OpenToolStripMenuItem.BackColor = Color.Sienna
        MenuStrip3.BackColor = Color.Sienna
        PlayListToolStripMenuItem.BackColor = Color.Sienna
    End Sub

    Private Sub WeBeJamminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeBeJamminToolStripMenuItem.Click
        PictureBox1.BackColor = Color.Maroon
        PictureBox1.Image = My.Resources.rasta
        CurrentSeek.BackColor = PictureBox1.BackColor
        TotalLength.BackColor = PictureBox1.BackColor
        CurrentSeek.ForeColor = Color.Gray
        TotalLength.ForeColor = Color.Gray
        Me.BackColor = Color.Maroon
        MenuStrip1.BackColor = Color.DarkGray
        OptionsToolStripMenuItem.BackColor = Color.DarkGray
        SongTitle.ForeColor = Color.LightGray
        SongTitle.Image = Nothing
        VolDown.BackColor = Color.Gray
        VolUp.BackColor = Color.Gray
        VolMute.BackColor = Color.Gray
        OpenToolStripMenuItem.BackColor = Color.Gray
        MenuStrip3.BackColor = Color.Gray
        PlayListToolStripMenuItem.BackColor = Color.Gray
    End Sub

    Private Sub ShuffleOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShuffleOnToolStripMenuItem.Click
        ShuffleList = True
        RepeatSong = False
        InitSongOptionsSelected()
    End Sub

    Private Sub ShuffleOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShuffleOffToolStripMenuItem.Click
        ShuffleList = False
        InitSongOptionsSelected()
    End Sub

    Private Sub RepeatOnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RepeatOnToolStripMenuItem1.Click
        RepeatSong = True
        ShuffleList = False
        InitSongOptionsSelected()
    End Sub

    Private Sub RepeatOffToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RepeatOffToolStripMenuItem1.Click
        RepeatSong = False
        InitSongOptionsSelected()
    End Sub

    Private Sub InitSongOptionsSelected()
        If ShuffleList = True Then
            Me.ShuffleOnToolStripMenuItem.Font = New Font(Me.ShuffleOnToolStripMenuItem.Font, FontStyle.Bold)
            Me.ShuffleOffToolStripMenuItem.Font = New Font(Me.ShuffleOffToolStripMenuItem.Font, FontStyle.Regular)
            Me.RepeatOnToolStripMenuItem1.Font = New Font(Me.RepeatOnToolStripMenuItem1.Font, FontStyle.Regular)
            Me.RepeatOffToolStripMenuItem1.Font = New Font(Me.RepeatOffToolStripMenuItem1.Font, FontStyle.Bold)
        Else
            Me.ShuffleOffToolStripMenuItem.Font = New Font(Me.ShuffleOffToolStripMenuItem.Font, FontStyle.Bold)
            Me.ShuffleOnToolStripMenuItem.Font = New Font(Me.ShuffleOnToolStripMenuItem.Font, FontStyle.Regular)
        End If
        If RepeatSong Then
            Me.RepeatOnToolStripMenuItem1.Font = New Font(Me.RepeatOnToolStripMenuItem1.Font, FontStyle.Bold)
            Me.RepeatOffToolStripMenuItem1.Font = New Font(Me.ShuffleOffToolStripMenuItem.Font, FontStyle.Regular)
            Me.ShuffleOnToolStripMenuItem.Font = New Font(Me.ShuffleOnToolStripMenuItem.Font, FontStyle.Regular)
            Me.ShuffleOffToolStripMenuItem.Font = New Font(Me.ShuffleOffToolStripMenuItem.Font, FontStyle.Bold)
        Else
            Me.RepeatOffToolStripMenuItem1.Font = New Font(Me.RepeatOffToolStripMenuItem1.Font, FontStyle.Bold)
            Me.RepeatOnToolStripMenuItem1.Font = New Font(Me.RepeatOnToolStripMenuItem1.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchYouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchYouTubeToolStripMenuItem.Click
        If ListBox2.SelectedIndex >= 0 Then
            Dim url As String = "https://www.youtube.com/results?search_query=" + ListBox2.SelectedItem.split(".")(0) + "+" + "Official"
            Process.Start(url)
        Else : MsgBox("Please Select A Song To Search!")
        End If
    End Sub

End Class




