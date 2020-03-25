<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerProductive
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimerProductive))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbLagu = New Guna.UI.WinForms.GunaTextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaTransfarantPictureBox1 = New Guna.UI.WinForms.GunaTransfarantPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.clock = New Guna.UI.WinForms.GunaLabel()
        Me.noteTimer = New Guna.UI.WinForms.GunaLabel()
        Me.nudJam = New Guna.UI.WinForms.GunaNumeric()
        Me.nudMenit = New Guna.UI.WinForms.GunaNumeric()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.mtbWaktu = New System.Windows.Forms.MaskedTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.nilaiWaktu = New Guna.UI.WinForms.GunaLabel()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kegiatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.noteSelesai = New Guna.UI.WinForms.GunaLabel()
        Me.btnSet = New Guna.UI.WinForms.GunaButton()
        Me.btnUbah = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbLagu
        '
        Me.tbLagu.BackColor = System.Drawing.Color.Transparent
        Me.tbLagu.BaseColor = System.Drawing.Color.White
        Me.tbLagu.BorderColor = System.Drawing.Color.Silver
        Me.tbLagu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tbLagu.FocusedBaseColor = System.Drawing.Color.White
        Me.tbLagu.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbLagu.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.tbLagu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbLagu.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.tbLagu.Location = New System.Drawing.Point(72, 467)
        Me.tbLagu.Name = "tbLagu"
        Me.tbLagu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLagu.Radius = 3
        Me.tbLagu.SelectedText = ""
        Me.tbLagu.Size = New System.Drawing.Size(203, 30)
        Me.tbLagu.TabIndex = 1
        Me.tbLagu.Text = "Tambahkan Lagu . . . "
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(27, 462)
        Me.AxWindowsMediaPlayer1.Margin = New System.Windows.Forms.Padding(0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(37, 35)
        Me.AxWindowsMediaPlayer1.TabIndex = 2
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.GunaTransfarantPictureBox1)
        Me.GunaLinePanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaLinePanel1.Controls.Add(Me.btnClose)
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(305, 48)
        Me.GunaLinePanel1.TabIndex = 4
        '
        'GunaTransfarantPictureBox1
        '
        Me.GunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black
        Me.GunaTransfarantPictureBox1.Image = Global.TimerProductive.My.Resources.Resources.icons8_u_64
        Me.GunaTransfarantPictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.GunaTransfarantPictureBox1.Name = "GunaTransfarantPictureBox1"
        Me.GunaTransfarantPictureBox1.Size = New System.Drawing.Size(48, 39)
        Me.GunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaTransfarantPictureBox1.TabIndex = 15
        Me.GunaTransfarantPictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel1.Location = New System.Drawing.Point(62, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(181, 27)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Timer Productive"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.TimerProductive.My.Resources.Resources.icons8_close_window_48
        Me.btnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(252, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Radius = 12
        Me.btnClose.Size = New System.Drawing.Size(39, 34)
        Me.btnClose.TabIndex = 3
        '
        'clock
        '
        Me.clock.AutoSize = True
        Me.clock.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.clock.ForeColor = System.Drawing.Color.White
        Me.clock.Location = New System.Drawing.Point(91, 64)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(102, 37)
        Me.clock.TabIndex = 5
        Me.clock.Text = "CLOCK"
        Me.clock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'noteTimer
        '
        Me.noteTimer.AutoSize = True
        Me.noteTimer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.noteTimer.ForeColor = System.Drawing.Color.White
        Me.noteTimer.Location = New System.Drawing.Point(103, 110)
        Me.noteTimer.Name = "noteTimer"
        Me.noteTimer.Size = New System.Drawing.Size(87, 19)
        Me.noteTimer.TabIndex = 6
        Me.noteTimer.Text = "SET WAKTU"
        Me.noteTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudJam
        '
        Me.nudJam.BaseColor = System.Drawing.Color.White
        Me.nudJam.BorderColor = System.Drawing.Color.Silver
        Me.nudJam.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudJam.ButtonForeColor = System.Drawing.Color.White
        Me.nudJam.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudJam.ForeColor = System.Drawing.Color.Black
        Me.nudJam.Location = New System.Drawing.Point(81, 139)
        Me.nudJam.Maximum = CType(23, Long)
        Me.nudJam.Minimum = CType(0, Long)
        Me.nudJam.Name = "nudJam"
        Me.nudJam.Size = New System.Drawing.Size(53, 30)
        Me.nudJam.TabIndex = 7
        Me.nudJam.Value = CType(0, Long)
        '
        'nudMenit
        '
        Me.nudMenit.BaseColor = System.Drawing.Color.White
        Me.nudMenit.BorderColor = System.Drawing.Color.Silver
        Me.nudMenit.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nudMenit.ButtonForeColor = System.Drawing.Color.White
        Me.nudMenit.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.nudMenit.ForeColor = System.Drawing.Color.Black
        Me.nudMenit.Location = New System.Drawing.Point(167, 139)
        Me.nudMenit.Maximum = CType(59, Long)
        Me.nudMenit.Minimum = CType(0, Long)
        Me.nudMenit.Name = "nudMenit"
        Me.nudMenit.Size = New System.Drawing.Size(54, 30)
        Me.nudMenit.TabIndex = 8
        Me.nudMenit.Text = "GunaNumeric2"
        Me.nudMenit.Value = CType(0, Long)
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(140, 132)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(24, 37)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = ":"
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mtbWaktu
        '
        Me.mtbWaktu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mtbWaktu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbWaktu.Location = New System.Drawing.Point(101, 197)
        Me.mtbWaktu.Mask = "00:00:00"
        Me.mtbWaktu.Name = "mtbWaktu"
        Me.mtbWaktu.Size = New System.Drawing.Size(102, 29)
        Me.mtbWaktu.TabIndex = 12
        Me.mtbWaktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel4.Location = New System.Drawing.Point(266, 509)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(40, 19)
        Me.GunaLabel4.TabIndex = 0
        Me.GunaLabel4.Text = "~Upi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'nilaiWaktu
        '
        Me.nilaiWaktu.AutoSize = True
        Me.nilaiWaktu.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.nilaiWaktu.ForeColor = System.Drawing.Color.White
        Me.nilaiWaktu.Location = New System.Drawing.Point(106, 180)
        Me.nilaiWaktu.Name = "nilaiWaktu"
        Me.nilaiWaktu.Size = New System.Drawing.Size(92, 13)
        Me.nilaiWaktu.TabIndex = 13
        Me.nilaiWaktu.Text = "SAMPAI WAKTU"
        Me.nilaiWaktu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GunaDataGridView1
        '
        Me.GunaDataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        Me.GunaDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.kegiatan, Me.keterangan})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(27, 291)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(248, 150)
        Me.GunaDataGridView1.TabIndex = 15
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nomor
        '
        Me.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomor.DefaultCellStyle = DataGridViewCellStyle3
        Me.nomor.FillWeight = 76.14214!
        Me.nomor.HeaderText = "No"
        Me.nomor.MaxInputLength = 10
        Me.nomor.MinimumWidth = 2
        Me.nomor.Name = "nomor"
        Me.nomor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.nomor.ToolTipText = "Urutan Kegiatan"
        Me.nomor.Width = 25
        '
        'kegiatan
        '
        Me.kegiatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kegiatan.DefaultCellStyle = DataGridViewCellStyle4
        Me.kegiatan.FillWeight = 158.7829!
        Me.kegiatan.HeaderText = "              Kegiatan"
        Me.kegiatan.MinimumWidth = 100
        Me.kegiatan.Name = "kegiatan"
        Me.kegiatan.ToolTipText = "Kegiatan yang ingin dilakukan"
        '
        'keterangan
        '
        Me.keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.NullValue = False
        Me.keterangan.DefaultCellStyle = DataGridViewCellStyle5
        Me.keterangan.FillWeight = 65.07496!
        Me.keterangan.HeaderText = "Selesai"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ToolTipText = "Selesai dilakukan"
        Me.keterangan.TrueValue = "Keren"
        Me.keterangan.Width = 50
        '
        'noteSelesai
        '
        Me.noteSelesai.AutoSize = True
        Me.noteSelesai.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.noteSelesai.ForeColor = System.Drawing.Color.White
        Me.noteSelesai.Location = New System.Drawing.Point(27, 113)
        Me.noteSelesai.Name = "noteSelesai"
        Me.noteSelesai.Size = New System.Drawing.Size(236, 19)
        Me.noteSelesai.TabIndex = 16
        Me.noteSelesai.Text = "WAKTU SUDAH MENCAPAI BATAS"
        Me.noteSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.noteSelesai.Visible = False
        '
        'btnSet
        '
        Me.btnSet.AnimationHoverSpeed = 0.07!
        Me.btnSet.AnimationSpeed = 0.03!
        Me.btnSet.BackColor = System.Drawing.Color.Transparent
        Me.btnSet.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnSet.BorderColor = System.Drawing.Color.Black
        Me.btnSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSet.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSet.FocusedColor = System.Drawing.Color.Empty
        Me.btnSet.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnSet.ForeColor = System.Drawing.Color.White
        Me.btnSet.Image = Global.TimerProductive.My.Resources.Resources.icons8_save_30
        Me.btnSet.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSet.Location = New System.Drawing.Point(102, 241)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSet.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSet.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSet.OnHoverImage = Nothing
        Me.btnSet.OnPressedColor = System.Drawing.Color.Black
        Me.btnSet.Radius = 20
        Me.btnSet.Size = New System.Drawing.Size(103, 37)
        Me.btnSet.TabIndex = 14
        Me.btnSet.Text = "S E T"
        '
        'btnUbah
        '
        Me.btnUbah.AnimationHoverSpeed = 0.07!
        Me.btnUbah.AnimationSpeed = 0.03!
        Me.btnUbah.BackColor = System.Drawing.Color.Transparent
        Me.btnUbah.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnUbah.BorderColor = System.Drawing.Color.Black
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUbah.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnUbah.FocusedColor = System.Drawing.Color.Empty
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Image = Global.TimerProductive.My.Resources.Resources.icons8_change_48
        Me.btnUbah.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUbah.Location = New System.Drawing.Point(102, 241)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUbah.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUbah.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUbah.OnHoverImage = Nothing
        Me.btnUbah.OnPressedColor = System.Drawing.Color.Black
        Me.btnUbah.Radius = 20
        Me.btnUbah.Size = New System.Drawing.Size(103, 37)
        Me.btnUbah.TabIndex = 0
        Me.btnUbah.Text = "UBAH"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(128, 451)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(42, 13)
        Me.GunaLabel2.TabIndex = 17
        Me.GunaLabel2.Text = "MUSIK"
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerProductive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(303, 528)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.noteSelesai)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.nilaiWaktu)
        Me.Controls.Add(Me.mtbWaktu)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.nudMenit)
        Me.Controls.Add(Me.nudJam)
        Me.Controls.Add(Me.noteTimer)
        Me.Controls.Add(Me.clock)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.tbLagu)
        Me.Controls.Add(Me.btnUbah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TimerProductive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer Productive - Upi"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.GunaTransfarantPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUbah As Guna.UI.WinForms.GunaButton
    Friend WithEvents tbLagu As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents clock As Guna.UI.WinForms.GunaLabel
    Friend WithEvents noteTimer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents nudJam As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents nudMenit As Guna.UI.WinForms.GunaNumeric
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents mtbWaktu As MaskedTextBox
    Friend WithEvents GunaTransfarantPictureBox1 As Guna.UI.WinForms.GunaTransfarantPictureBox
    Friend WithEvents btnSet As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents nilaiWaktu As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents nomor As DataGridViewTextBoxColumn
    Friend WithEvents kegiatan As DataGridViewTextBoxColumn
    Friend WithEvents keterangan As DataGridViewCheckBoxColumn
    Friend WithEvents noteSelesai As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
End Class
