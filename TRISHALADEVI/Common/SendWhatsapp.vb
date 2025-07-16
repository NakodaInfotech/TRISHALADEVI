
Imports System.ComponentModel
Imports Newtonsoft.Json.Linq
Imports BL

Public Class SendWhatsapp
    Public PATH As New ArrayList
    Public FILENAME As New ArrayList
    Dim RESPONSE As String = ""

    Sub FILLGRID()
        Try
            Dim objclsCMST As New ClsCommonMaster
            Dim dt As New DataTable
            If RBDOCTOR.Checked = True Then dt = objclsCMST.search(" CAST (0 AS BIT) AS CHK,ISNULL(DOCTORMASTER.DOCTOR_NAME, '') AS NAME, ISNULL(CITYMASTER.city_name, '') AS CITY, ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS AREA, ISNULL(DOCTORMASTER.DOCTOR_MOBILENO, '') AS MOBILENO ", "", " DOCTORMASTER LEFT OUTER JOIN VILLAGEMASTER ON DOCTORMASTER.DOCTOR_AREAID = VILLAGEMASTER.VILLAGE_ID LEFT OUTER JOIN CITYMASTER ON DOCTORMASTER.DOCTOR_CITYID = CITYMASTER.city_id ", " AND (DOCTORMASTER.DOCTOR_CMPID = " & CmpId & ") ORDER BY DOCTORMASTER.DOCTOR_NAME ") Else dt = objclsCMST.search(" CAST (0 AS BIT) AS CHK, ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME, ISNULL(CITYMASTER.city_name, '') AS CITY, ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS AREA, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILENO ", "", " PATIENTMASTER LEFT OUTER JOIN CITYMASTER ON PATIENTMASTER.PATIENT_DISTRICTID = CITYMASTER.city_id LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID ", " AND (PATIENTMASTER.PATIENT_CMPID = " & CmpId & ") ORDER BY PATIENTMASTER.PATIENT_NAME ")
            gridbilldetails.DataSource = dt
            If dt.Rows.Count > 0 Then
                gridbill.FocusedRowHandle = gridbill.RowCount - 1
                gridbill.TopRowIndex = gridbill.RowCount - 15
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Function errorvalid() As Boolean
        Dim bln As Boolean = True

    End Function

    Private Sub RBDOCTOR_CheckedChanged(sender As Object, e As EventArgs) Handles RBDOCTOR.CheckedChanged, RBPATIENT.CheckedChanged
        FILLGRID()
    End Sub

    Private Sub SendWhatsapp_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'IF AUTOCC IS TRUE THEN GET THE MOBILE NO FROM CMPMASTER AND SHOW IN AUTOCC
            Dim OBJCMN As New ClsCommon
            Dim DT As New DataTable
            If WHATSAPPAUTOCC = True Then
                DT = OBJCMN.search("ISNULL(CMP_TEL,'') AS MOBILENO", "", " CMPMASTER ", " AND CMP_ID = " & CmpId)
                If DT.Rows.Count > 0 Then TXTAUTOCC.Text = DT.Rows(0).Item("MOBILENO")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub ERRORMESSAGE(NO As String)
        Try
            If RESPONSE <> "" Then
                Dim STATUS As String = JObject.Parse(RESPONSE)("success")
                Dim ERRORMSG As String = JObject.Parse(RESPONSE)("message")
                If STATUS = "False" Then MsgBox("Error While Sending Msg to " & NO & ", Error - " & ERRORMSG & ", Response - " & RESPONSE)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Async Sub CMDSEND_Click(sender As Object, e As EventArgs) Handles CMDSEND.Click
        Try

            'FIRST CHECK STATUS OF MOBILE CONNECTION
            Dim CONNECTSTATUS As String = JObject.Parse(Await CHECKMOBILECONNECTSTATUS())("success")
            If CONNECTSTATUS = "False" Then
                MsgBox("Mobile Not connected, Please Check Connection", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If PATH.Count = 0 And TXTPATH.Text.Trim <> "" Then
                PATH.Add(TXTPATH.Text.Trim)
                FILENAME.Add(TXTFILENAME.Text.Trim)
            End If

            For I As Integer = 0 To PATH.Count - 1
                If TXTOTHERNO1.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTOTHERNO1.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTOTHERNO1.Text)
                End If
                If TXTOTHERNO2.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTOTHERNO2.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTOTHERNO2.Text)
                End If
                If TXTOTHERNO3.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTOTHERNO3.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTOTHERNO3.Text)
                End If
                If TXTOTHERNO4.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTOTHERNO4.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTOTHERNO4.Text)
                End If
                If TXTOTHERNO5.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTOTHERNO5.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTOTHERNO5.Text)
                End If
                If TXTAUTOCC.Text.Trim <> "" Then
                    RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & TXTAUTOCC.Text.Trim, PATH(I), FILENAME(I))
                    ERRORMESSAGE(TXTAUTOCC.Text)
                End If

                'SENDING WHATSAPP TO SELETED DOCTORS OR PATIENTS
                gridbill.ClearColumnsFilter()
                For J As Integer = 0 To gridbill.RowCount - 1
                    Dim dtrow As DataRow = gridbill.GetDataRow(J)
                    If Convert.ToBoolean(dtrow("CHK")) = True Then
                        If dtrow("MOBILENO").ToString.Trim <> "" Then
                            RESPONSE = Await SENDWHATSAPPATTACHMENT("91" & dtrow("MOBILENO"), PATH(I), FILENAME(I))
                            ERRORMESSAGE(dtrow("MOBILENO"))
                        End If
                    End If
                Next

            Next


            'TEXT MESSAGE SHOULD BE SEND ONLY ONCE
            If TXTMESSAGE.Text.Trim <> "" Then
                If TXTOTHERNO1.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTOTHERNO1.Text.Trim, TXTMESSAGE.Text.Trim)
                If TXTOTHERNO2.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTOTHERNO2.Text.Trim, TXTMESSAGE.Text.Trim)
                If TXTOTHERNO3.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTOTHERNO3.Text.Trim, TXTMESSAGE.Text.Trim)
                If TXTOTHERNO4.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTOTHERNO4.Text.Trim, TXTMESSAGE.Text.Trim)
                If TXTOTHERNO5.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTOTHERNO5.Text.Trim, TXTMESSAGE.Text.Trim)
                If TXTAUTOCC.Text.Trim <> "" Then Await SENDWHATSAPPMESSAGE("91" & TXTAUTOCC.Text.Trim, TXTMESSAGE.Text.Trim)

                'SENDING WHATSAPP TO SELETED DOCTORS OR PATIENTS
                gridbill.ClearColumnsFilter()
                For J As Integer = 0 To gridbill.RowCount - 1
                    Dim dtrow As DataRow = gridbill.GetDataRow(J)
                    If Convert.ToBoolean(dtrow("CHK")) = True Then
                        If dtrow("MOBILENO").ToString.Trim <> "" Then
                            RESPONSE = Await SENDWHATSAPPMESSAGE("91" & dtrow("MOBILENO"), TXTMESSAGE.Text.Trim)
                        End If
                    End If
                Next

            End If

            MsgBox("Message Sent", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUPLOAD_Click(sender As Object, e As EventArgs) Handles CMDUPLOAD.Click
        Try
            Dim dlgOpenDialog As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
            dlgOpenDialog.Filter = "Attach File | *.png;*.jpg;*.pdf;*.doc;*.*"
            dlgOpenDialog.Title = "Select File"
            dlgOpenDialog.ShowDialog()
            TXTPATH.Text = dlgOpenDialog.FileName
            TXTFILENAME.Text = dlgOpenDialog.SafeFileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class