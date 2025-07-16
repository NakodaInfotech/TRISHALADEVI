Imports BL

Public Class Claim
    Dim USERADD, USEREDIT, USERVIEW, USERDELETE As Boolean      'USED FOR RIGHT MANAGEMAENT
    Public EDIT As Boolean
    Public TEMPSRNO As Integer

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Try
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PatientMaster_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.Alt = True And e.KeyCode = Keys.D1 Then
                TabControl1.SelectedIndex = 0
            ElseIf e.Alt = True And e.KeyCode = Keys.D2 Then
                TabControl1.SelectedIndex = 1
            ElseIf e.Alt = True And e.KeyCode = Keys.Left Then
                Call Toolprevious_Click(sender, e)
            ElseIf e.Alt = True And e.KeyCode = Keys.Right Then
                Call toolnext_Click(sender, e)
            ElseIf (e.KeyCode = Windows.Forms.Keys.Escape) Then   'for Exit
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                SendKeys.Send("{Tab}")
            ElseIf e.KeyCode = Keys.F2 Then
                TXTNO.Focus()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub FILLCMB()
        Try
            'Fill Patient, MRD No, Surgery
            FILLPATIENT(CMBNAME)
            FILLMRDNO(CMBMRDNO)
            FILLSURGERY(CMBSURGERY)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Claim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim DTROW() As DataRow = USERRIGHTS.Select("FormName = 'CLAIM'")
            USERADD = DTROW(0).Item(1)
            USEREDIT = DTROW(0).Item(2)
            USERVIEW = DTROW(0).Item(3)
            USERDELETE = DTROW(0).Item(4)

            FILLCMB()
            CLEAR()
            If EDIT = True Then
                If USEREDIT = False And USERVIEW = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim dttable As New DataTable
                Dim OBJCLAIM As New ClsClaim

                OBJCLAIM.alParaval.Add(TEMPSRNO)
                OBJCLAIM.alParaval.Add(YearId)

                dttable = OBJCLAIM.GETCLAIM()

                If dttable.Rows.Count > 0 Then


                    TXTSRNO.Text = dttable.Rows(0).Item("SRNO").ToString
                    CMBNAME.Text = dttable.Rows(0).Item("NAME").ToString
                    CMBMRDNO.Text = dttable.Rows(0).Item("MRDNO").ToString

                    TXTFIRSTNAME.Text = dttable.Rows(0).Item("FIRSTNAME").ToString
                    TXTLASTNAME.Text = dttable.Rows(0).Item("LASTNAME").ToString
                    TXTUHLDNO.Text = dttable.Rows(0).Item("UHLDNO").ToString

                    TXTCATEGORY.Text = dttable.Rows(0).Item("CATEGORY").ToString
                    TXTVILLAGE.Text = dttable.Rows(0).Item("VILLAGE").ToString
                    TXTTALUKA.Text = dttable.Rows(0).Item("TALUKA").ToString
                    TXTDISTRICT.Text = dttable.Rows(0).Item("DISTRICT").ToString

                    TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
                    TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                    TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString

                    TXTSOCIETY.Text = dttable.Rows(0).Item("SOCIETY").ToString
                    TXTVILLAGEFINALBILL.Text = dttable.Rows(0).Item("VILLAGEFINALBILL").ToString

                    TXTCLAIMNO.Text = dttable.Rows(0).Item("CLAIMNO").ToString
                    DTSANCTION.Text = dttable.Rows(0).Item("SANCTIONDATE").ToString
                    CMBSURGERY.Text = dttable.Rows(0).Item("SURGERY").ToString
                    TXTILLNESS.Text = dttable.Rows(0).Item("ILLNESS").ToString


                    DTSURGERY.Text = dttable.Rows(0).Item("SURGERYDATE").ToString
                    DTADMISSION.Text = dttable.Rows(0).Item("ADMISSIONDATE").ToString
                    DTDISCHARGE.Text = dttable.Rows(0).Item("DISCHARGEDATE").ToString

                    TXTCODEAPP.Text = dttable.Rows(0).Item("CODEAPP").ToString
                    TXTCODEDONE.Text = dttable.Rows(0).Item("CODEDONE").ToString

                    TXTHOSPITAL.Text = dttable.Rows(0).Item("HOSPITAL").ToString
                    TXTHTALUKA.Text = dttable.Rows(0).Item("HTALUKA").ToString
                    TXTHREGNO.Text = dttable.Rows(0).Item("HREGNO").ToString

                    TXTSURGEON.Text = dttable.Rows(0).Item("SURGEON").ToString
                    TXTSURGEONMOBILE.Text = dttable.Rows(0).Item("SMOBILE").ToString

                    If IsDBNull(dttable.Rows(0).Item("PBEFORE")) = False Then
                        PBBEFORE.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PBEFORE"), Byte())))
                    Else
                        PBBEFORE.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PAFTER")) = False Then
                        PBAFTER.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PAFTER"), Byte())))
                    Else
                        PBAFTER.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PASCAN")) = False Then
                        PBASCAN.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PASCAN"), Byte())))
                    Else
                        PBASCAN.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PCLAIM")) = False Then
                        PBCLAIM.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PCLAIM"), Byte())))
                    Else
                        PBCLAIM.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PAUTHORITY")) = False Then
                        PBAUTHORITY.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PAUTHORITY"), Byte())))
                    Else
                        PBAUTHORITY.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PUHLD")) = False Then
                        PBUHLD.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PUHLD"), Byte())))
                    Else
                        PBUHLD.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PDOC1")) = False Then
                        PBDOC1.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PDOC1"), Byte())))
                    Else
                        PBDOC1.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PDOC2")) = False Then
                        PBDOC2.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PDOC2"), Byte())))
                    Else
                        PBDOC2.Image = Nothing
                    End If

                    If IsDBNull(dttable.Rows(0).Item("PDOC3")) = False Then
                        PBDOC3.Image = Image.FromStream(New IO.MemoryStream(DirectCast(dttable.Rows(0).Item("PDOC3"), Byte())))
                    Else
                        PBDOC3.Image = Nothing
                    End If

                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        Try
            EP.Clear()
            If Not ERRORVALID() Then
                Exit Sub
            End If

            Dim IntResult As Integer
            Dim alParaval As New ArrayList

            alParaval.Add(TXTSRNO.Text.Trim)
            alParaval.Add(CMBNAME.Text.Trim)

            alParaval.Add(TXTMOBILE.Text.Trim)
            alParaval.Add(Val(TXTAGE.Text.Trim))

            alParaval.Add(TXTSOCIETY.Text.Trim)
            alParaval.Add(TXTVILLAGEFINALBILL.Text.Trim)


            alParaval.Add(TXTCLAIMNO.Text.Trim)
            alParaval.Add(Format(DTSANCTION.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(CMBSURGERY.Text.Trim)
            alParaval.Add(TXTILLNESS.Text.Trim)

            alParaval.Add(Format(DTSURGERY.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(Format(DTADMISSION.Value.Date, "MM/dd/yyyy"))
            alParaval.Add(Format(DTDISCHARGE.Value.Date, "MM/dd/yyyy"))

            alParaval.Add(TXTCODEAPP.Text.Trim)
            alParaval.Add(TXTCODEDONE.Text.Trim)

            alParaval.Add(TXTHOSPITAL.Text.Trim)
            alParaval.Add(TXTHTALUKA.Text.Trim)
            alParaval.Add(TXTHREGNO.Text.Trim)

            alParaval.Add(TXTSURGEON.Text.Trim)
            alParaval.Add(TXTSURGEONMOBILE.Text.Trim)

            'Scanned Documents Upload

            'Before Photo Upload
            If PBBEFORE.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBBEFORE.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'After Photo Upload
            If PBAFTER.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBAFTER.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'A-Scan Report Upload
            If PBASCAN.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBASCAN.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'Claim Request Upload
            If PBCLAIM.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBCLAIM.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'Authorization Letter Upload
            If PBAUTHORITY.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBAUTHORITY.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'UHLD Receipt Upload
            If PBUHLD.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBUHLD.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'Doc1 Upload
            If PBDOC1.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBDOC1.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'Doc2 Upload
            If PBDOC2.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBDOC2.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            'Doc3 Upload
            If PBDOC3.Image IsNot Nothing Then
                Dim MS As New IO.MemoryStream
                PBDOC3.Image.Save(MS, Drawing.Imaging.ImageFormat.Png)
                alParaval.Add(MS.ToArray)
            Else
                alParaval.Add(DBNull.Value)
            End If

            alParaval.Add(CmpId)
            alParaval.Add(Userid)
            alParaval.Add(YearId)

            Dim OBJCLAIM As New ClsClaim
            OBJCLAIM.alParaval = alParaval

            'Save Claim
            If EDIT = False Then
                If USERADD = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                Dim DT As DataTable = OBJCLAIM.SAVE()
                TEMPSRNO = DT.Rows(0).Item(0)
                MsgBox("Details Added")
            Else
                'Update Claim
                If USEREDIT = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If
                IntResult = OBJCLAIM.UPDATE()
                EDIT = False
                MsgBox("Details Updated")
            End If

            CLEAR()
            CMBNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLEAR.Click
        Try
            CLEAR()
            EDIT = False
            CMBNAME.Focus()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Try
            If EDIT = True Then

                If USERDELETE = False Then
                    MsgBox("Insufficient Rights")
                    Exit Sub
                End If

                Dim TEMPMSG As Integer = MsgBox("Wish to Delete?", MsgBoxStyle.YesNo)
                If TEMPMSG = vbNo Then Exit Sub


                Dim ALPARAVAL As New ArrayList

                ALPARAVAL.Add(TEMPSRNO)
                ALPARAVAL.Add(YearId)

                Dim OBJACC As New ClsClaim
                OBJACC.alParaval = ALPARAVAL
                Dim INTRES As Integer = OBJACC.DELETE
                MsgBox("Claim Deleted Successfully")
                CLEAR()
                EDIT = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub PRINTREPORT(ByVal SRNO As Integer)
        Try
            If MsgBox("Wish to Print Documents?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Dim STRSEARCH As String = "{CLAIMMASTER.CLAIM_SRNO} = " & SRNO & " AND {CLAIMMASTER.CLAIM_YEARID} = " & YearId

            If CHKHFORM.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "HOSPITALREPORT"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKLIST.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "CHECKLIST"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKCLAIM.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "CLAIM"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKUHLDDOC1.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "UHLDDOC1"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKUHLDDOC2.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "UHLDDOC2"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKUHLDREC.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "UHLDREC"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKSCAN.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "SCAN"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKPHOTOBEFORE.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "PHOTOBEFORE"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKCLAIMREQ.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "CLAIMREQ"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKAUTHORIZATION.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "AUTHORIZATION"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKOTNOTES.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "OTNOTES"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKPHOTOAFTER.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "PHOTOAFTER"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKDISCHARGE.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "DISCHARGESUMM"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKBILL.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "SMALLBILL"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKFINALBILL.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "FINALBILL"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKIMPLANT.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "IMPLANTBILL"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKREPORTDOC1.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "REPORTDOC1"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKREPORTDOC2.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "REPORTDOC2"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

            If CHKREPORTDOC3.CheckState = CheckState.Checked Then
                Dim OBJCLAIM As New ClaimDesign
                OBJCLAIM.FRMSTRING = "REPORTDOC3"
                OBJCLAIM.STRSEARCH = STRSEARCH
                OBJCLAIM.MdiParent = MDIMain
                OBJCLAIM.Show()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRINT.Click
        Try
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub CLEAR()
        Try
            TXTNO.Clear()
            TXTSRNO.Clear()
            GETMAX_SRNO()

            CMBNAME.Text = ""
            CMBMRDNO.Text = ""

            TXTFIRSTNAME.Clear()
            TXTLASTNAME.Clear()
            TXTUHLDNO.Clear()
            TXTCLAIMNO.Clear()

            TXTCATEGORY.Clear()
            TXTVILLAGE.Clear()
            TXTTALUKA.Clear()
            TXTDISTRICT.Clear()

            TXTMOBILE.Clear()
            TXTAGE.Clear()
            TXTSEX.Clear()

            TXTSOCIETY.Clear()
            TXTVILLAGEFINALBILL.Clear()
            TXTCODEAPP.Clear()
            TXTCODEDONE.Clear()


            CMBSURGERY.Text = ""
            DTSURGERY.Value = Mydate
            DTSANCTION.Value = Mydate
            DTADMISSION.Value = Mydate
            DTDISCHARGE.Value = Mydate
            TXTILLNESS.Clear()

            TXTHTALUKA.Text = CMPCITYNAME
            TXTHREGNO.Text = HOSPREGNO


            CHKHFORM.CheckState = CheckState.Checked
            CHKLIST.CheckState = CheckState.Checked
            CHKCLAIM.CheckState = CheckState.Checked
            CHKUHLDDOC1.CheckState = CheckState.Checked
            CHKUHLDDOC2.CheckState = CheckState.Checked
            CHKUHLDREC.CheckState = CheckState.Checked
            CHKSCAN.CheckState = CheckState.Checked
            CHKPHOTOBEFORE.CheckState = CheckState.Checked
            CHKCLAIMREQ.CheckState = CheckState.Checked
            CHKAUTHORIZATION.CheckState = CheckState.Checked
            CHKOTNOTES.CheckState = CheckState.Checked
            CHKPHOTOAFTER.CheckState = CheckState.Checked
            CHKDISCHARGE.CheckState = CheckState.Checked
            CHKBILL.CheckState = CheckState.Checked
            CHKFINALBILL.CheckState = CheckState.Checked
            CHKREPORTDOC1.CheckState = CheckState.Checked
            CHKREPORTDOC2.CheckState = CheckState.Checked
            CHKREPORTDOC3.CheckState = CheckState.Checked
            CHKALL.Checked = CheckState.Unchecked
            CHKALL.Text = "Print None"

            PBBEFORE.Image = Nothing
            PBAFTER.Image = Nothing
            PBASCAN.Image = Nothing
            PBAUTHORITY.Image = Nothing
            PBCLAIM.Image = Nothing
            PBDOC1.Image = Nothing
            PBDOC2.Image = Nothing
            PBDOC3.Image = Nothing
            PBUHLD.Image = Nothing

            If ClientName = "RABKAVI" Then TXTHTALUKA.Text = "RABKAVI"

            EP.Clear()

            TabControl1.SelectedTab = TabPage1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBNAME_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMBNAME.Enter
        Try
            If CMBNAME.Text.Trim = "" Then FILLPATIENT(CMBNAME)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBNAME_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBNAME.Validating
        Try
            If CMBNAME.Text.Trim <> "" Then NAMEVALIDATE(CMBNAME, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBNAME_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBNAME.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJPATIENT As New SelectForm
                OBJPATIENT.FRMSTRING = "PATIENT"
                OBJPATIENT.ShowDialog()
                If OBJPATIENT.TEMPNAME <> "" Then CMBNAME.Text = OBJPATIENT.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMBSURGERY.Enter
        Try
            If CMBSURGERY.Text.Trim = "" Then FILLSURGERY(CMBSURGERY)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMBSURGERY.KeyDown
        Try
            If e.KeyCode = Keys.Oemcomma Then e.SuppressKeyPress = True
            If e.KeyCode = Keys.OemQuotes Then e.SuppressKeyPress = True

            If e.KeyCode = Keys.F1 Then
                Dim OBJSURGERY As New SelectForm
                OBJSURGERY.FRMSTRING = "SURGERY"
                OBJSURGERY.ShowDialog()
                If OBJSURGERY.TEMPNAME <> "" Then CMBSURGERY.Text = OBJSURGERY.TEMPNAME
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function CHECKDUPLICATE() As Boolean
        Try
            Dim BLN As Boolean = True
            If TXTCLAIMNO.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable
                If (EDIT = False) Then
                    dt = objclscommon.search(" CLAIM_CLAIMNO ", "", " CLAIMMASTER ", " AND CLAIM_CLAIMNO = '" & TXTCLAIMNO.Text.Trim & "' AND CLAIM_YEARID = " & YearId)
                    If dt.Rows.Count > 0 Then
                        MsgBox("Claim No Already Exists", MsgBoxStyle.Critical, "TRISHALADEVI")
                        BLN = False
                    End If
                End If
            End If
            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CMBNAME_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBNAME.Validated
        Try
            GETDETAILS(CMBNAME.Text)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETDETAILS(ByRef NAME As String)
        Try
            Dim OBJPATIENT As New ClsPatientMaster
            Dim ALPARAVAL As New ArrayList

            If NAME = Nothing Then Exit Sub


            'GET PATIENTID AND PASS
            Dim OBJCMN As New ClsCommon
            Dim DT As DataTable = OBJCMN.search("PATIENT_ID AS ID", "", " PATIENTMASTER ", " AND PATIENT_NAME = '" & NAME & "' AND PATIENT_CMPID = " & CmpId)
            If DT.Rows.Count = 0 Then Exit Sub


            ALPARAVAL.Add(Val(DT.Rows(0).Item("ID")))
            ALPARAVAL.Add(YearId)

            OBJPATIENT.alParaval = ALPARAVAL
            Dim dttable As DataTable = OBJPATIENT.GETPATIENT

            If dttable.Rows.Count > 0 Then
                'FILL DETAILS

                CMBNAME.Text = dttable.Rows(0).Item("NAME")
                TXTFIRSTNAME.Text = dttable.Rows(0).Item("FIRSTNAME").ToString
                TXTLASTNAME.Text = dttable.Rows(0).Item("LASTNAME").ToString

                TXTUHLDNO.Text = dttable.Rows(0).Item("UHLDNO").ToString
                CMBMRDNO.Text = dttable.Rows(0).Item("MRDNO")

                TXTAGE.Text = dttable.Rows(0).Item("AGE").ToString
                TXTSEX.Text = dttable.Rows(0).Item("SEX").ToString

                TXTCATEGORY.Text = dttable.Rows(0).Item("CATEGORY").ToString
                TXTVILLAGE.Text = dttable.Rows(0).Item("VILLAGE").ToString
                TXTTALUKA.Text = dttable.Rows(0).Item("TALUKA").ToString
                TXTDISTRICT.Text = dttable.Rows(0).Item("DISTRICT").ToString

                If TXTMOBILE.Text.Trim = "" Then TXTMOBILE.Text = dttable.Rows(0).Item("MOBILE").ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTCLAIMNO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTCLAIMNO.Validating
        Try
            If Not CHECKDUPLICATE() Then e.Cancel = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBSURGERY_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBSURGERY.Validating
        Try
            If CMBSURGERY.Text.Trim <> "" Then SURGERYVALIDATE(CMBSURGERY, e, Me)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTILLNESS_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTILLNESS.Validated
        Try
            uppercase(TXTILLNESS)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ERRORVALID() As Boolean
        Try
            Dim BLN As Boolean = True

            If CMBNAME.Text.Trim.Length = 0 Then
                EP.SetError(CMBNAME, "Fill Patient Name")
                BLN = False
            End If

            If TXTCLAIMNO.Text.Trim.Length = 0 Then
                EP.SetError(TXTCLAIMNO, "Fill Claim No")
                BLN = False
            End If

            If Not CHECKDUPLICATE() Then
                EP.SetError(TXTCLAIMNO, "Claim No Already Exists")
                BLN = False
            End If

            If CMBMRDNO.Text.Trim.Length = 0 Then
                EP.SetError(CMBMRDNO, "Fill MRD No")
                BLN = False
            End If

            If TXTUHLDNO.Text.Trim.Length = 0 Then
                EP.SetError(TXTUHLDNO, "Fill UHLD No")
                BLN = False
            End If

            If TXTMOBILE.Text.Trim.Length = 0 Then
                EP.SetError(TXTMOBILE, "Fill Mobile No")
                BLN = False
            End If

            If TXTAGE.Text.Trim.Length = 0 Then
                EP.SetError(TXTAGE, "Fill Age")
                BLN = False
            End If

            If Val(TXTAGE.Text.Trim) > 200 Then
                EP.SetError(TXTAGE, "Fill Proper Details")
                BLN = False
            End If

            If CMBSURGERY.Text.Trim.Length = 0 Then
                EP.SetError(CMBSURGERY, "Fill Surgery Name")
                BLN = False
            End If

            If TXTILLNESS.Text.Trim.Length = 0 Then
                EP.SetError(TXTILLNESS, "Fill Nature of Illness")
                BLN = False
            End If

            'Compare Dates

            If DTSURGERY.Value < DTADMISSION.Value Then
                EP.SetError(DTSURGERY, "Surgery Date cannot be before Admission Date")
                BLN = False
            End If

            If DTSURGERY.Value > DTDISCHARGE.Value Then
                EP.SetError(DTSURGERY, "Surgery Date cannot be after Discharge Date")
                BLN = False
            End If

            If DTSANCTION.Value > DTADMISSION.Value Then
                EP.SetError(DTSANCTION, "Sanction Date cannot be after Admission Date")
                BLN = False
            End If

            If DTSANCTION.Value > DTDISCHARGE.Value Then
                EP.SetError(DTSANCTION, "Sanction Date cannot be after Discharge Date")
                BLN = False
            End If

            If DTSANCTION.Value > DTSURGERY.Value Then
                EP.SetError(DTSANCTION, "Sanction Date cannot be after Surgery Date")
                BLN = False
            End If

            Return BLN
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub CMBMRDNO_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMBMRDNO.Enter
        Try
            If CMBMRDNO.Text.Trim = "" Then FILLMRDNO(CMBMRDNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMBMRDNO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMBMRDNO.Validating
        Try
            If CMBMRDNO.Text.Trim <> "" Then
                Dim objclscommon As New ClsCommonMaster
                Dim dt As DataTable
                dt = objclscommon.search(" PATIENT_NAME AS NAME ", "", " PATIENTMASTER ", " AND PATIENT_MRDNO = " & CMBMRDNO.Text.Trim & " AND PATIENT_CMPID = " & CmpId)
                If dt.Rows.Count > 0 Then
                    GETDETAILS(dt.Rows(0).Item("NAME"))
                Else
                    MsgBox("MRD No not present", MsgBoxStyle.Critical, "TRISHALADEVI")
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GETMAX_SRNO()
        Try
            Dim DTTABLE As New DataTable
            DTTABLE = GETMAX(" isnull(max(CLAIM_SRNO),0) + 1 ", " CLAIMMASTER ", " AND CLAIM_CMPID = " & CmpId & " AND CLAIM_YEARID=" & YearId)
            If DTTABLE.Rows.Count > 0 Then TXTSRNO.Text = DTTABLE.Rows(0).Item(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDBEFOREUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBEFOREUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBBEFORE.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDBEFOREREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBEFOREREMOVE.Click
        Try
            PBBEFORE.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDBEFOREVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBEFOREVIEW.Click
        Try
            If PBBEFORE.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBBEFORE.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDBEFOREPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDBEFOREPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKPHOTOBEFORE.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAFTERUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAFTERUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBAFTER.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAFTERREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAFTERREMOVE.Click
        Try
            PBAFTER.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAFTERVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAFTERVIEW.Click
        Try
            If PBAFTER.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBAFTER.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAFTERPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAFTERPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKPHOTOAFTER.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDASCANUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDASCANUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png;*.jpg)|*.bmp;*.jpeg;*.png;*.jpg"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBASCAN.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDASCANREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDASCANREMOVE.Click
        Try
            PBASCAN.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDASCANVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDASCANVIEW.Click
        Try
            If PBASCAN.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBASCAN.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDASCANPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDASCANPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKSCAN.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLAIMUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLAIMUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBCLAIM.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLAIMREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLAIMREMOVE.Click
        Try
            PBCLAIM.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLAIMVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLAIMVIEW.Click
        Try
            If PBCLAIM.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBCLAIM.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDCLAIMPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCLAIMPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKCLAIMREQ.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAUTHORITYUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAUTHORITYUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBAUTHORITY.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAUTHORITYREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAUTHORITYREMOVE.Click
        Try
            PBAUTHORITY.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAUTHORITYVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAUTHORITYVIEW.Click
        Try
            If PBAUTHORITY.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBAUTHORITY.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDAUTHORITYPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDAUTHORITYPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKAUTHORIZATION.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUHLDUPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUHLDUPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBUHLD.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUHLDREMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUHLDREMOVE.Click
        Try
            PBUHLD.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUHLDVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUHLDVIEW.Click
        Try
            If PBUHLD.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBUHLD.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDUHLDPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUHLDPRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKUHLDREC.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1UPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1UPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBDOC1.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1REMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1REMOVE.Click
        Try
            PBDOC1.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1VIEW.Click
        Try
            If PBDOC1.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBDOC1.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC1PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC1PRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKREPORTDOC1.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2UPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2UPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBDOC2.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2REMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2REMOVE.Click
        Try
            PBDOC2.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2VIEW.Click
        Try
            If PBDOC2.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBDOC2.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC2PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC2PRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKREPORTDOC2.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC3UPLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC3UPLOAD.Click
        Try
            OpenFileDialog1.Filter = "Pictures (*.bmp;*.jpeg;*.png)|*.bmp;*.jpeg;*.png"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName.Trim.Length <> 0 Then PBDOC3.ImageLocation = OpenFileDialog1.FileName
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC3REMOVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC3REMOVE.Click
        Try
            PBDOC3.Image = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CMDDOC3VIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC3VIEW.Click
        Try
            If PBDOC3.ImageLocation <> Nothing Then
                Dim OBJVIEW As New ViewImage
                OBJVIEW.PBSOFTCOPY.Image = PBDOC3.Image
                OBJVIEW.ShowDialog()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub SETCHECKSTATE()
        Try
            If CHKALL.Text = "Print All" Then
                CHKHFORM.CheckState = CheckState.Checked
                CHKLIST.CheckState = CheckState.Checked
                CHKCLAIM.CheckState = CheckState.Checked
                CHKUHLDDOC1.CheckState = CheckState.Checked
                CHKUHLDDOC2.CheckState = CheckState.Checked
                CHKUHLDREC.CheckState = CheckState.Checked
                CHKSCAN.CheckState = CheckState.Checked
                CHKPHOTOBEFORE.CheckState = CheckState.Checked
                CHKCLAIMREQ.CheckState = CheckState.Checked
                CHKAUTHORIZATION.CheckState = CheckState.Checked
                CHKOTNOTES.CheckState = CheckState.Checked
                CHKPHOTOAFTER.CheckState = CheckState.Checked
                CHKDISCHARGE.CheckState = CheckState.Checked
                CHKBILL.CheckState = CheckState.Checked
                CHKFINALBILL.CheckState = CheckState.Checked
                CHKREPORTDOC1.CheckState = CheckState.Checked
                CHKREPORTDOC2.CheckState = CheckState.Checked
                CHKREPORTDOC3.CheckState = CheckState.Checked
                CHKALL.Checked = CheckState.Unchecked
                CHKALL.Text = "Print None"
                Exit Sub
            End If

            If CHKALL.Text = "Print None" Then
                CHKHFORM.CheckState = CheckState.Unchecked
                CHKLIST.CheckState = CheckState.Unchecked
                CHKCLAIM.CheckState = CheckState.Unchecked
                CHKUHLDDOC1.CheckState = CheckState.Unchecked
                CHKUHLDDOC2.CheckState = CheckState.Unchecked
                CHKUHLDREC.CheckState = CheckState.Unchecked
                CHKSCAN.CheckState = CheckState.Unchecked
                CHKPHOTOBEFORE.CheckState = CheckState.Unchecked
                CHKCLAIMREQ.CheckState = CheckState.Unchecked
                CHKAUTHORIZATION.CheckState = CheckState.Unchecked
                CHKOTNOTES.CheckState = CheckState.Unchecked
                CHKPHOTOAFTER.CheckState = CheckState.Unchecked
                CHKDISCHARGE.CheckState = CheckState.Unchecked
                CHKBILL.CheckState = CheckState.Unchecked
                CHKFINALBILL.CheckState = CheckState.Unchecked
                CHKREPORTDOC1.CheckState = CheckState.Unchecked
                CHKREPORTDOC2.CheckState = CheckState.Unchecked
                CHKREPORTDOC3.CheckState = CheckState.Unchecked
                CHKALL.Text = "Print All"
                Exit Sub
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CHKALL_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKALL.CheckStateChanged
        Try
            SETCHECKSTATE()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        Try
            If USEREDIT = False And USERVIEW = False Then
                MsgBox("Insufficient Rights")
                Exit Sub
            End If

            Dim OBJCLAIM As New ClaimDetails
            OBJCLAIM.MdiParent = MDIMain
            OBJCLAIM.Show()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            CMDOK_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        Try
            If EDIT = True Then PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TOOLDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLDELETE.Click
        Try
            Call CMDDELETE_Click(sender, e)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Toolprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toolprevious.Click
        Try
LINE1:
            TEMPSRNO = TXTSRNO.Text.Trim
            TEMPSRNO = Val(TXTSRNO.Text) - 1
            If TEMPSRNO > 0 Then
                EDIT = True
                Claim_Load(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If

            If TXTCLAIMNO.Text.Trim = "" And TEMPSRNO > 1 Then
                TXTSRNO.Text = TEMPSRNO
                GoTo LINE1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub toolnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolnext.Click
        Try
LINE1:
            TEMPSRNO = Val(TXTSRNO.Text) + 1
            GETMAX_SRNO()
            Dim MAXNO As Integer = TXTSRNO.Text.Trim
            CLEAR()
            If Val(TXTSRNO.Text) - 1 >= TEMPSRNO Then
                EDIT = True
                Claim_Load(sender, e)
            Else
                CLEAR()
                EDIT = False
            End If
            If TXTCLAIMNO.Text.Trim = "" And TEMPSRNO < MAXNO Then
                TXTSRNO.Text = TEMPSRNO
                GoTo LINE1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TXTCLAIMSRNO_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTNO.Validating
        Try
            If Val(TXTNO.Text.Trim) > 0 Then
                TEMPSRNO = Val(TXTNO.Text)
                If TEMPSRNO > 0 Then
                    EDIT = True
                    Claim_Load(sender, e)
                Else
                    CLEAR()
                    EDIT = False
                End If
            End If
        Catch ex As Exception
            If ErrHandle(ex.Message.GetHashCode) = False Then Throw ex
        End Try
    End Sub

    Private Sub CMDDOC3PRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDOC3PRINT.Click
        Try
            If EDIT = False Then Exit Sub
            CHKALL.Text = "Print None"
            SETCHECKSTATE()
            CHKREPORTDOC3.CheckState = CheckState.Checked
            PRINTREPORT(TEMPSRNO)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class