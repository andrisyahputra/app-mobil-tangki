<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAMT
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DataGridAMT = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.LblKode = New System.Windows.Forms.Label()
        Me.btnUploud = New System.Windows.Forms.Button()
        Me.BTNEXCEL = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridAMT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJMHole1
        '
        Me.txtJMHole1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJMHole1.Location = New System.Drawing.Point(199, 75)
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
        Me.Label7.Size = New System.Drawing.Size(123, 27)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "NIK AMT :"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(174, 309)
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
        Me.LBLCARIDATA.Location = New System.Drawing.Point(51, 311)
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
        Me.GroupBox1.Text = "FORM AMT"
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
        Me.Label4.Size = New System.Drawing.Size(152, 27)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "NAMA AMT :"
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
        'DataGridAMT
        '
        Me.DataGridAMT.AllowUserToAddRows = False
        Me.DataGridAMT.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridAMT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridAMT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridAMT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAMT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridAMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridAMT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridAMT.GridColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridAMT.Location = New System.Drawing.Point(43, 418)
        Me.DataGridAMT.Name = "DataGridAMT"
        Me.DataGridAMT.ReadOnly = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DataGridAMT.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridAMT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAMT.Size = New System.Drawing.Size(924, 309)
        Me.DataGridAMT.TabIndex = 121
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Image = Global.AppMobilTangki.My.Resources.Resources.clear
        Me.btnClear.Location = New System.Drawing.Point(672, 285)
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
        Me.BtnTambah.Location = New System.Drawing.Point(572, 285)
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
        Me.btnHapus.Location = New System.Drawing.Point(892, 285)
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
        Me.BtnEdit.Location = New System.Drawing.Point(781, 285)
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
        Me.LblKode.Location = New System.Drawing.Point(497, 302)
        Me.LblKode.Name = "LblKode"
        Me.LblKode.Size = New System.Drawing.Size(40, 44)
        Me.LblKode.TabIndex = 114
        '
        'btnUploud
        '
        Me.btnUploud.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUploud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUploud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploud.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUploud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploud.Location = New System.Drawing.Point(751, 370)
        Me.btnUploud.Name = "btnUploud"
        Me.btnUploud.Size = New System.Drawing.Size(213, 33)
        Me.btnUploud.TabIndex = 124
        Me.btnUploud.Text = "UPLOUD"
        Me.btnUploud.UseVisualStyleBackColor = False
        '
        'BTNEXCEL
        '
        Me.BTNEXCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BTNEXCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEXCEL.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BTNEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNEXCEL.Location = New System.Drawing.Point(43, 370)
        Me.BTNEXCEL.Name = "BTNEXCEL"
        Me.BTNEXCEL.Size = New System.Drawing.Size(213, 33)
        Me.BTNEXCEL.TabIndex = 122
        Me.BTNEXCEL.Text = "IMPORT EXCEL"
        Me.BTNEXCEL.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(295, 370)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(436, 33)
        Me.ProgressBar1.TabIndex = 123
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Timer2
        '
        '
        'FormAMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 749)
        Me.Controls.Add(Me.btnUploud)
        Me.Controls.Add(Me.BTNEXCEL)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DataGridAMT)
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
        Me.Name = "FormAMT"
        Me.Text = "FormAMT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridAMT, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnClear As Label
    Friend WithEvents DataGridAMT As DataGridView
    Friend WithEvents lblJam As Label
    Friend WithEvents LblKode As Label
    Friend WithEvents btnUploud As Button
    Friend WithEvents BTNEXCEL As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer2 As Timer
End Class
