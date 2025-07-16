
Imports System.ComponentModel
Imports BL

Public Class OPD

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPOPDNO As Integer

    Private Sub CMDSAVE_Click(sender As Object, e As EventArgs) Handles CMDSAVE.Click
        Try

            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList
            alParaval.Add(CMBMRDNO.Text.Trim)
            alParaval.Add(Format(DTDATE.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(Format(DTENTRYDATE.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(CMBTYPE.Text.Trim)
            alParaval.Add(TXTHOSPITAL.Text.Trim)
            alParaval.Add(TXTHTALUKA.Text.Trim)
            alParaval.Add(TXTHREGNO.Text.Trim)
            alParaval.Add(TXTSURGEON.Text.Trim)
            alParaval.Add(TXTSURGEONMOBILE.Text.Trim)

            If CHKCONSULTATION.Checked = True Then
                alParaval.Add(1)
            Else
                alParaval.Add(0)
            End If
            alParaval.Add(CMBAMOUNT.Text.Trim)
            alParaval.Add(Val(TXTRECDAMT.Text))
            alParaval.Add(Val(TXTDISC.Text))
            alParaval.Add(TXTINWORDS.Text.Trim)
            alParaval.Add(Val(TXTSUBTOTAL.Text))
            alParaval.Add(Val(TXTGRANDTOTAL.Text))
            alParaval.Add(Val(TXTBALAMT.Text))

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


            Dim OBJIPD As New ClsOPD
            OBJIPD.alParaval = alParaval

            'Save PatientMaster
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJIPD.SAVE()
                TXTOPDNO.Text = DT.Rows(0).Item(0)
                MsgBox("Details Added")


                'GENERATE TOKEN ON THE APPOINTMENT DATE
                Dim OBJTOKEN As New ClsToken
                OBJTOKEN.alParaval.Add(Format(DTDATE.Value.Date, "MM/dd/yyyy"))
                OBJTOKEN.alParaval.Add(TXTOPDNO.Text.Trim)   'OPDNO
                OBJTOKEN.alParaval.Add(0)   'IPDNO
                OBJTOKEN.alParaval.Add(CMBTYPE.Text.Trim)
                OBJTOKEN.alParaval.Add(Userid)
                OBJTOKEN.alParaval.Add(YearId)
                DT = OBJTOKEN.SAVE()
                LBLTOKENNO.Text = DT.Rows(0).Item(0)
                LBLTIME.Text = DT.Rows(0).Item(1)

            Else
                'Update PatientMaster
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                alParaval.Add(TEMPOPDNO)
                IntResult = OBJIPD.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If
            PRINTREPORT()
            CLEAR()
            CMBMRDNO.Focus()
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
                'ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.P Then
                '    Call PrintToolStripButton_Click(sender, e)
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
            CMBMRDNO.Focus()
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

                ALPARAVAL.Add(TEMPOPDNO)
                ALPARAVAL.Add(YearId)

                Dim OBJACC As New ClsOPD
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

    Sub GETMAX_OPDNO()
        Dim DTTABLE As DataTable = GETMAX(" isnull(max(OPD_NO),0) + 1 ", "OPDMASTER", " AND OPD_YEARID = " & YearId)
        If DTTABLE.Rows.Count > 0 Then TXTOPDNO.Text = DTTABLE.Rows(0).Item(0)
    End Sub

    Sub GETMAX_BILLNO()
        Dim DTTABLE As DataTable = GETMAX(" isnull(max(OPD_BILLNO),0) + 1 ", "OPDMASTER", " AND OPD_YEARID = " & YearId)
        If DTTABLE.Rows.Count > 0 Then TXTBILLNO.Text = DTTABLE.Rows(0).Item(0)
    End Sub

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If LBLCANCEL.Visible = True Then
                EP.SetError(LBLCANCEL, "Unable to Save, Bill Cancelled")
                BLN = False
            End If

            If CMBMRDNO.Text.Trim.Length = 0 Then
                EP.SetError(CMBMRDNO, "Select MRD NO ")
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

            If LBLLASTDATE.Text.Trim = "" And Val(TXTRECDAMT.Text.Trim) = 0 And CHKCONSULTATION.CheckState = CheckState.Unchecked Then
                EP.SetError(TXTRECDAMT, "Amount Cannot be Kept Pending")
                BLN = False
            End If

            'IF PATIENT HAS PAID THE AMOUNT AND COMES AGAIN FOR CHECKUP WITHIN A MONTH THEN WE WONT CHARGE THE PATIENT ELSE WE NEED TO CHECK THE AMOUNT VALIDATION
            If LBLLASTDATE.Text.Trim <> "" AndAlso DateDiff(DateInterval.Day, Convert.ToDateTime(LBLLASTDATE.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date) > 30 Then

                Dim I As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(LBLLASTDATE.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date)

                If Val(TXTBALAMT.Text.Trim) > 0 And CHKCONSULTATION.CheckState = CheckState.Unchecked Then
                    EP.SetError(TXTBALAMT, "Patient Should Pay the Amount, as Last Renewal Date is over 1 month")
                    BLN = False
                End If
            End If

            If CMBTYPE.Text.Trim = "FOLLOWUP" And Val(TXTRECDAMT.Text.Trim) <> 0 Then
                EP.SetError(TXTRECDAMT, "For Followup Do Not take Amount")
                BLN = False
            End If


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
            '    EP.SetError(DTDATE, "opd not working on wednesday & saturday")
            '    MsgBox("opd not working on wednesday & saturday", MsgBoxStyle.Critical)
            '    BLN = False
            'End If


            Return BLN

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub CLEAR()
        Try
            TXTOPDNO.Clear()
            TXTBILLNO.Clear()

            CMBMRDNO.Text = ""
            CHKCONSULTATION.CheckState = CheckState.Unchecked
            TXTPATIENTNAME.Clear()
            TXTAGE.Clear()
            TXTSEX.Clear()
            TXTMOBILE.Clear()
            TXTPLACE.Clear()
            TXTOCCUPATION.Clear()
            DTDATE.Value = Mydate
            DTENTRYDATE.Value = Mydate
            EP.Clear()
            GETMAX_OPDNO()
            GETMAX_BILLNO()
            LBLTOKENNO.Text = ""
            LBLTIME.Text = ""
            LBLLASTDATE.Text = ""

            CMBTYPE.Enabled = True

            TXTSUBTOTAL.Clear()
            TXTDISC.Clear()
            TXTGRANDTOTAL.Clear()
            TXTINWORDS.Clear()
            TXTRECDAMT.Clear()
            TXTDISC.Clear()
            TXTBALAMT.Clear()
            LBLCANCEL.Visible = False


            CMBAMOUNT.Text = "250"
            GRIDCHARGES.RowCount = 0
            Dim E As New EventArgs
            CMBAMOUNT_Validated(CMBAMOUNT, E)

            TXTNEWOPDAMT.Clear()
            TXTNEWOPDCOUNT.Clear()
            TXTRENEWOPDAMT.Clear()
            TXTRENEWOPDCOUNT.Clear()
            TXTFOLLOWUPAMT.Clear()
            TXTFOLLOWUPCOUNT.Clear()

            FILLGRID()
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
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'OPD'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            FILLCMB()
            CLEAR()

            If ClientName = "RABKAVI" Then
                TXTHTALUKA.Text = "RABKAVI"
                TXTHREGNO.Text = "MMC 2000/01/0408"
            Else
                TXTHTALUKA.Text = "ATHANI"
                TXTHREGNO.Text = "MMC 2000/01/0408"

            End If

            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJIPD As New ClsOPD

                OBJIPD.alParaval.Add(TEMPOPDNO)
                OBJIPD.alParaval.Add(YearId)

                dttable = OBJIPD.GETOPD()

                If dttable.Rows.Count > 0 Then
                    TXTOPDNO.Text = TEMPOPDNO
                    TXTBILLNO.Text = Val(dttable.Rows(0).Item("BILLNO"))

                    CMBMRDNO.Text = dttable.Rows(0).Item("MRDNO")
                    Call CMBMRDNO_Validated(sender, e)
                    TXTPATIENTNAME.Text = dttable.Rows(0).Item("NAME")
                    TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                    TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString
                    TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                    TXTPLACE.Text = dttable.Rows(0).Item("PLACE").ToString
                    TXTOCCUPATION.Text = dttable.Rows(0).Item("OCCUPATION").ToString
                    DTDATE.Text = dttable.Rows(0).Item("DATE").ToString
                    DTENTRYDATE.Text = dttable.Rows(0).Item("ENTRYDATE").ToString
                    CMBTYPE.Text = dttable.Rows(0).Item("TYPE")
                    CMBTYPE.Enabled = False

                    TXTHOSPITAL.Text = dttable.Rows(0).Item("HOSPITAL").ToString
                    TXTHTALUKA.Text = dttable.Rows(0).Item("HTALUKA").ToString
                    TXTHREGNO.Text = dttable.Rows(0).Item("HREGNO").ToString
                    TXTSURGEON.Text = dttable.Rows(0).Item("SURGEON").ToString
                    TXTSURGEONMOBILE.Text = dttable.Rows(0).Item("SMOBILE").ToString
                    CMBAMOUNT.Text = dttable.Rows(0).Item("AMOUNTNAME")
                    TXTRECDAMT.Text = dttable.Rows(0).Item("RECDAMT")
                    TXTDISC.Text = dttable.Rows(0).Item("DISC")
                    TXTINWORDS.Text = dttable.Rows(0).Item("INWORDS")
                    TXTSUBTOTAL.Text = dttable.Rows(0).Item("SUBTOTAL")
                    TXTGRANDTOTAL.Text = dttable.Rows(0).Item("GRANDTOTAL")
                    TXTBALAMT.Text = dttable.Rows(0).Item("BALAMT")
                    CHKCONSULTATION.Checked = Convert.ToBoolean(dttable.Rows(0).Item("FREECONSULTATION"))

                    GRIDCHARGES.RowCount = 0


                    'FETCH TIME AND TOKEN NO FROM TOKEN MASTER
                    Dim OBJCMN As New ClsCommon
                    Dim DT As DataTable = OBJCMN.search("TOKEN_NO AS TOKENNO, TOKEN_TIME AS TOKENTIME", "", "TOKENMASTER", " AND TOKEN_OPDNO = " & Val(TXTOPDNO.Text.Trim) & " AND TOKEN_YEARID = " & YearId)
                    If DT.Rows.Count > 0 Then
                        LBLTOKENNO.Text = DT.Rows(0).Item("TOKENNO")
                        LBLTIME.Text = DT.Rows(0).Item("TOKENTIME")
                    End If
                    'CHARGES GRID
                    If dttable.Rows.Count > 0 Then
                        For Each DTMED As DataRow In dttable.Rows
                            GRIDCHARGES.Rows.Add(DTMED("SRNO"), DTMED("CHARGES"), DTMED("AMT"))
                        Next
                    End If

                    FILLGRID()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            FILLAMOUNT(CMBAMOUNT)
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
                Dim DT As DataTable = OBJCMN.search("ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME,  PATIENTMASTER.PATIENT_AGE AS AGE,  ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX,   ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS VILLAGE, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILE,ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION, ISNULL(PATIENT_CHECKCONSULTATION,0) AS CONSULTATION", "", " PATIENTMASTER LEFT OUTER JOIN VILLAGEMASTER ON VILLAGEMASTER.VILLAGE_ID = PATIENTMASTER.PATIENT_VILLAGEID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", " and PATIENTMASTER.PATIENT_MRDNO = " & Val(CMBMRDNO.Text.Trim) & "  and PATIENTMASTER.PATIENT_CMPID = " & CmpId)
                If DT.Rows.Count > 0 Then
                    TXTPATIENTNAME.Text = DT.Rows(0).Item("NAME")
                    TXTAGE.Text = DT.Rows(0).Item("AGE")
                    TXTSEX.Text = DT.Rows(0).Item("SEX")
                    TXTPLACE.Text = DT.Rows(0).Item("VILLAGE")
                    TXTMOBILE.Text = DT.Rows(0).Item("MOBILE")
                    TXTOCCUPATION.Text = DT.Rows(0).Item("OCCUPATION")
                    CHKCONSULTATION.Checked = DT.Rows(0).Item("CONSULTATION")
                End If

                'GET LAST PAID DATE
                DT = OBJCMN.search("TOP 1 OPD_DATE AS LASTDATE", "", "OPDMASTER", " AND OPD_RECDAMT > 0 AND OPD_NO < " & Val(TXTOPDNO.Text.Trim) & " AND OPD_MRDNO = " & Val(CMBMRDNO.Text.Trim) & " AND OPD_YEARID = " & YearId & " ORDER BY OPD_NO DESC")
                If DT.Rows.Count > 0 Then
                    LBLLASTDATE.Text = Format(Convert.ToDateTime(DT.Rows(0).Item("LASTDATE")).Date, "dd/MM/yyyy")
                End If

                GETTYPEAUTO()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETTYPEAUTO()
        Try
            If EDIT = True Then Exit Sub

            'GET TYPE AUTO
            'IF LASTDATE IS BLANK THEN NEW
            LBLLASTDATE.ForeColor = Color.YellowGreen
            If LBLLASTDATE.Text.Trim = "" Then
                CMBTYPE.Text = "NEW"
            Else
                'IF LAST DATE IS WITHIN A MONTH THEN FOLLOWUP
                If DateDiff(DateInterval.Day, Convert.ToDateTime(LBLLASTDATE.Text.Trim).Date, Convert.ToDateTime(DTDATE.Text).Date) <= 30 Then
                    CMBTYPE.Text = "FOLLOWUP"
                Else
                    CMBTYPE.Text = "RENEW"
                    LBLLASTDATE.ForeColor = Color.Red
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Toolprevious_Click(sender As Object, e As EventArgs) Handles Toolprevious.Click
        Try
            CMBAMOUNT.Text = ""
LINE1:
            TEMPOPDNO = Val(TXTOPDNO.Text) - 1
            If TEMPOPDNO > 0 Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBAMOUNT.Text.Trim = "" And TEMPOPDNO > 1 Then
                TXTOPDNO.Text = TEMPOPDNO
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

            Dim OBJPATIENT As New OpdDetails
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
            TEMPOPDNO = Val(TXTOPDNO.Text) + 1
            GETMAX_OPDNO()
            Dim MAXNO As Integer = TXTOPDNO.Text.Trim
            CLEAR()
            If Val(TXTOPDNO.Text) - 1 >= TEMPOPDNO Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBAMOUNT.Text.Trim = "" And TEMPOPDNO < MAXNO Then
                TXTOPDNO.Text = TEMPOPDNO
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

            If GRIDCHARGES.RowCount > 0 Then
                For Each row As DataGridViewRow In GRIDCHARGES.Rows
                    If Val(row.Cells(GAMT.Index).Value) <> 0 Then TXTSUBTOTAL.Text = Format(Val(TXTSUBTOTAL.Text) + Val(row.Cells(GAMT.Index).EditedFormattedValue), "0")
                Next
            End If
            TXTGRANDTOTAL.Text = Format(Val(TXTSUBTOTAL.Text) - Val(TXTDISC.Text), "0.00")
            TXTBALAMT.Text = Format(Val(TXTGRANDTOTAL.Text) - Val(TXTRECDAMT.Text), "0.00")
            If Val(TXTGRANDTOTAL.Text) > 0 Then TXTINWORDS.Text = CurrencyToWord(TXTGRANDTOTAL.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTDISC_Validated(sender As Object, e As EventArgs) Handles TXTDISC.Validated, TXTRECDAMT.Validated
        Try
            TOTAL()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        If EDIT = True Then PRINTREPORT()
    End Sub

    Sub PRINTREPORT()
        Try
            If MsgBox("Wish to Print Reports?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim STRSEARCH As String = "{OPDMASTER.OPD_NO} = " & Val(TXTOPDNO.Text.Trim) & " AND {OPDMASTER.OPD_YEARID} = " & YearId

            If CHKOPDDETAILS.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "OPDDETAILS"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKOPDDETAILSA5.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "OPDDETAILSA5"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKOPDRECEIPT.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "OPDRECEIPT"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKAPPTREC.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "APPTREC"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CHKALL_CheckedChanged(sender As Object, e As EventArgs) Handles CHKALL.CheckedChanged
        Try
            CHKOPDDETAILS.Checked = CHKALL.Checked
            CHKOPDDETAILSA5.Checked = CHKALL.Checked
            CHKOPDRECEIPT.Checked = CHKALL.Checked
            CHKAPPTREC.Checked = CHKALL.Checked
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTDISC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTDISC.KeyPress, TXTRECDAMT.KeyPress
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

    Private Sub DTDATE_Validated(sender As Object, e As EventArgs) Handles DTDATE.Validated
        Try
            FILLGRID()
            GETTYPEAUTO()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            Dim OBJCMN As New ClsCommon
            Dim DT As DataTable = OBJCMN.search(" TOKENMASTER.TOKEN_NO AS TOKENNO, TOKENMASTER.TOKEN_TIME AS TOKENTIME, ISNULL(OPD_TYPE,'NEW') AS TYPE, OPDMASTER.OPD_NO AS SRNO, OPDMASTER.OPD_MRDNO AS MRDNO,  PATIENTMASTER.PATIENT_NAME AS PATIENTNAME, PATIENTMASTER.PATIENT_AGE AS AGE, ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS VILLAGE, OPDMASTER.OPD_RECDAMT AS RECDAMT,  USERMASTER.USER_NAME AS USERNAME ", "", " TOKENMASTER RIGHT OUTER JOIN PATIENTMASTER INNER JOIN OPDMASTER INNER JOIN USERMASTER ON OPDMASTER.OPD_USERID = USERMASTER.USER_ID ON PATIENTMASTER.PATIENT_MRDNO = OPDMASTER.OPD_MRDNO LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID ON TOKENMASTER.TOKEN_YEARID = OPDMASTER.OPD_YEARID AND  TOKENMASTER.TOKEN_OPDNO = OPDMASTER.OPD_NO", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(DTDATE.Value.Date, "MM/dd/yyyy") & "' ORDER BY TOKEN_NO")
            gridbilldetails.DataSource = DT
            If DT.Rows.Count > 0 Then
                gridbill.FocusedRowHandle = gridbill.RowCount - 1
                gridbill.TopRowIndex = gridbill.RowCount - 15
            End If

            Dim DTNEW As DataTable = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(DTDATE.Value.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'NEW'")
            If DTNEW.Rows.Count > 0 Then
                TXTNEWOPDAMT.Text = Format(Val(DTNEW.Rows(0).Item("RECDAMT")), "0.00")
                TXTNEWOPDCOUNT.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")
            End If


            DTNEW = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(DTDATE.Value.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'RENEW'")
            If DTNEW.Rows.Count > 0 Then
                TXTRENEWOPDAMT.Text = Format(Val(DTNEW.Rows(0).Item("RECDAMT")), "0.00")
                TXTRENEWOPDCOUNT.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")
            End If

            DTNEW = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(DTDATE.Value.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'FOLLOWUP'")
            If DTNEW.Rows.Count > 0 Then
                TXTFOLLOWUPAMT.Text = Format(Val(DTNEW.Rows(0).Item("RECDAMT")), "0.00")
                TXTFOLLOWUPCOUNT.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class



