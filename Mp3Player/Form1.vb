Imports WMPLib
Imports System.IO

Public Class Form1
    Dim paths As String()
    Dim fileNames As String()

    Public Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WMA files(*wma)|*wma|All files(*.*)|*.*"
            paths = OpenFileDialog1.SafeFileNames
            fileNames = OpenFileDialog1.FileNames
            For i As Integer = 0 To fileNames.Length - 1
                Dim song As Song = New Song()
                song.songTitle = System.IO.Path.GetFileNameWithoutExtension(fileNames(i))
                song.songDir = fileNames(i)
                ListBox2.Items.Add(song)
            Next
        End If
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        SeekBar.Value = 0
        SeekTimer.Start()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        SeekTimer.Stop()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex - 1
        AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If ListBox2.Items.Count >= 1 Then
            Me.ListBox2.SelectedIndex = Me.ListBox2.SelectedIndex + 1
            AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.URL = paths(ListBox2.SelectedIndex)
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

    Private Sub LoadListToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles LoadListToolStripMenuItem1.Click
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\Users\Aaron\Desktop\playlist.txt")
        Dim stringReader As String
        Dim HasLine As Boolean = True
        While HasLine
            stringReader = fileReader.ReadLine
            If stringReader Is Nothing Then
                HasLine = False
            Else : ListBox2.Items.Add(stringReader)
            End If
        End While
    End Sub
    Private Sub ClearListToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem1.Click
        ListBox2.Items.Clear()
    End Sub

    Private Sub SaveListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveListToolStripMenuItem1.Click
    End Sub

   

End Class


