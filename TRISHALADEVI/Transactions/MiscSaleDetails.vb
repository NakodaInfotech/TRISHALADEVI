Imports BL
Public Class MiscSaleDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPDDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub OPDDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'MISCSALE'")
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

            'Dim OBJCMN As New ClsCommon
            'Dim DTTABLE As DataTable = OBJCMN.search(" ISNULL(MISCSALE.MISC_NO, 0) AS TEMPSALENO, ISNULL(PATIENTMASTER.PATIENT_MRDNO, '') AS MRDNO, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(PATIENTMASTER.PATIENT_NAME, '') ELSE ISNULL(MISCSALE.MISC_PATIENTNAME, '') END AS NAME, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(PATIENTMASTER.PATIENT_AGE, 0) ELSE ISNULL(MISCSALE.MISC_AGE, 0) END AS AGE, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(PATIENTMASTER.PATIENT_SEX, '') ELSE ISNULL(MISCSALE.MISC_SEX, '') END AS SEX, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') ELSE ISNULL(MISCSALE.MISC_PLACE, '') END AS PLACE, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') ELSE ISNULL(MISCSALE.MISC_MOBILENO, '') END AS MOBILE, CASE WHEN ISNULL(MISCSALE.MISC_MRDNO, 0) <> 0 THEN ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') ELSE ISNULL(MISCSALE.MISC_OCCUPATION, '') END AS OCCUPATION, ISNULL(MISCSALE.MISC_DATE, '') AS DATE, MISCSALE.MISC_RECDAMT AS RECDAMT, MISCSALE.MISC_BALAMT AS BALAMT, MISCSALE.MISC_INWORDS AS INWORDS, MISCSALE.MISC_REMARKS AS REMARKS, ISNULL(AMOUNTMASTER.AMOUNT_NAME, '') AS AMOUNTNAME, MISCSALE.MISC_DISC AS DISC, MISCSALE.MISC_SUBTOTAL AS SUBTOTAL, MISCSALE.MISC_GRANDTOTAL AS GRANDTOTAL ", "", " MISCSALE LEFT OUTER JOIN PATIENTMASTER ON MISCSALE.MISC_MRDNO = PATIENTMASTER.PATIENT_MRDNO LEFT OUTER JOIN AMOUNTMASTER ON MISCSALE.MISC_AMOUNTID = AMOUNTMASTER.AMOUNT_ID LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", " AND MISCSALE.MISC_YEARID = " & YearId & " ORDER BY MISCSALE.MISC_NO")
            Dim OBJMISC As New ClsMiscSale
            OBJMISC.alParaval.Add(0)
            OBJMISC.alParaval.Add(YearId)
            Dim DTTABLE As DataTable = OBJMISC.GETMISC()
            gridbilldetails.DataSource = DTTABLE
            If DTTABLE.Rows.Count > 0 Then
                gridbill.FocusedRowHandle = gridbill.RowCount - 1
                gridbill.TopRowIndex = gridbill.RowCount - 15
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Try
            showform(True, gridbill.GetFocusedRowCellValue("TEMPSALENO"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub showform(ByVal editval As Boolean, ByVal TEMPSALE As Integer)
        Try
            If (editval = True And USEREDIT = False And USERVIEW = False) Or (editval = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (editval = False) Or (editval = True And gridbill.RowCount > 0) Then
                Dim objPO As New MiscSale
                objPO.MdiParent = MDIMain
                objPO.EDIT = editval
                objPO.TEMPSALENO = TEMPSALE
                objPO.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
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

    Private Sub gridbill_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridbill.DoubleClick
        Try
            showform(True, gridbill.GetFocusedRowCellValue("TEMPSALENO"))
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

End Class


