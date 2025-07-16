Imports BL
Imports DevExpress.XtraGrid.Views.Base

Public Class DoctorDetails

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Dim TEMPNAME As String

    Private Sub CMDEXIT_Click(sender As Object, e As EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub

    Private Sub DoctorDetails_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.Alt = True And e.KeyCode = Windows.Forms.Keys.E Then       'for Saving
                Call CMDEDIT_Click(sender, e)
            ElseIf (e.Alt = True And e.KeyCode = Windows.Forms.Keys.X) Or (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf (e.Control = True And e.KeyCode = Windows.Forms.Keys.N) Or (e.Alt = True And e.KeyCode = Windows.Forms.Keys.A) Then       'for AddNew 
                Call CMDADD_Click(sender, e)
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DoctorDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
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
            FILLGRID()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRID()
        Try
            Dim OBJDC As New ClsDoctorMaster
            OBJDC.alParaval.Add(0)
            OBJDC.alParaval.Add(CmpId)
            Dim DT As DataTable = OBJDC.GETDOCTOR()
            GRIDNAME.DataSource = DT
            If DT.Rows.Count > 0 Then
                GRIDDOCTOR.FocusedRowHandle = GRIDDOCTOR.RowCount - 1
                GRIDDOCTOR.TopRowIndex = GRIDDOCTOR.RowCount - 15
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDEDIT_Click(sender As Object, e As EventArgs) Handles CMDEDIT.Click
        Try
            SHOWFORM(True, GRIDDOCTOR.GetFocusedRowCellValue("DOCTORID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, ByVal ID As String)
        Try
            If (EDITVAL = True And USEREDIT = False And USERVIEW = False) Or (EDITVAL = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (EDITVAL = False) Or (EDITVAL = True And GRIDDOCTOR.RowCount > 0) Then
                Dim OBJDOCTORMASTER As New DoctorMaster
                OBJDOCTORMASTER.MdiParent = MDIMain
                OBJDOCTORMASTER.EDIT = EDITVAL
                OBJDOCTORMASTER.TEMPID = ID
                OBJDOCTORMASTER.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PBEXCEL_Click(sender As Object, e As EventArgs) Handles PBEXCEL.Click
        Try
            Dim PATH As String = Application.StartupPath & "\Doctor Details.XLS"
            Dim opti As New DevExpress.XtraPrinting.XlsExportOptions
            opti.ShowGridLines = True
            opti.SheetName = "Doctor Details"
            GRIDDOCTOR.ExportToXls(PATH, opti)
            EXCELCMPHEADER(PATH, "Doctor Details", GRIDDOCTOR.VisibleColumns.Count + GRIDDOCTOR.GroupCount)
        Catch ex As Exception
            MsgBox("Doctor Details Excel File is Open, Please Close the File first then try to Export", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CMDADD_Click(sender As Object, e As EventArgs) Handles CMDADD.Click
        Try
            SHOWFORM(False, 0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDREFRESH_Click(sender As Object, e As EventArgs) Handles CMDREFRESH.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If
            FILLGRID()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDDOCTOR_DoubleClick(sender As Object, e As EventArgs) Handles GRIDDOCTOR.DoubleClick
        Try
            SHOWFORM(True, GRIDDOCTOR.GetFocusedRowCellValue("DOCTORID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class