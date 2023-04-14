Imports System.Drawing.Printing
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

    'Private Sub kondisiawal()
    '    Try
    '        KosongkanData()

    '        'txtJMHole2.Enabled = True
    '        'txtJMHole1.Enabled = True
    '        'txtDATEJUkur.Enabled = True

    '        'txtId.ReadOnly = True
    '        'CBIDUnit.Enabled = False
    '        'CBIDKamar.Enabled = False
    '        'txtKTemen2.ReadOnly = True
    '        'txtKTemen1.ReadOnly = True
    '        'txtMTangki.Enabled = False
    '        'CBIDKamar.Enabled = False
    '        'txtPlatKendaraan.Enabled = False
    '        'DateKendaraan.Enabled = False
    '        'CBBayar.Enabled = False
    '        'DateBayar.Enabled = False
    '        'DateJTempo.Enabled = False
    '        'txtTanggal.Enabled = False
    '        'txtKasir.Enabled = False
    '        'txtJam.Enabled = False
    '        'DateJTempo.Enabled = False
    '        'txtTempo.Enabled = False
    '        'txtHargaSw.MaxLength = 20
    '        txtJMHole1.Focus()

    '        ImgInput = AppMobilTangki.My.Resources.Resources.save
    '        ImgEdit = AppMobilTangki.My.Resources.Resources.update
    '        ImgHapus = AppMobilTangki.My.Resources.Resources.sampah
    '        ImgClear = AppMobilTangki.My.Resources.Resources.clear
    '        imgBatal = AppMobilTangki.My.Resources.Resources.batal
    '        imgSimpan = AppMobilTangki.My.Resources.Resources.simpan
    '        imgUpdate = AppMobilTangki.My.Resources.Resources.edit

    '        BtnTambah.Text = "INPUT"
    '        BtnTambah.Image = ImgInput
    '        BtnEdit.Text = "EDIT"
    '        BtnEdit.Image = ImgEdit
    '        btnHapus.Text = "HAPUS"
    '        btnHapus.Image = ImgHapus
    '        btnClear.Text = "CLEAR"
    '        btnClear.Image = ImgClear

    '        BtnTambah.Enabled = True
    '        btnHapus.Enabled = False
    '        BtnEdit.Enabled = False


    '        KoneksiKeDatabase()
    '        QUERY = "Select * FROM tbl_transaksi order by id"
    '        DA = New MySqlDataAdapter(QUERY, CONN)
    '        DS = New DataSet
    '        DA.Fill(DS, "tbl_transaksi")
    '        DataGridTranksaksi.DataSource = DS.Tables("tbl_transaksi")

    '        With DataGridTranksaksi
    '            '    '.Columns(0).Width = 200
    '            '    .Columns(1).Width = 200
    '            '    .Columns(2).Width = 80
    '            '    .Columns(3).Width = 100
    '            '    .Columns(4).Width = 100
    '            '    .Columns(5).Width = 100
    '            '    .Columns(6).Width = 90
    '            '    .Columns(7).Width = 90
    '            '    .Columns(8).Width = 120

    '            '.Columns(0).DataPropertyName = "id"
    '            '.Columns(1).DataPropertyName = "nama_perusahaan"
    '            '.Columns(2).DataPropertyName = "no_plat_mobil"
    '            '.Columns(3).DataPropertyName = "mobil_tangki"
    '            '.Columns(4).DataPropertyName = "id_kompartemen1"
    '            '.Columns(5).DataPropertyName = "id_kompartemen2"
    '            '.Columns(6).DataPropertyName = "jrk_m_hole1"
    '            '.Columns(7).DataPropertyName = "jrk_m_hole2"
    '            '.Columns(8).DataPropertyName = "tgl_jam_ukur"


    '            .Columns(0).Visible = False
    '            .Columns(1).HeaderText = "Jarak Meter Hole 1"
    '            .Columns(2).HeaderText = "Jarak Meter Hole 2"
    '            .Columns(3).HeaderText = "Tanggal Pengukuran"

    '            .Columns(4).Visible = False
    '            .Columns(5).Visible = False
    '            .Columns(6).Visible = False
    '            .Columns(7).Visible = False
    '            .Columns(8).Visible = False
    '            '.Columns(9).Visible = False
    '            '.Columns(10).Visible = False
    '            '.Columns(11).HeaderText = "NIK AMT"
    '            '.Columns(12).HeaderText = "Nama AMT"
    '            '.Columns(13).HeaderText = "Tempat Lahir"
    '            '.Columns(14).HeaderText = "Tanggal Lahir"
    '            '.Columns(15).HeaderText = "USIA"
    '            '.Columns(16).HeaderText = "NIK AMT"
    '            '.Columns(17).HeaderText = "Nama AMT"
    '            '.Columns(18).HeaderText = "Tempat Lahir"
    '            '.Columns(19).HeaderText = "Tanggal Lahir"
    '            '.Columns(20).HeaderText = "USIA"
    '            '.Columns(21).HeaderText = "Transportir"

    '            '.Columns(0).Visible = False

    '            '.Columns(9).Visible = False
    '            '.Columns(10).Visible = False

    '            '.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            '    .EnableHeadersVisualStyles = False
    '            '    '.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
    '            '    '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    '            '    .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)
    '            '    '.DefaultCellStyle.ForeColor = Color.DarkRed
    '            '    '.RowsDefaultCellStyle.BackColor = Color.PaleGreen
    '            '    '.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGreen
    '            '    '.AlternatingRowsDefaultCellStyle.ForeColor = Color.White
    '            '    '.GridColor = Color.DarkRed
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Focus()
        'KoneksiKeDatabase()
        'kondisiawal()
        kosongidata()
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
        LBLTGL.Text = DateTime.Now.ToString("dd-MMMM-yyyy")
        LBLJAM.Text = DateTime.Now.ToString("HH:mm:ss")
        tglsekarang = Today
    End Sub

    Private Sub KosongkanData()
        'txtCari.Text = ""
        'txtJMHole1.Text = ""
        'txtJMHole2.Text = ""
        'txtDATEJUkur.Text = ""
    End Sub

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Longpaper As Integer

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        'Try
        'If txtJMHole1.Text = "" Or
        '        txtJMHole2.Text = "" Then
        '    MsgBox("Silahkan Isi Semua Data")
        'Else
        '    Call KoneksiKeDatabase()
        '        'QUERY = "INSERT INTO tbl_transaksi values ('','" & txtJMHole1.Text & "','" & txtJMHole2.Text & "','" & Format(tglsekarang, "yyyy-MM-dd") & "','-','-','-','-','-')"
        '        QUERY = "INSERT INTO `tbl_transaksi`(`id`, `jrk_m_hole1`, `jrk_m_hole2`, `tgl_jam_ukur`, `a`, `b`, `c`, `d`, `e`) VALUES ('','" & txtJMHole1.Text & "','" & txtJMHole2.Text & "','" & Format(tglsekarang, "yyyy-MM-dd") & "','-','-','-','-','-')"
        '        DA = New MySqlDataAdapter(QUERY, CONN)
        '        DS = New DataSet
        '        DA.Fill(DS)

        Dim A As String = MsgBox("PRINT QRCODE...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "PRINT QRCODE")
        Select Case A
            Case vbCancel
                FormMenu_Load(sender, e)
                MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                Call KosongkanData()
                Exit Sub
            Case vbOK
                'MsgBox("Print QRCODE")
                changelongpaper()
                PPD.Document = PD2
                PPD.ShowDialog()
                'Print barcode
        End Select


        '        FormMenu_Load(sender, e)
        '        Call KosongkanData()
        '    End If
        'Catch ex As Exception
        '    MsgBox("Gagal Di tambah")
        'End Try
    End Sub

    Private Sub PD2_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD2.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed long paper
        pagesetup.PaperSize = New PaperSize("Custom", 250, Longpaper)
        PD2.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PD2.PrintPage
        Try
            Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
            Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
            Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
            Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

            Dim leftmargin As Integer = PD2.DefaultPageSettings.Margins.Left
            Dim centermargin As Integer = PD2.DefaultPageSettings.PaperSize.Width / 2
            Dim rightmargin As Integer = PD2.DefaultPageSettings.PaperSize.Width

            'font alignment
            Dim right As New StringFormat
            Dim center As New StringFormat
            right.Alignment = StringAlignment.Far
            center.Alignment = StringAlignment.Center

            Dim line As String
            line = "***************************************************************************"
            'e.Graphics.DrawString("Coba Stroe", f14, Brushes.Black, centermargin, 5, center)
            'Dim logo As Image = My.Resources.ResourceManager.GetObject("tanki") 'logo
            'e.Graphics.DrawImage(logo, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 35)
            'e.Graphics.DrawString("New York", f10, Brushes.Black, centermargin, 40, center)
            'e.Graphics.DrawString("TEL +1987", f8, Brushes.Black, centermargin, 55, center)

            'e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 75)
            'e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
            'e.Graphics.DrawString("KFGS1654", f8, Brushes.Black, 70, 75)

            'e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 85)
            'e.Graphics.DrawString(":", f8, Brushes.Black, 50, 85)
            'e.Graphics.DrawString("Andri", f8, Brushes.Black, 70, 85)

            e.Graphics.DrawString(Today, f8, Brushes.Black, 0, 95)

            e.Graphics.DrawString(line, f8, Brushes.Black, 0, 125)

            'Dim height As Integer
            'Dim i As Long
            'DataGridView1.AllowUserToAddRows = False
            'For row As Integer = 0 To DataGridView1.RowCount - 1
            '    height += 15
            '    e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 115 + height)
            '    e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 25, 115 + height)

            '    i = DataGridView1.Rows(row).Cells(2).Value
            '    DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            '    e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 115 + height, right)

            'Next

            Dim height2 As Integer
            'total()

            'height2 = 140 + height
            'e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
            'e.Graphics.DrawString("Total :" & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 15 + height2, right)
            'e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 15 + height2)


            'bercode
                Dim qrCode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
                Try
                    Dim qrCodeImage As Image
                'qrCodeImage = New Bitmap(qrCode.Encode("1: " & LBLID1.Text & vbCrLf & "2: " & LBLID2.Text & vbCrLf & "3: " & LBLJRKHOLE1.Text & vbCrLf & "4: " & LBLJRKHOLE2.Text & vbCrLf & "5: " & LBLAMT.Text & vbCrLf & "6: " & LBLPLATNO.Text & vbCrLf & "7: " & LBLKAPASTAS.Text & vbCrLf & "8: " & LBLPRODUK.Text & vbCrLf & "9: " & LBLMEREK.Text & vbCrLf & "10: " & LBLOPERATOR.Text & vbCrLf & "11: " & LBLJAM.Text & " " & LBLTGL.Text))
                qrCodeImage = New Bitmap(qrCode.Encode("1: " & LBLID1.Text & vbCrLf & "2: " & LBLID2.Text & vbCrLf & "3: " & LBLJRKHOLE1.Text & vbCrLf & "4: " & LBLJRKHOLE2.Text & vbCrLf & "5: " & LBLAMT.Text & vbCrLf & "6: " & LBLPLATNO.Text & vbCrLf & "7: " & LBLKAPASTAS.Text & vbCrLf & "8: " & LBLPRODUK.Text & vbCrLf & "9: " & LBLMEREK.Text & vbCrLf & "10: " & LBLOPERATOR.Text))
                e.Graphics.DrawImage(qrCodeImage, CInt((e.PageBounds.Width - 60) / 2), 60 + height2, 60, 60)

                Catch ex As Exception
                    MsgBox(ex.Message, "EROR")
                End Try
                e.Graphics.DrawString("~~ TERIMAKASIH ~~", f10b, Brushes.Black, centermargin, 140 + height2, center)
                'e.Graphics.DrawString("~~ STORE ~~", f10b, Brushes.Black, centermargin, 135 + height2, center)
            Catch ex As Exception

        End Try


    End Sub
    Dim t_price As Long
    Dim t_qty As Long

    'Sub total()
    '    Dim countprince As Long = 0
    '    For rowItem As Long = 0 To DataGridView1.RowCount - 1
    '        countprince = countprince + Val(DataGridView1.Rows(rowItem).Cells(2).Value * Val(DataGridView1.Rows(rowItem).Cells(1).Value))
    '    Next
    '    t_price = countprince

    '    Dim countqty As Long
    '    For rowItem As Long = 0 To DataGridView1.RowCount - 1
    '        countqty = countqty + Val(DataGridView1.Rows(rowItem).Cells(1).Value)
    '    Next
    '    t_qty = countqty
    'End Sub

    Private Sub changelongpaper()
        Dim rowcount As Integer
        Longpaper = 0
        'rowcount = DataGridView1.Rows.Count
        Longpaper = rowcount * 15
        Longpaper = Longpaper + 210
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'txtJMHole1.Text = ""
        'txtJMHole2.Text = ""
        'txtJMHole1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub kosongidata()
        LBLID1.Text = ""
        LBLID2.Text = ""
        LBLJRKHOLE1.Text = ""
        LBLJRKHOLE2.Text = ""
        LBLKAPASTAS.Text = ""
        LBLMEREK.Text = ""
        LBLPLATNO.Text = ""
        LBLAMT.Text = ""
        LBLOPERATOR.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim myVariable As String = TextBox1.Text
                Dim myValues() As String = myVariable.Trim("*"c, "#"c).Split(","c)

                Dim value1 As String = myValues(0)
                Dim value2 As Double = Double.Parse(myValues(1))

                Call KoneksiKeDatabase()
                CMD = New MySqlCommand("select * from `relasimtdanamt` where `no_polis`='" & value1 & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    LBLID1.Text = value1
                    LBLJRKHOLE1.Text = value2
                    LBLAMT.Text = RD.Item("nama_amt1")
                    LBLPLATNO.Text = RD.Item("no_polis")
                    LBLKAPASTAS.Text = RD.Item("kapasitas")
                    LBLPRODUK.Text = RD.Item("produk")
                    LBLMEREK.Text = RD.Item("merk_type")
                    LBLOPERATOR.Text = lblNLengkap.Text
                Else
                    kosongidata()
                    MessageBox.Show("GAGAL DITEMUKAN", "GAGAL ORDER")
                    Exit Sub
                End If
                MessageBox.Show("Berhasil ditambah", "SUKSES")
            End If
        Catch ex As Exception
            MsgBox("Input Format Salah", MsgBoxStyle.Exclamation, "EROR")
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Dim myVariable As String = TextBox2.Text
                Dim myValues() As String = myVariable.Trim("*"c, "#"c).Split(","c)

                Dim value1 As String = myValues(0)
                Dim value2 As Double = Double.Parse(myValues(1))

                Call KoneksiKeDatabase()
                CMD = New MySqlCommand("select * from `relasimtdanamt` where `no_polis`='" & value1 & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows = True Then
                    LBLID2.Text = value1
                    LBLJRKHOLE2.Text = value2
                    LBLAMT.Text = RD.Item("nama_amt1")
                    LBLPLATNO.Text = RD.Item("no_polis")
                    LBLKAPASTAS.Text = RD.Item("kapasitas")
                    LBLPRODUK.Text = RD.Item("produk")
                    LBLMEREK.Text = RD.Item("merk_type")
                    LBLOPERATOR.Text = lblNLengkap.Text
                Else
                    kosongidata()
                    MessageBox.Show("GAGAL DITEMUKAN", "GAGAL ORDER")
                    Exit Sub
                End If
                MessageBox.Show("Berhasil ditambah", "SUKSES")
            End If
        Catch ex As Exception
            MsgBox("Input Format Salah", MsgBoxStyle.Exclamation, "EROR")
        End Try
    End Sub


End Class