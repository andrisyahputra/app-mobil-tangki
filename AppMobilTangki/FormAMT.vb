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

    Private Sub kondisiawal()
        Try
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
            btnClear.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        Call FormMenu.tampilMenu()
        'FormMenu.FormMenu_Load(sender, e)
    End Sub

    Private Sub FormAMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCari.Enabled = True
        aktifField()
        KosongkanData()
        DataGridAMT.Enabled = True
        TXTKRFID.Focus()
        KoneksiKeDatabase()
        kondisiawal()
        txtCari.Text = "Cari Data NOPOLIS Dan RFID"
        DataGridAMT.Enabled = True


        'txtCari.Text = "Cari Data NOPOLIS Dan RFID"
        'KoneksiKeDatabase()
        'kondisiawal()
        'TXTKRFID.Focus()
        'aktifField()
        'DataGridAMT.Enabled = True
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
                DataGridAMT.Enabled = False
            Else
                Call KoneksiKeDatabase()
                'no urut tidak di editt
                QUERY = "UPDATE `amt` SET `kode_rfid`='" & TXTKRFID.Text & "',`kode_rfid2`='" & TXTKRFID2.Text & "',`no_polis`='" & TXTNOPOLIS.Text & "',`perusahaan`='" & TXTPERUSAHAAN.Text & "',`lokasiamt`='" & TXTLOKASI.Text & "',`nik_amt1`='" & TXTAMT1NIK.Text & "',`nama_amt1`='" & TXTAMT1NAMA.Text & "',`ksong1`='" & TXTAMT1KSONG.Text & "',`tempat_lahir1`='" & TXTAMT1TLAHIR.Text & "',`tgl_lahir1`='" & Format(DATEAMT1TLAHIR.Value, "yyyy-MM-dd") & "',`usia1`='" & TXTAMT1USIA.Text & "',`nik_amt2`='" & TXTAMT2NIK.Text & "',`nama_amt2`='" & TXTAMT2NAMA.Text & "',`ksong2`='" & TXTAMT2KSONG.Text & "',`tempat_lahir2`='" & TXTAMT2TLAHIR.Text & "',`tgl_lahir2`='" & Format(DATEAMT2TLAHIR.Value, "yyyy-MM-dd") & "',`usia2`='" & TXTAMT2USIA.Text & "',`nik_amt3`='" & TXTAMT3NIK.Text & "',`nama_amt3`='" & TXTAMT3NAMA.Text & "',`ksong3`='" & TXTAMT3KSONG.Text & "',`tempat_lahir3`='" & TXTAMT3TLAHIR.Text & "',`tgl_lahir3`='" & Format(DATEAMT3TLAHIR.Value, "yyyy-MM-dd") & "',`usia3`='" & TXTKRFID2.Text & "',`transportir`='" & TXTTRANSPORTASI.Text & "' WHERE `id`='" & dataId & "'"

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



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            'LvMTangki.Clear()
            txtCari.Enabled = True
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
        If BTNEXCEL.Text = "IMPORT EXCEL" Then
            BTNEXCEL.Text = "Please Wait..."

            BTNEXCEL.Enabled = False

            Dim exMessage As Integer = MessageBox.Show("Data Excel Harus Tutup", "Notfikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
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

                        txtCari.Enabled = False
                        Enabledfield()

                        BTNEXCEL.Text = "BATAL IMPORT"
                        BTNEXCEL.Enabled = True
                        btnHapus.Enabled = False
                        BtnEdit.Enabled = False
                        BtnTambah.Enabled = False
                        btnClear.Enabled = False
                        btnUploud.Enabled = True
                        DataGridAMT.Enabled = True
                        Exit Sub
                    Else
                        BTNEXCEL.Text = "IMPORT EXCEL"
                        BTNEXCEL.Enabled = True

                    End If
                Catch ex As Exception
                    'MessageBox.Show("Sheet Pada Excel Harus MT", "EROR")
                    MessageBox.Show("SHEET HARUS AMT")
                    BTNEXCEL.Text = "IMPORT EXCEL"
                    BTNEXCEL.Enabled = True
                End Try

            ElseIf exMessage = DialogResult.No Then
                BTNEXCEL.Text = "IMPORT EXCEL"
                BTNEXCEL.Enabled = True
                BtnTambah.Enabled = True
                btnClear.Enabled = True
                aktifField()
                DataGridAMT.Enabled = True
                txtCari.Enabled = True
                Exit Sub
            End If
        End If

        If BTNEXCEL.Text = "BATAL IMPORT" Then
            BTNEXCEL.Text = "IMPORT EXCEL"
            btnUploud.Text = "UPLOUD"
            FormAMT_Load(sender, e)

            aktifField()
            txtCari.Enabled = True
            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            BtnEdit.Text = "EDIT"
            BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnClear.Text = "CLEAR"
            btnClear.Image = ImgClear

            BtnTambah.Enabled = True
            btnClear.Enabled = True
            btnHapus.Enabled = False
            BtnEdit.Enabled = False
            DataGridAMT.Enabled = True
            Exit Sub
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormAMT_Load(sender, e)
            btnUploud.Text = "UPLOUD"
            BTNEXCEL.Text = "IMPORT EXCEL"
            aktifField()
            txtCari.Enabled = True

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub


    Private Sub btnUploud_Click(sender As Object, e As EventArgs) Handles btnUploud.Click
        Dim A As String
        A = MsgBox("Benar data Dihapus ganti data baru?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "UPLOUD DATA")
        Select Case A
            Case vbCancel
                MsgBox("Data Tidak diganti", MsgBoxStyle.OkOnly, "UPLOUD DATA")

                FormAMT_Load(sender, e)
                btnUploud.Text = "UPLOUD"
                BTNEXCEL.Text = "IMPORT EXCEL"
                aktifField()
                txtCari.Enabled = True

                Exit Sub
            Case vbOK
                Try
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

                    'Call KoneksiKeDatabase()
                    Dim QUERY1 As String = "ALTER TABLE `amt` AUTO_INCREMENT = 1"
                    CMD = New MySqlCommand(QUERY1, CONN)
                    CMD.ExecuteNonQuery()


                    With cmd1
                        .Connection = con
                        .CommandText = "Select * FROM [Daftar AMT $a4:w]"
                    End With

                    da.SelectCommand = cmd1
                    da.Fill(dt)



                    For Each r As DataRow In dt.Rows

                        If (IsDBNull(r(1)) And IsDBNull(r(2)) And IsDBNull(r(3)) And IsDBNull(r(4))) Then
                            ' if true, do nothing and continue to next row
                        Else
                            'buat data pisah
                            Dim myString As String = r(1).ToString
                            Dim myValues() As String = myString.Split(" "c)

                            Dim value1 As String = myValues(0)
                            Dim value2 As String = If(myValues.Length > 1, myValues(1), String.Empty)

                            Dim tgllahir1 As Date = If(Convert.IsDBNull(r(9)), Nothing, CType(r(9), Date))
                            Dim tgllahir2 As Date = If(Convert.IsDBNull(r(14)), Nothing, CType(r(14), Date))
                            Dim tgllahir3 As Date = If(Convert.IsDBNull(r(19)), Nothing, CType(r(19), Date))
                            Dim nourut As Integer = If(Convert.IsDBNull(r(0)), Nothing, CType(r(0), Integer))
                            'Dim nama As Integer = If(Convert.IsDBNull(r(6)), Nothing, CType(r(6), String))

                            Dim name As String = r(6).ToString
                            Dim trimmedName As String = name.Trim("'"c) ' menghapus tanda kutip satu pada awal dan akhir string
                            Dim escapedName As String = MySqlHelper.EscapeString(trimmedName) ' melindungi string dari karakter-karakter khusus

                            sql = "INSERT INTO `amt`(`id`, `no_urut`, `kode_rfid`, `kode_rfid2`, `no_polis`, `perusahaan`, `lokasiamt`, `nik_amt1`, `nama_amt1`, `ksong1`, `tempat_lahir1`, `tgl_lahir1`, `usia1`, `nik_amt2`, `nama_amt2`, `ksong2`, `tempat_lahir2`, `tgl_lahir2`, `usia2`, `nik_amt3`, `nama_amt3`, `ksong3`, `tempat_lahir3`, `tgl_lahir3`, `usia3`, `transportir`) VALUES ('','" & nourut.ToString & "','" & value1 & "','" & value2 & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & escapedName & "','" & r(7).ToString & "','" & r(8).ToString & "','" & tgllahir1.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','','" & r(13).ToString & "','" & tgllahir2.ToString("yyyy-MM-dd") & "','" & r(15).ToString & "','" & r(16).ToString & "','" & r(17).ToString & "','','" & r(18).ToString & "','" & tgllahir3.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & r(21).ToString & "')"


                            result = saveData(sql)
                            If result Then
                                Timer2.Start()
                            End If
                        End If
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    btnUploud.Text = "Failed Import..."
                End Try

        End Select
    End Sub
    Sub clickdatagrid()
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

                    'txtCari.Enabled = False
                    Enabledfield()
                    DataGridAMT.Enabled = True

                End If
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridAMT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAMT.CellClick
        clickdatagrid()
    End Sub

    Private Sub txtCari_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCari.MouseClick
        txtCari.Text = ""
        ' Mengubah font
        txtCari.Font = New Font("Times New Roman", 14.25)
        ' Mengubah warna
        txtCari.ForeColor = Color.Black
    End Sub

    Private Sub txtCari_Leave(sender As Object, e As EventArgs) Handles txtCari.Leave


        'FormAMT_Load(sender, e)
        txtCari.Text = "Cari Data NOPOLIS Dan RFID"
        ' Mengubah font
        txtCari.Font = New Font("Times New Roman", 14.25)
        ' Mengubah warna
        txtCari.ForeColor = SystemColors.WindowFrame

    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                KoneksiKeDatabase()
                QUERY = "SELECT * FROM amt WHERE `no_polis` LIKE '%" & Trim(txtCari.Text) & "%' OR `kode_rfid` LIKE '%" & Trim(txtCari.Text) & "%' OR `kode_rfid2` LIKE '%" & Trim(txtCari.Text) & "%'"

                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS, "mt")
                DataGridAMT.DataSource = DS.Tables("mt")

            Catch ex As Exception
                MsgBox("Data tidak di temukan")
            End Try
        End If
    End Sub

End Class