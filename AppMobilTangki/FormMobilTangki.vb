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


                '.Columns(0).DataPropertyName = "id"
                '.Columns(1).DataPropertyName = "nama_lengkap"
                '.Columns(2).DataPropertyName = "jenis_kelamin"
                '.Columns(3).DataPropertyName = "no_hp"
                '.Columns(4).DataPropertyName = "alamat"
                '.Columns(5).DataPropertyName = "tanggal_lahir"
                '.Columns(6).DataPropertyName = "user_name"
                '.Columns(7).DataPropertyName = "pwd"
                '.Columns(8).DataPropertyName = "lvl"
                '.Columns(9).DataPropertyName = "c"


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
                .Columns(25).HeaderText = "keterangan"
                .Columns(26).HeaderText = "TANGGAL PENERIMAAN"
                .Columns(27).HeaderText = "NOMOR SURAT TERA"
                .Columns(28).HeaderText = "T1"
                .Columns(29).HeaderText = "T2"
                .Columns(30).HeaderText = "T3"
                .Columns(31).HeaderText = "Ruang kosong(ltr)"
                .Columns(32).HeaderText = "Kl (mm/ltr)"
                .Columns(33).HeaderText = "T1"
                .Columns(34).HeaderText = "T2"
                .Columns(35).HeaderText = "T3"
                .Columns(36).HeaderText = "Ruang kosong(ltr)"
                .Columns(37).HeaderText = "Kl (mm/ltr)"
                .Columns(38).HeaderText = "TERA"
                .Columns(39).HeaderText = "Th. Pembuatan"
                .Columns(40).HeaderText = "No. STNK"
                .Columns(41).HeaderText = "Masa Berlaku STNK"
                .Columns(42).HeaderText = "No. Keur"
                .Columns(43).HeaderText = "Masa Berlaku Kier"
                .Columns(44).HeaderText = "No. Dok. Uji Emisi"
                .Columns(45).HeaderText = "Hasil Uji Emisi"
                .Columns(46).HeaderText = "Masa Berlaku Uji Emisi"
                .Columns(47).HeaderText = "No. SPB/SKT"
                .Columns(48).HeaderText = "Masa Berlaku SPB/SKT"
                .Columns(49).HeaderText = "No. Izin Prinsip Masuk Terminal BBM"
                .Columns(50).HeaderText = "No. Izin Masuk"
                .Columns(51).HeaderText = "Kode Area"
                .Columns(52).HeaderText = "Area"
                .Columns(53).HeaderText = "Kode Lokasi"
                .Columns(54).HeaderText = "Lokasi"
                .Columns(55).HeaderText = "Kode Kategori"
                .Columns(56).HeaderText = "Kategori"
                .Columns(57).HeaderText = "DELIVERY POINT"
                .Columns(58).HeaderText = "SEWA"
                .Columns(59).HeaderText = "TARIF"
                .Columns(60).HeaderText = "AGEN"
                .Columns(61).HeaderText = "INDUSTRI"
                .Columns(62).HeaderText = "ANGKUTAN SENDIRI"
                .Columns(63).HeaderText = "UMUR"
                .Columns(64).HeaderText = "KAT"
                .Columns(65).HeaderText = "PRODUK"
                .Columns(66).HeaderText = "(ENGKEL/TRONTON/SEMI TRAILER)"
                .Columns(67).HeaderText = "PABRIKAN TANGKI"
                .Columns(68).HeaderText = "MATERIAL TANGKI"
                .Columns(69).HeaderText = "MS/CARBON/AL"
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
        Catch ex As Exception
            KoneksiKeDatabase()
            kondisiawal()
            MessageBox.Show(ex.Message)

        Finally
            CONN.Close()
        End Try
        Return mysqlresult

    End Function

    Dim lokasifile As String


    Private Sub BTNEXCEL_Click(sender As Object, e As EventArgs) Handles BTNEXCEL.Click

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
        Try
            Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
            Dim cmd1 As New OleDb.OleDbCommand
            Dim da As New OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            Dim result As Boolean
            Dim sql As String

            Call KoneksiKeDatabase()
            QUERY = "DELETE FROM `mt`"
            CMD = New MySqlCommand(QUERY, CONN)
            CMD.ExecuteNonQuery()


            With cmd1
                .Connection = con
                .CommandText = "Select * FROM [mt$a3:cb]"
            End With

            da.SelectCommand = cmd1
            da.Fill(dt)

            For Each r As DataRow In dt.Rows


                Dim thbuatan As Date = r(9).ToString()
                'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & thbuatan.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"
                sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & thbuatan.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"


                result = saveData(sql)
                If result Then
                    Timer1.Start()
                End If
            Next

            'FormMobilTangki_Load(sender, e)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
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
End Class