Imports BL

Public Class SelectMaster
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean              'Used for edit
    Public TEMPNAME As String           'Used for edit name
    Public TEMPID As Integer            'Used for edit id
    Public FRMSTRING As String

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSAVE.Click
        Try

            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim ALPARAVAL As New ArrayList

            ALPARAVAL.Add(FRMSTRING)
            ALPARAVAL.Add(TXTNAME.Text.Trim)
            ALPARAVAL.Add(CmpId)
            ALPARAVAL.Add(Userid)
            ALPARAVAL.Add(YearId)

            Dim OBJCATEGORY As New ClsSelectMaster
            OBJCATEGORY.ALPARAVAL = ALPARAVAL
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                IntResult = OBJCATEGORY.SAVE()
                MsgBox("Details Added")

            ElseIf EDIT = True Then
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                ALPARAVAL.Add(TEMPID)
                IntResult = OBJCATEGORY.UPDATE()
                MsgBox("Details Updated")
                EDIT = False
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
                EP.SetError(TXTNAME, "Fill " & TXTFRM.Text.Trim)
                BLN = False
            Else
                If (EDIT = False) Or (EDIT = True And LCase(TEMPNAME) <> LCase(TXTNAME.Text.Trim)) Then
                    ' search duplication 
                    Dim OBJCMN As New ClsCommon
                    Dim dt As New DataTable
                    dt = OBJCMN.search(FRMSTRING & "_NAME ", "", "" & FRMSTRING & "MASTER ", " AND " & FRMSTRING & "_NAME = '" & TXTNAME.Text.Trim & "'")
                    If dt.Rows.Count > 0 Then
                        EP.SetError(TXTNAME, TXTFRM.Text.Trim & " Already Exists")
                        BLN = False
                    End If
                    uppercase(TXTNAME)
                End If
            End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Sub CLEAR()
        EP.Clear()
        TXTNAME.Clear()
    End Sub

    Private Sub TXTNAME_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTNAME.Validating
        Try

            If (EDIT = False) Or (EDIT = True And LCase(TEMPNAME) <> LCase(TXTNAME.Text.Trim)) Then
                ' search duplication 
                If TXTNAME.Text.Trim <> Nothing Then
                    Dim OBJCMN As New ClsCommonMaster
                    Dim dt As New DataTable
                    dt = OBJCMN.search(FRMSTRING & "_NAME ", "", "" & FRMSTRING & "MASTER ", " AND " & FRMSTRING & "_NAME = '" & TXTNAME.Text.Trim & "'")
                    If dt.Rows.Count > 0 Then
                        MsgBox(TXTFRM.Text.Trim & " Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                        e.Cancel = True
                    End If
                    uppercase(TXTNAME)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SelectMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Windows.Forms.Keys.Escape) Then               'FOR EXIT
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            ElseIf e.KeyCode = Keys.OemQuotes Then
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SelectMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'SELECT MASTER'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            CLEAR()

            TXTFRM.Text = FRMSTRING
            pcase(TXTFRM)


            Me.Text = "Add " & TXTFRM.Text.Trim
            

            'find the current right alignment position
            Dim rightAlign As Integer = LBSELECT.Left + LBSELECT.Width
            'set the text (assumes AutoSize is set to True)
            LBSELECT.Text = TXTFRM.Text.Trim
            'adjust position so the right hand point is in the same position as before
            LBSELECT.Left = rightAlign - LBSELECT.Width

            If EDIT = True Then

                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim ALPARAVAL As New ArrayList
                ALPARAVAL.Add(FRMSTRING)
                ALPARAVAL.Add(TEMPID)
                Dim OBJSELECT As New ClsSelectMaster
                OBJSELECT.ALPARAVAL = ALPARAVAL
                Dim dttable As DataTable = OBJSELECT.GETSELECT()
                If dttable.Rows.Count > 0 Then
                    TXTNAME.Text = dttable.Rows(0).Item("NAME").ToString
                    TEMPNAME = dttable.Rows(0).Item("NAME").ToString
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmddelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Try
            If EDIT = True Then
                If USERDELETE = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim tempmsg As Integer = MsgBox("Delete " & TXTFRM.Text.Trim & " Permanently?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                If tempmsg = vbYes Then

                    Dim OBJCATEGORY As New ClsSelectMaster
                    Dim ALPARAVAL As New ArrayList

                    ALPARAVAL.Add(TEMPID)

                    OBJCATEGORY.ALPARAVAL = ALPARAVAL
                    Dim INTRES As Integer = OBJCATEGORY.DELETE()
                    EDIT = False
                    clear()

                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
            TXTNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class