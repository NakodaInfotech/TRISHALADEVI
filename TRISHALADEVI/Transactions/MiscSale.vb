
Imports System.ComponentModel
Imports BL

Public Class MiscSale

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPSALENO As Integer

    Private Async Sub CMDSAVE_Click(sender As Object, e As EventArgs) Handles CMDSAVE.Click
        Try

            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList
            alParaval.Add(CMBMRDNO.Text.Trim)
            alParaval.Add(Format(DTDATE.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(CMBAMOUNT.Text.Trim)
            alParaval.Add(Val(TXTRECDAMT.Text))
            alParaval.Add(Val(TXTDISC.Text))
            alParaval.Add(TXTINWORDS.Text.Trim)
            alParaval.Add(TXTREMARKS.Text.Trim)
            alParaval.Add(Val(TXTSUBTOTAL.Text))
            alParaval.Add(Val(TXTGRANDTOTAL.Text))
            alParaval.Add(Val(TXTBALAMT.Text))
            alParaval.Add(TXTPATIENTNAME.Text.Trim)
            alParaval.Add(TXTMOBILE.Text)
            alParaval.Add(TXTPLACE.Text.Trim)
            alParaval.Add(TXTOCCUPATION.Text.Trim)
            alParaval.Add(Val(TXTAGE.Text))
            alParaval.Add(TXTSEX.Text.Trim)
            alParaval.Add(CMBDOCTOR.Text.Trim)
            alParaval.Add(Val(TXTCOMMPER.Text.Trim))
            alParaval.Add(Val(TXTCOMMAMT.Text.Trim))

            Dim SRNO As String = ""
            Dim CHARGE As String = ""
            Dim AMT As String = ""

            For Each row As Windows.Forms.DataGridViewRow In GRIDCHARGES.Rows
                If row.Cells(GSRNO.Index).Value <> Nothing Then
                    If SRNO = "" Then
                        SRNO = row.Cells(GSRNO.Index).Value
                        CHARGE = row.Cells(GCHARGE.Index).Value.ToString
                        AMT = Val(row.Cells(GAMT.Index).Value)
                    Else
                        SRNO = SRNO & "|" & row.Cells(GSRNO.Index).Value
                        CHARGE = CHARGE & "|" & row.Cells(GCHARGE.Index).Value.ToString
                        AMT = AMT & "|" & Val(row.Cells(GAMT.Index).Value)
                    End If
                End If
            Next

            alParaval.Add(SRNO)
            alParaval.Add(CHARGE)
            alParaval.Add(AMT)
            alParaval.Add(CmpId)
            alParaval.Add(Userid)
            alParaval.Add(YearId)


            Dim OBJIPD As New ClsMiscSale
            OBJIPD.alParaval = alParaval

            'Save PatientMaster
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJIPD.SAVE()
                TXTBILLNO.Text = DT.Rows(0).Item(0)
                MsgBox("Details Added")

                'SEND WHASAPP TO DOCTOR THAT PATIENT IS CHECKED BY DR. YOGESH
                If ClientName = "YOGESH" And CMBDOCTOR.Text.Trim <> "" Then
                    'GET WHATSAPP NO OF DOCTOR
                    Dim OBJCMN As New ClsCommon
                    Dim DTDOC As DataTable = OBJCMN.search("ISNULL(DOCTOR_MOBILENO,'') AS MOBILENO", "", " DOCTORMASTER ", " AND DOCTOR_NAME = '" & CMBDOCTOR.Text.Trim & "' AND DOCTOR_CMPID = " & CmpId)
                    Dim RESPONSE As String = Await SENDWHATSAPPMESSAGE("91" & DTDOC.Rows(0).Item("MOBILENO"), "Hi, Your Patient - *" & TXTPATIENTNAME.Text.Trim & "* has been Checked by *Dr. Yogesh Jain*")
                End If

            Else
                'Update PatientMaster
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                alParaval.Add(TEMPSALENO)
                IntResult = OBJIPD.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If
            'PRINTREPORT()
            CLEAR()
            If ClientName = "YOGESH" Then TXTPATIENTNAME.Focus() Else CMBMRDNO.Focus()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub EXIT_Click(sender As Object, e As EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPD_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.F1 Then
                Call OpenToolStripButton_Click(sender, e)
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            ElseIf e.Alt = True And e.KeyCode = Keys.Left Then
                Toolprevious_Click(sender, e)
            ElseIf e.Alt = True And e.KeyCode = Keys.Right Then
                toolnext_Click(sender, e)
            ElseIf e.KeyCode = Keys.Delete And GRIDCHARGES.RowCount > 0 Then
                GRIDCHARGES.Rows.RemoveAt(GRIDCHARGES.CurrentRow.Index)
                GETSRNO(GRIDCHARGES)
                TOTAL()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETSRNO(ByRef grid As System.Windows.Forms.DataGridView)
        Try
            For Each row As DataGridViewRow In grid.Rows
                row.Cells(0).Value = row.Index + 1
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLER_Click(sender As Object, e As EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
            If ClientName = "YOGESH" Then TXTPATIENTNAME.Focus() Else CMBMRDNO.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDELETE_Click(sender As Object, e As EventArgs) Handles CMDDELETE.Click
        Try
            If EDIT = True Then

                If USERDELETE = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim TEMPMSG As Integer = MsgBox("Wish to Delete?", MsgBoxStyle.YesNo)
                If TEMPMSG = vbNo Then Exit Sub


                Dim ALPARAVAL As New ArrayList

                ALPARAVAL.Add(TEMPSALENO)
                ALPARAVAL.Add(YearId)

                Dim OBJACC As New ClsMiscSale
                OBJACC.alParaval = ALPARAVAL
                Dim DT As DataTable = OBJACC.DELETE
                If DT.Rows.Count > 0 Then
                    MsgBox(DT.Rows(0).Item(0))
                    EDIT = False
                    CLEAR()
                    CMBMRDNO.Focus()
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Sub GETMAX_OPDNO()
    '    Dim DTTABLE As DataTable = GETMAX(" isnull(max(OPD_NO),0) + 1 ", "OPDMASTER", " AND OPD_YEARID = " & YearId)
    'If DTTABLE.Rows.Count > 0 Then TXTBILLNO.Text = DTTABLE.Rows(0).Item(0)
    'End Sub

    Sub GETMAX_BILLNO()
        Dim DTTABLE As DataTable = GETMAX(" isnull(max(MISC_NO),0) + 1 ", "MISCSALE", " AND MISC_YEARID = " & YearId)
        If DTTABLE.Rows.Count > 0 Then TXTBILLNO.Text = DTTABLE.Rows(0).Item(0)
    End Sub

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If CMBMRDNO.Text.Trim.Length = 0 And ClientName <> "YOGESH" Then
                EP.SetError(CMBMRDNO, "Select MRD NO ")
                BLN = False
            End If

            If TXTPATIENTNAME.Text.Trim.Length = 0 And ClientName = "YOGESH" Then
                EP.SetError(TXTPATIENTNAME, " Select Patient Name ")
                BLN = False
            End If

            If Val(TXTSUBTOTAL.Text.Trim) <= 0 Then
                EP.SetError(TXTSUBTOTAL, "Fill Proper Amt Details")
                BLN = False
            End If

            If Val(TXTBALAMT.Text.Trim) < 0 Then
                EP.SetError(TXTBALAMT, "Invalid Amount")
                BLN = False
            End If

            'If Label24.Text.Trim = "" And Val(TXTRECDAMT.Text.Trim) = 0 And CHKCONSULTATION.CheckState = CheckState.Unchecked Then
            '    EP.SetError(TXTRECDAMT, "Amount Cannot be Kept Pending")
            '    BLN = False
            'End If

            'IF PATIENT HAS PAID THE AMOUNT AND COMES AGAIN FOR CHECKUP WITHIN A MONTH THEN WE WONT CHARGE THE PATIENT ELSE WE NEED TO CHECK THE AMOUNT VALIDATION
            'If Label24.Text.Trim <> "" AndAlso DateDiff(DateInterval.Day, Convert.ToDateTime(Label24.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date) > 30 Then

            '    Dim I As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(Label24.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date)

            '    If Val(TXTBALAMT.Text.Trim) > 0 And CHKCONSULTATION.CheckState = CheckState.Unchecked Then
            '        EP.SetError(TXTBALAMT, "Patient Should Pay the Amount, as Last Renewal Date is over 1 month")
            '        BLN = False
            '    End If
            'End If




            'IF SAME MRD NO IS REGISTERED ON THE SAME DAY THEN DONT SAVE
            If EDIT = False And CMBMRDNO.Text.Trim <> "" Then
                Dim OBJCMN As New ClsCommon
                Dim DT As DataTable = OBJCMN.search("OPD_NO AS OPDNO", "", "OPDMASTER", " AND OPD_MRDNO = " & Val(CMBMRDNO.Text.Trim) & " AND OPD_DATE = '" & Format(DTDATE.Value.Date, "MM/dd/yyyy") & "' AND OPD_YEARID = " & YearId)
                If DT.Rows.Count > 0 Then
                    EP.SetError(DTDATE, "MRD No already registered")
                    MsgBox("MRD No already registered", MsgBoxStyle.Critical)
                    BLN = False
                End If
            End If


            'If DTDATE.Value.Date.DayOfWeek = DayOfWeek.Wednesday Or DTDATE.Value.Date.DayOfWeek = DayOfWeek.Saturday Then
            '    EP.SetError(DTDATE, "OPD Not Working on Wednesday & Saturday")
            '    MsgBox("OPD Not Working on Wednesday & Saturday", MsgBoxStyle.Critical)
            '    BLN = False
            'End If


            Return BLN

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub CLEAR()
        Try

            CMBMRDNO.Text = ""
            TXTPATIENTNAME.Clear()
            TXTAGE.Clear()
            TXTSEX.Clear()
            TXTMOBILE.Clear()
            TXTPLACE.Clear()
            TXTOCCUPATION.Clear()
            DTDATE.Value = Mydate
            EP.Clear()
            GETMAX_BILLNO()

            GRIDCHARGES.RowCount = 0
            TXTSUBTOTAL.Clear()
            TXTDISC.Clear()
            TXTGRANDTOTAL.Clear()
            TXTINWORDS.Clear()
            TXTRECDAMT.Clear()
            TXTDISC.Clear()
            TXTBALAMT.Clear()
            TXTREMARKS.Clear()
            TXTPATIENTNAME.Clear()
            TXTMOBILE.Clear()
            TXTPLACE.Clear()
            TXTAGE.Clear()
            TXTSEX.Clear()
            TXTOCCUPATION.Clear()
            CMBDOCTOR.Text = ""
            If ClientName = "YOGESH" Then TXTCOMMPER.Text = 40 Else TXTCOMMPER.Clear()
            TXTCOMMAMT.Clear()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Call CMDSAVE_Click(sender, e)
    End Sub

    Private Sub TOOLDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLDELETE.Click
        Call CMDDELETE_Click(sender, e)
    End Sub

    Private Sub IPD_LOAD(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'MISCSALE'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            FILLCMB()
            CLEAR()

            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJMISC As New ClsMiscSale

                OBJMISC.alParaval.Add(TEMPSALENO)
                OBJMISC.alParaval.Add(YearId)

                dttable = OBJMISC.GETMISC()

                If dttable.Rows.Count > 0 Then
                    TXTBILLNO.Text = TEMPSALENO
                    TXTBILLNO.ReadOnly = True
                    If dttable.Rows(0).Item("MRDNO") <> 0 Then CMBMRDNO.Text = dttable.Rows(0).Item("MRDNO")
                    If CMBMRDNO.Text.Trim <> "" Then
                        Call CMBMRDNO_Validated(sender, e)
                        TXTPATIENTNAME.Text = dttable.Rows(0).Item("NAME")
                        TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                        TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString
                        TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                        TXTPLACE.Text = dttable.Rows(0).Item("PLACE").ToString
                        TXTOCCUPATION.Text = dttable.Rows(0).Item("OCCUPATION").ToString
                    Else
                        TXTPATIENTNAME.Text = dttable.Rows(0).Item("MISCPATIENTNAME")
                        TXTAGE.Text = dttable.Rows(0).Item("MISCAGE").ToString
                        TXTSEX.Text = dttable.Rows(0).Item("MISCSEX").ToString
                        TXTMOBILE.Text = dttable.Rows(0).Item("MISCMOBILENO").ToString
                        TXTPLACE.Text = dttable.Rows(0).Item("MISCPLACE").ToString
                        TXTOCCUPATION.Text = dttable.Rows(0).Item("MISCOCCUPATION").ToString
                    End If


                    DTDATE.Text = dttable.Rows(0).Item("DATE").ToString



                    CMBAMOUNT.Text = dttable.Rows(0).Item("AMOUNTNAME")
                    TXTRECDAMT.Text = dttable.Rows(0).Item("RECDAMT")
                    TXTDISC.Text = dttable.Rows(0).Item("DISC")
                    TXTINWORDS.Text = dttable.Rows(0).Item("INWORDS")
                    TXTREMARKS.Text = dttable.Rows(0).Item("REMARKS")
                    TXTSUBTOTAL.Text = dttable.Rows(0).Item("SUBTOTAL")
                    TXTGRANDTOTAL.Text = dttable.Rows(0).Item("GRANDTOTAL")
                    TXTBALAMT.Text = dttable.Rows(0).Item("BALAMT")

                    CMBDOCTOR.Text = dttable.Rows(0).Item("DOCTOR")
                    TXTCOMMPER.Text = Val(dttable.Rows(0).Item("COMMPER"))
                    TXTCOMMAMT.Text = Val(dttable.Rows(0).Item("COMM"))

                    GRIDCHARGES.RowCount = 0




                    'CHARGES GRID
                    If dttable.Rows.Count > 0 Then
                        For Each DTMED As DataRow In dttable.Rows
                            GRIDCHARGES.Rows.Add(DTMED("SRNO"), DTMED("CHARGES"), DTMED("AMT"))
                        Next
                    End If


                End If
            Else
                EDIT = False
                clear()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            FILLAMOUNT(CMBAMOUNT)
            FILLDOCTOR(CMBDOCTOR)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBMRDNO_Enter(sender As Object, e As EventArgs) Handles CMBMRDNO.Enter
        Try
            If CMBMRDNO.Text.Trim = "" Then FILLMRDNO(CMBMRDNO)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBMRDNO_Validated(sender As Object, e As EventArgs) Handles CMBMRDNO.Validated
        Try
            If CMBMRDNO.Text.Trim <> "" Then
                Dim OBJCMN As New ClsCommon
                Dim DT As DataTable = OBJCMN.search("ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME,  PATIENTMASTER.PATIENT_AGE AS AGE,  ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX,   ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS VILLAGE, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILE,ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION ", "", " PATIENTMASTER LEFT OUTER JOIN VILLAGEMASTER ON VILLAGEMASTER.VILLAGE_ID = PATIENTMASTER.PATIENT_VILLAGEID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", " and PATIENTMASTER.PATIENT_MRDNO = " & Val(CMBMRDNO.Text.Trim) & "  and PATIENTMASTER.PATIENT_CMPID = " & CmpId)
                If DT.Rows.Count > 0 Then
                    TXTPATIENTNAME.Text = DT.Rows(0).Item("NAME")
                    TXTAGE.Text = DT.Rows(0).Item("AGE")
                    TXTSEX.Text = DT.Rows(0).Item("SEX")
                    TXTPLACE.Text = DT.Rows(0).Item("VILLAGE")
                    TXTMOBILE.Text = DT.Rows(0).Item("MOBILE")
                    TXTOCCUPATION.Text = DT.Rows(0).Item("OCCUPATION")
                    'CHKCONSULTATION.Checked = DT.Rows(0).Item("CONSULTATION")
                End If

                'GET LAST PAID DATE
                DT = OBJCMN.search("TOP 1 MISC_DATE AS DATE", "", "MISCSALE", " AND MISC_RECDAMT > 0 AND MISC_NO < " & Val(TXTBILLNO.Text.Trim) & " AND MISC_MRDNO = " & Val(CMBMRDNO.Text.Trim) & " AND MISC_YEARID = " & YearId & " ORDER BY MISC_NO DESC")
                If DT.Rows.Count > 0 Then
                    Label24.Text = Format(Convert.ToDateTime(DT.Rows(0).Item("DATE")).Date, "dd/MM/yyyy")
                End If

                '    GETTYPEAUTO()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Sub GETTYPEAUTO()
    '    Try
    '        If EDIT = True Then Exit Sub

    '    'GET TYPE AUTO
    '    'IF LASTDATE IS BLANK THEN NEW
    '    Label24.ForeColor = Color.YellowGreen
    '    If Label24.Text.Trim = "" Then
    '        'CMBTYPE.Text = "NEW"
    '    Else
    '        'IF LAST DATE IS WITHIN A MONTH THEN FOLLOWUP
    '        If DateDiff(DateInterval.Day, Convert.ToDateTime(Label24.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date) <= 30 Then
    '            'CMBTYPE.Text = "FOLLOWUP"
    '        Else
    '            'CMBTYPE.Text = "RENEW"
    '            Label24.ForeColor = Color.Red
    '        End If
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub Toolprevious_Click(sender As Object, e As EventArgs) Handles Toolprevious.Click
        Try
            CMBAMOUNT.Text = ""
LINE1:
            TEMPSALENO = Val(TXTBILLNO.Text) - 1
            If TEMPSALENO > 0 Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBAMOUNT.Text.Trim = "" And TEMPSALENO > 1 Then
                TXTBILLNO.Text = TEMPSALENO
                GoTo LINE1
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJPATIENT As New MiscSaleDetails
            OBJPATIENT.MdiParent = MDIMain
            OBJPATIENT.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub toolnext_Click(sender As Object, e As EventArgs) Handles toolnext.Click
        Try
            CMBAMOUNT.Text = ""
LINE1:
            TEMPSALENO = Val(TXTBILLNO.Text) + 1
            GETMAX_BILLNO()
            Dim MAXNO As Integer = TXTBILLNO.Text.Trim
            CLEAR()
            If Val(TXTBILLNO.Text) - 1 >= TEMPSALENO Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBAMOUNT.Text.Trim = "" And TEMPSALENO < MAXNO Then
                TXTBILLNO.Text = TEMPSALENO
                GoTo LINE1
            End If
        Catch ex As Exception
                If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
            End Try
        End Sub

        Private Sub CMDSEARCH_Click(sender As Object, e As EventArgs) Handles CMDSEARCH.Click
            Try
                Dim OBJPAT As New SelectPatient
                OBJPAT.ShowDialog()
                CMBMRDNO.Text = OBJPAT.MRDNO
                CMBMRDNO_Validated(sender, e)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub CMBAMOUNT_Enter(sender As Object, e As EventArgs) Handles CMBAMOUNT.Enter
            Try
                If CMBAMOUNT.Text.Trim = "" Then FILLAMOUNT(CMBAMOUNT)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub CMBAMOUNT_Validating(sender As Object, e As CancelEventArgs) Handles CMBAMOUNT.Validating
            Try
                If CMBAMOUNT.Text.Trim <> "" Then AMOUNTVALIDATE(CMBAMOUNT, e, Me)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Sub CMBAMOUNT_Validated(sender As Object, e As EventArgs) Handles CMBAMOUNT.Validated
            Try
                If CMBAMOUNT.Text.Trim <> "" And GRIDCHARGES.Rows.Count = 0 Then
                    Dim OBJCMN As New ClsCommonMaster
                    Dim DT As DataTable = OBJCMN.search("AMOUNT_SRNO AS SRNO, CHARGE_NAME AS CHARGES,AMOUNT_TOTALAMOUNT AS AMT,AMOUNT_LBLTOTALBALES AS LBLTOTALBALES", "", " AMOUNTMASTER INNER JOIN AMOUNTMASTER_DESC ON  AMOUNTMASTER_DESC.AMOUNT_ID = AMOUNTMASTER.AMOUNT_ID INNER JOIN CHARGEMASTER ON AMOUNTMASTER_DESC.AMOUNT_CHARGEID = CHARGEMASTER.CHARGE_ID  ", " AND AMOUNT_NAME = '" & CMBAMOUNT.Text.Trim & "' AND AMOUNTMASTER.AMOUNT_CMPID = " & CmpId)
                    If DT.Rows.Count > 0 Then
                        For Each DTROW As DataRow In DT.Rows
                            GRIDCHARGES.Rows.Add(DTROW("SRNO").ToString, DTROW("CHARGES"), Val(DTROW("AMT")))
                        Next
                    End If
                End If
                TOTAL()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

    Sub TOTAL()
        Try
            TXTSUBTOTAL.Text = 0
            TXTGRANDTOTAL.Text = 0
            If Val(TXTCOMMPER.Text.Trim) <> 0 Then TXTCOMMAMT.Clear()

            If GRIDCHARGES.RowCount > 0 Then
                For Each row As DataGridViewRow In GRIDCHARGES.Rows
                    If Val(row.Cells(GAMT.Index).Value) <> 0 Then TXTSUBTOTAL.Text = Format(Val(TXTSUBTOTAL.Text) + Val(row.Cells(GAMT.Index).EditedFormattedValue), "0")
                Next
            End If
            TXTGRANDTOTAL.Text = Format(Val(TXTSUBTOTAL.Text) - Val(TXTDISC.Text), "0.00")
            TXTBALAMT.Text = Format(Val(TXTGRANDTOTAL.Text) - Val(TXTRECDAMT.Text), "0.00")
            If Val(TXTGRANDTOTAL.Text) > 0 Then TXTINWORDS.Text = CurrencyToWord(TXTGRANDTOTAL.Text)
            TXTCOMMAMT.Text = Format(Val(TXTCOMMPER.Text.Trim) * Val(TXTGRANDTOTAL.Text.Trim) / 100, "0.00")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTDISC_Validated(sender As Object, e As EventArgs) Handles TXTDISC.Validated, TXTRECDAMT.Validated, TXTCOMMPER.Validated, TXTCOMMAMT.Validated
        Try
            TOTAL()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTDISC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDISC.KeyPress, TXTRECDAMT.KeyPress, TXTCOMMPER.KeyPress, TXTCOMMAMT.KeyPress
        numdotkeypress(e, sender, Me)
    End Sub

    Private Sub CMBMRDNO_Validating(sender As Object, e As CancelEventArgs) Handles CMBMRDNO.Validating
        Try
            If CMBMRDNO.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable = objclscommon.search(" PATIENT_NAME AS NAME ", "", " PATIENTMASTER ", " AND PATIENT_MRDNO = " & Val(CMBMRDNO.Text.Trim) & " AND PATIENT_CMPID = " & CmpId)
                If dt.Rows.Count <= 0 Then
                    MsgBox("MRD No not present", MsgBoxStyle.Critical, "TRISHALADEVI")
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDCHARGES_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles GRIDCHARGES.CellValidating
        Try
            Dim colNum As Integer = GRIDCHARGES.Columns(e.ColumnIndex).Index
            If String.IsNullOrEmpty(e.FormattedValue.ToString) Then Return

            Select Case colNum
                Case GAMT.Index
                    Dim dDebit As Decimal
                    Dim bValid As Boolean = Decimal.TryParse(e.FormattedValue.ToString, dDebit)
                    If bValid Then
                        If GRIDCHARGES.CurrentCell.Value = Nothing Then GRIDCHARGES.CurrentCell.Value = "0.00"
                        GRIDCHARGES.CurrentCell.Value = Convert.ToDecimal(GRIDCHARGES.Item(colNum, e.RowIndex).Value)
                        TOTAL()
                    Else
                        MessageBox.Show("Invalid Number Entered")
                        e.Cancel = True
                        Exit Sub
                    End If

            End Select
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub MiscSale_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If ClientName = "YOGESH" Then
                TXTPATIENTNAME.ReadOnly = False
                TXTPATIENTNAME.BackColor = Color.White
                TXTPATIENTNAME.TabStop = True
                TXTMOBILE.ReadOnly = False
                TXTMOBILE.BackColor = Color.White
                TXTMOBILE.TabStop = True
                TXTPLACE.ReadOnly = False
                TXTPLACE.BackColor = Color.White
                TXTPLACE.TabStop = True
                TXTOCCUPATION.ReadOnly = False
                TXTOCCUPATION.BackColor = Color.White
                TXTOCCUPATION.TabStop = True
                TXTAGE.ReadOnly = False
                TXTAGE.BackColor = Color.White
                TXTAGE.TabStop = True
                TXTSEX.ReadOnly = False
                TXTSEX.BackColor = Color.White
                TXTSEX.TabStop = True
                CMBDOCTOR.TabStop = True
                TXTCOMMPER.ReadOnly = False
                TXTCOMMPER.TabStop = True
                TXTCOMMAMT.ReadOnly = False
                TXTCOMMAMT.TabStop = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBDOCTOR_Enter(sender As Object, e As EventArgs) Handles CMBDOCTOR.Enter
        Try
            If CMBDOCTOR.Text.Trim = "" Then FILLDOCTOR(CMBDOCTOR)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBDOCTOR_Validating(sender As Object, e As CancelEventArgs) Handles CMBDOCTOR.Validating
        Try
            If CMBDOCTOR.Text.Trim <> "" Then DOCTORVALIDATE(CMBDOCTOR, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class






