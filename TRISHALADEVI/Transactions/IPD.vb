
Imports System.ComponentModel
Imports BL

Public Class IPD

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPIPDNO As Integer

    Private Sub CMDSAVE_Click(sender As Object, e As EventArgs) Handles CMDSAVE.Click
        Try

            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList
            alParaval.Add(CMBMRDNO.Text.Trim)
            alParaval.Add(Format(DTADMISSION.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(Format(DTDISCHARGE.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(Format(DTAPPOINTMENT.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(TXTHOSPITAL.Text.Trim)
            alParaval.Add(TXTHTALUKA.Text.Trim)
            alParaval.Add(TXTHREGNO.Text.Trim)
            alParaval.Add(TXTSURGEON.Text.Trim)
            alParaval.Add(TXTSURGEONMOBILE.Text.Trim)
            alParaval.Add(CMBSURGERYNAME.Text.Trim)
            alParaval.Add(TXTMEDICALHISTORY.Text.Trim)
            alParaval.Add(TXTRBS.Text.Trim)
            alParaval.Add(CMBHIV.Text.Trim)
            alParaval.Add(CMBHBsAg.Text.Trim)
            alParaval.Add(CMBASCAN.Text.Trim)
            alParaval.Add(CMBBSCAN.Text.Trim)
            alParaval.Add(TXTPERSONALHISTORY.Text.Trim)
            alParaval.Add(CMBALLERGY.Text.Trim)
            alParaval.Add(TXTANY.Text.Trim)
            alParaval.Add(TXTPULSE.Text.Trim)
            alParaval.Add(TXTTEMPRATURE.Text.Trim)
            alParaval.Add(TXTBP.Text.Trim)
            alParaval.Add(CMBAPPREHENSIVE.Text.Trim)
            alParaval.Add(CMBUNCOOPERATIVE.Text.Trim)
            alParaval.Add(CMBCALM.Text.Trim)
            alParaval.Add(TXTSIGNOUTISSUE.Text.Trim)
            alParaval.Add(TXTORALMEDICINE.Text.Trim)
            alParaval.Add(TXTANAESTHESIOLOGIST.Text.Trim)
            alParaval.Add(CMBAMOUNT.Text.Trim)
            alParaval.Add(Val(TXTRECDAMT.Text))
            alParaval.Add(Val(TXTDISC.Text))
            alParaval.Add(TXTINWORDS.Text.Trim)
            alParaval.Add(Val(TXTSUBTOTAL.Text))
            alParaval.Add(Val(TXTGRANDTOTAL.Text))
            alParaval.Add(Val(TXTBALAMT.Text))

            'Save CHARGES Grid
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


            Dim OBJIPD As New ClsIPD
            OBJIPD.alParaval = alParaval

            'Save PatientMaster
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJIPD.SAVE()
                TXTIPNO.Text = DT.Rows(0).Item(0)
                MsgBox("Details Added")


                'GENERATE TOKEN ON THE APPOINTMENT DATE
                Dim OBJTOKEN As New ClsToken
                OBJTOKEN.alParaval.Add(Format(DTAPPOINTMENT.Value.Date, "MM/dd/yyyy"))
                OBJTOKEN.alParaval.Add(0)   'OPDNO
                OBJTOKEN.alParaval.Add(TXTIPNO.Text.Trim)   'IPDNO
                OBJTOKEN.alParaval.Add("FOLLOWUP")   'TYPE
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
                alParaval.Add(TEMPIPDNO)
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
            ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.P Then
                Call PrintToolStripButton_Click(sender, e)
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

                ALPARAVAL.Add(TEMPIPDNO)
                ALPARAVAL.Add(YearId)

                Dim OBJACC As New ClsIPD
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

    Sub GETMAX_IPNO()
        Dim DTTABLE As DataTable = GETMAX(" isnull(max(IPD_NO),0) + 1 ", "IPDMASTER", " AND IPD_YEARID = " & YearId)
        If DTTABLE.Rows.Count > 0 Then TXTIPNO.Text = DTTABLE.Rows(0).Item(0)
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

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If CMBMRDNO.Text.Trim.Length = 0 Then
                EP.SetError(CMBMRDNO, "Select MRD NO ")
                BLN = False
            End If

            If CMBSURGERYNAME.Text.Trim.Length = 0 Then
                EP.SetError(CMBSURGERYNAME, "Select Surgery Name")
                BLN = False
            End If

            If DTDISCHARGE.Value.Date < DTADMISSION.Value.Date Then
                EP.SetError(DTDISCHARGE, "Discharge Date cannot be before Admission Date")
                BLN = False
            End If

            If DTAPPOINTMENT.Value.Date <= DTDISCHARGE.Value.Date Then
                EP.SetError(DTDISCHARGE, "Appointment Date cannot be before or same as Discharge Date")
                BLN = False
            End If

            If GRIDCHARGES.RowCount = 0 Then
                EP.SetError(CMBAMOUNT, "Fill Amt Details")
                BLN = False
            End If

            If Val(TXTSUBTOTAL.Text.Trim) <= 0 Then
                EP.SetError(TXTSUBTOTAL, "Fill Proper Amt Details")
                BLN = False
            End If

            If Val(TXTBALAMT.Text.Trim) < 0 Then
                EP.SetError(TXTBALAMT, "Amt Cannot be Less than 0")
                BLN = False
            End If

            'If DTAPPOINTMENT.Value.Date.DayOfWeek = DayOfWeek.Wednesday Or DTAPPOINTMENT.Value.Date.DayOfWeek = DayOfWeek.Saturday Then
            '    EP.SetError(DTAPPOINTMENT, "OPD Not Working on Wednesday & Saturday")
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
            DTADMISSION.Value = Mydate
            DTDISCHARGE.Value = Mydate
            DTAPPOINTMENT.Value = Mydate
            CMBSURGERYNAME.Text = ""
            TXTOPERATIONPROCEDURE.Clear()
            TXTMEDICALHISTORY.Clear()
            TXTRBS.Clear()
            TXTPERSONALHISTORY.Clear()
            TXTANY.Clear()
            TXTPULSE.Clear()
            TXTTEMPRATURE.Clear()
            TXTBP.Clear()
            TXTSIGNOUTISSUE.Clear()
            TXTORALMEDICINE.Clear()
            TXTANAESTHESIOLOGIST.Clear()
            EP.Clear()
            GETMAX_IPNO()
            LBLTOKENNO.Text = ""
            LBLTIME.Text = ""
            CMBAMOUNT.Text = ""
            GRIDCHARGES.RowCount = 0
            TXTSUBTOTAL.Clear()
            TXTDISC.Clear()
            TXTGRANDTOTAL.Clear()
            TXTINWORDS.Clear()
            TXTRECDAMT.Clear()
            TXTBALAMT.Clear()
            CMBHIV.Text = ""
            CMBHBsAg.Text = ""
            CMBASCAN.Text = ""
            CMBBSCAN.Text = ""
            CMBALLERGY.Text = ""
            CMBAPPREHENSIVE.Text = ""
            CMBUNCOOPERATIVE.Text = ""
            CMBCALM.Text = ""
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Call CMDSAVE_Click(sender, e)
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        If EDIT = True Then PRINTREPORT()
    End Sub

    Sub PRINTREPORT()
        Try
            If MsgBox("Wish to Print Reports?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim STRSEARCH As String = "{IPDMASTER.IPD_NO} = " & Val(TXTIPNO.Text.Trim) & " AND {IPDMASTER.IPD_YEARID} = " & YearId

            If CHKADMISSION.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "ADMISSION"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKGENCON.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "GENERALCONCENT"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKDOCASS.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "DOCASSREPORT"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKDOCORDER.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "DOCORDER"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKSURCONCENT.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "SURGERYCONCENT"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKREEVALUATION.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "REEVALUATION"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKOPNOTES.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "OPNOTES"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKPOSTOPCHART.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "POSTOPCHART"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKDISCHARGESUMM.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "DISCHARGESUMM"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKANAESTHESIA.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "ANAESTHESIA"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKANAESTHESIARECORD.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "ANAESTHESIARECORD"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKPREANAEVA.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "PREANAESTHESIAEVA"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKPOSTSCORE.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "POSTSCORE"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKANAESTHESIAOPNOTES.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "ANAESTHESIAOPNOTES"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKAPPTREC.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "IPDAPPTREC"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

            If CHKIPDRECEIPT.CheckState = CheckState.Checked Then
                Dim OBJIPD As New IPDDesign
                OBJIPD.FRMSTRING = "IPDRECEIPT"
                OBJIPD.STRSEARCH = STRSEARCH
                OBJIPD.MdiParent = MDIMain
                OBJIPD.Show()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TOOLDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLDELETE.Click
        Call CMDDELETE_Click(sender, e)
    End Sub

    Private Sub IPD_LOAD(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'IPD'")
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
                Dim OBJIPD As New ClsIPD

                OBJIPD.alParaval.Add(TEMPIPDNO)
                OBJIPD.alParaval.Add(YearId)

                dttable = OBJIPD.GETIPD()

                If dttable.Rows.Count > 0 Then
                    TXTIPNO.Text = TEMPIPDNO
                    CMBMRDNO.Text = dttable.Rows(0).Item("MRDNO")
                    TXTPATIENTNAME.Text = dttable.Rows(0).Item("NAME")
                    TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                    TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString
                    TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                    TXTPLACE.Text = dttable.Rows(0).Item("PLACE").ToString
                    TXTOCCUPATION.Text = dttable.Rows(0).Item("OCCUPATION").ToString
                    DTADMISSION.Text = dttable.Rows(0).Item("DTADMISSION").ToString
                    DTDISCHARGE.Text = dttable.Rows(0).Item("DTDISCHARGE").ToString
                    DTAPPOINTMENT.Text = dttable.Rows(0).Item("DTAPPOINTMENT").ToString

                    TXTHOSPITAL.Text = dttable.Rows(0).Item("HOSPITAL").ToString
                    TXTHTALUKA.Text = dttable.Rows(0).Item("HTALUKA").ToString
                    TXTHREGNO.Text = dttable.Rows(0).Item("HREGNO").ToString
                    TXTSURGEON.Text = dttable.Rows(0).Item("SURGEON").ToString
                    TXTSURGEONMOBILE.Text = dttable.Rows(0).Item("SMOBILE").ToString

                    CMBSURGERYNAME.Text = dttable.Rows(0).Item("SURGERY").ToString
                    TXTOPERATIONPROCEDURE.Text = dttable.Rows(0).Item("OPERATIONPROCEDURE").ToString

                    TXTMEDICALHISTORY.Text = dttable.Rows(0).Item("HISTORY").ToString
                    TXTRBS.Text = dttable.Rows(0).Item("RBS").ToString
                    CMBHIV.Text = dttable.Rows(0).Item("HIV").ToString
                    CMBHBsAg.Text = dttable.Rows(0).Item("HBSAG").ToString
                    CMBASCAN.Text = dttable.Rows(0).Item("ASCAN").ToString
                    CMBBSCAN.Text = dttable.Rows(0).Item("BSCAN").ToString
                    TXTPERSONALHISTORY.Text = dttable.Rows(0).Item("PERSONALHISTORY").ToString

                    CMBALLERGY.Text = dttable.Rows(0).Item("ALLERGY").ToString
                    TXTANY.Text = dttable.Rows(0).Item("ANY").ToString
                    TXTPULSE.Text = dttable.Rows(0).Item("PULSE").ToString
                    TXTTEMPRATURE.Text = dttable.Rows(0).Item("TEMPRATURE").ToString
                    TXTBP.Text = dttable.Rows(0).Item("BP").ToString

                    CMBAPPREHENSIVE.Text = dttable.Rows(0).Item("APPREHENSIVE").ToString
                    CMBUNCOOPERATIVE.Text = dttable.Rows(0).Item("UNCOOPERATIVE").ToString
                    CMBCALM.Text = dttable.Rows(0).Item("CALM").ToString

                    TXTSIGNOUTISSUE.Text = dttable.Rows(0).Item("ISSUE").ToString
                    TXTORALMEDICINE.Text = dttable.Rows(0).Item("ORALMEDICINE").ToString
                    TXTANAESTHESIOLOGIST.Text = dttable.Rows(0).Item("ANAESTHESIOLOGIST").ToString
                    CMBAMOUNT.Text = dttable.Rows(0).Item("AMOUNTNAME")
                    TXTRECDAMT.Text = dttable.Rows(0).Item("RECDAMT")
                    TXTDISC.Text = dttable.Rows(0).Item("DISC")
                    TXTINWORDS.Text = dttable.Rows(0).Item("INWORDS")
                    TXTSUBTOTAL.Text = dttable.Rows(0).Item("SUBTOTAL")
                    TXTGRANDTOTAL.Text = dttable.Rows(0).Item("GRANDTOTAL")
                    TXTBALAMT.Text = dttable.Rows(0).Item("BALAMT")

                    'FETCH TIME AND TOKEN NO FROM TOKEN MASTER
                    Dim OBJCMN As New ClsCommon
                    Dim DT As DataTable = OBJCMN.search("TOKEN_NO AS TOKENNO, TOKEN_TIME AS TOKENTIME", "", "TOKENMASTER", " AND TOKEN_IPDNO = " & Val(TXTIPNO.Text.Trim) & " AND TOKEN_YEARID = " & YearId)
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
                    TOTAL()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            FILLSURGERY(CMBSURGERYNAME)
            FILLAMOUNT(CMBAMOUNT)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERYNAME_Enter(sender As Object, e As EventArgs) Handles CMBSURGERYNAME.Enter
        Try
            If CMBSURGERYNAME.Text.Trim = "" Then FILLSURGERY(CMBSURGERYNAME)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
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
                Dim DT As DataTable = OBJCMN.search("ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME,  PATIENTMASTER.PATIENT_AGE AS AGE,  ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX,   ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS VILLAGE, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILE,ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION", "", " PATIENTMASTER LEFT OUTER JOIN VILLAGEMASTER ON VILLAGEMASTER.VILLAGE_ID = PATIENTMASTER.PATIENT_VILLAGEID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", " and PATIENTMASTER.PATIENT_MRDNO = " & Val(CMBMRDNO.Text.Trim) & "  and PATIENTMASTER.PATIENT_CMPID = " & CmpId)
                If DT.Rows.Count > 0 Then
                    TXTPATIENTNAME.Text = DT.Rows(0).Item("NAME")
                    TXTAGE.Text = DT.Rows(0).Item("AGE")
                    TXTSEX.Text = DT.Rows(0).Item("SEX")
                    TXTPLACE.Text = DT.Rows(0).Item("VILLAGE")
                    TXTMOBILE.Text = DT.Rows(0).Item("MOBILE")
                    TXTOCCUPATION.Text = DT.Rows(0).Item("OCCUPATION")
                Else
                    MsgBox("Invalid MRD No", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERYNAME_Validated(sender As Object, e As EventArgs) Handles CMBSURGERYNAME.Validated
        Try
            If CMBSURGERYNAME.Text.Trim <> "" Then
                Dim OBJCMN As New ClsCommon
                Dim DT As DataTable = OBJCMN.search("ISNULL(SURGERYMASTER.SURGERY_OPPROCEDURE, '') AS [PROCEDURE]  ", "", " SURGERYMASTER ", " and SURGERYMASTER.SURGERY_NAME = '" & CMBSURGERYNAME.Text.Trim & "'  and SURGERYMASTER.SURGERY_CMPID = " & CmpId)
                If DT.Rows.Count > 0 Then TXTOPERATIONPROCEDURE.Text = DT.Rows(0).Item("PROCEDURE")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Toolprevious_Click(sender As Object, e As EventArgs) Handles Toolprevious.Click
        Try
            CMBSURGERYNAME.Text = ""
LINE1:
            TEMPIPDNO = Val(TXTIPNO.Text) - 1
            If TEMPIPDNO > 0 Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBSURGERYNAME.Text.Trim = "" And TEMPIPDNO > 1 Then
                TXTIPNO.Text = TEMPIPDNO
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

            Dim OBJPATIENT As New IpdDetails
            OBJPATIENT.MdiParent = MDIMain
            OBJPATIENT.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERYNAME_Validating(sender As Object, e As CancelEventArgs) Handles CMBSURGERYNAME.Validating
        Try
            If CMBSURGERYNAME.Text.Trim <> "" Then SURGERYVALIDATE(CMBSURGERYNAME, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub toolnext_Click(sender As Object, e As EventArgs) Handles toolnext.Click
        Try
            CMBSURGERYNAME.Text = ""
LINE1:
            TEMPIPDNO = Val(TXTIPNO.Text) + 1
            GETMAX_IPNO()
            Dim MAXNO As Integer = TXTIPNO.Text.Trim
            CLEAR()
            If Val(TXTIPNO.Text) - 1 >= TEMPIPDNO Then
                EDIT = True
                IPD_LOAD(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If CMBSURGERYNAME.Text.Trim = "" And TEMPIPDNO < MAXNO Then
                TXTIPNO.Text = TEMPIPDNO
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
                    TOTAL()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub TOTAL()
        Try
            TXTSUBTOTAL.Text = 0
            TXTGRANDTOTAL.Text = 0
            TXTBALAMT.Text = 0

            For Each row As DataGridViewRow In GRIDCHARGES.Rows
                If Val(row.Cells(GAMT.Index).Value) <> 0 Then TXTSUBTOTAL.Text = Format(Val(TXTSUBTOTAL.Text) + Val(row.Cells(GAMT.Index).EditedFormattedValue), "0")
            Next

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

    Private Sub CHKALL_CheckedChanged(sender As Object, e As EventArgs) Handles CHKALL.CheckedChanged
        Try
            CHKADMISSION.Checked = CHKALL.Checked
            CHKGENCON.Checked = CHKALL.Checked
            CHKDOCASS.Checked = CHKALL.Checked
            CHKDOCORDER.Checked = CHKALL.Checked
            CHKSURCONCENT.Checked = CHKALL.Checked
            CHKREEVALUATION.Checked = CHKALL.Checked
            CHKOPNOTES.Checked = CHKALL.Checked
            CHKPOSTOPCHART.Checked = CHKALL.Checked
            CHKDISCHARGESUMM.Checked = CHKALL.Checked
            CHKANAESTHESIA.Checked = CHKALL.Checked
            CHKANAESTHESIARECORD.Checked = CHKALL.Checked
            CHKPREANAEVA.Checked = CHKALL.Checked
            CHKPOSTSCORE.Checked = CHKALL.Checked
            CHKANAESTHESIAOPNOTES.Checked = CHKALL.Checked
            CHKAPPTREC.Checked = CHKALL.Checked
            CHKIPDRECEIPT.Checked = CHKALL.Checked
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTRECDAMT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTRECDAMT.KeyPress, TXTDISC.KeyPress
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

End Class


