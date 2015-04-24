<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SeekBar = New System.Windows.Forms.ProgressBar()
        Me.SeekTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.CurrentSeek = New System.Windows.Forms.Label()
        Me.TotalLength = New System.Windows.Forms.Label()
        Me.SongTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.StopToolStripMenuItem, Me.PrevToolStripMenuItem, Me.NextToolStripMenuItem, Me.ToolStripMenuItem1, Me.OpenToolStripMenuItem, Me.PlayListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(441, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PrevToolStripMenuItem
        '
        Me.PrevToolStripMenuItem.Name = "PrevToolStripMenuItem"
        Me.PrevToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.PrevToolStripMenuItem.Text = "<<"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.NextToolStripMenuItem.Text = ">>"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.OpenToolStripMenuItem.Text = "Open Files"
        '
        'PlayListToolStripMenuItem
        '
        Me.PlayListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadListToolStripMenuItem1, Me.SaveListToolStripMenuItem1, Me.ClearListToolStripMenuItem1})
        Me.PlayListToolStripMenuItem.Name = "PlayListToolStripMenuItem"
        Me.PlayListToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.PlayListToolStripMenuItem.Text = "Play List"
        '
        'LoadListToolStripMenuItem1
        '
        Me.LoadListToolStripMenuItem1.Name = "LoadListToolStripMenuItem1"
        Me.LoadListToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.LoadListToolStripMenuItem1.Text = "Load List"
        '
        'SaveListToolStripMenuItem1
        '
        Me.SaveListToolStripMenuItem1.Name = "SaveListToolStripMenuItem1"
        Me.SaveListToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.SaveListToolStripMenuItem1.Text = "Save List"
        '
        'ClearListToolStripMenuItem1
        '
        Me.ClearListToolStripMenuItem1.Name = "ClearListToolStripMenuItem1"
        Me.ClearListToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ClearListToolStripMenuItem1.Text = "Clear List"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "SelectFiles"
        Me.OpenFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WMA files(*wma)|*wma|All files(*.*)|*.*"
        Me.OpenFileDialog1.Multiselect = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.DefaultExt = "txt"
        Me.OpenFileDialog2.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'SeekBar
        '
        Me.SeekBar.Location = New System.Drawing.Point(37, 73)
        Me.SeekBar.Name = "SeekBar"
        Me.SeekBar.Size = New System.Drawing.Size(364, 10)
        Me.SeekBar.TabIndex = 1
        '
        'SeekTimer
        '
        Me.SeekTimer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(533, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.Font = New System.Drawing.Font("Book Antiqua", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(37, 92)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(364, 122)
        Me.ListBox2.TabIndex = 5
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 379)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'CurrentSeek
        '
        Me.CurrentSeek.AutoSize = True
        Me.CurrentSeek.Location = New System.Drawing.Point(4, 73)
        Me.CurrentSeek.Name = "CurrentSeek"
        Me.CurrentSeek.Size = New System.Drawing.Size(28, 13)
        Me.CurrentSeek.TabIndex = 1
        Me.CurrentSeek.Text = "0:00"
        '
        'TotalLength
        '
        Me.TotalLength.AutoSize = True
        Me.TotalLength.Location = New System.Drawing.Point(401, 73)
        Me.TotalLength.Name = "TotalLength"
        Me.TotalLength.Size = New System.Drawing.Size(28, 13)
        Me.TotalLength.TabIndex = 1
        Me.TotalLength.Text = "0:00"
        '
        'SongTitle
        '
        Me.SongTitle.Font = New System.Drawing.Font("Matura MT Script Capitals", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongTitle.Location = New System.Drawing.Point(4, 40)
        Me.SongTitle.Name = "SongTitle"
        Me.SongTitle.Size = New System.Drawing.Size(432, 23)
        Me.SongTitle.TabIndex = 6
        Me.SongTitle.Text = "Song Title"
        Me.SongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(-8, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 10)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(-39, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 10)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 248)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SongTitle)
        Me.Controls.Add(Me.TotalLength)
        Me.Controls.Add(Me.CurrentSeek)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.SeekBar)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Mp3 Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrevToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SeekBar As System.Windows.Forms.ProgressBar
    Public WithEvents SeekTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrentSeek As System.Windows.Forms.Label
    Friend WithEvents TotalLength As System.Windows.Forms.Label
    Friend WithEvents SongTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
