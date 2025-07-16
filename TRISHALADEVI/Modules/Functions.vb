
Imports System.Windows.Forms
Imports System.Net.Mail
Imports BL
Imports System.IO
Imports System.Web
Imports System.Net
Imports System.Text
Imports WAProAPI
Imports Newtonsoft.Json

Module Functions

#Region "OTHERS"

    Public Sub pcase(ByRef txt As Object)
        txt.Text = StrConv(txt.Text, VbStrConv.ProperCase)
    End Sub

    Public Sub uppercase(ByRef txt As Object)
        txt.Text = StrConv(txt.Text, VbStrConv.Uppercase)
    End Sub

    Public Sub lowercase(ByRef txt As Object)
        txt.Text = StrConv(txt.Text, VbStrConv.Lowercase)
    End Sub

    Function ErrHandle(ByVal Errcode As Integer) As Boolean
        Dim bln As Boolean = False
        If Errcode = -675406840 Then
            MsgBox("Check Internet Connection")
            bln = True
        End If
        Return bln
    End Function
#End Region

#Region "WHATSAPP"

    Function CHECKWHASTAPPEXP() As Boolean
        Dim BLN As Boolean = True
        If Now.Date > WHATSAPPEXPDATE Then
            BLN = False
        End If
        Return BLN
    End Function

    Function GETWHATSAPPBASEURL() As String
        Dim WHATSAPPBASEURL As String = ""

        'READ BASEURL FROM C DRIVE
        If File.Exists("C:\WHATSAPPBASEURL.txt") Then
            Dim oRead As System.IO.StreamReader = File.OpenText("C:\WHATSAPPBASEURL.txt")
            WHATSAPPBASEURL = oRead.ReadToEnd
        End If
        Return WHATSAPPBASEURL
    End Function

    Async Function SENDWHATSAPPATTACHMENT(WHATSAPPNO As String, PATH As String, FILENAME As String) As Threading.Tasks.Task(Of String)
        Dim RESPONSE As String = ""
        Dim waMediaMsgBody As SendMediaMsgJson = New SendMediaMsgJson()
        Dim Attachment As String = Convert.ToBase64String(File.ReadAllBytes(PATH))
        Dim AttachmentFileName As String = FILENAME
        waMediaMsgBody.base64data = Attachment
        waMediaMsgBody.mimeType = MimeMapping.GetMimeMapping(AttachmentFileName)
        waMediaMsgBody.caption = "APIMethod SendMediaMessage from CISPLWhatsAppAPI.dll"
        waMediaMsgBody.filename = AttachmentFileName
        Dim txnResp As TxnRespWithSendMessageDtls = Await APIMethods.SendMediaMessageAsync(WHATSAPPNO, waMediaMsgBody)
        RESPONSE = JsonConvert.SerializeObject(txnResp, Formatting.Indented)

        Return RESPONSE
    End Function

    Async Function SENDWHATSAPPMESSAGE(WHATSAPPNO As String, TEXTMESSAGE As String) As Threading.Tasks.Task(Of String)
        Dim RESPONSE As String = ""
        Dim Body As SendTextMsgJson = New SendTextMsgJson()
        Body.text = TEXTMESSAGE
        Dim txnResp As TxnRespWithSendMessageDtls = Await APIMethods.SendTextMessageAsync(WHATSAPPNO, Body)
        RESPONSE = JsonConvert.SerializeObject(txnResp, Formatting.Indented)
        Return RESPONSE
    End Function

    Async Function CHECKMOBILECONNECTSTATUS() As Threading.Tasks.Task(Of String)
        Dim RESPONSE As String = ""
        Dim txnResp As TxnRespWithConnectionState = Await APIMethods.GetConnectionStateAsync()
        RESPONSE = JsonConvert.SerializeObject(txnResp, Formatting.Indented)
        Return RESPONSE
    End Function

