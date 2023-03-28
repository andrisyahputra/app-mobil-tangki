Public Class FormLaporan
    Sub switchPanelLaporan(ByVal panel As Form)
        PanelLaporan.Controls.Clear()
        'btnTutup.Visible = False
        panel.TopLevel = False
        PanelLaporan.Controls.Add(panel)
        panel.Show()
    End Sub
    Public Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanelLaporan(FormHarian)
        'FormHarian.btnView_Click(sender, e)
    End Sub

    Private Sub btnMTangki_Click(sender As Object, e As EventArgs) Handles btnMTangki.Click
        switchPanelLaporan(FormHarian)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBulanan.Click
        switchPanelLaporan(FormBulanan)
    End Sub

    Private Sub btnTahunan_Click(sender As Object, e As EventArgs) Handles btnTahunan.Click
        switchPanelLaporan(FormTahunan)
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        Call FormMenu.tampilMenu()
    End Sub
End Class