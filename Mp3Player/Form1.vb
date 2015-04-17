Imports WMPLib
Imports System.IO

Public Class Form1
    Dim paths As String()
    Dim fileNames As String()
    Dim mp3Songs

    Public Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            OpenFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WMA files(*wma)|*wma|All files(*.*)|*.*"
            paths = OpenFileDialog1.SafeFileNames
            fileNames = OpenFileDialog1.FileNames

            For i As Integer = 0 To fileNames.Length - 1
                ListBox1.Items.Add(fileNames(i))
                ListBox2.Items.Add(System.IO.Path.GetFileNameWithoutExtension(fileNames(i)))

            Next
        End If

    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
        SeekBar.Value = 0
        SeekTimer.Start()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        SeekTimer.Stop()
    End Sub

    Private Sub PrevToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevToolStripMenuItem.Click
        Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex - 1
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        If ListBox1.Items.Count > 1 Then
                Me.ListBox1.SelectedIndex = Me.ListBox1.SelectedIndex + 1
                AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
                AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = paths(ListBox1.SelectedIndex)

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

    
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class
