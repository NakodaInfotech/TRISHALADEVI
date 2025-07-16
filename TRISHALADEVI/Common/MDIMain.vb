
Imports BL
Imports WAProAPI

Public Class MDIMain

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MDIMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = CmpName & " (" & AccFrom & " - " & AccTo & ")"
        GETCONN()
        SETENABILITY()

        If ALLOWWHATSAPP = True Then
            WHATSAPPREG_MASTER.Enabled = True
            SENDWHATSAPP_MASTER.Enabled = True
            Dim BASEURL As String = GETWHATSAPPBASEURL()
            If BASEURL <> "" Then
                APIMethods.BaseURL = BASEURL
            Else
                MsgBox("Whastapp Base URL is Missing", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Sub SETENABILITY()
        Try

            If UserName = "Admin" Then
                CMP_MASTER.Enabled = True
                YEAR_MASTER.Enabled = True
                ADMIN_MASTER.Enabled = True
                MERGELEDGER.Enabled = True
                MERGEPARAMETER_MENU.Enabled = True
                BLOCKUSER_MENU.Enabled = True
            Else
                'ONLY TO CHANGE PASSWORD
                ADMIN_MASTER.Enabled = True
                USERADD.Enabled = False
                USEREDIT.Enabled = True
            End If

            For Each DTROW As DataRow In USERRIGHTS.Rows

                'MASTERS
                If DTROW(0).ToString = "PATIENT MASTER" Then
                    If DTROW(1).ToString = True Then
                        PATIENT_MASTER.Enabled = True
                        PATIENT_TOOL.Enabled = True
                        PATIENTADD.Enabled = True
                        DOCTOR_MASTER.Enabled = True
                        DOCTORADD.Enabled = True
                    Else
                        PATIENTADD.Enabled = False
                        DOCTORADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        PATIENT_MASTER.Enabled = True
                        PATIENTEDIT.Enabled = True
                        DOCTOR_MASTER.Enabled = True
                        DOCTOREDIT.Enabled = True
                    Else
                        PATIENTEDIT.Enabled = False
                        DOCTOREDIT.Enabled = False
                    End If


                ElseIf DTROW(0).ToString = "SURGERY MASTER" Then
                    If DTROW(1).ToString = True Then
                        SURGERY_MASTER.Enabled = True
                        AMOUNT_MASTER.Enabled = True
                        SURGERYADD.Enabled = True
                        AMOUNTADD.Enabled = True
                    Else
                        SURGERYADD.Enabled = False
                        AMOUNTADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        SURGERY_MASTER.Enabled = True
                        AMOUNT_MASTER.Enabled = True
                        SURGERYEDIT.Enabled = True
                        AMOUNTEDIT.Enabled = True
                    Else
                        SURGERYEDIT.Enabled = False
                        AMOUNTEDIT.Enabled = False
                    End If


                ElseIf DTROW(0).ToString = "SELECT MASTER" Then
                    If DTROW(1).ToString = True Then
                        CATEGORY_MASTER.Enabled = True
                        VILLAGE_MASTER.Enabled = True
                        TALUKA_MASTER.Enabled = True
                        DISTRICT_MASTER.Enabled = True
                        CATEGORYADD.Enabled = True
                        VILLAGEADD.Enabled = True
                        TALUKAADD.Enabled = True
                        DISTRICTADD.Enabled = True
                    Else
                        CATEGORYADD.Enabled = False
                        VILLAGEADD.Enabled = False
                        TALUKAADD.Enabled = False
                        DISTRICTADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        CATEGORY_MASTER.Enabled = True
                        VILLAGE_MASTER.Enabled = True
                        TALUKA_MASTER.Enabled = True
                        DISTRICT_MASTER.Enabled = True
                        CATEGORYEDIT.Enabled = True
                        VILLAGEEDIT.Enabled = True
                        TALUKAEDIT.Enabled = True
                        DISTRICTEDIT.Enabled = True
                    Else
                        CATEGORYEDIT.Enabled = False
                        VILLAGEEDIT.Enabled = False
                        TALUKAEDIT.Enabled = False
                        DISTRICTEDIT.Enabled = False
                    End If

                ElseIf DTROW(0).ToString = "CLAIM" Then
                    If DTROW(1).ToString = True Then
                        CLAIM_MASTER.Enabled = True
                        CLAIM_TOOL.Enabled = True
                        CLAIM_ADD.Enabled = True
                    Else
                        CLAIM_ADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        CLAIM_MASTER.Enabled = True
                        CLAIM_EDIT.Enabled = True
                    Else
                        CLAIM_EDIT.Enabled = False
                    End If

                ElseIf DTROW(0).ToString = "OPD" Then
                    If DTROW(1).ToString = True Then
                        DISPLAYOPD_REPORT.Enabled = True
                        OPD_MASTER.Enabled = True
                        OPD_TOOL.Enabled = True
                        OPDADD.Enabled = True
                        OPD_REPORTS.Enabled = True
                    Else
                        OPDADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        OPD_MASTER.Enabled = True
                        OPDEDIT.Enabled = True
                        OPD_REPORTS.Enabled = True
                    Else
                        OPDEDIT.Enabled = False
                    End If

                ElseIf DTROW(0).ToString = "IPD" Then
                    If DTROW(1).ToString = True Then
                        IPD_MASTER.Enabled = True
                        IPD_TOOL.Enabled = True
                        IPDADD.Enabled = True
                    Else
                        IPDADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        IPD_MASTER.Enabled = True
                        IPDEDIT.Enabled = True
                    Else
                        IPDEDIT.Enabled = False
                    End If

                ElseIf DTROW(0).ToString = "MISCSALE" Then
                    If DTROW(1).ToString = True Then
                        MISCSALE_MASTER.Enabled = True
                        MISCSALE_TOOL.Enabled = True
                        MISCSALEADD.Enabled = True
                    Else
                        MISCSALEADD.Enabled = False
                    End If
                    If (DTROW(2) = True) Or (DTROW(3) = True) Or (DTROW(4) = True) Then
                        MISCSALE_MASTER.Enabled = True
                        MISCSALEEDIT.Enabled = True
                    Else
                        MISCSALEEDIT.Enabled = False
                    End If

                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub addUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERADD.Click
        Try
            Dim objuser As New UserMaster
            objuser.MdiParent = Me
            objuser.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub editUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USEREDIT.Click
        Try
            Dim objuser As New UserDetails
            objuser.MdiParent = Me
            objuser.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Sub opencmp(ByVal CMP As String)
        Try

            Dim objcmn As New ClsCommon
            Dim DT As DataTable

            DT = objcmn.search("CMPMASTER.CMP_NAME, YEARMASTER.YEAR_DBNAME, CMPMASTER.CMP_ID, YEARMASTER.YEAR_STARTDATE, YEARMASTER.YEAR_ENDDATE, YEARMASTER.YEAR_ID", "", " CMPMASTER INNER JOIN YEARMASTER ON YEARMASTER.YEAR_CMPID = CMPMASTER.CMP_ID", " AND CMPMASTER.CMP_NAME = '" & CMP & "'")
            CmpName = DT.Rows(0).Item(0).ToString
            DBName = DT.Rows(0).Item(1).ToString
            CmpId = DT.Rows(0).Item(2).ToString
            AccFrom = DT.Rows(0).Item(3)
            AccTo = DT.Rows(0).Item(4)
            YearId = DT.Rows(0).Item(5).ToString
            Cmppassword.cmdback.Visible = False
            Cmppassword.lblretype.Visible = False
            Cmppassword.txtretypepassword.Visible = False
            Cmppassword.cmdnext.Text = "&Ok"
            Cmppassword.ShowDialog()

        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub ChangeCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeCompany.Click
        Try
            'close all child forms
            Dim frm As Form
            For Each frm In MdiChildren
                frm.Close()
            Next

            Me.Dispose()
            Cmpdetails.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ChangeUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUserToolStripMenuItem.Click
        Try
            'close all child forms
            Dim frm As Form
            For Each frm In MdiChildren
                frm.Close()
            Next

            Me.Dispose()
            Login.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMPEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPEDIT.Click
        Try
            Cmpmaster.edit = True
            Cmpmaster.TEMPCMPNAME = CmpName
            Cmpmaster.ShowDialog()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMPADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMPADD.Click
        Try
            Dim obj As New Cmpmaster
            obj.Show()
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub BackupCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupCompany.Click
        Try
            backup()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub backup()
        Try
            'TAKE BACKUP
            Dim TEMPMSG As Integer = MsgBox("Create Backup?", MsgBoxStyle.YesNo)
            If TEMPMSG = vbYes Then

                'CHECKING FOR BACKUP FOLDER
                If FileIO.FileSystem.DirectoryExists("C:\TRISHALADEVIBACKUP") = False Then FileIO.FileSystem.CreateDirectory("C:\TRISHALADEVIBACKUP")

                'IF SAME DATE'S BACKUP EXIST THEN DELETE IT THEN RECREATE IT
                If FileIO.FileSystem.FileExists("C:\TRISHALADEVIBACKUP\BACKUP " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".bak") Then FileIO.FileSystem.DeleteFile("D:\TRISHALADEVIBACKUP\BACKUP " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".bak")

                Dim OBJCMN As New ClsCommon
                Dim DT As DataTable = OBJCMN.Execute_Any_String(" backup database TRISHALADEVI to disk='C:\TRISHALADEVIBACKUP\BACKUP " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".bak'", "", "")
                MsgBox("Backup Completed")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub BLOCKUSER_MENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLOCKUSER_MENU.Click
        Try
            Dim OBJUSER As New BlockUser
            OBJUSER.MdiParent = Me
            OBJUSER.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub YEARADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YEARADD.Click
        Try
            Dim TEMPMSG As Integer = MsgBox("Create New Accounting Year?", MsgBoxStyle.YesNo)
            If TEMPMSG = vbYes Then
                Dim obj As New YearMaster
                obj.cmdback.Visible = False
                obj.EDIT = False
                obj.FRMSTRING = "ADDYEAR"
                obj.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CATEGORYADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATEGORYADD.Click
        Try
            Dim OBJSELECT As New SelectMaster
            OBJSELECT.FRMSTRING = "CATEGORY"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CATEGORYEDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATEGORYEDIT.Click
        Try
            Dim OBJSELECT As New SelectDetails
            OBJSELECT.FRMSTRING = "CATEGORY"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AddNewVillageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VILLAGEADD.Click
        Try
            Dim OBJSELECT As New SelectMaster
            OBJSELECT.FRMSTRING = "VILLAGE"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditExistingCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VILLAGEEDIT.Click
        Try
            Dim OBJSELECT As New SelectDetails
            OBJSELECT.FRMSTRING = "VILLAGE"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AddNewTalukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TALUKAADD.Click
        Try
            Dim OBJSELECT As New SelectMaster
            OBJSELECT.FRMSTRING = "TALUKA"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditExistingTalukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TALUKAEDIT.Click
        Try
            Dim OBJSELECT As New SelectDetails
            OBJSELECT.FRMSTRING = "TALUKA"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AddNewDistrictToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISTRICTADD.Click
        Try
            Dim OBJSELECT As New SelectMaster
            OBJSELECT.FRMSTRING = "DISTRICT"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditExistingTalukaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISTRICTEDIT.Click
        Try
            Dim OBJSELECT As New SelectDetails
            OBJSELECT.FRMSTRING = "DISTRICT"
            OBJSELECT.MdiParent = Me
            OBJSELECT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PATIENT_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATIENTADD.Click
        Try
            Dim OBJPATIENT As New PatientMaster
            OBJPATIENT.MdiParent = Me
            OBJPATIENT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PATIENT_EDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PATIENTEDIT.Click
        Try
            Dim OBJPATIENT As New PatientDetails
            OBJPATIENT.MdiParent = Me
            OBJPATIENT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SURGERY_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SURGERYADD.Click
        Try
            Dim OBJSURGERY As New SurgeryMaster
            OBJSURGERY.MdiParent = Me
            OBJSURGERY.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SURGERY_EDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SURGERYEDIT.Click
        Try
            Dim OBJSURGERY As New SurgeryDetails
            OBJSURGERY.MdiParent = Me
            OBJSURGERY.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CLAIM_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLAIM_ADD.Click
        Try
            Dim OBJCLAIM As New Claim
            OBJCLAIM.MdiParent = Me
            OBJCLAIM.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CLAIM_EDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLAIM_EDIT.Click
        Try
            Dim OBJCLAIMDETAILS As New ClaimDetails
            OBJCLAIMDETAILS.MdiParent = Me
            OBJCLAIMDETAILS.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AMOUNTADD_Click(sender As Object, e As EventArgs) Handles AMOUNTADD.Click
        Try
            Dim OBJCLAIM As New AmountMaster
            OBJCLAIM.MdiParent = Me
            OBJCLAIM.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AMOUNTEDIT_Click(sender As Object, e As EventArgs) Handles AMOUNTEDIT.Click
        Try
            Dim OBJCLAIMDETAILS As New AmountMasterDetails
            OBJCLAIMDETAILS.MdiParent = Me
            OBJCLAIMDETAILS.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPDADD_Click(sender As Object, e As EventArgs) Handles OPDADD.Click
        Try
            Dim OBJCLAIM As New OPD
            OBJCLAIM.MdiParent = Me
            OBJCLAIM.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPDEDIT_Click(sender As Object, e As EventArgs) Handles OPDEDIT.Click
        Try
            Dim OBJCLAIMDETAILS As New OpdDetails
            OBJCLAIMDETAILS.MdiParent = Me
            OBJCLAIMDETAILS.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IPDADD_Click(sender As Object, e As EventArgs) Handles IPDADD.Click
        Try
            Dim OBJCLAIM As New IPD
            OBJCLAIM.MdiParent = Me
            OBJCLAIM.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IPDEDIT_Click(sender As Object, e As EventArgs) Handles IPDEDIT.Click
        Try
            Dim OBJCLAIMDETAILS As New IpdDetails
            OBJCLAIMDETAILS.MdiParent = Me
            OBJCLAIMDETAILS.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PATIENT_TOOL_Click(sender As Object, e As EventArgs) Handles PATIENT_TOOL.Click
        Try
            Dim OBJPATIENT As New PatientMaster
            OBJPATIENT.MdiParent = Me
            OBJPATIENT.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPD_TOOL_Click(sender As Object, e As EventArgs) Handles OPD_TOOL.Click
        Try
            Dim OBJOPD As New OPD
            OBJOPD.MdiParent = Me
            OBJOPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub IPD_TOOL_Click(sender As Object, e As EventArgs) Handles IPD_TOOL.Click
        Try
            Dim OBJIPD As New IPD
            OBJIPD.MdiParent = Me
            OBJIPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ADDMISCSALE_Click(sender As Object, e As EventArgs) Handles MISCSALEADD.Click
        Try
            Dim OBJIPD As New MiscSale
            OBJIPD.MdiParent = Me
            OBJIPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EDIT_MISC_Click(sender As Object, e As EventArgs) Handles MISCSALEEDIT.Click
        Try
            Dim OBJIPD As New MiscSaleDetails
            OBJIPD.MdiParent = Me
            OBJIPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MISCSALE_TOOL_Click(sender As Object, e As EventArgs) Handles MISCSALE_TOOL.Click
        Try
            Dim OBJIPD As New MiscSale
            OBJIPD.MdiParent = Me
            OBJIPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DISPLAYOPD_REPORT_Click(sender As Object, e As EventArgs) Handles DISPLAYOPD_REPORT.Click
        Try
            Dim OBJOPD As New DisplayToken
            OBJOPD.MdiParent = Me
            OBJOPD.WHERECLAUSE = " AND DATE = '" & Format(Now.Date, "MM/dd/yyyy") & "'"
            OBJOPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OPD_REPORTS_Click(sender As Object, e As EventArgs) Handles OPD_REPORTS.Click
        Try
            Dim OBJOPD As New OPDFilter
            OBJOPD.MdiParent = Me
            OBJOPD.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub MDIMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If ClientName = "YOGESH" Then
                OPD_TOOL.Visible = False
                OPD_TOOLSTRIP.Visible = False
                OPD_MASTER.Visible = False
                IPD_TOOL.Visible = False
                IPD_TOOLSTRIP.Visible = False
                IPD_MASTER.Visible = False
                OPD_REPORTS.Visible = False
                OPDREPORTS_TOOLSTRIP.Visible = False
                DISPLAYOPD_REPORT.Visible = False
                DISPLAYOPD_TOOLSTRIP.Visible = False
                SENDWHATSAPP_MASTER.Enabled = True

            ElseIf ClientName = "TRISHALADEVIOLDRABKAVI" Or ClientName = "TRISHALADEVIOLDATHANI" Then
                OPD_TOOL.Visible = False
                OPD_TOOLSTRIP.Visible = False
                OPD_MASTER.Visible = False
                IPD_TOOL.Visible = False
                IPD_TOOLSTRIP.Visible = False
                IPD_MASTER.Visible = False
                OPD_REPORTS.Visible = False
                OPDREPORTS_TOOLSTRIP.Visible = False
                DISPLAYOPD_REPORT.Visible = False
                DISPLAYOPD_TOOLSTRIP.Visible = False
                DOCTOR_MASTER.Visible = False
                CLAIM_MASTER.Visible = True
            Else

                DOCTOR_MASTER.Visible = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DOCTORADD_Click(sender As Object, e As EventArgs) Handles DOCTORADD.Click
        Try
            Dim OBJDOCTOR As New DoctorMaster
            OBJDOCTOR.MdiParent = Me
            OBJDOCTOR.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DOCTOREDIT_Click(sender As Object, e As EventArgs) Handles DOCTOREDIT.Click
        Try
            Dim OBJDOCTOR As New DoctorDetails
            OBJDOCTOR.MdiParent = Me
            OBJDOCTOR.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub WHATSAPPREG_MASTER_Click(sender As Object, e As EventArgs) Handles WHATSAPPREG_MASTER.Click
        Try
            Dim OBJWHATSAPP As New WhatsAppRegistration
            OBJWHATSAPP.MdiParent = Me
            OBJWHATSAPP.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SENDWHATSAPP_MASTER_Click(sender As Object, e As EventArgs) Handles SENDWHATSAPP_MASTER.Click
        Try
            Dim OBJWHATSAPP As New SendWhatsapp
            OBJWHATSAPP.MdiParent = Me
            OBJWHATSAPP.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CLAIM_TOOL_Click(sender As Object, e As EventArgs) Handles CLAIM_TOOL.Click
        Try
            Dim OBJCLAIM As New Claim
            OBJCLAIM.MdiParent = Me
            OBJCLAIM.Show()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class