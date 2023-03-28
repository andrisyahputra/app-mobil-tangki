<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.btnTutup = New System.Windows.Forms.Label()
        Me.btnMTangki = New System.Windows.Forms.Button()
        Me.btnBulanan = New System.Windows.Forms.Button()
        Me.btnTahunan = New System.Windows.Forms.Button()
        Me.PanelLaporan = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
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
        Me.btnTutup.TabIndex = 112
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
        Me.btnMTangki.Location = New System.Drawing.Point(48, 658)
        Me.btnMTangki.Margin = New System.Windows.Forms.Padding(3, 3, 40, 40)
        Me.btnMTangki.Name = "btnMTangki"
        Me.btnMTangki.Size = New System.Drawing.Size(250, 42)
        Me.btnMTangki.TabIndex = 113
        Me.btnMTangki.Text = "LAPORAN HARIAN"
        Me.btnMTangki.UseVisualStyleBackColor = False
        '
        'btnBulanan
        '
        Me.btnBulanan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBulanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnBulanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBulanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBulanan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBulanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnBulanan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBulanan.Location = New System.Drawing.Point(341, 658)
        Me.btnBulanan.Margin = New System.Windows.Forms.Padding(3, 3, 40, 40)
        Me.btnBulanan.Name = "btnBulanan"
        Me.btnBulanan.Size = New System.Drawing.Size(282, 42)
        Me.btnBulanan.TabIndex = 113
        Me.btnBulanan.Text = "LAPORAN BULANAN"
        Me.btnBulanan.UseVisualStyleBackColor = False
        '
        'btnTahunan
        '
        Me.btnTahunan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTahunan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.btnTahunan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTahunan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTahunan.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTahunan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.btnTahunan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTahunan.Location = New System.Drawing.Point(666, 658)
        Me.btnTahunan.Margin = New System.Windows.Forms.Padding(3, 3, 4, 40)
        Me.btnTahunan.Name = "btnTahunan"
        Me.btnTahunan.Size = New System.Drawing.Size(269, 42)
        Me.btnTahunan.TabIndex = 113
        Me.btnTahunan.Text = "LAPORAN TAHUNAN"
        Me.btnTahunan.UseVisualStyleBackColor = False
        '
        'PanelLaporan
        '
        Me.PanelLaporan.Location = New System.Drawing.Point(1, -2)
        Me.PanelLaporan.Name = "PanelLaporan"
        Me.PanelLaporan.Size = New System.Drawing.Size(1001, 620)
        Me.PanelLaporan.TabIndex = 114
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1002, 749)
        Me.Controls.Add(Me.btnTahunan)
        Me.Controls.Add(Me.btnBulanan)
        Me.Controls.Add(Me.btnMTangki)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.PanelLaporan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTutup As Label
    Friend WithEvents btnMTangki As Button
    Friend WithEvents btnBulanan As Button
    Friend WithEvents btnTahunan As Button
    Friend WithEvents PanelLaporan As Panel
End Class
