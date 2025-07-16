<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDetails
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
        Me.TXTOCCUPATION = New System.Windows.Forms.TextBox()
        Me.LBLOCCUPATION = New System.Windows.Forms.Label()
        Me.TXTMOBILE = New System.Windows.Forms.TextBox()
        Me.TXTLASTNAME = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.TXTDISTRICT = New System.Windows.Forms.TextBox()
        Me.TXTTALUKA = New System.Windows.Forms.TextBox()
        Me.TXTVILLAGE = New System.Windows.Forms.TextBox()
        Me.TXTCATEGORY = New System.Windows.Forms.TextBox()
        Me.TXTSEX = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTPHOTOIMGPATH = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTADDRESS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBPHOTO = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLVILLAGE = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PBEXCEL = New System.Windows.Forms.PictureBox()
        Me.GRIDNAME = New DevExpress.XtraGrid.GridControl()
        Me.GRIDPATIENT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GUHLDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GPATIENTID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CMDREFRESH = New System.Windows.Forms.Button()
        Me.CMDADD = New System.Windows.Forms.Button()
        Me.CMDEDIT = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BlendPanel1.SuspendLayout()
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDPATIENT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.TXTOCCUPATION)
        Me.BlendPanel1.Controls.Add(Me.LBLOCCUPATION)
        Me.BlendPanel1.Controls.Add(Me.TXTMOBILE)
        Me.BlendPanel1.Controls.Add(Me.TXTLASTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTFIRSTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTDISTRICT)
        Me.BlendPanel1.Controls.Add(Me.TXTTALUKA)
        Me.BlendPanel1.Controls.Add(Me.TXTVILLAGE)
        Me.BlendPanel1.Controls.Add(Me.TXTCATEGORY)
        Me.BlendPanel1.Controls.Add(Me.TXTSEX)
        Me.BlendPanel1.Controls.Add(Me.TXTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTPHOTOIMGPATH)
        Me.BlendPanel1.Controls.Add(Me.Label13)
        Me.BlendPanel1.Controls.Add(Me.Label12)
        Me.BlendPanel1.Controls.Add(Me.TXTADDRESS)
        Me.BlendPanel1.Controls.Add(Me.Label1)
        Me.BlendPanel1.Controls.Add(Me.PBPHOTO)
        Me.BlendPanel1.Controls.Add(Me.Label10)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.LBLVILLAGE)
        Me.BlendPanel1.Controls.Add(Me.Label6)
        Me.BlendPanel1.Controls.Add(Me.Label4)
        Me.BlendPanel1.Controls.Add(Me.Label15)
        Me.BlendPanel1.Controls.Add(Me.TXTAGE)
        Me.BlendPanel1.Controls.Add(Me.Label16)
        Me.BlendPanel1.Controls.Add(Me.Label17)
        Me.BlendPanel1.Controls.Add(Me.Label18)
        Me.BlendPanel1.Controls.Add(Me.PBEXCEL)
        Me.BlendPanel1.Controls.Add(Me.GRIDNAME)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.CMDADD)
        Me.BlendPanel1.Controls.Add(Me.CMDEDIT)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.Label21)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(967, 605)
        Me.BlendPanel1.TabIndex = 0
        '
        'TXTOCCUPATION
        '
        Me.TXTOCCUPATION.BackColor = System.Drawing.Color.Linen
        Me.TXTOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTOCCUPATION.Location = New System.Drawing.Point(717, 396)
        Me.TXTOCCUPATION.MaxLength = 100
        Me.TXTOCCUPATION.Name = "TXTOCCUPATION"
        Me.TXTOCCUPATION.Size = New System.Drawing.Size(233, 23)
        Me.TXTOCCUPATION.TabIndex = 897
        Me.TXTOCCUPATION.TabStop = False
        '
        'LBLOCCUPATION
        '
        Me.LBLOCCUPATION.AutoSize = True
        Me.LBLOCCUPATION.BackColor = System.Drawing.Color.Transparent
        Me.LBLOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOCCUPATION.Location = New System.Drawing.Point(644, 400)
        Me.LBLOCCUPATION.Name = "LBLOCCUPATION"
        Me.LBLOCCUPATION.Size = New System.Drawing.Size(70, 15)
        Me.LBLOCCUPATION.TabIndex = 896
        Me.LBLOCCUPATION.Text = "Occupation"
        '
        'TXTMOBILE
        '
        Me.TXTMOBILE.BackColor = System.Drawing.Color.Linen
        Me.TXTMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOBILE.Location = New System.Drawing.Point(717, 173)
        Me.TXTMOBILE.MaxLength = 100
        Me.TXTMOBILE.Name = "TXTMOBILE"
        Me.TXTMOBILE.Size = New System.Drawing.Size(233, 23)
        Me.TXTMOBILE.TabIndex = 895
        Me.TXTMOBILE.TabStop = False
        '
        'TXTLASTNAME
        '
        Me.TXTLASTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTLASTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLASTNAME.Location = New System.Drawing.Point(717, 115)
        Me.TXTLASTNAME.MaxLength = 100
        Me.TXTLASTNAME.Name = "TXTLASTNAME"
        Me.TXTLASTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTLASTNAME.TabIndex = 894
        Me.TXTLASTNAME.TabStop = False
        '
        'TXTFIRSTNAME
        '
        Me.TXTFIRSTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTFIRSTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFIRSTNAME.Location = New System.Drawing.Point(717, 86)
        Me.TXTFIRSTNAME.MaxLength = 100
        Me.TXTFIRSTNAME.Name = "TXTFIRSTNAME"
        Me.TXTFIRSTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTFIRSTNAME.TabIndex = 893
        Me.TXTFIRSTNAME.TabStop = False
        '
        'TXTDISTRICT
        '
        Me.TXTDISTRICT.BackColor = System.Drawing.Color.Linen
        Me.TXTDISTRICT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDISTRICT.Location = New System.Drawing.Point(717, 289)
        Me.TXTDISTRICT.MaxLength = 100
        Me.TXTDISTRICT.Name = "TXTDISTRICT"
        Me.TXTDISTRICT.Size = New System.Drawing.Size(233, 23)
        Me.TXTDISTRICT.TabIndex = 892
        Me.TXTDISTRICT.TabStop = False
        '
        'TXTTALUKA
        '
        Me.TXTTALUKA.BackColor = System.Drawing.Color.Linen
        Me.TXTTALUKA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTALUKA.Location = New System.Drawing.Point(717, 260)
        Me.TXTTALUKA.MaxLength = 100
        Me.TXTTALUKA.Name = "TXTTALUKA"
        Me.TXTTALUKA.Size = New System.Drawing.Size(233, 23)
        Me.TXTTALUKA.TabIndex = 891
        Me.TXTTALUKA.TabStop = False
        '
        'TXTVILLAGE
        '
        Me.TXTVILLAGE.BackColor = System.Drawing.Color.Linen
        Me.TXTVILLAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTVILLAGE.Location = New System.Drawing.Point(717, 231)
        Me.TXTVILLAGE.MaxLength = 100
        Me.TXTVILLAGE.Name = "TXTVILLAGE"
        Me.TXTVILLAGE.Size = New System.Drawing.Size(233, 23)
        Me.TXTVILLAGE.TabIndex = 890
        Me.TXTVILLAGE.TabStop = False
        '
        'TXTCATEGORY
        '
        Me.TXTCATEGORY.BackColor = System.Drawing.Color.Linen
        Me.TXTCATEGORY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCATEGORY.Location = New System.Drawing.Point(717, 202)
        Me.TXTCATEGORY.MaxLength = 100
        Me.TXTCATEGORY.Name = "TXTCATEGORY"
        Me.TXTCATEGORY.Size = New System.Drawing.Size(233, 23)
        Me.TXTCATEGORY.TabIndex = 889
        Me.TXTCATEGORY.TabStop = False
        '
        'TXTSEX
        '
        Me.TXTSEX.BackColor = System.Drawing.Color.Linen
        Me.TXTSEX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEX.Location = New System.Drawing.Point(870, 143)
        Me.TXTSEX.MaxLength = 3
        Me.TXTSEX.Name = "TXTSEX"
        Me.TXTSEX.Size = New System.Drawing.Size(80, 23)
        Me.TXTSEX.TabIndex = 888
        Me.TXTSEX.TabStop = False
        '
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.Location = New System.Drawing.Point(717, 56)
        Me.TXTNAME.MaxLength = 100
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTNAME.TabIndex = 887
        Me.TXTNAME.TabStop = False
        '
        'TXTPHOTOIMGPATH
        '
        Me.TXTPHOTOIMGPATH.BackColor = System.Drawing.Color.White
        Me.TXTPHOTOIMGPATH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPHOTOIMGPATH.ForeColor = System.Drawing.Color.Black
        Me.TXTPHOTOIMGPATH.Location = New System.Drawing.Point(692, 462)
        Me.TXTPHOTOIMGPATH.Name = "TXTPHOTOIMGPATH"
        Me.TXTPHOTOIMGPATH.Size = New System.Drawing.Size(22, 23)
        Me.TXTPHOTOIMGPATH.TabIndex = 886
        Me.TXTPHOTOIMGPATH.TabStop = False
        Me.TXTPHOTOIMGPATH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXTPHOTOIMGPATH.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(668, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 885
        Me.Label13.Text = "Mobile"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(663, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 884
        Me.Label12.Text = "Address"
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.BackColor = System.Drawing.Color.Linen
        Me.TXTADDRESS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTADDRESS.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS.Location = New System.Drawing.Point(717, 318)
        Me.TXTADDRESS.Multiline = True
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.Size = New System.Drawing.Size(233, 72)
        Me.TXTADDRESS.TabIndex = 867
        Me.TXTADDRESS.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(643, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 883
        Me.Label1.Text = "Photograph"
        '
        'PBPHOTO
        '
        Me.PBPHOTO.BackColor = System.Drawing.Color.White
        Me.PBPHOTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBPHOTO.ErrorImage = Nothing
        Me.PBPHOTO.InitialImage = Nothing
        Me.PBPHOTO.Location = New System.Drawing.Point(717, 447)
        Me.PBPHOTO.Name = "PBPHOTO"
        Me.PBPHOTO.Size = New System.Drawing.Size(142, 145)
        Me.PBPHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPHOTO.TabIndex = 882
        Me.PBPHOTO.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(666, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 15)
        Me.Label10.TabIndex = 881
        Me.Label10.Text = "District"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(843, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 880
        Me.Label2.Text = "Sex"
        '
        'LBLVILLAGE
        '
        Me.LBLVILLAGE.AutoSize = True
        Me.LBLVILLAGE.BackColor = System.Drawing.Color.Transparent
        Me.LBLVILLAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVILLAGE.Location = New System.Drawing.Point(669, 235)
        Me.LBLVILLAGE.Name = "LBLVILLAGE"
        Me.LBLVILLAGE.Size = New System.Drawing.Size(45, 15)
        Me.LBLVILLAGE.TabIndex = 879
        Me.LBLVILLAGE.Text = "Village"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(651, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 877
        Me.Label6.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(671, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 875
        Me.Label4.Text = "Taluka"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(659, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 15)
        Me.Label15.TabIndex = 874
        Me.Label15.Text = "Category"
        '
        'TXTAGE
        '
        Me.TXTAGE.BackColor = System.Drawing.Color.Linen
        Me.TXTAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAGE.Location = New System.Drawing.Point(717, 144)
        Me.TXTAGE.MaxLength = 3
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(72, 23)
        Me.TXTAGE.TabIndex = 861
        Me.TXTAGE.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(688, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 15)
        Me.Label16.TabIndex = 873
        Me.Label16.Text = "Age"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(648, 90)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 15)
        Me.Label17.TabIndex = 872
        Me.Label17.Text = "First Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(635, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 15)
        Me.Label18.TabIndex = 871
        Me.Label18.Text = "Patient Name"
        '
        'PBEXCEL
        '
        Me.PBEXCEL.Image = Global.TRISHALADEVI.My.Resources.Resources.Excel_icon
        Me.PBEXCEL.Location = New System.Drawing.Point(750, 12)
        Me.PBEXCEL.Name = "PBEXCEL"
        Me.PBEXCEL.Size = New System.Drawing.Size(25, 25)
        Me.PBEXCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEXCEL.TabIndex = 241
        Me.PBEXCEL.TabStop = False
        '
        'GRIDNAME
        '
        Me.GRIDNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDNAME.Location = New System.Drawing.Point(16, 33)
        Me.GRIDNAME.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GRIDNAME.MainView = Me.GRIDPATIENT
        Me.GRIDNAME.Name = "GRIDNAME"
        Me.GRIDNAME.Size = New System.Drawing.Size(613, 509)
        Me.GRIDNAME.TabIndex = 0
        Me.GRIDNAME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRIDPATIENT})
        '
        'GRIDPATIENT
        '
        Me.GRIDPATIENT.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDPATIENT.Appearance.Row.Options.UseFont = True
        Me.GRIDPATIENT.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GNAME, Me.GMRDNO, Me.GUHLDNO, Me.GPATIENTID})
        Me.GRIDPATIENT.GridControl = Me.GRIDNAME
        Me.GRIDPATIENT.Name = "GRIDPATIENT"
        Me.GRIDPATIENT.OptionsBehavior.AllowIncrementalSearch = True
        Me.GRIDPATIENT.OptionsBehavior.Editable = False
        Me.GRIDPATIENT.OptionsCustomization.AllowColumnMoving = False
        Me.GRIDPATIENT.OptionsCustomization.AllowGroup = False
        Me.GRIDPATIENT.OptionsView.ColumnAutoWidth = False
        Me.GRIDPATIENT.OptionsView.ShowAutoFilterRow = True
        Me.GRIDPATIENT.OptionsView.ShowGroupPanel = False
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 0
        Me.GNAME.Width = 275
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 1
        Me.GMRDNO.Width = 150
        '
        'GUHLDNO
        '
        Me.GUHLDNO.Caption = "UHLD No"
        Me.GUHLDNO.FieldName = "UHLDNO"
        Me.GUHLDNO.Name = "GUHLDNO"
        Me.GUHLDNO.Visible = True
        Me.GUHLDNO.VisibleIndex = 2
        Me.GUHLDNO.Width = 150
        '
        'GPATIENTID
        '
        Me.GPATIENTID.Caption = "Patient ID"
        Me.GPATIENTID.FieldName = "PATIENTID"
        Me.GPATIENTID.Name = "GPATIENTID"
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(781, 12)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 1
        Me.CMDREFRESH.Text = "&Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'CMDADD
        '
        Me.CMDADD.BackColor = System.Drawing.Color.Transparent
        Me.CMDADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDADD.FlatAppearance.BorderSize = 0
        Me.CMDADD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADD.ForeColor = System.Drawing.Color.Black
        Me.CMDADD.Location = New System.Drawing.Point(400, 560)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(80, 28)
        Me.CMDADD.TabIndex = 3
        Me.CMDADD.Text = "&Add New"
        Me.CMDADD.UseVisualStyleBackColor = False
        '
        'CMDEDIT
        '
        Me.CMDEDIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEDIT.FlatAppearance.BorderSize = 0
        Me.CMDEDIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEDIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEDIT.Location = New System.Drawing.Point(870, 12)
        Me.CMDEDIT.Name = "CMDEDIT"
        Me.CMDEDIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEDIT.TabIndex = 2
        Me.CMDEDIT.Text = "E&dit"
        Me.CMDEDIT.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(486, 560)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 4
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(19, 13)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(171, 14)
        Me.Label21.TabIndex = 232
        Me.Label21.Text = "Double Click on Patient to Edit"
        '
        'PatientDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(967, 605)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "PatientDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Patient Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDPATIENT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents PBEXCEL As System.Windows.Forms.PictureBox
    Private WithEvents GRIDNAME As DevExpress.XtraGrid.GridControl
    Private WithEvents GRIDPATIENT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CMDREFRESH As System.Windows.Forms.Button
    Friend WithEvents CMDADD As System.Windows.Forms.Button
    Friend WithEvents CMDEDIT As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBPHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLVILLAGE As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXTAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TXTPHOTOIMGPATH As System.Windows.Forms.TextBox
    Friend WithEvents TXTMOBILE As System.Windows.Forms.TextBox
    Friend WithEvents TXTLASTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTFIRSTNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTDISTRICT As System.Windows.Forms.TextBox
    Friend WithEvents TXTTALUKA As System.Windows.Forms.TextBox
    Friend WithEvents TXTVILLAGE As System.Windows.Forms.TextBox
    Friend WithEvents TXTCATEGORY As System.Windows.Forms.TextBox
    Friend WithEvents TXTSEX As System.Windows.Forms.TextBox
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents GUHLDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPATIENTID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TXTOCCUPATION As TextBox
    Friend WithEvents LBLOCCUPATION As Label
End Class
