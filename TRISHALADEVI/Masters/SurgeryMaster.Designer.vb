<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SurgeryMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SurgeryMaster))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.TXTRATE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CMBOPERATIVEPROC = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTPOSTINSTERCUTION = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBMEDICINE = New System.Windows.Forms.ComboBox()
        Me.CMBANATHESIA = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTPOSTORDERS = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTPREORDERS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCHEIF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMBCHARGES = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBEYE = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTMEDSRNO = New System.Windows.Forms.TextBox()
        Me.GRIDMEDICINES = New System.Windows.Forms.DataGridView()
        Me.GMEDSRNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMEDICINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPROCEDURE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BlendPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GRIDMEDICINES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.TXTRATE)
        Me.BlendPanel1.Controls.Add(Me.Label8)
        Me.BlendPanel1.Controls.Add(Me.CMBOPERATIVEPROC)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Controls.Add(Me.TXTPOSTINSTERCUTION)
        Me.BlendPanel1.Controls.Add(Me.Label3)
        Me.BlendPanel1.Controls.Add(Me.CMBMEDICINE)
        Me.BlendPanel1.Controls.Add(Me.CMBANATHESIA)
        Me.BlendPanel1.Controls.Add(Me.Label12)
        Me.BlendPanel1.Controls.Add(Me.TXTPOSTORDERS)
        Me.BlendPanel1.Controls.Add(Me.Label11)
        Me.BlendPanel1.Controls.Add(Me.TXTPREORDERS)
        Me.BlendPanel1.Controls.Add(Me.Label10)
        Me.BlendPanel1.Controls.Add(Me.TXTCHEIF)
        Me.BlendPanel1.Controls.Add(Me.Label7)
        Me.BlendPanel1.Controls.Add(Me.Label5)
        Me.BlendPanel1.Controls.Add(Me.CMBCHARGES)
        Me.BlendPanel1.Controls.Add(Me.Label4)
        Me.BlendPanel1.Controls.Add(Me.CMBEYE)
        Me.BlendPanel1.Controls.Add(Me.Label9)
        Me.BlendPanel1.Controls.Add(Me.TXTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTMEDSRNO)
        Me.BlendPanel1.Controls.Add(Me.GRIDMEDICINES)
        Me.BlendPanel1.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.TXTPROCEDURE)
        Me.BlendPanel1.Controls.Add(Me.Label6)
        Me.BlendPanel1.Controls.Add(Me.Label15)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1140, 574)
        Me.BlendPanel1.TabIndex = 0
        '
        'TXTRATE
        '
        Me.TXTRATE.BackColor = System.Drawing.Color.White
        Me.TXTRATE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRATE.ForeColor = System.Drawing.Color.Black
        Me.TXTRATE.Location = New System.Drawing.Point(891, 198)
        Me.TXTRATE.Name = "TXTRATE"
        Me.TXTRATE.Size = New System.Drawing.Size(63, 22)
        Me.TXTRATE.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(854, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 15)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Rate"
        '
        'CMBOPERATIVEPROC
        '
        Me.CMBOPERATIVEPROC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBOPERATIVEPROC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBOPERATIVEPROC.DropDownWidth = 300
        Me.CMBOPERATIVEPROC.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBOPERATIVEPROC.FormattingEnabled = True
        Me.CMBOPERATIVEPROC.ItemHeight = 15
        Me.CMBOPERATIVEPROC.Location = New System.Drawing.Point(130, 98)
        Me.CMBOPERATIVEPROC.MaxDropDownItems = 14
        Me.CMBOPERATIVEPROC.Name = "CMBOPERATIVEPROC"
        Me.CMBOPERATIVEPROC.Size = New System.Drawing.Size(381, 23)
        Me.CMBOPERATIVEPROC.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.TOOLDELETE, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1140, 25)
        Me.ToolStrip1.TabIndex = 80
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
        'TXTPOSTINSTERCUTION
        '
        Me.TXTPOSTINSTERCUTION.BackColor = System.Drawing.Color.White
        Me.TXTPOSTINSTERCUTION.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPOSTINSTERCUTION.ForeColor = System.Drawing.Color.Black
        Me.TXTPOSTINSTERCUTION.Location = New System.Drawing.Point(745, 289)
        Me.TXTPOSTINSTERCUTION.Multiline = True
        Me.TXTPOSTINSTERCUTION.Name = "TXTPOSTINSTERCUTION"
        Me.TXTPOSTINSTERCUTION.Size = New System.Drawing.Size(427, 198)
        Me.TXTPOSTINSTERCUTION.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(742, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Post Op Instructions"
        '
        'CMBMEDICINE
        '
        Me.CMBMEDICINE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBMEDICINE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBMEDICINE.DropDownWidth = 300
        Me.CMBMEDICINE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEDICINE.FormattingEnabled = True
        Me.CMBMEDICINE.ItemHeight = 14
        Me.CMBMEDICINE.Location = New System.Drawing.Point(560, 118)
        Me.CMBMEDICINE.MaxDropDownItems = 14
        Me.CMBMEDICINE.Name = "CMBMEDICINE"
        Me.CMBMEDICINE.Size = New System.Drawing.Size(220, 22)
        Me.CMBMEDICINE.TabIndex = 9
        '
        'CMBANATHESIA
        '
        Me.CMBANATHESIA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBANATHESIA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBANATHESIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBANATHESIA.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBANATHESIA.FormattingEnabled = True
        Me.CMBANATHESIA.Items.AddRange(New Object() {"", "LOCAL ANAESTHESIA", "GENERAL ANAESTHESIA", "STAND BY", "UNDER SEDATION"})
        Me.CMBANATHESIA.Location = New System.Drawing.Point(130, 262)
        Me.CMBANATHESIA.MaxDropDownItems = 14
        Me.CMBANATHESIA.Name = "CMBANATHESIA"
        Me.CMBANATHESIA.Size = New System.Drawing.Size(147, 22)
        Me.CMBANATHESIA.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(55, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 15)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Anaesthesia"
        '
        'TXTPOSTORDERS
        '
        Me.TXTPOSTORDERS.BackColor = System.Drawing.Color.White
        Me.TXTPOSTORDERS.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPOSTORDERS.ForeColor = System.Drawing.Color.Black
        Me.TXTPOSTORDERS.Location = New System.Drawing.Point(130, 214)
        Me.TXTPOSTORDERS.Multiline = True
        Me.TXTPOSTORDERS.Name = "TXTPOSTORDERS"
        Me.TXTPOSTORDERS.Size = New System.Drawing.Size(381, 42)
        Me.TXTPOSTORDERS.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 218)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Post Op Orders"
        '
        'TXTPREORDERS
        '
        Me.TXTPREORDERS.BackColor = System.Drawing.Color.White
        Me.TXTPREORDERS.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPREORDERS.ForeColor = System.Drawing.Color.Black
        Me.TXTPREORDERS.Location = New System.Drawing.Point(130, 155)
        Me.TXTPREORDERS.Multiline = True
        Me.TXTPREORDERS.Name = "TXTPREORDERS"
        Me.TXTPREORDERS.Size = New System.Drawing.Size(381, 53)
        Me.TXTPREORDERS.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Pre Op Orders"
        '
        'TXTCHEIF
        '
        Me.TXTCHEIF.BackColor = System.Drawing.Color.White
        Me.TXTCHEIF.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCHEIF.ForeColor = System.Drawing.Color.Black
        Me.TXTCHEIF.Location = New System.Drawing.Point(130, 127)
        Me.TXTCHEIF.Name = "TXTCHEIF"
        Me.TXTCHEIF.Size = New System.Drawing.Size(233, 22)
        Me.TXTCHEIF.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cheif Complaints"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Operation Procedure"
        '
        'CMBCHARGES
        '
        Me.CMBCHARGES.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCHARGES.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCHARGES.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBCHARGES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCHARGES.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCHARGES.FormattingEnabled = True
        Me.CMBCHARGES.Items.AddRange(New Object() {"SURGICAL CHARGES", "LASER CHARGES", "INJECTION FEE"})
        Me.CMBCHARGES.Location = New System.Drawing.Point(904, 70)
        Me.CMBCHARGES.Name = "CMBCHARGES"
        Me.CMBCHARGES.Size = New System.Drawing.Size(147, 23)
        Me.CMBCHARGES.TabIndex = 2
        Me.CMBCHARGES.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(813, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Type of Charge"
        Me.Label4.Visible = False
        '
        'CMBEYE
        '
        Me.CMBEYE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBEYE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBEYE.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBEYE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBEYE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEYE.FormattingEnabled = True
        Me.CMBEYE.Items.AddRange(New Object() {"RIGHT", "LEFT"})
        Me.CMBEYE.Location = New System.Drawing.Point(130, 69)
        Me.CMBEYE.Name = "CMBEYE"
        Me.CMBEYE.Size = New System.Drawing.Size(83, 23)
        Me.CMBEYE.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(100, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Eye"
        '
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTNAME.Location = New System.Drawing.Point(130, 40)
        Me.TXTNAME.MaxLength = 100
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTNAME.TabIndex = 0
        '
        'TXTMEDSRNO
        '
        Me.TXTMEDSRNO.BackColor = System.Drawing.Color.Linen
        Me.TXTMEDSRNO.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMEDSRNO.Location = New System.Drawing.Point(520, 118)
        Me.TXTMEDSRNO.Name = "TXTMEDSRNO"
        Me.TXTMEDSRNO.ReadOnly = True
        Me.TXTMEDSRNO.Size = New System.Drawing.Size(40, 22)
        Me.TXTMEDSRNO.TabIndex = 10
        Me.TXTMEDSRNO.TabStop = False
        '
        'GRIDMEDICINES
        '
        Me.GRIDMEDICINES.AllowUserToAddRows = False
        Me.GRIDMEDICINES.AllowUserToDeleteRows = False
        Me.GRIDMEDICINES.AllowUserToResizeColumns = False
        Me.GRIDMEDICINES.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.GRIDMEDICINES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRIDMEDICINES.BackgroundColor = System.Drawing.Color.White
        Me.GRIDMEDICINES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRIDMEDICINES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRIDMEDICINES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRIDMEDICINES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRIDMEDICINES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GMEDSRNO, Me.GMEDICINE})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRIDMEDICINES.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRIDMEDICINES.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRIDMEDICINES.Location = New System.Drawing.Point(520, 140)
        Me.GRIDMEDICINES.Margin = New System.Windows.Forms.Padding(2)
        Me.GRIDMEDICINES.MultiSelect = False
        Me.GRIDMEDICINES.Name = "GRIDMEDICINES"
        Me.GRIDMEDICINES.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        Me.GRIDMEDICINES.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GRIDMEDICINES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRIDMEDICINES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRIDMEDICINES.Size = New System.Drawing.Size(292, 115)
        Me.GRIDMEDICINES.TabIndex = 10
        Me.GRIDMEDICINES.TabStop = False
        '
        'GMEDSRNO
        '
        Me.GMEDSRNO.HeaderText = "Sr."
        Me.GMEDSRNO.Name = "GMEDSRNO"
        Me.GMEDSRNO.ReadOnly = True
        Me.GMEDSRNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GMEDSRNO.Width = 40
        '
        'GMEDICINE
        '
        Me.GMEDICINE.HeaderText = "Name of Medicine"
        Me.GMEDICINE.Name = "GMEDICINE"
        Me.GMEDICINE.ReadOnly = True
        Me.GMEDICINE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.GMEDICINE.Width = 220
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(573, 493)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 15
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
        Me.CMDEXIT.Location = New System.Drawing.Point(659, 493)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 16
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
        Me.CMDOK.Location = New System.Drawing.Point(401, 493)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 13
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
        Me.CMDCLEAR.Location = New System.Drawing.Point(487, 493)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 14
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Medicines"
        '
        'TXTPROCEDURE
        '
        Me.TXTPROCEDURE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTPROCEDURE.Location = New System.Drawing.Point(130, 290)
        Me.TXTPROCEDURE.Multiline = True
        Me.TXTPROCEDURE.Name = "TXTPROCEDURE"
        Me.TXTPROCEDURE.Size = New System.Drawing.Size(596, 198)
        Me.TXTPROCEDURE.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(70, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "OT Notes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(44, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 15)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Surgery Name"
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
        '
        'SurgeryMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1140, 574)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SurgeryMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Surgery Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GRIDMEDICINES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTPROCEDURE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CMDDELETE As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents CMDCLEAR As System.Windows.Forms.Button
    Friend WithEvents EP As System.Windows.Forms.ErrorProvider
    Friend WithEvents TXTMEDSRNO As System.Windows.Forms.TextBox
    Friend WithEvents GRIDMEDICINES As System.Windows.Forms.DataGridView
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents GMEDSRNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GMEDICINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMBEYE As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CMBCHARGES As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CMBANATHESIA As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTPOSTORDERS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTPREORDERS As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCHEIF As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CMBMEDICINE As ComboBox
    Friend WithEvents TXTPOSTINSTERCUTION As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents TOOLDELETE As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CMBOPERATIVEPROC As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTRATE As TextBox
End Class
