<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksi
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtJMHole1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.LBLCARIDATA = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.lblIDPlat = New System.Windows.Forms.Label()
        Me.txtJMHole2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridTranksaksi = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridTranksaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJMHole1
        '
        Me.txtJMHole1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJMHole1.Location = New System.Drawing.Point(300, 75)
        Me.txtJMHole1.Name = "txtJMHole1"
        Me.txtJMHole1.Size = New System.Drawing.Size(147, 25)
        Me.txtJMHole1.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 27)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Jarak Main Hole 1         :"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(180, 355)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(295, 29)
        Me.txtCari.TabIndex = 119
        '
        'LBLCARIDATA
        '
        Me.LBLCARIDATA.AutoSize = True
        Me.LBLCARIDATA.BackColor = System.Drawing.Color.Transparent
        Me.LBLCARIDATA.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCARIDATA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.LBLCARIDATA.Location = New System.Drawing.Point(57, 357)
        Me.LBLCARIDATA.Name = "LBLCARIDATA"
        Me.LBLCARIDATA.Size = New System.Drawing.Size(117, 27)
        Me.LBLCARIDATA.TabIndex = 118
        Me.LBLCARIDATA.Text = "Cari Data :"
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
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 20.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(922, 236)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSAKSI"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.BackColor = System.Drawing.Color.Transparent
        Me.lblJam.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.Location = New System.Drawing.Point(488, 152)
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
        Me.txtJMHole2.Location = New System.Drawing.Point(727, 75)
        Me.txtJMHole2.Name = "txtJMHole2"
        Me.txtJMHole2.Size = New System.Drawing.Size(147, 25)
        Me.txtJMHole2.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(482, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 27)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Jarak Main Hole 2         :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 27)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "TGL JAM PENGUKURAN  :"
        '
        'Timer1
        '
        '
        'DataGridTranksaksi
        '
        Me.DataGridTranksaksi.AllowUserToAddRows = False
        Me.DataGridTranksaksi.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridTranksaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridTranksaksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridTranksaksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTranksaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridTranksaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTranksaksi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridTranksaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridTranksaksi.Location = New System.Drawing.Point(43, 418)
        Me.DataGridTranksaksi.Name = "DataGridTranksaksi"
        Me.DataGridTranksaksi.ReadOnly = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridTranksaksi.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridTranksaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridTranksaksi.Size = New System.Drawing.Size(924, 309)
        Me.DataGridTranksaksi.TabIndex = 121
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Image = Global.AppMobilTangki.My.Resources.Resources.clear
        Me.btnClear.Location = New System.Drawing.Point(678, 331)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 70)
        Me.btnClear.TabIndex = 120
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnTambah.Image = Global.AppMobilTangki.My.Resources.Resources.save
        Me.BtnTambah.Location = New System.Drawing.Point(578, 331)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(69, 70)
        Me.BtnTambah.TabIndex = 115
        '
        'btnHapus
        '
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHapus.Image = Global.AppMobilTangki.My.Resources.Resources.sampah
        Me.btnHapus.Location = New System.Drawing.Point(898, 331)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(69, 70)
        Me.btnHapus.TabIndex = 117
        '
        'BtnEdit
        '
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEdit.Image = Global.AppMobilTangki.My.Resources.Resources.update
        Me.BtnEdit.Location = New System.Drawing.Point(787, 331)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(69, 70)
        Me.BtnEdit.TabIndex = 116
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
        Me.btnTutup.TabIndex = 111
        '
        'LblKode
        '
        Me.LblKode.BackColor = System.Drawing.Color.Transparent
        Me.LblKode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblKode.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKode.Image = Global.AppMobilTangki.My.Resources.Resources.search
        Me.LblKode.Location = New System.Drawing.Point(503, 348)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 114
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 749)
        Me.Controls.Add(Me.DataGridTranksaksi)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.LBLCARIDATA)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.LblKode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnTutup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridTranksaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Label
    Friend WithEvents txtJMHole1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHapus As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents LBLCARIDATA As Label
    Friend WithEvents BtnEdit As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTutup As Label
    Friend WithEvents txtJMHole2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIDPlat As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnClear As Label
    Friend WithEvents DataGridTranksaksi As DataGridView
    Friend WithEvents lblJam As Label
    Friend WithEvents LblKode As Label
End Class
