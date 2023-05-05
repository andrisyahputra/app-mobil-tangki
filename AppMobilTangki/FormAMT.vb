Imports System.IO
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
    Dim dataId%
    Dim tglsekarang As Date

    Private Sub Enabledfield()
        TXTKRFID.Enabled = False
        TXTKRFID2.Enabled = False
        TXTNOPOLIS.Enabled = False
        TXTPERUSAHAAN.Enabled = False
        TXTLOKASI.Enabled = False
        TXTTRANSPORTASI.Enabled = False
        TXTAMT1NIK.Enabled = False
        TXTAMT1NAMA.Enabled = False
        TXTAMT1KSONG.Enabled = False
        TXTAMT1TLAHIR.Enabled = False
        DATEAMT1TLAHIR.Enabled = False
        TXTAMT1USIA.Enabled = False
        TXTAMT2NIK.Enabled = False
        TXTAMT2NAMA.Enabled = False
        TXTAMT2KSONG.Enabled = False
        TXTAMT2TLAHIR.Enabled = False
        DATEAMT2TLAHIR.Enabled = False
        TXTAMT2USIA.Enabled = False
        TXTAMT3NIK.Enabled = False
        TXTAMT3NAMA.Enabled = False
        TXTAMT3KSONG.Enabled = False
        TXTAMT3TLAHIR.Enabled = False
        DATEAMT3TLAHIR.Enabled = False
        TXTAMT3USIA.Enabled = False

    End Sub
    Private Sub aktifField()
        TXTKRFID.Enabled = True
        TXTKRFID2.Enabled = True
        TXTNOPOLIS.Enabled = True
        TXTPERUSAHAAN.Enabled = True
        TXTLOKASI.Enabled = True
        TXTTRANSPORTASI.Enabled = True
        TXTAMT1NIK.Enabled = True
        TXTAMT1NAMA.Enabled = True
        TXTAMT1KSONG.Enabled = True
        TXTAMT1TLAHIR.Enabled = True
        DATEAMT1TLAHIR.Enabled = True
        TXTAMT1USIA.Enabled = True
        TXTAMT2NIK.Enabled = True
        TXTAMT2NAMA.Enabled = True
        TXTAMT2KSONG.Enabled = True
        TXTAMT2TLAHIR.Enabled = True
        DATEAMT2TLAHIR.Enabled = True
        TXTAMT2USIA.Enabled = True
        TXTAMT3NIK.Enabled = True
        TXTAMT3NAMA.Enabled = True
        TXTAMT3KSONG.Enabled = True
        TXTAMT3TLAHIR.Enabled = True
        DATEAMT3TLAHIR.Enabled = True
        TXTAMT3USIA.Enabled = True
    End Sub
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
        TXTKRFID.Text = ""
        TXTKRFID2.Text = ""
        TXTNOPOLIS.Text = ""
        TXTPERUSAHAAN.Text = ""
        TXTLOKASI.Text = ""
        TXTTRANSPORTASI.Text = ""
        TXTAMT1NIK.Text = ""
        TXTAMT1NAMA.Text = ""
        TXTAMT1KSONG.Text = ""
        TXTAMT1TLAHIR.Text = ""
        DATEAMT1TLAHIR.Value = Today()
        TXTAMT1USIA.Text = ""
        TXTAMT2NIK.Text = ""
        TXTAMT2NAMA.Text = ""
        TXTAMT2KSONG.Text = ""
        TXTAMT2TLAHIR.Text = ""
        DATEAMT2TLAHIR.Value = Today()
        TXTAMT2USIA.Text = ""
        TXTAMT3NIK.Text = ""
        TXTAMT3NAMA.Text = ""
        TXTAMT3KSONG.Text = ""
        TXTAMT3TLAHIR.Text = ""
        DATEAMT3TLAHIR.Value = Today()
        TXTAMT3USIA.Text = ""
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


                .Columns(1).HeaderText = "No Urut"
                .Columns(2).HeaderText = "No. RFID 1"
                .Columns(3).HeaderText = "No. RFID 2"
                .Columns(4).HeaderText = "NOPOL"
                .Columns(5).HeaderText = "Perusahaan"
                .Columns(6).HeaderText = "Lokasi"
                .Columns(7).HeaderText = "NIK AMT"
                .Columns(8).HeaderText = "Nama AMT"
                .Columns(9).HeaderText = "Keterangan AMT 1"
                .Columns(10).HeaderText = "Tempat Lahir"
                .Columns(11).HeaderText = "Tanggal Lahir"
                .Columns(12).HeaderText = "USIA"
                .Columns(13).HeaderText = "NIK AMT 2"
                .Columns(14).HeaderText = "Nama AMT 2"
                .Columns(15).HeaderText = "Keterangan AMT 2"
                .Columns(16).HeaderText = "Tempat Lahir AMT 2"
                .Columns(17).HeaderText = "Tanggal Lahir AMT 2"
                .Columns(18).HeaderText = "USIA AMT 2"
                .Columns(19).HeaderText = "NIK AMT Cadangan"
                .Columns(20).HeaderText = "Nama AMT Cadangan"
                .Columns(21).HeaderText = "Keterangan AMT Cadangan"
                .Columns(22).HeaderText = "Tempat Lahir AMT Cadangan"
                .Columns(23).HeaderText = "Tanggal Lahir AMT Cadangan"
                .Columns(24).HeaderText = "USIA AMT Cadangan"
                .Columns(25).HeaderText = "Transportir"


                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "no_urut"
                .Columns(2).DataPropertyName = "kode_rfid"
                .Columns(3).DataPropertyName = "kode_rfid2"
                .Columns(4).DataPropertyName = "no_polis"
                .Columns(5).DataPropertyName = "perusahaan"
                .Columns(6).DataPropertyName = "lokasiamt"
                .Columns(7).DataPropertyName = "nik_amt1"
                .Columns(8).DataPropertyName = "nama_amt1"
                .Columns(9).DataPropertyName = "ksong1"
                .Columns(10).DataPropertyName = "tempat_lahir1"
                .Columns(11).DataPropertyName = "tgl_lahir1"
                .Columns(12).DataPropertyName = "usia1"
                .Columns(13).DataPropertyName = "nik_amt2"
                .Columns(14).DataPropertyName = "nama_amt2"
                .Columns(15).DataPropertyName = "ksong2"
                .Columns(16).DataPropertyName = "tempat_lahir2"
                .Columns(17).DataPropertyName = "tgl_lahir2"
                .Columns(18).DataPropertyName = "usia2"
                .Columns(19).DataPropertyName = "nik_amt3"
                .Columns(20).DataPropertyName = "nama_amt3"
                .Columns(21).DataPropertyName = "ksong3"
                .Columns(22).DataPropertyName = "tempat_lahir3"
                .Columns(23).DataPropertyName = "tgl_lahir3"
                .Columns(24).DataPropertyName = "usia3"
                .Columns(25).DataPropertyName = "transportir"

                .Columns(0).Visible = False

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

            KosongkanData()
            btnUploud.Enabled = False
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
        'lblJam.Text = DateTime.Now.ToString()
        tglsekarang = Today
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            Call KoneksiKeDatabase()
            QUERY = "INSERT INTO `amt`(`id`, `no_urut`, `kode_rfid`, `kode_rfid2`, `no_polis`, `perusahaan`, `lokasiamt`, `nik_amt1`, `nama_amt1`, `ksong1`, `tempat_lahir1`, `tgl_lahir1`, `usia1`, `nik_amt2`, `nama_amt2`, `ksong2`, `tempat_lahir2`, `tgl_lahir2`, `usia2`, `nik_amt3`, `nama_amt3`, `ksong3`, `tempat_lahir3`, `tgl_lahir3`, `usia3`, `transportir`) VALUES ('','1','" & TXTKRFID.Text & "','" & TXTKRFID2.Text & "','" & TXTNOPOLIS.Text & "','" & TXTPERUSAHAAN.Text & "','" & TXTLOKASI.Text & "','" & TXTAMT1NIK.Text & "','" & TXTAMT1NAMA.Text & "','" & TXTAMT1KSONG.Text & "','" & TXTAMT1TLAHIR.Text & "','" & Format(DATEAMT1TLAHIR.Value, "yyyy-MM-dd") & "','" & TXTAMT1USIA.Text & "','" & TXTAMT2NIK.Text & "','" & TXTAMT2NAMA.Text & "','" & TXTAMT2KSONG.Text & "','" & TXTAMT2TLAHIR.Text & "','" & Format(DATEAMT2TLAHIR.Value, "yyyy-MM-dd") & "','" & TXTAMT2USIA.Text & "','" & TXTAMT3NIK.Text & "','" & TXTAMT3NAMA.Text & "','" & TXTAMT3KSONG.Text & "','" & TXTAMT3TLAHIR.Text & "','" & Format(DATEAMT3TLAHIR.Value, "yyyy-MM-dd") & "','" & TXTAMT3USIA.Text & "','" & TXTTRANSPORTASI.Text & "')"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS)


            MessageBox.Show("Berhasil ditambah")
            FormAMT_Load(sender, e)
            KosongkanData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            'LvMTangki.Clear()
            aktifField()
            KosongkanData()
            DataGridAMT.Enabled = True

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
            Exit Sub
        End If
        If btnClear.Text = "CLEAR" Then
            KosongkanData()
            TXTKRFID.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try

            If BtnEdit.Text = "EDIT" Then
                aktifField()
                BtnEdit.Image = imgUpdate
                BtnEdit.Text = "UPDATE"
                btnHapus.Enabled = True
                btnHapus.Text = "BATAL"
                btnHapus.Image = imgBatal
                BtnTambah.Enabled = False
                btnClear.Text = "CLEAR"
                btnClear.Image = ImgClear
            Else
                Call KoneksiKeDatabase()
                QUERY = "UPDATE `amt` SET `no_urut`='1',`kode_rfid`='" & TXTKRFID.Text & "',`kode_rfid2`='" & TXTKRFID2.Text & "',`no_polis`='" & TXTNOPOLIS.Text & "',`perusahaan`='" & TXTPERUSAHAAN.Text & "',`lokasiamt`='" & TXTLOKASI.Text & "',`nik_amt1`='" & TXTAMT1NIK.Text & "',`nama_amt1`='" & TXTAMT1NAMA.Text & "',`ksong1`='" & TXTAMT1KSONG.Text & "',`tempat_lahir1`='" & TXTAMT1TLAHIR.Text & "',`tgl_lahir1`='" & Format(DATEAMT1TLAHIR.Value, "yyyy-MM-dd") & "',`usia1`='" & TXTAMT1USIA.Text & "',`nik_amt2`='" & TXTAMT2NIK.Text & "',`nama_amt2`='" & TXTAMT2NAMA.Text & "',`ksong2`='" & TXTAMT2KSONG.Text & "',`tempat_lahir2`='" & TXTAMT2TLAHIR.Text & "',`tgl_lahir2`='" & Format(DATEAMT2TLAHIR.Value, "yyyy-MM-dd") & "',`usia2`='" & TXTAMT2USIA.Text & "',`nik_amt3`='" & TXTAMT3NIK.Text & "',`nama_amt3`='" & TXTAMT3NAMA.Text & "',`ksong3`='" & TXTAMT3KSONG.Text & "',`tempat_lahir3`='" & TXTAMT3TLAHIR.Text & "',`tgl_lahir3`='" & Format(DATEAMT3TLAHIR.Value, "yyyy-MM-dd") & "',`usia3`='" & TXTKRFID2.Text & "',`transportir`='" & TXTTRANSPORTASI.Text & "' WHERE `id`='" & dataId & "'"

                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS)

                MsgBox("Edit data berhasil")
                DataGridAMT.Enabled = True
                'CBLevel.Items.Clear()
                FormAMT_Load(sender, e)
                'Call KosongkanData()
            End If
        Catch ex As Exception
            'MsgBox("PLAT NOMOR SUDAH TERSEDIA")
            MsgBox(ex.Message)
            'CBLevel.Items.Clear()
            'FormUser_Load(sender, e)
            btnHapus.Visible = True
            kondisiawal()
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            'LvMTangki.Clear()
            aktifField()
            KosongkanData()
            DataGridAMT.Enabled = True

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
            Exit Sub
        End If


        Try
            If btnHapus.Text = "HAPUS" Then
                Dim A As String
                A = MsgBox("Benar data No : " & TXTNOPOLIS.Text & " akan Dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
                Select Case A
                    Case vbCancel
                        'LvMTangki.Clear()

                        'Call KosongkanData()
                        MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        aktifField()
                        DataGridAMT.Enabled = True
                        'KosongkanData()
                        FormAMT_Load(sender, e)
                        Exit Sub
                    Case vbOK
                        Call KoneksiKeDatabase()
                        QUERY = "DELETE FROM `amt` where id='" & dataId & "'"
                        CMD = New MySqlCommand(QUERY, CONN)
                        CMD.ExecuteNonQuery()
                        'LvMTangki.Clear()

                        MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        aktifField()
                        DataGridAMT.Enabled = True
                        'KosongkanData()
                        FormAMT_Load(sender, e)

                End Select
            End If

        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
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
        TXTKRFID.Focus()
    End Sub
    Dim lokasifile As String

    Private Sub BTNEXCEL_Click(sender As Object, e As EventArgs) Handles BTNEXCEL.Click
        Dim exMessage As Integer = MessageBox.Show("Data Excel Harus Tutup", "Notfikasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If exMessage = DialogResult.Yes Then
            Dim ofd As New OpenFileDialog
            Try
                With ofd
                    .Filter = "Excel File|*.xlsx|Excel File|*.xls| All files(*.*)|*.*"
                    .FilterIndex = 1
                    .Title = "Import data from excel file"
                End With
                If ofd.ShowDialog() = DialogResult.OK Then

                    lokasifile = ofd.FileName
                    Dim con As OleDb.OleDbConnection
                    Dim cmd As OleDb.OleDbDataAdapter
                    Dim dt As New DataSet

                    If Path.GetExtension(lokasifile) = ".xlsx" Then
                        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + lokasifile + ";Extended Properties=Excel 12.0;")
                        cmd = New OleDb.OleDbDataAdapter("SELECT * FROM [Daftar AMT $a4:w]", con)
                    ElseIf Path.GetExtension(lokasifile) = ".xls" Then
                        con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + lokasifile + ";Extended Properties='Excel 8.0;HDR=YES;'")
                        cmd = New OleDb.OleDbDataAdapter("SELECT * FROM [Daftar AMT $a4:w]", con)
                    Else
                        ' Handle unsupported file format
                        MessageBox.Show("Import failed")
                        Exit Sub
                    End If
                    cmd.Fill(dt)
                    DataGridAMT.DataSource = dt.Tables(0)
                    'With DataGridAMT
                    '    .Columns(0).HeaderText = "No Urut"
                    '    .Columns(1).HeaderText = "No. RFID"
                    '    .Columns(2).HeaderText = "NOPOL"
                    '    .Columns(3).HeaderText = "Perusahaan"
                    '    .Columns(4).HeaderText = "Lokasi"
                    '    .Columns(5).HeaderText = "NIK AMT"
                    '    .Columns(6).HeaderText = "Nama AMT"
                    '    .Columns(7).HeaderText = "Tempat Lahir"
                    '    .Columns(8).HeaderText = "Tanggal Lahir"
                    '    .Columns(9).HeaderText = "USIA"
                    '    .Columns(10).HeaderText = "NIK AMT"
                    '    .Columns(11).HeaderText = "Nama AMT"
                    '    .Columns(12).HeaderText = "Tempat Lahir"
                    '    .Columns(13).HeaderText = "Tanggal Lahir"
                    '    .Columns(14).HeaderText = "USIA"
                    '    .Columns(15).HeaderText = "NIK AMT"
                    '    .Columns(16).HeaderText = "Nama AMT"
                    '    .Columns(17).HeaderText = "Tempat Lahir"
                    '    .Columns(18).HeaderText = "Tanggal Lahir"
                    '    .Columns(19).HeaderText = "USIA"
                    '    .Columns(20).HeaderText = "Transportir"
                    'End With

                    'con.Close()
                    btnUploud.Enabled = True
                Else


                End If
            Catch ex As Exception
                'MessageBox.Show("Sheet Pada Excel Harus MT", "EROR")
                MessageBox.Show(ex.Message)
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
            Dim trimmedName As String = name.Trim("'"c) ' menghapus tanda kutip satu pada awal dan akhir string
            Dim escapedName As String = MySqlHelper.EscapeString(trimmedName) ' melindungi string dari karakter-karakter khusus

            sql = "INSERT INTO `amt`(`id`, `no_urut`, `kode_rfid`, `kode_rfid2`, `no_polis`, `perusahaan`, `lokasiamt`, `nik_amt1`, `nama_amt1`, `ksong1`, `tempat_lahir1`, `tgl_lahir1`, `usia1`, `nik_amt2`, `nama_amt2`, `ksong2`, `tempat_lahir2`, `tgl_lahir2`, `usia2`, `nik_amt3`, `nama_amt3`, `ksong3`, `tempat_lahir3`, `tgl_lahir3`, `usia3`, `transportir`) VALUES ('','" & nourut.ToString & "','" & r(1).ToString & "','koderfid2','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & escapedName & "','" & r(7).ToString & "','" & r(8).ToString & "','" & tgllahir1.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','ksong2','" & r(13).ToString & "','" & tgllahir2.ToString("yyyy-MM-dd") & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','ksong3','" & r(18).ToString & "','" & tgllahir3.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & r(21).ToString & "')"


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

    Private Sub BTNEXPORT_Click(sender As Object, e As EventArgs) Handles BTNEXPORT.Click
        Try
            BTNEXPORT.Text = "Please Wait..."
            BTNEXPORT.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                'Dim i As Integer
                'Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                'xlApp.Workbooks.Open()
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("Daftar AMT")

                For i = 0 To DataGridAMT.RowCount - 2
                    For j = 0 To DataGridAMT.ColumnCount - 1
                        For k As Integer = 1 To DataGridAMT.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridAMT.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridAMT(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                BTNEXPORT.Text = "Export To MS Excel"
                BTNEXPORT.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Buka File excel Failed to save !!!" & vbCrLf & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub DataGridAMT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAMT.CellClick
        Dim i As Integer

        Try
            With DataGridAMT
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else


                    i = .CurrentRow.Index
                    'ID
                    dataId = .Rows(i).Cells(0).Value
                    ''untuk date
                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(11).Value) AndAlso .Rows(i).Cells(11).Value IsNot Nothing Then

                        DATEAMT1TLAHIR.Text = .Rows(i).Cells(11).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEAMT1TLAHIR.Value = Today
                    End If
                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(17).Value) AndAlso .Rows(i).Cells(17).Value IsNot Nothing Then

                        DATEAMT2TLAHIR.Text = .Rows(i).Cells(17).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEAMT2TLAHIR.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(23).Value) AndAlso .Rows(i).Cells(23).Value IsNot Nothing Then
                        DATEAMT3TLAHIR.Text = .Rows(i).Cells(23).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEAMT3TLAHIR.Value = Today
                    End If

                    'untuk text
                    TXTKRFID.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(2).Value) AndAlso .Rows(i).Cells(2).Value IsNot Nothing, .Rows(i).Cells(2).Value.ToString(), "")
                    TXTKRFID2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(3).Value) AndAlso .Rows(i).Cells(3).Value IsNot Nothing, .Rows(i).Cells(3).Value.ToString(), "")
                    TXTNOPOLIS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(4).Value) AndAlso .Rows(i).Cells(4).Value IsNot Nothing, .Rows(i).Cells(4).Value.ToString(), "")
                    TXTPERUSAHAAN.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(5).Value) AndAlso .Rows(i).Cells(5).Value IsNot Nothing, .Rows(i).Cells(5).Value.ToString(), "")
                    TXTLOKASI.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(6).Value) AndAlso .Rows(i).Cells(6).Value IsNot Nothing, .Rows(i).Cells(6).Value.ToString(), "")
                    TXTAMT1NIK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(7).Value) AndAlso .Rows(i).Cells(7).Value IsNot Nothing, .Rows(i).Cells(7).Value.ToString(), "")
                    TXTAMT1NAMA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(8).Value) AndAlso .Rows(i).Cells(8).Value IsNot Nothing, .Rows(i).Cells(8).Value.ToString(), "")
                    TXTAMT1KSONG.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(9).Value) AndAlso .Rows(i).Cells(9).Value IsNot Nothing, .Rows(i).Cells(9).Value.ToString(), "")
                    TXTAMT1TLAHIR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(10).Value) AndAlso .Rows(i).Cells(10).Value IsNot Nothing, .Rows(i).Cells(10).Value.ToString(), "")

                    TXTAMT1USIA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(12).Value) AndAlso .Rows(i).Cells(12).Value IsNot Nothing, .Rows(i).Cells(12).Value.ToString(), "")
                    TXTAMT2NIK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(13).Value) AndAlso .Rows(i).Cells(13).Value IsNot Nothing, .Rows(i).Cells(13).Value.ToString(), "")
                    TXTAMT2NAMA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(14).Value) AndAlso .Rows(i).Cells(14).Value IsNot Nothing, .Rows(i).Cells(14).Value.ToString(), "")
                    TXTAMT2KSONG.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(15).Value) AndAlso .Rows(i).Cells(15).Value IsNot Nothing, .Rows(i).Cells(15).Value.ToString(), "")
                    TXTAMT2TLAHIR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(16).Value) AndAlso .Rows(i).Cells(16).Value IsNot Nothing, .Rows(i).Cells(16).Value.ToString(), "")


                    TXTAMT2USIA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(18).Value) AndAlso .Rows(i).Cells(18).Value IsNot Nothing, .Rows(i).Cells(18).Value.ToString(), "")
                    TXTAMT3NIK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(19).Value) AndAlso .Rows(i).Cells(19).Value IsNot Nothing, .Rows(i).Cells(19).Value.ToString(), "")
                    TXTAMT3NAMA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(20).Value) AndAlso .Rows(i).Cells(20).Value IsNot Nothing, .Rows(i).Cells(20).Value.ToString(), "")
                    TXTAMT3KSONG.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(21).Value) AndAlso .Rows(i).Cells(21).Value IsNot Nothing, .Rows(i).Cells(21).Value.ToString(), "")
                    TXTAMT3TLAHIR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(22).Value) AndAlso .Rows(i).Cells(22).Value IsNot Nothing, .Rows(i).Cells(22).Value.ToString(), "")
                    DATEAMT3TLAHIR.Value = Today()
                    TXTAMT3USIA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(24).Value) AndAlso .Rows(i).Cells(24).Value IsNot Nothing, .Rows(i).Cells(24).Value.ToString(), "")

                    TXTTRANSPORTASI.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(25).Value) AndAlso .Rows(i).Cells(25).Value IsNot Nothing, .Rows(i).Cells(25).Value.ToString(), "")

                    BtnEdit.Text = "EDIT"
                    BtnEdit.Image = ImgEdit
                    BtnEdit.Enabled = True

                    btnClear.Enabled = True
                    btnClear.Text = "BATAL"
                    btnClear.Image = imgBatal

                    btnHapus.Enabled = True
                    btnHapus.Text = "HAPUS"

                    BtnTambah.Enabled = False

                    Enabledfield()
                    DataGridAMT.Enabled = False

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
