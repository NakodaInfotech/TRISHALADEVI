
Imports BL

Public Class OpdDetails

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
            Dim DTTABLE As DataTable = OBJCMN.search("  OPDMASTER.OPD_NO AS TEMPOPDNO, ISNULL(OPDMASTER.OPD_BILLNO, 1) AS BILLNO, ISNULL(PATIENTMASTER.PATIENT_MRDNO, '') AS MRDNO, ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME, ISNULL(PATIENTMASTER.PATIENT_AGE, 0) AS AGE, ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX, ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS PLACE, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '')  AS MOBILE, ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION, ISNULL(OPDMASTER.OPD_ENTRYDATE, '') AS ENTRYDATE, ISNULL(OPDMASTER.OPD_DATE, '') AS DATE, ISNULL(OPDMASTER.OPD_TYPE, 'NEW') AS TYPE, OPDMASTER.OPD_HOSPITAL AS HOSPITAL, OPDMASTER.OPD_HTALUKA AS HTALUKA, OPDMASTER.OPD_RECDAMT AS RECDAMT, OPDMASTER.OPD_BALAMT AS BALAMT, OPDMASTER.OPD_INWORDS AS INWORDS, OPDMASTER.OPD_HREGNO AS HREGNO, OPDMASTER.OPD_SURGEON AS SURGEON, OPDMASTER.OPD_SMOBILE AS SMOBILE, OPDMASTER.OPD_DISC AS DISC, OPDMASTER.OPD_SUBTOTAL AS SUBTOTAL, OPDMASTER.OPD_GRANDTOTAL AS GRANDTOTAL, OPDMASTER.OPD_BALAMT AS BALAMT, OPDMASTER.OPD_YEARID, ISNULL(OPDMASTER.OPD_CHECKCONSULTATION, 0) AS FREECONSULTATION, ISNULL(TOKENMASTER.TOKEN_NO, 0) AS TOKENNO, ISNULL(TOKENMASTER.TOKEN_TIME, '') AS TOKENTIME ", "", " OPDMASTER INNER JOIN PATIENTMASTER ON OPDMASTER.OPD_MRDNO = PATIENTMASTER.PATIENT_MRDNO LEFT OUTER JOIN TOKENMASTER ON OPDMASTER.OPD_NO = TOKENMASTER.TOKEN_OPDNO AND OPDMASTER.OPD_YEARID = TOKENMASTER.TOKEN_YEARID LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", WHERECLAUSE & " AND OPDMASTER.OPD_YEARID = " & YearId & " ORDER BY TOKENMASTER.TOKEN_NO")
            gridbilldetails.DataSource = DTTABLE

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
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

End Class

