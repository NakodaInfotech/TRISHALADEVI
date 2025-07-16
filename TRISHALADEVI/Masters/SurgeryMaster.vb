
Imports System.ComponentModel
Imports BL

Public Class SurgeryMaster
    Public EDIT As Boolean
    Public TEMPNAME As String
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Dim TEMPID As Integer
    Dim GRIDMEDICINESDOUBLECLICK As Boolean
    Dim GRIDCHECKLISTDOUBLECLICK As Boolean
    Dim TEMPMEDROW As Integer
    Dim TEMPCHKROW As Integer

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
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

    Private Sub SurgeryMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Alt = True And e.KeyCode = Windows.Forms.Keys.S Then       'for Saving
                Call CMDOK_Click(sender, e)
            ElseIf (e.Alt = True And e.KeyCode = Windows.Forms.Keys.X) Or (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.F1 Then
                Call OpenToolStripButton_Click(sender, e)
            ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.D Then       'for Delete
                Call CMDDELETE_Click(sender, e)
            ElseIf e.Alt = True And e.KeyCode = Keys.Right Then
                toolnext_Click(sender, e)
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            FILLMEDICINES(CMBMEDICINE)
            FILLOPERATIVEPROC(CMBOPERATIVEPROC)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SurgeryMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'SURGERY MASTER'")
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
                Dim OBJSUR As New ClsSurgeryMaster

                OBJSUR.alParaval.Add(TEMPNAME)
                dttable = OBJSUR.GETSURGERY()

                If dttable.Rows.Count > 0 Then
                    TXTNAME.Text = TEMPNAME
                    TEMPID = Val(dttable.Rows(0).Item("SURGERYID"))
                    TXTNAME.Text = dttable.Rows(0).Item("NAME").ToString
                    CMBEYE.Text = dttable.Rows(0).Item("EYE").ToString
                    CMBCHARGES.Text = dttable.Rows(0).Item("CHARGES").ToString
                    CMBOPERATIVEPROC.Text = dttable.Rows(0).Item("OPPROCEDURE").ToString
                    TXTCHEIF.Text = dttable.Rows(0).Item("CHEIF").ToString
                    TXTPREORDERS.Text = dttable.Rows(0).Item("PREORDERS").ToString
                    TXTPOSTORDERS.Text = dttable.Rows(0).Item("POSTORDERS").ToString
                    TXTPOSTINSTERCUTION.Text = dttable.Rows(0).Item("INSTRUCTION").ToString
                    CMBANATHESIA.Text = dttable.Rows(0).Item("ANATHESIA").ToString
                    TXTPROCEDURE.Text = dttable.Rows(0).Item("SURPROCEDURE").ToString
                    TXTRATE.Text = dttable.Rows(0).Item("RATE").ToString
                    'MEDICINES GRID
                    Dim OBJCMN As New ClsCommon
                    Dim DT As DataTable = OBJCMN.search(" SURGERY_SRNO AS MEDSRNO, ISNULL(MEDICINEMASTER.MEDICINE_NAME,'') AS MEDICINE ", " ", " SURGERYMASTER_MEDICINE INNER JOIN  MEDICINEMASTER ON SURGERYMASTER_MEDICINE.SURGERY_MEDICINEID = MEDICINEMASTER.MEDICINE_ID ", " AND SURGERY_ID = '" & TEMPID & "' ORDER BY SURGERY_SRNO")
                    If DT.Rows.Count > 0 Then
                        For Each DTMED As DataRow In DT.Rows
                            GRIDMEDICINES.Rows.Add(DTMED("MEDSRNO"), DTMED("MEDICINE"))
                        Next
                        GRIDMEDICINES.FirstDisplayedScrollingRowIndex = GRIDMEDICINES.RowCount - 1
                    End If


                    'CHECKLIST GRID
                    'DT = OBJCMN.search(" SURGERY_CHKSRNO AS CHKSRNO, SURGERY_CHKLIST AS CHKLIST, SURGERY_CHK AS CHK ", " ", " SURGERYMASTER_CHKLIST ", " AND SURGERY_ID = '" & TEMPID & "' ORDER BY SURGERY_CHKSRNO")
                    'If DT.Rows.Count > 0 Then
                    '    For Each DTCHK As DataRow In DT.Rows
                    '        GRIDCHECKLIST.Rows.Add(DTCHK("CHKSRNO"), DTCHK("CHKLIST"), DTCHK("CHK"))
                    '    Next
                    'End If

                Else
                    EDIT = False
                    CLEAR()

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
            alParaval.Add(CMBEYE.Text.Trim)
            alParaval.Add(CMBCHARGES.Text.Trim)
            alParaval.Add(CMBOPERATIVEPROC.Text.Trim)
            alParaval.Add(TXTCHEIF.Text.Trim)
            alParaval.Add(TXTPREORDERS.Text.Trim)
            alParaval.Add(TXTPOSTORDERS.Text.Trim)
            alParaval.Add(TXTPOSTINSTERCUTION.Text.Trim)
            alParaval.Add(CMBANATHESIA.Text.Trim)
            alParaval.Add(TXTPROCEDURE.Text.Trim)

            'Save Medicines Grid
            Dim MEDSRNO As String = ""
            Dim MEDICINE As String = ""
            For Each row As Windows.Forms.DataGridViewRow In GRIDMEDICINES.Rows
                If row.Cells(GMEDSRNO.Index).Value <> Nothing Then
                    If MEDSRNO = "" Then
                        MEDSRNO = row.Cells(GMEDSRNO.Index).Value.ToString
                        MEDICINE = row.Cells(GMEDICINE.Index).Value.ToString
                    Else
                        MEDSRNO = MEDSRNO & "|" & row.Cells(GMEDSRNO.Index).Value.ToString
                        MEDICINE = MEDICINE & "|" & row.Cells(GMEDICINE.Index).Value.ToString
                    End If
                End If
            Next

            alParaval.Add(MEDSRNO)
            alParaval.Add(MEDICINE)

            'Save Checklist Grid
            'Dim CHKSRNO As String = ""
            'Dim CHKLIST As String = ""
            'Dim CHK As String = ""
            'For Each row As Windows.Forms.DataGridViewRow In GRIDCHECKLIST.Rows
            '    If row.Cells(GCHKSRNO.Index).Value <> Nothing Then
            '        If CHKSRNO = "" Then
            '            CHKSRNO = row.Cells(GMEDSRNO.Index).Value.ToString
            '            CHKLIST = row.Cells(GCHKLIST.Index).Value.ToString
            '            CHK = row.Cells(GCHK.Index).Value.ToString
            '        Else
            '            CHKSRNO = CHKSRNO & "|" & row.Cells(GMEDSRNO.Index).Value.ToString
            '            CHKLIST = CHKLIST & "|" & row.Cells(GCHKLIST.Index).Value.ToString
            '            CHK = CHK & "|" & row.Cells(GCHK.Index).Value.ToString
            '        End If
            '    End If
            'Next

            'alParaval.Add(CHKSRNO)
            'alParaval.Add(CHKLIST)
            'alParaval.Add(CHK)

            alParaval.Add(CmpId)
            alParaval.Add(Userid)
            alParaval.Add(TXTRATE.Text.Trim)



            Dim OBJSURGERYMASTER As New ClsSurgeryMaster
            OBJSURGERYMASTER.alParaval = alParaval

            If EDIT = False Then
                'Save SurgeryMaster
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                IntResult = OBJSURGERYMASTER.SAVE()
                'TEMPID = DT.Rows(0).Item(0)
                MsgBox("Details Added")
            Else
                'Update SurgeryMaster
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                alParaval.Add(TEMPID)
                IntResult = OBJSURGERYMASTER.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If

            CLEAR()
            TXTNAME.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CLEAR()
        Try
            EP.Clear()
            TXTNAME.Clear()

            CMBEYE.SelectedIndex = 0
            CMBCHARGES.SelectedIndex = 0
            CMBOPERATIVEPROC.Text = ""
            TXTPREORDERS.Clear()
            TXTPOSTORDERS.Clear()
            TXTPOSTINSTERCUTION.Clear()
            TXTCHEIF.Clear()
            TXTPROCEDURE.Clear()
            TXTMEDSRNO.Text = 1
            CMBMEDICINE.Text = ""
            TXTRATE.Clear()

            'TXTCHKSRNO.Clear()
            'TXTCHKLIST.Clear()
            'CMBCHK.SelectedItem = Nothing

            'GRIDCHECKLIST.RowCount = 0
            GRIDMEDICINES.RowCount = 0

            GRIDMEDICINESDOUBLECLICK = False
            GRIDCHECKLISTDOUBLECLICK = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            GRIDMEDICINES.Enabled = True
            If GRIDMEDICINESDOUBLECLICK = False Then
                GRIDMEDICINES.Rows.Add(Val(TXTMEDSRNO.Text.Trim), CMBMEDICINE.Text.Trim)
                GETSRNO(GRIDMEDICINES)
            ElseIf GRIDMEDICINESDOUBLECLICK = True Then
                GRIDMEDICINES.Item(GMEDSRNO.Index, TEMPMEDROW).Value = TXTMEDSRNO.Text.Trim
                GRIDMEDICINES.Item(GMEDICINE.Index, TEMPMEDROW).Value = CMBMEDICINE.Text.Trim

                GRIDMEDICINESDOUBLECLICK = False

            End If

            GRIDMEDICINES.FirstDisplayedScrollingRowIndex = GRIDMEDICINES.RowCount - 1
            CMBMEDICINE.Text = ""
            CMBMEDICINE.Focus()
            TXTMEDSRNO.Clear()
            TXTMEDSRNO.Text = GRIDMEDICINES.RowCount + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Sub FILLCHECKLIST()
    '    Try
    '        If GRIDCHECKLISTDOUBLECLICK = False Then
    '            GRIDCHECKLIST.Rows.Add(Val(TXTCHKSRNO.Text.Trim), TXTCHKLIST.Text.Trim, CMBCHK.Text.Trim)
    '            GETSRNO(GRIDCHECKLIST)
    '        ElseIf GRIDCHECKLISTDOUBLECLICK = True Then
    '            GRIDCHECKLIST.Item(GCHKSRNO.Index, TEMPCHKROW).Value = TXTCHKSRNO.Text.Trim
    '            GRIDCHECKLIST.Item(GCHKLIST.Index, TEMPCHKROW).Value = TXTCHKLIST.Text.Trim
    '            GRIDCHECKLIST.Item(GCHK.Index, TEMPCHKROW).Value = CMBCHK.Text.Trim

    '            GRIDCHECKLISTDOUBLECLICK = False

    '        End If

    '        GRIDCHECKLIST.FirstDisplayedScrollingRowIndex = GRIDCHECKLIST.RowCount - 1

    '        TXTCHKSRNO.Clear()
    '        TXTCHKLIST.Clear()
    '        CMBCHK.SelectedItem = Nothing
    '        TXTCHKLIST.Focus()

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Function ERRORVALID()
        Try
            Dim BLN As Boolean = True

            If TXTNAME.Text.Trim.Length = 0 Then
                EP.SetError(TXTNAME, "Fill Surgery Name")
                BLN = False
            End If

            If Not CHECKDUPLICATE() Then
                EP.SetError(TXTNAME, "Name Already Exists")
                BLN = False
            End If

            'If GRIDMEDICINES.RowCount = 0 Then
            '    EP.SetError(CMBMEDICINE, " Please Enter Data in grid")
            '    BLN = False
            'End If

            'If TXTRATE.Text.Trim.Length = 0 Then
            '    EP.SetError(TXTRATE, "Fill Surgery Rate")
            '    BLN = False
            'End If

            If TXTPROCEDURE.Text.Trim.Length = 0 Then
                EP.SetError(TXTPROCEDURE, "Fill Surgery Procedure")
                BLN = False
            End If


            Return BLN

        Catch ex As Exception
            Throw ex
        End Try
    End Function

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
                ALPARAVAL.Add(Userid)

                Dim OBJSURGERY As New ClsSurgeryMaster
                OBJSURGERY.alParaval = ALPARAVAL
                Dim DT As DataTable = OBJSURGERY.DELETE
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

    Private Sub TXTNAME_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTNAME.Validating
        Try
            If Not CHECKDUPLICATE() Then e.Cancel = True
            uppercase(TXTNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTMEDSRNO_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMEDSRNO.Enter
        If GRIDMEDICINESDOUBLECLICK = False Then
            If GRIDMEDICINES.RowCount > 0 Then
                TXTMEDSRNO.Text = Val(GRIDMEDICINES.Rows(GRIDMEDICINES.RowCount - 1).Cells(GMEDSRNO.Index).Value) + 1
            Else
                TXTMEDSRNO.Text = 1
            End If
        End If
    End Sub

    Sub EDITROW()
        Try
            If GRIDMEDICINES.CurrentRow.Index >= 0 And GRIDMEDICINES.Item(GMEDSRNO.Index, GRIDMEDICINES.CurrentRow.Index).Value <> Nothing Then
                GRIDMEDICINESDOUBLECLICK = True
                TEMPMEDROW = GRIDMEDICINES.CurrentRow.Index
                TXTMEDSRNO.Text = GRIDMEDICINES.Item(GMEDSRNO.Index, GRIDMEDICINES.CurrentRow.Index).Value.ToString
                CMBMEDICINE.Text = GRIDMEDICINES.Item(GMEDICINE.Index, GRIDMEDICINES.CurrentRow.Index).Value.ToString

                CMBMEDICINE.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub GRIDMEDICINES_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRIDMEDICINES.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        EDITROW()
    End Sub

    Private Sub GRIDMEDICINES_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRIDMEDICINES.KeyDown
        Try
            If e.KeyCode = Keys.Delete And GRIDMEDICINES.RowCount > 0 Then
                'dont allow user if any of the grid line is in edit mode.....
                If GRIDMEDICINESDOUBLECLICK = True Then
                    MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
                    Exit Sub
                End If
                'end of block

                GRIDMEDICINES.Rows.RemoveAt(GRIDMEDICINES.CurrentRow.Index)
                GETSRNO(GRIDMEDICINES)
            ElseIf e.KeyCode = Keys.F5 Then
                EDITROW()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub GRIDCHECKLIST_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Try
    '        If e.RowIndex = -1 Then Exit Sub
    '        If e.RowIndex >= 0 And GRIDCHECKLIST.Item(GMEDSRNO.Index, e.RowIndex).Value <> Nothing Then

    '            GRIDCHECKLISTDOUBLECLICK = True
    '            TXTCHKSRNO.Text = GRIDCHECKLIST.Item(GCHKSRNO.Index, e.RowIndex).Value
    '            TXTCHKLIST.Text = GRIDCHECKLIST.Item(GCHKLIST.Index, e.RowIndex).Value
    '            CMBCHK.Text = GRIDCHECKLIST.Item(GCHK.Index, e.RowIndex).Value
    '            TEMPCHKROW = e.RowIndex
    '            TXTCHKLIST.Focus()
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub GRIDCHECKLIST_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    Try
    '        If e.KeyCode = Keys.Delete And GRIDCHECKLIST.RowCount > 0 Then
    '            'dont allow user if any of the grid line is in edit mode.....
    '            If GRIDCHECKLISTDOUBLECLICK = True Then
    '                MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
    '                Exit Sub
    '            End If
    '            'end of block

    '            GRIDCHECKLIST.Rows.RemoveAt(GRIDCHECKLIST.CurrentRow.Index)
    '            GETSRNO(GRIDCHECKLIST)
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub



    'Private Sub CMBCHK_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    Try
    '        If TXTCHKLIST.Text <> "" Then FILLCHECKLIST()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Private Sub TXTRATE_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Try
    '        numkeypress(e, TXTRATE, Me)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Function CHECKDUPLICATE() As Boolean
        Try
            Dim BLN As Boolean = True
            If TXTNAME.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommon
                Dim dt As DataTable
                If (EDIT = False) Then
                    dt = objclscommon.search(" SURGERY_NAME ", "", " SURGERYMASTER ", " AND SURGERY_NAME = '" & TXTNAME.Text.Trim & "' AND SURGERY_CMPID = " & CmpId)
                    If dt.Rows.Count > 0 Then
                        MsgBox("Name Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                        BLN = False
                    End If
                End If
            End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Private Sub TXTCHKLIST_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    Try
    '        If TXTCHKLIST.Text = "" Then CMDOK.Focus()
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub CMDCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
            TXTNAME.Focus()
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

            Dim OBJSURGERY As New SurgeryDetails
            OBJSURGERY.MdiParent = MDIMain
            OBJSURGERY.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            CMDOK_Click(sender, e)
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

    Private Sub Toolnext_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CMBMEDICINE_Enter(sender As Object, e As EventArgs) Handles CMBMEDICINE.Enter
        Try
            If CMBMEDICINE.Text.Trim = "" Then FILLMEDICINES(CMBMEDICINE)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBMEDICINE_Validating(sender As Object, e As CancelEventArgs) Handles CMBMEDICINE.Validating
        Try
            If CMBMEDICINE.Text.Trim <> "" Then MEDICINEVALIDATE(CMBMEDICINE, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMBMEDICINE_Validated(sender As Object, e As EventArgs) Handles CMBMEDICINE.Validated
        If CMBMEDICINE.Text.Trim <> "" Then
            'MsgBox("Select Process....")
            FILLGRID()
            'Else
            '    If CMBMEDICINE.Text.Trim = "" Then
            '        MsgBox("Enter MEDICINE Name....", MsgBoxStyle.Critical)
            '        'CMBPROCESS.Focus()
            'End If
        End If
    End Sub

    Private Sub CMBOPERATIVEPROC_Enter(sender As Object, e As EventArgs) Handles CMBOPERATIVEPROC.Enter
        Try
            If CMBOPERATIVEPROC.Text.Trim = "" Then FILLOPERATIVEPROC(CMBOPERATIVEPROC)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBOPERATIVEPROC_Validating(sender As Object, e As CancelEventArgs) Handles CMBOPERATIVEPROC.Validating
        Try
            If CMBOPERATIVEPROC.Text.Trim <> "" Then OPPROCVALIDATE(CMBOPERATIVEPROC, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class