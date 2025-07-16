
Imports System.ComponentModel
Imports BL

Public Class AmountMaster
    Public EDIT As Boolean
    Public TEMPNAME As String
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public TEMPID As Integer
    Dim GRIDCHARGESDOUBLECLICK As Boolean
    Dim TEMPMEDROW As Integer

    Sub CLEAR()
        Try
            EP.Clear()
            TXTAMOUNT.Clear()
            LBLTOTALAMT.Text = 0.0
            TXTSRNO.Text = 1
            CMBCHARGES.Text = ""
            TXTAMT.Clear()
            GRIDCHARGES.RowCount = 0
            GRIDCHARGESDOUBLECLICK = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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

    Sub FILLCMB()
        Try
            FILLCHARGE(CMBCHARGES)
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
            ElseIf e.Alt = True And e.KeyCode = Windows.Forms.Keys.D Then       'for Delete
                Call CMDDELETE_Click(sender, e)
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
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

            CLEAR()

            TXTAMOUNT.Text = TEMPNAME

            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJSUR As New ClsAmountMaster
                OBJSUR.alParaval.Add(TEMPNAME)
                OBJSUR.alParaval.Add(CmpId)
                dttable = OBJSUR.GETAMOUNT()

                If dttable.Rows.Count > 0 Then

                    TEMPID = Val(dttable.Rows(0).Item("ID"))
                    TXTAMOUNT.Text = dttable.Rows(0).Item("NAME").ToString
                    LBLTOTALAMT.Text = dttable.Rows(0).Item("LBLTOTALBALES").ToString
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


    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList

            alParaval.Add(TXTAMOUNT.Text.Trim)
            alParaval.Add(Val(LBLTOTALAMT.Text))

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



            Dim OBJSURGERYMASTER As New ClsAmountMaster
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
            TXTAMOUNT.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            If GRIDCHARGESDOUBLECLICK = False Then
                GRIDCHARGES.Rows.Add(Val(TXTSRNO.Text.Trim), CMBCHARGES.Text.Trim, Format(Val(TXTAMT.Text.Trim), "0.00"))
                GETSRNO(GRIDCHARGES)
            ElseIf GRIDCHARGESDOUBLECLICK = True Then
                GRIDCHARGES.Item(GSRNO.Index, TEMPMEDROW).Value = TXTSRNO.Text.Trim
                GRIDCHARGES.Item(GCHARGE.Index, TEMPMEDROW).Value = CMBCHARGES.Text.Trim
                GRIDCHARGES.Item(GAMT.Index, TEMPMEDROW).Value = Format(Val(TXTAMT.Text.Trim), "0.00")

                GRIDCHARGESDOUBLECLICK = False

            End If

            GRIDCHARGES.FirstDisplayedScrollingRowIndex = GRIDCHARGES.RowCount - 1
            TXTSRNO.Text = GRIDCHARGES.RowCount + 1

            CMBCHARGES.Text = ""
            TXTAMT.Clear()
            TXTAMT.Focus()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Function ERRORVALID()
        Try
            Dim BLN As Boolean = True

            If TXTAMOUNT.Text.Trim.Length = 0 Then
                EP.SetError(TXTAMOUNT, "Fill Amount")
                BLN = False
            End If

            'If TXTAMT.Text.Trim.Length = 0 Then
            '    EP.SetError(TXTAMT, "Fill Grid Amount")
            '    BLN = False
            'End If


            If GRIDCHARGES.RowCount = 0 Then
                EP.SetError(TXTAMT, "Fill Amt Details")
                BLN = False
            End If

            Return BLN

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click

        Dim IntResult As Integer
        Try
            If EDIT = True Then
                If MsgBox("Delete Entry?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Dim alParaval As New ArrayList
                alParaval.Add(TEMPID)
                alParaval.Add(CmpId)
                Dim clspo As New ClsAmountMaster
                clspo.alParaval = alParaval
                IntResult = clspo.DELETE()
                MsgBox("AMOUNT MASTER DELETED ")
                CLEAR()
                EDIT = False
            Else
                MsgBox("Delete is only in Edit Mode")
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try

    End Sub

    Sub EDITROW()
        Try
            If GRIDCHARGES.CurrentRow.Index >= 0 And GRIDCHARGES.Item(GSRNO.Index, GRIDCHARGES.CurrentRow.Index).Value <> Nothing Then
                GRIDCHARGESDOUBLECLICK = True
                TEMPMEDROW = GRIDCHARGES.CurrentRow.Index
                TXTSRNO.Text = GRIDCHARGES.Item(GSRNO.Index, GRIDCHARGES.CurrentRow.Index).Value.ToString
                CMBCHARGES.Text = GRIDCHARGES.Item(GCHARGE.Index, GRIDCHARGES.CurrentRow.Index).Value.ToString
                TXTAMT.Text = GRIDCHARGES.Item(GAMT.Index, GRIDCHARGES.CurrentRow.Index).Value.ToString


                CMBCHARGES.Focus()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDCHARGES_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRIDCHARGES.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            EDITROW()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDCHARGES_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRIDCHARGES.KeyDown
        Try
            If e.KeyCode = Keys.Delete And GRIDCHARGES.RowCount > 0 Then
                'dont allow user if any of the grid line is in edit mode.....
                If GRIDCHARGESDOUBLECLICK = True Then
                    MessageBox.Show("Row is in Edited Mode, You Cannot Delete This Row")
                    Exit Sub
                End If
                'end of block
                GRIDCHARGES.Rows.RemoveAt(GRIDCHARGES.CurrentRow.Index)
                GETSRNO(GRIDCHARGES)
                TOTAL()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
            TXTAMOUNT.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TOOLOPEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLOPEN.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJSURGERY As New AmountMasterDetails
            OBJSURGERY.MdiParent = MDIMain
            OBJSURGERY.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub TOOLDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLDELETE.Click
        Try
            Call CMDDELETE_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCHARGES_Enter(sender As Object, e As EventArgs) Handles CMBCHARGES.Enter
        Try
            If CMBCHARGES.Text.Trim = "" Then FILLCHARGE(CMBCHARGES)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub TXTAMT_Validated(sender As Object, e As EventArgs) Handles TXTAMT.Validated
        Try
            If CMBCHARGES.Text.Trim <> "" Then
                FILLGRID()
                TOTAL()
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub TOTAL()
        Try
            LBLTOTALAMT.Text = "0.0"
            For Each row As DataGridViewRow In GRIDCHARGES.Rows
                If Val(row.Cells(GAMT.Index).Value) <> 0 Then LBLTOTALAMT.Text = Format(Val(LBLTOTALAMT.Text) + Val(row.Cells(GAMT.Index).EditedFormattedValue), "0")
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCHARGES_Validating(sender As Object, e As CancelEventArgs) Handles CMBCHARGES.Validating
        Try
            If CMBCHARGES.Text.Trim <> "" Then CHARGEVALIDATE(CMBCHARGES, e, Me)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub TXTAMT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTAMT.KeyPress
        numdotkeypress(e, sender, Me)
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
    Function CHECKDUPLICATE() As Boolean
        Try
            Dim BLN As Boolean = True
            If TXTAMOUNT.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable
                If (EDIT = False) Then
                    dt = objclscommon.search(" AMOUNT_NAME ", "", " AMOUNTMASTER ", " AND AMOUNT_NAME = '" & TXTAMOUNT.Text.Trim & "'")
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

    Private Sub TXTAMOUNT_Validating(sender As Object, e As CancelEventArgs) Handles TXTAMOUNT.Validating
        Try
            If Not CHECKDUPLICATE() Then e.Cancel = True
            uppercase(TXTAMOUNT)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class