<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTahunan
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
        Me.btnP = New System.Windows.Forms.Label()
        Me.btnE = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnP
        '
        Me.btnP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnP.Image = Global.AppMobilTangki.My.Resources.Resources.prter
        Me.btnP.Location = New System.Drawing.Point(804, 91)
        Me.btnP.Margin = New System.Windows.Forms.Padding(3, 0, 40, 0)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(69, 70)
        Me.btnP.TabIndex = 112
        Me.btnP.Text = "Microsoft Sans Serif; 1,5pt"
        '
        'btnE
        '
        Me.btnE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnE.Image = Global.AppMobilTangki.My.Resources.Resources.exprt
        Me.btnE.Location = New System.Drawing.Point(916, 91)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(69, 70)
        Me.btnE.TabIndex = 111
        Me.btnE.Text = "Microsoft Sans Serif; 1,5pt"
        '
        'btnView
        '
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.5!)
        Me.btnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnView.Image = Global.AppMobilTangki.My.Resources.Resources.rf
        Me.btnView.Location = New System.Drawing.Point(692, 91)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 0, 40, 0)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(69, 70)
        Me.btnView.TabIndex = 110
        Me.btnView.Text = "Microsoft Sans Serif; 1,5pt"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(980, 55)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "LAPORAN TAHUNAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 182)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(3, 12, 3, 20)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(977, 409)
        Me.CrystalReportViewer1.TabIndex = 108
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033"})
        Me.ComboBox1.Location = New System.Drawing.Point(97, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 32)
        Me.ComboBox1.TabIndex = 114
        Me.ComboBox1.Text = "2023"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "TAHUN :"
        '
        'FormTahunan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 620)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTahunan"
        Me.Text = "FormTahunan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnP As Label
    Friend WithEvents btnE As Label
    Friend WithEvents btnView As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
