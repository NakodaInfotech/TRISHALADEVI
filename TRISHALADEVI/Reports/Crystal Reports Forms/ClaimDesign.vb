
Imports BL
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms

Public Class ClaimDesign

    Dim RPTHOSPITAL As New HospitalReport
    Dim RPTCHECKLIST As New CheckListReport
    Dim RPTCLAIM As New ClaimReport
    Dim RPTUHLDDOC1 As New UHLDDoc1
    Dim RPTUHLDDOC2 As New UHLDDoc2
    Dim RPTUHLDREC As New UHLDReceipt
    Dim RPTSCAN As New ScanReport
    Dim RPTPHOTOBEFORE As New PhotoBefore
    Dim RPTCLAIMREQ As New ClaimRequestReport
    Dim RPTAUTHORIZATION As New AuthorizationReport
    Dim RPTOTNOTES As New OTNotes
    Dim RPTPHOTOAFTER As New PhotoAfter
    Dim RPTDISCHARGE As New DischargeSummary
    Dim RPTSMALLBILL As New SmallBillReport
    Dim RPTFINALBILL As New FinalBillReport
    Dim RPTIMPLANT As New FinalBillReport_implant
    Dim RPTREPORTDOC1 As New ReportDoc1
    Dim RPTREPORTDOC2 As New ReportDoc2
    Dim RPTREPORTDOC3 As New ReportDoc3


    Public STRSEARCH As String
    Public FRMSTRING As String

    Private Sub ClaimDesign_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ClaimDesign_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            '**************** SET SERVER ************************
            Dim crtableLogonInfo As New TableLogOnInfo
            Dim crConnecttionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim crTable As Table

            With crConnecttionInfo
                .ServerName = SERVERNAME
                .DatabaseName = DatabaseName
                .UserID = DBUSERNAME
                .Password = Dbpassword
                .IntegratedSecurity = Dbsecurity
            End With

            If FRMSTRING = "HOSPITALREPORT" Then
                crTables = RPTHOSPITAL.Database.Tables
                Me.Text = "Hospital Form"
            ElseIf FRMSTRING = "CHECKLIST" Then
                crTables = RPTCHECKLIST.Database.Tables
                Me.Text = "Check List Report"
            ElseIf FRMSTRING = "CLAIM" Then
                crTables = RPTCLAIM.Database.Tables
                Me.Text = "Claim Report"
            ElseIf FRMSTRING = "UHLDDOC1" Then
                crTables = RPTUHLDDOC1.Database.Tables
                Me.Text = "UHLD Doc 1"
            ElseIf FRMSTRING = "UHLDDOC2" Then
                crTables = RPTUHLDDOC2.Database.Tables
                Me.Text = "UHLD Doc 2"
            ElseIf FRMSTRING = "UHLDREC" Then
                crTables = RPTUHLDREC.Database.Tables
                Me.Text = "UHLD Receipt"
            ElseIf FRMSTRING = "SCAN" Then
                Me.Text = "Scan Report"
                crTables = RPTSCAN.Database.Tables
            ElseIf FRMSTRING = "PHOTOBEFORE" Then
                crTables = RPTPHOTOBEFORE.Database.Tables
                Me.Text = "Photo Before Operation"
            ElseIf FRMSTRING = "CLAIMREQ" Then
                crTables = RPTCLAIMREQ.Database.Tables
                Me.Text = "Claim Request"
            ElseIf FRMSTRING = "AUTHORIZATION" Then
                crTables = RPTAUTHORIZATION.Database.Tables
                Me.Text = "Claim Authorization Report"
            ElseIf FRMSTRING = "OTNOTES" Then
                crTables = RPTOTNOTES.Database.Tables
                Me.Text = "OT Notes"
            ElseIf FRMSTRING = "PHOTOAFTER" Then
                crTables = RPTPHOTOAFTER.Database.Tables
                Me.Text = "Photo After Operation"
            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                crTables = RPTDISCHARGE.Database.Tables
                Me.Text = "Discharge Summary Report"
            ElseIf FRMSTRING = "SMALLBILL" Then
                crTables = RPTSMALLBILL.Database.Tables
                Me.Text = "Invoice Report"
            ElseIf FRMSTRING = "FINALBILL" Then
                crTables = RPTFINALBILL.Database.Tables
                Me.Text = "Final Invoice Report"
            ElseIf FRMSTRING = "IMPLANTBILL" Then
                crTables = RPTIMPLANT.Database.Tables
                Me.Text = "Final Invoice Report IMPLANT"
            ElseIf FRMSTRING = "REPORTDOC1" Then
                crTables = RPTREPORTDOC1.Database.Tables
                Me.Text = "Report Document 1"
            ElseIf FRMSTRING = "REPORTDOC2" Then
                crTables = RPTREPORTDOC2.Database.Tables
                Me.Text = "Report Document 2"
            ElseIf FRMSTRING = "REPORTDOC3" Then
                crTables = RPTREPORTDOC3.Database.Tables
                Me.Text = "Report Document 3"
            End If

            For Each crTable In crTables
                crtableLogonInfo = crTable.LogOnInfo
                crtableLogonInfo.ConnectionInfo = crConnecttionInfo
                crTable.ApplyLogOnInfo(crtableLogonInfo)
            Next
            '************************ END *******************

            crpo.SelectionFormula = STRSEARCH

            If FRMSTRING = "HOSPITALREPORT" Then
                crpo.ReportSource = RPTHOSPITAL
                RPTHOSPITAL.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "CHECKLIST" Then
                crpo.ReportSource = RPTCHECKLIST
                RPTCHECKLIST.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "CLAIM" Then
                crpo.ReportSource = RPTCLAIM
                RPTCLAIM.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "UHLDDOC1" Then
                crpo.ReportSource = RPTUHLDDOC1
                RPTUHLDDOC1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "UHLDDOC2" Then
                crpo.ReportSource = RPTUHLDDOC2
                RPTUHLDDOC2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "UHLDREC" Then
                crpo.ReportSource = RPTUHLDREC
                RPTUHLDREC.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "SCAN" Then
                crpo.ReportSource = RPTSCAN
                RPTSCAN.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "PHOTOBEFORE" Then
                crpo.ReportSource = RPTPHOTOBEFORE
                RPTPHOTOBEFORE.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "CLAIMREQ" Then
                crpo.ReportSource = RPTCLAIMREQ
                RPTCLAIMREQ.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "AUTHORIZATION" Then
                crpo.ReportSource = RPTAUTHORIZATION
                RPTAUTHORIZATION.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "OTNOTES" Then
                crpo.ReportSource = RPTOTNOTES
                RPTOTNOTES.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "PHOTOAFTER" Then
                crpo.ReportSource = RPTPHOTOAFTER
                RPTPHOTOAFTER.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                crpo.ReportSource = RPTDISCHARGE
                RPTDISCHARGE.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "SMALLBILL" Then
                crpo.ReportSource = RPTSMALLBILL
                RPTSMALLBILL.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5
            ElseIf FRMSTRING = "FINALBILL" Then
                crpo.ReportSource = RPTFINALBILL
                RPTFINALBILL.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "IMPLANTBILL" Then
                crpo.ReportSource = RPTIMPLANT
                RPTIMPLANT.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "REPORTDOC1" Then
                crpo.ReportSource = RPTREPORTDOC1
                RPTREPORTDOC1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "REPORTDOC2" Then
                crpo.ReportSource = RPTREPORTDOC2
                RPTREPORTDOC2.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            ElseIf FRMSTRING = "REPORTDOC3" Then
                crpo.ReportSource = RPTREPORTDOC3
                RPTREPORTDOC3.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            End If
            
            crpo.Zoom(100)
            crpo.Refresh()

        Catch Exp As LoadSaveReportException
            MsgBox("Incorrect path for loading report.", _
                    MsgBoxStyle.Critical, "Load Report Error")
        End Try
    End Sub

    Private Sub sendmailtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendmailtool.Click
        Dim emailid As String = ""
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Transfer()
        Try
            Dim objmail As New SendMail
            objmail.attachment = Application.StartupPath & "\Claim Details.PDF"
            If emailid <> "" Then
                objmail.cmbfirstadd.Text = emailid
            End If
            objmail.Show()
            objmail.BringToFront()
        Catch ex As Exception
            Throw ex
        End Try
        Windows.Forms.Cursor.Current = Cursors.Arrow
    End Sub

    Sub Transfer()
        Try
            Dim expo As New ExportOptions
            Dim oDfDopt As New DiskFileDestinationOptions
            oDfDopt.DiskFileName = Application.StartupPath & "\Claim Details.PDF"

            If FRMSTRING = "HOSPITALREPORT" Then
                expo = RPTHOSPITAL.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTHOSPITAL.Export()
            ElseIf FRMSTRING = "CHECKLIST" Then
                expo = RPTCHECKLIST.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTCHECKLIST.Export()
            ElseIf FRMSTRING = "CLAIM" Then
                expo = RPTCLAIM.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTCLAIM.Export()
            ElseIf FRMSTRING = "UHLDDOC1" Then
                expo = RPTUHLDDOC1.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTUHLDDOC1.Export()
            ElseIf FRMSTRING = "UHLDDOC2" Then
                expo = RPTUHLDDOC2.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTUHLDDOC2.Export()
            ElseIf FRMSTRING = "UHLDREC" Then
                expo = RPTUHLDREC.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTUHLDREC.Export()
            ElseIf FRMSTRING = "SCAN" Then
                expo = RPTSCAN.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTSCAN.Export()
            ElseIf FRMSTRING = "PHOTOBEFORE" Then
                expo = RPTPHOTOBEFORE.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTPHOTOBEFORE.Export()
            ElseIf FRMSTRING = "CLAIMREQ" Then
                expo = RPTCLAIMREQ.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTCLAIMREQ.Export()
            ElseIf FRMSTRING = "AUTHORIZATION" Then
                expo = RPTAUTHORIZATION.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTAUTHORIZATION.Export()
            ElseIf FRMSTRING = "OTNOTES" Then
                expo = RPTOTNOTES.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOTNOTES.Export()
            ElseIf FRMSTRING = "PHOTOAFTER" Then
                expo = RPTPHOTOAFTER.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTPHOTOAFTER.Export()
            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                expo = RPTDISCHARGE.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTDISCHARGE.Export()
            ElseIf FRMSTRING = "SMALLBILL" Then
                expo = RPTSMALLBILL.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTSMALLBILL.Export()
            ElseIf FRMSTRING = "FINALBILL" Then
                expo = RPTFINALBILL.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTFINALBILL.Export()
            ElseIf FRMSTRING = "IMPLANTBILL" Then
                expo = RPTIMPLANT.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTIMPLANT.Export()
            ElseIf FRMSTRING = "REPORTDOC1" Then
                expo = RPTREPORTDOC1.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTREPORTDOC1.Export()
            ElseIf FRMSTRING = "REPORTDOC2" Then
                expo = RPTREPORTDOC2.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTREPORTDOC2.Export()
            ElseIf FRMSTRING = "REPORTDOC3" Then
                expo = RPTREPORTDOC3.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTREPORTDOC3.Export()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class