Imports System.IO
Public Class FormMenu



    Public Sub clearMenu()
        btnTutup.Visible = False
        PictureBox1.Visible = False
        lblTangki.Visible = False
        lblatas.Visible = False
    End Sub
    Public Sub tampilMenu()
        btnTutup.Visible = True
        PictureBox1.Visible = True
        lblTangki.Visible = True
        lblatas.Visible = True

    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        PanelMenu.Controls.Clear()
        'btnTutup.Visible = False
        panel.TopLevel = False
        PanelMenu.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ''PanelAkses.Visible = False
        ''FormUnit.ShowDialog()
        'FormHistory.FormHistory_Load(sender, e)
        'FormHistory.btnTutup_Click(sender, e)
        clearMenu()
        switchPanel(FormLaporan)
    End Sub
    Private Sub btnMTangki_Click(sender As Object, e As EventArgs) Handles btnMTangki.Click
        'PanelAkses.Visible = False
        clearMenu()
        FormMobilTangki.FormMobilTangki_Load(sender, e)

        switchPanel(FormMobilTangki)
    End Sub
    Public Shared gambar() As Byte
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Dim ms As New MemoryStream(gambar)
            ptProfil.Image = Image.FromStream(ms)
            ptProfil.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception

        End Try

        If lbl_level.Text = "Admin" Then
            btnUser.Visible = True
            'tampilgambar()
        ElseIf lbl_level.Text = "Operator" Then
            btnUser.Visible = False
            'tampilgambar()
        Else
            Me.Close()
            FormLogin.Show()
            MessageBox.Show("Bukan Kasir dan Admin !!!")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        FormLogin.Show()
        FormLogin.txtPassword.Text = ""
        FormLogin.txtUsername.Text = ""
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        clearMenu()
        switchPanel(FormUser)
        For i = 0 To FormUser.DataGridView1.Rows.Count - 1
            Dim r As DataGridViewRow = FormUser.DataGridView1.Rows(i)
            r.Height = 70
        Next
    End Sub
    'Private Sub tampilgambar()

    '    Call KoneksiKeDatabase()
    '    QUERY = "SELECT * FROM tbl_user WHERE id like '" & lbl_user.Text & "'"
    '    CMD = New MySqlCommand(QUERY, CONN)
    '    RD = CMD.ExecuteReader
    '    RD.Read()
    '    Try
    '        Dim gambar() As Byte
    '        If RD.HasRows() Then
    '            gambar = RD("foto")

    '            Dim ms As New MemoryStream(gambar)
    '            ptProfil.Image = Image.FromStream(ms)
    '            ptProfil.SizeMode = PictureBoxSizeMode.StretchImage
    '        End If
    '        RD.Close()
    '    Catch ex As Exception
    '        MessageBox.Show("EROR : " & ex.Message, "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class