#End Region


    Sub FILLPATIENT(ByRef CMBNAME As ComboBox)
        Try
            If CMBNAME.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" PATIENT_NAME ", "", " PATIENTMASTER", " AND PATIENT_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "PATIENT_NAME"
                    CMBNAME.DataSource = dt
                    CMBNAME.DisplayMember = "PATIENT_NAME"
                    CMBNAME.Text = ""
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub PATIENTVALIDATE(ByRef CMBNAME As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBNAME.Text.Trim <> "" Then
                uppercase(CMBNAME)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" PATIENT_ID ", "", " PATIENTMASTER ", " AND PATIENT_NAME = '" & CMBNAME.Text.Trim & "' AND  PATIENT_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("PATIENT not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("PATIENT")
                        alParaval.Add(UCase(CMBNAME.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJCATEGORY As New ClsSelectMaster
                        OBJCATEGORY.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJCATEGORY.SAVE()
                    Else
                        CMBNAME.Focus()
                        CMBNAME.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub


    Sub FILLMRDNO(ByRef CMBMRDNO As ComboBox)
        Try
            If CMBMRDNO.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" PATIENT_MRDNO ", "", " PATIENTMASTER", " AND PATIENT_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "PATIENT_MRDNO"
                    CMBMRDNO.DataSource = dt
                    CMBMRDNO.DisplayMember = "PATIENT_MRDNO"
                End If
                CMBMRDNO.SelectAll()
                CMBMRDNO.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLSURGERY(ByRef CMBSURGERY As ComboBox)
        Try
            If CMBSURGERY.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable = OBJcommon.search(" SURGERY_NAME ", "", " SURGERYMASTER", " AND SURGERY_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "SURGERY_NAME"
                    CMBSURGERY.DataSource = dt
                    CMBSURGERY.DisplayMember = "SURGERY_NAME"
                End If
                CMBSURGERY.SelectAll()
                CMBSURGERY.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLAMOUNT(ByRef CMBAMOUNT As ComboBox)
        Try
            If CMBAMOUNT.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable = OBJcommon.search(" AMOUNT_NAME ", "", " AMOUNTMASTER", " AND AMOUNT_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "AMOUNT_NAME"
                    CMBAMOUNT.DataSource = dt
                    CMBAMOUNT.DisplayMember = "AMOUNT_NAME"
                End If
                CMBAMOUNT.SelectAll()
                CMBAMOUNT.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLDOCTOR(ByRef CMBDOCTOR As ComboBox)
        Try
            If CMBDOCTOR.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable = OBJcommon.search(" DOCTOR_NAME ", "", " DOCTORMASTER", " AND DOCTOR_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "DOCTOR_NAME"
                    CMBDOCTOR.DataSource = dt
                    CMBDOCTOR.DisplayMember = "DOCTOR_NAME"
                End If
                CMBDOCTOR.SelectAll()
                CMBDOCTOR.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub DOCTORVALIDATE(ByRef CMBDOCTOR As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBDOCTOR.Text.Trim <> "" Then
                uppercase(CMBDOCTOR)
                Dim OBJCMN As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJCMN.search(" DOCTOR_ID ", "", " DOCTORMASTER ", " AND DOCTOR_NAME = '" & CMBDOCTOR.Text.Trim & "'")
                If dt.Rows.Count = 0 Then
                    Dim a As String = CMBDOCTOR.Text.Trim
                    Dim tempmsg As Integer = MsgBox("DOCTOR not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        CMBDOCTOR.Text = a
                        Dim OBJDOCTOR As New DoctorMaster
                        OBJDOCTOR.TEMPDOCTOR = CMBDOCTOR.Text.Trim()
                        OBJDOCTOR.ShowDialog()
                        dt = OBJCMN.search(" DOCTOR_ID ", "", " DOCTORMASTER ", " AND DOCTOR_DOCTOR = '" & CMBDOCTOR.Text.Trim & "'")
                        If dt.Rows.Count > 0 Then
                            Dim dt1 As New DataTable
                            dt1 = CMBDOCTOR.DataSource
                            If CMBDOCTOR.DataSource <> Nothing Then
line1:
                                If dt1.Rows.Count > 0 Then
                                    dt1.Rows.Add(CMBDOCTOR.Text.Trim)
                                    CMBDOCTOR.Text = a
                                End If
                            End If
                        End If
                        e.Cancel = True
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo line1
            Throw ex
        End Try
    End Sub

    Sub FILLCATEGORY(ByRef CMBCATEGORY As ComboBox)
        Try
            If CMBCATEGORY.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" CATEGORY_NAME ", "", " CATEGORYMASTER", " AND CATEGORY_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "CATEGORY_NAME"
                    CMBCATEGORY.DataSource = dt
                    CMBCATEGORY.DisplayMember = "CATEGORY_NAME"
                    CMBCATEGORY.Text = ""
                End If
                CMBCATEGORY.SelectAll()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CATEGORYVALIDATE(ByRef CMBCATEGORY As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBCATEGORY.Text.Trim <> "" Then
                uppercase(CMBCATEGORY)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" CATEGORY_ID ", "", " CATEGORYMASTER ", " AND CATEGORY_NAME = '" & CMBCATEGORY.Text.Trim & "' AND CATEGORY_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Category not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("CATEGORY")
                        alParaval.Add(UCase(CMBCATEGORY.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJCATEGORY As New ClsSelectMaster
                        OBJCATEGORY.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJCATEGORY.SAVE()
                    Else
                        CMBCATEGORY.Focus()
                        CMBCATEGORY.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub SPECIALIZATIONVALIDATE(ByRef CMBCATEGORY As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBCATEGORY.Text.Trim <> "" Then
                uppercase(CMBCATEGORY)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" CATEGORY_ID ", "", " CATEGORYMASTER ", " AND CATEGORY_NAME = '" & CMBCATEGORY.Text.Trim & "' AND CATEGORY_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Specialization not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("CATEGORY")
                        alParaval.Add(UCase(CMBCATEGORY.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJCATEGORY As New ClsSelectMaster
                        OBJCATEGORY.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJCATEGORY.SAVE()
                    Else
                        CMBCATEGORY.Focus()
                        CMBCATEGORY.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLVILLAGE(ByRef CMBVILLAGE As ComboBox)
        Try
            If CMBVILLAGE.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" VILLAGE_NAME ", "", " VILLAGEMASTER", " AND VILLAGE_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "VILLAGE_NAME"
                    CMBVILLAGE.DataSource = dt
                    CMBVILLAGE.DisplayMember = "VILLAGE_NAME"
                End If
                CMBVILLAGE.SelectAll()
                CMBVILLAGE.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub VILLAGEVALIDATE(ByRef CMBVILLAGE As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBVILLAGE.Text.Trim <> "" Then
                uppercase(CMBVILLAGE)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" VILLAGE_ID ", "", " VILLAGEMASTER ", " AND VILLAGE_NAME = '" & CMBVILLAGE.Text.Trim & "' AND VILLAGE_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Village not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("VILLAGE")
                        alParaval.Add(UCase(CMBVILLAGE.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)

                        Dim OBJVILLAGE As New ClsSelectMaster
                        OBJVILLAGE.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJVILLAGE.SAVE()
                    Else
                        CMBVILLAGE.Focus()
                        CMBVILLAGE.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLTALUKA(ByRef CMBTALUKA As ComboBox)
        Try
            If CMBTALUKA.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" TALUKA_NAME ", "", " TALUKAMASTER ", " AND TALUKA_CMPID=" & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "TALUKA_NAME"
                    CMBTALUKA.DataSource = dt
                    CMBTALUKA.DisplayMember = "TALUKA_NAME"
                End If
                CMBTALUKA.SelectAll()
                CMBTALUKA.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub AREAVALIDATE(ByRef CMBVILLAGE As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBVILLAGE.Text.Trim <> "" Then
                uppercase(CMBVILLAGE)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" VILLAGE_ID ", "", " VILLAGEMASTER ", " AND VILLAGE_NAME = '" & CMBVILLAGE.Text.Trim & "' AND VILLAGE_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Area not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("VILLAGE")
                        alParaval.Add(UCase(CMBVILLAGE.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)

                        Dim OBJVILLAGE As New ClsSelectMaster
                        OBJVILLAGE.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJVILLAGE.SAVE()
                    Else
                        CMBVILLAGE.Focus()
                        CMBVILLAGE.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub TALUKAVALIDATE(ByRef CMBTALUKA As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBTALUKA.Text.Trim <> "" Then
                uppercase(CMBTALUKA)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" TALUKA_ID ", "", " TALUKAMASTER ", " AND TALUKA_NAME = '" & CMBTALUKA.Text.Trim & "' AND TALUKA_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Taluka not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("TALUKA")
                        alParaval.Add(UCase(CMBTALUKA.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJTALUKA As New ClsSelectMaster
                        OBJTALUKA.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJTALUKA.SAVE()
                    Else
                        CMBTALUKA.Focus()
                        CMBTALUKA.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLDISTRICT(ByRef CMBDISTRICT As ComboBox)
        Try
            If CMBDISTRICT.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" DISTRICT_NAME ", "", " DISTRICTMASTER ", " AND DISTRICT_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "DISTRICT_NAME"
                    CMBDISTRICT.DataSource = dt
                    CMBDISTRICT.DisplayMember = "DISTRICT_NAME"
                End If
                CMBDISTRICT.SelectAll()
                CMBDISTRICT.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub DISTRICTVALIDATE(ByRef CMBDISTRICT As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBDISTRICT.Text.Trim <> "" Then
                uppercase(CMBDISTRICT)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" DISTRICT_ID ", "", " DISTRICTMASTER ", " AND DISTRICT_NAME = '" & CMBDISTRICT.Text.Trim & "' AND DISTRICT_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("District not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("DISTRICT")
                        alParaval.Add(UCase(CMBDISTRICT.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJDISTRICT As New ClsSelectMaster
                        OBJDISTRICT.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJDISTRICT.SAVE()
                    Else
                        CMBDISTRICT.Focus()
                        CMBDISTRICT.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLMEDICINES(ByRef CMBMEDICINE As ComboBox)
        Try
            If CMBMEDICINE.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" MEDICINE_NAME ", "", " MEDICINEMASTER ", " AND MEDICINE_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "MEDICINE_NAME"
                    CMBMEDICINE.DataSource = dt
                    CMBMEDICINE.DisplayMember = "MEDICINE_NAME"
                End If
                CMBMEDICINE.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub MEDICINEVALIDATE(ByRef CMBMEDICINE As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBMEDICINE.Text.Trim <> "" Then
                uppercase(CMBMEDICINE)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" MEDICINE_ID ", "", " MEDICINEMASTER ", " AND MEDICINE_NAME = '" & CMBMEDICINE.Text.Trim & "' AND MEDICINE_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Medicine not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("MEDICINE")
                        alParaval.Add(UCase(CMBMEDICINE.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJDISTRICT As New ClsSelectMaster
                        OBJDISTRICT.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJDISTRICT.SAVE()
                    Else
                        CMBMEDICINE.Focus()
                        CMBMEDICINE.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLOPERATIVEPROC(ByRef CMBOPPROC As ComboBox)
        Try
            If CMBOPPROC.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" OPPROC_NAME ", "", " OPPROCMASTER ", " AND OPPROC_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "OPPROC_NAME"
                    CMBOPPROC.DataSource = dt
                    CMBOPPROC.DisplayMember = "OPPROC_NAME"
                End If
                CMBOPPROC.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub OPPROCVALIDATE(ByRef CMBOPPROC As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBOPPROC.Text.Trim <> "" Then
                uppercase(CMBOPPROC)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" OPPROC_ID ", "", " OPPROCMASTER ", " AND OPPROC_NAME = '" & CMBOPPROC.Text.Trim & "' AND OPPROC_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Procedure not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("OPPROC")
                        alParaval.Add(UCase(CMBOPPROC.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJDISTRICT As New ClsSelectMaster
                        OBJDISTRICT.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJDISTRICT.SAVE()
                    Else
                        CMBOPPROC.Focus()
                        CMBOPPROC.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLCHARGE(ByRef CMBCHARGES As ComboBox)
        Try
            If CMBCHARGES.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" CHARGE_NAME ", "", "CHARGEMASTER", " AND CHARGE_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "CHARGE_NAME"
                    CMBCHARGES.DataSource = dt
                    CMBCHARGES.DisplayMember = "CHARGE_NAME"
                End If
                CMBCHARGES.SelectAll()
                CMBCHARGES.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CHARGEVALIDATE(ByRef CMBCHARGES As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBCHARGES.Text.Trim <> "" Then
                uppercase(CMBCHARGES)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" CHARGE_ID ", "", "CHARGEMASTER", " AND CHARGE_NAME = '" & CMBCHARGES.Text.Trim & "' AND CHARGE_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Charge not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("CHARGE")
                        alParaval.Add(UCase(CMBCHARGES.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJDISTRICT As New ClsSelectMaster
                        OBJDISTRICT.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJDISTRICT.SAVE()
                    Else
                        CMBCHARGES.Focus()
                        CMBCHARGES.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLOCCUPATION(ByRef CMBOCCUPATION As ComboBox)
        Try
            If CMBOCCUPATION.Text.Trim = "" Then
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" OCCUPATION_NAME ", "", " OCCUPATIONMASTER ", " AND OCCUPATION_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "OCCUPATION_NAME"
                    CMBOCCUPATION.DataSource = dt
                    CMBOCCUPATION.DisplayMember = "OCCUPATION_NAME"
                End If
                CMBOCCUPATION.SelectAll()
                CMBOCCUPATION.Text = ""
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub OCCUPATIONVALIDATE(ByRef CMBOCCUPATION As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBOCCUPATION.Text.Trim <> "" Then
                uppercase(CMBOCCUPATION)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" OCCUPATION_ID ", "", "OCCUPATIONMASTER ", " AND OCCUPATION_NAME = '" & CMBOCCUPATION.Text.Trim & "' AND OCCUPATION_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Occupation not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add("OCCUPATION")
                        alParaval.Add(UCase(CMBOCCUPATION.Text.Trim))
                        alParaval.Add(CmpId)
                        alParaval.Add(Userid)


                        Dim OBJOCCUPATION As New ClsSelectMaster
                        OBJOCCUPATION.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJOCCUPATION.SAVE()
                    Else
                        CMBOCCUPATION.Focus()
                        CMBOCCUPATION.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub sendemail(ByVal toMail As String, ByVal tempattachment As String, ByVal mailbody As String, ByVal subject As String, Optional ByVal TEMPATTACHMENT1 As String = "")

        'Dim mailBody As String
        Try
            Cursor.Current = Cursors.WaitCursor

            'create the mail message
            Dim mail As New MailMessage
            Dim MAILATTACHMENT As Attachment

            'set the addresses
            mail.From = New MailAddress("mstraders5472@gmail.com", "M.S. TRADERS")
            mail.To.Add(toMail)


            'set the content
            mail.Subject = subject
            mail.Body = mailbody
            mail.IsBodyHtml = True
            MAILATTACHMENT = New Attachment(tempattachment)
            mail.Attachments.Add(MAILATTACHMENT)


            If TEMPATTACHMENT1 <> "" Then
                MAILATTACHMENT = New Attachment(TEMPATTACHMENT1)
                mail.Attachments.Add(MAILATTACHMENT)
            End If


            'send the message
            Dim smtp As New SmtpClient

            'set username and password
            Dim nc As New System.Net.NetworkCredential


            'GET SMTP, EMAILADD AND PASSWORD FROM USERMASTER
            Dim OBJCMN As New ClsCommon
            Dim DT As DataTable = OBJCMN.search("USER_SMTP AS SMTP, USER_SMTPEMAIL AS EMAIL, USER_SMTPPASS AS PASS", "", " USERMASTER", " AND USER_NAME = '" & UserName & "' and USER_CMPID = " & CmpId)
            'Dim DT As DataTable = OBJCMN.search("USER_SMTP AS SMTP, USER_SMTPEMAIL AS EMAIL, USER_SMTPPASS AS PASS", "", " USERMASTER", " AND USER_id = '" & Userid & "' and USER_CMPID = " & CmpId)
            If DT.Rows.Count > 0 Then
                If DT.Rows(0).Item("SMTP") = "" Then smtp.Host = "smtp.gmail.com" Else smtp.Host = DT.Rows(0).Item("SMTP")
                smtp.Port = (25)
                smtp.EnableSsl = True

                nc.UserName = DT.Rows(0).Item("EMAIL")
                nc.Password = DT.Rows(0).Item("PASS")
            Else

                smtp.Host = "smtp.gmail.com"
                smtp.Port = (25)
                smtp.EnableSsl = True

                nc.UserName = "gulkitjain@gmail.com"
                nc.Password = "gulkit3042"

            End If

            smtp.Timeout = 50000
            smtp.Credentials = nc
            smtp.Send(mail)
            mail.Dispose()

        Catch ex As Exception
            Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub FILLUSER(ByRef CMBUSER As ComboBox, Optional ByVal CONDITION As String = "")
        Try
            Dim OBJcommon As New ClsCommon
            Dim dt As DataTable

            dt = OBJcommon.search(" DISTINCT User_Name as [UserName]", "", "USERMASTER", " and USERMASTER.USER_cmpid= " & CmpId & " ORDER BY USER_NAME ")
            If dt.Rows.Count > 0 Then
                dt.DefaultView.Sort = "USERNAME"
                CMBUSER.DataSource = dt
                CMBUSER.DisplayMember = "USERNAME"
                CMBUSER.Text = ""
            End If
            CMBUSER.SelectAll()
            CMBUSER.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function GETMAX(ByVal fldname As String, ByVal tbname As String, Optional ByVal whereclause As String = "") As DataTable
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim DTTABLE As DataTable

            Dim objclscommon As New ClsCommon()
            DTTABLE = objclscommon.GETMAXNO(fldname, tbname, whereclause)

            Return DTTABLE
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Function

    Sub NAMEVALIDATE(ByRef CMBNAME As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBNAME.Text.Trim <> "" Then
                uppercase(CMBNAME)
                Dim OBJCMN As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJCMN.search(" PATIENT_ID ", "", " PATIENTMASTER ", " AND PATIENT_NAME = '" & CMBNAME.Text.Trim & "'")
                If dt.Rows.Count = 0 Then
                    Dim a As String = CMBNAME.Text.Trim
                    Dim tempmsg As Integer = MsgBox("Patient not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        CMBNAME.Text = a
                        Dim OBJPATIENT As New PatientMaster
                        OBJPATIENT.TEMPNAME = CMBNAME.Text.Trim()
                        OBJPATIENT.ShowDialog()
                        dt = OBJCMN.search(" PATIENT_ID ", "", " PATIENTMASTER ", " AND PATIENT_NAME = '" & CMBNAME.Text.Trim & "'")
                        If dt.Rows.Count > 0 Then
                            Dim dt1 As New DataTable
                            dt1 = CMBNAME.DataSource
                            If CMBNAME.DataSource <> Nothing Then
line1:
                                If dt1.Rows.Count > 0 Then
                                    dt1.Rows.Add(CMBNAME.Text.Trim)
                                    CMBNAME.Text = a
                                End If
                            End If
                        End If
                        e.Cancel = True
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo line1
            Throw ex
        End Try
    End Sub

    Sub SURGERYVALIDATE(ByRef CMBSURGERY As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBSURGERY.Text.Trim <> "" Then
                uppercase(CMBSURGERY)
                Dim OBJCMN As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJCMN.search(" SURGERY_ID AS SURGERYID ", "", " SURGERYMASTER ", " AND SURGERY_NAME = '" & CMBSURGERY.Text.Trim & "' AND SURGERY_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim a As String = CMBSURGERY.Text.Trim
                    Dim tempmsg As Integer = MsgBox("Surgery not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        CMBSURGERY.Text = a
                        Dim OBJSURGERY As New SurgeryMaster
                        OBJSURGERY.TEMPNAME = CMBSURGERY.Text.Trim()
                        OBJSURGERY.ShowDialog()
                        dt = OBJCMN.search(" SURGERY_ID AS SURGERYID ", "", " SURGERYMASTER ", " AND SURGERY_NAME = '" & CMBSURGERY.Text.Trim & "' AND SURGERY_CMPID = " & CmpId)
                        If dt.Rows.Count > 0 Then
                            Dim dt1 As New DataTable
                            dt1 = CMBSURGERY.DataSource
                            If CMBSURGERY.DataSource <> Nothing Then
line1:
                                If dt1.Rows.Count > 0 Then
                                    dt1.Rows.Add(CMBSURGERY.Text.Trim)
                                    CMBSURGERY.Text = a
                                End If
                            End If
                        End If
                        e.Cancel = True
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo line1
            Throw ex
        End Try
    End Sub

    Sub AMOUNTVALIDATE(ByRef CMBAMOUNT As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBAMOUNT.Text.Trim <> "" Then
                uppercase(CMBAMOUNT)
                Dim OBJCMN As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJCMN.search(" AMOUNT_ID AS AMOUNTID ", "", " AMOUNTMASTER ", " AND AMOUNT_NAME = '" & CMBAMOUNT.Text.Trim & "' AND AMOUNT_CMPID = " & CmpId)
                If dt.Rows.Count = 0 Then
                    Dim a As String = CMBAMOUNT.Text.Trim
                    Dim tempmsg As Integer = MsgBox("AMOUNT not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        CMBAMOUNT.Text = a
                        Dim OBJAMOUNT As New AmountMaster
                        OBJAMOUNT.TEMPNAME = CMBAMOUNT.Text.Trim()
                        OBJAMOUNT.ShowDialog()
                        dt = OBJCMN.search(" AMOUNT_ID AS AMOUNTID ", "", " AMOUNTMASTER ", " AND AMOUNT_NAME = '" & CMBAMOUNT.Text.Trim & "' AND AMOUNT_CMPID = " & CmpId)
                        If dt.Rows.Count > 0 Then
                            Dim dt1 As New DataTable
                            dt1 = CMBAMOUNT.DataSource
                            If CMBAMOUNT.DataSource <> Nothing Then
line1:
                                If dt1.Rows.Count > 0 Then
                                    dt1.Rows.Add(CMBAMOUNT.Text.Trim)
                                    CMBAMOUNT.Text = a
                                End If
                            End If
                        End If
                        e.Cancel = True
                    Else
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
            GoTo line1
            Throw ex
        End Try
    End Sub

    Sub FILLCITY(ByRef CMBCITY As ComboBox)
        Try
            If CMBCITY.Text.Trim = "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable

                dt = objclscommon.search(" CITY_name ", "", " CITYMaster", " and CITY_cmpid=" & CmpId & " AND CITY_LOCATIONID = " & Locationid & " AND CITY_YEARID = " & YearId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "CITY_name"
                    CMBCITY.DataSource = dt
                    CMBCITY.DisplayMember = "CITY_name"
                    CMBCITY.Text = ""
                End If
                CMBCITY.SelectAll()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CITYVALIDATE(ByRef CMBCITY As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBCITY.Text.Trim <> "" Then
                uppercase(CMBCITY)
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = objclscommon.search("CITY_id", "", "CITYMaster", " and CITY_NAME = '" & CMBCITY.Text.Trim & "' and CITY_cmpid = " & CmpId & " and CITY_LOCATIONid = " & Locationid & " and CITY_YEARid = " & YearId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("CITY not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add(UCase(CMBCITY.Text.Trim))
                        alParaval.Add("")
                        alParaval.Add(CmpId)
                        alParaval.Add(Locationid)
                        alParaval.Add(Userid)
                        alParaval.Add(YearId)
                        alParaval.Add(0)

                        Dim OBJCITY As New ClsCityMaster
                        OBJCITY.alParaval = alParaval
                        Dim IntResult As Integer = OBJCITY.save()
                    Else
                        CMBCITY.Focus()
                        CMBCITY.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLSTATE(ByRef CMBSTATE As ComboBox)
        Try

            If CMBSTATE.Text.Trim = "" Then
                Dim objclscommom As New ClsCommonMaster
                Dim dt As DataTable = objclscommom.search(" STATE_name ", " ", " STATEMASTER ", " AND STATE_cmpid = " & CmpId & " AND STATE_yearid =  " & YearId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "STATE_name"
                    CMBSTATE.DataSource = dt
                    CMBSTATE.DisplayMember = "STATE_name"
                    CMBSTATE.Text = ""
                End If
                CMBSTATE.SelectAll()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub STATEVALIDATE(ByRef CMBSTATE As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBSTATE.Text.Trim <> "" Then
                uppercase(CMBSTATE)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" STATE_id", "", "STATEMASTER", " and STATE_NAME = '" & CMBSTATE.Text.Trim & "' and STATE_cmpid = " & CmpId & " and STATE_LOCATIONid = " & Locationid & " and STATE_YEARid = " & YearId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("State not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add(UCase(CMBSTATE.Text.Trim))
                        alParaval.Add("")
                        alParaval.Add(CmpId)
                        alParaval.Add(Locationid)
                        alParaval.Add(Userid)
                        alParaval.Add(YearId)
                        alParaval.Add(0)

                        Dim OBJSTATE As New ClsCityMaster
                        OBJSTATE.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJSTATE.SAVESTATE()
                    Else
                        CMBSTATE.Focus()
                        CMBSTATE.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCOUNTRY(ByRef CMBCOUNTRY As ComboBox)
        Try
            If CMBCOUNTRY.Text.Trim = "" Then
                Dim objclscommom As New ClsCommonMaster
                Dim dt As DataTable = objclscommom.search(" COUNTRY_name ", " ", " COUNTRYMASTER ", " AND COUNTRY_cmpid = " & CmpId & " AND COUNTRY_yearid =  " & YearId)
                If dt.Rows.Count > 0 Then
                    dt.DefaultView.Sort = "COUNTRY_name"
                    CMBCOUNTRY.DataSource = dt
                    CMBCOUNTRY.DisplayMember = "COUNTRY_name"
                    CMBCOUNTRY.Text = ""
                End If
                CMBCOUNTRY.SelectAll()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub COUNTRYVALIDATE(ByRef CMBCOUNTRY As ComboBox, ByRef e As System.ComponentModel.CancelEventArgs, ByRef frm As System.Windows.Forms.Form)
        Try
            Cursor.Current = Cursors.WaitCursor
            If CMBCOUNTRY.Text.Trim <> "" Then
                uppercase(CMBCOUNTRY)
                Dim OBJcommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = OBJcommon.search(" COUNTRY_ID ", "", " COUNTRYMASTER ", " AND COUNTRY_NAME = '" & CMBCOUNTRY.Text.Trim & "' AND COUNTRY_cmpid = " & CmpId & " AND COUNTRY_yearid =  " & YearId)
                If dt.Rows.Count = 0 Then
                    Dim tempmsg As Integer = MsgBox("Country not present, Add New?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                    If tempmsg = vbYes Then
                        Dim alParaval As New ArrayList

                        alParaval.Add(UCase(CMBCOUNTRY.Text.Trim))
                        alParaval.Add("")
                        alParaval.Add(CmpId)
                        alParaval.Add(Locationid)
                        alParaval.Add(Userid)
                        alParaval.Add(YearId)
                        alParaval.Add(0)

                        Dim OBJCOUNTRY As New ClsCityMaster
                        OBJCOUNTRY.ALPARAVAL = alParaval
                        Dim IntResult As Integer = OBJCOUNTRY.SAVECOUNTRY()
                    Else
                        CMBCOUNTRY.Focus()
                        CMBCOUNTRY.SelectAll()
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "KEYPRESS"

    Sub numkeypress(ByVal han As KeyPressEventArgs, ByVal sen As Control, ByVal frm As System.Windows.Forms.Form)
        'If AscW(han.KeyChar) = 13 Then
        '    SendKeys.Send("{Tab}")
        '    han.KeyChar = ""
        'End If

        If AscW(han.KeyChar) >= 48 And AscW(han.KeyChar) <= 57 Or AscW(han.KeyChar) = 8 Then
            han.KeyChar = han.KeyChar
        Else
            han.KeyChar = ""
        End If

        If AscW(han.KeyChar) = Keys.Escape Then
            frm.Close()
        End If
    End Sub

    Sub numdot(ByVal han As KeyPressEventArgs, ByVal txt As System.Windows.Forms.TextBox, ByVal frm As System.Windows.Forms.Form)
        Dim mypos As Integer

        mypos = InStr(1, txt.Text, ".")

        'If AscW(han.KeyChar) = 13 Then
        '    SendKeys.Send("{Tab}")
        '    han.KeyChar = ""
        'End If

        If AscW(han.KeyChar) > 47 And AscW(han.KeyChar) < 58 Or AscW(han.KeyChar) = 8 Or AscW(han.KeyChar) = 46 Then
            han.KeyChar = han.KeyChar
        Else
            han.KeyChar = ""
        End If


        If AscW(han.KeyChar) > 47 And AscW(han.KeyChar) < 58 And mypos <> "0" Then
            If txt.SelectionStart = mypos + 2 Then
                han.KeyChar = ""
            End If
        End If

        If txt.SelectionStart >= mypos Then
            txt.SelectionLength = 1
            han.KeyChar = han.KeyChar
        End If

        If AscW(han.KeyChar) = 46 Then

            'test = True
            mypos = InStr(1, txt.Text, ".")
            If mypos <> "0" Then txt.SelectionStart = mypos
            If mypos = 0 Then
                han.KeyChar = han.KeyChar
            Else
                han.KeyChar = ""
            End If

        End If

        If AscW(han.KeyChar) = Keys.Escape Then
            frm.Close()
        End If
    End Sub

    Sub numdotkeypress(ByVal han As KeyPressEventArgs, ByVal sen As Object, ByVal frm As System.Windows.Forms.Form)
        Dim mypos As Integer

        'If AscW(han.KeyChar) = 13 Then
        '    SendKeys.Send("{Tab}")
        '    han.KeyChar = ""
        'End If
        If AscW(han.KeyChar) >= 48 And AscW(han.KeyChar) <= 57 Or AscW(han.KeyChar) = 8 Then
            han.KeyChar = han.KeyChar
        ElseIf AscW(han.KeyChar) = 46 Then
            mypos = InStr(1, sen.Text, ".")
            If mypos = 0 Then
                han.KeyChar = han.KeyChar
            Else
                han.KeyChar = ""
            End If
        Else
            han.KeyChar = ""
        End If

        If AscW(han.KeyChar) = Keys.Escape Then
            frm.Close()
        End If
    End Sub

    Sub enterkeypress(ByVal han As KeyPressEventArgs, ByVal frm As System.Windows.Forms.Form)
        If AscW(han.KeyChar) = 13 Then
            SendKeys.Send("{Tab}")
            han.KeyChar = ""
        End If
    End Sub

#End Region

#Region "IN WORDS FUNCTION"

    Function CurrencyToWord(ByVal Num As Decimal) As String

        'I have created this function for converting amount in indian rupees (INR). 
        'You can manipulate as you wish like decimal setting, Doller (any currency) Prefix.

        Dim strNum As String
        Dim strNumDec As String
        Dim StrWord As String
        strNum = Num

        If InStr(1, strNum, ".") <> 0 Then
            strNumDec = Mid(strNum, InStr(1, strNum, ".") + 1)

            If Len(strNumDec) = 1 Then
                strNumDec = strNumDec + "0"
            End If
            If Len(strNumDec) > 2 Then
                strNumDec = Mid(strNumDec, 1, 2)
            End If

            strNum = Mid(strNum, 1, InStr(1, strNum, ".") - 1)
            StrWord = IIf(CDbl(strNum) = 1, " Rupee ", " Rupees ") + NumToWord(CDbl(strNum)) + IIf(CDbl(strNumDec) > 0, " and Paise" + cWord3(CDbl(strNumDec)), "")
        Else
            StrWord = IIf(CDbl(strNum) = 1, " Rupee ", " Rupees ") + NumToWord(CDbl(strNum))
        End If
        CurrencyToWord = StrWord & " Only"
        Return CurrencyToWord

    End Function

    Function NumToWord(ByVal Num As Decimal) As String

        'I divided this function in two part.
        '1. Three or less digit number.
        '2. more than three digit number.
        Dim strNum As String
        Dim StrWord As String
        strNum = Num

        If Len(strNum) <= 3 Then
            StrWord = cWord3(CDbl(strNum))
        Else
            StrWord = cWordG3(CDbl(Mid(strNum, 1, Len(strNum) - 3))) + " " + cWord3(CDbl(Mid(strNum, Len(strNum) - 2)))
        End If
        NumToWord = StrWord

    End Function

    Function cWordG3(ByVal Num As Decimal) As String

        '2. more than three digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        strNum = Num
        If Len(strNum) Mod 2 <> 0 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            If readNum <> "0" Then
                StrWord = retWord(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 1) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 2)
        End If
        While Not Len(strNum) = 0
            readNum = CDbl(Mid(strNum, 1, 2))
            If readNum <> "0" Then
                StrWord = StrWord + " " + cWord3(readNum)
                readNum = CDbl("1" + strReplicate("0", Len(strNum) - 2) + "000")
                StrWord = StrWord + " " + retWord(readNum)
            End If
            strNum = Mid(strNum, 3)
        End While
        cWordG3 = StrWord
        Return cWordG3

    End Function

    Function strReplicate(ByVal str As String, ByVal intD As Integer) As String

        'This fucntion padded "0" after the number to evaluate hundred, thousand and on....
        'using this function you can replicate any Charactor with given string.
        strReplicate = ""
        For i As Integer = 1 To intD
            strReplicate = strReplicate + str
        Next
        Return strReplicate

    End Function

    Function cWord3(ByVal Num As Decimal) As String

        '1. Three or less digit number.
        Dim strNum As String = ""
        Dim StrWord As String = ""
        Dim readNum As String = ""
        If Num < 0 Then Num = Num * -1
        strNum = Num

        If Len(strNum) = 3 Then
            readNum = CDbl(Mid(strNum, 1, 1))
            StrWord = retWord(readNum) + " Hundred"
            strNum = Mid(strNum, 2, Len(strNum))
        End If

        If Len(strNum) <= 2 Then
            If CDbl(strNum) >= 0 And CDbl(strNum) <= 20 Then
                StrWord = StrWord + " " + retWord(CDbl(strNum))
            Else
                StrWord = StrWord + " " + retWord(CDbl(Mid(strNum, 1, 1) + "0")) + " " + retWord(CDbl(Mid(strNum, 2, 1)))
            End If
        End If

        strNum = CStr(Num)
        cWord3 = StrWord
        Return cWord3

    End Function

    Function retWord(ByVal Num As Decimal) As String
        'This two dimensional array store the primary word convertion of number.
        retWord = ""
        Dim ArrWordList(,) As Object = {{0, ""}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"},
                                        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"},
                                        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"},
                                        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"},
                                        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"},
                                        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}, {100, "Hundred"}, {1000, "Thousand"},
                                        {100000, "Lakh"}, {10000000, "Crore"}}

        For i As Integer = 0 To UBound(ArrWordList)
            If Num = ArrWordList(i, 0) Then
                retWord = ArrWordList(i, 1)
                Exit For
            End If
        Next
        Return retWord

    End Function

#End Region

End Module
