Imports BL

Public Class IpdDetails

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

            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'IPD'")
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
            Dim DTTABLE As DataTable = OBJCMN.search(" IPDMASTER.IPD_NO AS TEMPIPDNO, ISNULL(PATIENTMASTER.PATIENT_MRDNO, '') AS MRDNO, ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME, ISNULL(PATIENTMASTER.PATIENT_AGE, 0) AS AGE, ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX, ISNULL(VILLAGEMASTER.VILLAGE_NAME, '') AS PLACE, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILE, ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION, IPDMASTER.IPD_ADMISSIONDATE AS DTADMISSION, IPDMASTER.IPD_DISCHARGEDATE AS DTDISCHARGE, IPDMASTER.IPD_NEXTAPPOINTMENT AS DTAPPOINTMENT, IPDMASTER.IPD_HOSPITAL AS HOSPITAL, IPDMASTER.IPD_HTALUKA AS HTALUKA, IPDMASTER.IPD_HREGNO AS HREGNO, IPDMASTER.IPD_SURGEON AS SURGEON, IPDMASTER.IPD_SMOBILE AS SMOBILE, SURGERYMASTER.SURGERY_NAME AS SURGERY, SURGERYMASTER.SURGERY_OPPROCEDURE AS OPERATIONPROCEDURE, ISNULL(IPDMASTER.IPD_MEDICALHISTORY, '') AS HISTORY, ISNULL(IPDMASTER.IPD_RBS, '') AS RBS, IPDMASTER.IPD_HIV AS HIV,IPDMASTER.IPD_HBSAG AS HBSAG, IPDMASTER.IPD_ASCAN AS ASCAN, IPDMASTER.IPD_BSCAN AS BSCAN, ISNULL(IPDMASTER.IPD_PERSONALHISTORY, '') AS PERSONALHISTORY, IPDMASTER.IPD_ALLERGY AS ALLERGY, ISNULL(IPDMASTER.IPD_ANY, '') AS [ANY], ISNULL(IPDMASTER.IPD_PULSE, '') AS PULSE, ISNULL(IPDMASTER.IPD_TEMPRATURE, '') AS TEMPRATURE, ISNULL(IPDMASTER.IPD_BP, '') AS BP, IPDMASTER.IPD_APPRIHENSIVE AS APPREHENSIVE, IPDMASTER.IPD_COOPERATIVE AS UNCOOPERATIVE, IPDMASTER.IPD_CALM AS CALM, ISNULL(IPDMASTER.IPD_SIGNISSUE, '') AS ISSUE, ISNULL(IPDMASTER.IPD_ORALMEDICINE, '') AS ORALMEDICINE, ISNULL(IPDMASTER.IPD_ANAESTHESIOLOGIST, '') AS ANAESTHESIOLOGIST, IPDMASTER.IPD_RECDAMT AS RECDAMT, IPDMASTER.IPD_DISC AS DISC, IPDMASTER.IPD_INWORDS AS INWORDS, IPDMASTER.IPD_SUBTOTAL AS SUBTOTAL, IPDMASTER.IPD_GRANDTOTAL AS GRANDTOTAL, IPDMASTER.IPD_BALAMT AS BALAMT, IPDMASTER.IPD_YEARID, ISNULL(TOKENMASTER.TOKEN_NO, 0) AS TOKENNO, ISNULL(TOKENMASTER.TOKEN_TIME, '') AS TOKENTIME ", "", " IPDMASTER INNER JOIN SURGERYMASTER ON IPDMASTER.IPD_SURGERYID = SURGERYMASTER.SURGERY_ID INNER JOIN PATIENTMASTER ON IPDMASTER.IPD_MRDNO = PATIENTMASTER.PATIENT_MRDNO LEFT OUTER JOIN TOKENMASTER ON IPDMASTER.IPD_NO = TOKENMASTER.TOKEN_IPDNO AND IPDMASTER.IPD_YEARID = TOKENMASTER.TOKEN_YEARID LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID", " AND IPDMASTER.IPD_YEARID = " & YearId & " ORDER BY TEMPIPDNO ")
            gridbilldetails.DataSource = DTTABLE
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Try
            showform(True, gridbill.GetFocusedRowCellValue("TEMPIPDNO"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub showform(ByVal editval As Boolean, ByVal TEMPID As Integer)
        Try
            If (editval = True And USEREDIT = False And USERVIEW = False) Or (editval = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (editval = False) Or (editval = True And gridbill.RowCount > 0) Then
                Dim objPO As New IPD
                objPO.MdiParent = MDIMain
                objPO.EDIT = editval
                objPO.TEMPIPDNO = TEMPID
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
            showform(True, gridbill.GetFocusedRowCellValue("TEMPIPDNO"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Try

            Dim PATH As String = Application.StartupPath & "\IPD Details.XLS"
            Dim opti As New DevExpress.XtraPrinting.XlsExportOptions
            opti.ShowGridLines = True

            For Each proc In System.Diagnostics.Process.GetProcessesByName("Excel")
                proc.Kill()
            Next
            opti.SheetName = "IPD Details"
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
