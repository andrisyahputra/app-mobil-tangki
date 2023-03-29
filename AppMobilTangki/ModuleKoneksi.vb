Imports MySql.Data.MySqlClient
Module ModuleKoneksi
    Public CONN As New MySqlConnection
    Public DA As New MySqlDataAdapter
    Public DS As New DataSet
    Public QUERY As String
    Public CMD As New MySqlCommand
    Public RD As MySqlDataReader

    Public Sub KoneksiKeDatabase()
        Try
            Dim str As String = "server=localhost;User Id=root;password=;Persist Security Info=True;database=app_mobil_tangki;Convert Zero Datetime=True"
            'Dim str As String = "Server=localhost;user id=root;database=app_mobil_tangki"
            CONN = New MySqlConnection(str)
            If CONN.State = ConnectionState.Closed Then
                Try
                    CONN.Open()
                    'MsgBox("Koneksi Ke server Berhasil")
                Catch ex As Exception
                    MsgBox("Koneksi Ke server Gagal")
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub

End Module
