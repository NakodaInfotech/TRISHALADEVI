Imports BL
Imports DevExpress.XtraGrid.Views.Grid

Public Class ClaimDetails
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT

    Private Sub ClaimDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Windows.Forms.Keys.Escape Or (e.KeyCode = Keys.X And e.Alt = True) Then
                Me.Close()
            ElseIf e.KeyCode = Keys.N And e.Alt = True Then
                SHOWFORM(False, 0)
            ElseIf e.KeyCode = Keys.O And e.Alt = True Then
                CMDADD_Click(sender, e)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ClaimDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'CLAIM'")
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

    Sub FILLGRID(Optional ByVal whereclause As String = "")
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim ALPARAVAL As New ArrayList
            Dim OBJPATIENT As New ClsClaim

            ALPARAVAL.Add("")
            ALPARAVAL.Add(YearId)

            OBJPATIENT.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJPATIENT.GETCLAIM
            GRIDCLAIMDETAILS.DataSource = dttable

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Try
            SHOWFORM(False)
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub SHOWFORM(ByVal EDITVAL As Boolean, Optional ByVal SRNO As Integer = 0)
        Try
            If (EDITVAL = True And USEREDIT = False And USERVIEW = False) Or (EDITVAL = False And USERADD = False) Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            If (EDITVAL = False) Or (EDITVAL = True And GRIDCLAIM.RowCount > 0) Then
                Dim OBJCLAIM As New Claim
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.EDIT = EDITVAL
                OBJCLAIM.TEMPSRNO = SRNO
                OBJCLAIM.Show()
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GRIDCLAIM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDCLAIM.DoubleClick
        Try
            SHOWFORM(True, GRIDCLAIM.GetFocusedRowCellValue("SRNO"))
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
            FILLGRID()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class