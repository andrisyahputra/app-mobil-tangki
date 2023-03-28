Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormHarian
    Public Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            Dim cryrpt As New ReportDocument
            Dim crtablelogoninfos As New TableLogOnInfos
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New LaporHarian '<== nama file laporan crystal report
            cryrpt = laporan
            With crconnectioninfo
                .ServerName = ""
                .DatabaseName = ""
                .UserID = ""
                .Password = ""
            End With
            crtables = cryrpt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            'CrystalReportViewer1.SelectionFormula = "Month({relasipelanggan1.tgl_bayar})=" & Val(dateTgl) & " and year({relasipelanggan1.tgl_bayar})=" & Val(ComboBox2.Text)
            CrystalReportViewer1.ReportSource = cryrpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()



        Catch ex As Exception
            MsgBox("Gagal Tampil Print")
        End Try
    End Sub

    Public Sub FormHarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnView_Click(sender, e)
    End Sub
End Class