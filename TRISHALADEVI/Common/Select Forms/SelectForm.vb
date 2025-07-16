Imports BL

Public Class SelectForm
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public TEMPNAME As String
    Public FRMSTRING As String

    Private Sub CMDEXIT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SelectForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Alt = True And e.KeyCode = Windows.Forms.Keys.O Then       'for Selecting
                Call CMDOK_Click(sender, e)
            ElseIf (e.Alt = True And e.KeyCode = Windows.Forms.Keys.X) Or (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf e.KeyCode = Keys.Oemcomma Then
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub SelectForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim DTROW() As DataRow
            DTROW = USERRIGHTS.Select("")

            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            TXTFRM.Text = FRMSTRING
            pcase(TXTFRM)

            Me.Text = "Select " & TXTFRM.Text.Trim
            LBSELECT.Text = Me.Text

            FILLGRID("")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID(ByVal WHERECLAUSE As String)
        Try

            Dim OBJCMN As New ClsCommon
            Dim DT As DataTable = OBJCMN.search(" " & FRMSTRING & "_NAME , " & FRMSTRING & "_ID ", "", " " & FRMSTRING & "MASTER ", WHERECLAUSE & "  AND " & FRMSTRING & "MASTER." & FRMSTRING & "_YEARID = " & YearId & " ORDER BY " & FRMSTRING & "MASTER." & FRMSTRING & "_NAME ")
            GRID.DataSource = DT

            GRID.Columns(0).HeaderText = "Select " & TXTFRM.Text
            GRID.Columns(0).Width = 220
            GRID.Columns(1).Visible = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            If GRID.SelectedRows.Count > 0 Then
                TEMPNAME = GRID.Rows(GRID.SelectedRows(0).Index).Cells(0).Value
            Else
                TEMPNAME = ""
            End If
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRID_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GRID.CellDoubleClick
        Try
            If GRID.Rows.Count > 0 Then
                CMDOK_Click(sender, e)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDREFRESH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMDREFRESH.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If
            TXTNAME.Clear()
            FILLGRID("")
            TXTNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTNAME_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTNAME.TextChanged
        Try
            If TXTNAME.Text.Trim <> "" Then
                If RBSTART.Checked = True Then
                    FILLGRID(" AND " & FRMSTRING & "MASTER." & FRMSTRING & "_NAME like '" & TXTNAME.Text.Trim & "%'")
                ElseIf RBPART.Checked = True Then
                    FILLGRID(" AND " & FRMSTRING & "MASTER." & FRMSTRING & "_NAME like '%" & TXTNAME.Text.Trim & "%'")
                End If
            Else
                FILLGRID("")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDCATEGORY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRID.KeyDown
        Try
            If e.KeyCode = Keys.Enter And GRID.RowCount > 0 Then

                If GRID.SelectedRows.Count > 0 Then
                    TEMPNAME = GRID.Rows(GRID.SelectedRows(0).Index).Cells(0).Value
                Else
                    TEMPNAME = ""
                End If
                Me.Close()

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RBSTART_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBSTART.Click
        Try
            TXTNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub RBPART_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBPART.CheckedChanged
        Try
            TXTNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class