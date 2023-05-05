Imports System.IO
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

    Private Sub Enabledfield()

        TXTKRFID.Enabled = False
        TXTKRFID2.Enabled = False
        TXTNOPOLIS.Enabled = False
        TXTKBLOKIR.Enabled = False
        TXTTITLE.Enabled = False
        TXTNPERUSAHAAN.Enabled = False
        TXTSTATUS.Enabled = False
        TXTMTYPE.Enabled = False
        TXTMODEL.Enabled = False
        DATETHNBUATAN.Enabled = False
        TXTKAPASITAS.Enabled = False
        TXTKOMPATEMENT.Enabled = False
        TXTPRODUK.Enabled = False
        TXTNOMESIN.Enabled = False
        TXTNRANGKA.Enabled = False
        TXTHUEMISI.Enabled = False
        DATEPASMASUK.Enabled = False
        DATESTNK.Enabled = False
        DATEKEUR.Enabled = False
        DATETERA.Enabled = False
        TXTIZBKHUSU.Enabled = False
        DATESKT.Enabled = False
        TXTNPAS.Enabled = False
        TXTSTATUS2.Enabled = False
        TXTKET.Enabled = False
        TXTTGLTERIMA.Enabled = False
        TXTNOSTERA.Enabled = False
        TXTKOMPT1.Enabled = False
        TXTKOMPT2.Enabled = False
        TXTKOMPT3.Enabled = False
        TXTKOMPKSONG.Enabled = False
        TXTKOMPK1.Enabled = False
        TXTKOMP2T1.Enabled = False
        TXTKOMP2T2.Enabled = False
        TXTKOMP2T3.Enabled = False
        TXTKOMP2RKSONG.Enabled = False
        TXTKOMP2K1.Enabled = False
        DATEMLAKUKIER.Enabled = False
        TXTNODOKEMISI.Enabled = False
        DATETERA2.Enabled = False
        TXTTHNBUATAN2.Enabled = False
        TXTNSTNK.Enabled = False
        DATEMLAKUSTNK.Enabled = False
        TXTNKEUR.Enabled = False
    End Sub

    Private Sub aktifField()
        TXTKRFID.Enabled = True
        TXTKRFID2.Enabled = True
        TXTNOPOLIS.Enabled = True
        TXTKBLOKIR.Enabled = True
        TXTTITLE.Enabled = True
        TXTNPERUSAHAAN.Enabled = True
        TXTSTATUS.Enabled = True
        TXTMTYPE.Enabled = True
        TXTMODEL.Enabled = True
        DATETHNBUATAN.Enabled = True
        TXTKAPASITAS.Enabled = True
        TXTKOMPATEMENT.Enabled = True
        TXTPRODUK.Enabled = True
        TXTNOMESIN.Enabled = True
        TXTNRANGKA.Enabled = True
        TXTHUEMISI.Enabled = True
        DATEPASMASUK.Enabled = True
        DATESTNK.Enabled = True
        DATEKEUR.Enabled = True
        DATETERA.Enabled = True
        TXTIZBKHUSU.Enabled = True
        DATESKT.Enabled = True
        TXTNPAS.Enabled = True
        TXTSTATUS2.Enabled = True
        TXTKET.Enabled = True
        TXTTGLTERIMA.Enabled = True
        TXTNOSTERA.Enabled = True
        TXTKOMPT1.Enabled = True
        TXTKOMPT2.Enabled = True
        TXTKOMPT3.Enabled = True
        TXTKOMPKSONG.Enabled = True
        TXTKOMPK1.Enabled = True
        TXTKOMP2T1.Enabled = True
        TXTKOMP2T2.Enabled = True
        TXTKOMP2T3.Enabled = True
        TXTKOMP2RKSONG.Enabled = True
        TXTKOMP2K1.Enabled = True
        DATEMLAKUKIER.Enabled = True
        TXTNODOKEMISI.Enabled = True
        DATETERA2.Enabled = True
        TXTTHNBUATAN2.Enabled = True
        TXTNSTNK.Enabled = True
        DATEMLAKUSTNK.Enabled = True
        TXTNKEUR.Enabled = True
    End Sub


    Private Sub kosongidata()
        TXTKRFID.Text = ""
        TXTKRFID2.Text = ""
        TXTNOPOLIS.Text = ""
        TXTKBLOKIR.Text = ""
        TXTTITLE.Text = ""
        TXTNPERUSAHAAN.Text = ""
        TXTSTATUS.Text = ""
        TXTMTYPE.Text = ""
        TXTMODEL.Text = ""
        DATETHNBUATAN.Value = Today
        TXTKAPASITAS.Text = ""
        TXTKOMPATEMENT.Text = ""
        TXTPRODUK.Text = ""
        TXTNOMESIN.Text = ""
        TXTNRANGKA.Text = ""
        TXTHUEMISI.Text = ""
        DATEPASMASUK.Value = Today
        DATESTNK.Value = Today
        DATEKEUR.Value = Today
        DATETERA.Value = Today
        TXTIZBKHUSU.Text = ""
        DATESKT.Value = Today
        TXTNPAS.Text = ""
        TXTSTATUS2.Text = ""
        TXTKET.Text = ""
        TXTTGLTERIMA.Text = ""
        TXTNOSTERA.Text = ""
        TXTKOMPT1.Text = ""
        TXTKOMPT2.Text = ""
        TXTKOMPT3.Text = ""
        TXTKOMPKSONG.Text = ""
        TXTKOMPK1.Text = ""
        TXTKOMP2T1.Text = ""
        TXTKOMP2T2.Text = ""
        TXTKOMP2T3.Text = ""
        TXTKOMP2RKSONG.Text = ""
        TXTKOMP2K1.Text = ""
        DATEMLAKUKIER.Value = Today
        TXTNODOKEMISI.Text = ""
        DATETERA2.Value = Today
        TXTTHNBUATAN2.Text = ""
        TXTNSTNK.Text = ""
        DATEMLAKUSTNK.Value = Today
        TXTNKEUR.Text = ""
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            Call KoneksiKeDatabase()
            QUERY = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `kode_rfid2`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`, `hasil_uji_emisi`, `m_berlaku_uji_emisi`, `no_spb_skt`, `m_berlaku_spb_mkt`, `no_z_m_terminal_bbm`, `no_izin_masuk`, `kode_area`, `area`, `kd_lokasi`, `lokasi`, `kd_kategori`, `kategori`, `delivery_point`, `sewa`, `tarif`, `agen`, `industri`, `angkutan_sendiri`, `umur`, `kat`, `produk2`, `engkel_tronton_semit`, `pabrikan_tangki`, `material_tangki`, `pembuatan_tangki`, `sts_armada`, `plat`, `asuransi`, `alamat`, `telepon`, `email`, `npwp`, `penanggung_jawab`, `jabatan`, `data_umur_mt`) VALUES ('','4','" & TXTKRFID.Text & "','" & TXTKRFID2.Text & "','" & TXTNOPOLIS.Text & "','" & TXTKBLOKIR.Text & "','" & TXTTITLE.Text & "','" & TXTNPERUSAHAAN.Text & "','" & TXTSTATUS.Text & "','" & TXTMTYPE.Text & "','" & TXTMODEL.Text & "','" & Format(DATETHNBUATAN.Value, "yyyy-MM-dd") & "','" & TXTKAPASITAS.Text & "','" & TXTKOMPATEMENT.Text & "','" & TXTPRODUK.Text & "','" & TXTNOMESIN.Text & "','" & TXTNRANGKA.Text & "','" & TXTHUEMISI.Text & "','" & Format(DATEPASMASUK.Value, "yyyy-MM-dd") & "','" & Format(DATESTNK.Value, "yyyy-MM-dd") & "','" & Format(DATEKEUR.Value, "yyyy-MM-dd") & "','" & Format(DATETERA.Value, "yyyy-MM-dd") & "','" & TXTIZBKHUSU.Text & "','" & Format(DATESKT.Value, "yyyy-MM-dd") & "','" & TXTNPAS.Text & "','" & TXTSTATUS2.Text & "','" & TXTKET.Text & "','" & TXTTGLTERIMA.Text & "','" & TXTNOSTERA.Text & "','" & TXTKOMPT1.Text & "','" & TXTKOMPT2.Text & "','" & TXTKOMPT3.Text & "','" & TXTKOMPKSONG.Text & "','" & TXTKOMPK1.Text & "','" & TXTKOMP2T1.Text & "','" & TXTKOMP2T2.Text & "','" & TXTKOMP2T3.Text & "','" & TXTKOMP2RKSONG.Text & "','" & TXTKOMP2K1.Text & "','" & Format(DATETERA2.Value, "yyyy-MM-dd") & "','" & TXTTHNBUATAN2.Text & "','" & TXTNSTNK.Text & "','" & Format(DATEMLAKUSTNK.Value, "yyyy-MM-dd") & "','" & TXTNKEUR.Text & "','" & Format(DATEMLAKUKIER.Value, "yyyy-MM-dd") & "','" & TXTNODOKEMISI.Text & "')"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS)


            MessageBox.Show("Berhasil ditambah")
            FormMobilTangki_Load(sender, e)
            Call kosongidata()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub FormMobilTangki_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiKeDatabase()
        kondisiawal()
        TXTKRFID.Focus()
    End Sub
    Private Sub kondisiawal()
        Try

            QUERY = "Select * FROM mt ORDER BY id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "mt")
            DTGridMT.DataSource = DS.Tables("mt")

            With DTGridMT
                '    '.Columns(1).Width = 200
                '    '.Columns(2).Width = 120
                '    '.Columns(3).Width = 100
                '    '.Columns(4).Width = 150
                '    '.Columns(5).Width = 150
                '    '.Columns(6).Width = 100
                '    '.Columns(7).Width = 100
                '    '.Columns(8).Width = 80
                '    '.Columns(9).Width = 150


                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "no_urut"
                .Columns(2).DataPropertyName = "kode_rfid"
                .Columns(3).DataPropertyName = "kode_rfid2"
                .Columns(4).DataPropertyName = "no_polis"
                .Columns(5).DataPropertyName = "ket_blokir"
                .Columns(6).DataPropertyName = "title"
                .Columns(7).DataPropertyName = "nama_perusahaan"
                .Columns(8).DataPropertyName = "sts"
                .Columns(9).DataPropertyName = "merk_type"
                .Columns(10).DataPropertyName = "model"
                .Columns(11).DataPropertyName = "thn_pembuatan"
                .Columns(12).DataPropertyName = "kapasitas"
                .Columns(13).DataPropertyName = "kompartemen"
                .Columns(14).DataPropertyName = "produk"
                .Columns(15).DataPropertyName = "no_mesin"
                .Columns(16).DataPropertyName = "no_rangka"
                .Columns(17).DataPropertyName = "hsl_uji_emisi"
                .Columns(18).DataPropertyName = "pas_masuk"
                .Columns(19).DataPropertyName = "stnk"
                .Columns(20).DataPropertyName = "keur"
                .Columns(21).DataPropertyName = "tera"
                .Columns(22).DataPropertyName = "ijin_brg_khusus"
                .Columns(23).DataPropertyName = "skt"
                .Columns(24).DataPropertyName = "no_pas"
                .Columns(25).DataPropertyName = "status2"
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
                '.Columns(46).DataPropertyName = "hasil_uji_emisi"
                '.Columns(47).DataPropertyName = "m_berlaku_uji_emisi"
                '.Columns(48).DataPropertyName = "no_spb_skt"
                '.Columns(49).DataPropertyName = "m_berlaku_spb_mkt"
                '.Columns(50).DataPropertyName = "no_z_m_terminal_bbm"
                '.Columns(51).DataPropertyName = "no_izin_masuk"
                '.Columns(52).DataPropertyName = "kode_area"
                '.Columns(53).DataPropertyName = "area"
                '.Columns(54).DataPropertyName = "kd_lokasi"
                '.Columns(55).DataPropertyName = "lokasi"
                '.Columns(56).DataPropertyName = "kd_kategori"
                '.Columns(57).DataPropertyName = "kategori"
                '.Columns(58).DataPropertyName = "delivery_point"
                '.Columns(59).DataPropertyName = "sewa"
                '.Columns(60).DataPropertyName = "tarif"
                '.Columns(61).DataPropertyName = "agen"
                '.Columns(62).DataPropertyName = "industri"
                '.Columns(63).DataPropertyName = "angkutan_sendiri"
                '.Columns(64).DataPropertyName = "umur"
                '.Columns(65).DataPropertyName = "kat"
                '.Columns(66).DataPropertyName = "produk2"
                '.Columns(67).DataPropertyName = "engkel_tronton_semit"
                '.Columns(68).DataPropertyName = "pabrikan_tangki"
                '.Columns(69).DataPropertyName = "material_tangki"
                '.Columns(70).DataPropertyName = "pembuatan_tangki"
                '.Columns(71).DataPropertyName = "sts_armada"
                '.Columns(72).DataPropertyName = "plat"
                '.Columns(73).DataPropertyName = "asuransi"
                '.Columns(74).DataPropertyName = "alamat"
                '.Columns(75).DataPropertyName = "telepon"
                '.Columns(76).DataPropertyName = "email"
                '.Columns(77).DataPropertyName = "npwp"
                '.Columns(78).DataPropertyName = "penanggung_jawab"
                '.Columns(79).DataPropertyName = "jabatan"
                '.Columns(80).DataPropertyName = "data_umur_mt"

                .Columns(0).Visible = False
                '.Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "NO URUT"
                .Columns(2).HeaderText = "KODE RFID"
                .Columns(3).HeaderText = "KODE RFID 2"
                .Columns(4).HeaderText = "NO POLIS"
                .Columns(5).HeaderText = "KET_BLOKIR"
                .Columns(6).HeaderText = "TITLE"
                .Columns(7).HeaderText = "NAMA PERUSAHAAN"
                .Columns(8).HeaderText = "STATUS"
                .Columns(9).HeaderText = "MEREK TYPE"
                .Columns(10).HeaderText = "MODEL"
                .Columns(11).HeaderText = "TAHUN PEMBUATAN"
                .Columns(12).HeaderText = "KAPASITAS"
                .Columns(13).HeaderText = "KOMPARTEMEN"
                .Columns(14).HeaderText = "PRODUK"
                .Columns(15).HeaderText = "NO MESIN"
                .Columns(16).HeaderText = "NO RANGKA"
                .Columns(17).HeaderText = "HASIL UJI EMISI"
                .Columns(18).HeaderText = "PAS MASUK"
                .Columns(19).HeaderText = "STNK"
                .Columns(20).HeaderText = "KEUR"
                .Columns(21).HeaderText = "TERA"
                .Columns(22).HeaderText = "IJIN BARANG KHUSUS"
                .Columns(23).HeaderText = "SKT"
                .Columns(24).HeaderText = "NO PAS"
                .Columns(25).HeaderText = "STATUS"
                .Columns(26).HeaderText = "KETERANGAN"
                .Columns(27).HeaderText = "TANGGAL PENERIMA"
                .Columns(28).HeaderText = "NO SURAT TERA"
                .Columns(29).HeaderText = "KOMPARTEMEN T1"
                .Columns(30).HeaderText = "KOMPARTEMEN T2"
                .Columns(31).HeaderText = "KOMPARTEMEN T3"
                .Columns(32).HeaderText = "KOMPARTEMEN RUANG KOSONG"
                .Columns(33).HeaderText = "KOMPARTEMEN k1"
                .Columns(34).HeaderText = "KOMPARTEMEN2 T1"
                .Columns(35).HeaderText = "OMPARTEMEN2 T2"
                .Columns(36).HeaderText = "KOMPARTEMEN2 T3"
                .Columns(37).HeaderText = "KOMPARTEMEN2 RUANG KOSONG"
                .Columns(38).HeaderText = "KOMPARTEMEN K1"
                .Columns(39).HeaderText = "TERA"
                .Columns(40).HeaderText = "TAHUN PEMBUATAN 2"
                .Columns(41).HeaderText = "NO STNK"
                .Columns(42).HeaderText = "BERLAKU STNK"
                .Columns(43).HeaderText = "NO KEUR"
                .Columns(44).HeaderText = "MASA BERLAKU KIER"
                .Columns(45).HeaderText = "NO DOK UJI EMISI"
                '.Columns(46).HeaderText = "HASIL UJI EMISI"
                '.Columns(47).HeaderText = "MASA BERLAKU UJI EMISI"
                '.Columns(48).HeaderText = "NO SPB/SKT"
                '.Columns(49).HeaderText = "MASA BERLAKU SPB/SKT"
                '.Columns(50).HeaderText = "No. Izin Prinsip Masuk Terminal BBM"
                '.Columns(51).HeaderText = "No. Izin Masuk"
                '.Columns(52).HeaderText = "KODE AREA"
                '.Columns(53).HeaderText = "AREA"
                '.Columns(54).HeaderText = "KODE LOKASI"
                '.Columns(55).HeaderText = "LOKASI"
                '.Columns(56).HeaderText = "KODE KATEGORI"
                '.Columns(57).HeaderText = "KATEGORI"
                '.Columns(58).HeaderText = "DELIVERY POINT"
                '.Columns(59).HeaderText = "SEWA"
                '.Columns(60).HeaderText = "TARIF"
                '.Columns(61).HeaderText = "AGEN"
                '.Columns(62).HeaderText = "INDUSTRI"
                '.Columns(63).HeaderText = "ANGKUTAN SENDIRI"
                '.Columns(64).HeaderText = "UMUR"
                '.Columns(65).HeaderText = "KETERANGAN"
                '.Columns(66).HeaderText = "PRODUK2"
                '.Columns(67).HeaderText = "ENGKEL/TRONTON/SEMI TRAILER"
                '.Columns(68).HeaderText = "PABRIKAN TANGKI"
                '.Columns(69).HeaderText = "MATERIAL TANGKI"
                '.Columns(70).HeaderText = "PEMBUATAN TANGKI"
                '.Columns(71).HeaderText = "STATUS ARMADA"
                '.Columns(72).HeaderText = "PLAT"
                '.Columns(73).HeaderText = "ASURANSI"
                '.Columns(74).HeaderText = "ALAMAT"
                '.Columns(75).HeaderText = "TELEPON"
                '.Columns(76).HeaderText = "EMAIL"
                '.Columns(77).HeaderText = "NPWP"
                '.Columns(78).HeaderText = "PENANGGUNG JAWAB"
                '.Columns(79).HeaderText = "JABATAN"
                '.Columns(80).HeaderText = "DATA UMUR MT"

                '    .Columns(9).DefaultCellStyle.Format = "yyyy-MM-dd"
                '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '    .EnableHeadersVisualStyles = False
                '    .ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                '    .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                '    .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
                '    .RowsDefaultCellStyle.BackColor = Color.Crimson
                '    .DefaultCellStyle.ForeColor = Color.DarkRed
                '    .RowsDefaultCellStyle.BackColor = Color.SkyBlue
                '    .AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
                '    .GridColor = Color.DarkRed
            End With
            kosongidata()
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
                DTGridMT.Enabled = False
            Else
                CMD = New MySqlCommand
                CMD.Connection = CONN

                QUERY = "UPDATE `mt` SET `kode_rfid`='" & TXTKRFID.Text & "',`kode_rfid2`='" & TXTKRFID2.Text & "',`no_polis`='" & TXTNOPOLIS.Text & "',`ket_blokir`='" & TXTKBLOKIR.Text & "',`title`='" & TXTTITLE.Text & "',`nama_perusahaan`='" & TXTNPERUSAHAAN.Text & "',`sts`='" & TXTSTATUS.Text & "',`merk_type`='" & TXTMTYPE.Text & "',`model`='" & TXTMODEL.Text & "',`thn_pembuatan`='" & Format(DATETHNBUATAN.Value, "yyyy-MM-dd") & "',`kapasitas`='" & TXTKAPASITAS.Text & "',`kompartemen`='" & TXTKOMPATEMENT.Text & "',`produk`='" & TXTPRODUK.Text & "',`no_mesin`='" & TXTNOMESIN.Text & "',`no_rangka`='" & TXTNRANGKA.Text & "',`hsl_uji_emisi`='" & TXTHUEMISI.Text & "',`pas_masuk`='" & Format(DATEPASMASUK.Value, "yyyy-MM-dd") & "',`stnk`='" & Format(DATESTNK.Value, "yyyy-MM-dd") & "',`keur`='" & Format(DATEKEUR.Value, "yyyy-MM-dd") & "',`tera`='" & Format(DATETERA.Value, "yyyy-MM-dd") & "',`ijin_brg_khusus`='" & TXTIZBKHUSU.Text & "',`skt`='" & Format(DATESKT.Value, "yyyy-MM-dd") & "',`no_pas`='" & TXTNPAS.Text & "',`status2`='" & TXTSTATUS2.Text & "',`keterangan`='" & TXTKET.Text & "',`tgl_penerima`='" & TXTTGLTERIMA.Text & "',`no_surat_tera`='" & TXTNOSTERA.Text & "',`komp1_t1`='" & TXTKOMPT1.Text & "',`komp1_t2`='" & TXTKOMPT2.Text & "',`komp1_t3`='" & TXTKOMP2T3.Text & "',`komp1_ruang_ksg`='" & TXTKOMPKSONG.Text & "',`komp1_k1`='" & TXTKOMPK1.Text & "',`komp2_t1`='" & TXTKOMP2T1.Text & "',`komp2_t2`='" & TXTKOMP2T2.Text & "',`komp2_t3`='" & TXTKOMP2T3.Text & "',`komp2_ruang_ksg`='" & TXTKOMP2RKSONG.Text & "',`komp2_k1`='" & TXTKOMP2K1.Text & "',`tera2`='" & Format(DATETERA2.Value, "yyyy-MM-dd") & "',`thn_pembuatan2`='" & TXTTHNBUATAN2.Text & "',`no_stnk`='" & TXTNSTNK.Text & "',`m_berlaku_stnk`='" & Format(DATEMLAKUSTNK.Value, "yyyy-MM-dd") & "',`no_keur`='" & TXTNKEUR.Text & "',`m_berlaku_kier`='" & Format(DATEMLAKUKIER.Value, "yyyy-MM-dd") & "',`no_dok_uji_emisi`='" & TXTNODOKEMISI.Text & "' where id='" & dataId & "'"

                CMD.CommandText = QUERY
                CMD.ExecuteNonQuery()
                MsgBox("EDIT data berhasil")

                DTGridMT.Enabled = True
                'CBLevel.Items.Clear()
                FormMobilTangki_Load(sender, e)
                'Call KosongkanData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'CBLevel.Items.Clear()
            'FormUser_Load(sender, e)
            kondisiawal()
            'ListView1.Enabled = True
        End Try
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnClear.Text = "BATAL" Then
            'LvMTangki.Clear()
            aktifField()
            kosongidata()
            DTGridMT.Enabled = True

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
            kosongidata()
            TXTKRFID.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            'LvMTangki.Clear()
            aktifField()
            kosongidata()
            DTGridMT.Enabled = True

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
                        MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        aktifField()
                        DTGridMT.Enabled = True
                        'KosongkanData()
                        FormMobilTangki_Load(sender, e)
                        Exit Sub
                    Case vbOK
                        Call KoneksiKeDatabase()
                        QUERY = "DELETE FROM `mt` where id='" & dataId & "'"
                        CMD = New MySqlCommand(QUERY, CONN)
                        CMD.ExecuteNonQuery()
                        'LvMTangki.Clear()

                        MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        aktifField()
                        DTGridMT.Enabled = True
                        'KosongkanData()
                        FormMobilTangki_Load(sender, e)

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
                            cmd = New OleDb.OleDbDataAdapter("SELECT * FROM [mt$A3:CB]", con)
                        ElseIf Path.GetExtension(lokasifile) = ".xls" Then
                            con = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + lokasifile + ";Extended Properties='Excel 8.0;HDR=YES;'")
                            cmd = New OleDb.OleDbDataAdapter("SELECT * FROM [mt$A3:CB]", con)
                        Else
                            ' Handle unsupported file format
                            MessageBox.Show("Import failed")
                            Exit Sub
                        End If

                        cmd.Fill(dt)
                        DTGridMT.DataSource = dt.Tables(0)
                        DTGridMT.Columns(24).Visible = False

                        Enabledfield()
                        BTNEXCEL.Text = "BATAL IMPORT"
                        BTNEXCEL.Enabled = True
                        btnHapus.Enabled = False
                        BtnEdit.Enabled = False
                        BtnTambah.Enabled = False
                        btnClear.Enabled = False
                        btnUploud.Enabled = True
                        DTGridMT.Enabled = True
                        Exit Sub
                    Else
                        BTNEXCEL.Text = "IMPORT EXCEL"
                        BTNEXCEL.Enabled = True
                    End If
                Catch ex As Exception
                    'MessageBox.Show("Sheet Pada Excel Harus MT", "EROR")
                    MessageBox.Show("SHEET HARUS MT")
                    BTNEXCEL.Text = "IMPORT EXCEL"
                    BTNEXCEL.Enabled = True
                End Try



            ElseIf exMessage = DialogResult.No Then
                BTNEXCEL.Text = "IMPORT EXCEL"
                BTNEXCEL.Enabled = True
                BtnTambah.Enabled = True
                btnClear.Enabled = True
                aktifField()
                DTGridMT.Enabled = True
                'MessageBox.Show("User Select No")
                Exit Sub
            End If
        End If

        If BTNEXCEL.Text = "BATAL IMPORT" Then
            BTNEXCEL.Text = "IMPORT EXCEL"
            btnUploud.Text = "UPLOUD"
            FormMobilTangki_Load(sender, e)

            aktifField()

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
            DTGridMT.Enabled = True
            Exit Sub
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Sucessfully imported", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormMobilTangki_Load(sender, e)
            btnUploud.Text = "UPLOUD"
            BTNEXCEL.Text = "IMPORT EXCEL"
            aktifField()

            ProgressBar1.Value = 0
        Else
            ProgressBar1.Value += 1
        End If
    End Sub



    Private Sub btnUploud_Click(sender As Object, e As EventArgs) Handles btnUploud.Click
        Try
            btnUploud.Text = "Please Wait..."
            btnUploud.Enabled = False


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

            'Call KoneksiKeDatabase()
            Dim QUERY1 As String = "ALTER TABLE `amt` AUTO_INCREMENT = 1"
            CMD = New MySqlCommand(QUERY1, CONN)
            CMD.ExecuteNonQuery()


            With cmd1
                .Connection = con
                .CommandText = "Select * FROM [mt$a3:cb]"
            End With

            da.SelectCommand = cmd1
            da.Fill(dt)


            Dim count As Integer = 0

            For Each r As DataRow In dt.Rows

                'buat data pisah
                Dim myString As String = r(1).ToString
                Dim myValues() As String = myString.Split(" "c)

                Dim value1 As String = myValues(0)
                Dim value2 As String = If(myValues.Length > 1, myValues(1), String.Empty)

                Dim dateValue As Date = If(Convert.IsDBNull(r(9)), Nothing, CType(r(9), Date))
                Dim datemasuk As Date = If(Convert.IsDBNull(r(16)), Nothing, CType(r(16), Date))
                Dim datestnk As Date = If(Convert.IsDBNull(r(17)), Nothing, CType(r(17), Date))
                Dim datekeur As Date = If(Convert.IsDBNull(r(18)), Nothing, CType(r(18), Date))
                Dim datetera As Date = If(Convert.IsDBNull(r(19)), Nothing, CType(r(19), Date))
                Dim dateskt As Date = If(Convert.IsDBNull(r(21)), Nothing, CType(r(21), Date))
                Dim datetera2 As Date = If(Convert.IsDBNull(r(38)), Nothing, CType(r(38), Date))
                Dim datemlakustnk As Date = If(Convert.IsDBNull(r(41)), Nothing, CType(r(41), Date))
                Dim datemlakukier As Date = If(Convert.IsDBNull(r(43)), Nothing, CType(r(43), Date))
                count += 1
                '37 hilangkan
                sql = "INSERT INTO `mt`(`id`, `no_urut`, `kode_rfid`, `kode_rfid2`, `no_polis`, `ket_blokir`, `title`, `nama_perusahaan`, `sts`, `merk_type`, `model`, `thn_pembuatan`, `kapasitas`, `kompartemen`, `produk`, `no_mesin`, `no_rangka`, `hsl_uji_emisi`, `pas_masuk`, `stnk`, `keur`, `tera`, `ijin_brg_khusus`, `skt`, `no_pas`, `status2`, `keterangan`, `tgl_penerima`, `no_surat_tera`, `komp1_t1`, `komp1_t2`, `komp1_t3`, `komp1_ruang_ksg`, `komp1_k1`, `komp2_t1`, `komp2_t2`, `komp2_t3`, `komp2_ruang_ksg`, `komp2_k1`, `tera2`, `thn_pembuatan2`, `no_stnk`, `m_berlaku_stnk`, `no_keur`, `m_berlaku_kier`, `no_dok_uji_emisi`) VALUES ('" & count & "','" & r(0).ToString & "','" & value1 & "','" & value2 & "','" & r(2).ToString & "','" & r(3).ToString & "','" & r(4).ToString & "','" & r(5).ToString & "','" & r(6).ToString & "','" & r(7).ToString & "','" & r(8).ToString & "','" & dateValue.ToString("yyyy-MM-dd") & "','" & r(10).ToString & "','" & r(11).ToString & "','" & r(12).ToString & "','" & r(13).ToString & "','" & r(14).ToString & "','" & r(15).ToString & "','" & datemasuk.ToString("yyyy-MM-dd") & "','" & datestnk.ToString("yyyy-MM-dd") & "','" & datekeur.ToString("yyyy-MM-dd") & "','" & datetera.ToString("yyyy-MM-dd") & "','" & r(20).ToString & "','" & dateskt.ToString("yyyy-MM-dd") & "','" & r(22).ToString & "','" & r(23).ToString & "','" & r(24).ToString() & "','" & r(25).ToString & "','" & r(26).ToString & "','" & r(27).ToString & "','" & r(28).ToString & "','" & r(29).ToString & "','" & r(30).ToString & "','" & r(31).ToString & "','" & r(32).ToString & "','" & r(33).ToString & "','" & r(34).ToString & "','" & r(35).ToString & "','" & r(36).ToString & "','" & datetera2.ToString("yyyy-MM-dd") & "','" & r(39).ToString & "','" & r(40).ToString & "','" & datemlakustnk.ToString("yyyy-MM-dd") & "','" & r(42).ToString & "','" & datemlakukier.ToString("yyyy-MM-dd") & "','" & r(44).ToString & "')"

                result = saveData(sql)
                If result Then
                    Timer1.Start()
                End If

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            btnUploud.Text = "Failed Import..."
        End Try

    End Sub

    Dim FlNm As String

    Private Sub ExportToExcel(ByVal DGV As DataGridView)
        Dim fs As New StreamWriter(FlNm, False)
        With fs
            .WriteLine("<?xml version=""1.0""?>")
            .WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            .WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet"">")
            .WriteLine("    <Styles>")
            .WriteLine("        <Style ss:ID=""hdr"">")
            .WriteLine("            <Alignment ss:Horizontal=""Center""/>")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""11"" ss:Bold=""1""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""ksg"">")
            .WriteLine("            <Alignment ss:Vertical=""Bottom""/>")
            .WriteLine("            <Borders/>")
            .WriteLine("            <Font ss:FontName=""Calibri""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""isi"">")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""10""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("    </Styles>")

            If DGV.Name = "MT" Then
                .WriteLine("    <Worksheet ss:Name=""MT"">") 'SET NAMA SHEET
                .WriteLine("        <Table>")
                .WriteLine("<Column ss:Width=""50""/>") 'no
                .WriteLine("<Column ss:Width=""93""/>") 'rfid
                .WriteLine("<Column ss:Width=""93""/>") 'rfid2
                .WriteLine("<Column ss:Width=""100""/>") 'no polis
                .WriteLine("<Column ss:Width=""84""/>") 'ket blokir
                .WriteLine("<Column ss:Width=""50""/>") 'title
                .WriteLine("<Column ss:Width=""220""/>") 'Nama perusahan
                .WriteLine("<Column ss:Width=""84""/>") 'status
                .WriteLine("<Column ss:Width=""100""/>") 'merek_type
                .WriteLine("<Column ss:Width=""100""/>") 'model
                .WriteLine("<Column ss:Width=""100""/>") 'thn buatan
                .WriteLine("<Column ss:Width=""100""/>") 'kapasitas
                .WriteLine("<Column ss:Width=""84""/>") 'kompartemen1
                .WriteLine("<Column ss:Width=""100""/>") 'produk
                .WriteLine("<Column ss:Width=""110""/>") 'nomesin
                .WriteLine("<Column ss:Width=""120""/>") 'no rangka
                .WriteLine("<Column ss:Width=""70""/>") 'hasil
                .WriteLine("<Column ss:Width=""84""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""84""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""120""/>") 'ID
                .WriteLine("<Column ss:Width=""93""/>") 'NO
                .WriteLine("<Column ss:Width=""84""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""84""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""110""/>") 'ketrangan
                .WriteLine("<Column ss:Width=""120""/>") 'NO
                .WriteLine("<Column ss:Width=""120""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""100""/>") 'ID
                .WriteLine("<Column ss:Width=""100""/>") 'NO
                .WriteLine("<Column ss:Width=""100""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""100""/>") 'ID
                .WriteLine("<Column ss:Width=""120""/>") 'NO
                .WriteLine("<Column ss:Width=""120""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""120""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""100""/>") 'ID
                .WriteLine("<Column ss:Width=""120""/>") 'NO
                .WriteLine("<Column ss:Width=""100""/>") 'NAMA
                .WriteLine("<Column ss:Width=""120""/>") 'Alamat
                .WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""120""/>") 'ID
                .WriteLine("<Column ss:Width=""180""/>") 'NO
                .WriteLine("<Column ss:Width=""100""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                .WriteLine("<Column ss:Width=""100""/>") 'ID
                .WriteLine("<Column ss:Width=""100""/>") 'NO
                .WriteLine("<Column ss:Width=""100""/>") 'NAMA
                .WriteLine("<Column ss:Width=""100""/>") 'Alamat
                .WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                '.WriteLine("<Column ss:Width=""100""/>") 'ID
                '.WriteLine("<Column ss:Width=""93""/>") 'NO
                '.WriteLine("<Column ss:Width=""84""/>") 'NAMA
                '.WriteLine("<Column ss:Width=""100""/>") 'Alamat
                '.WriteLine("<Column ss:Width=""84""/>") 'TGL LAHIR
                '.WriteLine("<Column ss:Width=""100""/>") 'ID
                '.WriteLine("<Column ss:Width=""100""/>") 'NO
                '.WriteLine("<Column ss:Width=""120""/>") 'NAMA
                '.WriteLine("<Column ss:Width=""100""/>") 'Alamat
                '.WriteLine("<Column ss:Width=""100""/>") 'TGL LAHIR
                '.WriteLine("<Column ss:Width=""100""/>") 'ID
                '.WriteLine("<Column ss:Width=""120""/>") 'NO
                '.WriteLine("<Column ss:Width=""120""/>") 'NAMA
                '.WriteLine("<Column ss:Width=""100""/>") 'Alamat
                '.WriteLine("<Column ss:Width=""120""/>") 'TGL LAHIR
                '.WriteLine("<Column ss:Width=""100""/>") 'ID
                '.WriteLine("<Column ss:Width=""93""/>") 'NO
                '.WriteLine("<Column ss:Width=""84""/>") 'NAMA
                '.WriteLine("<Column ss:Width=""100""/>") 'Alamat
                '.WriteLine("<Column ss:Width=""84""/>") 'TGL LAHIR
                '.WriteLine("<Column ss:Width=""100""/>") 'ID
                '.WriteLine("<Column ss:Width=""93""/>") 'NO
                '.WriteLine("<Column ss:Width=""84""/>") 'NAMA
                '.WriteLine("<Column ss:Width=""100""/>") 'Alamat
                '.WriteLine("<Column ss:Width=""200""/>") 'TGL LAHIR
            End If
            'data kosong
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String""></Data>")
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            'data kosong
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String""></Data>")
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            'AUTO SET HEADER
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String"">{0}</Data>", DGV.Columns.Item(i).HeaderText)
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            For intRow As Integer = 0 To DGV.RowCount - 1
                Application.DoEvents()
                .WriteLine("        <Row ss:StyleID=""ksg"" ss:utoFitHeight =""0"">")
                For intCol As Integer = 0 To DGV.Columns.Count - 1
                    Application.DoEvents()
                    .WriteLine("        <Cell ss:StyleID=""isi"">")
                    If intCol = 10 Or intCol = 17 Or intCol = 18 Or intCol = 19 Or intCol = 20 Or intCol = 22 Or intCol = 38 Or intCol = 41 Or intCol = 43 Then 'if column 7 or ... has date set custom format
                        If DGV.Item(intCol, intRow).Value = "0001-01-01" Then
                            .WriteLine("            <Data ss:Type=""String""></Data>")
                        Else
                            .WriteLine("            <Data ss:Type=""String"">{0}</Data>", Format(DGV.Item(intCol, intRow).Value, "yyyy-MM-dd").ToString())
                        End If
                    ElseIf intCol = 0 Then
                        If DGV.Item(intCol, intRow).Value = "0" Then
                            .WriteLine("            <Data ss:Type=""String""></Data>")
                        Else
                            .WriteLine("            <Data ss:Type=""String"">{0}</Data>", DGV.Item(intCol, intRow).Value)
                        End If
                    Else
                        .WriteLine("            <Data ss:Type=""String"">{0}</Data>", DGV.Item(intCol, intRow).Value)
                    End If


                    .WriteLine("        </Cell>")
                Next
                .WriteLine("        </Row>")
            Next
            .WriteLine("        </Table>")
            .WriteLine("    </Worksheet>")
            .WriteLine("</Workbook>")
            .Close()
        End With
    End Sub

    Private Sub BTNEXPORT_Click_1(sender As Object, e As EventArgs) Handles BTNEXPORT.Click
        Try
            If DTGridMT.RowCount = 0 Then Return

            BTNEXPORT.Text = "Please Wait..."
            BTNEXPORT.Enabled = False
            Application.DoEvents()

            Dim DGV As New DataGridView

            With DGV
                .AllowUserToAddRows = False
                .Name = "MT"
                .Visible = False
                .Columns.Clear()
                .Columns.Add("no_urut", "NO URUT")
                .Columns.Add("kode_rfid", "KODE RFID")
                .Columns.Add("kode_rfid2", "KODE RFID 2")
                .Columns.Add("no_polis", "NO POLIS")
                .Columns.Add("ket_blokir", "KET_BLOKIR")
                .Columns.Add("title", "TITLE")
                .Columns.Add("nama_perusahaan", "NAMA PERUSAHAAN")
                .Columns.Add("sts", "STATUS")
                .Columns.Add("merk_type", "MEREK TYPE")
                .Columns.Add("model", "MODEL")
                .Columns.Add("thn_pembuatan", "TAHUN PEMBUATAN")
                .Columns.Add("kapasitas", "KAPASITAS")
                .Columns.Add("kompartemen", "KOMPARTEMEN")
                .Columns.Add("produk", "PRODUK")
                .Columns.Add("no_mesin", "NO MESIN")
                .Columns.Add("no_rangka", "NO RANGKA")
                .Columns.Add("hsl_uji_emisi", "HASIL UJI EMISI")
                .Columns.Add("pas_masuk", "PAS MASUK")
                .Columns.Add("stnk", "STNK")
                .Columns.Add("keur", "KEUR")
                .Columns.Add("tera", "TERA")
                .Columns.Add("ijin_brg_khusus", "IJIN BARANG KHUSUS")
                .Columns.Add("skt", "SKT")
                .Columns.Add("no_pas", "NO PAS")
                .Columns.Add("status2", "STATUS")
                .Columns.Add("keterangan", "KETERANGAN")
                .Columns.Add("tgl_penerima", "TANGGAL PENERIMA")
                .Columns.Add("no_surat_tera", "NO SURAT TERA")
                .Columns.Add("komp1_t1", "KOMPARTEMEN T1")
                .Columns.Add("komp1_t2", "KOMPARTEMEN T2")
                .Columns.Add("komp1_t3", "KOMPARTEMEN T3")
                .Columns.Add("komp1_ruang_ksg", "KOMPARTEMEN RUANG KOSONG")
                .Columns.Add("komp1_k1", "KOMPARTEMEN k1")
                .Columns.Add("komp2_t1", "KOMPARTEMEN2 T1")
                .Columns.Add("komp2_t2", "KOMPARTEMEN2 T2")
                .Columns.Add("komp2_t3", "KOMPARTEMEN2 T3")
                .Columns.Add("komp2_ruang_ksg", "KOMPARTEMEN2 RUANG KOSONG")
                .Columns.Add("komp2_k1", "KOMPARTEMEN2 K1")
                .Columns.Add("tera2", "TERA 2")
                .Columns.Add("thn_pembuatan2", "TAHUN PEMBUATAN 2")
                .Columns.Add("no_stnk", "NO STNK")
                .Columns.Add("m_berlaku_stnk", "MASA BERLAKU STNK")
                .Columns.Add("no_keur", "NO KEUR")
                .Columns.Add("m_berlaku_kier", "MASA BERLAKU KIER")
                .Columns.Add("no_dok_uji_emisi", "NO DOK UJI EMISI")
                '.Columns.Add("hasil_uji_emisi", "HASIL UJI EMISI")
                '.Columns.Add("m_berlaku_uji_emisi", "MASA BERLAKU UJI EMISI")
                '.Columns.Add("no_spb_skt", "NO SPB/SKT")
                '.Columns.Add("m_berlaku_spb_mkt", "MASA BERLAKU SPB/SKT")
                '.Columns.Add("no_z_m_terminal_bbm", "No. Izin Prinsip Masuk Terminal BBM")
                '.Columns.Add("no_izin_masuk", "No. Izin Masuk")
                '.Columns.Add("kode_area", "KODE AREA")
                '.Columns.Add("area", "AREA")
                '.Columns.Add("kd_lokasi", "KODE LOKASI")
                '.Columns.Add("lokasi", "LOKASI")
                '.Columns.Add("kd_kategori", "KODE KATEGORI")
                '.Columns.Add("kategori", "KATEGORI")
                '.Columns.Add("delivery_point", "DELIVERY POINT")
                '.Columns.Add("sewa", "SEWA")
                '.Columns.Add("tarif", "TARIF")
                '.Columns.Add("agen", "AGEN")
                '.Columns.Add("industri", "INDUSTRI")
                '.Columns.Add("angkutan_sendiri", "ANGKUTAN SENDIRI")
                '.Columns.Add("umur", "UMUR")
                '.Columns.Add("kat", "KETERANGAN")
                '.Columns.Add("produk2", "PRODUK2")
                '.Columns.Add("engkel_tronton_semit", "ENGKEL/TRONTON/SEMI TRAILER")
                '.Columns.Add("pabrikan_tangki", "PABRIKAN TANGKI")
                '.Columns.Add("material_tangki", "MATERIAL TANGKI")
                '.Columns.Add("pembuatan_tangki", "PEMBUATAN TANGKI")
                '.Columns.Add("sts_armada", "STATUS ARMADA")
                '.Columns.Add("plat", "PLAT")
                '.Columns.Add("asuransi", "ASURANSI")
                '.Columns.Add("alamat", "ALAMAT")
                '.Columns.Add("telepon", "TELEPON")
                '.Columns.Add("email", "EMAIL")
                '.Columns.Add("npwp", "NPWP")
                '.Columns.Add("penanggung_jawab", "PENANGGUNG JAWAB")
                '.Columns.Add("jabatan", "JABATAN")
                '.Columns.Add("data_umur_mt", "DATA UMUR MT")


                .Columns("no_urut").DataPropertyName = "no_urut"
                .Columns("kode_rfid").DataPropertyName = "kode_rfid"
                .Columns("kode_rfid2").DataPropertyName = "kode_rfid2"
                .Columns("no_polis").DataPropertyName = "no_polis"
                .Columns("ket_blokir").DataPropertyName = "ket_blokir"
                .Columns("title").DataPropertyName = "title"
                .Columns("nama_perusahaan").DataPropertyName = "nama_perusahaan"
                .Columns("sts").DataPropertyName = "sts"
                .Columns("merk_type").DataPropertyName = "merk_type"
                .Columns("model").DataPropertyName = "model"
                .Columns("thn_pembuatan").DataPropertyName = "thn_pembuatan"
                .Columns("kapasitas").DataPropertyName = "kapasitas"
                .Columns("kompartemen").DataPropertyName = "kompartemen"
                .Columns("produk").DataPropertyName = "produk"
                .Columns("no_mesin").DataPropertyName = "no_mesin"
                .Columns("no_rangka").DataPropertyName = "no_rangka"
                .Columns("hsl_uji_emisi").DataPropertyName = "hsl_uji_emisi"
                .Columns("pas_masuk").DataPropertyName = "pas_masuk"
                .Columns("stnk").DataPropertyName = "stnk"
                .Columns("keur").DataPropertyName = "keur"
                .Columns("tera").DataPropertyName = "tera"
                .Columns("ijin_brg_khusus").DataPropertyName = "ijin_brg_khusus"
                .Columns("skt").DataPropertyName = "skt"
                .Columns("no_pas").DataPropertyName = "no_pas"
                .Columns("status2").DataPropertyName = "status2"
                .Columns("keterangan").DataPropertyName = "keterangan"
                .Columns("tgl_penerima").DataPropertyName = "tgl_penerima"
                .Columns("no_surat_tera").DataPropertyName = "no_surat_tera"
                .Columns("komp1_t1").DataPropertyName = "komp1_t1"
                .Columns("komp1_t2").DataPropertyName = "komp1_t2"
                .Columns("komp1_t3").DataPropertyName = "komp1_t3"
                .Columns("komp1_ruang_ksg").DataPropertyName = "komp1_ruang_ksg"
                .Columns("komp1_k1").DataPropertyName = "komp1_k1"
                .Columns("komp2_t1").DataPropertyName = "komp2_t1"
                .Columns("komp2_t2").DataPropertyName = "komp2_t2"
                .Columns("komp2_t3").DataPropertyName = "komp2_t3"
                .Columns("komp2_ruang_ksg").DataPropertyName = "komp2_ruang_ksg"
                .Columns("komp2_k1").DataPropertyName = "komp2_k1"
                .Columns("tera2").DataPropertyName = "tera2"
                .Columns("thn_pembuatan2").DataPropertyName = "thn_pembuatan2"
                .Columns("no_stnk").DataPropertyName = "no_stnk"
                .Columns("m_berlaku_stnk").DataPropertyName = "m_berlaku_stnk"
                .Columns("no_keur").DataPropertyName = "no_keur"
                .Columns("m_berlaku_kier").DataPropertyName = "m_berlaku_kier"
                .Columns("no_dok_uji_emisi").DataPropertyName = "no_dok_uji_emisi"
                '.Columns("hasil_uji_emisi").DataPropertyName = "hasil_uji_emisi"
                '.Columns("m_berlaku_uji_emisi").DataPropertyName = "m_berlaku_uji_emisi"
                '.Columns("no_spb_skt").DataPropertyName = "no_spb_skt"
                '.Columns("m_berlaku_spb_mkt").DataPropertyName = "m_berlaku_spb_mkt"
                '.Columns("no_z_m_terminal_bbm").DataPropertyName = "no_z_m_terminal_bbm"
                '.Columns("no_izin_masuk").DataPropertyName = "no_izin_masuk"
                '.Columns("kode_area").DataPropertyName = "kode_area"
                '.Columns("area").DataPropertyName = "area"
                '.Columns("kd_lokasi").DataPropertyName = "kd_lokasi"
                '.Columns("lokasi").DataPropertyName = "lokasi"
                '.Columns("kd_kategori").DataPropertyName = "kd_kategori"
                '.Columns("kategori").DataPropertyName = "kategori"
                '.Columns("delivery_point").DataPropertyName = "delivery_point"
                '.Columns("sewa").DataPropertyName = "sewa"
                '.Columns("tarif").DataPropertyName = "tarif"
                '.Columns("agen").DataPropertyName = "agen"
                '.Columns("industri").DataPropertyName = "industri"
                '.Columns("angkutan_sendiri").DataPropertyName = "angkutan_sendiri"
                '.Columns("umur").DataPropertyName = "umur"
                '.Columns("kat").DataPropertyName = "kat"
                '.Columns("produk2").DataPropertyName = "produk2"
                '.Columns("engkel_tronton_semit").DataPropertyName = "engkel_tronton_semit"
                '.Columns("pabrikan_tangki").DataPropertyName = "pabrikan_tangki"
                '.Columns("material_tangki").DataPropertyName = "material_tangki"
                '.Columns("pembuatan_tangki").DataPropertyName = "pembuatan_tangki"
                '.Columns("sts_armada").DataPropertyName = "sts_armada"
                '.Columns("plat").DataPropertyName = "plat"
                '.Columns("asuransi").DataPropertyName = "asuransi"
                '.Columns("alamat").DataPropertyName = "alamat"
                '.Columns("telepon").DataPropertyName = "telepon"
                '.Columns("email").DataPropertyName = "email"
                '.Columns("npwp").DataPropertyName = "npwp"
                '.Columns("penanggung_jawab").DataPropertyName = "penanggung_jawab"
                '.Columns("jabatan").DataPropertyName = "jabatan"
                '.Columns("data_umur_mt").DataPropertyName = "data_umur_mt"


            End With
            With DTGridMT
                If .Rows.Count > 0 Then
                    For i As Integer = 0 To .Rows.Count - 1
                        Application.DoEvents()
                        DGV.Rows.Add(.Rows(i).Cells("no_urut").Value,
    .Rows(i).Cells("kode_rfid").Value,
    .Rows(i).Cells("kode_rfid2").Value,
    .Rows(i).Cells("no_polis").Value,
    .Rows(i).Cells("ket_blokir").Value,
    .Rows(i).Cells("title").Value,
    .Rows(i).Cells("nama_perusahaan").Value,
    .Rows(i).Cells("sts").Value,
    .Rows(i).Cells("merk_type").Value,
    .Rows(i).Cells("model").Value,
    .Rows(i).Cells("thn_pembuatan").Value,
    .Rows(i).Cells("kapasitas").Value,
    .Rows(i).Cells("kompartemen").Value,
    .Rows(i).Cells("produk").Value,
    .Rows(i).Cells("no_mesin").Value,
    .Rows(i).Cells("no_rangka").Value,
    .Rows(i).Cells("hsl_uji_emisi").Value,
    .Rows(i).Cells("pas_masuk").Value,
    .Rows(i).Cells("stnk").Value,
    .Rows(i).Cells("keur").Value,
    .Rows(i).Cells("tera").Value,
    .Rows(i).Cells("ijin_brg_khusus").Value,
    .Rows(i).Cells("skt").Value,
    .Rows(i).Cells("no_pas").Value,
    .Rows(i).Cells("status2").Value,
    .Rows(i).Cells("keterangan").Value,
    .Rows(i).Cells("tgl_penerima").Value,
    .Rows(i).Cells("no_surat_tera").Value,
    .Rows(i).Cells("komp1_t1").Value,
    .Rows(i).Cells("komp1_t2").Value,
    .Rows(i).Cells("komp1_t3").Value,
    .Rows(i).Cells("komp1_ruang_ksg").Value,
    .Rows(i).Cells("komp1_k1").Value,
    .Rows(i).Cells("komp2_t1").Value,
    .Rows(i).Cells("komp2_t2").Value,
    .Rows(i).Cells("komp2_t3").Value,
    .Rows(i).Cells("komp2_ruang_ksg").Value,
    .Rows(i).Cells("komp2_k1").Value,
    .Rows(i).Cells("tera2").Value,
    .Rows(i).Cells("thn_pembuatan2").Value,
    .Rows(i).Cells("no_stnk").Value,
    .Rows(i).Cells("m_berlaku_stnk").Value,
    .Rows(i).Cells("no_keur").Value,
    .Rows(i).Cells("m_berlaku_kier").Value,
    .Rows(i).Cells("no_dok_uji_emisi").Value)
                        '.Rows(i).Cells("hasil_uji_emisi").Value,
                        '.Rows(i).Cells("m_berlaku_uji_emisi").Value,
                        '.Rows(i).Cells("no_spb_skt").Value,
                        '.Rows(i).Cells("m_berlaku_spb_mkt").Value,
                        '.Rows(i).Cells("no_z_m_terminal_bbm").Value,
                        '.Rows(i).Cells("no_izin_masuk").Value,
                        '.Rows(i).Cells("kode_area").Value,
                        '.Rows(i).Cells("area").Value,
                        '.Rows(i).Cells("kd_lokasi").Value,
                        '.Rows(i).Cells("lokasi").Value,
                        '.Rows(i).Cells("kd_kategori").Value,
                        '.Rows(i).Cells("kategori").Value,
                        '.Rows(i).Cells("delivery_point").Value,
                        '.Rows(i).Cells("sewa").Value,
                        '.Rows(i).Cells("tarif").Value,
                        '.Rows(i).Cells("agen").Value,
                        '.Rows(i).Cells("industri").Value,
                        '.Rows(i).Cells("angkutan_sendiri").Value,
                        '.Rows(i).Cells("umur").Value,
                        '.Rows(i).Cells("kat").Value,
                        '.Rows(i).Cells("produk2").Value,
                        '.Rows(i).Cells("engkel_tronton_semit").Value,
                        '.Rows(i).Cells("pabrikan_tangki").Value,
                        '.Rows(i).Cells("material_tangki").Value,
                        '.Rows(i).Cells("pembuatan_tangki").Value,
                        '.Rows(i).Cells("sts_armada").Value,
                        '.Rows(i).Cells("plat").Value,
                        '.Rows(i).Cells("asuransi").Value,
                        '.Rows(i).Cells("alamat").Value,
                        '.Rows(i).Cells("telepon").Value,
                        '.Rows(i).Cells("email").Value,
                        '.Rows(i).Cells("npwp").Value,
                        '.Rows(i).Cells("penanggung_jawab").Value,
                        '.Rows(i).Cells("jabatan").Value,
                        '.Rows(i).Cells("data_umur_mt").Value)
                    Next
                End If
            End With
            FlNm = Application.StartupPath & "\EXPORT\MT " _
                    & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
            If File.Exists(FlNm) Then File.Delete(FlNm)
            ExportToExcel(DGV)

            DGV.Dispose()
            DGV = Nothing

            Process.Start(FlNm)

            'Save the Excel file.

            BTNEXPORT.Text = "EXPORT EXCEL"
            BTNEXPORT.Enabled = True
            MessageBox.Show("Save Ulang Dengan Format xlsx atau xls", "SAVE ULANG", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Excel Harap ditutup")
            BTNEXPORT.Text = "EXPORT EXCEL"
            BTNEXPORT.Enabled = True
        End Try
    End Sub
    Sub CLICKgRIDvIEW()
        Dim i As Integer

        Try
            With DTGridMT
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else


                    i = .CurrentRow.Index
                    'ID
                    dataId = .Rows(i).Cells(0).Value
                    'untuk date
                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(11).Value) AndAlso .Rows(i).Cells(11).Value IsNot Nothing Then

                        DATETHNBUATAN.Text = .Rows(i).Cells(11).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATETHNBUATAN.Value = Today
                    End If
                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(18).Value) AndAlso .Rows(i).Cells(18).Value IsNot Nothing Then

                        DATEPASMASUK.Text = .Rows(i).Cells(18).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEPASMASUK.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(19).Value) AndAlso .Rows(i).Cells(19).Value IsNot Nothing Then

                        DATESTNK.Text = .Rows(i).Cells(19).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATESTNK.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(20).Value) AndAlso .Rows(i).Cells(20).Value IsNot Nothing Then

                        DATEKEUR.Text = .Rows(i).Cells(20).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEKEUR.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(21).Value) AndAlso .Rows(i).Cells(21).Value IsNot Nothing Then

                        DATETERA.Text = .Rows(i).Cells(21).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATETERA.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(23).Value) AndAlso .Rows(i).Cells(23).Value IsNot Nothing Then

                        DATESKT.Text = .Rows(i).Cells(23).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATESKT.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(39).Value) AndAlso .Rows(i).Cells(39).Value IsNot Nothing Then

                        DATETERA2.Text = .Rows(i).Cells(39).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATETERA2.Value = Today
                    End If

                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(42).Value) AndAlso .Rows(i).Cells(42).Value IsNot Nothing Then

                        DATEMLAKUSTNK.Text = .Rows(i).Cells(42).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEMLAKUSTNK.Value = Today
                    End If
                    If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(44).Value) AndAlso .Rows(i).Cells(44).Value IsNot Nothing Then

                        DATEMLAKUKIER.Text = .Rows(i).Cells(44).Value
                    Else
                        'jika baris atau sel kosong, lakukan tindakan yang sesuai
                        DATEMLAKUKIER.Value = Today
                    End If

                    'untuk text
                    TXTKRFID.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(2).Value) AndAlso .Rows(i).Cells(2).Value IsNot Nothing, .Rows(i).Cells(2).Value.ToString(), "")
                    TXTKRFID2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(3).Value) AndAlso .Rows(i).Cells(3).Value IsNot Nothing, .Rows(i).Cells(3).Value.ToString(), "")
                    TXTNOPOLIS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(4).Value) AndAlso .Rows(i).Cells(4).Value IsNot Nothing, .Rows(i).Cells(4).Value.ToString(), "")
                    TXTKBLOKIR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(5).Value) AndAlso .Rows(i).Cells(5).Value IsNot Nothing, .Rows(i).Cells(5).Value.ToString(), "")
                    TXTTITLE.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(6).Value) AndAlso .Rows(i).Cells(6).Value IsNot Nothing, .Rows(i).Cells(6).Value.ToString(), "")
                    TXTNPERUSAHAAN.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(7).Value) AndAlso .Rows(i).Cells(7).Value IsNot Nothing, .Rows(i).Cells(7).Value.ToString(), "")
                    TXTSTATUS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(8).Value) AndAlso .Rows(i).Cells(8).Value IsNot Nothing, .Rows(i).Cells(8).Value.ToString(), "")
                    TXTMTYPE.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(9).Value) AndAlso .Rows(i).Cells(9).Value IsNot Nothing, .Rows(i).Cells(9).Value.ToString(), "")
                    TXTMODEL.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(10).Value) AndAlso .Rows(i).Cells(10).Value IsNot Nothing, .Rows(i).Cells(10).Value.ToString(), "")
                    TXTKAPASITAS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(12).Value) AndAlso .Rows(i).Cells(12).Value IsNot Nothing, .Rows(i).Cells(12).Value.ToString(), "")
                    TXTKOMPATEMENT.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(13).Value) AndAlso .Rows(i).Cells(13).Value IsNot Nothing, .Rows(i).Cells(13).Value.ToString(), "")

                    TXTPRODUK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(14).Value) AndAlso .Rows(i).Cells(14).Value IsNot Nothing, .Rows(i).Cells(14).Value.ToString(), "")
                    TXTNOMESIN.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(15).Value) AndAlso .Rows(i).Cells(15).Value IsNot Nothing, .Rows(i).Cells(15).Value.ToString(), "")
                    TXTNRANGKA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(16).Value) AndAlso .Rows(i).Cells(16).Value IsNot Nothing, .Rows(i).Cells(16).Value.ToString(), "")
                    TXTHUEMISI.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(17).Value) AndAlso .Rows(i).Cells(17).Value IsNot Nothing, .Rows(i).Cells(17).Value.ToString() & "%", "")
                    TXTIZBKHUSU.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(22).Value) AndAlso .Rows(i).Cells(22).Value IsNot Nothing, .Rows(i).Cells(22).Value.ToString(), "")
                    TXTNPAS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(24).Value) AndAlso .Rows(i).Cells(24).Value IsNot Nothing, .Rows(i).Cells(24).Value.ToString(), "")
                    TXTSTATUS2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(25).Value) AndAlso .Rows(i).Cells(25).Value IsNot Nothing, .Rows(i).Cells(25).Value.ToString(), "")


                    TXTKET.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(26).Value) AndAlso .Rows(i).Cells(26).Value IsNot Nothing, .Rows(i).Cells(26).Value.ToString(), "")
                    TXTTGLTERIMA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(27).Value) AndAlso .Rows(i).Cells(27).Value IsNot Nothing, .Rows(i).Cells(27).Value.ToString(), "")
                    TXTNOSTERA.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(28).Value) AndAlso .Rows(i).Cells(28).Value IsNot Nothing, .Rows(i).Cells(28).Value.ToString(), "")
                    TXTKOMPT1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(29).Value) AndAlso .Rows(i).Cells(29).Value IsNot Nothing, .Rows(i).Cells(29).Value.ToString(), "")
                    TXTKOMPT2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(30).Value) AndAlso .Rows(i).Cells(30).Value IsNot Nothing, .Rows(i).Cells(30).Value.ToString(), "")
                    TXTKOMPT3.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(31).Value) AndAlso .Rows(i).Cells(31).Value IsNot Nothing, .Rows(i).Cells(31).Value.ToString(), "")
                    TXTKOMPKSONG.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(32).Value) AndAlso .Rows(i).Cells(32).Value IsNot Nothing, .Rows(i).Cells(32).Value.ToString(), "")
                    TXTKOMPK1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(33).Value) AndAlso .Rows(i).Cells(33).Value IsNot Nothing, .Rows(i).Cells(33).Value.ToString(), "")
                    TXTKOMP2T1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(34).Value) AndAlso .Rows(i).Cells(34).Value IsNot Nothing, .Rows(i).Cells(34).Value.ToString(), "")
                    TXTKOMP2T2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(35).Value) AndAlso .Rows(i).Cells(35).Value IsNot Nothing, .Rows(i).Cells(35).Value.ToString(), "")
                    TXTKOMP2T3.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(36).Value) AndAlso .Rows(i).Cells(36).Value IsNot Nothing, .Rows(i).Cells(36).Value.ToString(), "")
                    TXTKOMP2RKSONG.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(37).Value) AndAlso .Rows(i).Cells(37).Value IsNot Nothing, .Rows(i).Cells(37).Value.ToString(), "")
                    TXTKOMP2K1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(38).Value) AndAlso .Rows(i).Cells(38).Value IsNot Nothing, .Rows(i).Cells(38).Value.ToString(), "")

                    TXTTHNBUATAN2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(40).Value) AndAlso .Rows(i).Cells(40).Value IsNot Nothing, .Rows(i).Cells(40).Value.ToString(), "")
                    TXTNSTNK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(41).Value) AndAlso .Rows(i).Cells(41).Value IsNot Nothing, .Rows(i).Cells(41).Value.ToString(), "")
                    TXTNKEUR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(43).Value) AndAlso .Rows(i).Cells(43).Value IsNot Nothing, .Rows(i).Cells(43).Value.ToString(), "")
                    TXTNODOKEMISI.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(45).Value) AndAlso .Rows(i).Cells(45).Value IsNot Nothing, .Rows(i).Cells(45).Value.ToString(), "")

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
                    DTGridMT.Enabled = False

                End If
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try


    End Sub



    Private Sub DTGridMT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGridMT.CellClick
        CLICKgRIDvIEW()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class