
Imports System.ComponentModel
Imports BL

Public Class DoctorMaster

    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPID As Integer
    Public TEMPDOCTOR As String = ""

    Private Sub CMDEXIT_Click(sender As Object, e As EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub

    Private Sub CMDCLEAR_Click(sender As Object, e As EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDOK_Click(sender As Object, e As EventArgs) Handles CMDOK.Click
        Try
            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList

            alParaval.Add(TXTNAME.Text.Trim)
            alParaval.Add(TXTAGE.Text.Trim)
            alParaval.Add(CMBSEX.Text.Trim)
            alParaval.Add(CMBSPECIALIZATION.Text.Trim)
            alParaval.Add(CMBAREA.Text.Trim)
            alParaval.Add(CMBCITY.Text.Trim)
            alParaval.Add(CMBSTATE.Text.Trim)
            alParaval.Add(CMBCOUNTRY.Text.Trim)
            alParaval.Add(TXTADDRESS.Text.Trim)
            alParaval.Add(TXTMOBILE.Text.Trim)
            alParaval.Add(CmpId)
            alParaval.Add(Userid)
            alParaval.Add(YearId)

            Dim OBJDOCTORMASTER As New ClsDoctorMaster
            OBJDOCTORMASTER.alParaval = alParaval

            ''Save PatientMaster
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJDOCTORMASTER.SAVE()
                MsgBox("Details Added")

            Else
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                alParaval.Add(TEMPID)
                IntResult = OBJDOCTORMASTER.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If

            CLEAR()
            TXTNAME.Focus()


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If TXTNAME.Text.Trim.Length = 0 Then
                EP.SetError(TXTNAME, "Fill Doctor Name")
                BLN = False
            End If

            If Not CHECKDUPLICATE() Then
                EP.SetError(TXTNAME, "Name Already Exists")
                BLN = False
            End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub CLEAR()
        Try
            TXTNAME.Clear()
            TXTAGE.Clear()
            CMBSEX.SelectedItem = Nothing
            CMBSPECIALIZATION.Text = ""
            CMBAREA.Text = ""
            CMBCITY.Text = ""
            CMBSTATE.Text = ""
            CMBCOUNTRY.Text = ""
            TXTADDRESS.Clear()
            TXTMOBILE.Clear()
            EP.Clear()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function CHECKDUPLICATE() As Boolean
        Try
            Dim BLN As Boolean = True
            If TXTNAME.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable
                If (EDIT = False) Then
                    dt = objclscommon.search(" DOCTOR_NAME ", "", " DOCTORMASTER ", " AND DOCTOR_NAME = '" & TXTNAME.Text.Trim & "'")
                    If dt.Rows.Count > 0 Then
                        MsgBox("Name Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                        BLN = False
                    End If
                End If
            End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub TXTNAME_Validating(sender As Object, e As CancelEventArgs) Handles TXTNAME.Validating
        Try
            If Not CHECKDUPLICATE() Then e.Cancel = True
            uppercase(TXTNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSPECIALIZATION_Enter(sender As Object, e As EventArgs) Handles CMBSPECIALIZATION.Enter
        Try
            If CMBSPECIALIZATION.Text.Trim = "" Then FILLCATEGORY(CMBSPECIALIZATION)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSPECIALIZATION_Validating(sender As Object, e As CancelEventArgs) Handles CMBSPECIALIZATION.Validating
        Try
            If CMBSPECIALIZATION.Text.Trim <> "" Then SPECIALIZATIONVALIDATE(CMBSPECIALIZATION, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBAREA_Enter(sender As Object, e As EventArgs) Handles CMBAREA.Enter
        Try
            If CMBAREA.Text.Trim = "" Then FILLVILLAGE(CMBAREA)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBAREA_Validating(sender As Object, e As CancelEventArgs) Handles CMBAREA.Validating
        Try
            If CMBAREA.Text.Trim <> "" Then AREAVALIDATE(CMBAREA, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCITY_Enter(sender As Object, e As EventArgs) Handles CMBCITY.Enter
        Try
            If CMBCITY.Text.Trim = "" Then FILLCITY(CMBCITY)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCITY_Validating(sender As Object, e As CancelEventArgs) Handles CMBCITY.Validating
        Try
            If CMBCITY.Text.Trim <> "" Then CITYVALIDATE(CMBCITY, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSTATE_Enter(sender As Object, e As EventArgs) Handles CMBSTATE.Enter
        Try
            If CMBSTATE.Text.Trim = "" Then FILLSTATE(CMBSTATE)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJDOCTOR As New DoctorDetails
            OBJDOCTOR.MdiParent = MDIMain
            OBJDOCTOR.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            'Fill Category,Village,Taluka,District
            FILLCATEGORY(CMBSPECIALIZATION)
            FILLVILLAGE(CMBAREA)
            FILLCITY(CMBCITY)
            FILLSTATE(CMBSTATE)
            FILLCOUNTRY(CMBCOUNTRY)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DoctorMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'PATIENT MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            FILLCMB()
            CLEAR()
            TXTNAME.Text = TEMPDOCTOR

            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJDOCTOR As New ClsDoctorMaster
                OBJDOCTOR.alParaval.Add(TEMPID)
                OBJDOCTOR.alParaval.Add(CmpId)
                dttable = OBJDOCTOR.GETDOCTOR()
                If dttable.Rows.Count > 0 Then
                    TXTNAME.Text = dttable.Rows(0).Item("NAME").ToString
                    TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                    CMBSEX.Text = dttable.Rows(0).Item("SEX").ToString
                    CMBSPECIALIZATION.Text = dttable.Rows(0).Item("SPECIALIZATION")
                    CMBAREA.Text = dttable.Rows(0).Item("AREA")
                    CMBCITY.Text = dttable.Rows(0).Item("CITY")
                    CMBSTATE.Text = dttable.Rows(0).Item("STATE")
                    CMBCOUNTRY.Text = dttable.Rows(0).Item("COUNTRY")
                    TXTADDRESS.Text = dttable.Rows(0).Item("ADDRESS")
                    TXTMOBILE.Text = dttable.Rows(0).Item("MOBILENO")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDELETE_Click(sender As Object, e As EventArgs) Handles CMDDELETE.Click
        Try
            If EDIT = True Then

                If USERDELETE = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim TEMPMSG As Integer = MsgBox("Wish to Delete?", MsgBoxStyle.YesNo)
                If TEMPMSG = vbNo Then Exit Sub


                Dim ALPARAVAL As New ArrayList

                ALPARAVAL.Add(TEMPID)

                Dim OBJACC As New ClsDoctorMaster
                OBJACC.alParaval = ALPARAVAL
                Dim DT As DataTable = OBJACC.DELETE
                If DT.Rows.Count > 0 Then
                    MsgBox(DT.Rows(0).Item(0))
                    EDIT = False
                    CLEAR()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSTATE_Validating(sender As Object, e As CancelEventArgs) Handles CMBSTATE.Validating
        Try
            If CMBSTATE.Text.Trim <> "" Then STATEVALIDATE(CMBSTATE, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCOUNTRY_Enter(sender As Object, e As EventArgs) Handles CMBCOUNTRY.Enter
        Try
            If CMBCOUNTRY.Text.Trim = "" Then FILLCOUNTRY(CMBCOUNTRY)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBCOUNTRY_Validating(sender As Object, e As CancelEventArgs) Handles CMBCOUNTRY.Validating
        Try
            If CMBCOUNTRY.Text.Trim <> "" Then COUNTRYVALIDATE(CMBCOUNTRY, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTAGE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTAGE.KeyPress
        numkeypress(e, sender, Me)
    End Sub

    Private Sub DoctorMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class