Imports MySql.Data.MySqlClient

Public Class FormAMT
    Dim ImgInput As Bitmap
    Dim ImgEdit As Bitmap
    Dim ImgHapus As Bitmap
    Dim ImgClear As Bitmap
    Dim ImgTutup As Bitmap
    Dim imgBatal As Bitmap
    Dim imgSimpan As Bitmap
    Dim imgUpdate As Bitmap
    'Dim dataId%
    Dim tglsekarang As Date

    'Private Sub AturGridTransaksi()

    'With DataGridTranksaksi
    '    '.Columns(0).Width = 200
    '    .Columns(1).Width = 200
    '    .Columns(2).Width = 80
    '    .Columns(3).Width = 100
    '    .Columns(4).Width = 100
    '    .Columns(5).Width = 100
    '    .Columns(6).Width = 90
    '    .Columns(7).Width = 90
    '    .Columns(8).Width = 120

    '    .Columns(0).DataPropertyName = "id"
    '    .Columns(1).DataPropertyName = "nama_perusahaan"
    '    .Columns(2).DataPropertyName = "no_plat_mobil"
    '    .Columns(3).DataPropertyName = "mobil_tangki"
    '    .Columns(4).DataPropertyName = "id_kompartemen1"
    '    .Columns(5).DataPropertyName = "id_kompartemen2"
    '    .Columns(6).DataPropertyName = "jrk_m_hole1"
    '    .Columns(7).DataPropertyName = "jrk_m_hole2"
    '    .Columns(8).DataPropertyName = "tgl_jam_ukur"

    '    .Columns(1).HeaderText = "NAMA PERUSAHAAN"
    '    .Columns(2).HeaderText = "NO PLAT KENDARAAN"
    '    .Columns(3).HeaderText = "MOBIL TANGKI"
    '    .Columns(4).HeaderText = "KOMPARTEMEN 1"
    '    .Columns(5).HeaderText = "KOMPARTEMEN 2"
    '    .Columns(6).HeaderText = "JARAK HOLE 1"
    '    .Columns(7).HeaderText = "JARAK HOLE 2"
    '    .Columns(8).HeaderText = "TGL JAM UKUR"

    '    .Columns(0).Visible = False

    '    '.Columns(9).Visible = False
    '    '.Columns(10).Visible = False

    '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    .EnableHeadersVisualStyles = False
    '    '.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
    '    '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '    .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
    '    '.DefaultCellStyle.ForeColor = Color.DarkRed
    '    '.RowsDefaultCellStyle.BackColor = Color.PaleGreen
    '    '.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGreen
    '    '.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
    '    '.GridColor = Color.DarkRed
    'End With
    'End Sub


    Private Sub KosongkanData()
        txtCari.Text = ""
        txtJMHole1.Text = ""
        txtJMHole2.Text = ""
        'txtDATEJUkur.Text = ""
    End Sub
    Private Sub tablePenuhKamar()
        Try
            'AturGridKamar()
            'Query = "Select * FROM tbl_kamar ORDER BY id_kamar"

        Catch ex As Exception
            MsgBox("Gagal tampil transaksi")
        End Try
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
            QUERY = "Select * FROM amt order by id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "amt")
            DataGridAMT.DataSource = DS.Tables("amt")

            With DataGridAMT
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

                .Columns(1).HeaderText = "No Urut"
                .Columns(2).HeaderText = "No. RFID"
                .Columns(3).HeaderText = "NOPOL"
                .Columns(4).HeaderText = "Perusahaan"
                .Columns(5).HeaderText = "Lokasi"
                .Columns(6).HeaderText = "NIK AMT"
                .Columns(7).HeaderText = "Nama AMT"
                .Columns(8).HeaderText = "Tempat Lahir"
                .Columns(9).HeaderText = "Tanggal Lahir"
                .Columns(10).HeaderText = "USIA"
                .Columns(11).HeaderText = "NIK AMT"
                .Columns(12).HeaderText = "Nama AMT"
                .Columns(13).HeaderText = "Tempat Lahir"
                .Columns(14).HeaderText = "Tanggal Lahir"
                .Columns(15).HeaderText = "USIA"
                .Columns(16).HeaderText = "NIK AMT"
                .Columns(17).HeaderText = "Nama AMT"
                .Columns(18).HeaderText = "Tempat Lahir"
                .Columns(19).HeaderText = "Tanggal Lahir"
                .Columns(20).HeaderText = "USIA"
                .Columns(21).HeaderText = "Transportir"

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


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        Call FormMenu.tampilMenu()
        'FormMenu.FormMenu_Load(sender, e)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        lblJam.Text = DateTime.Now.ToString()
        tglsekarang = Today
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
                        FormAMT_Load(sender, e)
                        MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                        Call KosongkanData()
                        Exit Sub
                    Case vbOK
                        FormMenu.clearMenu()

                        'FormMenu.switchPanel(FormQRCODE)
                        'AmbilDatakeTransakasi()
                        Me.Close()
                End Select


                FormAMT_Load(sender, e)
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox("Gagal Di tambah")
        End Try
    End Sub

    'Private Sub DataGridTranksaksi_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridAMT.CellMouseClick
    '    BtnEdit.Text = "EDIT"
    '    btnHapus.Text = "HAPUS"
    '    BtnEdit.Image = ImgEdit
    '    btnClear.Text = "BATAL"
    '    btnClear.Image = imgBatal
    '    BtnEdit.Enabled = True
    '    btnHapus.Enabled = True
    '    BtnTambah.Enabled = False
    '    btnClear.Enabled = True

    '    txtJMHole2.Enabled = False
    '    txtJMHole1.Enabled = False
    '    txtJMHole1.Text = DataGridAMT.Rows(e.RowIndex).Cells(6).Value
    '    txtJMHole2.Text = DataGridAMT.Rows(e.RowIndex).Cells(7).Value
    '    dataId = DataGridAMT.Rows(e.RowIndex).Cells(0).Value
    '    'lblJam.Text = DataGridTranksaksi.Rows(e.RowIndex).Cells(8).Value
    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            FormAMT_Load(sender, e)
            Call KosongkanData()
            Exit Sub
        End If
        If btnClear.Text = "CLEAR" Then
            txtJMHole1.Text = ""
            txtJMHole2.Text = ""
            txtJMHole1.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub fieldaktif()
        txtJMHole1.Enabled = True
        txtJMHole2.Enabled = True
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'Try

        '    If BtnEdit.Text = "EDIT" Then
        '        BtnEdit.Image = imgUpdate
        '        BtnEdit.Text = "UPDATE"
        '        btnHapus.Enabled = True
        '        btnHapus.Text = "BATAL"
        '        btnHapus.Image = imgBatal
        '        BtnTambah.Enabled = False
        '        btnClear.Text = "CLEAR"
        '        btnClear.Image = ImgClear
        '        fieldaktif()
        '    Else
        '        Call KoneksiKeDatabase()
        '        QUERY = "UPDATE tbl_transaksi SET no_plat_mobil='" & lblIDPlat.Text & "',jrk_m_hole1='" & txtJMHole1.Text & "',jrk_m_hole2='" & txtJMHole2.Text & "',tgl_jam_ukur='" & Today() & "',a='-',b='-',c='-',d='-',e='-'where id='" & dataId & "'"
        '        DA = New MySqlDataAdapter(QUERY, CONN)
        '        DS = New DataSet
        '        DA.Fill(DS)

        '        MsgBox("Edit data berhasil")

        '        Call kondisiawal()
        '    End If
        'Catch ex As Exception
        '    MsgBox("PLAT NOMOR SUDAH TERSEDIA")
        'End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        'If btnHapus.Text = "BATAL" Then
        '    FormAMT_Load(sender, e)
        '    Call KosongkanData()
        '    Exit Sub
        'End If


        'Try
        '    If btnHapus.Text = "HAPUS" Then
        '        Dim A As String
        '        A = MsgBox("BENAR DIHAPUS...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
        '        Select Case A
        '            Case vbCancel
        '                FormAMT_Load(sender, e)
        '                Call KosongkanData()
        '                MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
        '                Exit Sub
        '            Case vbOK
        '                Call KoneksiKeDatabase()
        '                QUERY = "delete from tbl_transaksi where id='" & dataId & "'"
        '                CMD = New MySqlCommand(QUERY, CONN)
        '                CMD.ExecuteNonQuery()
        '                FormAMT_Load(sender, e)
        '                Call KosongkanData()
        '                MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
        '        End Select
        '    End If

        'Catch ex As Exception
        '    MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        'End Try
    End Sub
    'Private Sub Caridata(pencarian As String)
    '    Try
    '        KoneksiKeDatabase()
    '        QUERY = "SELECT * FROM relasitransaksi WHERE nama_perusahaan LIKE '%" & Trim(pencarian) & "%' OR no_plat_mobil LIKE '%" & Trim(pencarian) & "%'"
    '        DA = New MySqlDataAdapter(QUERY, CONN)
    '        DA.Fill(DS, "relasitransaksi")
    '        DataGridTranksaksi.DataSource = DS.Tables("relasitransaksi")
    '    Catch ex As Exception
    '        MsgBox("Data tidak di temukan")
    '    End Try
    'End Sub

    'Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
    '    Caridata(txtCari.Text)
    'End Sub
    Private Sub caridata()
        Try
            KoneksiKeDatabase()
            QUERY = "SELECT * FROM relasitransaksi WHERE nama_perusahaan LIKE '%" & Trim(txtCari.Text) & "%' OR no_plat_mobil LIKE '%" & Trim(txtCari.Text) & "%'"
            Dim cmd As New MySqlCommand(QUERY, CONN)
            cmd.Parameters.AddWithValue("relasitransaksi", txtCari.Text)
            DA.SelectCommand = cmd
            Dim dt As New DataTable
            DA.Fill(dt)
            DataGridAMT.DataSource = dt
        Catch ex As Exception
            MsgBox("Data tidak di temukan")
        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        caridata()
    End Sub

    Private Sub FormAMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        kondisiawal()
        'AturGridTransaksi()
        'Timer1.Start()
    End Sub
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
                    Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Daftar AMT $a4:w]", con)
                    cmd.TableMappings.Add("Table", "Table")
                    Dim dt As New DataSet
                    cmd.Fill(dt)
                    DataGridAMT.DataSource = dt.Tables(0)
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
            .CommandText = "Select * FROM [Daftar AMT $a4:w]"
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

            Dim tgllahir1 As Date = If(Convert.IsDBNull(r(9)), Nothing, CType(r(9), Date))
            Dim tgllahir2 As Date = If(Convert.IsDBNull(r(14)), Nothing, CType(r(14), Date))
            Dim tgllahir3 As Date = If(Convert.IsDBNull(r(19)), Nothing, CType(r(19), Date))
            Dim nourut As Integer = If(Convert.IsDBNull(r(0)), Nothing, CType(r(0), Integer))
            'Dim nama As Integer = If(Convert.IsDBNull(r(6)), Nothing, CType(r(6), String))

            Dim name As String = r(6).ToString
            Dim trimmedName As String = Name.Trim("'"c) ' menghapus tanda kutip satu pada awal dan akhir string
            Dim escapedName As String = MySqlHelper.EscapeString(trimmedName) ' melindungi string dari karakter-karakter khusus


            'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & myDate.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & r(19).ToString & "','" & r(20).ToString & "','" & r(21).ToString & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & r(38).ToString & "','" & r(39).ToString & "','" & r(40).ToString & "','" & r(41).ToString & "','" & r(42).ToString & "','" & r(43).ToString & "','" & r(44).ToString & "','" & r(45).ToString & "','" & r(46).ToString & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"
            'sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `ksong`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','" & r(0).ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & DateValue.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & datemasuk.ToString("yyyy-MM-dd") & "','" & datestnk.ToString("yyyy-MM-dd") & "','" & datekeur.ToString("yyyy-MM-dd") & "','" & datetera.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & dateskt.ToString("yyyy-MM-dd") & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString & "','" & r(25).ToString() & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & r(37).ToString & "','" & datetera2.ToString("yyyy-MM-dd") & "','" & r(39).ToString & "','" & r(40).ToString & "','" & datemlakustnk.ToString("yyyy-MM-dd") & "','" & r(42).ToString & "','" & datemlakukier.ToString("yyyy-MM-dd") & "','" & r(44).ToString & "','" & r(45).ToString & "','" & datemlakuemisi.ToString("yyyy-MM-dd") & "','" & r(47).ToString & "','" & r(48).ToString & "','" & r(49).ToString & "','" & r(50).ToString & "','" & r(51).ToString & "','" & r(52).ToString & "','" & r(53).ToString & "','" & r(54).ToString & "','" & r(55).ToString & "','" & r(56).ToString & "','" & r(57).ToString & "','" & r(58).ToString & "','" & r(59).ToString & "','" & r(69).ToString & "','" & r(61).ToString & "','" & r(62).ToString & "','" & r(63).ToString & "','" & r(64).ToString & "','" & r(65).ToString & "','" & r(66).ToString & "','" & r(67).ToString & "','" & r(68).ToString & "','" & r(69).ToString & "','" & r(70).ToString & "','" & r(71).ToString & "','" & r(72).ToString & "','" & r(73).ToString & "','" & r(74).ToString & "','" & r(75).ToString & "','" & r(76).ToString & "','" & r(77).ToString & "','" & r(78).ToString & "','" & r(79).ToString & "')"
            'sql = "INSERT INTO `amt`(`id`, `rfid`, `nopol`, `perusahaan`, `lokasi`, `nik_amt1`, `nama_amt1`, `ksong1`, `tempat_lahir1`, `tgl_lahir1`, `usia1`, `nik_amt2`, `nama_amt2`, `tempat_lahir2`, `tgl_lahir2`, `usia2`, `nik_amt3`, `nama_amt3`, `tempat_lahir3`, `tgl_lahir3`, `usia3`, `transportir`) VALUES ('','" & r(1).ToString '" &,'" & r(2).toString'" &,'" & r(3).toString'" &,'" & r(4).toString'" &,'" & r(5).toString'" &,'" & r(6).toString'" &,'" & r(7).toString'" &,'" & r(8).toString'" &,'" & r(9).toString'" &,'" & r(10).toString'" &,'" & r(11).toString'" &,'" & r(12).toString'" &,'" & r(13).toString'" &,'" & r(14).toString'" &,'" & r(15).toString'" &,'" & r(16).toString'" &,'" & r(17).toString'" &,'" & r(18).toString'" &,'" & r(19).toString'" &,'" & r(20).toString'" &,'" & r(21).toString'" &,'" & r(22).toString & "')"
            sql = "INSERT INTO `amt`(`id`, `no_urut`, `rfid`, `nopol`, `perusahaan`, `lokasi`, `nik_amt1`, `nama_amt1`, `ksong1`, `tempat_lahir1`, `tgl_lahir1`, `usia1`, `nik_amt2`, `nama_amt2`, `tempat_lahir2`, `tgl_lahir2`, `usia2`, `nik_amt3`, `nama_amt3`, `tempat_lahir3`, `tgl_lahir3`, `usia3`, `transportir`) VALUES ('','" & nourut.ToString & "','" & r(1).ToString & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & escapedName & "','" & r(7).ToString & "','" & r(8).ToString & "','" & tgllahir1.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & tgllahir2.ToString("yyyy-MM-dd") & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','" & r(18).ToString & "','" & tgllahir3.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & r(21).ToString & "')"


            result = saveData(sql)
            If result Then
                Timer2.Start()
            End If
        Next

        'FormMobilTangki_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            'Dim filepath As String = TXTLOCATION.Text
            'Dim connstring As String = String.Empty
            Dim con As OleDb.OleDbConnection

            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
            'If filepath.EndsWith(".xls") Then
            '    connstring =
            'End If
            Dim cmd As New OleDb.OleDbDataAdapter("Select * from [Daftar AMT $a5:w]", con)
            cmd.TableMappings.Add("Table", "Table")
            Dim dt As New DataSet
            cmd.Fill(dt)
            DataGridAMT.DataSource = dt.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub
End Class
