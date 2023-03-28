Public Class FormLoader
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub FormLoader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Enabled = True

        FormUser.FormUser_Load(sender, e)
        FormMobilTangki.FormMobilTangki_Load(sender, e)
        'FormHarian.FormHarian_Load(sender, e)
    End Sub
End Class