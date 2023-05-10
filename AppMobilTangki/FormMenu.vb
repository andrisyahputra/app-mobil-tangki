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
    Dim dataId%
    Public Sub clearMenu()
        btnTutup.Visible = False
        'PictureBox1.Visible = False

        lblTangki.Visible = False
        lblatas.Visible = False


        GroupBox1.Visible = False
        DataGridTranksaksi.Visible = False
        btnHapus.Visible = False
        btnClear.Visible = False
        'BtnEdit.Visible = False
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
        'BtnEdit.Visible = True
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
            kosongidata()

            ImgInput = AppMobilTangki.My.Resources.Resources.save
            ImgEdit = AppMobilTangki.My.Resources.Resources.update
            ImgHapus = AppMobilTangki.My.Resources.Resources.sampah
            ImgClear = AppMobilTangki.My.Resources.Resources.clear
            imgBatal = AppMobilTangki.My.Resources.Resources.batal
            imgSimpan = AppMobilTangki.My.Resources.Resources.simpan
            imgUpdate = AppMobilTangki.My.Resources.Resources.edit

            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            'BtnEdit.Text = "EDIT"
            'BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnClear.Text = "CLEAR"
            btnClear.Image = ImgClear

            BtnTambah.Enabled = False
            btnClear.Enabled = False
            btnHapus.Enabled = False
            'BtnEdit.Enabled = False


            KoneksiKeDatabase()
            QUERY = "Select * FROM tbl_order order by id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "tbl_order")
            DataGridTranksaksi.DataSource = DS.Tables("tbl_order")

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


                .Columns(1).HeaderText = "ID HOLE 1"
                .Columns(2).HeaderText = "ID HOLE 2"
                .Columns(3).HeaderText = "Jarak Meter Hole 1"
                .Columns(4).HeaderText = "Jarak Meter Hole 2"
                .Columns(5).HeaderText = "Nama AMT"
                .Columns(6).HeaderText = "Plat No"
                .Columns(7).HeaderText = "Kapasitas"
                .Columns(8).HeaderText = "Produk"
                .Columns(9).HeaderText = "Merek/Type"
                .Columns(10).HeaderText = "Operator"
                .Columns(11).HeaderText = "Jam Ukur"
                .Columns(11).HeaderText = ""

                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "id_hole1"
                .Columns(2).DataPropertyName = "id_hole2"
                .Columns(3).DataPropertyName = "jrk_main_hole1"
                .Columns(4).DataPropertyName = "jrk_main_hole2"
                .Columns(5).DataPropertyName = "amt"
                .Columns(6).DataPropertyName = "platno"
                .Columns(7).DataPropertyName = "kapasitas"
                .Columns(8).DataPropertyName = "produk"
                .Columns(9).DataPropertyName = "merek_type"
                .Columns(10).DataPropertyName = "operator"
                .Columns(11).DataPropertyName = "jam_ukur"
                .Columns(12).DataPropertyName = "tgl_ukur"

                .Columns(0).Visible = False

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
        TextBox1.Focus()
        KoneksiKeDatabase()
        kondisiawal()
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
        'LBLTGL.Text = DateTime.Now.ToString("dd-MMMM-yyyy")
        LBLDATE.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss")
        tglsekarang = Today
    End Sub

    'Private Sub kosongidata()
    '    'txtCari.Text = ""
    '    'txtJMHole1.Text = ""
    '    'txtJMHole2.Text = ""
    '    'txtDATEJUkur.Text = ""
    'End Sub

    Dim WithEvents PD2 As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Longpaper As Integer

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Dim tanggalukur As Date = If(Convert.IsDBNull(LBLDATE.Text), Nothing, CType(LBLDATE.Text, Date))
        Dim jamukur As Date = If(Convert.IsDBNull(LBLDATE.Text), Nothing, CType(LBLDATE.Text, Date))

        Call KoneksiKeDatabase()
        QUERY = "INSERT INTO `tbl_order`(`id`, `id_hole1`, `id_hole2`, `jrk_main_hole1`, `jrk_main_hole2`, `amt`, `platno`, `kapasitas`, `produk`, `merek_type`, `operator`, `jam_ukur`, `tgl_ukur`) VALUES ('','" & LBLID1.Text & "','" & LBLID2.Text & "','" & LBLJRKHOLE1.Text & "','" & LBLJRKHOLE2.Text & "','" & LBLAMT.Text & "','" & LBLPLATNO.Text & "','" & LBLKAPASTAS.Text & "','" & LBLPRODUK.Text & "','" & LBLMEREK.Text & "','" & LBLOPERATOR.Text & "','" & jamukur.ToString("HH:mm") & "','" & tanggalukur.ToString("yyyy-MM-dd") & "')"

        DA = New MySqlDataAdapter(QUERY, CONN)
        DS = New DataSet
        DA.Fill(DS)

        Dim A As String = MsgBox("PRINT QRCODE...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "PRINT QRCODE")
        Select Case A
            Case vbCancel
                FormMenu_Load(sender, e)
                MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                Call kosongidata()
                Exit Sub
            Case vbOK

                changelongpaper()
                PPD.Document = PD2
                PPD.ShowDialog()

                FormMenu_Load(sender, e)
                MsgBox("Berhasil Ditambah", MsgBoxStyle.OkOnly, "SUKSES")
                Call kosongidata()

        End Select
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
    'Dim t_price As Long
    'Dim t_qty As Long

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
        If btnClear.Text = "BATAL" Then
            'LvMTangki.Clear()
            txtCari.Enabled = True
            'aktifField()
            kosongidata()
            DataGridTranksaksi.Enabled = True

            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            'BtnEdit.Text = "EDIT"
            'BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnClear.Text = "CLEAR"
            btnClear.Image = ImgClear

            BtnTambah.Enabled = False
            btnClear.Enabled = False
            btnHapus.Enabled = False
            'BtnEdit.Enabled = False
            Exit Sub
        End If
        If btnClear.Text = "CLEAR" Then
            kosongidata()
            TextBox1.Focus()
            BtnTambah.Enabled = False
            btnClear.Enabled = False
            btnHapus.Enabled = False
            Exit Sub
        End If
    End Sub


    Private Sub kosongidata()
        LBLID1.Text = ""
        LBLID2.Text = ""
        LBLJRKHOLE1.Text = ""
        LBLJRKHOLE2.Text = ""
        LBLKAPASTAS.Text = ""
        LBLMEREK.Text = ""
        LBLPRODUK.Text = ""
        LBLPLATNO.Text = ""
        LBLAMT.Text = ""
        LBLOPERATOR.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    'Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    '    Try
    '        If e.KeyChar = Chr(13) Then
    '            Dim myVariable As String = TextBox1.Text
    '            Dim myValues() As String = myVariable.Trim("*"c, "#"c).Split(","c)

    '            Dim value1 As String = myValues(0)
    '            Dim value2 As Double = Double.Parse(myValues(1))

    '            If value1 = "" Then
    '                MsgBox("RFID BELUM TERSEDIA")
    '                Exit Sub
    '            Else
    '                Call KoneksiKeDatabase()
    '                CMD = New MySqlCommand("select * from `relasirfid1dan2` where `kode_rfid`='" & value1 & "'", CONN)
    '                RD = CMD.ExecuteReader
    '                RD.Read()
    '                If RD.HasRows = True Then
    '                    LBLID1.Text = value1
    '                    LBLJRKHOLE1.Text = value2
    '                    LBLAMT.Text = RD.Item("nama_amt1")
    '                    LBLPLATNO.Text = RD.Item("no_polis")
    '                    LBLKAPASTAS.Text = RD.Item("kapasitas")
    '                    LBLPRODUK.Text = RD.Item("produk")
    '                    LBLMEREK.Text = RD.Item("merk_type")
    '                    LBLOPERATOR.Text = lblNLengkap.Text
    '                Else
    '                    kosongidata()
    '                    MessageBox.Show("GAGAL DITEMUKAN", "GAGAL ORDER")
    '                    Exit Sub
    '                End If
    '                MessageBox.Show("Berhasil ditambah", "SUKSES")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        kosongidata()
    '        MsgBox("Input Format Salah", MsgBoxStyle.Exclamation, "EROR")
    '    End Try
    'End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If e.KeyChar = Chr(13) Then

                Dim myVariable As String = TextBox1.Text
                Dim myValues() As String = myVariable.Trim("*"c, "#"c).Split(","c)

                Dim value1 As String = myValues(0)
                Dim value2 As Double = Double.Parse(myValues(1))

                Dim myVariable2 As String = TextBox2.Text
                Dim myValues2() As String = myVariable2.Trim("*"c, "#"c).Split(","c)

                Dim value3 As String = myValues2(0)
                Dim value4 As Double = Double.Parse(myValues2(1))

                If value1 = "" Then
                    MsgBox("RFID BELUM TERSEDIA")
                    Exit Sub
                Else
                    Call KoneksiKeDatabase()
                    CMD = New MySqlCommand("select * from `relasirfid1dan2` where `kode_rfid`='" & value1 & "' and `kode_rfid2`='" & value3 & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        LBLID1.Text = value1
                        LBLJRKHOLE1.Text = value2
                        LBLID2.Text = value3
                        LBLJRKHOLE2.Text = value4
                        LBLAMT.Text = RD.Item("nama_amt1")
                        LBLPLATNO.Text = RD.Item("no_polis")
                        LBLKAPASTAS.Text = RD.Item("kapasitas")
                        LBLPRODUK.Text = RD.Item("produk")
                        LBLMEREK.Text = RD.Item("merk_type")
                        LBLOPERATOR.Text = lblNLengkap.Text

                        BtnTambah.Enabled = True
                        btnClear.Enabled = True
                    Else
                        kosongidata()
                        MessageBox.Show("GAGAL DITEMUKAN", "GAGAL ORDER")
                        Exit Sub
                    End If
                    MessageBox.Show("Berhasil ditemukan", "ORDER")
                End If
            End If
        Catch ex As Exception
            kosongidata()
            MsgBox("Input Format Salah", MsgBoxStyle.Exclamation, "EROR")
        End Try
    End Sub


    Private Sub DataGridTranksaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridTranksaksi.CellClick
        Dim i As Integer

        Try
            With DataGridTranksaksi
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else


                    i = .CurrentRow.Index
                    'ID
                    dataId = .Rows(i).Cells(0).Value
                    ''untuk date
                    'If i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(12).Value) AndAlso .Rows(i).Cells(12).Value IsNot Nothing Then

                    '    Label1.Text = .Rows(i).Cells(12).Value.ToString("dd/MM/yyyy")
                    'Else
                    '    'jika baris atau sel kosong, lakukan tindakan yang sesuai
                    '    Label1.Text = "eror"
                    'End If
                    'Dim dateValue As DateTime
                    'If DateTime.TryParseExact(.Rows(i).Cells(12).Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dateValue) Then
                    '    Dim formattedDate As String = dateValue.ToString("dd/MM/yyyy")
                    '    Label1.Text = formattedDate
                    'Else
                    '    ' handle invalid date format
                    'End If



                    'untuk text
                    LBLID1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(1).Value) AndAlso .Rows(i).Cells(1).Value IsNot Nothing, .Rows(i).Cells(1).Value.ToString(), "")
                    LBLID2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(2).Value) AndAlso .Rows(i).Cells(2).Value IsNot Nothing, .Rows(i).Cells(2).Value.ToString(), "")
                    LBLJRKHOLE1.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(3).Value) AndAlso .Rows(i).Cells(3).Value IsNot Nothing, .Rows(i).Cells(3).Value.ToString(), "")
                    LBLJRKHOLE2.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(4).Value) AndAlso .Rows(i).Cells(4).Value IsNot Nothing, .Rows(i).Cells(4).Value.ToString(), "")
                    LBLAMT.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(5).Value) AndAlso .Rows(i).Cells(5).Value IsNot Nothing, .Rows(i).Cells(5).Value.ToString(), "")
                    LBLPLATNO.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(6).Value) AndAlso .Rows(i).Cells(6).Value IsNot Nothing, .Rows(i).Cells(6).Value.ToString(), "")
                    LBLKAPASTAS.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(7).Value) AndAlso .Rows(i).Cells(7).Value IsNot Nothing, .Rows(i).Cells(7).Value.ToString(), "")
                    LBLPRODUK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(8).Value) AndAlso .Rows(i).Cells(8).Value IsNot Nothing, .Rows(i).Cells(8).Value.ToString(), "")
                    LBLMEREK.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(9).Value) AndAlso .Rows(i).Cells(9).Value IsNot Nothing, .Rows(i).Cells(9).Value.ToString(), "")
                    LBLOPERATOR.Text = If(i < .Rows.Count AndAlso Not IsDBNull(.Rows(i).Cells(10).Value) AndAlso .Rows(i).Cells(10).Value IsNot Nothing, .Rows(i).Cells(10).Value.ToString(), "")

                    'UNTUK WAKTU
                    'Label1.Text = .Rows(i).Cells(12).Value.ToString()

                    'Dim dateValue As DateTime
                    'If DateTime.TryParseExact(.Rows(i).Cells(12).Value.ToString(), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, dateValue) Then
                    '    Dim formattedDate As String = dateValue.ToString("dd/MM/yyyy")
                    '    Label1.Text = formattedDate
                    'Else
                    '    ' handle invalid date format
                    'End If



                    'BtnEdit.Text = "EDIT"
                    'BtnEdit.Image = ImgEdit
                    'BtnEdit.Enabled = True

                    btnClear.Enabled = True
                    btnClear.Text = "BATAL"
                    btnClear.Image = imgBatal

                    btnHapus.Enabled = True
                    btnHapus.Text = "HAPUS"

                    BtnTambah.Enabled = False

                    'txtCari.Enabled = False
                    'Enabledfield()
                    DataGridTranksaksi.Enabled = True

                End If
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If btnHapus.Text = "BATAL" Then
            'LvMTangki.Clear()
            'aktifField()
            kosongidata()
            DataGridTranksaksi.Enabled = True

            BtnTambah.Text = "INPUT"
            BtnTambah.Image = ImgInput
            'BtnEdit.Text = "EDIT"
            'BtnEdit.Image = ImgEdit
            btnHapus.Text = "HAPUS"
            btnHapus.Image = ImgHapus
            btnClear.Text = "CLEAR"
            btnClear.Image = ImgClear

            BtnTambah.Enabled = True
            btnHapus.Enabled = False
            'BtnEdit.Enabled = False
            Exit Sub
        End If


        Try
            If btnHapus.Text = "HAPUS" Then
                Dim A As String
                A = MsgBox("Benar data No : " & LBLAMT.Text & " akan Dihapus...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
                Select Case A
                    Case vbCancel
                        MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        DataGridTranksaksi.Enabled = True
                        'KosongkanData()

                        FormMenu_Load(sender, e)
                        Exit Sub
                    Case vbOK
                        Call KoneksiKeDatabase()
                        QUERY = "DELETE FROM `tbl_order` where id='" & dataId & "'"
                        CMD = New MySqlCommand(QUERY, CONN)
                        CMD.ExecuteNonQuery()
                        'LvMTangki.Clear()

                        MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")

                        DataGridTranksaksi.Enabled = True
                        'KosongkanData()
                        FormMenu_Load(sender, e)

                End Select
            End If

        Catch ex As Exception
            MsgBox("Data Tidak bisa di Hapus", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Hapus Data")
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim inputText As String = TextBox3.Text

        ' Memisahkan teks menjadi baris-baris terpisah
        Dim lines() As String = inputText.Split({vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)

        ' Menginisialisasi List untuk menyimpan nilai yang diambil
        Dim values As New List(Of String)()

        ' Mengambil nilai dari setiap baris
        For Each line As String In lines
            ' Menghilangkan karakter "*" dan "#" dari baris
            line = line.Replace("*", "").Replace("#", "")

            ' Memisahkan nilai menggunakan koma sebagai delimiter
            Dim lineValues() As String = line.Split(","c)

            ' Menambahkan nilai ke dalam List
            For Each value As String In lineValues
                values.Add(value)
            Next
        Next

        ' Mengambil nilai yang diinginkan
        Dim value1 As String = values(0) 'id hole 1
        Dim value2 As String = values(1) 'jarak hole 1
        Dim value3 As String = values(2) 'id hole2
        Dim value4 As String = values(3) 'jarak holw 2

        LBLID1.Text = value1
        LBLID2.Text = value2
        LBLJRKHOLE1.Text = value3
        LBLJRKHOLE2.Text = value4

    End Sub

    'Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
    '    Try
    '        If e.KeyChar = Chr(13) Then



    '            'Dim myVariable As String = TextBox1.Text
    '            'Dim myValues() As String = myVariable.Trim("*"c, "#"c).Split(","c)

    '            'Dim value1 As String = myValues(0)
    '            'Dim value2 As Double = Double.Parse(myValues(1))

    '            'Dim myVariable2 As String = TextBox2.Text
    '            'Dim myValues2() As String = myVariable2.Trim("*"c, "#"c).Split(","c)

    '            'Dim value3 As String = myValues2(0)
    '            'Dim value4 As Double = Double.Parse(myValues2(1))

    '            'If value1 = "" Then
    '            '    MsgBox("RFID BELUM TERSEDIA")
    '            '    Exit Sub
    '            'Else
    '            '    Call KoneksiKeDatabase()
    '            '    CMD = New MySqlCommand("select * from `relasirfid1dan2` where `kode_rfid`='" & value1 & "' and `kode_rfid2`='" & value3 & "'", CONN)
    '            '    RD = CMD.ExecuteReader
    '            '    RD.Read()
    '            '    If RD.HasRows = True Then
    '            '        LBLID1.Text = value1
    '            '        LBLJRKHOLE1.Text = value2
    '            '        LBLID2.Text = value3
    '            '        LBLJRKHOLE2.Text = value4
    '            '        LBLAMT.Text = RD.Item("nama_amt1")
    '            '        LBLPLATNO.Text = RD.Item("no_polis")
    '            '        LBLKAPASTAS.Text = RD.Item("kapasitas")
    '            '        LBLPRODUK.Text = RD.Item("produk")
    '            '        LBLMEREK.Text = RD.Item("merk_type")
    '            '        LBLOPERATOR.Text = lblNLengkap.Text

    '            '        BtnTambah.Enabled = True
    '            '        btnClear.Enabled = True
    '            '    Else
    '            '        kosongidata()
    '            '        MessageBox.Show("GAGAL DITEMUKAN", "GAGAL ORDER")
    '            '        Exit Sub
    '            '    End If
    '            '    MessageBox.Show("Berhasil ditemukan", "ORDER")
    '            'End If
    '        End If
    '    Catch ex As Exception
    '        kosongidata()
    '        MsgBox("Input Format Salah", MsgBoxStyle.Exclamation, "EROR")
    '    End Try
    'End Sub
End Class