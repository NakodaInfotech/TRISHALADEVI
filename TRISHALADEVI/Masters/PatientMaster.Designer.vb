<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientMaster
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientMaster))
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.CMBOCCUPATION = New System.Windows.Forms.ComboBox()
        Me.CHKCONSULTATION = New System.Windows.Forms.CheckBox()
        Me.LBLOCCUPATION = New System.Windows.Forms.Label()
        Me.TXTHOF = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CMDUHLD2PRINT = New System.Windows.Forms.Button()
        Me.CMDUHLD1PRINT = New System.Windows.Forms.Button()
        Me.CMDPHOTOPRINT = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMDDOC2REMOVE = New System.Windows.Forms.Button()
        Me.CMDDOC2 = New System.Windows.Forms.Button()
        Me.CMDDOC2VIEW = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PBDOC2 = New System.Windows.Forms.PictureBox()
        Me.CMDDOC1REMOVE = New System.Windows.Forms.Button()
        Me.CMDDOC1 = New System.Windows.Forms.Button()
        Me.CMDDOC1VIEW = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PBDOC1 = New System.Windows.Forms.PictureBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTMOBILE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTADDRESS = New System.Windows.Forms.TextBox()
        Me.CMDPHOTOREMOVE = New System.Windows.Forms.Button()
        Me.CMDPHOTOUPLOAD = New System.Windows.Forms.Button()
        Me.CMDPHOTOVIEW = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PBPHOTO = New System.Windows.Forms.PictureBox()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.CMBDISTRICT = New System.Windows.Forms.ComboBox()
        Me.CMBTALUKA = New System.Windows.Forms.ComboBox()
        Me.CMBVILLAGE = New System.Windows.Forms.ComboBox()
        Me.CMBSEX = New System.Windows.Forms.ComboBox()
        Me.LBLDISTRICT = New System.Windows.Forms.Label()
        Me.CMBCATEGORY = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLVILLAGE = New System.Windows.Forms.Label()
        Me.TXTMRDNO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTLASTNAME = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTUHLDNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BlendPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PBDOC2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDOC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.CMBOCCUPATION)
        Me.BlendPanel1.Controls.Add(Me.CHKCONSULTATION)
        Me.BlendPanel1.Controls.Add(Me.LBLOCCUPATION)
        Me.BlendPanel1.Controls.Add(Me.TXTHOF)
        Me.BlendPanel1.Controls.Add(Me.Label17)
        Me.BlendPanel1.Controls.Add(Me.CMDUHLD2PRINT)
        Me.BlendPanel1.Controls.Add(Me.CMDUHLD1PRINT)
        Me.BlendPanel1.Controls.Add(Me.CMDPHOTOPRINT)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC2REMOVE)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC2)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC2VIEW)
        Me.BlendPanel1.Controls.Add(Me.Label16)
        Me.BlendPanel1.Controls.Add(Me.PBDOC2)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC1REMOVE)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC1)
        Me.BlendPanel1.Controls.Add(Me.CMDDOC1VIEW)
        Me.BlendPanel1.Controls.Add(Me.Label14)
        Me.BlendPanel1.Controls.Add(Me.PBDOC1)
        Me.BlendPanel1.Controls.Add(Me.TXTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTMOBILE)
        Me.BlendPanel1.Controls.Add(Me.Label13)
        Me.BlendPanel1.Controls.Add(Me.Label12)
        Me.BlendPanel1.Controls.Add(Me.TXTADDRESS)
        Me.BlendPanel1.Controls.Add(Me.CMDPHOTOREMOVE)
        Me.BlendPanel1.Controls.Add(Me.CMDPHOTOUPLOAD)
        Me.BlendPanel1.Controls.Add(Me.CMDPHOTOVIEW)
        Me.BlendPanel1.Controls.Add(Me.Label11)
        Me.BlendPanel1.Controls.Add(Me.PBPHOTO)
        Me.BlendPanel1.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel1.Controls.Add(Me.CMBDISTRICT)
        Me.BlendPanel1.Controls.Add(Me.CMBTALUKA)
        Me.BlendPanel1.Controls.Add(Me.CMBVILLAGE)
        Me.BlendPanel1.Controls.Add(Me.CMBSEX)
        Me.BlendPanel1.Controls.Add(Me.LBLDISTRICT)
        Me.BlendPanel1.Controls.Add(Me.CMBCATEGORY)
        Me.BlendPanel1.Controls.Add(Me.Label9)
        Me.BlendPanel1.Controls.Add(Me.LBLVILLAGE)
        Me.BlendPanel1.Controls.Add(Me.TXTMRDNO)
        Me.BlendPanel1.Controls.Add(Me.Label7)
        Me.BlendPanel1.Controls.Add(Me.TXTLASTNAME)
        Me.BlendPanel1.Controls.Add(Me.Label6)
        Me.BlendPanel1.Controls.Add(Me.TXTUHLDNO)
        Me.BlendPanel1.Controls.Add(Me.Label5)
        Me.BlendPanel1.Controls.Add(Me.Label4)
        Me.BlendPanel1.Controls.Add(Me.Label3)
        Me.BlendPanel1.Controls.Add(Me.TXTAGE)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.TXTFIRSTNAME)
        Me.BlendPanel1.Controls.Add(Me.Label1)
        Me.BlendPanel1.Controls.Add(Me.Label15)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(666, 609)
        Me.BlendPanel1.TabIndex = 0
        '
        'CMBOCCUPATION
        '
        Me.CMBOCCUPATION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBOCCUPATION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBOCCUPATION.BackColor = System.Drawing.Color.White
        Me.CMBOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBOCCUPATION.FormattingEnabled = True
        Me.CMBOCCUPATION.Items.AddRange(New Object() {""})
        Me.CMBOCCUPATION.Location = New System.Drawing.Point(124, 470)
        Me.CMBOCCUPATION.MaxLength = 100
        Me.CMBOCCUPATION.Name = "CMBOCCUPATION"
        Me.CMBOCCUPATION.Size = New System.Drawing.Size(233, 23)
        Me.CMBOCCUPATION.TabIndex = 14
        '
        'CHKCONSULTATION
        '
        Me.CHKCONSULTATION.AutoSize = True
        Me.CHKCONSULTATION.BackColor = System.Drawing.Color.Transparent
        Me.CHKCONSULTATION.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCONSULTATION.Location = New System.Drawing.Point(124, 499)
        Me.CHKCONSULTATION.Name = "CHKCONSULTATION"
        Me.CHKCONSULTATION.Size = New System.Drawing.Size(122, 18)
        Me.CHKCONSULTATION.TabIndex = 15
        Me.CHKCONSULTATION.Text = "Free Consultation"
        Me.CHKCONSULTATION.UseVisualStyleBackColor = False
        '
        'LBLOCCUPATION
        '
        Me.LBLOCCUPATION.AutoSize = True
        Me.LBLOCCUPATION.BackColor = System.Drawing.Color.Transparent
        Me.LBLOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOCCUPATION.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLOCCUPATION.Location = New System.Drawing.Point(53, 474)
        Me.LBLOCCUPATION.Name = "LBLOCCUPATION"
        Me.LBLOCCUPATION.Size = New System.Drawing.Size(67, 14)
        Me.LBLOCCUPATION.TabIndex = 50
        Me.LBLOCCUPATION.Text = "Occupation"
        '
        'TXTHOF
        '
        Me.TXTHOF.BackColor = System.Drawing.Color.White
        Me.TXTHOF.Location = New System.Drawing.Point(124, 73)
        Me.TXTHOF.MaxLength = 100
        Me.TXTHOF.Name = "TXTHOF"
        Me.TXTHOF.Size = New System.Drawing.Size(233, 23)
        Me.TXTHOF.TabIndex = 1
        Me.TXTHOF.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 15)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Head Of Family"
        '
        'CMDUHLD2PRINT
        '
        Me.CMDUHLD2PRINT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDUHLD2PRINT.Location = New System.Drawing.Point(541, 519)
        Me.CMDUHLD2PRINT.Name = "CMDUHLD2PRINT"
        Me.CMDUHLD2PRINT.Size = New System.Drawing.Size(80, 28)
        Me.CMDUHLD2PRINT.TabIndex = 34
        Me.CMDUHLD2PRINT.Text = "Print"
        Me.CMDUHLD2PRINT.UseVisualStyleBackColor = True
        '
        'CMDUHLD1PRINT
        '
        Me.CMDUHLD1PRINT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDUHLD1PRINT.Location = New System.Drawing.Point(541, 345)
        Me.CMDUHLD1PRINT.Name = "CMDUHLD1PRINT"
        Me.CMDUHLD1PRINT.Size = New System.Drawing.Size(80, 28)
        Me.CMDUHLD1PRINT.TabIndex = 30
        Me.CMDUHLD1PRINT.Text = "Print"
        Me.CMDUHLD1PRINT.UseVisualStyleBackColor = True
        '
        'CMDPHOTOPRINT
        '
        Me.CMDPHOTOPRINT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPHOTOPRINT.Location = New System.Drawing.Point(541, 172)
        Me.CMDPHOTOPRINT.Name = "CMDPHOTOPRINT"
        Me.CMDPHOTOPRINT.Size = New System.Drawing.Size(80, 28)
        Me.CMDPHOTOPRINT.TabIndex = 19
        Me.CMDPHOTOPRINT.Text = "Print"
        Me.CMDPHOTOPRINT.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.TOOLDELETE, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(666, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'TOOLDELETE
        '
        Me.TOOLDELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TOOLDELETE.Image = CType(resources.GetObject("TOOLDELETE.Image"), System.Drawing.Image)
        Me.TOOLDELETE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOOLDELETE.Name = "TOOLDELETE"
        Me.TOOLDELETE.Size = New System.Drawing.Size(23, 22)
        Me.TOOLDELETE.Text = "&Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CMDDOC2REMOVE
        '
        Me.CMDDOC2REMOVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC2REMOVE.Location = New System.Drawing.Point(541, 451)
        Me.CMDDOC2REMOVE.Name = "CMDDOC2REMOVE"
        Me.CMDDOC2REMOVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC2REMOVE.TabIndex = 32
        Me.CMDDOC2REMOVE.Text = "Remove"
        Me.CMDDOC2REMOVE.UseVisualStyleBackColor = True
        '
        'CMDDOC2
        '
        Me.CMDDOC2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC2.Location = New System.Drawing.Point(541, 417)
        Me.CMDDOC2.Name = "CMDDOC2"
        Me.CMDDOC2.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC2.TabIndex = 31
        Me.CMDDOC2.Text = "Upload"
        Me.CMDDOC2.UseVisualStyleBackColor = True
        '
        'CMDDOC2VIEW
        '
        Me.CMDDOC2VIEW.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC2VIEW.Location = New System.Drawing.Point(541, 485)
        Me.CMDDOC2VIEW.Name = "CMDDOC2VIEW"
        Me.CMDDOC2VIEW.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC2VIEW.TabIndex = 33
        Me.CMDDOC2VIEW.Text = "View"
        Me.CMDDOC2VIEW.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(390, 391)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 15)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "UHLD Upload Document2"
        '
        'PBDOC2
        '
        Me.PBDOC2.BackColor = System.Drawing.Color.Transparent
        Me.PBDOC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBDOC2.ErrorImage = Nothing
        Me.PBDOC2.InitialImage = Nothing
        Me.PBDOC2.Location = New System.Drawing.Point(393, 410)
        Me.PBDOC2.Name = "PBDOC2"
        Me.PBDOC2.Size = New System.Drawing.Size(142, 145)
        Me.PBDOC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDOC2.TabIndex = 838
        Me.PBDOC2.TabStop = False
        '
        'CMDDOC1REMOVE
        '
        Me.CMDDOC1REMOVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC1REMOVE.Location = New System.Drawing.Point(541, 277)
        Me.CMDDOC1REMOVE.Name = "CMDDOC1REMOVE"
        Me.CMDDOC1REMOVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC1REMOVE.TabIndex = 28
        Me.CMDDOC1REMOVE.Text = "Remove"
        Me.CMDDOC1REMOVE.UseVisualStyleBackColor = True
        '
        'CMDDOC1
        '
        Me.CMDDOC1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC1.Location = New System.Drawing.Point(541, 243)
        Me.CMDDOC1.Name = "CMDDOC1"
        Me.CMDDOC1.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC1.TabIndex = 27
        Me.CMDDOC1.Text = "Upload"
        Me.CMDDOC1.UseVisualStyleBackColor = True
        '
        'CMDDOC1VIEW
        '
        Me.CMDDOC1VIEW.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDOC1VIEW.Location = New System.Drawing.Point(541, 311)
        Me.CMDDOC1VIEW.Name = "CMDDOC1VIEW"
        Me.CMDDOC1VIEW.Size = New System.Drawing.Size(80, 28)
        Me.CMDDOC1VIEW.TabIndex = 29
        Me.CMDDOC1VIEW.Text = "View"
        Me.CMDDOC1VIEW.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(390, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 15)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "UHLD Upload Document1"
        '
        'PBDOC1
        '
        Me.PBDOC1.BackColor = System.Drawing.Color.Transparent
        Me.PBDOC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBDOC1.ErrorImage = Nothing
        Me.PBDOC1.InitialImage = Nothing
        Me.PBDOC1.Location = New System.Drawing.Point(393, 234)
        Me.PBDOC1.Name = "PBDOC1"
        Me.PBDOC1.Size = New System.Drawing.Size(142, 145)
        Me.PBDOC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBDOC1.TabIndex = 833
        Me.PBDOC1.TabStop = False
        '
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTNAME.Location = New System.Drawing.Point(124, 44)
        Me.TXTNAME.MaxLength = 100
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTNAME.TabIndex = 0
        '
        'TXTMOBILE
        '
        Me.TXTMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOBILE.Location = New System.Drawing.Point(124, 441)
        Me.TXTMOBILE.MaxLength = 25
        Me.TXTMOBILE.Name = "TXTMOBILE"
        Me.TXTMOBILE.Size = New System.Drawing.Size(233, 23)
        Me.TXTMOBILE.TabIndex = 13
        Me.TXTMOBILE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(74, 445)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 14)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Mobile"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(69, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Address"
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.BackColor = System.Drawing.SystemColors.Window
        Me.TXTADDRESS.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS.Location = New System.Drawing.Point(124, 363)
        Me.TXTADDRESS.MaxLength = 200
        Me.TXTADDRESS.Multiline = True
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.Size = New System.Drawing.Size(233, 72)
        Me.TXTADDRESS.TabIndex = 12
        Me.TXTADDRESS.TabStop = False
        '
        'CMDPHOTOREMOVE
        '
        Me.CMDPHOTOREMOVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPHOTOREMOVE.Location = New System.Drawing.Point(541, 104)
        Me.CMDPHOTOREMOVE.Name = "CMDPHOTOREMOVE"
        Me.CMDPHOTOREMOVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDPHOTOREMOVE.TabIndex = 17
        Me.CMDPHOTOREMOVE.Text = "Remove"
        Me.CMDPHOTOREMOVE.UseVisualStyleBackColor = True
        '
        'CMDPHOTOUPLOAD
        '
        Me.CMDPHOTOUPLOAD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPHOTOUPLOAD.Location = New System.Drawing.Point(541, 70)
        Me.CMDPHOTOUPLOAD.Name = "CMDPHOTOUPLOAD"
        Me.CMDPHOTOUPLOAD.Size = New System.Drawing.Size(80, 28)
        Me.CMDPHOTOUPLOAD.TabIndex = 16
        Me.CMDPHOTOUPLOAD.Text = "Upload"
        Me.CMDPHOTOUPLOAD.UseVisualStyleBackColor = True
        '
        'CMDPHOTOVIEW
        '
        Me.CMDPHOTOVIEW.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPHOTOVIEW.Location = New System.Drawing.Point(541, 138)
        Me.CMDPHOTOVIEW.Name = "CMDPHOTOVIEW"
        Me.CMDPHOTOVIEW.Size = New System.Drawing.Size(80, 28)
        Me.CMDPHOTOVIEW.TabIndex = 18
        Me.CMDPHOTOVIEW.Text = "View"
        Me.CMDPHOTOVIEW.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(390, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Photograph"
        '
        'PBPHOTO
        '
        Me.PBPHOTO.BackColor = System.Drawing.Color.Transparent
        Me.PBPHOTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBPHOTO.ErrorImage = Nothing
        Me.PBPHOTO.InitialImage = Nothing
        Me.PBPHOTO.Location = New System.Drawing.Point(393, 63)
        Me.PBPHOTO.Name = "PBPHOTO"
        Me.PBPHOTO.Size = New System.Drawing.Size(142, 145)
        Me.PBPHOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPHOTO.TabIndex = 823
        Me.PBPHOTO.TabStop = False
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(335, 566)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 22
        Me.CMDDELETE.Text = "&Delete"
        Me.CMDDELETE.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(421, 566)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 23
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'CMDOK
        '
        Me.CMDOK.BackColor = System.Drawing.Color.Transparent
        Me.CMDOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDOK.FlatAppearance.BorderSize = 0
        Me.CMDOK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDOK.ForeColor = System.Drawing.Color.Black
        Me.CMDOK.Location = New System.Drawing.Point(166, 567)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 20
        Me.CMDOK.Text = "&Save"
        Me.CMDOK.UseVisualStyleBackColor = False
        '
        'CMDCLEAR
        '
        Me.CMDCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.CMDCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDCLEAR.FlatAppearance.BorderSize = 0
        Me.CMDCLEAR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCLEAR.ForeColor = System.Drawing.Color.Black
        Me.CMDCLEAR.Location = New System.Drawing.Point(252, 567)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 21
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'CMBDISTRICT
        '
        Me.CMBDISTRICT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBDISTRICT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBDISTRICT.BackColor = System.Drawing.Color.White
        Me.CMBDISTRICT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDISTRICT.FormattingEnabled = True
        Me.CMBDISTRICT.Items.AddRange(New Object() {""})
        Me.CMBDISTRICT.Location = New System.Drawing.Point(124, 276)
        Me.CMBDISTRICT.MaxLength = 100
        Me.CMBDISTRICT.Name = "CMBDISTRICT"
        Me.CMBDISTRICT.Size = New System.Drawing.Size(233, 23)
        Me.CMBDISTRICT.TabIndex = 9
        Me.CMBDISTRICT.TabStop = False
        '
        'CMBTALUKA
        '
        Me.CMBTALUKA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBTALUKA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBTALUKA.BackColor = System.Drawing.Color.White
        Me.CMBTALUKA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTALUKA.FormattingEnabled = True
        Me.CMBTALUKA.Items.AddRange(New Object() {""})
        Me.CMBTALUKA.Location = New System.Drawing.Point(124, 247)
        Me.CMBTALUKA.MaxLength = 100
        Me.CMBTALUKA.Name = "CMBTALUKA"
        Me.CMBTALUKA.Size = New System.Drawing.Size(233, 23)
        Me.CMBTALUKA.TabIndex = 8
        Me.CMBTALUKA.TabStop = False
        '
        'CMBVILLAGE
        '
        Me.CMBVILLAGE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBVILLAGE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBVILLAGE.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBVILLAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBVILLAGE.FormattingEnabled = True
        Me.CMBVILLAGE.Items.AddRange(New Object() {""})
        Me.CMBVILLAGE.Location = New System.Drawing.Point(124, 218)
        Me.CMBVILLAGE.MaxLength = 100
        Me.CMBVILLAGE.Name = "CMBVILLAGE"
        Me.CMBVILLAGE.Size = New System.Drawing.Size(233, 23)
        Me.CMBVILLAGE.TabIndex = 7
        '
        'CMBSEX
        '
        Me.CMBSEX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBSEX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBSEX.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBSEX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBSEX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSEX.FormattingEnabled = True
        Me.CMBSEX.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CMBSEX.Location = New System.Drawing.Point(274, 160)
        Me.CMBSEX.Name = "CMBSEX"
        Me.CMBSEX.Size = New System.Drawing.Size(83, 23)
        Me.CMBSEX.TabIndex = 5
        '
        'LBLDISTRICT
        '
        Me.LBLDISTRICT.AutoSize = True
        Me.LBLDISTRICT.BackColor = System.Drawing.Color.Transparent
        Me.LBLDISTRICT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDISTRICT.Location = New System.Drawing.Point(72, 280)
        Me.LBLDISTRICT.Name = "LBLDISTRICT"
        Me.LBLDISTRICT.Size = New System.Drawing.Size(48, 15)
        Me.LBLDISTRICT.TabIndex = 45
        Me.LBLDISTRICT.Text = "District"
        '
        'CMBCATEGORY
        '
        Me.CMBCATEGORY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCATEGORY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCATEGORY.BackColor = System.Drawing.Color.White
        Me.CMBCATEGORY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCATEGORY.FormattingEnabled = True
        Me.CMBCATEGORY.Items.AddRange(New Object() {""})
        Me.CMBCATEGORY.Location = New System.Drawing.Point(124, 189)
        Me.CMBCATEGORY.MaxLength = 100
        Me.CMBCATEGORY.Name = "CMBCATEGORY"
        Me.CMBCATEGORY.Size = New System.Drawing.Size(233, 23)
        Me.CMBCATEGORY.TabIndex = 6
        Me.CMBCATEGORY.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(246, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Sex"
        '
        'LBLVILLAGE
        '
        Me.LBLVILLAGE.BackColor = System.Drawing.Color.Transparent
        Me.LBLVILLAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVILLAGE.Location = New System.Drawing.Point(60, 222)
        Me.LBLVILLAGE.Name = "LBLVILLAGE"
        Me.LBLVILLAGE.Size = New System.Drawing.Size(60, 15)
        Me.LBLVILLAGE.TabIndex = 43
        Me.LBLVILLAGE.Text = "Village"
        Me.LBLVILLAGE.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXTMRDNO
        '
        Me.TXTMRDNO.BackColor = System.Drawing.Color.Linen
        Me.TXTMRDNO.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTMRDNO.Location = New System.Drawing.Point(124, 305)
        Me.TXTMRDNO.MaxLength = 50
        Me.TXTMRDNO.Name = "TXTMRDNO"
        Me.TXTMRDNO.ReadOnly = True
        Me.TXTMRDNO.Size = New System.Drawing.Size(183, 23)
        Me.TXTMRDNO.TabIndex = 10
        Me.TXTMRDNO.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "MRD No"
        '
        'TXTLASTNAME
        '
        Me.TXTLASTNAME.BackColor = System.Drawing.Color.White
        Me.TXTLASTNAME.Location = New System.Drawing.Point(124, 131)
        Me.TXTLASTNAME.MaxLength = 100
        Me.TXTLASTNAME.Name = "TXTLASTNAME"
        Me.TXTLASTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTLASTNAME.TabIndex = 3
        Me.TXTLASTNAME.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Last Name"
        '
        'TXTUHLDNO
        '
        Me.TXTUHLDNO.BackColor = System.Drawing.Color.White
        Me.TXTUHLDNO.Location = New System.Drawing.Point(124, 334)
        Me.TXTUHLDNO.MaxLength = 50
        Me.TXTUHLDNO.Name = "TXTUHLDNO"
        Me.TXTUHLDNO.Size = New System.Drawing.Size(183, 23)
        Me.TXTUHLDNO.TabIndex = 11
        Me.TXTUHLDNO.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 338)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "UHLD No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Taluka"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Category"
        '
        'TXTAGE
        '
        Me.TXTAGE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTAGE.Location = New System.Drawing.Point(124, 160)
        Me.TXTAGE.MaxLength = 3
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(72, 23)
        Me.TXTAGE.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Age"
        '
        'TXTFIRSTNAME
        '
        Me.TXTFIRSTNAME.BackColor = System.Drawing.Color.White
        Me.TXTFIRSTNAME.Location = New System.Drawing.Point(124, 102)
        Me.TXTFIRSTNAME.MaxLength = 100
        Me.TXTFIRSTNAME.Name = "TXTFIRSTNAME"
        Me.TXTFIRSTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTFIRSTNAME.TabIndex = 2
        Me.TXTFIRSTNAME.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "First Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 15)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Patient Name"
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PatientMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(666, 609)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "PatientMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Patient Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PBDOC2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDOC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPHOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents EP As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CMBCATEGORY As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBLVILLAGE As System.Windows.Forms.Label
    Friend WithEvents TXTMRDNO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXTLASTNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTUHLDNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTFIRSTNAME As System.Windows.Forms.TextBox
    Friend WithEvents CMBDISTRICT As System.Windows.Forms.ComboBox
    Friend WithEvents CMBTALUKA As System.Windows.Forms.ComboBox
    Friend WithEvents CMBVILLAGE As System.Windows.Forms.ComboBox
    Friend WithEvents CMBSEX As System.Windows.Forms.ComboBox
    Friend WithEvents LBLDISTRICT As System.Windows.Forms.Label
    Friend WithEvents CMDDELETE As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents CMDCLEAR As System.Windows.Forms.Button
    Friend WithEvents CMDPHOTOREMOVE As System.Windows.Forms.Button
    Friend WithEvents CMDPHOTOUPLOAD As System.Windows.Forms.Button
    Friend WithEvents CMDPHOTOVIEW As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PBPHOTO As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTADDRESS As System.Windows.Forms.TextBox
    Friend WithEvents TXTMOBILE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents CMDDOC2REMOVE As System.Windows.Forms.Button
    Friend WithEvents CMDDOC2 As System.Windows.Forms.Button
    Friend WithEvents CMDDOC2VIEW As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PBDOC2 As System.Windows.Forms.PictureBox
    Friend WithEvents CMDDOC1REMOVE As System.Windows.Forms.Button
    Friend WithEvents CMDDOC1 As System.Windows.Forms.Button
    Friend WithEvents CMDDOC1VIEW As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PBDOC1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TOOLDELETE As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CMDPHOTOPRINT As System.Windows.Forms.Button
    Friend WithEvents CMDUHLD2PRINT As System.Windows.Forms.Button
    Friend WithEvents CMDUHLD1PRINT As System.Windows.Forms.Button
    Friend WithEvents TXTHOF As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LBLOCCUPATION As Label
    Friend WithEvents CHKCONSULTATION As CheckBox
    Friend WithEvents CMBOCCUPATION As ComboBox
End Class
