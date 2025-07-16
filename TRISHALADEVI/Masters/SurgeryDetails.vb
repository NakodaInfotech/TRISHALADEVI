Imports BL

Public Class SurgeryDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Dim TEMPID As Integer
    Public TEMPNAME As String

    Private Sub SurgeryDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub SurgeryDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            FILLGRIDNAME()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRIDNAME(Optional ByVal whereclause As String = "")
        Try
            Dim ALPARAVAL As New ArrayList
            Dim OBJSURGERY As New ClsSurgeryMaster

            ALPARAVAL.Add("")


            OBJSURGERY.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJSURGERY.GETSURGERY
            GRIDNAME.DataSource = dttable

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETDETAILS(ByRef NAME As String)
        Try
            Dim OBJSURGERY As New ClsSurgeryMaster
            Dim ALPARAVAL As New ArrayList

            If NAME = Nothing Then Exit Sub

            ALPARAVAL.Add(NAME)


            OBJSURGERY.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJSURGERY.GETSURGERY

            CLEAR()

            If dttable.Rows.Count > 0 Then
                'FILL DETAILS
                TEMPID = Val(dttable.Rows(0).Item("SURGERYID"))

                TXTNAME.Text = dttable.Rows(0).Item("NAME")

                TXTPROCEDURE.Text = dttable.Rows(0).Item("SURPROCEDURE").ToString

                'MEDICINES GRID
                Dim OBJCMN As New ClsCommon
                Dim DT As DataTable = OBJCMN.search(" SURGERY_SRNO AS MEDSRNO, ISNULL(MEDICINEMASTER.MEDICINE_NAME,'') AS MEDICINE ", " ", " SURGERYMASTER_MEDICINE INNER JOIN  MEDICINEMASTER ON SURGERYMASTER_MEDICINE.SURGERY_MEDICINEID = MEDICINEMASTER.MEDICINE_ID ", " AND SURGERY_ID = '" & TEMPID & "' ORDER BY SURGERY_SRNO")
                If DT.Rows.Count > 0 Then
                    For Each DTMED As DataRow In DT.Rows
                        GRIDMEDICINES.Rows.Add(DTMED("MEDSRNO"), DTMED("MEDICINE"))
                    Next
                End If


                'Dim OBJCMN As New ClsCommon
                'Dim DT As DataTable = OBJCMN.search(" SURGERY_SRNO AS MEDSRNO, SURGERY_MEDICINEID AS MEDICINE ", " ", " SURGERYMASTER_MEDICINE  ", " AND SURGERY_ID = '" & TEMPID & "' ORDER BY SURGERY_SRNO")
                'If DT.Rows.Count > 0 Then
                '    For Each DTMED As DataRow In DT.Rows
                '        GRIDMEDICINES.Rows.Add(DTMED("MEDSRNO"), DTMED("MEDICINE"))
                '    Next
                'End If

                'CHECKLIST GRID
                'DT = OBJCMN.search(" SURGERY_CHKSRNO AS CHKSRNO, SURGERY_CHKLIST AS CHKLIST, SURGERY_CHK AS CHK ", " ", " SURGERYMASTER_CHKLIST ", " AND SURGERY_ID = '" & TEMPID & "' ORDER BY SURGERY_CHKSRNO")
                'If DT.Rows.Count > 0 Then
                '    For Each DTCHK As DataRow In DT.Rows
                '        GRIDCHECKLIST.Rows.Add(DTCHK("CHKSRNO"), DTCHK("CHKLIST"), DTCHK("CHK"))
                '    Next
                'End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CLEAR()
        Try
            TXTNAME.Clear()

            TXTPROCEDURE.Clear()

            GRIDMEDICINES.RowCount = 0
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
            SHOWFORM(True, GRIDSURGERY.GetFocusedRowCellValue("NAME"))
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, ByVal NAME As String)
        Try
            If (EDITVAL = True And USEREDIT = False And USERVIEW = False) Or (EDITVAL = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (EDITVAL = False) Or (EDITVAL = True And GRIDSURGERY.RowCount > 0) Then
                Dim OBJSURGERYMASTER As New SurgeryMaster
                OBJSURGERYMASTER.MdiParent = MDIMain
                OBJSURGERYMASTER.EDIT = EDITVAL
                OBJSURGERYMASTER.TEMPNAME = NAME
                OBJSURGERYMASTER.Show()
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Try
            SHOWFORM(False, "")
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub GRIDSURGERY_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDSURGERY.Click
        Try
            GETDETAILS(GRIDSURGERY.GetFocusedRowCellValue("NAME"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDSURGERY_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDSURGERY.DoubleClick
        Try
            SHOWFORM(True, GRIDSURGERY.GetFocusedRowCellValue("NAME"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDSURGERY_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GRIDSURGERY.FocusedRowChanged
        Try
            GETDETAILS(GRIDSURGERY.GetFocusedRowCellValue("NAME"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDREFRESH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDREFRESH.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If
            FILLGRIDNAME()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PBEXCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBEXCEL.Click
        'Try
        '    Dim OBJACC As New LedgerDetailsReport
        '    OBJACC.MdiParent = MDIMain
        '    OBJACC.Show()
        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Sub

End Class