Imports MySql.Data.MySqlClient
Public Class FormMobilTangki
    Dim ImgInput As Bitmap
    Dim ImgEdit As Bitmap
    Dim ImgHapus As Bitmap
    Dim ImgClear As Bitmap
    Dim ImgTutup As Bitmap
    Dim imgBatal As Bitmap
    Dim imgSimpan As Bitmap
    Dim imgUpdate As Bitmap
    Dim dataId%

    'Private Sub PosisiList()
    '    With LvMTangki.Columns
    '        '.Add("ID", 0)
    '        '.Add("NAMA PERUSAHAAN", 200)
    '        '.Add("MOBIL TANGKI", 170)
    '        '.Add("KOMPERTEMEN1", 170)
    '        '.Add("KOMPERTEMEN2", 170)
    '        '.Add("NO PLAT MOBIL", 170)
    '        '.Add("ID KENDARAAN", 100)
    '        '.Add("TGL KENDARAAN", 110)
    '        '.Add("TGL BAYAR", 100)
    '        '.Add("TGL JATUH TEMPO", 120)
    '        '.Add("TEMPO", 70)
    '        '.Add("PEMBAYARAN", 100)
    '        '.Add("HARGA", 60)
    '        '.Add("KASIR", 100)
    '    End With
    '    'LvMTangki.BackColor = Co

    'End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            If txtNPerusahaan.Text = "" Or
                    txtPlatKendaraan.Text = "" Or
                    txtMTangki.Text = "" Or
                    txtKTemen2.Text = "" Or
                    txtKTemen1.Text = "" Then
                MsgBox("Silahkan Isi Semua Data")
            Else
                Call KoneksiKeDatabase()
                QUERY = "INSERT INTO tbl_mobil_tangki values ('','" & txtNPerusahaan.Text & "','" & txtMTangki.Text & "','" & txtKTemen1.Text & "','" & txtKTemen2.Text & "','" & txtPlatKendaraan.Text & "','-','-','-','-','-')"
                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS)

                'LvMTangki.Clear()
                FormMobilTangki_Load(sender, e)
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox("Gagal ")
        End Try

    End Sub

    Public Sub FormMobilTangki_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Timer1.Start()
        'comboBoxIDUnit()
        'LvMTangki.Clear()
        KoneksiKeDatabase()
        kondisiawal()
        'PosisiList()
    End Sub
    Private Sub kondisiawal()
        'Dim a As Integer
        Try
            KosongkanData()

            txtNPerusahaan.Enabled = True
            txtPlatKendaraan.Enabled = True
            txtMTangki.Enabled = True
            txtKTemen2.Enabled = True
            txtKTemen1.Enabled = True

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
            txtNPerusahaan.Focus()

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

            'KoneksiKeDatabase()
            'QUERY = "Select * FROM mt ORDER BY id"
            'DA = New MySqlDataAdapter(QUERY, CONN)
            'DS = New DataSet
            'DA.Fill(DS)
            'LvMTangki.Items.Clear()
            'For a = 0 To DS.Tables(0).Rows.Count - 1
            '    With LvMTangki
            '        '.Items.Add(DS.Tables(0).Rows(a).Item(0))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(1))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(2))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(3))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(4))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(5))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(5))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(6))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(7))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(8))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(9))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(10))
            '        '.Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(11))
            '    End With


            'Next

            'Try

            QUERY = "Select * FROM mt ORDER BY id"
                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS, "mt")
                DataGridView1.DataSource = DS.Tables("mt")

            With DataGridView1
                '    '.Columns(1).Width = 200
                '    '.Columns(2).Width = 120
                '    '.Columns(3).Width = 100
                '    '.Columns(4).Width = 150
                '    '.Columns(5).Width = 150
                '    '.Columns(6).Width = 100
                '    '.Columns(7).Width = 100
                '    '.Columns(8).Width = 80
                '    ''.Columns(9).Width = 150


                '    '.Columns(0).DataPropertyName = "id"
                '    '.Columns(1).DataPropertyName = "nama_lengkap"
                '    '.Columns(2).DataPropertyName = "jenis_kelamin"
                '    '.Columns(3).DataPropertyName = "no_hp"
                '    '.Columns(4).DataPropertyName = "alamat"
                '    '.Columns(5).DataPropertyName = "tanggal_lahir"
                '    '.Columns(6).DataPropertyName = "user_name"
                '    '.Columns(7).DataPropertyName = "pwd"
                '    '.Columns(8).DataPropertyName = "lvl"
                '    '.Columns(9).DataPropertyName = "c"

                '    '.Columns(1).HeaderText = "NAMA LENGKAP"
                '    '.Columns(2).HeaderText = "JENIS KELAMIN"
                '    '.Columns(3).HeaderText = "NOMOR HP"
                '    '.Columns(4).HeaderText = "ALAMAT"
                '    '.Columns(5).HeaderText = "TANGGAL LAHIR"
                '    '.Columns(6).HeaderText = "USERNAME"
                '    '.Columns(7).HeaderText = "PASSWORD"
                '    '.Columns(8).HeaderText = "LEVEL"

                '    '.Columns(0).Visible = False
                '    '.Columns(9).Visible = False

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .EnableHeadersVisualStyles = False
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)

                .RowsDefaultCellStyle.BackColor = Color.Crimson
                .DefaultCellStyle.ForeColor = Color.DarkRed
                .RowsDefaultCellStyle.BackColor = Color.SkyBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
                .GridColor = Color.DarkRed

            End With

            'Catch ex As Exception
            '    MsgBox(ex.Message, "EROR")
            'End Try

            'MsgBox("database berhasil di tampil")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub KosongkanData()
        txtCari.Text = ""
        txtKTemen1.Text = ""
        txtKTemen2.Text = ""
        txtPlatKendaraan.Text = ""
        txtMTangki.Text = ""
        txtNPerusahaan.Text = ""
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        Call FormMenu.tampilMenu()
        'FormMenu.FormMenu_Load(sender, e)
    End Sub
    Private Sub AmbilDatakeTransakasi()
        'With LvMTangki.SelectedItems
        '    BtnEdit.Text = "EDIT"
        '    btnHapus.Text = "HAPUS"
        '    BtnEdit.Image = ImgEdit
        '    BtnEdit.Enabled = True
        '    btnHapus.Enabled = True
        '    BtnTambah.Enabled = False
        '    FormTransaksi.lblIDPlat.Text = .Item(0).SubItems(5).Text
        'End With

    End Sub

    'Private Sub LvMTangki_DoubleClick(sender As Object, e As EventArgs) Handles LvMTangki.DoubleClick
    '    Dim A As String = MsgBox("Tambah Transaksi...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "TRANKSAKSI")
    '    Select Case A
    '        Case vbCancel
    '            LvMTangki.Clear()
    '            FormMobilTangki_Load(sender, e)
    '            Call KosongkanData()
    '            Exit Sub
    '        Case vbOK
    '            FormMenu.clearMenu()
    '            FormMenu.switchPanel(FormTransaksi)
    '            AmbilDatakeTransakasi()
    '            Me.Close()
    '    End Select
    'End Sub
    Private Sub fieldaftif()
        txtNPerusahaan.Enabled = True
        txtPlatKendaraan.Enabled = True
        txtMTangki.Enabled = True
        txtKTemen2.Enabled = True
        txtKTemen1.Enabled = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try

            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = True
                btnHapus.Text = "BATAL"
                btnHapus.Image = imgBatal
                BtnTambah.Enabled = False
                btnClear.Text = "CLEAR"
                btnClear.Image = ImgClear
                fieldaftif()
            Else
                Call KoneksiKeDatabase()
                QUERY = "UPDATE tbl_mobil_tangki SET nama_perusahaan='" & txtNPerusahaan.Text & "',mobil_tangki='" & txtMTangki.Text & "',id_kompartemen1='" & txtKTemen1.Text & "',id_kompartemen2='" & txtKTemen2.Text & "',no_plat_mobil='" & txtPlatKendaraan.Text & "',a='-',b='-',c='-',d='-',e='-'where id='" & dataId & "'"
                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS)

                MsgBox("Edit data berhasil")

                    Call kondisiawal()
                'LvMTangki.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("PLAT NOMOR SUDAH TERSEDIA")
        End Try
    End Sub
    Private Sub ambiledithapus()
        'With LvMTangki.SelectedItems
        'BtnEdit.Text = "EDIT"
        '    btnHapus.Text = "HAPUS"
        '    BtnEdit.Image = ImgEdit
        '    btnClear.Text = "BATAL"
        '    btnClear.Image = imgBatal
        '    BtnEdit.Enabled = True
        '    btnHapus.Enabled = True
        '    BtnTambah.Enabled = False
        '    btnClear.Enabled = True

        '    txtNPerusahaan.Enabled = False
        '    txtPlatKendaraan.Enabled = False
        '    txtMTangki.Enabled = False
        '    txtKTemen2.Enabled = False
        '    txtKTemen1.Enabled = False

        '    dataId = .Item(0).SubItems(0).Text
        '    txtNPerusahaan.Text = .Item(0).SubItems(1).Text
        '    txtMTangki.Text = .Item(0).SubItems(2).Text
        '    txtPlatKendaraan.Text = .Item(0).SubItems(5).Text
        '    txtKTemen1.Text = .Item(0).SubItems(3).Text
        '    txtKTemen2.Text = .Item(0).SubItems(4).Text
        'End With
    End Sub


    Private Sub LvMTangki_Click(sender As Object, e As EventArgs)
        ambiledithapus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            'LvMTangki.Clear()
            FormMobilTangki_Load(sender, e)
            Call KosongkanData()
            Exit Sub
        End If
        If btnClear.Text = "CLEAR" Then
            txtNPerusahaan.Text = ""
            txtPlatKendaraan.Text = ""
            txtMTangki.Text = ""
            txtKTemen2.Text = ""
            txtKTemen1.Text = ""
            txtNPerusahaan.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            'LvMTangki.Clear()
            FormMobilTangki_Load(sender, e)
            Call KosongkanData()
            Exit Sub
        End If


        Try
            If btnHapus.Text = "HAPUS" Then
                Dim A As String
                A = MsgBox("Benar DIHAPUS...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
                Select Case A
                    Case vbCancel
                        'LvMTangki.Clear()
                        FormMobilTangki_Load(sender, e)
                        Call KosongkanData()
                        MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
                        Exit Sub
                    Case vbOK
                        Call KoneksiKeDatabase()
                        QUERY = "delete from tbl_mobil_tangki where id='" & dataId & "'"
                        CMD = New MySqlCommand(QUERY, CONN)
                        CMD.ExecuteNonQuery()
                        'LvMTangki.Clear()
                        FormMobilTangki_Load(sender, e)
                        Call KosongkanData()
                        MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
                End Select
            End If

        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub
    Private Sub Caridata()
        'Try
        '    KoneksiKeDatabase()
        '    QUERY = "SELECT * FROM tbl_mobil_tangki WHERE nama_perusahaan LIKE '%" & Trim(txtCari.Text) & "%' OR mobil_tangki LIKE '%" & Trim(txtCari.Text) & "%'"
        '    DA = New MySqlDataAdapter(QUERY, CONN)
        '    DS = New DataSet
        '    DA.Fill(DS)
        '    LvMTangki.Items.Clear()
        '    For a = 0 To DS.Tables(0).Rows.Count - 1
        '        With LvMTangki
        '            .Items.Add(DS.Tables(0).Rows(a).Item(0))
        '            .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(1))
        '            .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(2))
        '            .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(3))
        '            .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(4))
        '            .Items(a).SubItems.Add(DS.Tables(0).Rows(a).Item(5))
        '        End With
        '    Next
        'Catch ex As Exception
        '    MsgBox("Data tidak di temukan")
        'End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        Caridata()
    End Sub
End Class