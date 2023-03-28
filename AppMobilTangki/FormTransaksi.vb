Imports MySql.Data.MySqlClient

Public Class FormTransaksi
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

    Private Sub AturGridTransaksi()

        With DataGridTranksaksi
            '.Columns(0).Width = 200
            .Columns(1).Width = 200
            .Columns(2).Width = 80
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 90
            .Columns(7).Width = 90
            .Columns(8).Width = 120

            .Columns(0).DataPropertyName = "id"
            .Columns(1).DataPropertyName = "nama_perusahaan"
            .Columns(2).DataPropertyName = "no_plat_mobil"
            .Columns(3).DataPropertyName = "mobil_tangki"
            .Columns(4).DataPropertyName = "id_kompartemen1"
            .Columns(5).DataPropertyName = "id_kompartemen2"
            .Columns(6).DataPropertyName = "jrk_m_hole1"
            .Columns(7).DataPropertyName = "jrk_m_hole2"
            .Columns(8).DataPropertyName = "tgl_jam_ukur"

            .Columns(1).HeaderText = "NAMA PERUSAHAAN"
            .Columns(2).HeaderText = "NO PLAT KENDARAAN"
            .Columns(3).HeaderText = "MOBIL TANGKI"
            .Columns(4).HeaderText = "KOMPARTEMEN 1"
            .Columns(5).HeaderText = "KOMPARTEMEN 2"
            .Columns(6).HeaderText = "JARAK HOLE 1"
            .Columns(7).HeaderText = "JARAK HOLE 2"
            .Columns(8).HeaderText = "TGL JAM UKUR"

            .Columns(0).Visible = False

            '.Columns(9).Visible = False
            '.Columns(10).Visible = False

            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False
            '.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
            '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
            '.DefaultCellStyle.ForeColor = Color.DarkRed
            '.RowsDefaultCellStyle.BackColor = Color.PaleGreen
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGreen
            '.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            '.GridColor = Color.DarkRed
        End With
    End Sub


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
            QUERY = "Select * FROM relasitransaksi"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "relasitransaksi")
            DataGridTranksaksi.DataSource = DS.Tables("relasitransaksi")
        Catch ex As Exception
            MsgBox("database gagal di tampil")
        End Try
    End Sub


    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
        Call FormMenu.tampilMenu()
        'FormMenu.FormMenu_Load(sender, e)
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        kondisiawal()
        AturGridTransaksi()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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
                        FormTransaksi_Load(sender, e)
                        MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                        Call KosongkanData()
                        Exit Sub
                    Case vbOK
                        FormMenu.clearMenu()

                        'FormMenu.switchPanel(FormQRCODE)
                        'AmbilDatakeTransakasi()
                        Me.Close()
                End Select


                FormTransaksi_Load(sender, e)
                Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox("Gagal Di tambah")
        End Try
    End Sub

    Private Sub DataGridTranksaksi_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridTranksaksi.CellMouseClick
        BtnEdit.Text = "EDIT"
        btnHapus.Text = "HAPUS"
        BtnEdit.Image = ImgEdit
        btnClear.Text = "BATAL"
        btnClear.Image = imgBatal
        BtnEdit.Enabled = True
        btnHapus.Enabled = True
        BtnTambah.Enabled = False
        btnClear.Enabled = True

        txtJMHole2.Enabled = False
        txtJMHole1.Enabled = False
        txtJMHole1.Text = DataGridTranksaksi.Rows(e.RowIndex).Cells(6).Value
        txtJMHole2.Text = DataGridTranksaksi.Rows(e.RowIndex).Cells(7).Value
        dataId = DataGridTranksaksi.Rows(e.RowIndex).Cells(0).Value
        'lblJam.Text = DataGridTranksaksi.Rows(e.RowIndex).Cells(8).Value
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            FormTransaksi_Load(sender, e)
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
                fieldaktif()
            Else
                Call KoneksiKeDatabase()
                QUERY = "UPDATE tbl_transaksi SET no_plat_mobil='" & lblIDPlat.Text & "',jrk_m_hole1='" & txtJMHole1.Text & "',jrk_m_hole2='" & txtJMHole2.Text & "',tgl_jam_ukur='" & Today() & "',a='-',b='-',c='-',d='-',e='-'where id='" & dataId & "'"
                DA = New MySqlDataAdapter(QUERY, CONN)
                DS = New DataSet
                DA.Fill(DS)

                MsgBox("Edit data berhasil")

                Call kondisiawal()
            End If
        Catch ex As Exception
            MsgBox("PLAT NOMOR SUDAH TERSEDIA")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            FormTransaksi_Load(sender, e)
            Call KosongkanData()
            Exit Sub
        End If


        Try
            If btnHapus.Text = "HAPUS" Then
                Dim A As String
                A = MsgBox("BENAR DIHAPUS...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
                Select Case A
                    Case vbCancel
                        FormTransaksi_Load(sender, e)
                        Call KosongkanData()
                        MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
                        Exit Sub
                    Case vbOK
                        Call KoneksiKeDatabase()
                        QUERY = "delete from tbl_transaksi where id='" & dataId & "'"
                        CMD = New MySqlCommand(QUERY, CONN)
                        CMD.ExecuteNonQuery()
                        FormTransaksi_Load(sender, e)
                        Call KosongkanData()
                        MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
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
            DataGridTranksaksi.DataSource = dt
        Catch ex As Exception
            MsgBox("Data tidak di temukan")
        End Try
    End Sub

    Private Sub LblKode_Click(sender As Object, e As EventArgs) Handles LblKode.Click
        caridata()
    End Sub

End Class
