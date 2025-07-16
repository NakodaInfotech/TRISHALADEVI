﻿Imports BL

Public Class SelectDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public FRMSTRING As String

    Private Sub SelectDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf (e.Control = True And e.KeyCode = Windows.Forms.Keys.N) Then
                SHOWFORM(False, "")
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            ElseIf e.KeyCode = Keys.OemQuotes Then
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SelectDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'SELECT MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            TXTFRM.Text = FRMSTRING
            pcase(TXTFRM)

            Me.Text = TXTFRM.Text.Trim & " Details"

            FILLGRID()

            If GRIDSELECT.RowCount > 0 Then GRIDSELECT.FirstDisplayedScrollingRowIndex = GRIDSELECT.RowCount - 1

        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim DTTABLE As New DataTable
            Dim objClsCommon As New ClsCommonMaster
            DTTABLE = objClsCommon.search(FRMSTRING & "_NAME , " & FRMSTRING & "_ID ", "", " " & FRMSTRING & "MASTER ")
            If DTTABLE.Rows.Count > 0 Then
                GRIDSELECT.DataSource = DTTABLE
                GRIDSELECT.Columns(0).HeaderText = "Select " & TXTFRM.Text
                GRIDSELECT.Columns(1).Visible = False
                GRIDSELECT.Columns(0).Width = 250
                GRIDSELECT.Columns(0).SortMode = Windows.Forms.DataGridViewColumnSortMode.Automatic
            End If
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

    Private Sub CMDEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDIT.Click
        Try
            SHOWFORM(True, GRIDSELECT.Item(1, GRIDSELECT.CurrentRow.Index).Value)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, ByVal ID As Integer)
        Try
            If (EDITVAL = True And USEREDIT = False And USERVIEW = False) Or (EDITVAL = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJSELECT As New SelectMaster
            OBJSELECT.EDIT = EDITVAL
            OBJSELECT.FRMSTRING = FRMSTRING
            OBJSELECT.TEMPID = ID
            OBJSELECT.MdiParent = MDIMain
            OBJSELECT.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub GRIDSELECT_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRIDSELECT.CellDoubleClick
        Try
            SHOWFORM(True, GRIDSELECT.Item(1, GRIDSELECT.CurrentRow.Index).Value.ToString)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub TXTNAME_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNAME.Validated
        Try
            Dim rowno, b As Integer
            FILLGRID()
            rowno = 0
            For b = 1 To GRIDSELECT.RowCount
                TXTTEMPNAME.Text = GRIDSELECT.Item(0, rowno).Value.ToString()
                TXTTEMPNAME.SelectionStart = 0
                TXTTEMPNAME.SelectionLength = TXTNAME.TextLength
                If LCase(TXTNAME.Text.Trim) <> LCase(TXTTEMPNAME.SelectedText.Trim) Then
                    GRIDSELECT.Rows.RemoveAt(rowno)
                Else
                    rowno = rowno + 1
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Try
            SHOWFORM(False, 0)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

End Class