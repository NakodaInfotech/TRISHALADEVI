<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OPD))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TXTSEX = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.TXTPLACE = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TXTMOBILE = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXTOPDNO = New System.Windows.Forms.TextBox()
        Me.DTDATE = New System.Windows.Forms.DateTimePicker()
        Me.TXTPATIENTNAME = New System.Windows.Forms.TextBox()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.TXTSURGEONMOBILE = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TXTSURGEON = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TXTHTALUKA = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TXTHREGNO = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TXTHOSPITAL = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CMBMRDNO = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Toolprevious = New System.Windows.Forms.ToolStripButton()
        Me.toolnext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTNO = New System.Windows.Forms.TextBox()
        Me.LBLTOKENNO = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLTIME = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBAMOUNT = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMDSEARCH = New System.Windows.Forms.Button()
        Me.GRIDCHARGES = New System.Windows.Forms.DataGridView()
        Me.GSRNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GCHARGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAMT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTSUBTOTAL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTDISC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTGRANDTOTAL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTINWORDS = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.BlendPanel2 = New VbPowerPack.BlendPanel()
        Me.CHKOPDDETAILSA5 = New System.Windows.Forms.CheckBox()
        Me.DTENTRYDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXTFOLLOWUPCOUNT = New System.Windows.Forms.TextBox()
        Me.TXTRENEWOPDCOUNT = New System.Windows.Forms.TextBox()
        Me.TXTNEWOPDCOUNT = New System.Windows.Forms.TextBox()
        Me.TXTBILLNO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTFOLLOWUPAMT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTRENEWOPDAMT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTNEWOPDAMT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMBTYPE = New System.Windows.Forms.ComboBox()
        Me.gridbilldetails = New DevExpress.XtraGrid.GridControl()
        Me.gridbill = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GTOKENNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTOKENTIME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GOPDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GVILLAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRECDAMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GUSERNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CHKAPPTREC = New System.Windows.Forms.CheckBox()
        Me.CHKOPDRECEIPT = New System.Windows.Forms.CheckBox()
        Me.LBLCANCEL = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLLASTDATE = New System.Windows.Forms.Label()
        Me.CHKALL = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHKOPDDETAILS = New System.Windows.Forms.CheckBox()
        Me.CHKCONSULTATION = New System.Windows.Forms.CheckBox()
        Me.TXTBALAMT = New System.Windows.Forms.TextBox()
        Me.LBLBALAMT = New System.Windows.Forms.Label()
        Me.TXTRECDAMT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTOCCUPATION = New System.Windows.Forms.TextBox()
        Me.LBLOCCUPATION = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlendPanel2.SuspendLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(237, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1183, 25)
        Me.miniToolStrip.TabIndex = 79
        '
        'CMDCLEAR
        '
        Me.CMDCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.CMDCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDCLEAR.FlatAppearance.BorderSize = 0
        Me.CMDCLEAR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCLEAR.ForeColor = System.Drawing.Color.Black
        Me.CMDCLEAR.Location = New System.Drawing.Point(432, 526)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 9
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.Transparent
        Me.CMDSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSAVE.FlatAppearance.BorderSize = 0
        Me.CMDSAVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSAVE.ForeColor = System.Drawing.Color.Black
        Me.CMDSAVE.Location = New System.Drawing.Point(346, 526)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDSAVE.TabIndex = 8
        Me.CMDSAVE.Text = "&Save"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(604, 526)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 11
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(48, 302)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 15)
        Me.Label32.TabIndex = 34
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(521, 41)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 15)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "OPD No"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(14, 97)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 15)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "Name Of Patient "
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(256, 155)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(26, 15)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Age"
        '
        'TXTSEX
        '
        Me.TXTSEX.BackColor = System.Drawing.Color.Linen
        Me.TXTSEX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEX.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTSEX.Location = New System.Drawing.Point(371, 151)
        Me.TXTSEX.MaxLength = 50
        Me.TXTSEX.Name = "TXTSEX"
        Me.TXTSEX.ReadOnly = True
        Me.TXTSEX.Size = New System.Drawing.Size(55, 23)
        Me.TXTSEX.TabIndex = 9
        Me.TXTSEX.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(249, 126)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 15)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Place"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(344, 155)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 15)
        Me.Label26.TabIndex = 29
        Me.Label26.Text = "Sex"
        '
        'TXTAGE
        '
        Me.TXTAGE.BackColor = System.Drawing.Color.Linen
        Me.TXTAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAGE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTAGE.Location = New System.Drawing.Point(287, 151)
        Me.TXTAGE.MaxLength = 50
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.ReadOnly = True
        Me.TXTAGE.Size = New System.Drawing.Size(55, 23)
        Me.TXTAGE.TabIndex = 8
        Me.TXTAGE.TabStop = False
        '
        'TXTPLACE
        '
        Me.TXTPLACE.BackColor = System.Drawing.Color.Linen
        Me.TXTPLACE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPLACE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTPLACE.Location = New System.Drawing.Point(287, 122)
        Me.TXTPLACE.MaxLength = 50
        Me.TXTPLACE.Name = "TXTPLACE"
        Me.TXTPLACE.ReadOnly = True
        Me.TXTPLACE.Size = New System.Drawing.Size(139, 23)
        Me.TXTPLACE.TabIndex = 7
        Me.TXTPLACE.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(42, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 15)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Contact No."
        '
        'TXTMOBILE
        '
        Me.TXTMOBILE.BackColor = System.Drawing.Color.Linen
        Me.TXTMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOBILE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTMOBILE.Location = New System.Drawing.Point(112, 122)
        Me.TXTMOBILE.MaxLength = 50
        Me.TXTMOBILE.Name = "TXTMOBILE"
        Me.TXTMOBILE.ReadOnly = True
        Me.TXTMOBILE.Size = New System.Drawing.Size(118, 23)
        Me.TXTMOBILE.TabIndex = 5
        Me.TXTMOBILE.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(484, 69)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 15)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Followup Date"
        '
        'TXTOPDNO
        '
        Me.TXTOPDNO.BackColor = System.Drawing.Color.Linen
        Me.TXTOPDNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTOPDNO.Location = New System.Drawing.Point(572, 37)
        Me.TXTOPDNO.MaxLength = 100
        Me.TXTOPDNO.Name = "TXTOPDNO"
        Me.TXTOPDNO.Size = New System.Drawing.Size(89, 23)
        Me.TXTOPDNO.TabIndex = 16
        Me.TXTOPDNO.TabStop = False
        '
        'DTDATE
        '
        Me.DTDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTDATE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTDATE.Location = New System.Drawing.Point(572, 65)
        Me.DTDATE.Name = "DTDATE"
        Me.DTDATE.Size = New System.Drawing.Size(89, 23)
        Me.DTDATE.TabIndex = 2
        '
        'TXTPATIENTNAME
        '
        Me.TXTPATIENTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTPATIENTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPATIENTNAME.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTPATIENTNAME.Location = New System.Drawing.Point(112, 93)
        Me.TXTPATIENTNAME.MaxLength = 50
        Me.TXTPATIENTNAME.Name = "TXTPATIENTNAME"
        Me.TXTPATIENTNAME.ReadOnly = True
        Me.TXTPATIENTNAME.Size = New System.Drawing.Size(314, 23)
        Me.TXTPATIENTNAME.TabIndex = 4
        Me.TXTPATIENTNAME.TabStop = False
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(518, 526)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 10
        Me.CMDDELETE.Text = "&Delete"
        Me.CMDDELETE.UseVisualStyleBackColor = False
        '
        'TXTSURGEONMOBILE
        '
        Me.TXTSURGEONMOBILE.BackColor = System.Drawing.Color.Linen
        Me.TXTSURGEONMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSURGEONMOBILE.Location = New System.Drawing.Point(744, 122)
        Me.TXTSURGEONMOBILE.MaxLength = 25
        Me.TXTSURGEONMOBILE.Name = "TXTSURGEONMOBILE"
        Me.TXTSURGEONMOBILE.ReadOnly = True
        Me.TXTSURGEONMOBILE.Size = New System.Drawing.Size(95, 23)
        Me.TXTSURGEONMOBILE.TabIndex = 19
        Me.TXTSURGEONMOBILE.TabStop = False
        Me.TXTSURGEONMOBILE.Text = "9986903343"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(466, 184)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(105, 15)
        Me.Label52.TabIndex = 49
        Me.Label52.Text = "Nature of Surgeon"
        '
        'TXTSURGEON
        '
        Me.TXTSURGEON.BackColor = System.Drawing.Color.Linen
        Me.TXTSURGEON.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSURGEON.Location = New System.Drawing.Point(572, 180)
        Me.TXTSURGEON.MaxLength = 100
        Me.TXTSURGEON.Name = "TXTSURGEON"
        Me.TXTSURGEON.ReadOnly = True
        Me.TXTSURGEON.Size = New System.Drawing.Size(267, 23)
        Me.TXTSURGEON.TabIndex = 22
        Me.TXTSURGEON.TabStop = False
        Me.TXTSURGEON.Text = "Dr. Padmajeet A. Nadagouda Patil"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(484, 126)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(93, 15)
        Me.Label51.TabIndex = 47
        Me.Label51.Text = "Hospital Taluka"
        '
        'TXTHTALUKA
        '
        Me.TXTHTALUKA.BackColor = System.Drawing.Color.Linen
        Me.TXTHTALUKA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHTALUKA.Location = New System.Drawing.Point(572, 122)
        Me.TXTHTALUKA.MaxLength = 100
        Me.TXTHTALUKA.Name = "TXTHTALUKA"
        Me.TXTHTALUKA.ReadOnly = True
        Me.TXTHTALUKA.Size = New System.Drawing.Size(61, 23)
        Me.TXTHTALUKA.TabIndex = 18
        Me.TXTHTALUKA.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(474, 155)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 15)
        Me.Label50.TabIndex = 48
        Me.Label50.Text = "Hospital Reg. No."
        '
        'TXTHREGNO
        '
        Me.TXTHREGNO.BackColor = System.Drawing.Color.Linen
        Me.TXTHREGNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHREGNO.Location = New System.Drawing.Point(572, 151)
        Me.TXTHREGNO.MaxLength = 100
        Me.TXTHREGNO.Name = "TXTHREGNO"
        Me.TXTHREGNO.ReadOnly = True
        Me.TXTHREGNO.Size = New System.Drawing.Size(267, 23)
        Me.TXTHREGNO.TabIndex = 21
        Me.TXTHREGNO.TabStop = False
        Me.TXTHREGNO.Text = "MMC 2000/01/0408"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(487, 97)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(88, 15)
        Me.Label49.TabIndex = 46
        Me.Label49.Text = "Hospital Name"
        '
        'TXTHOSPITAL
        '
        Me.TXTHOSPITAL.BackColor = System.Drawing.Color.Linen
        Me.TXTHOSPITAL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHOSPITAL.Location = New System.Drawing.Point(572, 93)
        Me.TXTHOSPITAL.MaxLength = 100
        Me.TXTHOSPITAL.Name = "TXTHOSPITAL"
        Me.TXTHOSPITAL.ReadOnly = True
        Me.TXTHOSPITAL.Size = New System.Drawing.Size(267, 23)
        Me.TXTHOSPITAL.TabIndex = 17
        Me.TXTHOSPITAL.TabStop = False
        Me.TXTHOSPITAL.Text = "TRISHALADEVI SUPER SPECIALITY EYE HOSPITAL"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(54, 41)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 15)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "MRD NO."
        '
        'CMBMRDNO
        '
        Me.CMBMRDNO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBMRDNO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBMRDNO.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBMRDNO.DropDownWidth = 300
        Me.CMBMRDNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMRDNO.FormattingEnabled = True
        Me.CMBMRDNO.ItemHeight = 15
        Me.CMBMRDNO.Location = New System.Drawing.Point(112, 37)
        Me.CMBMRDNO.MaxDropDownItems = 14
        Me.CMBMRDNO.Name = "CMBMRDNO"
        Me.CMBMRDNO.Size = New System.Drawing.Size(118, 23)
        Me.CMBMRDNO.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.TOOLDELETE, Me.ToolStripSeparator1, Me.Toolprevious, Me.toolnext, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1362, 25)
        Me.ToolStrip1.TabIndex = 20
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
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
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
        'Toolprevious
        '
        Me.Toolprevious.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Toolprevious.Image = CType(resources.GetObject("Toolprevious.Image"), System.Drawing.Image)
        Me.Toolprevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Toolprevious.Name = "Toolprevious"
        Me.Toolprevious.Size = New System.Drawing.Size(73, 22)
        Me.Toolprevious.Text = "Previous"
        '
        'toolnext
        '
        Me.toolnext.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolnext.Image = CType(resources.GetObject("toolnext.Image"), System.Drawing.Image)
        Me.toolnext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolnext.Name = "toolnext"
        Me.toolnext.Size = New System.Drawing.Size(51, 22)
        Me.toolnext.Text = "Next"
        Me.toolnext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TXTNO
        '
        Me.TXTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNO.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNO.Location = New System.Drawing.Point(240, 2)
        Me.TXTNO.Name = "TXTNO"
        Me.TXTNO.Size = New System.Drawing.Size(61, 22)
        Me.TXTNO.TabIndex = 19
        Me.TXTNO.TabStop = False
        Me.TXTNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLTOKENNO
        '
        Me.LBLTOKENNO.AutoSize = True
        Me.LBLTOKENNO.BackColor = System.Drawing.Color.Transparent
        Me.LBLTOKENNO.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOKENNO.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBLTOKENNO.Location = New System.Drawing.Point(193, 370)
        Me.LBLTOKENNO.Name = "LBLTOKENNO"
        Me.LBLTOKENNO.Size = New System.Drawing.Size(57, 33)
        Me.LBLTOKENNO.TabIndex = 12
        Me.LBLTOKENNO.Text = "125"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label2.Location = New System.Drawing.Point(61, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 33)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Token No :"
        '
        'LBLTIME
        '
        Me.LBLTIME.AutoSize = True
        Me.LBLTIME.BackColor = System.Drawing.Color.Transparent
        Me.LBLTIME.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTIME.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBLTIME.Location = New System.Drawing.Point(146, 409)
        Me.LBLTIME.Name = "LBLTIME"
        Me.LBLTIME.Size = New System.Drawing.Size(110, 33)
        Me.LBLTIME.TabIndex = 14
        Me.LBLTIME.Text = "9:30 AM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label3.Location = New System.Drawing.Point(64, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 33)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Time :"
        '
        'CMBAMOUNT
        '
        Me.CMBAMOUNT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBAMOUNT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBAMOUNT.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBAMOUNT.DropDownWidth = 300
        Me.CMBAMOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBAMOUNT.FormattingEnabled = True
        Me.CMBAMOUNT.ItemHeight = 15
        Me.CMBAMOUNT.Location = New System.Drawing.Point(112, 180)
        Me.CMBAMOUNT.MaxDropDownItems = 14
        Me.CMBAMOUNT.Name = "CMBAMOUNT"
        Me.CMBAMOUNT.Size = New System.Drawing.Size(314, 23)
        Me.CMBAMOUNT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Amount"
        '
        'CMDSEARCH
        '
        Me.CMDSEARCH.BackColor = System.Drawing.Color.Transparent
        Me.CMDSEARCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSEARCH.FlatAppearance.BorderSize = 0
        Me.CMDSEARCH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSEARCH.ForeColor = System.Drawing.Color.Black
        Me.CMDSEARCH.Location = New System.Drawing.Point(236, 34)
        Me.CMDSEARCH.Name = "CMDSEARCH"
        Me.CMDSEARCH.Size = New System.Drawing.Size(80, 28)
        Me.CMDSEARCH.TabIndex = 1
        Me.CMDSEARCH.Text = "S&earch"
        Me.CMDSEARCH.UseVisualStyleBackColor = False
        '
        'GRIDCHARGES
        '
        Me.GRIDCHARGES.AllowUserToAddRows = False
        Me.GRIDCHARGES.AllowUserToDeleteRows = False
        Me.GRIDCHARGES.AllowUserToResizeColumns = False
        Me.GRIDCHARGES.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.GRIDCHARGES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRIDCHARGES.BackgroundColor = System.Drawing.Color.White
        Me.GRIDCHARGES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRIDCHARGES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRIDCHARGES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRIDCHARGES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRIDCHARGES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GSRNO, Me.GCHARGE, Me.GAMT})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRIDCHARGES.DefaultCellStyle = DataGridViewCellStyle4
        Me.GRIDCHARGES.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRIDCHARGES.Location = New System.Drawing.Point(67, 216)
        Me.GRIDCHARGES.Margin = New System.Windows.Forms.Padding(2)
        Me.GRIDCHARGES.MultiSelect = False
        Me.GRIDCHARGES.Name = "GRIDCHARGES"
        Me.GRIDCHARGES.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        Me.GRIDCHARGES.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRIDCHARGES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRIDCHARGES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRIDCHARGES.Size = New System.Drawing.Size(394, 145)
        Me.GRIDCHARGES.TabIndex = 5
        Me.GRIDCHARGES.TabStop = False
        '
        'GSRNO
        '
        Me.GSRNO.HeaderText = "Sr."
        Me.GSRNO.Name = "GSRNO"
        Me.GSRNO.ReadOnly = True
        Me.GSRNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GSRNO.Width = 40
        '
        'GCHARGE
        '
        Me.GCHARGE.HeaderText = "Charges"
        Me.GCHARGE.Name = "GCHARGE"
        Me.GCHARGE.ReadOnly = True
        Me.GCHARGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GCHARGE.Width = 220
        '
        'GAMT
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.GAMT.DefaultCellStyle = DataGridViewCellStyle3
        Me.GAMT.HeaderText = "Amount"
        Me.GAMT.Name = "GAMT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(308, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Subtotal"
        '
        'TXTSUBTOTAL
        '
        Me.TXTSUBTOTAL.BackColor = System.Drawing.Color.Linen
        Me.TXTSUBTOTAL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSUBTOTAL.Location = New System.Drawing.Point(361, 366)
        Me.TXTSUBTOTAL.MaxLength = 25
        Me.TXTSUBTOTAL.Name = "TXTSUBTOTAL"
        Me.TXTSUBTOTAL.ReadOnly = True
        Me.TXTSUBTOTAL.Size = New System.Drawing.Size(65, 23)
        Me.TXTSUBTOTAL.TabIndex = 12
        Me.TXTSUBTOTAL.TabStop = False
        Me.TXTSUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 399)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Discount"
        '
        'TXTDISC
        '
        Me.TXTDISC.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDISC.Location = New System.Drawing.Point(361, 395)
        Me.TXTDISC.MaxLength = 25
        Me.TXTDISC.Name = "TXTDISC"
        Me.TXTDISC.Size = New System.Drawing.Size(65, 23)
        Me.TXTDISC.TabIndex = 6
        Me.TXTDISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Grand Total"
        '
        'TXTGRANDTOTAL
        '
        Me.TXTGRANDTOTAL.BackColor = System.Drawing.Color.Linen
        Me.TXTGRANDTOTAL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGRANDTOTAL.Location = New System.Drawing.Point(361, 424)
        Me.TXTGRANDTOTAL.MaxLength = 25
        Me.TXTGRANDTOTAL.Name = "TXTGRANDTOTAL"
        Me.TXTGRANDTOTAL.ReadOnly = True
        Me.TXTGRANDTOTAL.Size = New System.Drawing.Size(65, 23)
        Me.TXTGRANDTOTAL.TabIndex = 15
        Me.TXTGRANDTOTAL.TabStop = False
        Me.TXTGRANDTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 456)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "In Words"
        Me.Label8.Visible = False
        '
        'TXTINWORDS
        '
        Me.TXTINWORDS.BackColor = System.Drawing.Color.Linen
        Me.TXTINWORDS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTINWORDS.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTINWORDS.Location = New System.Drawing.Point(70, 452)
        Me.TXTINWORDS.MaxLength = 50
        Me.TXTINWORDS.Multiline = True
        Me.TXTINWORDS.Name = "TXTINWORDS"
        Me.TXTINWORDS.ReadOnly = True
        Me.TXTINWORDS.Size = New System.Drawing.Size(203, 89)
        Me.TXTINWORDS.TabIndex = 23
        Me.TXTINWORDS.TabStop = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(639, 126)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(102, 15)
        Me.Label53.TabIndex = 52
        Me.Label53.Text = "Surgeon's Mobile"
        '
        'BlendPanel2
        '
        Me.BlendPanel2.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel2.Controls.Add(Me.CHKOPDDETAILSA5)
        Me.BlendPanel2.Controls.Add(Me.DTENTRYDATE)
        Me.BlendPanel2.Controls.Add(Me.Label16)
        Me.BlendPanel2.Controls.Add(Me.TXTFOLLOWUPCOUNT)
        Me.BlendPanel2.Controls.Add(Me.TXTRENEWOPDCOUNT)
        Me.BlendPanel2.Controls.Add(Me.TXTNEWOPDCOUNT)
        Me.BlendPanel2.Controls.Add(Me.TXTBILLNO)
        Me.BlendPanel2.Controls.Add(Me.Label15)
        Me.BlendPanel2.Controls.Add(Me.TXTFOLLOWUPAMT)
        Me.BlendPanel2.Controls.Add(Me.Label14)
        Me.BlendPanel2.Controls.Add(Me.TXTRENEWOPDAMT)
        Me.BlendPanel2.Controls.Add(Me.Label13)
        Me.BlendPanel2.Controls.Add(Me.TXTNEWOPDAMT)
        Me.BlendPanel2.Controls.Add(Me.Label12)
        Me.BlendPanel2.Controls.Add(Me.Label11)
        Me.BlendPanel2.Controls.Add(Me.CMBTYPE)
        Me.BlendPanel2.Controls.Add(Me.gridbilldetails)
        Me.BlendPanel2.Controls.Add(Me.CHKAPPTREC)
        Me.BlendPanel2.Controls.Add(Me.CHKOPDRECEIPT)
        Me.BlendPanel2.Controls.Add(Me.LBLCANCEL)
        Me.BlendPanel2.Controls.Add(Me.Label10)
        Me.BlendPanel2.Controls.Add(Me.LBLLASTDATE)
        Me.BlendPanel2.Controls.Add(Me.CHKALL)
        Me.BlendPanel2.Controls.Add(Me.Label1)
        Me.BlendPanel2.Controls.Add(Me.CHKOPDDETAILS)
        Me.BlendPanel2.Controls.Add(Me.CHKCONSULTATION)
        Me.BlendPanel2.Controls.Add(Me.TXTBALAMT)
        Me.BlendPanel2.Controls.Add(Me.LBLBALAMT)
        Me.BlendPanel2.Controls.Add(Me.TXTRECDAMT)
        Me.BlendPanel2.Controls.Add(Me.Label9)
        Me.BlendPanel2.Controls.Add(Me.TXTOCCUPATION)
        Me.BlendPanel2.Controls.Add(Me.LBLOCCUPATION)
        Me.BlendPanel2.Controls.Add(Me.Label53)
        Me.BlendPanel2.Controls.Add(Me.TXTINWORDS)
        Me.BlendPanel2.Controls.Add(Me.Label8)
        Me.BlendPanel2.Controls.Add(Me.TXTGRANDTOTAL)
        Me.BlendPanel2.Controls.Add(Me.Label7)
        Me.BlendPanel2.Controls.Add(Me.TXTDISC)
        Me.BlendPanel2.Controls.Add(Me.Label6)
        Me.BlendPanel2.Controls.Add(Me.TXTSUBTOTAL)
        Me.BlendPanel2.Controls.Add(Me.Label5)
        Me.BlendPanel2.Controls.Add(Me.GRIDCHARGES)
        Me.BlendPanel2.Controls.Add(Me.CMDSEARCH)
        Me.BlendPanel2.Controls.Add(Me.Label4)
        Me.BlendPanel2.Controls.Add(Me.CMBAMOUNT)
        Me.BlendPanel2.Controls.Add(Me.Label3)
        Me.BlendPanel2.Controls.Add(Me.LBLTIME)
        Me.BlendPanel2.Controls.Add(Me.Label2)
        Me.BlendPanel2.Controls.Add(Me.LBLTOKENNO)
        Me.BlendPanel2.Controls.Add(Me.TXTNO)
        Me.BlendPanel2.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel2.Controls.Add(Me.CMBMRDNO)
        Me.BlendPanel2.Controls.Add(Me.Label30)
        Me.BlendPanel2.Controls.Add(Me.TXTHOSPITAL)
        Me.BlendPanel2.Controls.Add(Me.Label49)
        Me.BlendPanel2.Controls.Add(Me.TXTHREGNO)
        Me.BlendPanel2.Controls.Add(Me.Label50)
        Me.BlendPanel2.Controls.Add(Me.TXTHTALUKA)
        Me.BlendPanel2.Controls.Add(Me.Label51)
        Me.BlendPanel2.Controls.Add(Me.TXTSURGEON)
        Me.BlendPanel2.Controls.Add(Me.Label52)
        Me.BlendPanel2.Controls.Add(Me.TXTSURGEONMOBILE)
        Me.BlendPanel2.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel2.Controls.Add(Me.TXTPATIENTNAME)
        Me.BlendPanel2.Controls.Add(Me.DTDATE)
        Me.BlendPanel2.Controls.Add(Me.TXTOPDNO)
        Me.BlendPanel2.Controls.Add(Me.Label24)
        Me.BlendPanel2.Controls.Add(Me.TXTMOBILE)
        Me.BlendPanel2.Controls.Add(Me.Label25)
        Me.BlendPanel2.Controls.Add(Me.TXTPLACE)
        Me.BlendPanel2.Controls.Add(Me.TXTAGE)
        Me.BlendPanel2.Controls.Add(Me.Label26)
        Me.BlendPanel2.Controls.Add(Me.Label27)
        Me.BlendPanel2.Controls.Add(Me.TXTSEX)
        Me.BlendPanel2.Controls.Add(Me.Label28)
        Me.BlendPanel2.Controls.Add(Me.Label29)
        Me.BlendPanel2.Controls.Add(Me.Label31)
        Me.BlendPanel2.Controls.Add(Me.Label32)
        Me.BlendPanel2.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel2.Controls.Add(Me.CMDSAVE)
        Me.BlendPanel2.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel2.Name = "BlendPanel2"
        Me.BlendPanel2.Size = New System.Drawing.Size(1362, 741)
        Me.BlendPanel2.TabIndex = 0
        '
        'CHKOPDDETAILSA5
        '
        Me.CHKOPDDETAILSA5.AutoSize = True
        Me.CHKOPDDETAILSA5.BackColor = System.Drawing.Color.Transparent
        Me.CHKOPDDETAILSA5.Location = New System.Drawing.Point(541, 303)
        Me.CHKOPDDETAILSA5.Name = "CHKOPDDETAILSA5"
        Me.CHKOPDDETAILSA5.Size = New System.Drawing.Size(114, 19)
        Me.CHKOPDDETAILSA5.TabIndex = 1002
        Me.CHKOPDDETAILSA5.TabStop = False
        Me.CHKOPDDETAILSA5.Text = "OPD Report (A5)"
        Me.CHKOPDDETAILSA5.UseVisualStyleBackColor = False
        '
        'DTENTRYDATE
        '
        Me.DTENTRYDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTENTRYDATE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTENTRYDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTENTRYDATE.Location = New System.Drawing.Point(765, 66)
        Me.DTENTRYDATE.Name = "DTENTRYDATE"
        Me.DTENTRYDATE.Size = New System.Drawing.Size(86, 23)
        Me.DTENTRYDATE.TabIndex = 1001
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(701, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 15)
        Me.Label16.TabIndex = 1000
        Me.Label16.Text = "Entry Date"
        '
        'TXTFOLLOWUPCOUNT
        '
        Me.TXTFOLLOWUPCOUNT.BackColor = System.Drawing.Color.Linen
        Me.TXTFOLLOWUPCOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFOLLOWUPCOUNT.Location = New System.Drawing.Point(693, 486)
        Me.TXTFOLLOWUPCOUNT.MaxLength = 25
        Me.TXTFOLLOWUPCOUNT.Name = "TXTFOLLOWUPCOUNT"
        Me.TXTFOLLOWUPCOUNT.ReadOnly = True
        Me.TXTFOLLOWUPCOUNT.Size = New System.Drawing.Size(42, 23)
        Me.TXTFOLLOWUPCOUNT.TabIndex = 999
        Me.TXTFOLLOWUPCOUNT.TabStop = False
        Me.TXTFOLLOWUPCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTRENEWOPDCOUNT
        '
        Me.TXTRENEWOPDCOUNT.BackColor = System.Drawing.Color.Linen
        Me.TXTRENEWOPDCOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRENEWOPDCOUNT.Location = New System.Drawing.Point(693, 457)
        Me.TXTRENEWOPDCOUNT.MaxLength = 25
        Me.TXTRENEWOPDCOUNT.Name = "TXTRENEWOPDCOUNT"
        Me.TXTRENEWOPDCOUNT.ReadOnly = True
        Me.TXTRENEWOPDCOUNT.Size = New System.Drawing.Size(42, 23)
        Me.TXTRENEWOPDCOUNT.TabIndex = 998
        Me.TXTRENEWOPDCOUNT.TabStop = False
        Me.TXTRENEWOPDCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNEWOPDCOUNT
        '
        Me.TXTNEWOPDCOUNT.BackColor = System.Drawing.Color.Linen
        Me.TXTNEWOPDCOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNEWOPDCOUNT.Location = New System.Drawing.Point(693, 428)
        Me.TXTNEWOPDCOUNT.MaxLength = 25
        Me.TXTNEWOPDCOUNT.Name = "TXTNEWOPDCOUNT"
        Me.TXTNEWOPDCOUNT.ReadOnly = True
        Me.TXTNEWOPDCOUNT.Size = New System.Drawing.Size(42, 23)
        Me.TXTNEWOPDCOUNT.TabIndex = 997
        Me.TXTNEWOPDCOUNT.TabStop = False
        Me.TXTNEWOPDCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTBILLNO
        '
        Me.TXTBILLNO.BackColor = System.Drawing.Color.Linen
        Me.TXTBILLNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBILLNO.Location = New System.Drawing.Point(764, 37)
        Me.TXTBILLNO.MaxLength = 100
        Me.TXTBILLNO.Name = "TXTBILLNO"
        Me.TXTBILLNO.Size = New System.Drawing.Size(86, 23)
        Me.TXTBILLNO.TabIndex = 996
        Me.TXTBILLNO.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(720, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 15)
        Me.Label15.TabIndex = 995
        Me.Label15.Text = "Bill No"
        '
        'TXTFOLLOWUPAMT
        '
        Me.TXTFOLLOWUPAMT.BackColor = System.Drawing.Color.Linen
        Me.TXTFOLLOWUPAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFOLLOWUPAMT.Location = New System.Drawing.Point(741, 486)
        Me.TXTFOLLOWUPAMT.MaxLength = 25
        Me.TXTFOLLOWUPAMT.Name = "TXTFOLLOWUPAMT"
        Me.TXTFOLLOWUPAMT.ReadOnly = True
        Me.TXTFOLLOWUPAMT.Size = New System.Drawing.Size(80, 23)
        Me.TXTFOLLOWUPAMT.TabIndex = 993
        Me.TXTFOLLOWUPAMT.TabStop = False
        Me.TXTFOLLOWUPAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(626, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 15)
        Me.Label14.TabIndex = 994
        Me.Label14.Text = "Follow Ups"
        '
        'TXTRENEWOPDAMT
        '
        Me.TXTRENEWOPDAMT.BackColor = System.Drawing.Color.Linen
        Me.TXTRENEWOPDAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRENEWOPDAMT.Location = New System.Drawing.Point(741, 457)
        Me.TXTRENEWOPDAMT.MaxLength = 25
        Me.TXTRENEWOPDAMT.Name = "TXTRENEWOPDAMT"
        Me.TXTRENEWOPDAMT.ReadOnly = True
        Me.TXTRENEWOPDAMT.Size = New System.Drawing.Size(80, 23)
        Me.TXTRENEWOPDAMT.TabIndex = 991
        Me.TXTRENEWOPDAMT.TabStop = False
        Me.TXTRENEWOPDAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(649, 461)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 992
        Me.Label13.Text = "Renew"
        '
        'TXTNEWOPDAMT
        '
        Me.TXTNEWOPDAMT.BackColor = System.Drawing.Color.Linen
        Me.TXTNEWOPDAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNEWOPDAMT.Location = New System.Drawing.Point(741, 428)
        Me.TXTNEWOPDAMT.MaxLength = 25
        Me.TXTNEWOPDAMT.Name = "TXTNEWOPDAMT"
        Me.TXTNEWOPDAMT.ReadOnly = True
        Me.TXTNEWOPDAMT.Size = New System.Drawing.Size(80, 23)
        Me.TXTNEWOPDAMT.TabIndex = 989
        Me.TXTNEWOPDAMT.TabStop = False
        Me.TXTNEWOPDAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(661, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 15)
        Me.Label12.TabIndex = 990
        Me.Label12.Text = "New"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(254, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 15)
        Me.Label11.TabIndex = 988
        Me.Label11.Text = "Type"
        '
        'CMBTYPE
        '
        Me.CMBTYPE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBTYPE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBTYPE.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTYPE.DropDownWidth = 300
        Me.CMBTYPE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTYPE.FormattingEnabled = True
        Me.CMBTYPE.ItemHeight = 15
        Me.CMBTYPE.Items.AddRange(New Object() {"NEW", "RENEW", "FOLLOWUP"})
        Me.CMBTYPE.Location = New System.Drawing.Point(287, 65)
        Me.CMBTYPE.MaxDropDownItems = 14
        Me.CMBTYPE.Name = "CMBTYPE"
        Me.CMBTYPE.Size = New System.Drawing.Size(139, 23)
        Me.CMBTYPE.TabIndex = 3
        '
        'gridbilldetails
        '
        Me.gridbilldetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbilldetails.Location = New System.Drawing.Point(856, 37)
        Me.gridbilldetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gridbilldetails.MainView = Me.gridbill
        Me.gridbilldetails.Name = "gridbilldetails"
        Me.gridbilldetails.Size = New System.Drawing.Size(900, 688)
        Me.gridbilldetails.TabIndex = 986
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GTOKENNO, Me.GTOKENTIME, Me.GTYPE, Me.GOPDNO, Me.GMRDNO, Me.GNAME, Me.GAGE, Me.GVILLAGE, Me.GRECDAMT, Me.GUSERNAME})
        Me.gridbill.GridControl = Me.gridbilldetails
        Me.gridbill.Name = "gridbill"
        Me.gridbill.OptionsBehavior.Editable = False
        Me.gridbill.OptionsView.ColumnAutoWidth = False
        Me.gridbill.OptionsView.ShowAutoFilterRow = True
        Me.gridbill.OptionsView.ShowFooter = True
        Me.gridbill.OptionsView.ShowGroupPanel = False
        '
        'GTOKENNO
        '
        Me.GTOKENNO.Caption = "Token No"
        Me.GTOKENNO.FieldName = "TOKENNO"
        Me.GTOKENNO.Name = "GTOKENNO"
        Me.GTOKENNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GTOKENNO.Visible = True
        Me.GTOKENNO.VisibleIndex = 0
        '
        'GTOKENTIME
        '
        Me.GTOKENTIME.Caption = "Time"
        Me.GTOKENTIME.FieldName = "TOKENTIME"
        Me.GTOKENTIME.Name = "GTOKENTIME"
        Me.GTOKENTIME.Visible = True
        Me.GTOKENTIME.VisibleIndex = 1
        '
        'GTYPE
        '
        Me.GTYPE.Caption = "Type"
        Me.GTYPE.FieldName = "TYPE"
        Me.GTYPE.Name = "GTYPE"
        Me.GTYPE.Visible = True
        Me.GTYPE.VisibleIndex = 2
        '
        'GOPDNO
        '
        Me.GOPDNO.Caption = "Sr. No"
        Me.GOPDNO.FieldName = "SRNO"
        Me.GOPDNO.Name = "GOPDNO"
        Me.GOPDNO.Width = 69
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD.No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 3
        Me.GMRDNO.Width = 100
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "PATIENTNAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 4
        Me.GNAME.Width = 200
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 5
        '
        'GVILLAGE
        '
        Me.GVILLAGE.Caption = "Village"
        Me.GVILLAGE.FieldName = "VILLAGE"
        Me.GVILLAGE.Name = "GVILLAGE"
        Me.GVILLAGE.Visible = True
        Me.GVILLAGE.VisibleIndex = 6
        Me.GVILLAGE.Width = 120
        '
        'GRECDAMT
        '
        Me.GRECDAMT.Caption = "Recd Amt"
        Me.GRECDAMT.FieldName = "RECDAMT"
        Me.GRECDAMT.Name = "GRECDAMT"
        Me.GRECDAMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GRECDAMT.Visible = True
        Me.GRECDAMT.VisibleIndex = 7
        '
        'GUSERNAME
        '
        Me.GUSERNAME.Caption = "User Name"
        Me.GUSERNAME.FieldName = "USERNAME"
        Me.GUSERNAME.Name = "GUSERNAME"
        Me.GUSERNAME.Visible = True
        Me.GUSERNAME.VisibleIndex = 8
        '
        'CHKAPPTREC
        '
        Me.CHKAPPTREC.AutoSize = True
        Me.CHKAPPTREC.BackColor = System.Drawing.Color.Transparent
        Me.CHKAPPTREC.Checked = True
        Me.CHKAPPTREC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKAPPTREC.Location = New System.Drawing.Point(541, 353)
        Me.CHKAPPTREC.Name = "CHKAPPTREC"
        Me.CHKAPPTREC.Size = New System.Drawing.Size(139, 19)
        Me.CHKAPPTREC.TabIndex = 985
        Me.CHKAPPTREC.TabStop = False
        Me.CHKAPPTREC.Text = "Appointment Receipt"
        Me.CHKAPPTREC.UseVisualStyleBackColor = False
        '
        'CHKOPDRECEIPT
        '
        Me.CHKOPDRECEIPT.AutoSize = True
        Me.CHKOPDRECEIPT.BackColor = System.Drawing.Color.Transparent
        Me.CHKOPDRECEIPT.Location = New System.Drawing.Point(541, 328)
        Me.CHKOPDRECEIPT.Name = "CHKOPDRECEIPT"
        Me.CHKOPDRECEIPT.Size = New System.Drawing.Size(93, 19)
        Me.CHKOPDRECEIPT.TabIndex = 984
        Me.CHKOPDRECEIPT.TabStop = False
        Me.CHKOPDRECEIPT.Text = "OPD Receipt"
        Me.CHKOPDRECEIPT.UseVisualStyleBackColor = False
        '
        'LBLCANCEL
        '
        Me.LBLCANCEL.AutoSize = True
        Me.LBLCANCEL.BackColor = System.Drawing.Color.Transparent
        Me.LBLCANCEL.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCANCEL.ForeColor = System.Drawing.Color.Red
        Me.LBLCANCEL.Location = New System.Drawing.Point(492, 438)
        Me.LBLCANCEL.Name = "LBLCANCEL"
        Me.LBLCANCEL.Size = New System.Drawing.Size(233, 39)
        Me.LBLCANCEL.TabIndex = 983
        Me.LBLCANCEL.Text = "BILL CANCELLED"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label10.Location = New System.Drawing.Point(491, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 33)
        Me.Label10.TabIndex = 982
        Me.Label10.Text = "Last Renewal :"
        '
        'LBLLASTDATE
        '
        Me.LBLLASTDATE.AutoSize = True
        Me.LBLLASTDATE.BackColor = System.Drawing.Color.Transparent
        Me.LBLLASTDATE.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLASTDATE.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBLLASTDATE.Location = New System.Drawing.Point(670, 381)
        Me.LBLLASTDATE.Name = "LBLLASTDATE"
        Me.LBLLASTDATE.Size = New System.Drawing.Size(151, 33)
        Me.LBLLASTDATE.TabIndex = 981
        Me.LBLLASTDATE.Text = "04/10/2019"
        '
        'CHKALL
        '
        Me.CHKALL.AutoSize = True
        Me.CHKALL.BackColor = System.Drawing.Color.Transparent
        Me.CHKALL.Location = New System.Drawing.Point(541, 253)
        Me.CHKALL.Name = "CHKALL"
        Me.CHKALL.Size = New System.Drawing.Size(84, 19)
        Me.CHKALL.TabIndex = 980
        Me.CHKALL.TabStop = False
        Me.CHKALL.Text = "Print None"
        Me.CHKALL.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 979
        Me.Label1.Text = "Print Documents"
        '
        'CHKOPDDETAILS
        '
        Me.CHKOPDDETAILS.AutoSize = True
        Me.CHKOPDDETAILS.BackColor = System.Drawing.Color.Transparent
        Me.CHKOPDDETAILS.Location = New System.Drawing.Point(541, 278)
        Me.CHKOPDDETAILS.Name = "CHKOPDDETAILS"
        Me.CHKOPDDETAILS.Size = New System.Drawing.Size(114, 19)
        Me.CHKOPDDETAILS.TabIndex = 978
        Me.CHKOPDDETAILS.TabStop = False
        Me.CHKOPDDETAILS.Text = "OPD Report (A4)"
        Me.CHKOPDDETAILS.UseVisualStyleBackColor = False
        '
        'CHKCONSULTATION
        '
        Me.CHKCONSULTATION.AutoSize = True
        Me.CHKCONSULTATION.BackColor = System.Drawing.Color.Transparent
        Me.CHKCONSULTATION.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCONSULTATION.Location = New System.Drawing.Point(112, 67)
        Me.CHKCONSULTATION.Name = "CHKCONSULTATION"
        Me.CHKCONSULTATION.Size = New System.Drawing.Size(122, 18)
        Me.CHKCONSULTATION.TabIndex = 2
        Me.CHKCONSULTATION.TabStop = False
        Me.CHKCONSULTATION.Text = "Free Consultation"
        Me.CHKCONSULTATION.UseVisualStyleBackColor = False
        '
        'TXTBALAMT
        '
        Me.TXTBALAMT.BackColor = System.Drawing.Color.Linen
        Me.TXTBALAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBALAMT.Location = New System.Drawing.Point(361, 481)
        Me.TXTBALAMT.MaxLength = 25
        Me.TXTBALAMT.Name = "TXTBALAMT"
        Me.TXTBALAMT.ReadOnly = True
        Me.TXTBALAMT.Size = New System.Drawing.Size(65, 23)
        Me.TXTBALAMT.TabIndex = 16
        Me.TXTBALAMT.TabStop = False
        Me.TXTBALAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLBALAMT
        '
        Me.LBLBALAMT.AutoSize = True
        Me.LBLBALAMT.BackColor = System.Drawing.Color.Transparent
        Me.LBLBALAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLBALAMT.Location = New System.Drawing.Point(311, 485)
        Me.LBLBALAMT.Name = "LBLBALAMT"
        Me.LBLBALAMT.Size = New System.Drawing.Size(49, 15)
        Me.LBLBALAMT.TabIndex = 42
        Me.LBLBALAMT.Text = "Bal Amt"
        '
        'TXTRECDAMT
        '
        Me.TXTRECDAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRECDAMT.Location = New System.Drawing.Point(361, 453)
        Me.TXTRECDAMT.MaxLength = 25
        Me.TXTRECDAMT.Name = "TXTRECDAMT"
        Me.TXTRECDAMT.Size = New System.Drawing.Size(65, 23)
        Me.TXTRECDAMT.TabIndex = 7
        Me.TXTRECDAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Recd Amt"
        '
        'TXTOCCUPATION
        '
        Me.TXTOCCUPATION.BackColor = System.Drawing.Color.Linen
        Me.TXTOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTOCCUPATION.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTOCCUPATION.Location = New System.Drawing.Point(112, 151)
        Me.TXTOCCUPATION.MaxLength = 50
        Me.TXTOCCUPATION.Name = "TXTOCCUPATION"
        Me.TXTOCCUPATION.ReadOnly = True
        Me.TXTOCCUPATION.Size = New System.Drawing.Size(118, 23)
        Me.TXTOCCUPATION.TabIndex = 6
        Me.TXTOCCUPATION.TabStop = False
        '
        'LBLOCCUPATION
        '
        Me.LBLOCCUPATION.AutoSize = True
        Me.LBLOCCUPATION.BackColor = System.Drawing.Color.Transparent
        Me.LBLOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOCCUPATION.Location = New System.Drawing.Point(43, 155)
        Me.LBLOCCUPATION.Name = "LBLOCCUPATION"
        Me.LBLOCCUPATION.Size = New System.Drawing.Size(70, 15)
        Me.LBLOCCUPATION.TabIndex = 33
        Me.LBLOCCUPATION.Text = "Occupation"
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
        '
        'OPD
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.BlendPanel2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "OPD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OPD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlendPanel2.ResumeLayout(False)
        Me.BlendPanel2.PerformLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents miniToolStrip As ToolStrip
    Friend WithEvents CMDCLEAR As Button
    Friend WithEvents CMDSAVE As Button
    Friend WithEvents CMDEXIT As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TXTSEX As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents TXTPLACE As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TXTMOBILE As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TXTOPDNO As TextBox
    Friend WithEvents DTDATE As DateTimePicker
    Friend WithEvents TXTPATIENTNAME As TextBox
    Friend WithEvents CMDDELETE As Button
    Friend WithEvents TXTSURGEONMOBILE As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents TXTSURGEON As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TXTHTALUKA As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TXTHREGNO As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents TXTHOSPITAL As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents CMBMRDNO As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents TOOLDELETE As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Toolprevious As ToolStripButton
    Friend WithEvents toolnext As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TXTNO As TextBox
    Friend WithEvents LBLTOKENNO As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLTIME As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBAMOUNT As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMDSEARCH As Button
    Friend WithEvents GRIDCHARGES As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTSUBTOTAL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTDISC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTGRANDTOTAL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTINWORDS As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents BlendPanel2 As VbPowerPack.BlendPanel
    Friend WithEvents TXTOCCUPATION As TextBox
    Friend WithEvents LBLOCCUPATION As Label
    Friend WithEvents TXTBALAMT As TextBox
    Friend WithEvents LBLBALAMT As Label
    Friend WithEvents TXTRECDAMT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EP As ErrorProvider
    Friend WithEvents CHKCONSULTATION As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CHKOPDDETAILS As CheckBox
    Friend WithEvents CHKALL As CheckBox
    Friend WithEvents GSRNO As DataGridViewTextBoxColumn
    Friend WithEvents GCHARGE As DataGridViewTextBoxColumn
    Friend WithEvents GAMT As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLLASTDATE As Label
    Friend WithEvents LBLCANCEL As Label
    Friend WithEvents CHKOPDRECEIPT As CheckBox
    Friend WithEvents CHKAPPTREC As CheckBox
    Private WithEvents gridbilldetails As DevExpress.XtraGrid.GridControl
    Private WithEvents gridbill As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GTOKENNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENTIME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GOPDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GVILLAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRECDAMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GUSERNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents CMBTYPE As ComboBox
    Friend WithEvents TXTFOLLOWUPAMT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTRENEWOPDAMT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTNEWOPDAMT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTBILLNO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTFOLLOWUPCOUNT As TextBox
    Friend WithEvents TXTRENEWOPDCOUNT As TextBox
    Friend WithEvents TXTNEWOPDCOUNT As TextBox
    Friend WithEvents DTENTRYDATE As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents CHKOPDDETAILSA5 As CheckBox
End Class
