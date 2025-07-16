
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class IPDDesign

    Dim RPTADMISSION As New AdmissionReport
    Dim RPTGENERALCON As New GeneralConsentForm
    Dim RPTDOCASSREPORT As New InitialDoctorsAssesmentSheet
    Dim RPTDOCORDER As New DoctorsOrderSheet
    Dim RPTSURGERYCONCENT As New SurgeryAnaesthesiaConcentForm
    Dim RPTREEVALUATION As New Re_EvaluationBeforeOT
    Dim RPTOPNOTES As New OperativeNotes
    Dim RPTPOSTOPCHART As New PostOperartiveMonitoringChart
    Dim RPTDISCHARGESUMM As New DischargeSummaryIPD
    Dim RPTANAESTHESIA As New ConsentForAnesthesia
    Dim RPTANAESTHESIARECORD As New AnaesthesiaRecord
    Dim RPTPREANAESTHESIAEVA As New PreAnaesthesiaEvaluation
    Dim RPTPOSTSCORE As New PostAnaesthesiaRecoveryScore

    '14TH REPORT WILL BE SAME AND 7TH REPORT
    'Dim RPTANAESTHESIAOPNOTES As New OperativeNotesAnaesthesia
    Dim RPTANAESTHESIAOPNOTES As New OperativeNotes

    Dim RPTAPPTRECIPD As New AppointmentReceiptIPD
    Dim RPTIPDRECEIPT As New IPDReceipt

    'REPORT FOR OPD
    Dim RPTOPDDETAILS As New OPDReportDetails
    Dim RPTOPDDETAILSA5 As New OPDReportDetailsA5
    Dim RPTOPDRECEIPT As New OPDReceipt
    Dim RPTAPPTRECOPD As New AppointmentReceiptOPD


    'OPDDETAILS REPORTS
    Dim RPTOPDDATEWISE As New OPDDayWiseReport
    Dim RPTOPDALLBILLS As New OPDAllBillsReport


    Public STRSEARCH As String
    Public FRMSTRING As String
    Public PERIOD As String

    Private Sub IPDDesign_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IPDDesign_Load(sender As Object, e As EventArgs) Handles Me.Load
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

            If FRMSTRING = "ADMISSION" Then
                crTables = RPTADMISSION.Database.Tables
                Me.Text = "Admission Record"

            ElseIf FRMSTRING = "GENERALCONCENT" Then
                crTables = RPTGENERALCON.Database.Tables
                Me.Text = "General concent Form"

            ElseIf FRMSTRING = "DOCASSREPORT" Then
                crTables = RPTDOCASSREPORT.Database.Tables
                Me.Text = "Initial Doctor's Assesment"


            ElseIf FRMSTRING = "DOCORDER" Then
                crTables = RPTDOCORDER.Database.Tables
                Me.Text = "Doctor's Order Sheet"


            ElseIf FRMSTRING = "SURGERYCONCENT" Then
                crTables = RPTSURGERYCONCENT.Database.Tables
                Me.Text = "Surgery & Anaesthesia Concent Form"


            ElseIf FRMSTRING = "REEVALUATION" Then
                crTables = RPTREEVALUATION.Database.Tables
                Me.Text = "Re-Evaluation Before OT"


            ElseIf FRMSTRING = "OPNOTES" Then
                crTables = RPTOPNOTES.Database.Tables
                Me.Text = "Operative Notes"


            ElseIf FRMSTRING = "POSTOPCHART" Then
                crTables = RPTPOSTOPCHART.Database.Tables
                Me.Text = "Post Operative Chart"


            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                crTables = RPTDISCHARGESUMM.Database.Tables
                Me.Text = "Discharge Summary"


            ElseIf FRMSTRING = "ANAESTHESIA" Then
                crTables = RPTANAESTHESIA.Database.Tables
                Me.Text = "Concent for Anaesthesia"


            ElseIf FRMSTRING = "ANAESTHESIARECORD" Then
                crTables = RPTANAESTHESIARECORD.Database.Tables
                Me.Text = "Anaesthesia Record"


            ElseIf FRMSTRING = "PREANAESTHESIAEVA" Then
                crTables = RPTPREANAESTHESIAEVA.Database.Tables
                Me.Text = "Pre Anaesthesia Evaluation"


            ElseIf FRMSTRING = "POSTSCORE" Then
                crTables = RPTPOSTSCORE.Database.Tables
                Me.Text = "Post Anaesthesia Recovery Score"


            ElseIf FRMSTRING = "ANAESTHESIAOPNOTES" Then
                crTables = RPTANAESTHESIAOPNOTES.Database.Tables
                Me.Text = "Operative Notes (Anaesthesia)"

            ElseIf FRMSTRING = "IPDAPPTREC" Then
                crTables = RPTAPPTRECIPD.Database.Tables
                Me.Text = "Appointment Receipt"

            ElseIf FRMSTRING = "IPDRECEIPT" Then
                crTables = RPTIPDRECEIPT.Database.Tables
                Me.Text = "IPD Receipt"


                'FOR REPORT OPD
            ElseIf FRMSTRING = "OPDDETAILS" Then
                crTables = RPTOPDDETAILS.Database.Tables
                Me.Text = "OPD Report"

            ElseIf FRMSTRING = "OPDDETAILSA5" Then
                crTables = RPTOPDDETAILSA5.Database.Tables
                Me.Text = "OPD Report (A5)"

            ElseIf FRMSTRING = "OPDRECEIPT" Then
                crTables = RPTOPDRECEIPT.Database.Tables
                Me.Text = "OPD Receipt"

            ElseIf FRMSTRING = "APPTREC" Then
                crTables = RPTAPPTRECOPD.Database.Tables
                Me.Text = "Appointment Receipt"

            ElseIf FRMSTRING = "OPDDAYWISE" Then
                crTables = RPTOPDDATEWISE.Database.Tables
                Me.Text = "OPD Day Wise Report"

            ElseIf FRMSTRING = "OPDALLBILLS" Then
                crTables = RPTOPDALLBILLS.Database.Tables
                Me.Text = "OPD All Bills"

            End If


            For Each crTable In crTables
                crtableLogonInfo = crTable.LogOnInfo
                crtableLogonInfo.ConnectionInfo = crConnecttionInfo
                crTable.ApplyLogOnInfo(crtableLogonInfo)
            Next
            '************************ END *******************

            crpo.SelectionFormula = STRSEARCH

            If FRMSTRING = "ADMISSION" Then
                crpo.ReportSource = RPTADMISSION

            ElseIf FRMSTRING = "GENERALCONCENT" Then
                crpo.ReportSource = RPTGENERALCON

            ElseIf FRMSTRING = "DOCASSREPORT" Then
                crpo.ReportSource = RPTDOCASSREPORT

            ElseIf FRMSTRING = "DOCORDER" Then
                crpo.ReportSource = RPTDOCORDER

            ElseIf FRMSTRING = "SURGERYCONCENT" Then
                crpo.ReportSource = RPTSURGERYCONCENT

            ElseIf FRMSTRING = "REEVALUATION" Then
                crpo.ReportSource = RPTREEVALUATION

            ElseIf FRMSTRING = "OPNOTES" Then
                crpo.ReportSource = RPTOPNOTES

            ElseIf FRMSTRING = "POSTOPCHART" Then
                crpo.ReportSource = RPTPOSTOPCHART

            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                crpo.ReportSource = RPTDISCHARGESUMM

            ElseIf FRMSTRING = "ANAESTHESIA" Then
                crpo.ReportSource = RPTANAESTHESIA

            ElseIf FRMSTRING = "ANAESTHESIARECORD" Then
                crpo.ReportSource = RPTANAESTHESIARECORD

            ElseIf FRMSTRING = "PREANAESTHESIAEVA" Then
                crpo.ReportSource = RPTPREANAESTHESIAEVA

            ElseIf FRMSTRING = "POSTSCORE" Then
                crpo.ReportSource = RPTPOSTSCORE

            ElseIf FRMSTRING = "ANAESTHESIAOPNOTES" Then
                crpo.ReportSource = RPTANAESTHESIAOPNOTES

            ElseIf FRMSTRING = "IPDAPPTREC" Then
                crpo.ReportSource = RPTAPPTRECIPD

            ElseIf FRMSTRING = "IPDRECEIPT" Then
                crpo.ReportSource = RPTIPDRECEIPT

            End If

            'FOR OPD REPORT

            If FRMSTRING = "OPDRECEIPT" Then
                crpo.ReportSource = RPTOPDRECEIPT

            ElseIf FRMSTRING = "APPTREC" Then
                crpo.ReportSource = RPTAPPTRECOPD

            ElseIf FRMSTRING = "OPDDETAILS" Then
                crpo.ReportSource = RPTOPDDETAILS

            ElseIf FRMSTRING = "OPDDETAILSA5" Then
                crpo.ReportSource = RPTOPDDETAILSA5

            ElseIf FRMSTRING = "OPDDAYWISE" Then
                crpo.ReportSource = RPTOPDDATEWISE
                RPTOPDDATEWISE.DataDefinition.FormulaFields("PERIOD").Text = "'" & PERIOD & "'"

            ElseIf FRMSTRING = "OPDALLBILLS" Then
                crpo.ReportSource = RPTOPDALLBILLS
            End If

            crpo.Zoom(100)
            crpo.Refresh()

        Catch Exp As LoadSaveReportException
            MsgBox("Incorrect path for loading report.",
                    MsgBoxStyle.Critical, "Load Report Error")
        End Try
    End Sub

    Sub Transfer()
        Try
            Dim expo As New ExportOptions
            Dim oDfDopt As New DiskFileDestinationOptions
            oDfDopt.DiskFileName = Application.StartupPath & "\IPD Details.PDF"

            If FRMSTRING = "ADMISSION" Then
                expo = RPTADMISSION.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTADMISSION.Export()

            ElseIf FRMSTRING = "GENERALCONCENT" Then
                expo = RPTGENERALCON.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTGENERALCON.Export()


            ElseIf FRMSTRING = "DOCASSREPORT" Then
                expo = RPTDOCASSREPORT.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTDOCASSREPORT.Export()


            ElseIf FRMSTRING = "DOCORDER" Then
                expo = RPTDOCORDER.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTDOCORDER.Export()


            ElseIf FRMSTRING = "SURGERYCONCENT" Then
                expo = RPTSURGERYCONCENT.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTSURGERYCONCENT.Export()


            ElseIf FRMSTRING = "REEVALUATION" Then
                expo = RPTREEVALUATION.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTREEVALUATION.Export()


            ElseIf FRMSTRING = "OPNOTES" Then
                expo = RPTOPNOTES.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPNOTES.Export()


            ElseIf FRMSTRING = "POSTOPCHART" Then
                expo = RPTPOSTOPCHART.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTPOSTOPCHART.Export()


            ElseIf FRMSTRING = "DISCHARGESUMM" Then
                expo = RPTDISCHARGESUMM.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTDISCHARGESUMM.Export()


            ElseIf FRMSTRING = "ANAESTHESIA" Then
                expo = RPTANAESTHESIA.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTANAESTHESIA.Export()


            ElseIf FRMSTRING = "ANAESTHESIARECORD" Then
                expo = RPTANAESTHESIARECORD.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTANAESTHESIARECORD.Export()


            ElseIf FRMSTRING = "PREANAESTHESIAEVA" Then
                expo = RPTPREANAESTHESIAEVA.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTPREANAESTHESIAEVA.Export()


            ElseIf FRMSTRING = "POSTSCORE" Then
                expo = RPTPOSTSCORE.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTPOSTSCORE.Export()


            ElseIf FRMSTRING = "ANAESTHESIAOPNOTES" Then
                expo = RPTANAESTHESIAOPNOTES.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTANAESTHESIAOPNOTES.Export()


            ElseIf FRMSTRING = "IPDAPPTREC" Then
                expo = RPTAPPTRECIPD.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTAPPTRECIPD.Export()


            ElseIf FRMSTRING = "IPDRECEIPT" Then
                expo = RPTIPDRECEIPT.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTIPDRECEIPT.Export()
            End If

            'FOR OPD REPORT
            If FRMSTRING = "OPDRECEIPT" Then
                expo = RPTOPDRECEIPT.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPDRECEIPT.Export()

            ElseIf FRMSTRING = "APPTREC" Then
                expo = RPTAPPTRECOPD.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTAPPTRECOPD.Export()

            ElseIf FRMSTRING = "OPDDETAILS" Then
                expo = RPTOPDDETAILS.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPDDETAILS.Export()

            ElseIf FRMSTRING = "OPDDETAILSA5" Then
                expo = RPTOPDDETAILSA5.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPDDETAILSA5.Export()

            ElseIf FRMSTRING = "OPDDAYWISE" Then
                expo = RPTOPDDATEWISE.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPDDATEWISE.Export()

            ElseIf FRMSTRING = "OPDALLBILLS" Then
                expo = RPTOPDALLBILLS.ExportOptions
                expo.ExportDestinationType = ExportDestinationType.DiskFile
                expo.ExportFormatType = ExportFormatType.PortableDocFormat
                expo.DestinationOptions = oDfDopt
                RPTOPDALLBILLS.Export()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub sendmailtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendmailtool.Click
        Dim emailid As String = ""
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Transfer()
        Try
            Dim objmail As New SendMail
            objmail.attachment = Application.StartupPath & "\IPD Details.PDF"
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


End Class