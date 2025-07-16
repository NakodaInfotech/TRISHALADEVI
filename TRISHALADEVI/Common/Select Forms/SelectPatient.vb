
Imports BL

Public Class SelectPatient

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public MRDNO As String = ""

    Private Sub LedgerDetailsReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Windows.Forms.Keys.Escape Or (e.KeyCode = Keys.X And e.Alt = True) Then
                Me.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub fillgrid(ByVal WHERECLAUSE As String)
        Try
            Dim objclsCMST As New ClsCommonMaster
            Dim dt As DataTable = objclsCMST.search(" ISNULL(PATIENTMASTER.PATIENT_NAME, '') AS NAME, ISNULL(PATIENTMASTER.PATIENT_HOF, '') AS HOF, ISNULL(PATIENTMASTER.PATIENT_FIRSTNAME, '') AS FIRSTNAME,ISNULL(PATIENTMASTER.PATIENT_LASTNAME, '') AS LASTNAME,PATIENTMASTER.PATIENT_AGE AS AGE, ISNULL(PATIENTMASTER.PATIENT_SEX, '') AS SEX, ISNULL(CATEGORYMASTER.CATEGORY_NAME, '') AS CATEGORY, ISNULL(DISTRICTMASTER.DISTRICT_NAME, '') AS DISTRICT, ISNULL(PATIENTMASTER.PATIENT_MRDNO, '') AS MRDNO, ISNULL(PATIENTMASTER.PATIENT_UHLDNO, '') AS UHLDNO, ISNULL(PATIENTMASTER.PATIENT_ADDRESS, '') AS ADDRESS, ISNULL(PATIENTMASTER.PATIENT_MOBILE, '') AS MOBILE, ISNULL(OCCUPATIONMASTER.OCCUPATION_NAME, '') AS OCCUPATION, ISNULL(PATIENTMASTER.PATIENT_CHECKCONSULTATION,0)AS CHECKCONSULTATION ", "", " PATIENTMASTER LEFT OUTER JOIN VILLAGEMASTER ON PATIENTMASTER.PATIENT_VILLAGEID = VILLAGEMASTER.VILLAGE_ID LEFT OUTER JOIN CATEGORYMASTER ON PATIENTMASTER.PATIENT_CATEGORYID = CATEGORYMASTER.CATEGORY_ID LEFT OUTER JOIN TALUKAMASTER ON PATIENTMASTER.PATIENT_TALUKAID = TALUKAMASTER.TALUKA_ID LEFT OUTER JOIN DISTRICTMASTER ON PATIENTMASTER.PATIENT_DISTRICTID = DISTRICTMASTER.DISTRICT_ID LEFT OUTER JOIN OCCUPATIONMASTER ON PATIENTMASTER.PATIENT_OCCUPATIONID = OCCUPATIONMASTER.OCCUPATION_ID ", WHERECLAUSE & " AND PATIENTMASTER.PATIENT_CMPID = " & CmpId & " ORDER BY PATIENTMASTER.PATIENT_NAME")
            gridbilldetails.DataSource = dt
            If dt.Rows.Count > 0 Then gridbill.FocusedRowHandle = gridbill.RowCount - 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub

    Private Sub cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Try
            showform(False, "")
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub showform(ByVal editval As Boolean, ByVal name As String)
        Try
            If (editval = True And USEREDIT = False And USERVIEW = False) Or (editval = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (editval = False) Or (editval = True And gridbill.RowCount > 0) Then
                Dim objaccountsmaster As New PatientMaster
                objaccountsmaster.MdiParent = MDIMain
                objaccountsmaster.EDIT = editval
                objaccountsmaster.frmstring = "PATIENT"
                objaccountsmaster.TEMPNAME = name
                objaccountsmaster.Show()
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMDPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim PATH As String = "" = ""
            If FileIO.FileSystem.FileExists(PATH) = True Then FileIO.FileSystem.DeleteFile(PATH)
            PATH = Application.StartupPath & "\Patient Details.XLS"

            Dim opti As New DevExpress.XtraPrinting.XlsExportOptions
            opti.ShowGridLines = True

            Dim workbook As String = PATH
            If FileIO.FileSystem.FileExists(PATH) = True Then Interaction.GetObject(workbook).close(False)
            GC.Collect()
            'For Each proc In System.Diagnostics.Process.GetProcessesByName("Excel")
            '    proc.Kill()
            'Next

            Dim PERIOD As String = AccFrom & " - " & AccTo

            opti.SheetName = "Patient Details"
            gridbill.ExportToXls(PATH, opti)
            'EXCELCMPHEADER(PATH, "Ledger Details", gridbill.VisibleColumns.Count + gridbill.GroupCount, "", PERIOD)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdedit_Click(sender As Object, e As EventArgs) Handles cmdedit.Click
        showform(True, gridbill.GetFocusedRowCellValue("NAME"))
    End Sub

    Private Sub CMDOK_Click(sender As Object, e As EventArgs) Handles CMDOK.Click
        Try
            MRDNO = gridbill.GetFocusedRowCellValue("MRDNO")
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LedgerDetailsReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'PATIENT MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            fillgrid("")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSAVE.Click
        Try
            fillgrid("")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub gridbill_DoubleClick(sender As Object, e As EventArgs) Handles gridbill.DoubleClick
        Try
            Call CMDOK_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
