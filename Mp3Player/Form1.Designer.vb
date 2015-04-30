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
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatSongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatOnToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatOffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchYouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SeekBar = New System.Windows.Forms.ProgressBar()
        Me.SeekTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.CurrentSeek = New System.Windows.Forms.Label()
        Me.TotalLength = New System.Windows.Forms.Label()
        Me.SongTitle = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolMute = New System.Windows.Forms.PictureBox()
        Me.VolDown = New System.Windows.Forms.PictureBox()
        Me.VolUp = New System.Windows.Forms.PictureBox()
        Me.EMC2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IChooseYouToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeBeJamminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.VolMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.PlayToolStripMenuItem, Me.StopToolStripMenuItem, Me.PrevToolStripMenuItem, Me.NextToolStripMenuItem, Me.ToolStripMenuItem1, Me.ThemesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(448, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SongToolStripMenuItem, Me.SearchYouTubeToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 28)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SongToolStripMenuItem
        '
        Me.SongToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShuffleToolStripMenuItem, Me.RepeatSongToolStripMenuItem})
        Me.SongToolStripMenuItem.Name = "SongToolStripMenuItem"
        Me.SongToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SongToolStripMenuItem.Text = "Songs"
        '
        'ShuffleToolStripMenuItem
        '
        Me.ShuffleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShuffleOnToolStripMenuItem, Me.ShuffleOffToolStripMenuItem})
        Me.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem"
        Me.ShuffleToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ShuffleToolStripMenuItem.Text = "Shuffle"
        '
        'ShuffleOnToolStripMenuItem
        '
        Me.ShuffleOnToolStripMenuItem.Name = "ShuffleOnToolStripMenuItem"
        Me.ShuffleOnToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.ShuffleOnToolStripMenuItem.Text = "On"
        '
        'ShuffleOffToolStripMenuItem
        '
        Me.ShuffleOffToolStripMenuItem.Name = "ShuffleOffToolStripMenuItem"
        Me.ShuffleOffToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.ShuffleOffToolStripMenuItem.Text = "Off"
        '
        'RepeatSongToolStripMenuItem
        '
        Me.RepeatSongToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatOnToolStripMenuItem1, Me.RepeatOffToolStripMenuItem1})
        Me.RepeatSongToolStripMenuItem.Name = "RepeatSongToolStripMenuItem"
        Me.RepeatSongToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RepeatSongToolStripMenuItem.Text = "Repeat Song"
        '
        'RepeatOnToolStripMenuItem1
        '
        Me.RepeatOnToolStripMenuItem1.Name = "RepeatOnToolStripMenuItem1"
        Me.RepeatOnToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
        Me.RepeatOnToolStripMenuItem1.Text = "On"
        '
        'RepeatOffToolStripMenuItem1
        '
        Me.RepeatOffToolStripMenuItem1.Name = "RepeatOffToolStripMenuItem1"
        Me.RepeatOffToolStripMenuItem1.Size = New System.Drawing.Size(91, 22)
        Me.RepeatOffToolStripMenuItem1.Text = "Off"
        '
        'SearchYouTubeToolStripMenuItem
        '
        Me.SearchYouTubeToolStripMenuItem.Name = "SearchYouTubeToolStripMenuItem"
        Me.SearchYouTubeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SearchYouTubeToolStripMenuItem.Text = "Search YouTube"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.PlayToolStripMenuItem.Margin = New System.Windows.Forms.Padding(75, 0, 0, 0)
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(43, 28)
        Me.PlayToolStripMenuItem.Text = "4"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(41, 28)
        Me.StopToolStripMenuItem.Text = "<"
        '
        'PrevToolStripMenuItem
        '
        Me.PrevToolStripMenuItem.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.PrevToolStripMenuItem.Name = "PrevToolStripMenuItem"
        Me.PrevToolStripMenuItem.Size = New System.Drawing.Size(41, 28)
        Me.PrevToolStripMenuItem.Text = "7"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(41, 28)
        Me.NextToolStripMenuItem.Text = "8"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Webdings", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(33, 28)
        Me.ToolStripMenuItem1.Text = "5"
        '
        'ThemesToolStripMenuItem
        '
        Me.ThemesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ThemesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.EMC2ToolStripMenuItem, Me.BrickToolStripMenuItem, Me.IChooseYouToolStripMenuItem, Me.WeBeJamminToolStripMenuItem})
        Me.ThemesToolStripMenuItem.Name = "ThemesToolStripMenuItem"
        Me.ThemesToolStripMenuItem.Size = New System.Drawing.Size(61, 28)
        Me.ThemesToolStripMenuItem.Text = "Themes"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NoneToolStripMenuItem.Text = "None"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(32, 19)
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
        Me.SeekBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SeekBar.ForeColor = System.Drawing.Color.Fuchsia
        Me.SeekBar.Location = New System.Drawing.Point(47, 91)
        Me.SeekBar.Name = "SeekBar"
        Me.SeekBar.Size = New System.Drawing.Size(348, 17)
        Me.SeekBar.TabIndex = 1
        '
        'SeekTimer
        '
        Me.SeekTimer.Interval = 1000
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.White
        Me.ListBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(47, 114)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(348, 210)
        Me.ListBox2.TabIndex = 5
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(7, 451)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'CurrentSeek
        '
        Me.CurrentSeek.AutoSize = True
        Me.CurrentSeek.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentSeek.Location = New System.Drawing.Point(4, 91)
        Me.CurrentSeek.Name = "CurrentSeek"
        Me.CurrentSeek.Size = New System.Drawing.Size(37, 16)
        Me.CurrentSeek.TabIndex = 1
        Me.CurrentSeek.Text = "0:00"
        Me.CurrentSeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalLength
        '
        Me.TotalLength.AutoSize = True
        Me.TotalLength.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLength.Location = New System.Drawing.Point(399, 91)
        Me.TotalLength.Name = "TotalLength"
        Me.TotalLength.Size = New System.Drawing.Size(37, 16)
        Me.TotalLength.TabIndex = 1
        Me.TotalLength.Text = "0:00"
        Me.TotalLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SongTitle
        '
        Me.SongTitle.Font = New System.Drawing.Font("Lucida Console", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SongTitle.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SongTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SongTitle.Location = New System.Drawing.Point(-3, 32)
        Me.SongTitle.Name = "SongTitle"
        Me.SongTitle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.SongTitle.Size = New System.Drawing.Size(453, 56)
        Me.SongTitle.TabIndex = 6
        Me.SongTitle.Text = "Song Title"
        Me.SongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.PlayListToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 347)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(448, 24)
        Me.MenuStrip3.TabIndex = 10
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.OpenToolStripMenuItem.Text = "Add Music"
        '
        'PlayListToolStripMenuItem
        '
        Me.PlayListToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        'VolMute
        '
        Me.VolMute.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VolMute.Image = Global.Mp3Player.My.Resources.Resources.volume_mute
        Me.VolMute.InitialImage = Nothing
        Me.VolMute.Location = New System.Drawing.Point(10, 347)
        Me.VolMute.MaximumSize = New System.Drawing.Size(20, 20)
        Me.VolMute.Name = "VolMute"
        Me.VolMute.Size = New System.Drawing.Size(20, 20)
        Me.VolMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VolMute.TabIndex = 14
        Me.VolMute.TabStop = False
        '
        'VolDown
        '
        Me.VolDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VolDown.Image = Global.Mp3Player.My.Resources.Resources.VolumeDown_512
        Me.VolDown.InitialImage = Nothing
        Me.VolDown.Location = New System.Drawing.Point(36, 347)
        Me.VolDown.MaximumSize = New System.Drawing.Size(20, 20)
        Me.VolDown.Name = "VolDown"
        Me.VolDown.Size = New System.Drawing.Size(20, 20)
        Me.VolDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VolDown.TabIndex = 13
        Me.VolDown.TabStop = False
        '
        'VolUp
        '
        Me.VolUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VolUp.Image = Global.Mp3Player.My.Resources.Resources.VolumeUp_512
        Me.VolUp.InitialImage = Nothing
        Me.VolUp.Location = New System.Drawing.Point(62, 347)
        Me.VolUp.MaximumSize = New System.Drawing.Size(20, 20)
        Me.VolUp.Name = "VolUp"
        Me.VolUp.Size = New System.Drawing.Size(20, 20)
        Me.VolUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VolUp.TabIndex = 12
        Me.VolUp.TabStop = False
        '
        'EMC2ToolStripMenuItem
        '
        Me.EMC2ToolStripMenuItem.Image = Global.Mp3Player.My.Resources.Resources.EMC2
        Me.EMC2ToolStripMenuItem.Name = "EMC2ToolStripMenuItem"
        Me.EMC2ToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EMC2ToolStripMenuItem.Text = "E=MC2"
        '
        'BrickToolStripMenuItem
        '
        Me.BrickToolStripMenuItem.Image = Global.Mp3Player.My.Resources.Resources.brickWall
        Me.BrickToolStripMenuItem.Name = "BrickToolStripMenuItem"
        Me.BrickToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.BrickToolStripMenuItem.Text = "Another Brick in the wall"
        '
        'IChooseYouToolStripMenuItem
        '
        Me.IChooseYouToolStripMenuItem.Image = Global.Mp3Player.My.Resources.Resources.pikachu_58698
        Me.IChooseYouToolStripMenuItem.Name = "IChooseYouToolStripMenuItem"
        Me.IChooseYouToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.IChooseYouToolStripMenuItem.Text = "I Choose You!"
        '
        'WeBeJamminToolStripMenuItem
        '
        Me.WeBeJamminToolStripMenuItem.Image = Global.Mp3Player.My.Resources.Resources.rasta
        Me.WeBeJamminToolStripMenuItem.Name = "WeBeJamminToolStripMenuItem"
        Me.WeBeJamminToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.WeBeJamminToolStripMenuItem.Text = "We Be Jammin"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(467, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 371)
        Me.Controls.Add(Me.VolMute)
        Me.Controls.Add(Me.VolDown)
        Me.Controls.Add(Me.VolUp)
        Me.Controls.Add(Me.MenuStrip3)
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
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.VolMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
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
    Friend WithEvents CurrentSeek As System.Windows.Forms.Label
    Friend WithEvents TotalLength As System.Windows.Forms.Label
    Friend WithEvents SongTitle As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip3 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolUp As System.Windows.Forms.PictureBox
    Friend WithEvents VolDown As System.Windows.Forms.PictureBox
    Friend WithEvents ThemesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMC2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleOnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatSongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatOnToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatOffToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchYouTubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IChooseYouToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeBeJamminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolMute As System.Windows.Forms.PictureBox
End Class
