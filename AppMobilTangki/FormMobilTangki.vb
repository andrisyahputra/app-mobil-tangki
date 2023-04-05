Imports System.Globalization
Imports System.Threading
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
        'posisilv()
        'Timer1.Start()
        'comboBoxIDUnit()
        'LvMTangki.Clear()
        KoneksiKeDatabase()
        'PosisiList()
        'isiList()
        kondisiawal()
        'SpinerCircle1.Visible = False

        'Control.CheckForIllegalCrossThreadCalls = False
        'PosisiList()
    End Sub
    Private Sub kondisiawal()
        'Dim a As Integer
        Try

            QUERY = "Select * FROM mt ORDER BY id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "mt")
            DTGridMT.DataSource = DS.Tables("mt")

            'DateTime dt1 = Convert.ToDateTime(DTGridMT.Rows[i].Cells["Date"].Value);

            With DTGridMT
                '.Columns(1).Width = 200
                '.Columns(2).Width = 120
                '.Columns(3).Width = 100
                '.Columns(4).Width = 150
                '.Columns(5).Width = 150
                '.Columns(6).Width = 100
                '.Columns(7).Width = 100
                '.Columns(8).Width = 80
                '.Columns(9).Width = 150


                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "no_urut"
                .Columns(2).DataPropertyName = "kode_rfid"
                .Columns(3).DataPropertyName = "no_polis"
                .Columns(4).DataPropertyName = "ket_blokir"
                .Columns(5).DataPropertyName = "title"
                .Columns(6).DataPropertyName = "nama_perusahaan"
                .Columns(7).DataPropertyName = "sts"
                .Columns(8).DataPropertyName = "merk_type"
                .Columns(9).DataPropertyName = "model"
                .Columns(10).DataPropertyName = "thn_pembuatan"
                .Columns(11).DataPropertyName = "kapasitas"
                .Columns(12).DataPropertyName = "kompartemen"
                .Columns(13).DataPropertyName = "produk"
                .Columns(14).DataPropertyName = "no_mesin"
                .Columns(15).DataPropertyName = "no_rangka"
                .Columns(16).DataPropertyName = "hsl_uji_emisi"
                .Columns(17).DataPropertyName = "pas_masuk"
                .Columns(18).DataPropertyName = "stnk"
                .Columns(19).DataPropertyName = "keur"
                .Columns(20).DataPropertyName = "tera"
                .Columns(21).DataPropertyName = "ijin_brg_khusus"
                .Columns(22).DataPropertyName = "skt"
                .Columns(23).DataPropertyName = "no_pas"
                .Columns(24).DataPropertyName = "status2"
                .Columns(25).DataPropertyName = "ksong"
                .Columns(26).DataPropertyName = "keterangan"
                .Columns(27).DataPropertyName = "tgl_penerima"
                .Columns(28).DataPropertyName = "no_surat_tera"
                .Columns(29).DataPropertyName = "komp1_t1"
                .Columns(30).DataPropertyName = "komp1_t2"
                .Columns(31).DataPropertyName = "komp1_t3"
                .Columns(32).DataPropertyName = "komp1_ruang_ksg"
                .Columns(33).DataPropertyName = "komp1_k1"
                .Columns(34).DataPropertyName = "komp2_t1"
                .Columns(35).DataPropertyName = "komp2_t2"
                .Columns(36).DataPropertyName = "komp2_t3"
                .Columns(37).DataPropertyName = "komp2_ruang_ksg"
                .Columns(38).DataPropertyName = "komp2_k1"
                .Columns(39).DataPropertyName = "tera2"
                .Columns(40).DataPropertyName = "thn_pembuatan2"
                .Columns(41).DataPropertyName = "no_stnk"
                .Columns(42).DataPropertyName = "m_berlaku_stnk"
                .Columns(43).DataPropertyName = "no_keur"
                .Columns(44).DataPropertyName = "m_berlaku_kier"
                .Columns(45).DataPropertyName = "no_dok_uji_emisi"
                .Columns(46).DataPropertyName = "hasil_uji_emisi"
                .Columns(47).DataPropertyName = "m_berlaku_uji_emisi"
                .Columns(48).DataPropertyName = "no_spb_skt"
                .Columns(49).DataPropertyName = "m_berlaku_spb_mkt"
                .Columns(50).DataPropertyName = "no_z_m_terminal_bbm"
                .Columns(51).DataPropertyName = "no_izin_masuk"
                .Columns(52).DataPropertyName = "kode_area"
                .Columns(53).DataPropertyName = "area"
                .Columns(54).DataPropertyName = "kd_lokasi"
                .Columns(55).DataPropertyName = "lokasi"
                .Columns(56).DataPropertyName = "kd_kategori"
                .Columns(57).DataPropertyName = "kategori"
                .Columns(58).DataPropertyName = "delivery_point"
                .Columns(59).DataPropertyName = "sewa"
                .Columns(60).DataPropertyName = "tarif"
                .Columns(61).DataPropertyName = "agen"
                .Columns(62).DataPropertyName = "industri"
                .Columns(63).DataPropertyName = "angkutan_sendiri"
                .Columns(64).DataPropertyName = "umur"
                .Columns(65).DataPropertyName = "kat"
                .Columns(66).DataPropertyName = "produk2"
                .Columns(67).DataPropertyName = "engkel_tronton_semit"
                .Columns(68).DataPropertyName = "pabrikan_tangki"
                .Columns(69).DataPropertyName = "material_tangki"
                .Columns(70).DataPropertyName = "pembuatan_tangki"
                .Columns(71).DataPropertyName = "sts_armada"
                .Columns(72).DataPropertyName = "plat"
                .Columns(73).DataPropertyName = "asuransi"
                .Columns(74).DataPropertyName = "alamat"
                .Columns(75).DataPropertyName = "telepon"
                .Columns(76).DataPropertyName = "email"
                .Columns(77).DataPropertyName = "npwp"
                .Columns(78).DataPropertyName = "penanggung_jawab"
                .Columns(79).DataPropertyName = "jabatan"
                .Columns(80).DataPropertyName = "data_umur_mt"


                .Columns(0).Visible = False
                .Columns(1).HeaderText = "No. Urute"
                .Columns(2).HeaderText = "KODE RFID"
                .Columns(3).HeaderText = "Nomor Polisi"
                .Columns(4).HeaderText = "KETERANGAN BLOKIR"
                .Columns(5).HeaderText = "Title"
                .Columns(6).HeaderText = "Nama Perusahaan"
                .Columns(7).HeaderText = "Status"
                .Columns(8).HeaderText = "Merk / Type"
                .Columns(9).HeaderText = "Model"
                .Columns(10).HeaderText = "Thn Pembuatan"
                .Columns(11).HeaderText = "Kapasitas"
                .Columns(12).HeaderText = "Kompartemen"
                .Columns(13).HeaderText = "Produk"
                .Columns(14).HeaderText = "Nomor Mesin"
                .Columns(15).HeaderText = "Nomor Rangka"
                .Columns(16).HeaderText = "Hasil Uji Emisi %"
                .Columns(17).HeaderText = "Pas Masuk"
                .Columns(18).HeaderText = "STNK"
                .Columns(19).HeaderText = "KEUR"
                .Columns(20).HeaderText = "TERA"
                .Columns(21).HeaderText = "IJIN BARANG KHUSUS"
                .Columns(22).HeaderText = "SKT"
                .Columns(23).HeaderText = "No Pas"
                .Columns(24).HeaderText = "STATUS"
                .Columns(25).Visible = False
                .Columns(26).HeaderText = "Keterangan"
                .Columns(27).HeaderText = "TANGGAL PENERIMAAN"
                .Columns(28).HeaderText = "NOMOR SURAT TERA"
                .Columns(29).HeaderText = "T1"
                .Columns(30).HeaderText = "T2"
                .Columns(31).HeaderText = "T3"
                .Columns(32).HeaderText = "Ruang kosong(ltr)"
                .Columns(33).HeaderText = "Kl (mm/ltr)"
                .Columns(34).HeaderText = "T1"
                .Columns(35).HeaderText = "T2"
                .Columns(36).HeaderText = "T3"
                .Columns(37).HeaderText = "Ruang kosong(ltr)"
                .Columns(38).HeaderText = "Kl (mm/ltr)"
                .Columns(39).HeaderText = "TERA"
                .Columns(40).HeaderText = "Th. Pembuatan"
                .Columns(41).HeaderText = "No. STNK"
                .Columns(42).HeaderText = "Masa Berlaku STNK"
                .Columns(43).HeaderText = "No. Keur"
                .Columns(44).HeaderText = "Masa Berlaku Kier"
                .Columns(45).HeaderText = "No. Dok. Uji Emisi"
                .Columns(46).HeaderText = "Hasil Uji Emisi"
                .Columns(47).HeaderText = "Masa Berlaku Uji Emisi"
                .Columns(48).HeaderText = "No. SPB/SKT"
                .Columns(49).HeaderText = "Masa Berlaku SPB/SKT"
                .Columns(50).HeaderText = "No. Izin Prinsip Masuk Terminal BBM"
                .Columns(51).HeaderText = "No. Izin Masuk"
                .Columns(52).HeaderText = "Kode Area"
                .Columns(53).HeaderText = "Area"
                .Columns(54).HeaderText = "Kode Lokasi"
                .Columns(55).HeaderText = "Lokasi"
                .Columns(56).HeaderText = "Kode Kategori"
                .Columns(57).HeaderText = "Kategori"
                .Columns(58).HeaderText = "DELIVERY POINT"
                .Columns(59).HeaderText = "SEWA"
                .Columns(60).HeaderText = "TARIF"
                .Columns(61).HeaderText = "AGEN"
                .Columns(62).HeaderText = "INDUSTRI"
                .Columns(63).HeaderText = "ANGKUTAN SENDIRI"
                .Columns(64).HeaderText = "UMUR"
                .Columns(65).HeaderText = "KAT"
                .Columns(66).HeaderText = "PRODUK"
                .Columns(67).HeaderText = "(ENGKEL/TRONTON/SEMI TRAILER)"
                .Columns(68).HeaderText = "PABRIKAN TANGKI"
                .Columns(69).HeaderText = "MATERIAL TANGKI MS/CARBON/AL"
                .Columns(70).HeaderText = "PEMBUATAN TANGKI TGL/BLN/TH"
                .Columns(71).HeaderText = "STATUS ARMADA"
                .Columns(72).HeaderText = "Plat"
                .Columns(73).HeaderText = "ASURANSI"
                .Columns(74).HeaderText = "ALAMAT"
                .Columns(75).HeaderText = "TELEPON"
                .Columns(76).HeaderText = "EMAIL"
                .Columns(77).HeaderText = "NPWP"
                .Columns(78).HeaderText = "PENANGGUNG JAWAB"
                .Columns(79).HeaderText = "JABATAN"
                .Columns(80).HeaderText = "Data Umur MT"




                .Columns(9).DefaultCellStyle.Format = "yyyy-MM-dd"



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

            'MsgBox("database berhasil di tampil")
            KosongkanData()

            txtNPerusahaan.Enabled = True
            txtPlatKendaraan.Enabled = True
            txtMTangki.Enabled = True
            txtKTemen2.Enabled = True
            txtKTemen1.Enabled = True

            btnUploud.Enabled = False

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

    Private Function saveData(sql As String)
        Dim CONN As MySqlConnection = New MySqlConnection("server=localhost;User Id=root;password=;Persist Security Info=True;database=app_mobil_tangki;Convert Zero Datetime=True")
        Dim mysqlcmd As MySqlCommand
        Dim mysqlresult As Boolean

        Try
            CONN.Open()
            mysqlcmd = New MySqlCommand
            With mysqlcmd
                .Connection = CONN
                .CommandText = sql
                mysqlresult = .ExecuteNonQuery
            End With
            'KoneksiKeDatabase()
            'kondisiawal()
            'FormMobilTangki_Load(Me, e)
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            CONN.Close()

        End Try
        Return mysqlresult

    End Function

    Dim lokasifile As String


    Private Sub BTNEXCEL_Click(sender As Object, e As EventArgs) Handles BTNEXCEL.Click
        Dim exMessage As Integer = MessageBox.Show("Data Excel Harus Tutup", "Notfikasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If exMessage = DialogResult.Yes Then
            'MessageBox.Show("User Select Yes")
            Dim ofd As New OpenFileDialog
            'Dim con As OleDb.OleDbConnection
            'Dim cmd As New OleDb.OleDbCommand


            Try
                With ofd
                    .Filter = "Excel Files(*.xlsx)|*.xlsx| All files(*.*)|*.*"
                    .FilterIndex = 1
                    .Title = "Import data from excel file"
                End With
                If ofd.ShowDialog() = DialogResult.OK Then

                    lokasifile = ofd.FileName
                    'BackgroundWorker1.RunWorkerAsync()

                    'con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
                    'con.Open()
                    'With cmd
                    '    .Connection = con
                    '    .CommandText = "SELECT * FROM [mt$a3:cb]"
                    'End With


                    'da.SelectCommand = cmd
                    'Dim dt As New DataTable
                    'da.Fill(dt)
                    ''DTGridMT.DataSource = dt


                    'con.Close()

                    Dim con As OleDb.OleDbConnection

                    con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
                    'If filepath.EndsWith(".xls") Then
                    '    connstring =
                    'End If
                    Dim cmd As New OleDb.OleDbDataAdapter("Select * from [mt$a3:cb]", con)
                    cmd.TableMappings.Add("Table", "Table")
                    Dim dt As New DataSet
                    cmd.Fill(dt)
                    DTGridMT.DataSource = dt.Tables(0)
                    'con.Close()
                    btnUploud.Enabled = True
                Else


                End If
            Catch ex As Exception
                MessageBox.Show("Sheet Pada Excel Harus MT", "EROR")
            End Try

        ElseIf exMessage = DialogResult.No Then
            'MessageBox.Show("User Select No")
            Exit Sub
        End If


    End Sub

    'Public Sub LoadData(dgv As DataGridView)
    '    Try
    '        Dim con As OleDb.OleDbConnection
    '        Dim cmd As New OleDb.OleDbCommand
    '        Dim rd As OleDb.OleDbDataReader
    '        Dim da As New OleDb.OleDbDataAdapter
    '        'Dim dt As DataTable

    '        If dgv.InvokeRequired Then
    '            dgv.Invoke(Sub() dgv.Rows.Clear())
    '        Else
    '            dgv.Rows.Clear()
    '        End If



    '        'Call KoneksiKeDatabase()
    '        'QUERY = "DELETE FROM `tbl_employee`"
    '        'CMD = New MySqlCommand(QUERY, CONN)
    '        'Dim i As Integer
    '        'RD = CMD.ExecuteReader
    '        KoneksiKeDatabase()

    '        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
    '        con.Open()
    '        With cmd
    '            .Connection = con
    '            .CommandText = "SELECT * FROM [Sheet1$]"
    '            '.CommandText = "SELECT * FROM [mt$a3:cb]"
    '        End With


    '        da.SelectCommand = cmd
    '        Dim i As Integer

    '        rd = cmd.ExecuteReader
    '        Dim dt As New DataTable
    '        DA.Fill(dt)
    '        'DTGridMT.DataSource = dt


    '        con.Close()


    '        While RD.Read
    '            i += 1
    '            If dgv.InvokeRequired Then
    '                dgv.Invoke(Sub()
    '                               DTGridMT.Rows.Add(i, rd(1), rd(2)) 'i  use no
    '                               DTGridMT.ClearSelection()
    '                           End Sub)
    '            End If
    '            Thread.Sleep(500)



    '        End While

    '        If SpinerCircle1.InvokeRequired Then
    '            SpinerCircle1.Invoke(Sub()
    '                                     SpinerCircle1.Visible = False
    '                                 End Sub)
    '        Else
    '            SpinerCircle1.Visible = True
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub



    Private Sub btnUploud_Click(sender As Object, e As EventArgs) Handles btnUploud.Click
        'Try
        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
            Dim cmd1 As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            Dim result As Boolean
            Dim sql As String

            Call KoneksiKeDatabase()
        QUERY = "DELETE FROM `amt`"
        CMD = New MySqlCommand(QUERY, CONN)
            CMD.ExecuteNonQuery()


            With cmd1
                .Connection = con
                .CommandText = "Select * FROM [mt$a3:cb]"
            End With

            da.SelectCommand = cmd1
            da.Fill(dt)



            For Each r As DataRow In dt.Rows




                'Dim iDate As Date = r(9).ToString



                'If iDate.ToLongDateString Is DBNull.Value Then
                '    txtIssuedDate.Text = String.Empty
                'Else
                '    txtIssuedDate.Text = CType(FormatString(.Item("IssuedDate")).Trim, Date)
                'End If



                'Dim iDate1 As Date = r(9).ToString
                'Dim iDate As Dat 'output

                'If r(9) Is DBNull.Value Then
                '    iDate = String.Empty
                'Else
                '    iDate = iDate1.ToString("yyyy-MM-dd")
                'End If

                'Dim myDate As Date = r(9).ToString()


                'Dim iDate As String = r(9).ToString
                'Dim oDate As DateTime = Convert.ToDateTime(iDate)

                'Dim iDate

                'Dim myDate As DateTime = r(9).ToString("yyyy-MM-dd")

                'If r(9) Is " " Then
                '    myDate = Convert.ToString(DBNull.Value)
                'Else
                '    myDate = myDate.ToString("yyyy-MM-dd")
                'End If

                'Dim dateValue As Date
                'Dim dbNullValue As Object = DBNull.Value 'nul


                'If r(9) Is " " Then
                '    dateValue = Nothing
                'Else
                '    dateValue = r(9)
                'End If

                'Dim dateValue As Date

                'If Convert.IsDBNull(r(9)) Then
                '    dateValue = Nothing
                'Else
                '    dateValue = CType(r(9), Date)
                'End If

                'Dim datemasuk As Date

                'If Convert.IsDBNull(r(16)) Then
                '    datemasuk = Nothing
                'Else
                '    datemasuk = CType(r(16), Date)
                'End If

                Dim dateValue As Date = If(Convert.IsDBNull(r(9)), Nothing, CType(r(9), Date))
                Dim datemasuk As Date = If(Convert.IsDBNull(r(16)), Nothing, CType(r(16), Date))
                Dim datestnk As Date = If(Convert.IsDBNull(r(17)), Nothing, CType(r(17), Date))
                Dim datekeur As Date = If(Convert.IsDBNull(r(18)), Nothing, CType(r(18), Date))
                Dim datetera As Date = If(Convert.IsDBNull(r(19)), Nothing, CType(r(19), Date))
                Dim dateskt As Date = If(Convert.IsDBNull(r(21)), Nothing, CType(r(21), Date))
                Dim datetera2 As Date = If(Convert.IsDBNull(r(38)), Nothing, CType(r(38), Date))
            'Dim thbuatan2 As Date = If(Convert.IsDBNull(r(39)), Nothing, CType(r(39), Date))
            Dim datemlakustnk As Date = If(Convert.IsDBNull(r(41)), Nothing, CType(r(41), Date))
                Dim datemlakukier As Date = If(Convert.IsDBNull(r(43)), Nothing, CType(r(43), Date))
                Dim datemlakuemisi As Date = If(Convert.IsDBNull(r(46)), Nothing, CType(r(46), Date))



            'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & myDate.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"
            sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & dateValue.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & datemasuk.ToString("yyyy-MM-dd") & "','" & datestnk.ToString("yyyy-MM-dd") & "','" & datekeur.ToString("yyyy-MM-dd") & "','" & datetera.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & dateskt.ToString("yyyy-MM-dd") & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString() & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & datetera2.ToString("yyyy-MM-dd") & "','" & r(39).ToString & "','" & r(40).ToString & "','" & datemlakustnk.ToString("yyyy-MM-dd") & "','" & r(42).ToString & "','" & datemlakukier.ToString("yyyy-MM-dd") & "','" & r(44).ToString & "','" & r(45).ToString & "','" & datemlakuemisi.ToString("yyyy-MM-dd") & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"
            'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & Convert.ToDateTime(iDate) & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"


            result = saveData(sql)
                If result Then
                    Timer1.Start()
                End If
            Next

            'FormMobilTangki_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Dim counter As Integer = 0

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try
            'Dim filepath As String = TXTLOCATION.Text
            'Dim connstring As String = String.Empty
            Dim con As OleDb.OleDbConnection

            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
            'If filepath.EndsWith(".xls") Then
            '    connstring =
            'End If
            Dim cmd As New OleDb.OleDbDataAdapter("Select * from [mt$a3:cb]", con)
            cmd.TableMappings.Add("Table", "Table")
            Dim dt As New DataSet
            cmd.Fill(dt)
            DTGridMT.DataSource = dt.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'lblloader.Text = "Imported    " & e.ProgressPercentage.ToString() & "    of    "
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class