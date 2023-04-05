Imports MySql.Data.MySqlClient

Public Class FormMenu
    Dim ImgInput As Bitmap
    Dim ImgEdit As Bitmap
    Dim ImgHapus As Bitmap
    Dim ImgClear As Bitmap
    Dim ImgTutup As Bitmap
    Dim imgBatal As Bitmap
    Dim imgSimpan As Bitmap
    Dim imgUpdate As Bitmap




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
        switchPanel(FormAMT)
    End Sub

    Private Sub kondisiawal()
        Try
            KosongkanData()

            txtJMHole2.Enabled = True
            txtJMHole1.Enabled = True
            'txtDATEJUkur.Enabled = True

            'txtId.ReadOnly = True
            'CBIDUnit.Enabled = False
            'CBIDKamar.Enabled = False
            'txtKTemen2.ReadOnly = True
            'txtKTemen1.ReadOnly = True
            'txtMTangki.Enabled = False
            'CBIDKamar.Enabled = False
            'txtPlatKendaraan.Enabled = False
            'DateKendaraan.Enabled = False
            'CBBayar.Enabled = False
            'DateBayar.Enabled = False
            'DateJTempo.Enabled = False
            'txtTanggal.Enabled = False
            'txtKasir.Enabled = False
            'txtJam.Enabled = False
            'DateJTempo.Enabled = False
            'txtTempo.Enabled = False
            'txtHargaSw.MaxLength = 20
            txtJMHole1.Focus()

            ImgInput = AppMobilTangki.My.Resources.Resources.save
            ImgEdit = AppMobilTangki.My.Resources.Resources.update
            ImgHapus = AppMobilTangki.My.Resources.Resources.sampah
            ImgClear = AppMobilTangki.My.Resources.Resources.clear
            imgBatal = AppMobilTangki.My.Resources.Resources.batal
            imgSimpan = AppMobilTangki.My.Resources.Resources.simpan
            imgUpdate = AppMobilTangki.My.Resources.Resources.edit

            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            BtnEdit.Text = "EDIT"
            BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnClear.Text = "CLEAR"
            btnClear.Image = ImgClear

            BtnTambah.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False


            KoneksiKeDatabase()
            QUERY = "Select * FROM tbl_transaksi order by id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "tbl_transaksi")
            DataGridTranksaksi.DataSource = DS.Tables("tbl_transaksi")

            With DataGridTranksaksi
                '    '.Columns(0).Width = 200
                '    .Columns(1).Width = 200
                '    .Columns(2).Width = 80
                '    .Columns(3).Width = 100
                '    .Columns(4).Width = 100
                '    .Columns(5).Width = 100
                '    .Columns(6).Width = 90
                '    .Columns(7).Width = 90
                '    .Columns(8).Width = 120

                '.Columns(0).DataPropertyName = "id"
                '.Columns(1).DataPropertyName = "nama_perusahaan"
                '.Columns(2).DataPropertyName = "no_plat_mobil"
                '.Columns(3).DataPropertyName = "mobil_tangki"
                '.Columns(4).DataPropertyName = "id_kompartemen1"
                '.Columns(5).DataPropertyName = "id_kompartemen2"
                '.Columns(6).DataPropertyName = "jrk_m_hole1"
                '.Columns(7).DataPropertyName = "jrk_m_hole2"
                '.Columns(8).DataPropertyName = "tgl_jam_ukur"


                .Columns(0).Visible = False

                .Columns(1).HeaderText = "No Plat Mobil"
                .Columns(2).HeaderText = "Jarak Meter Hole 1"
                .Columns(3).HeaderText = "Jarak Meter Hole 2"
                .Columns(4).HeaderText = "Tanggal Pengukuran"

                .Columns(5).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(8).Visible = False
                .Columns(9).Visible = False
                '.Columns(10).Visible = False
                '.Columns(11).HeaderText = "NIK AMT"
                '.Columns(12).HeaderText = "Nama AMT"
                '.Columns(13).HeaderText = "Tempat Lahir"
                '.Columns(14).HeaderText = "Tanggal Lahir"
                '.Columns(15).HeaderText = "USIA"
                '.Columns(16).HeaderText = "NIK AMT"
                '.Columns(17).HeaderText = "Nama AMT"
                '.Columns(18).HeaderText = "Tempat Lahir"
                '.Columns(19).HeaderText = "Tanggal Lahir"
                '.Columns(20).HeaderText = "USIA"
                '.Columns(21).HeaderText = "Transportir"

                '.Columns(0).Visible = False

                '.Columns(9).Visible = False
                '.Columns(10).Visible = False

                '.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '    .EnableHeadersVisualStyles = False
                '    '.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                '    '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                '    .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
                '    '.DefaultCellStyle.ForeColor = Color.DarkRed
                '    '.RowsDefaultCellStyle.BackColor = Color.PaleGreen
                '    '.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGreen
                '    '.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
                '    '.GridColor = Color.DarkRed
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        KoneksiKeDatabase()
        kondisiawal()
        Timer1.Start()

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


    Dim tglsekarang As Date
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = DateTime.Now.ToString()
        tglsekarang = Today
    End Sub

    Private Sub KosongkanData()
        txtCari.Text = ""
        txtJMHole1.Text = ""
        txtJMHole2.Text = ""
        'txtDATEJUkur.Text = ""
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            If txtJMHole1.Text = "" Or
                    txtJMHole2.Text = "" Then
                MsgBox("Silahkan Isi Semua Data")
            Else
                Call KoneksiKeDatabase()
                QUERY = "INSERT INTO tbl_transaksi values ('','" & lblIDPlat.Text & "','" & txtJMHole1.Text & "','" & txtJMHole2.Text & "','" & Format(tglsekarang, "yyyy-MM-dd") & "','-','-','-','-','-')"
                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS)

                Dim A As String = MsgBox("PRINT QRCODE...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "PRINT QRCODE")
                Select Case A
                    Case vbCancel
                        FormMenu_Load(sender, e)
                        MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                        Call KosongkanData()
                        Exit Sub
                    Case vbOK
                        MsgBox("Print QRCODE")
                        'FormMenu.clearMenu()

                        'FormMenu.switchPanel(FormQRCODE)
                        'AmbilDatakeTransakasi()
                        'Me.Close()
                End Select


                FormMenu_Load(sender, e)
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox("Gagal Di tambah")
        End Try
    End Sub

    'Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
    '    If btnClear.Text = "BATAL" Then
    '        FormMenu_Load(sender, e)
    '        Call KosongkanData()
    '        Exit Sub
    '    End If
    '    If btnClear.Text = "CLEAR" Then
    '        txtJMHole1.Text = ""
    '        txtJMHole2.Text = ""
    '        txtJMHole1.Focus()
    '        Exit Sub
    '    End If
    'End Sub
End Class