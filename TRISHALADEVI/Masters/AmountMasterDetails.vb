Imports BL

Public Class AmountMasterDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean

    Private Sub RackDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'SURGERY MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If
            FILLGRID()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            Dim ALPARAVAL As New ArrayList
            Dim OBJSURGERY As New ClsAmountMaster
            ALPARAVAL.Add("")
            ALPARAVAL.Add(CmpId)
            OBJSURGERY.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJSURGERY.GETAMOUNT
            GRIDBILLDETAILS.DataSource = dttable

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, ByVal NAME As String, ID As Integer)
        Try
            Dim OBJDEPT As New AmountMaster
            OBJDEPT.MdiParent = MDIMain
            OBJDEPT.EDIT = EDITVAL
            OBJDEPT.TEMPID = ID
            OBJDEPT.TEMPNAME = NAME
            OBJDEPT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDADDNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADDNEW.Click
        Try
            SHOWFORM(False, "", 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEDIT.Click
        Try
            SHOWFORM(True, GRIDBILL.GetFocusedRowCellValue("NAME"), GRIDBILL.GetFocusedRowCellValue("ID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub

    Private Sub CMDREFRESH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREFRESH.Click
        Try
            FILLGRID()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDBILL_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDBILL.DoubleClick
        Try
            SHOWFORM(True, GRIDBILL.GetFocusedRowCellValue("NAME"), GRIDBILL.GetFocusedRowCellValue("ID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        Try

            Dim PATH As String = Application.StartupPath & "\Amount Master Details.XLS"
            Dim opti As New DevExpress.XtraPrinting.XlsExportOptions
            opti.ShowGridLines = True

            For Each proc In System.Diagnostics.Process.GetProcessesByName("Excel")
                proc.Kill()
            Next
            opti.SheetName = "Amount Master Details"
            GRIDBILL.ExportToXls(PATH, opti)
            'EXCELCMPHEADER(PATH, "Item Master Details", GRIDBILL.VisibleColumns.Count + GRIDBILL.GroupCount)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ItemDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class





