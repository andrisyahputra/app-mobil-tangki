Public Class FormMenu



    Public Sub clearMenu()
        btnTutup.Visible = False
        'PictureBox1.Visible = False

        lblTangki.Visible = False
        lblatas.Visible = False


        GroupBox1.Visible = False
        DataGridTranksaksi.Visible = False
        btnHapus.Visible = False
        btnClear.Visible = False
        BtnEdit.Visible = False
        BtnTambah.Visible = False
        LBLCARIDATA.Visible = False
        txtCari.Visible = False
        LBLCARIDATA.Visible = False
        Label9.Visible = False


    End Sub
    Public Sub tampilMenu()
        btnTutup.Visible = True
        'PictureBox1.Visible = True
        lblTangki.Visible = True
        lblatas.Visible = True


        GroupBox1.Visible = True
        DataGridTranksaksi.Visible = True
        btnHapus.Visible = True
        btnClear.Visible = True
        BtnEdit.Visible = True
        BtnTambah.Visible = True
        LBLCARIDATA.Visible = True
        txtCari.Visible = True
        LBLCARIDATA.Visible = True
        Label9.Visible = True


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

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        If lbl_level.Text = "Admin" Then
            btnUser.Visible = True
        ElseIf lbl_level.Text = "Operator" Then
            btnUser.Visible = False
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

    End Sub

    Private Sub BTNAMT_Click(sender As Object, e As EventArgs) Handles BTNAMT.Click
        clearMenu()
        switchPanel(FormTransaksi)
    End Sub

End Class