<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.open = New System.Windows.Forms.OpenFileDialog()
        Me.TitleBar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ion = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrangChủToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiaSẻFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pBar = New System.Windows.Forms.ProgressBar()
        Me.fileopen = New System.Windows.Forms.OpenFileDialog()
        Me.bWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'open
        '
        Me.open.Filter = "RAR-ZIP files (*.rar)|*.zip"
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.MediumAquamarine
        Me.TitleBar.Location = New System.Drawing.Point(-16, -1)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(577, 38)
        Me.TitleBar.TabIndex = 0
        Me.TitleBar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.TitleBar, "Chỉ hỗ trợ tập tin dạng ZIP và RAR ")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(94, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Chỉ hỗ trợ tập tin ZIP và RAR")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lưu Trữ 360 - Share Files"
        Me.ToolTip1.SetToolTip(Me.Label1, "Chỉ hỗ trợ tập tin dạng ZIP và RAR ")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(544, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Label2, "Đóng")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "-"
        Me.ToolTip1.SetToolTip(Me.Label3, "Thu xuống")
        '
        'ion
        '
        Me.ion.ContextMenuStrip = Me.tmenu
        Me.ion.Icon = CType(resources.GetObject("ion.Icon"), System.Drawing.Icon)
        Me.ion.Text = "Share Files"
        Me.ion.Visible = True
        '
        'tmenu
        '
        Me.tmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrangChủToolStripMenuItem, Me.ChiaSẻFilesToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.tmenu.Name = "ContextMenuStrip1"
        Me.tmenu.Size = New System.Drawing.Size(139, 70)
        '
        'TrangChủToolStripMenuItem
        '
        Me.TrangChủToolStripMenuItem.Name = "TrangChủToolStripMenuItem"
        Me.TrangChủToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TrangChủToolStripMenuItem.Text = "Trang chủ"
        '
        'ChiaSẻFilesToolStripMenuItem
        '
        Me.ChiaSẻFilesToolStripMenuItem.Name = "ChiaSẻFilesToolStripMenuItem"
        Me.ChiaSẻFilesToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ChiaSẻFilesToolStripMenuItem.Text = "Chia sẻ Files"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(147, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kéo thả tập tin vào đây !"
        Me.ToolTip1.SetToolTip(Me.Label4, "Chỉ hỗ trợ tập tin ZIP và RAR")
        '
        'pBar
        '
        Me.pBar.Location = New System.Drawing.Point(34, 149)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(504, 33)
        Me.pBar.TabIndex = 6
        '
        'fileopen
        '
        Me.fileopen.Filter = "Tập tin nén|*.zip;*.rar;*.RAR;*.ZIP"
        '
        'bWorker
        '
        Me.bWorker.WorkerReportsProgress = True
        Me.bWorker.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(522, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        Me.Label5.Visible = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 139)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pBar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Share File - Chia sẻ tập tin"
        Me.ToolTip1.SetToolTip(Me, "Chỉ hỗ trợ tập tin dạng ZIP và RAR ")
        CType(Me.TitleBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ion As System.Windows.Forms.NotifyIcon
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents fileopen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TrangChủToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiaSẻFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents TitleBar As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
