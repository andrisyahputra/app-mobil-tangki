<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHarian
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dateTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnP = New System.Windows.Forms.Label()
        Me.btnE = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
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
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "LAPORAN HARIAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateTgl
        '
        Me.dateTgl.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dateTgl.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dateTgl.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dateTgl.CustomFormat = "dd/MM/yyyy"
        Me.dateTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.dateTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTgl.Location = New System.Drawing.Point(111, 128)
        Me.dateTgl.Name = "dateTgl"
        Me.dateTgl.Size = New System.Drawing.Size(136, 29)
        Me.dateTgl.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TANGGAL"
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
        Me.btnP.TabIndex = 96
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
        Me.btnE.TabIndex = 95
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
        Me.btnView.TabIndex = 94
        Me.btnView.Text = "Microsoft Sans Serif; 1,5pt"
        '
        'FormHarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 620)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.dateTgl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormHarian"
        Me.Text = "FormHarian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As Label
    Friend WithEvents btnP As Label
    Friend WithEvents btnE As Label
    Friend WithEvents btnView As Label
    Friend WithEvents dateTgl As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
