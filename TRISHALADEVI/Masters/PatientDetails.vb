
Imports BL
Imports DevExpress.XtraGrid.Views.Grid

Public Class PatientDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Dim TEMPNAME As String

    Private Sub PatientDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub PatientDetails_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            FILLGRIDNAME()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLGRIDNAME(Optional ByVal whereclause As String = "")
        Try
            Dim ALPARAVAL As New ArrayList
            Dim OBJPATIENT As New ClsPatientMaster

            ALPARAVAL.Add("")
            OBJPATIENT.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJPATIENT.GETPATIENT
            GRIDNAME.DataSource = dttable

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETDETAILS(ByRef PATIENTID As Integer)
        Try
            Dim OBJPATIENT As New ClsPatientMaster
            Dim ALPARAVAL As New ArrayList

            If PATIENTID = 0 Then Exit Sub

            ALPARAVAL.Add(PATIENTID)


            OBJPATIENT.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJPATIENT.GETPATIENT

            CLEAR()

            If dttable.Rows.Count > 0 Then
                'FILL DETAILS
                'TEMPID = Val(dttable.Rows(0).Item("PATIENTID"))

                TXTNAME.Text = dttable.Rows(0).Item("NAME")
                TXTFIRSTNAME.Text = dttable.Rows(0).Item("FIRSTNAME").ToString
                TXTLASTNAME.Text = dttable.Rows(0).Item("LASTNAME").ToString
                TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString

                TXTCATEGORY.Text = dttable.Rows(0).Item("CATEGORY").ToString
                TXTVILLAGE.Text = dttable.Rows(0).Item("VILLAGE").ToString
                TXTTALUKA.Text = dttable.Rows(0).Item("TALUKA").ToString
                TXTDISTRICT.Text = dttable.Rows(0).Item("DISTRICT").ToString

                TXTADDRESS.Text = dttable.Rows(0).Item("ADDRESS").ToString
                TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                TXTOCCUPATION.Text = dttable.Rows(0).Item("OCCUPATION").ToString

                If IsDBNull(dttable.Rows(0).Item("IMGPATH")) = False Then
                    PBPHOTO.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("IMGPATH"), Byte())))
                    TXTPHOTOIMGPATH.Text = dttable.Rows(0).Item("IMGPATH").ToString
                Else
                    PBPHOTO.Image = Nothing
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CLEAR()
        Try
            TXTNAME.Clear()
            TXTFIRSTNAME.Clear()
            TXTLASTNAME.Clear()
            TXTAGE.Clear()
            TXTSEX.Clear()
            TXTCATEGORY.Clear()
            TXTVILLAGE.Clear()
            TXTTALUKA.Clear()
            TXTDISTRICT.Clear()
            TXTADDRESS.Clear()
            TXTMOBILE.Clear()
            TXTOCCUPATION.Clear()
            TXTPHOTOIMGPATH.Clear()
            PBPHOTO.Image = Nothing
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
            SHOWFORM(True, GRIDPATIENT.GetFocusedRowCellValue("PATIENTID"))
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, ByVal PATIENTID As Integer)
        Try
            If (EDITVAL = True And USEREDIT = False And USERVIEW = False) Or (EDITVAL = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (EDITVAL = False) Or (EDITVAL = True And GRIDPATIENT.RowCount > 0) Then
                Dim OBJPATIENTMASTER As New PatientMaster
                OBJPATIENTMASTER.MdiParent = MDIMain
                OBJPATIENTMASTER.EDIT = EDITVAL
                OBJPATIENTMASTER.TEMPID = PATIENTID
                OBJPATIENTMASTER.Show()
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

    Private Sub GRIDPATIENT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDPATIENT.Click
        Try
            GETDETAILS(GRIDPATIENT.GetFocusedRowCellValue("PATIENTID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDPATIENT_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDPATIENT.DoubleClick
        Try
            SHOWFORM(True, GRIDPATIENT.GetFocusedRowCellValue("PATIENTID"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDPATIENT_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GRIDPATIENT.FocusedRowChanged
        Try
            GETDETAILS(GRIDPATIENT.GetFocusedRowCellValue("PATIENTID"))
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

    Private Sub PatientDetails_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If ClientName = "YOGESH" Then
                LBLVILLAGE.Text = "Area"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class