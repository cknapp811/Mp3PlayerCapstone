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
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrevToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SeekBar = New System.Windows.Forms.ProgressBar()
        Me.SeekTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.PrevToolStripMenuItem, Me.NextToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ClearListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PauseToolStripMenuItem.Text = "Pause"
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
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.OpenToolStripMenuItem.Text = "Open"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "SelectFiles"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(12, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(193, 344)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.Visible = False
        '
        'SeekBar
        '
        Me.SeekBar.Location = New System.Drawing.Point(307, 7)
        Me.SeekBar.Name = "SeekBar"
        Me.SeekBar.Size = New System.Drawing.Size(280, 10)
        Me.SeekBar.TabIndex = 3
        '
        'SeekTimer
        '
        Me.SeekTimer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(612, 404)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(12, 27)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(193, 344)
        Me.ListBox2.TabIndex = 5
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ClearListToolStripMenuItem.Text = "Clear List"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(610, 383)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.SeekBar)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Mp3 Player"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrevToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SeekBar As System.Windows.Forms.ProgressBar
    Public WithEvents SeekTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ClearListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
