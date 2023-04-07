<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTangki = New System.Windows.Forms.Label()
        Me.btnMTangki = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNLengkap = New System.Windows.Forms.Label()
        Me.lbl_level = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNAMT = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.PanelAkses = New System.Windows.Forms.Panel()
        Me.DataGridTranksaksi = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.LBLCARIDATA = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblIDPlat = New System.Windows.Forms.Label()
        Me.txtJMHole2 = New System.Windows.Forms.TextBox()
        Me.txtJMHole1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.lblatas = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelAkses.SuspendLayout()
        CType(Me.DataGridTranksaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTangki
        '
        Me.lblTangki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTangki.AutoSize = True
        Me.lblTangki.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblTangki.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTangki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lblTangki.Location = New System.Drawing.Point(787, 3)
        Me.lblTangki.Name = "lblTangki"
        Me.lblTangki.Size = New System.Drawing.Size(198, 55)
        Me.lblTangki.TabIndex = 124
        Me.lblTangki.Text = "ORDER"
        '
        'btnMTangki
        '
        Me.btnMTangki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMTangki.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnMTangki.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMTangki.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMTangki.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMTangki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnMTangki.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMTangki.Location = New System.Drawing.Point(12, 143)
        Me.btnMTangki.Name = "btnMTangki"
        Me.btnMTangki.Size = New System.Drawing.Size(336, 63)
        Me.btnMTangki.TabIndex = 8
        Me.btnMTangki.Text = "MOBIL TANGKI"
        Me.btnMTangki.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblNLengkap)
        Me.Panel4.Controls.Add(Me.lbl_level)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 561)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 188)
        Me.Panel4.TabIndex = 4
        '
        'lblNLengkap
        '
        Me.lblNLengkap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNLengkap.AutoSize = True
        Me.lblNLengkap.BackColor = System.Drawing.Color.Transparent
        Me.lblNLengkap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNLengkap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lblNLengkap.Location = New System.Drawing.Point(27, 35)
        Me.lblNLengkap.Name = "lblNLengkap"
        Me.lblNLengkap.Size = New System.Drawing.Size(123, 20)
        Me.lblNLengkap.TabIndex = 21
        Me.lblNLengkap.Text = "Nama lengkap"
        '
        'lbl_level
        '
        Me.lbl_level.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_level.AutoSize = True
        Me.lbl_level.BackColor = System.Drawing.Color.Transparent
        Me.lbl_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_level.Location = New System.Drawing.Point(27, 81)
        Me.lbl_level.Name = "lbl_level"
        Me.lbl_level.Size = New System.Drawing.Size(94, 20)
        Me.lbl_level.TabIndex = 15
        Me.lbl_level.Text = "Level User"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(366, 100)
        Me.Panel5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 73)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "WELCOME"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BTNAMT)
        Me.Panel3.Controls.Add(Me.btnUser)
        Me.Panel3.Controls.Add(Me.btnMTangki)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.btnLaporan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(366, 749)
        Me.Panel3.TabIndex = 124
        '
        'BTNAMT
        '
        Me.BTNAMT.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNAMT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAMT.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAMT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNAMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNAMT.Location = New System.Drawing.Point(15, 235)
        Me.BTNAMT.Name = "BTNAMT"
        Me.BTNAMT.Size = New System.Drawing.Size(336, 63)
        Me.BTNAMT.TabIndex = 10
        Me.BTNAMT.Text = "REGISTASI AMT"
        Me.BTNAMT.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(15, 440)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(336, 63)
        Me.btnUser.TabIndex = 9
        Me.btnUser.Text = "USER"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(15, 342)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(336, 63)
        Me.btnLaporan.TabIndex = 4
        Me.btnLaporan.Text = "LAPORAN"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'PanelAkses
        '
        Me.PanelAkses.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PanelAkses.Controls.Add(Me.DataGridTranksaksi)
        Me.PanelAkses.Controls.Add(Me.btnClear)
        Me.PanelAkses.Controls.Add(Me.BtnTambah)
        Me.PanelAkses.Controls.Add(Me.btnHapus)
        Me.PanelAkses.Controls.Add(Me.LBLCARIDATA)
        Me.PanelAkses.Controls.Add(Me.txtCari)
        Me.PanelAkses.Controls.Add(Me.Label9)
        Me.PanelAkses.Controls.Add(Me.BtnEdit)
        Me.PanelAkses.Controls.Add(Me.GroupBox1)
        Me.PanelAkses.Controls.Add(Me.btnTutup)
        Me.PanelAkses.Controls.Add(Me.lblTangki)
        Me.PanelAkses.Controls.Add(Me.lblatas)
        Me.PanelAkses.Controls.Add(Me.PanelMenu)
        Me.PanelAkses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAkses.Location = New System.Drawing.Point(0, 0)
        Me.PanelAkses.Name = "PanelAkses"
        Me.PanelAkses.Size = New System.Drawing.Size(1370, 749)
        Me.PanelAkses.TabIndex = 126
        '
        'DataGridTranksaksi
        '
        Me.DataGridTranksaksi.AllowUserToAddRows = False
        Me.DataGridTranksaksi.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridTranksaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridTranksaksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridTranksaksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTranksaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridTranksaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTranksaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridTranksaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridTranksaksi.Location = New System.Drawing.Point(414, 484)
        Me.DataGridTranksaksi.Name = "DataGridTranksaksi"
        Me.DataGridTranksaksi.ReadOnly = True
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridTranksaksi.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridTranksaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTranksaksi.Size = New System.Drawing.Size(924, 253)
        Me.DataGridTranksaksi.TabIndex = 140
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Image = Global.AppMobilTangki.My.Resources.Resources.clear
        Me.btnClear.Location = New System.Drawing.Point(1044, 395)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 70)
        Me.btnClear.TabIndex = 139
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTambah.Image = Global.AppMobilTangki.My.Resources.Resources.save
        Me.BtnTambah.Location = New System.Drawing.Point(944, 395)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 70)
        Me.BtnTambah.TabIndex = 134
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHapus.Image = Global.AppMobilTangki.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(1264, 395)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 136
        '
        'LBLCARIDATA
        '
        Me.LBLCARIDATA.BackColor = System.Drawing.Color.Transparent
        Me.LBLCARIDATA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBLCARIDATA.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCARIDATA.Image = Global.AppMobilTangki.My.Resources.Resources.search
        Me.LBLCARIDATA.Location = New System.Drawing.Point(869, 412)
        Me.LBLCARIDATA.Name = "LBLCARIDATA"
        Me.LBLCARIDATA.Size = New System.Drawing.Size(40, 44)
        Me.LBLCARIDATA.TabIndex = 133
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(546, 419)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(295, 29)
        Me.txtCari.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(423, 421)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 27)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Cari Data :"
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Image = Global.AppMobilTangki.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(1153, 395)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 135
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lblJam)
        Me.GroupBox1.Controls.Add(Me.lblIDPlat)
        Me.GroupBox1.Controls.Add(Me.txtJMHole2)
        Me.GroupBox1.Controls.Add(Me.txtJMHole1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(416, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 236)
        Me.GroupBox1.TabIndex = 132
        Me.GroupBox1.TabStop = False
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.BackColor = System.Drawing.Color.Transparent
        Me.lblJam.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.Location = New System.Drawing.Point(357, 189)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(47, 27)
        Me.lblJam.TabIndex = 98
        Me.lblJam.Text = "jam"
        '
        'lblIDPlat
        '
        Me.lblIDPlat.AutoSize = True
        Me.lblIDPlat.BackColor = System.Drawing.Color.Transparent
        Me.lblIDPlat.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDPlat.Location = New System.Drawing.Point(443, 25)
        Me.lblIDPlat.Name = "lblIDPlat"
        Me.lblIDPlat.Size = New System.Drawing.Size(18, 27)
        Me.lblIDPlat.TabIndex = 97
        Me.lblIDPlat.Text = " "
        Me.lblIDPlat.Visible = False
        '
        'txtJMHole2
        '
        Me.txtJMHole2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJMHole2.Location = New System.Drawing.Point(727, 52)
        Me.txtJMHole2.Name = "txtJMHole2"
        Me.txtJMHole2.Size = New System.Drawing.Size(147, 25)
        Me.txtJMHole2.TabIndex = 69
        '
        'txtJMHole1
        '
        Me.txtJMHole1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJMHole1.Location = New System.Drawing.Point(300, 52)
        Me.txtJMHole1.Name = "txtJMHole1"
        Me.txtJMHole1.Size = New System.Drawing.Size(147, 25)
        Me.txtJMHole1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 27)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Jarak Main Hole 2         :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 27)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Jarak Main Hole 1         :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 27)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "TGL JAM PENGUKURAN  :"
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.Image = Global.AppMobilTangki.My.Resources.Resources.close
        Me.btnTutup.Location = New System.Drawing.Point(1320, 1)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(50, 39)
        Me.btnTutup.TabIndex = 125
        '
        'lblatas
        '
        Me.lblatas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.lblatas.Location = New System.Drawing.Point(365, 0)
        Me.lblatas.Name = "lblatas"
        Me.lblatas.Size = New System.Drawing.Size(1005, 63)
        Me.lblatas.TabIndex = 131
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelMenu.Location = New System.Drawing.Point(368, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(1002, 749)
        Me.PanelMenu.TabIndex = 47
        '
        'Timer1
        '
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelAkses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.PanelAkses.ResumeLayout(False)
        Me.PanelAkses.PerformLayout()
        CType(Me.DataGridTranksaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTutup As Label
    Friend WithEvents lblTangki As Label
    Friend WithEvents btnMTangki As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelAkses As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents lblatas As Label
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents lbl_level As Label
    Friend WithEvents lblNLengkap As Label
    Friend WithEvents BTNAMT As Button
    Friend WithEvents DataGridTranksaksi As DataGridView
    Friend WithEvents btnClear As Label
    Friend WithEvents BtnTambah As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents LBLCARIDATA As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnEdit As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblJam As Label
    Friend WithEvents lblIDPlat As Label
    Friend WithEvents txtJMHole2 As TextBox
    Friend WithEvents txtJMHole1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
