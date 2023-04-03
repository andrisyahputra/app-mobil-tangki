<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMobilTangki
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKTemen2 = New System.Windows.Forms.TextBox()
        Me.txtKTemen1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPlatKendaraan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNPerusahaan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMTangki = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNEXCEL = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnUploud = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblloader = New System.Windows.Forms.Label()
        Me.DTGridMT = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTGridMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtKTemen2)
        Me.GroupBox1.Controls.Add(Me.txtKTemen1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtPlatKendaraan)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNPerusahaan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtMTangki)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 236)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KENDARAAN MOBIL TANGKI"
        '
        'txtKTemen2
        '
        Me.txtKTemen2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKTemen2.Location = New System.Drawing.Point(675, 118)
        Me.txtKTemen2.Name = "txtKTemen2"
        Me.txtKTemen2.Size = New System.Drawing.Size(225, 25)
        Me.txtKTemen2.TabIndex = 92
        '
        'txtKTemen1
        '
        Me.txtKTemen1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKTemen1.Location = New System.Drawing.Point(675, 71)
        Me.txtKTemen1.Name = "txtKTemen1"
        Me.txtKTemen1.Size = New System.Drawing.Size(225, 25)
        Me.txtKTemen1.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 27)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "ID Kompartemen 2    :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(450, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(228, 27)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "ID Kompartemen 1    :"
        '
        'txtPlatKendaraan
        '
        Me.txtPlatKendaraan.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlatKendaraan.Location = New System.Drawing.Point(240, 158)
        Me.txtPlatKendaraan.Name = "txtPlatKendaraan"
        Me.txtPlatKendaraan.Size = New System.Drawing.Size(201, 25)
        Me.txtPlatKendaraan.TabIndex = 77
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(214, 27)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "No Plat Kendaraan  :"
        '
        'txtNPerusahaan
        '
        Me.txtNPerusahaan.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPerusahaan.Location = New System.Drawing.Point(240, 69)
        Me.txtNPerusahaan.Name = "txtNPerusahaan"
        Me.txtNPerusahaan.Size = New System.Drawing.Size(201, 25)
        Me.txtNPerusahaan.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 27)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Nama Perusahaan   :"
        '
        'txtMTangki
        '
        Me.txtMTangki.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMTangki.Location = New System.Drawing.Point(240, 116)
        Me.txtMTangki.Name = "txtMTangki"
        Me.txtMTangki.Size = New System.Drawing.Size(201, 25)
        Me.txtMTangki.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 27)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Mobil Tangki           :"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(178, 315)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(347, 29)
        Me.txtCari.TabIndex = 110
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(55, 317)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 27)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Cari Data :"
        '
        'BTNEXCEL
        '
        Me.BTNEXCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNEXCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEXCEL.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNEXCEL.Location = New System.Drawing.Point(25, 364)
        Me.BTNEXCEL.Name = "BTNEXCEL"
        Me.BTNEXCEL.Size = New System.Drawing.Size(213, 33)
        Me.BTNEXCEL.TabIndex = 113
        Me.BTNEXCEL.Text = "IMPORT EXCEL"
        Me.BTNEXCEL.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(253, 385)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(491, 12)
        Me.ProgressBar1.TabIndex = 114
        '
        'Timer1
        '
        '
        'btnUploud
        '
        Me.btnUploud.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUploud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploud.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUploud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploud.Location = New System.Drawing.Point(764, 364)
        Me.btnUploud.Name = "btnUploud"
        Me.btnUploud.Size = New System.Drawing.Size(213, 33)
        Me.btnUploud.TabIndex = 115
        Me.btnUploud.Text = "UPLOUD"
        Me.btnUploud.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Image = Global.AppMobilTangki.My.Resources.Resources.clear
        Me.btnClear.Location = New System.Drawing.Point(704, 291)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 70)
        Me.btnClear.TabIndex = 111
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHapus.Image = Global.AppMobilTangki.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(896, 291)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 107
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Image = Global.AppMobilTangki.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(805, 291)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 106
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTambah.Image = Global.AppMobilTangki.My.Resources.Resources.save
        Me.BtnTambah.Location = New System.Drawing.Point(610, 291)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 70)
        Me.BtnTambah.TabIndex = 105
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppMobilTangki.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(548, 308)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 104
        '
        'btnTutup
        '
        Me.btnTutup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTutup.BackColor = System.Drawing.Color.Transparent
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppMobilTangki.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(966, -2)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(36, 39)
        Me.btnTutup.TabIndex = 101
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'lblloader
        '
        Me.lblloader.AutoSize = True
        Me.lblloader.BackColor = System.Drawing.Color.Transparent
        Me.lblloader.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloader.Location = New System.Drawing.Point(256, 355)
        Me.lblloader.Name = "lblloader"
        Me.lblloader.Size = New System.Drawing.Size(20, 27)
        Me.lblloader.TabIndex = 93
        Me.lblloader.Text = "-"
        '
        'DTGridMT
        '
        Me.DTGridMT.AllowUserToAddRows = False
        Me.DTGridMT.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTGridMT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTGridMT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTGridMT.Location = New System.Drawing.Point(25, 422)
        Me.DTGridMT.Name = "DTGridMT"
        Me.DTGridMT.ReadOnly = True
        Me.DTGridMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DTGridMT.Size = New System.Drawing.Size(952, 302)
        Me.DTGridMT.TabIndex = 116
        '
        'FormMobilTangki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 749)
        Me.Controls.Add(Me.DTGridMT)
        Me.Controls.Add(Me.lblloader)
        Me.Controls.Add(Me.btnUploud)
        Me.Controls.Add(Me.BTNEXCEL)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMobilTangki"
        Me.Text = "FormMobilTangki"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DTGridMT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTutup As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKTemen2 As TextBox
    Friend WithEvents txtKTemen1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPlatKendaraan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMTangki As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents BtnEdit As Label
    Friend WithEvents BtnTambah As Label
    Friend WithEvents txtNPerusahaan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents BTNEXCEL As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnUploud As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblloader As Label
    Friend WithEvents DTGridMT As DataGridView
End Class
