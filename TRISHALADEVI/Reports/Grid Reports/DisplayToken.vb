
Imports BL
Imports DevExpress.XtraGrid.Views.Grid

Public Class DisplayToken


    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public WHERECLAUSE As String = ""

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DisplayToken_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Windows.Forms.Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.N And e.Control = True Then
                showform(False, 0)
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub DisplayToken_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'OPD'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            fillgrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub fillgrid()
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJCMN As New ClsCommon
            Dim PENDING As String = ""
            'IN PENDING SHOW ALL THE DATA AS PER SHAKUNTALA SISTER'S REQUIREMENT
            If RBENTERED.Checked = True Then PENDING = " and TOKENDONE = 'TRUE'"
            Dim DTTABLE As DataTable = OBJCMN.search("  * ", "", " TOKENDATA ", WHERECLAUSE & PENDING & "  AND YEARID = " & YearId & " ORDER BY TOKENNO")
            gridbilldetails.DataSource = DTTABLE

            Dim DTNEW As DataTable = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'NEW'")
            If DTNEW.Rows.Count > 0 Then TXTNEW.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

            DTNEW = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'RENEW'")
            If DTNEW.Rows.Count > 0 Then TXTRENEW.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

            DTNEW = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "' AND OPD_TYPE = 'FOLLOWUP'")
            If DTNEW.Rows.Count > 0 Then TXTFOLLOWUP.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

            DTNEW = OBJCMN.search("ISNULL(SUM(OPDMASTER.OPD_RECDAMT),0) AS RECDAMT, ISNULL(COUNT(OPDMASTER.OPD_NO),0) AS NOOFOPD", "", " OPDMASTER ", " AND OPDMASTER.OPD_YEARID = " & YearId & " AND OPD_DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "'")
            If DTNEW.Rows.Count > 0 Then TXTTOTALPATIENTS.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

            DTNEW = OBJCMN.search("ISNULL(COUNT(TEMPOPDNO),0) AS NOOFOPD", "", " TOKENDATA ", " AND YEARID = " & YearId & " AND DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "' AND TOKENDONE = 'TRUE'")
            If DTNEW.Rows.Count > 0 Then TXTCHECHED.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

            DTNEW = OBJCMN.search("ISNULL(COUNT(TEMPOPDNO),0) AS NOOFOPD", "", " TOKENDATA ", " AND YEARID = " & YearId & " AND DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "' AND TOKENDONE = 'FALSE'")
            If DTNEW.Rows.Count > 0 Then TXTUNCHECKED.Text = Format(Val(DTNEW.Rows(0).Item("NOOFOPD")), "0")

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            showform(True, gridbill.GetFocusedRowCellValue("TEMPOPDNO"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub showform(ByVal editval As Boolean, ByVal TEMPOPD As Integer)
        Try
            If (editval = True And USEREDIT = False And USERVIEW = False) Or (editval = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (editval = False) Or (editval = True And gridbill.RowCount > 0) Then
                Dim objPO As New OPD
                objPO.MdiParent = MDIMain
                objPO.EDIT = editval
                objPO.TEMPOPDNO = TEMPOPD
                objPO.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If USERADD = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If
            showform(False, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDSAVE_Click(sender As Object, e As EventArgs) Handles CMDSAVE.Click
        Try
            Dim OBJCMN As New ClsCommon
            Dim DT As New DataTable

            'PENDING
            If RBPENDING.Checked = True Then
                Dim SELECTEDROWS As Int32() = gridbill.GetSelectedRows()
                For I As Integer = 0 To Val(SELECTEDROWS.Length - 1)
                    Dim DTROW As DataRow = gridbill.GetDataRow(SELECTEDROWS(I))

                    If DTROW("ENTRYTYPE") = "OPD" Then DT = OBJCMN.Execute_Any_String(" UPDATE TOKENMASTER SET TOKEN_DONE = 'TRUE' WHERE TOKEN_NO = " & DTROW("TOKENNO") & " AND TOKEN_OPDNO = " & DTROW("TEMPOPDNO") & " AND TOKEN_YEARID = " & YearId, "", "")
                    If DTROW("ENTRYTYPE") = "IPD" Then DT = OBJCMN.Execute_Any_String(" UPDATE TOKENMASTER SET TOKEN_DONE = 'TRUE' WHERE TOKEN_NO = " & DTROW("TOKENNO") & " AND TOKEN_IPDNO = " & DTROW("TEMPOPDNO") & " AND TOKEN_YEARID = " & YearId, "", "")

                Next
                MsgBox("Details Updated Successfully")
                fillgrid()
                gridbill.Focus()
            End If

            'ENTERED
            If RBENTERED.Checked = True Then
                Dim SELECTEDROWS As Int32() = gridbill.GetSelectedRows()
                For I As Integer = 0 To Val(SELECTEDROWS.Length - 1)
                    Dim DTROW As DataRow = gridbill.GetDataRow(SELECTEDROWS(I))

                    If DTROW("ENTRYTYPE") = "OPD" Then DT = OBJCMN.Execute_Any_String(" UPDATE TOKENMASTER SET TOKEN_DONE = 'FALSE' WHERE TOKEN_NO = " & DTROW("TOKENNO") & " AND TOKEN_OPDNO = " & DTROW("TEMPOPDNO") & " AND TOKEN_YEARID = " & YearId, "", "")
                    If DTROW("ENTRYTYPE") = "IPD" Then DT = OBJCMN.Execute_Any_String(" UPDATE TOKENMASTER SET TOKEN_DONE = 'FALSE' WHERE TOKEN_NO = " & DTROW("TOKENNO") & " AND TOKEN_IPDNO = " & DTROW("TEMPOPDNO") & " AND TOKEN_YEARID = " & YearId, "", "")

                Next
                MsgBox("Details Updated Successfully")
                fillgrid()
                gridbill.Focus()
            End If


            'DT = OBJCMN.Execute_Any_String("UPDATE CHALLAN SET CHALLAN.CHALLAN_SIGNRECD = 1 WHERE CHALLAN.CHALLAN_NO = " & Val(dtrow("CHALLANNO")) & "  AND CHALLAN.CHALLAN_YEARID = " & YearId, "", "")


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub gridbill_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridbill.DoubleClick
        Try
            showform(True, gridbill.GetFocusedRowCellValue("TEMPOPDNO"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Try

            Dim PATH As String = Application.StartupPath & "\OPD Details.XLS"
            Dim opti As New DevExpress.XtraPrinting.XlsExportOptions
            opti.ShowGridLines = True

            For Each proc In System.Diagnostics.Process.GetProcessesByName("Excel")
                proc.Kill()
            Next
            opti.SheetName = "OPD Details"
            gridbill.ExportToXls(PATH, opti)
            'EXCELCMPHEADER(PATH, "Purchase Order Details", gridbill.VisibleColumns.Count + gridbill.GroupCount)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDREFRESH_Click(sender As Object, e As EventArgs) Handles CMDREFRESH.Click
        Try
            fillgrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub gridbill_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gridbill.RowStyle
        Try
            If e.RowHandle >= 0 Then
                Dim View As GridView = sender
                If View.GetRowCellDisplayText(e.RowHandle, View.Columns("TOKENDONE")) = "Checked" Then
                    e.Appearance.Font = New System.Drawing.Font("CALIBRI", 9.0F, System.Drawing.FontStyle.Bold)
                    e.Appearance.BackColor = Color.Yellow
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class