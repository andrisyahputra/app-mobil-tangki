Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub btnMTangki_Click(sender As Object, e As EventArgs) Handles btnMTangki.Click
        Try

            If Not txtUsername.Text.Length >= 5 Or Not txtPassword.Text.Length >= 5 Then
                MessageBox.Show("Username atau Password Minimal 5 huruf atau angka")
            ElseIf txtPassword.Text = "" Or txtUsername.Text = "" Then
                MessageBox.Show("Username atau Password Masih Kosong")
            Else
                Call KoneksiKeDatabase()
                CMD = New MySqlCommand("select * from tbl_user where user_name='" & txtUsername.Text & "' and pwd='" & txtPassword.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    FormMenu.lbl_level.Text = RD.Item("lvl")
                    FormMenu.lblNLengkap.Text = RD.Item("nama_lengkap")
                    Me.Hide()
                    FormMenu.Show()
                Else
                    MsgBox("Password atau Username Salah!!", MsgBoxStyle.Critical, "GAGAL LOGIN!!")
                End If
            End If
        Catch ex As Exception
            MsgBox("Gagal Login")
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUsername.CharacterCasing = CharacterCasing.Lower
        txtPassword.CharacterCasing = CharacterCasing.Lower
    End Sub
End Class