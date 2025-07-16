<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPatient
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
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.cmdedit = New System.Windows.Forms.Button()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.gridbilldetails = New DevExpress.XtraGrid.GridControl()
        Me.gridbill = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GPATIENTNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFAMILY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GFIRSTNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GLASTNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCATEGORY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVILLAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTALUKA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDISTRICT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GUHLDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GADDRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMOBILE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GOCCUPATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCONSULTATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdcancel = New System.Windows.Forms.Button()
        Me.BlendPanel1.SuspendLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.cmdadd)
        Me.BlendPanel1.Controls.Add(Me.cmdedit)
        Me.BlendPanel1.Controls.Add(Me.CMDSAVE)
        Me.BlendPanel1.Controls.Add(Me.gridbilldetails)
        Me.BlendPanel1.Controls.Add(Me.cmdcancel)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1196, 599)
        Me.BlendPanel1.TabIndex = 6
        '
        'CMDOK
        '
        Me.CMDOK.BackColor = System.Drawing.Color.Transparent
        Me.CMDOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDOK.FlatAppearance.BorderSize = 0
        Me.CMDOK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDOK.ForeColor = System.Drawing.Color.Black
        Me.CMDOK.Location = New System.Drawing.Point(555, 546)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 505
        Me.CMDOK.Text = "&Select"
        Me.CMDOK.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.BackColor = System.Drawing.Color.Transparent
        Me.cmdadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdadd.FlatAppearance.BorderSize = 0
        Me.cmdadd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.Color.Black
        Me.cmdadd.Location = New System.Drawing.Point(988, 559)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(80, 28)
        Me.cmdadd.TabIndex = 504
        Me.cmdadd.Text = "&Add New"
        Me.cmdadd.UseVisualStyleBackColor = False
        Me.cmdadd.Visible = False
        '
        'cmdedit
        '
        Me.cmdedit.BackColor = System.Drawing.Color.Transparent
        Me.cmdedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdedit.FlatAppearance.BorderSize = 0
        Me.cmdedit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.ForeColor = System.Drawing.Color.Black
        Me.cmdedit.Location = New System.Drawing.Point(1097, 559)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(80, 28)
        Me.cmdedit.TabIndex = 503
        Me.cmdedit.Text = "&Edit"
        Me.cmdedit.UseVisualStyleBackColor = False
        Me.cmdedit.Visible = False
        '
        'CMDSAVE
        '
        Me.CMDSAVE.Location = New System.Drawing.Point(641, 546)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDSAVE.TabIndex = 502
        Me.CMDSAVE.Text = "&Refresh"
        Me.CMDSAVE.UseVisualStyleBackColor = True
        '
        'gridbilldetails
        '
        Me.gridbilldetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbilldetails.Location = New System.Drawing.Point(16, 14)
        Me.gridbilldetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gridbilldetails.MainView = Me.gridbill
        Me.gridbilldetails.Name = "gridbilldetails"
        Me.gridbilldetails.Size = New System.Drawing.Size(1179, 526)
        Me.gridbilldetails.TabIndex = 494
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GPATIENTNAME, Me.GFAMILY, Me.GFIRSTNAME, Me.GLASTNAME, Me.GAGE, Me.GSEX, Me.GCATEGORY, Me.GVILLAGE, Me.GTALUKA, Me.GDISTRICT, Me.GMRDNO, Me.GUHLDNO, Me.GADDRESS, Me.GMOBILE, Me.GOCCUPATION, Me.GCONSULTATION})
        Me.gridbill.GridControl = Me.gridbilldetails
        Me.gridbill.Name = "gridbill"
        Me.gridbill.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridbill.OptionsBehavior.Editable = False
        Me.gridbill.OptionsView.ColumnAutoWidth = False
        Me.gridbill.OptionsView.ShowAutoFilterRow = True
        '
        'GPATIENTNAME
        '
        Me.GPATIENTNAME.Caption = "Patient Name "
        Me.GPATIENTNAME.FieldName = "NAME"
        Me.GPATIENTNAME.Name = "GPATIENTNAME"
        Me.GPATIENTNAME.Visible = True
        Me.GPATIENTNAME.VisibleIndex = 0
        Me.GPATIENTNAME.Width = 138
        '
        'GFAMILY
        '
        Me.GFAMILY.Caption = "Head Of Family"
        Me.GFAMILY.FieldName = "HOF"
        Me.GFAMILY.Name = "GFAMILY"
        Me.GFAMILY.Visible = True
        Me.GFAMILY.VisibleIndex = 1
        Me.GFAMILY.Width = 114
        '
        'GFIRSTNAME
        '
        Me.GFIRSTNAME.Caption = "First Name "
        Me.GFIRSTNAME.FieldName = "FIRSTNAME"
        Me.GFIRSTNAME.Name = "GFIRSTNAME"
        Me.GFIRSTNAME.Visible = True
        Me.GFIRSTNAME.VisibleIndex = 2
        Me.GFIRSTNAME.Width = 144
        '
        'GLASTNAME
        '
        Me.GLASTNAME.Caption = "Last Name "
        Me.GLASTNAME.FieldName = "LASTNAME"
        Me.GLASTNAME.Name = "GLASTNAME"
        Me.GLASTNAME.Visible = True
        Me.GLASTNAME.VisibleIndex = 3
        Me.GLASTNAME.Width = 125
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 4
        Me.GAGE.Width = 59
        '
        'GSEX
        '
        Me.GSEX.Caption = "Sex "
        Me.GSEX.FieldName = "SEX"
        Me.GSEX.Name = "GSEX"
        Me.GSEX.Visible = True
        Me.GSEX.VisibleIndex = 5
        Me.GSEX.Width = 49
        '
        'GCATEGORY
        '
        Me.GCATEGORY.Caption = "Category"
        Me.GCATEGORY.FieldName = "CATEGORY"
        Me.GCATEGORY.Name = "GCATEGORY"
        Me.GCATEGORY.Visible = True
        Me.GCATEGORY.VisibleIndex = 6
        Me.GCATEGORY.Width = 90
        '
        'GVILLAGE
        '
        Me.GVILLAGE.Caption = "Village"
        Me.GVILLAGE.FieldName = "VILLAGE"
        Me.GVILLAGE.Name = "GVILLAGE"
        '
        'GTALUKA
        '
        Me.GTALUKA.Caption = "Taluka"
        Me.GTALUKA.FieldName = "TALUKA"
        Me.GTALUKA.Name = "GTALUKA"
        Me.GTALUKA.Width = 40
        '
        'GDISTRICT
        '
        Me.GDISTRICT.Caption = "District"
        Me.GDISTRICT.FieldName = "DISTRICT"
        Me.GDISTRICT.Name = "GDISTRICT"
        Me.GDISTRICT.Visible = True
        Me.GDISTRICT.VisibleIndex = 7
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD NO"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 8
        Me.GMRDNO.Width = 52
        '
        'GUHLDNO
        '
        Me.GUHLDNO.Caption = "UHLD NO"
        Me.GUHLDNO.FieldName = "UHLDNO"
        Me.GUHLDNO.Name = "GUHLDNO"
        Me.GUHLDNO.Visible = True
        Me.GUHLDNO.VisibleIndex = 9
        Me.GUHLDNO.Width = 90
        '
        'GADDRESS
        '
        Me.GADDRESS.Caption = "Address"
        Me.GADDRESS.FieldName = "ADDRESS"
        Me.GADDRESS.Name = "GADDRESS"
        Me.GADDRESS.Visible = True
        Me.GADDRESS.VisibleIndex = 10
        Me.GADDRESS.Width = 105
        '
        'GMOBILE
        '
        Me.GMOBILE.Caption = "Mobile"
        Me.GMOBILE.FieldName = "MOBILE"
        Me.GMOBILE.Name = "GMOBILE"
        Me.GMOBILE.Visible = True
        Me.GMOBILE.VisibleIndex = 11
        Me.GMOBILE.Width = 97
        '
        'GOCCUPATION
        '
        Me.GOCCUPATION.Caption = "Occupation"
        Me.GOCCUPATION.FieldName = "OCCUPATION"
        Me.GOCCUPATION.Name = "GOCCUPATION"
        Me.GOCCUPATION.Visible = True
        Me.GOCCUPATION.VisibleIndex = 12
        Me.GOCCUPATION.Width = 98
        '
        'GCONSULTATION
        '
        Me.GCONSULTATION.Caption = "Free Consultation"
        Me.GCONSULTATION.FieldName = "CHECKCONSULTATION"
        Me.GCONSULTATION.Name = "GCONSULTATION"
        Me.GCONSULTATION.Visible = True
        Me.GCONSULTATION.VisibleIndex = 13
        Me.GCONSULTATION.Width = 90
        '
        'cmdcancel
        '
        Me.cmdcancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdcancel.FlatAppearance.BorderSize = 0
        Me.cmdcancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancel.ForeColor = System.Drawing.Color.Black
        Me.cmdcancel.Location = New System.Drawing.Point(727, 546)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(80, 28)
        Me.cmdcancel.TabIndex = 316
        Me.cmdcancel.Text = "&Exit"
        Me.cmdcancel.UseVisualStyleBackColor = False
        '
        'SelectPatient
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1196, 599)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SelectPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SelectPatient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents cmdadd As Button
    Friend WithEvents cmdedit As Button
    Friend WithEvents CMDSAVE As Button
    Private WithEvents gridbilldetails As DevExpress.XtraGrid.GridControl
    Private WithEvents gridbill As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GPATIENTNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GFAMILY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GFIRSTNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GLASTNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCATEGORY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVILLAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTALUKA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDISTRICT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GUHLDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GADDRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMOBILE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GOCCUPATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCONSULTATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdcancel As Button
    Friend WithEvents CMDOK As Button
End Class
