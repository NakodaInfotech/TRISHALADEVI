<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendWhatsapp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTPATH = New System.Windows.Forms.TextBox()
        Me.CMDUPLOAD = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RBPATIENT = New System.Windows.Forms.RadioButton()
        Me.CHKSELECTALL = New System.Windows.Forms.CheckBox()
        Me.RBDOCTOR = New System.Windows.Forms.RadioButton()
        Me.gridbilldetails = New DevExpress.XtraGrid.GridControl()
        Me.gridbill = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCHK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMOBILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTAUTOCC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTERRORMSG = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTOTHERNO5 = New System.Windows.Forms.TextBox()
        Me.TXTOTHERNO4 = New System.Windows.Forms.TextBox()
        Me.TXTOTHERNO3 = New System.Windows.Forms.TextBox()
        Me.TXTOTHERNO2 = New System.Windows.Forms.TextBox()
        Me.TXTOTHERNO1 = New System.Windows.Forms.TextBox()
        Me.TXTMESSAGE = New System.Windows.Forms.TextBox()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.CMDSEND = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTFILENAME = New System.Windows.Forms.TextBox()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlendPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.TXTFILENAME)
        Me.BlendPanel1.Controls.Add(Me.Label9)
        Me.BlendPanel1.Controls.Add(Me.TXTPATH)
        Me.BlendPanel1.Controls.Add(Me.CMDUPLOAD)
        Me.BlendPanel1.Controls.Add(Me.GroupBox4)
        Me.BlendPanel1.Controls.Add(Me.Label8)
        Me.BlendPanel1.Controls.Add(Me.TXTAUTOCC)
        Me.BlendPanel1.Controls.Add(Me.Label7)
        Me.BlendPanel1.Controls.Add(Me.TXTERRORMSG)
        Me.BlendPanel1.Controls.Add(Me.Label6)
        Me.BlendPanel1.Controls.Add(Me.TXTOTHERNO5)
        Me.BlendPanel1.Controls.Add(Me.TXTOTHERNO4)
        Me.BlendPanel1.Controls.Add(Me.TXTOTHERNO3)
        Me.BlendPanel1.Controls.Add(Me.TXTOTHERNO2)
        Me.BlendPanel1.Controls.Add(Me.TXTOTHERNO1)
        Me.BlendPanel1.Controls.Add(Me.TXTMESSAGE)
        Me.BlendPanel1.Controls.Add(Me.cmdcancel)
        Me.BlendPanel1.Controls.Add(Me.CMDSEND)
        Me.BlendPanel1.Controls.Add(Me.Label1)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.Label3)
        Me.BlendPanel1.Controls.Add(Me.Label4)
        Me.BlendPanel1.Controls.Add(Me.Label5)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1329, 582)
        Me.BlendPanel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(85, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 660
        Me.Label9.Text = "Path"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTPATH
        '
        Me.TXTPATH.BackColor = System.Drawing.Color.Linen
        Me.TXTPATH.Location = New System.Drawing.Point(120, 234)
        Me.TXTPATH.MaxLength = 10
        Me.TXTPATH.Name = "TXTPATH"
        Me.TXTPATH.ReadOnly = True
        Me.TXTPATH.Size = New System.Drawing.Size(423, 23)
        Me.TXTPATH.TabIndex = 659
        Me.TXTPATH.TabStop = False
        '
        'CMDUPLOAD
        '
        Me.CMDUPLOAD.Location = New System.Drawing.Point(202, 263)
        Me.CMDUPLOAD.Name = "CMDUPLOAD"
        Me.CMDUPLOAD.Size = New System.Drawing.Size(80, 28)
        Me.CMDUPLOAD.TabIndex = 5
        Me.CMDUPLOAD.Text = "Upload Doc"
        Me.CMDUPLOAD.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RBPATIENT)
        Me.GroupBox4.Controls.Add(Me.CHKSELECTALL)
        Me.GroupBox4.Controls.Add(Me.RBDOCTOR)
        Me.GroupBox4.Controls.Add(Me.gridbilldetails)
        Me.GroupBox4.Location = New System.Drawing.Point(591, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(729, 566)
        Me.GroupBox4.TabIndex = 658
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selection"
        '
        'RBPATIENT
        '
        Me.RBPATIENT.AutoSize = True
        Me.RBPATIENT.BackColor = System.Drawing.Color.Transparent
        Me.RBPATIENT.Location = New System.Drawing.Point(364, 18)
        Me.RBPATIENT.Name = "RBPATIENT"
        Me.RBPATIENT.Size = New System.Drawing.Size(63, 19)
        Me.RBPATIENT.TabIndex = 1
        Me.RBPATIENT.Text = "Patient"
        Me.RBPATIENT.UseVisualStyleBackColor = False
        '
        'CHKSELECTALL
        '
        Me.CHKSELECTALL.AutoSize = True
        Me.CHKSELECTALL.BackColor = System.Drawing.Color.Transparent
        Me.CHKSELECTALL.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSELECTALL.ForeColor = System.Drawing.Color.Black
        Me.CHKSELECTALL.Location = New System.Drawing.Point(18, 22)
        Me.CHKSELECTALL.Name = "CHKSELECTALL"
        Me.CHKSELECTALL.Size = New System.Drawing.Size(77, 18)
        Me.CHKSELECTALL.TabIndex = 2
        Me.CHKSELECTALL.Text = "Select All"
        Me.CHKSELECTALL.UseVisualStyleBackColor = False
        '
        'RBDOCTOR
        '
        Me.RBDOCTOR.AutoSize = True
        Me.RBDOCTOR.BackColor = System.Drawing.Color.Transparent
        Me.RBDOCTOR.Checked = True
        Me.RBDOCTOR.Location = New System.Drawing.Point(299, 18)
        Me.RBDOCTOR.Name = "RBDOCTOR"
        Me.RBDOCTOR.Size = New System.Drawing.Size(62, 19)
        Me.RBDOCTOR.TabIndex = 0
        Me.RBDOCTOR.TabStop = True
        Me.RBDOCTOR.Text = "Doctor"
        Me.RBDOCTOR.UseVisualStyleBackColor = False
        '
        'gridbilldetails
        '
        Me.gridbilldetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbilldetails.Location = New System.Drawing.Point(15, 43)
        Me.gridbilldetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gridbilldetails.MainView = Me.gridbill
        Me.gridbilldetails.Name = "gridbilldetails"
        Me.gridbilldetails.Size = New System.Drawing.Size(698, 517)
        Me.gridbilldetails.TabIndex = 3
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCHK, Me.GNAME, Me.GAREA, Me.GCITY, Me.GMOBILENO})
        Me.gridbill.GridControl = Me.gridbilldetails
        Me.gridbill.Name = "gridbill"
        Me.gridbill.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridbill.OptionsView.ColumnAutoWidth = False
        Me.gridbill.OptionsView.ShowAutoFilterRow = True
        Me.gridbill.OptionsView.ShowFooter = True
        '
        'GCHK
        '
        Me.GCHK.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GCHK.FieldName = "CHK"
        Me.GCHK.Name = "GCHK"
        Me.GCHK.OptionsColumn.ShowCaption = False
        Me.GCHK.Visible = True
        Me.GCHK.VisibleIndex = 0
        Me.GCHK.Width = 35
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.ImageIndex = 0
        Me.GNAME.Name = "GNAME"
        Me.GNAME.OptionsColumn.AllowEdit = False
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 1
        Me.GNAME.Width = 200
        '
        'GAREA
        '
        Me.GAREA.Caption = "Area"
        Me.GAREA.FieldName = "AREA"
        Me.GAREA.Name = "GAREA"
        Me.GAREA.Visible = True
        Me.GAREA.VisibleIndex = 2
        Me.GAREA.Width = 200
        '
        'GCITY
        '
        Me.GCITY.Caption = "City"
        Me.GCITY.FieldName = "CITY"
        Me.GCITY.Name = "GCITY"
        Me.GCITY.OptionsColumn.AllowEdit = False
        Me.GCITY.Visible = True
        Me.GCITY.VisibleIndex = 3
        Me.GCITY.Width = 90
        '
        'GMOBILENO
        '
        Me.GMOBILENO.Caption = "Mobile No"
        Me.GMOBILENO.FieldName = "MOBILENO"
        Me.GMOBILENO.Name = "GMOBILENO"
        Me.GMOBILENO.Visible = True
        Me.GMOBILENO.VisibleIndex = 4
        Me.GMOBILENO.Width = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Auto CC"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTAUTOCC
        '
        Me.TXTAUTOCC.Location = New System.Drawing.Point(120, 205)
        Me.TXTAUTOCC.MaxLength = 10
        Me.TXTAUTOCC.Name = "TXTAUTOCC"
        Me.TXTAUTOCC.Size = New System.Drawing.Size(176, 23)
        Me.TXTAUTOCC.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Error Message"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTERRORMSG
        '
        Me.TXTERRORMSG.BackColor = System.Drawing.Color.Linen
        Me.TXTERRORMSG.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTERRORMSG.ForeColor = System.Drawing.Color.DimGray
        Me.TXTERRORMSG.Location = New System.Drawing.Point(120, 347)
        Me.TXTERRORMSG.Multiline = True
        Me.TXTERRORMSG.Name = "TXTERRORMSG"
        Me.TXTERRORMSG.ReadOnly = True
        Me.TXTERRORMSG.Size = New System.Drawing.Size(423, 112)
        Me.TXTERRORMSG.TabIndex = 15
        Me.TXTERRORMSG.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Message"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTOTHERNO5
        '
        Me.TXTOTHERNO5.Location = New System.Drawing.Point(380, 42)
        Me.TXTOTHERNO5.MaxLength = 10
        Me.TXTOTHERNO5.Name = "TXTOTHERNO5"
        Me.TXTOTHERNO5.Size = New System.Drawing.Size(176, 23)
        Me.TXTOTHERNO5.TabIndex = 9
        '
        'TXTOTHERNO4
        '
        Me.TXTOTHERNO4.Location = New System.Drawing.Point(380, 12)
        Me.TXTOTHERNO4.MaxLength = 10
        Me.TXTOTHERNO4.Name = "TXTOTHERNO4"
        Me.TXTOTHERNO4.Size = New System.Drawing.Size(176, 23)
        Me.TXTOTHERNO4.TabIndex = 7
        '
        'TXTOTHERNO3
        '
        Me.TXTOTHERNO3.Location = New System.Drawing.Point(120, 72)
        Me.TXTOTHERNO3.MaxLength = 10
        Me.TXTOTHERNO3.Name = "TXTOTHERNO3"
        Me.TXTOTHERNO3.Size = New System.Drawing.Size(176, 23)
        Me.TXTOTHERNO3.TabIndex = 5
        '
        'TXTOTHERNO2
        '
        Me.TXTOTHERNO2.Location = New System.Drawing.Point(120, 42)
        Me.TXTOTHERNO2.MaxLength = 10
        Me.TXTOTHERNO2.Name = "TXTOTHERNO2"
        Me.TXTOTHERNO2.Size = New System.Drawing.Size(176, 23)
        Me.TXTOTHERNO2.TabIndex = 3
        '
        'TXTOTHERNO1
        '
        Me.TXTOTHERNO1.Location = New System.Drawing.Point(120, 12)
        Me.TXTOTHERNO1.MaxLength = 10
        Me.TXTOTHERNO1.Name = "TXTOTHERNO1"
        Me.TXTOTHERNO1.Size = New System.Drawing.Size(176, 23)
        Me.TXTOTHERNO1.TabIndex = 1
        '
        'TXTMESSAGE
        '
        Me.TXTMESSAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMESSAGE.ForeColor = System.Drawing.Color.DimGray
        Me.TXTMESSAGE.Location = New System.Drawing.Point(120, 101)
        Me.TXTMESSAGE.Multiline = True
        Me.TXTMESSAGE.Name = "TXTMESSAGE"
        Me.TXTMESSAGE.Size = New System.Drawing.Size(423, 98)
        Me.TXTMESSAGE.TabIndex = 10
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.FlatAppearance.BorderSize = 0
        Me.cmdcancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.ForeColor = System.Drawing.Color.Black
        Me.cmdcancel.Location = New System.Drawing.Point(374, 263)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdcancel.TabIndex = 12
        Me.cmdcancel.Text = "E&xit"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'CMDSEND
        '
        Me.CMDSEND.BackColor = System.Drawing.Color.Transparent
        Me.CMDSEND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CMDSEND.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSEND.FlatAppearance.BorderSize = 0
        Me.CMDSEND.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSEND.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CMDSEND.Location = New System.Drawing.Point(288, 263)
        Me.CMDSEND.Name = "CMDSEND"
        Me.CMDSEND.Size = New System.Drawing.Size(80, 28)
        Me.CMDSEND.TabIndex = 11
        Me.CMDSEND.Text = "&Send"
        Me.CMDSEND.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CMDSEND.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Other Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Other Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Other Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(305, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Other Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Other Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTFILENAME
        '
        Me.TXTFILENAME.BackColor = System.Drawing.Color.Linen
        Me.TXTFILENAME.Location = New System.Drawing.Point(302, 205)
        Me.TXTFILENAME.MaxLength = 10
        Me.TXTFILENAME.Name = "TXTFILENAME"
        Me.TXTFILENAME.ReadOnly = True
        Me.TXTFILENAME.Size = New System.Drawing.Size(241, 23)
        Me.TXTFILENAME.TabIndex = 661
        Me.TXTFILENAME.TabStop = False
        Me.TXTFILENAME.Visible = False
        '
        'SendWhatsapp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 582)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SendWhatsapp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SendWhatsapp"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RBPATIENT As RadioButton
    Friend WithEvents CHKSELECTALL As CheckBox
    Friend WithEvents RBDOCTOR As RadioButton
    Private WithEvents gridbilldetails As DevExpress.XtraGrid.GridControl
    Private WithEvents gridbill As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCHK As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAREA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMOBILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTAUTOCC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTERRORMSG As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTOTHERNO5 As TextBox
    Friend WithEvents TXTOTHERNO4 As TextBox
    Friend WithEvents TXTOTHERNO3 As TextBox
    Friend WithEvents TXTOTHERNO2 As TextBox
    Friend WithEvents TXTOTHERNO1 As TextBox
    Friend WithEvents TXTMESSAGE As TextBox
    Friend WithEvents cmdcancel As Button
    Friend WithEvents CMDSEND As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTPATH As TextBox
    Friend WithEvents CMDUPLOAD As Button
    Friend WithEvents TXTFILENAME As TextBox
End Class
