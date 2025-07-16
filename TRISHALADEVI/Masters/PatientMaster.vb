
Imports BL

Public Class PatientMaster

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPID As Integer
    Public TEMPMRDNO As String
    Public TEMPNAME As String
    Public frmstring As String

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PatientMaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Alt = True And e.KeyCode = Windows.Forms.Keys.F1 Then
                Call OpenToolStripButton_Click(sender, e)
            ElseIf (e.Alt = True And e.KeyCode = Windows.Forms.Keys.X) Or (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            'Fill Category,Village,Taluka,District
            FILLCATEGORY(CMBCATEGORY)
            FILLVILLAGE(CMBVILLAGE)
            FILLTALUKA(CMBTALUKA)
            FILLDISTRICT(CMBDISTRICT)
            FILLOCCUPATION(CMBOCCUPATION)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETMAX_MRDNO()
        Dim DTTABLE As DataTable = GETMAX(" isnull(max(PATIENT_MRDNO),0) + 1 ", "PATIENTMASTER", "AND PATIENT_CMPID = " & CmpId)
        If DTTABLE.Rows.Count > 0 Then TXTMRDNO.Text = DTTABLE.Rows(0).Item(0)
    End Sub

    Private Sub PatientMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'PATIENT MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            FILLCMB()
            CLEAR()

            TXTNAME.Text = TEMPNAME

            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJPATIENT As New ClsPatientMaster

                OBJPATIENT.alParaval.Add(TEMPID)

                dttable = OBJPATIENT.GETPATIENT()

                If dttable.Rows.Count > 0 Then
                    TXTMRDNO.Text = TEMPMRDNO
                    TXTNAME.Text = dttable.Rows(0).Item("NAME")

                    TXTHOF.Text = dttable.Rows(0).Item("HOF").ToString
                    TXTFIRSTNAME.Text = dttable.Rows(0).Item("FIRSTNAME").ToString
                    TXTLASTNAME.Text = dttable.Rows(0).Item("LASTNAME").ToString
                    TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                    CMBSEX.Text = dttable.Rows(0).Item("SEX").ToString

                    CMBCATEGORY.Text = dttable.Rows(0).Item("CATEGORY").ToString
                    CMBVILLAGE.Text = dttable.Rows(0).Item("VILLAGE").ToString
                    CMBTALUKA.Text = dttable.Rows(0).Item("TALUKA").ToString
                    CMBDISTRICT.Text = dttable.Rows(0).Item("DISTRICT").ToString

                    TXTADDRESS.Text = dttable.Rows(0).Item("ADDRESS").ToString
                    TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                    CMBOCCUPATION.Text = dttable.Rows(0).Item("OCCUPATION").ToString
                    If dttable.Rows(0).Item("CHECKCONSULTATION") = 0 Then CHKCONSULTATION.Checked = False Else CHKCONSULTATION.Checked = True
                    TXTMRDNO.Text = dttable.Rows(0).Item("MRDNO").ToString
                    TXTUHLDNO.Text = dttable.Rows(0).Item("UHLDNO").ToString

                    If IsDBNull(dttable.Rows(0).Item("IMGPATH")) = False Then
                        PBPHOTO.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("IMGPATH"), Byte())))
                    Else
                        PBPHOTO.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("DOC1PATH")) = False Then
                        PBDOC1.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("DOC1PATH"), Byte())))
                    Else
                        PBDOC1.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("DOC2PATH")) = False Then
                        PBDOC2.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("DOC2PATH"), Byte())))
                    Else
                        PBDOC2.Image = Nothing
                    End If

                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList

            alParaval.Add(TXTNAME.Text.Trim)
            alParaval.Add(TXTHOF.Text.Trim)
            alParaval.Add(TXTFIRSTNAME.Text.Trim)
            alParaval.Add(TXTLASTNAME.Text.Trim)
            alParaval.Add(Val(TXTAGE.Text.Trim))
            alParaval.Add(CMBSEX.Text.Trim)
            alParaval.Add(CMBCATEGORY.Text.Trim)
            alParaval.Add(CMBVILLAGE.Text.Trim)
            alParaval.Add(CMBTALUKA.Text.Trim)
            alParaval.Add(CMBDISTRICT.Text.Trim)
            alParaval.Add(TXTADDRESS.Text.Trim)
            alParaval.Add(TXTMOBILE.Text.Trim)
            alParaval.Add(CMBOCCUPATION.Text.Trim)
            If CHKCONSULTATION.Checked = True Then
                alParaval.Add(1)
            Else
                alParaval.Add(0)
            End If
            alParaval.Add(TXTMRDNO.Text.Trim)
            alParaval.Add(TXTUHLDNO.Text.Trim)

            'Photo Upload
            If PBPHOTO.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBPHOTO.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'DOC1 Upload
            If PBDOC1.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBDOC1.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'DOC2 Upload
            If PBDOC2.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBDOC2.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            alParaval.Add(CmpId)
            alParaval.Add(Userid)
            'alParaval.Add(YearId)

            Dim OBJPATIENTMASTER As New ClsPatientMaster
            OBJPATIENTMASTER.alParaval = alParaval

            'Save PatientMaster
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJPATIENTMASTER.SAVE()
                ' TEMPID = DT.Rows(0).Item(0)
                'Conversion from type 'DBNull' to type 'Integer' is not valid.
                'cannot find table 0
                MsgBox("Details Added")

            Else
                'Update PatientMaster
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                alParaval.Add(TEMPID)
                IntResult = OBJPATIENTMASTER.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If

            CLEAR()
            TXTNAME.Focus()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMDCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Try
            If EDIT = True Then

                If USERDELETE = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim TEMPMSG As Integer = MsgBox("Wish to Delete?", MsgBoxStyle.YesNo)
                If TEMPMSG = vbNo Then Exit Sub


                Dim ALPARAVAL As New ArrayList

                ALPARAVAL.Add(TEMPID)

                Dim OBJACC As New ClsPatientMaster
                OBJACC.alParaval = ALPARAVAL
                Dim DT As DataTable = OBJACC.DELETE
                If DT.Rows.Count > 0 Then
                    MsgBox(DT.Rows(0).Item(0))
                    EDIT = False
                    CLEAR()
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CLEAR()
        Try
            TXTHOF.Clear()
            TXTFIRSTNAME.Clear()
            TXTLASTNAME.Clear()
            TXTAGE.Clear()
            CMBSEX.SelectedItem = Nothing
            CMBCATEGORY.Text = ""
            CMBVILLAGE.Text = ""
            CMBTALUKA.Text = ""
            CMBDISTRICT.Text = ""
            TXTADDRESS.Clear()
            TXTMOBILE.Clear()
            CMBOCCUPATION.Text = ""
            CHKCONSULTATION.Checked = False
            TXTUHLDNO.Clear()
            PBPHOTO.Image = Nothing
            PBDOC1.Image = Nothing
            PBDOC2.Image = Nothing
            TXTNAME.Clear()
            EP.Clear()
            GETMAX_MRDNO()
            'TXTMRDNO.Text = TXTMRDNO.Text.Trim + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTNAME_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTNAME.Validating
        Try
            If Not CHECKDUPLICATE() Then e.Cancel = True
            uppercase(TXTNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTFIRSTNAME_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTFIRSTNAME.Validated
        Try
            uppercase(TXTFIRSTNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTLASTNAME_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTLASTNAME.Validated
        Try
            uppercase(TXTLASTNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCATEGORY_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBCATEGORY.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJCATEGORY As New SelectForm
                OBJCATEGORY.FRMSTRING = "CATEGORY"
                OBJCATEGORY.ShowDialog()
                If OBJCATEGORY.TEMPNAME <> "" Then CMBCATEGORY.Text = OBJCATEGORY.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCATEGORY_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBCATEGORY.Validating
        Try
            If CMBCATEGORY.Text.Trim <> "" Then CATEGORYVALIDATE(CMBCATEGORY, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBCATEGORY_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCATEGORY.Enter
        Try
            If CMBCATEGORY.Text.Trim = "" Then FILLCATEGORY(CMBCATEGORY)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBOCCUPATION_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBOCCUPATION.Validating
        Try
            If CMBOCCUPATION.Text.Trim <> "" Then OCCUPATIONVALIDATE(CMBOCCUPATION, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBOCCUPATION_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBOCCUPATION.Enter
        Try
            If CMBOCCUPATION.Text.Trim = "" Then FILLOCCUPATION(CMBOCCUPATION)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBVILLAGE_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBVILLAGE.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJVILLAGE As New SelectForm
                OBJVILLAGE.FRMSTRING = "VILLAGE"
                OBJVILLAGE.ShowDialog()
                If OBJVILLAGE.TEMPNAME <> "" Then CMBVILLAGE.Text = OBJVILLAGE.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBVILLAGE_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBVILLAGE.Validating
        Try
            If CMBVILLAGE.Text.Trim <> "" Then VILLAGEVALIDATE(CMBVILLAGE, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBVILLAGE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBVILLAGE.Enter
        Try
            If CMBVILLAGE.Text.Trim = "" Then FILLVILLAGE(CMBVILLAGE)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBTALUKA_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBTALUKA.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJTALUKA As New SelectForm
                OBJTALUKA.FRMSTRING = "TALUKA"
                OBJTALUKA.ShowDialog()
                If OBJTALUKA.TEMPNAME <> "" Then CMBTALUKA.Text = OBJTALUKA.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBTALUKA_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBTALUKA.Validating
        Try
            If CMBTALUKA.Text.Trim <> "" Then TALUKAVALIDATE(CMBTALUKA, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBTALUKA_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBTALUKA.Enter
        Try
            If CMBTALUKA.Text.Trim = "" Then FILLTALUKA(CMBTALUKA)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBDISTRICT_Keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBDISTRICT.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJDISTRICT As New SelectForm
                OBJDISTRICT.FRMSTRING = "DISTRICT"
                OBJDISTRICT.ShowDialog()
                If OBJDISTRICT.TEMPNAME <> "" Then CMBDISTRICT.Text = OBJDISTRICT.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBDISTRICT_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBDISTRICT.Validating
        Try
            If CMBDISTRICT.Text.Trim <> "" Then DISTRICTVALIDATE(CMBDISTRICT, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBDISTRICT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBDISTRICT.Enter
        Try
            If CMBDISTRICT.Text.Trim = "" Then FILLDISTRICT(CMBDISTRICT)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub TXTMRDNO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTMRDNO.Validating
        Try
            'Check for Duplication
            If edit = False Then
                Dim OBJCMN As New ClsCommon
                Dim dt As DataTable = OBJCMN.search(" PATIENTMASTER.PATIENT_MRDNO ", " ", " PATIENTMASTER ", " AND PATIENTMASTER.PATIENT_MRDNO = '" & TXTMRDNO.Text.Trim & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("MRD No Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTUHLDNO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTUHLDNO.Validating
        Try
            'Check for Duplication
            If EDIT = False And (ClientName = "TRISHALADEVIOLDRABKAVI" Or ClientName = "TRISHALADEVIOLDATHANI") Then
                Dim OBJCMN As New ClsCommon
                Dim dt As DataTable = OBJCMN.search(" PATIENTMASTER.PATIENT_UHLDNO ", " ", " PATIENTMASTER ", " AND PATIENTMASTER.PATIENT_UHLDNO = '" & TXTUHLDNO.Text.Trim & "'")
                If dt.Rows.Count > 0 Then
                    MsgBox("UHLD No Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                    e.Cancel = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDPHOTOUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPHOTOUPLOAD.Click
        OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBPHOTO.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub CMDPHOTOREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPHOTOREMOVE.Click
        Try
            PBPHOTO.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDPHOTOVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPHOTOVIEW.Click
        Try
            If PBPHOTO.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBPHOTO.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1.Click
        OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBDOC1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub CMDDOC1REMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1REMOVE.Click
        Try
            PBDOC1.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1VIEW.Click
        Try
            If PBDOC1.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBDOC1.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2.Click
        OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpg;*.png"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBDOC2.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub CMDDOC2REMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2REMOVE.Click
        Try
            PBDOC2.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2VIEW.Click
        Try
            If PBDOC2.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBDOC2.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTAGE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTAGE.KeyPress, TXTMRDNO.KeyPress
        Try
            numkeypress(e, sender, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If TXTNAME.Text.Trim.Length = 0 Then
                EP.SetError(TXTNAME, "Fill Patient Name")
                BLN = False
            End If

            If (ClientName = "TRISHALADEVIOLDRABKAVI" Or ClientName = "TRISHALADEVIOLDATHANI") And TXTMRDNO.Text.Trim.Length = 0 Then
                EP.SetError(TXTNAME, "Fill MRD No")
                BLN = False
            End If

            If Not CHECKDUPLICATE() Then
                EP.SetError(TXTNAME, "Name Already Exists")
                BLN = False
            End If

            If CMBVILLAGE.Text.Trim.Length = 0 And ClientName <> "YOGESH" Then
                EP.SetError(CMBVILLAGE, "Fill Village Name")
                BLN = False
            End If

            If TXTAGE.Text.Trim.Length = 0 And ClientName <> "YOGESH" Then
                EP.SetError(TXTAGE, "Fill Age")
                BLN = False
            End If

            If Val(TXTAGE.Text.Trim) > 200 Then
                EP.SetError(TXTAGE, "Fill Proper Details")
                BLN = False
            End If

            If CMBSEX.Text.Trim = "" And ClientName <> "YOGESH" Then
                EP.SetError(CMBSEX, "Fill Sex")
                BLN = False
            End If

            Return BLN

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Function CHECKDUPLICATE() As Boolean
        Try
            Dim BLN As Boolean = True
            'If TXTNAME.Text.Trim <> "" Then
            '    Dim objclscommon As New ClsCommonMaster
            '    Dim dt As DataTable
            '    If (EDIT = False) Then
            '        dt = objclscommon.search(" PATIENT_NAME ", "", " PATIENTMASTER ", " AND PATIENT_NAME = '" & TXTNAME.Text.Trim & "'")
            '        If dt.Rows.Count > 0 Then
            '            MsgBox("Name Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
            '            BLN = False
            '        End If
            '    End If
            'End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CMDPHOTOPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPHOTOPRINT.Click
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUHLD1PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUHLD1PRINT.Click
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJPATIENT As New PatientDetails
            OBJPATIENT.MdiParent = MDIMain
            OBJPATIENT.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            CMDOK_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'If EDIT = True Then PRINTREPORT(TEMPID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TOOLDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLDELETE.Click
        Try
            Call CMDDELETE_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PatientMaster_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If ClientName = "YOGESH" Then
                LBLVILLAGE.Text = "Area"
                LBLDISTRICT.Text = "City"
                CMBVILLAGE.BackColor = Color.White
                TXTAGE.BackColor = Color.White
            End If

            If ClientName = "TRISHALADEVIOLDRABKAVI" Or ClientName = "TRISHALADEVIOLDATHANI" Then
                TXTMRDNO.ReadOnly = False
                TXTMRDNO.TabStop = True
                TXTHOF.TabStop = True
                TXTFIRSTNAME.TabStop = True
                TXTLASTNAME.TabStop = True
                CMBCATEGORY.TabStop = True
                CMBTALUKA.TabStop = True
                CMBDISTRICT.TabStop = True
                TXTUHLDNO.TabStop = True
                TXTADDRESS.TabStop = True
                TXTMRDNO.BackColor = Color.LemonChiffon
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class