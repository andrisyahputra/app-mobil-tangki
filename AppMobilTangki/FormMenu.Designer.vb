<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.lblTangki = New System.Windows.Forms.Label()
        Me.btnMTangki = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_level = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.PanelAkses = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.lblatas = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.lblNLengkap = New System.Windows.Forms.Label()
        Me.ptProfil = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelAkses.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTangki
        '
        Me.lblTangki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTangki.AutoSize = True
        Me.lblTangki.BackColor = System.Drawing.Color.Transparent
        Me.lblTangki.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTangki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lblTangki.Location = New System.Drawing.Point(768, 119)
        Me.lblTangki.Name = "lblTangki"
        Me.lblTangki.Size = New System.Drawing.Size(216, 55)
        Me.lblTangki.TabIndex = 124
        Me.lblTangki.Text = "TANGKI"
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
        Me.btnMTangki.Text = "REGISTRASI"
        Me.btnMTangki.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblNLengkap)
        Me.Panel4.Controls.Add(Me.ptProfil)
        Me.Panel4.Controls.Add(Me.lbl_level)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 447)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(366, 302)
        Me.Panel4.TabIndex = 4
        '
        'lbl_level
        '
        Me.lbl_level.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_level.AutoSize = True
        Me.lbl_level.BackColor = System.Drawing.Color.Transparent
        Me.lbl_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lbl_level.Location = New System.Drawing.Point(67, 231)
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
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(15, 343)
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
        Me.btnLaporan.Location = New System.Drawing.Point(12, 247)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(336, 63)
        Me.btnLaporan.TabIndex = 4
        Me.btnLaporan.Text = "LAPORAN"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'PanelAkses
        '
        Me.PanelAkses.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PanelAkses.Controls.Add(Me.PictureBox1)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AppMobilTangki.My.Resources.Resources.tanki_green
        Me.PictureBox1.Location = New System.Drawing.Point(466, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(802, 515)
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
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
        'lblNLengkap
        '
        Me.lblNLengkap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNLengkap.AutoSize = True
        Me.lblNLengkap.BackColor = System.Drawing.Color.Transparent
        Me.lblNLengkap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNLengkap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.lblNLengkap.Location = New System.Drawing.Point(67, 206)
        Me.lblNLengkap.Name = "lblNLengkap"
        Me.lblNLengkap.Size = New System.Drawing.Size(123, 20)
        Me.lblNLengkap.TabIndex = 21
        Me.lblNLengkap.Text = "Nama lengkap"
        '
        'ptProfil
        '
        Me.ptProfil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ptProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptProfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptProfil.Location = New System.Drawing.Point(71, 43)
        Me.ptProfil.Margin = New System.Windows.Forms.Padding(71, 3, 71, 3)
        Me.ptProfil.Name = "ptProfil"
        Me.ptProfil.Size = New System.Drawing.Size(224, 151)
        Me.ptProfil.TabIndex = 20
        Me.ptProfil.TabStop = False
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptProfil, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUser As Button
    Friend WithEvents lbl_level As Label
    Friend WithEvents lblNLengkap As Label
    Friend WithEvents ptProfil As PictureBox
End Class
