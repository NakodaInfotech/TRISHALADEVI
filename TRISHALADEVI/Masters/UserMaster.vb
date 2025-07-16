﻿
Imports BL

Public Class UserMaster

    Public Uname As String
    Public edit As Boolean

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub UserMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                If errorvalid() = True Then
                    Dim tempmsg As Integer = MessageBox.Show("Save Changes?", "", MessageBoxButtons.YesNo)
                    If tempmsg = vbYes Then cmdok_Click(sender, e)
                End If
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

    Private Sub UserMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim objcmn As New ClsCommon
            Dim dt As New DataTable
            If edit = False Then
                FILLUSER(CMBUSER)
            Else
                CMBUSER.Enabled = False
            End If
            fillgrid()

            dt = objcmn.search("CMP_NAME", "", "CMPMASTER", "")
            For Each DTROW As DataRow In dt.Rows
                LSTCMP.Items.Add(DTROW(0).ToString)
                If DTROW(0) = CmpName Then LSTCMP.SetItemChecked(LSTCMP.Items.Count - 1, True)
            Next

            If edit = True Then
                dt = objcmn.search("User_Password,User_email, User_tel, User_smtp, User_pop, User_smtpemail, User_smtppass", "", "UserMaster", " and user_name = '" & Uname & "' and user_cmpid = " & CmpId)
                txtusername.Text = Uname
                txtpassword.Text = dt.Rows(0).Item(0).ToString
                txtconfirmpass.Text = txtpassword.Text
                txtemail.Text = dt.Rows(0).Item(1).ToString
                txttel.Text = dt.Rows(0).Item(2).ToString
                txtsmtp.Text = dt.Rows(0).Item(3).ToString
                txtpop.Text = dt.Rows(0).Item(4).ToString
                txtsmtpemail.Text = dt.Rows(0).Item(5).ToString
                txtsmtppass.Text = dt.Rows(0).Item(6).ToString

                Dim DTUSER As New DataTable
                DTUSER = objcmn.search(" DISTINCT  User_formName as [FormName], User_add as Addf, User_Edit as Editf, User_View as Viewf, User_Delete as Deletef ", "", " USERMASTER_RIGHTS INNER JOIN USERMASTER ON USERMASTER.USER_ID = USERMASTER_RIGHTS.USER_ID AND USERMASTER.USER_CMPID = USERMASTER_RIGHTS.USER_CMPID ", " and USERMASTER.USER_NAME = '" & Uname & "' and Usermaster.User_cmpid = " & CmpId & " ORDER BY USERMASTER_rights.USER_FORMNAME")
                griddetails.DataSource = DTUSER

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub fillgrid()
        Try
            Dim objcmn As New ClsCommon
            Dim dt As New DataTable
            dt = objcmn.search("Form_Name as FormName, isnull(form_add,'False') as Addf, isnull(form_edit,'False') as Editf, isnull(form_view,'False') as Viewf, isnull(form_delete,'False') as Deletef ", "", "FormMaster", " ORDER BY FORM_NAME")
            For Each DTROW As DataRow In dt.Rows
                cmbformname.Items.Add(DTROW(0).ToString)
            Next
            griddetails.DataSource = dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub fillgriduser(ByVal name As String)
        Try
            Dim objcmn As New ClsCommon
            Dim dtuser As New DataTable

            dtuser = objcmn.search(" DISTINCT  User_formName as [FormName], User_add as Addf, User_Edit as Editf, User_View as Viewf, User_Delete as Deletef ", "", " USERMASTER_RIGHTS INNER JOIN USERMASTER ON USERMASTER.USER_ID = USERMASTER_RIGHTS.USER_ID AND USERMASTER.USER_CMPID = USERMASTER_RIGHTS.USER_CMPID ", " and USERMASTER.USER_NAME = '" & CMBUSER.Text.Trim & "' AND USERMASTER.user_cmpid = " & CmpId & " order by USERMASTER_rights.user_formname")
            griddetails.DataSource = dtuser
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub griduser_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles griduser.ValidateRow
        Try
            Dim DTROW As DataRowView = e.Row
            If (DTROW(0).ToString = "") Or (DTROW(1).ToString = "" And DTROW(2).ToString = "" And DTROW(3).ToString = "" And DTROW(4).ToString = "") Then
                MsgBox("Enter Details", MsgBoxStyle.Exclamation)
                e.Valid = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdok.Click
        Try
            Dim IntResult As Integer
            EP.Clear()
            If Not errorvalid() Then
                Exit Sub
            End If

            Dim alParaval As New ArrayList

            alParaval.Add(txtusername.Text.Trim)
            alParaval.Add(txtpassword.Text.Trim)
            alParaval.Add(txtemail.Text.Trim)
            alParaval.Add(txttel.Text.Trim)
            alParaval.Add(txtsmtp.Text.Trim)
            alParaval.Add(txtpop.Text.Trim)
            alParaval.Add(txtsmtpemail.Text.Trim)
            alParaval.Add(txtsmtppass.Text.Trim)

            Dim CHK As CheckedListBox.CheckedItemCollection = LSTCMP.CheckedItems
            For Each obj As Object In CHK
                Dim objcmn As New ClsCommon
                Dim dt As DataTable
                dt = objcmn.search("cmp_id,year_id", "", "cmpmaster inner join yearmaster ON YEAR_CMPID = CMP_ID", " AND CMP_NAME ='" & CHK.Item(0) & "'")
                alParaval.Add(dt.Rows(0).Item(0))
                alParaval.Add(Locationid)
                alParaval.Add(Userid)
                alParaval.Add(dt.Rows(0).Item(1))
                alParaval.Add(0)
            Next

           

            Dim formname As String = ""
            Dim gadd As String = ""
            Dim gedit As String = ""
            Dim gview As String = ""
            Dim gdelete As String = ""

            For i As Integer = 0 To griduser.RowCount - 1

                Dim dtrow As DataRow = griduser.GetDataRow(i)
                If formname = "" Then

                    formname = dtrow(0).ToString

                    If Convert.ToBoolean(dtrow(1)) = False Then
                        gadd = "False"
                    Else
                        gadd = dtrow(1)
                    End If

                    If Convert.ToBoolean(dtrow(2)) = False Then
                        gedit = "False"
                    Else
                        gedit = dtrow(2)
                    End If

                    If Convert.ToBoolean(dtrow(3)) = False Then
                        gview = "False"
                    Else
                        gview = dtrow(3)
                    End If

                    If Convert.ToBoolean(dtrow(4)) = False Then
                        gdelete = "False"
                    Else
                        gdelete = dtrow(4)
                    End If

                Else

                    formname = formname & "," & dtrow(0).ToString

                    If Convert.ToBoolean(dtrow(1)) = False Then
                        gadd = gadd & "," & "False"
                    Else
                        gadd = gadd & "," & dtrow(1)
                    End If

                    If Convert.ToBoolean(dtrow(2)) = False Then
                        gedit = gedit & "," & "False"
                    Else
                        gedit = gedit & "," & dtrow(2)
                    End If

                    If Convert.ToBoolean(dtrow(3)) = False Then
                        gview = gview & "," & "False"
                    Else
                        gview = gview & "," & dtrow(3)
                    End If

                    If Convert.ToBoolean(dtrow(4)) = False Then
                        gdelete = gdelete & "," & "False"
                    Else
                        gdelete = gdelete & "," & dtrow(4)
                    End If

                End If
            Next

            alParaval.Add(formname)
            alParaval.Add(gadd)
            alParaval.Add(gedit)
            alParaval.Add(gview)
            alParaval.Add(gdelete)


            Dim objclsusermaster As New ClsUserMaster()
            objclsusermaster.alParaval = alParaval

            If edit = False Then

                If UserName <> "Admin" Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                IntResult = objclsusermaster.save()
                MessageBox.Show("Details Added")
            Else
                alParaval.Add(Uname)
                If UserName = "Admin" Then
                    IntResult = objclsusermaster.update()
                Else
                    IntResult = objclsusermaster.updateuserdetails()
                End If
                MsgBox("Details Updated")
                edit = False
            End If

            If edit = False Then
                Dim tempmsg As Integer = MsgBox("Add User for Diffrent Company?", MsgBoxStyle.YesNo)
                If tempmsg = vbYes Then
                    For i As Integer = 0 To LSTCMP.Items.Count - 1
                        LSTCMP.SetItemChecked(i, False)
                    Next
                    txtusername.Focus()
                Else
                    clear()
                    txtusername.Focus()
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
 
    Sub clear()
        Try
            EP.Clear()
            txtusername.Clear()
            txtpassword.Clear()
            txtconfirmpass.Clear()
            txtemail.Clear()
            txttel.Clear()
            txtsmtp.Clear()
            txtpop.Clear()
            txtsmtpemail.Clear()
            txtsmtppass.Clear()
            CMBUSER.Text = ""

            griddetails.DataSource = Nothing
            For i As Integer = 0 To LSTCMP.Items.Count - 1
                LSTCMP.SetItemChecked(i, False)
            Next
            fillgrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function errorvalid() As Boolean
        Dim bln As Boolean = True

        If txtusername.Text.Trim.Length = 0 Then
            EP.SetError(txtusername, "Enter User Name")
            bln = False
        End If

        If txtpassword.Text.Trim.Length = 0 Then
            EP.SetError(txtpassword, "Enter Password")
            bln = False
        End If

        If txtpassword.Text.Trim <> txtconfirmpass.text.trim Then
            EP.SetError(txtconfirmpass, "Password Does not Match")
            txtpassword.Clear()
            txtconfirmpass.Clear()
            bln = False
        End If

        If griduser.RowCount <= 0 Then
            EP.SetError(txtusername, "Assign atleast 1 Right")
            bln = False
        End If

        If LSTCMP.CheckedItems.Count <= 0 Then
            EP.SetError(LSTCMP, "Select Company")
            bln = False
        End If

        If (edit = False) Or (edit = True And Uname <> txtusername.Text.Trim) Then
            Dim objcmn As New ClsCommon
            Dim CHK As CheckedListBox.CheckedItemCollection = LSTCMP.CheckedItems
            For Each obj As Object In CHK
                Dim dt As DataTable = objcmn.search("cmp_id", "", "cmpmaster", " AND CMP_NAME ='" & CHK.Item(0) & "'")
                Dim dt1 As DataTable = objcmn.search("user_id", "", "USERMASTER", " AND USER_NAME ='" & txtusername.Text.Trim & "' AND USER_CMPID = " & dt.Rows(0).Item(0))
                If dt1.Rows.Count > 0 Then
                    EP.SetError(txtusername, "User Already Exists In selected Company")
                    bln = False
                End If
            Next
        End If

        Return bln

    End Function

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Try
            Dim objudet As New UserDetails
            objudet.MdiParent = MDIMain
            objudet.Show()
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Call cmdok_Click(sender, e)
    End Sub

    Private Sub LSTCMP_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles LSTCMP.ItemCheck
        Try
            If e.NewValue = CheckState.Checked And LSTCMP.CheckedItems.Count > 0 Then
                e.NewValue = CheckState.Unchecked
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        clear()
        edit = False
        txtusername.Focus()
    End Sub

    Private Sub ToolStripdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripdelete.Click
        Try
            If edit = True Then
                Dim tempmsg As Integer = MsgBox("Delete User Permanently?", MsgBoxStyle.YesNo, "TRISHALADEVI")
                If tempmsg = vbYes Then

                    Dim OBJUser As New ClsUserMaster
                    Dim ALPARAVAL As New ArrayList

                    ALPARAVAL.Add(txtusername.Text.Trim)
                    ALPARAVAL.Add(CmpId)

                    OBJUser.alParaval = ALPARAVAL
                    Dim DT As DataTable = OBJUser.DELETE()
                    MsgBox(DT.Rows(0).Item(0).ToString)

                    clear()

                End If

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub chkall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkall.CheckedChanged
        Try

            Dim dt As DataTable = griddetails.DataSource
            For Each row As DataRow In dt.Rows
                row.Item("Addf") = chkall.CheckState
                row.Item("Editf") = chkall.CheckState
                row.Item("Viewf") = chkall.CheckState
                row.Item("Deletef") = chkall.CheckState
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBUSER_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBUSER.Validated
        Try
            If CMBUSER.Text.Trim <> "" Then
                Dim TEMPMSG As Integer = MsgBox("Copy Rights of " & CMBUSER.Text.Trim & "?", MsgBoxStyle.YesNo)
                If TEMPMSG = vbYes Then fillgriduser(CMBUSER.Text.Trim)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CHKSHOWPASS_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHKSHOWPASS.CheckedChanged
        Try
            If CHKSHOWPASS.Checked = True Then txtsmtppass.PasswordChar = "" Else txtsmtppass.PasswordChar = "*"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

   
End Class