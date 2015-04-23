Imports WMPLib
Imports System.IO

Public Class Form1
    Dim paths As String()
    Dim fileNames As String()
    Dim song As Song = New Song()

    Public Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WMA files(*wma)|*wma|All files(*.*)|*.*"
            paths = OpenFileDialog1.SafeFileNames
            fileNames = OpenFileDialog1.FileNames
            For i As Integer = 0 To fileNames.Length - 1
                song.songTitle = System.IO.Path.GetFileName(fileNames(i))
                song.songDir = Path.GetDirectoryName(fileNames(i))
                ListBox2.Items.Add(song.songTitle)
            Next
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
        SeekBar.Value = 0
        SeekTimer.Start()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        SeekTimer.Stop()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex - 1
        AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If ListBox2.Items.Count >= 1 Then
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
            AxWindowsMediaPlayer1.URL = (song.songDir & "\" & ListBox2.SelectedItem)
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub SeekTimer_Tick(ByVal sender As System.Object, ByVal e As EventArgs) Handles SeekTimer.Tick
        If SeekBar.Value < 100 Then
            SeekBar.Value = SeekBar.Value + 1
        Else : SeekBar.Value = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SeekBar.Value = 0
    End Sub

    Private Sub LoadListToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadListToolStripMenuItem1.Click
        Dim oReader As StreamReader
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "txt"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim HasLine As Boolean = True
            oReader = New StreamReader(OpenFileDialog1.FileName, True)
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

    Private Sub ClearListToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem1.Click
        ListBox2.Items.Clear()
    End Sub
End Class


