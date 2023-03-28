Imports MySql.Data.MySqlClient

Public Class FormUser
    Dim gender As String
    Dim user As String
    Dim idNilai As String

    Private Sub KosongkanData()
        TxtNamaLengkap.Text = ""
        TxtAlamat.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        CBLevel.Text = ""
        txtNoWa.Text = ""
        RBLaki.Checked = False
        RBPerempuan.Checked = False
        DateTanggalLahir.Value = Today
    End Sub
    Private Sub KondisiAwal()
        TxtNamaLengkap.Text = ""
        TxtAlamat.Text = ""
        TxtPassword.Text = ""
        TxtUsername.Text = ""
        txtNoWa.Text = ""
        RBLaki.Text = "Laki Laki"
        RBPerempuan.Text = "Perempuan"
        DateTanggalLahir.Text = Today

        TxtNamaLengkap.Enabled = False
        TxtAlamat.Enabled = False
        TxtPassword.Enabled = False
        TxtUsername.Enabled = False
        CBLevel.Enabled = False
        RBLaki.Enabled = False
        RBPerempuan.Enabled = False
        DateTanggalLahir.Enabled = False
        txtNoWa.Enabled = False
        TxtUsername.MaxLength = 10
        TxtPassword.MaxLength = 10
        txtNoWa.MaxLength = 15

        RBLaki.Checked = False
        RBPerempuan.Checked = False

        BtnTambah.Text = "INPUT"
        BtnEdit.Text = "EDIT"
        BtnHapus.Text = "HAPUS"
        BtnTutup.Text = "TUTUP"


        BtnTambah.Enabled = True
        BtnHapus.Enabled = False
        BtnEdit.Enabled = False
        BtnTutup.Enabled = True

        Try

            QUERY = "Select * FROM tbl_user ORDER BY id"
            DA = New MySqlDataAdapter(QUERY, CONN)
            DS = New DataSet
            DA.Fill(DS, "tbl_user")
            DataGridView1.DataSource = DS.Tables("tbl_user")

            With DataGridView1
                .Columns(1).Width = 200
                .Columns(2).Width = 120
                .Columns(3).Width = 100
                .Columns(4).Width = 150
                .Columns(5).Width = 150
                .Columns(6).Width = 100
                .Columns(7).Width = 100
                .Columns(8).Width = 80
                '.Columns(9).Width = 150


                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "nama_lengkap"
                .Columns(2).DataPropertyName = "jenis_kelamin"
                .Columns(3).DataPropertyName = "no_hp"
                .Columns(4).DataPropertyName = "alamat"
                .Columns(5).DataPropertyName = "tanggal_lahir"
                .Columns(6).DataPropertyName = "user_name"
                .Columns(7).DataPropertyName = "pwd"
                .Columns(8).DataPropertyName = "lvl"
                .Columns(9).DataPropertyName = "c"

                .Columns(1).HeaderText = "NAMA LENGKAP"
                .Columns(2).HeaderText = "JENIS KELAMIN"
                .Columns(3).HeaderText = "NOMOR HP"
                .Columns(4).HeaderText = "ALAMAT"
                .Columns(5).HeaderText = "TANGGAL LAHIR"
                .Columns(6).HeaderText = "USERNAME"
                .Columns(7).HeaderText = "PASSWORD"
                .Columns(8).HeaderText = "LEVEL"

                .Columns(0).Visible = False
                .Columns(9).Visible = False

                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .EnableHeadersVisualStyles = False
                '.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
                '.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.Font = New Font(DataGridView.DefaultFont, FontStyle.Bold)

                .RowsDefaultCellStyle.BackColor = Color.Crimson
                .DefaultCellStyle.ForeColor = Color.DarkRed
                .RowsDefaultCellStyle.BackColor = Color.SkyBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Wheat
                .GridColor = Color.DarkRed

            End With

        Catch ex As Exception
            MsgBox(ex.Message, "EROR")
        End Try
    End Sub

    Public Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBLevel.Items.Clear()
        CBLevel.DropDownStyle = ComboBoxStyle.DropDownList
        CBLevel.Items.Add("Admin")
        CBLevel.Items.Add("Operator")
        KoneksiKeDatabase()
        KondisiAwal()
        TxtUsername.CharacterCasing = CharacterCasing.Lower
        TxtPassword.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        If BtnTutup.Text = "TUTUP" Then
            Me.Close()
            Call FormMenu.tampilMenu()
            CBLevel.Items.Clear()
        Else
            DataGridView1.Enabled = True
            BtnHapus.Visible = True
            CBLevel.Items.Clear()
            FormUser_Load(sender, e)
            Call KosongkanData()
        End If
    End Sub
    Private Sub FieldAktif()

        TxtNamaLengkap.Enabled = True
        TxtAlamat.Enabled = True
        TxtPassword.Enabled = True
        TxtUsername.Enabled = True
        CBLevel.Enabled = True
        RBLaki.Enabled = True
        RBPerempuan.Enabled = True
        DateTanggalLahir.Enabled = True
        txtNoWa.Enabled = True
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Try
            If BtnTambah.Text = "INPUT" Then
                BtnTambah.Text = "SIMPAN"
                BtnEdit.Text = "CLEAR"
                BtnHapus.Visible = False
                DataGridView1.Enabled = False
                BtnTutup.Text = "BATAL"
                Call FieldAktif()
                TxtNamaLengkap.Focus()
            Else


                If TxtNamaLengkap.Text = "" Or
                        TxtAlamat.Text = "" Or
                        TxtPassword.Text = "" Or
                        TxtUsername.Text = "" Or
                        txtNoWa.Text = "" Or
                        CBLevel.Text = "" Or
                        RBLaki.Checked = False And RBPerempuan.Checked = False Then
                    MsgBox("Silahkan Isi Semua Data")
                ElseIf DateTanggalLahir.Text = Today Then
                    MsgBox("Tanggal Lahir belum input")
                ElseIf DateTanggalLahir.Text > Today Then
                    MsgBox("Tanggal Lahir Kelewatan tahun")
                ElseIf Not txtNoWa.Text.Length >= 12 Then
                    MsgBox("Minimal Nomor Wa 12 angka")
                ElseIf Not TxtUsername.Text.Length >= 5 Then
                    MsgBox("Minimal 5 Username")
                ElseIf Not TxtPassword.Text.Length >= 5 Then
                    MsgBox("Minimal 5 Password")
                Else
                    Call KoneksiKeDatabase()
                    CMD = New MySqlCommand("SELECT * FROM tbl_user where user_name='" & TxtUsername.Text & "' OR no_hp='" & txtNoWa.Text & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    If RD.HasRows = True Then
                        MsgBox("Username atau No Wa Tidak boleh sama", MsgBoxStyle.Critical, "Data Dulpicat")

                    Else



                        Call KoneksiKeDatabase()
                        If RBLaki.Checked = True Then
                            gender = RBLaki.Text
                        ElseIf RBPerempuan.Checked = True Then
                            gender = RBPerempuan.Text
                        End If

                        Call KoneksiKeDatabase()
                        CMD = New MySqlCommand
                        CMD.Connection = CONN
                        QUERY = "INSERT INTO `tbl_user`(`id`, `nama_lengkap`, `jenis_kelamin`, `alamat`, `tanggal_lahir`, `user_name`, `pwd`, `lvl`, `no_hp`, `c`) VALUES ('','" & TxtNamaLengkap.Text & "','" & gender & "','" & TxtAlamat.Text & "','" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "','" & TxtUsername.Text & "','" & TxtPassword.Text & "','" & CBLevel.Text & "','" & txtNoWa.Text & "','-')"
                        CMD.CommandText = QUERY
                        CMD.ExecuteNonQuery()

                        MsgBox("Input data berhasil")
                        BtnHapus.Visible = True
                        DataGridView1.Enabled = True
                        CBLevel.Items.Clear()
                        FormUser_Load(sender, e)
                        Call KosongkanData()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Username sudah tersedia")
        End Try
    End Sub

    Private Sub txtNoWa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoWa.KeyPress
        If Not Char.IsDigit(CChar(CStr(e.KeyChar))) Or txtNoWa.Text.Length >= 15 Then e.Handled = True
        If e.KeyChar = ChrW(Keys.Back) Then e.Handled = False
    End Sub

    Dim dataID As String

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        Try
            BtnEdit.Enabled = True
            BtnHapus.Enabled = True
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"


            dataID = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            TxtNamaLengkap.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value

            gender = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            If gender = RBLaki.Text Then
                RBLaki.Checked = True
            ElseIf gender = RBPerempuan.Text Then
                RBPerempuan.Checked = True
            Else
                RBLaki.Checked = False
                RBPerempuan.Checked = False
            End If

            txtNoWa.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            TxtAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
            DateTanggalLahir.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
            TxtUsername.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
            TxtPassword.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            CBLevel.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value

        Catch ex As Exception

        End Try

    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If BtnEdit.Text = "CLEAR" Then
            TxtNamaLengkap.Text = ""
            TxtAlamat.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Text = ""
            CBLevel.Text = ""
            RBLaki.Checked = False
            RBPerempuan.Checked = False
            DateTanggalLahir.Value = Today
            TxtNamaLengkap.Focus()
            Exit Sub
        End If

        If BtnEdit.Text = "EDIT" Then
            DataGridView1.Enabled = False
            BtnEdit.Text = "UPDATE"

            FieldAktif()
            BtnHapus.Enabled = False
        Else
            Try

                CMD = New MySqlCommand
                CMD.Connection = CONN
                QUERY = "UPDATE tbl_user SET nama_lengkap='" & TxtNamaLengkap.Text & "',jenis_kelamin='" & gender & "',alamat='" & TxtAlamat.Text & "',tanggal_lahir='" & Format(DateTanggalLahir.Value, "yyyy-MM-dd") & "',user_name='" & TxtUsername.Text & "',pwd='" & TxtPassword.Text & "',lvl='" & CBLevel.Text & "',no_hp='" & txtNoWa.Text & "',c='-'where id='" & dataID & "'"
                CMD.CommandText = QUERY
                CMD.ExecuteNonQuery()
                MsgBox("EDIT data berhasil")
                DataGridView1.Enabled = True
                CBLevel.Items.Clear()
                FormUser_Load(sender, e)
                Call KosongkanData()
            Catch ex As Exception
                MsgBox("Username sudah tersedia")
                CBLevel.Items.Clear()
                FormUser_Load(sender, e)
                BtnHapus.Visible = True
                KondisiAwal()
                'ListView1.Enabled = True
            End Try


        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If BtnHapus.Text = "HAPUS" Then
            DataGridView1.Enabled = False
            BtnHapus.Text = "DELETE"
            BtnEdit.Enabled = False
            BtnTambah.Enabled = False
            BtnTutup.Text = "BATAL"
            TxtNamaLengkap.Enabled = False
            TxtAlamat.Enabled = False
            TxtUsername.Enabled = False
            TxtPassword.Enabled = False
            RBLaki.Enabled = False
            RBPerempuan.Enabled = False
            CBLevel.Enabled = False

        Else

            Dim A As String
            A = MsgBox("BENAR DIHAPUS...?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "HAPUS DATA")
            Select Case A
                Case vbCancel
                    FormUser_Load(sender, e)
                    Call KosongkanData()
                    MsgBox("Data Tidak hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
                    Exit Sub
                Case vbOK
                    Call KoneksiKeDatabase()
                    QUERY = "delete from tbl_user where id='" & dataID & "'"
                    CMD = New MySqlCommand(QUERY, CONN)
                    CMD.ExecuteNonQuery()
                    FormUser_Load(sender, e)
                    Call KosongkanData()
                    MsgBox("Berhasil Di hapus", MsgBoxStyle.OkOnly, "HAPUS DATA")
                    DataGridView1.Enabled = True
            End Select
        End If
    End Sub



End Class