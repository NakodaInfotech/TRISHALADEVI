<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiscSale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiscSale))
        Me.BlendPanel2 = New VbPowerPack.BlendPanel()
        Me.TXTREMARKS = New System.Windows.Forms.TextBox()
        Me.LBLREMARK = New System.Windows.Forms.Label()
        Me.TXTBILLNO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CHKALL = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTBALAMT = New System.Windows.Forms.TextBox()
        Me.LBLBALAMT = New System.Windows.Forms.Label()
        Me.TXTRECDAMT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTOCCUPATION = New System.Windows.Forms.TextBox()
        Me.LBLOCCUPATION = New System.Windows.Forms.Label()
        Me.TXTINWORDS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTGRANDTOTAL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTDISC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTSUBTOTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GRIDCHARGES = New System.Windows.Forms.DataGridView()
        Me.GSRNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GCHARGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAMT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMDSEARCH = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBAMOUNT = New System.Windows.Forms.ComboBox()
        Me.TXTNO = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Toolprevious = New System.Windows.Forms.ToolStripButton()
        Me.toolnext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CMBMRDNO = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.TXTPATIENTNAME = New System.Windows.Forms.TextBox()
        Me.DTDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXTMOBILE = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TXTPLACE = New System.Windows.Forms.TextBox()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TXTSEX = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBDOCTOR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTCOMMPER = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCOMMAMT = New System.Windows.Forms.TextBox()
        Me.BlendPanel2.SuspendLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel2
        '
        Me.BlendPanel2.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel2.Controls.Add(Me.Label10)
        Me.BlendPanel2.Controls.Add(Me.TXTCOMMAMT)
        Me.BlendPanel2.Controls.Add(Me.Label3)
        Me.BlendPanel2.Controls.Add(Me.TXTCOMMPER)
        Me.BlendPanel2.Controls.Add(Me.Label2)
        Me.BlendPanel2.Controls.Add(Me.CMBDOCTOR)
        Me.BlendPanel2.Controls.Add(Me.TXTREMARKS)
        Me.BlendPanel2.Controls.Add(Me.LBLREMARK)
        Me.BlendPanel2.Controls.Add(Me.TXTBILLNO)
        Me.BlendPanel2.Controls.Add(Me.Label15)
        Me.BlendPanel2.Controls.Add(Me.CHKALL)
        Me.BlendPanel2.Controls.Add(Me.Label1)
        Me.BlendPanel2.Controls.Add(Me.TXTBALAMT)
        Me.BlendPanel2.Controls.Add(Me.LBLBALAMT)
        Me.BlendPanel2.Controls.Add(Me.TXTRECDAMT)
        Me.BlendPanel2.Controls.Add(Me.Label9)
        Me.BlendPanel2.Controls.Add(Me.TXTOCCUPATION)
        Me.BlendPanel2.Controls.Add(Me.LBLOCCUPATION)
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
        Me.BlendPanel2.Controls.Add(Me.TXTNO)
        Me.BlendPanel2.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel2.Controls.Add(Me.CMBMRDNO)
        Me.BlendPanel2.Controls.Add(Me.Label30)
        Me.BlendPanel2.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel2.Controls.Add(Me.TXTPATIENTNAME)
        Me.BlendPanel2.Controls.Add(Me.DTDATE)
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
        Me.BlendPanel2.Controls.Add(Me.Label32)
        Me.BlendPanel2.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel2.Controls.Add(Me.CMDSAVE)
        Me.BlendPanel2.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel2.Name = "BlendPanel2"
        Me.BlendPanel2.Size = New System.Drawing.Size(619, 558)
        Me.BlendPanel2.TabIndex = 0
        '
        'TXTREMARKS
        '
        Me.TXTREMARKS.BackColor = System.Drawing.Color.White
        Me.TXTREMARKS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREMARKS.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTREMARKS.Location = New System.Drawing.Point(70, 436)
        Me.TXTREMARKS.MaxLength = 50
        Me.TXTREMARKS.Multiline = True
        Me.TXTREMARKS.Name = "TXTREMARKS"
        Me.TXTREMARKS.Size = New System.Drawing.Size(203, 65)
        Me.TXTREMARKS.TabIndex = 17
        '
        'LBLREMARK
        '
        Me.LBLREMARK.AutoSize = True
        Me.LBLREMARK.BackColor = System.Drawing.Color.Transparent
        Me.LBLREMARK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLREMARK.Location = New System.Drawing.Point(14, 442)
        Me.LBLREMARK.Name = "LBLREMARK"
        Me.LBLREMARK.Size = New System.Drawing.Size(54, 15)
        Me.LBLREMARK.TabIndex = 997
        Me.LBLREMARK.Text = "Remarks"
        '
        'TXTBILLNO
        '
        Me.TXTBILLNO.BackColor = System.Drawing.Color.Linen
        Me.TXTBILLNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBILLNO.Location = New System.Drawing.Point(513, 34)
        Me.TXTBILLNO.MaxLength = 100
        Me.TXTBILLNO.Name = "TXTBILLNO"
        Me.TXTBILLNO.Size = New System.Drawing.Size(90, 23)
        Me.TXTBILLNO.TabIndex = 0
        Me.TXTBILLNO.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(467, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 15)
        Me.Label15.TabIndex = 995
        Me.Label15.Text = "Bill No"
        '
        'CHKALL
        '
        Me.CHKALL.AutoSize = True
        Me.CHKALL.BackColor = System.Drawing.Color.Transparent
        Me.CHKALL.Checked = True
        Me.CHKALL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKALL.Location = New System.Drawing.Point(481, 118)
        Me.CHKALL.Name = "CHKALL"
        Me.CHKALL.Size = New System.Drawing.Size(96, 19)
        Me.CHKALL.TabIndex = 980
        Me.CHKALL.TabStop = False
        Me.CHKALL.Text = "Misc Receipt"
        Me.CHKALL.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(478, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 979
        Me.Label1.Text = "Print Documents"
        '
        'TXTBALAMT
        '
        Me.TXTBALAMT.BackColor = System.Drawing.Color.Linen
        Me.TXTBALAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBALAMT.Location = New System.Drawing.Point(361, 451)
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
        Me.LBLBALAMT.Location = New System.Drawing.Point(311, 455)
        Me.LBLBALAMT.Name = "LBLBALAMT"
        Me.LBLBALAMT.Size = New System.Drawing.Size(49, 15)
        Me.LBLBALAMT.TabIndex = 42
        Me.LBLBALAMT.Text = "Bal Amt"
        '
        'TXTRECDAMT
        '
        Me.TXTRECDAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRECDAMT.Location = New System.Drawing.Point(361, 423)
        Me.TXTRECDAMT.MaxLength = 25
        Me.TXTRECDAMT.Name = "TXTRECDAMT"
        Me.TXTRECDAMT.Size = New System.Drawing.Size(65, 23)
        Me.TXTRECDAMT.TabIndex = 16
        Me.TXTRECDAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(302, 427)
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
        Me.TXTOCCUPATION.Location = New System.Drawing.Point(112, 122)
        Me.TXTOCCUPATION.MaxLength = 50
        Me.TXTOCCUPATION.Name = "TXTOCCUPATION"
        Me.TXTOCCUPATION.ReadOnly = True
        Me.TXTOCCUPATION.Size = New System.Drawing.Size(118, 23)
        Me.TXTOCCUPATION.TabIndex = 7
        Me.TXTOCCUPATION.TabStop = False
        '
        'LBLOCCUPATION
        '
        Me.LBLOCCUPATION.AutoSize = True
        Me.LBLOCCUPATION.BackColor = System.Drawing.Color.Transparent
        Me.LBLOCCUPATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOCCUPATION.Location = New System.Drawing.Point(40, 126)
        Me.LBLOCCUPATION.Name = "LBLOCCUPATION"
        Me.LBLOCCUPATION.Size = New System.Drawing.Size(70, 15)
        Me.LBLOCCUPATION.TabIndex = 33
        Me.LBLOCCUPATION.Text = "Occupation"
        '
        'TXTINWORDS
        '
        Me.TXTINWORDS.BackColor = System.Drawing.Color.Linen
        Me.TXTINWORDS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTINWORDS.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTINWORDS.Location = New System.Drawing.Point(70, 341)
        Me.TXTINWORDS.MaxLength = 50
        Me.TXTINWORDS.Multiline = True
        Me.TXTINWORDS.Name = "TXTINWORDS"
        Me.TXTINWORDS.ReadOnly = True
        Me.TXTINWORDS.Size = New System.Drawing.Size(203, 89)
        Me.TXTINWORDS.TabIndex = 17
        Me.TXTINWORDS.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "In Words"
        '
        'TXTGRANDTOTAL
        '
        Me.TXTGRANDTOTAL.BackColor = System.Drawing.Color.Linen
        Me.TXTGRANDTOTAL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGRANDTOTAL.Location = New System.Drawing.Point(361, 394)
        Me.TXTGRANDTOTAL.MaxLength = 25
        Me.TXTGRANDTOTAL.Name = "TXTGRANDTOTAL"
        Me.TXTGRANDTOTAL.ReadOnly = True
        Me.TXTGRANDTOTAL.Size = New System.Drawing.Size(65, 23)
        Me.TXTGRANDTOTAL.TabIndex = 14
        Me.TXTGRANDTOTAL.TabStop = False
        Me.TXTGRANDTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(291, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 15)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Grand Total"
        '
        'TXTDISC
        '
        Me.TXTDISC.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDISC.Location = New System.Drawing.Point(361, 365)
        Me.TXTDISC.MaxLength = 25
        Me.TXTDISC.Name = "TXTDISC"
        Me.TXTDISC.Size = New System.Drawing.Size(65, 23)
        Me.TXTDISC.TabIndex = 14
        Me.TXTDISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(306, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Discount"
        '
        'TXTSUBTOTAL
        '
        Me.TXTSUBTOTAL.BackColor = System.Drawing.Color.Linen
        Me.TXTSUBTOTAL.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSUBTOTAL.Location = New System.Drawing.Point(361, 336)
        Me.TXTSUBTOTAL.MaxLength = 25
        Me.TXTSUBTOTAL.Name = "TXTSUBTOTAL"
        Me.TXTSUBTOTAL.ReadOnly = True
        Me.TXTSUBTOTAL.Size = New System.Drawing.Size(65, 23)
        Me.TXTSUBTOTAL.TabIndex = 15
        Me.TXTSUBTOTAL.TabStop = False
        Me.TXTSUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(308, 340)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Subtotal"
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
        Me.GRIDCHARGES.Location = New System.Drawing.Point(67, 213)
        Me.GRIDCHARGES.Margin = New System.Windows.Forms.Padding(2)
        Me.GRIDCHARGES.MultiSelect = False
        Me.GRIDCHARGES.Name = "GRIDCHARGES"
        Me.GRIDCHARGES.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        Me.GRIDCHARGES.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRIDCHARGES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRIDCHARGES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRIDCHARGES.Size = New System.Drawing.Size(394, 118)
        Me.GRIDCHARGES.TabIndex = 22
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
        Me.CMDSEARCH.TabIndex = 3
        Me.CMDSEARCH.Text = "S&earch"
        Me.CMDSEARCH.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Amount"
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
        Me.CMBAMOUNT.TabIndex = 13
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
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.TOOLDELETE, Me.ToolStripSeparator1, Me.Toolprevious, Me.toolnext, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(619, 25)
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
        Me.CMBMRDNO.TabIndex = 2
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
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(312, 519)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 20
        Me.CMDDELETE.Text = "&Delete"
        Me.CMDDELETE.UseVisualStyleBackColor = False
        '
        'TXTPATIENTNAME
        '
        Me.TXTPATIENTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTPATIENTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPATIENTNAME.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTPATIENTNAME.Location = New System.Drawing.Point(112, 64)
        Me.TXTPATIENTNAME.MaxLength = 50
        Me.TXTPATIENTNAME.Name = "TXTPATIENTNAME"
        Me.TXTPATIENTNAME.ReadOnly = True
        Me.TXTPATIENTNAME.Size = New System.Drawing.Size(314, 23)
        Me.TXTPATIENTNAME.TabIndex = 4
        Me.TXTPATIENTNAME.TabStop = False
        '
        'DTDATE
        '
        Me.DTDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTDATE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTDATE.Location = New System.Drawing.Point(513, 62)
        Me.DTDATE.Name = "DTDATE"
        Me.DTDATE.Size = New System.Drawing.Size(90, 23)
        Me.DTDATE.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(476, 66)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 15)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = " Date"
        '
        'TXTMOBILE
        '
        Me.TXTMOBILE.BackColor = System.Drawing.Color.Linen
        Me.TXTMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOBILE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTMOBILE.Location = New System.Drawing.Point(112, 93)
        Me.TXTMOBILE.MaxLength = 50
        Me.TXTMOBILE.Name = "TXTMOBILE"
        Me.TXTMOBILE.ReadOnly = True
        Me.TXTMOBILE.Size = New System.Drawing.Size(118, 23)
        Me.TXTMOBILE.TabIndex = 5
        Me.TXTMOBILE.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 97)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 15)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Contact No."
        '
        'TXTPLACE
        '
        Me.TXTPLACE.BackColor = System.Drawing.Color.Linen
        Me.TXTPLACE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPLACE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTPLACE.Location = New System.Drawing.Point(287, 93)
        Me.TXTPLACE.MaxLength = 50
        Me.TXTPLACE.Name = "TXTPLACE"
        Me.TXTPLACE.ReadOnly = True
        Me.TXTPLACE.Size = New System.Drawing.Size(139, 23)
        Me.TXTPLACE.TabIndex = 6
        Me.TXTPLACE.TabStop = False
        '
        'TXTAGE
        '
        Me.TXTAGE.BackColor = System.Drawing.Color.Linen
        Me.TXTAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAGE.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTAGE.Location = New System.Drawing.Point(287, 122)
        Me.TXTAGE.MaxLength = 50
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.ReadOnly = True
        Me.TXTAGE.Size = New System.Drawing.Size(55, 23)
        Me.TXTAGE.TabIndex = 8
        Me.TXTAGE.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(344, 126)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 15)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Sex"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(249, 97)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 15)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Place"
        '
        'TXTSEX
        '
        Me.TXTSEX.BackColor = System.Drawing.Color.Linen
        Me.TXTSEX.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEX.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTSEX.Location = New System.Drawing.Point(371, 122)
        Me.TXTSEX.MaxLength = 50
        Me.TXTSEX.Name = "TXTSEX"
        Me.TXTSEX.ReadOnly = True
        Me.TXTSEX.Size = New System.Drawing.Size(55, 23)
        Me.TXTSEX.TabIndex = 9
        Me.TXTSEX.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(256, 126)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(26, 15)
        Me.Label28.TabIndex = 30
        Me.Label28.Text = "Age"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 68)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 15)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "Name Of Patient "
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
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(398, 519)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 21
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.Transparent
        Me.CMDSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSAVE.FlatAppearance.BorderSize = 0
        Me.CMDSAVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSAVE.ForeColor = System.Drawing.Color.Black
        Me.CMDSAVE.Location = New System.Drawing.Point(140, 519)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDSAVE.TabIndex = 18
        Me.CMDSAVE.Text = "&Save"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'CMDCLEAR
        '
        Me.CMDCLEAR.BackColor = System.Drawing.Color.Transparent
        Me.CMDCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDCLEAR.FlatAppearance.BorderSize = 0
        Me.CMDCLEAR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCLEAR.ForeColor = System.Drawing.Color.Black
        Me.CMDCLEAR.Location = New System.Drawing.Point(226, 519)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 19
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 999
        Me.Label2.Text = "Ref Doctor"
        '
        'CMBDOCTOR
        '
        Me.CMBDOCTOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBDOCTOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBDOCTOR.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBDOCTOR.DropDownWidth = 300
        Me.CMBDOCTOR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDOCTOR.FormattingEnabled = True
        Me.CMBDOCTOR.ItemHeight = 15
        Me.CMBDOCTOR.Location = New System.Drawing.Point(112, 151)
        Me.CMBDOCTOR.MaxDropDownItems = 14
        Me.CMBDOCTOR.Name = "CMBDOCTOR"
        Me.CMBDOCTOR.Size = New System.Drawing.Size(230, 23)
        Me.CMBDOCTOR.TabIndex = 10
        Me.CMBDOCTOR.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 1001
        Me.Label3.Text = "%"
        '
        'TXTCOMMPER
        '
        Me.TXTCOMMPER.BackColor = System.Drawing.Color.White
        Me.TXTCOMMPER.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOMMPER.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTCOMMPER.Location = New System.Drawing.Point(371, 151)
        Me.TXTCOMMPER.MaxLength = 50
        Me.TXTCOMMPER.Name = "TXTCOMMPER"
        Me.TXTCOMMPER.ReadOnly = True
        Me.TXTCOMMPER.Size = New System.Drawing.Size(55, 23)
        Me.TXTCOMMPER.TabIndex = 11
        Me.TXTCOMMPER.TabStop = False
        Me.TXTCOMMPER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 15)
        Me.Label10.TabIndex = 1003
        Me.Label10.Text = "Comm Amt"
        '
        'TXTCOMMAMT
        '
        Me.TXTCOMMAMT.BackColor = System.Drawing.Color.White
        Me.TXTCOMMAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOMMAMT.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TXTCOMMAMT.Location = New System.Drawing.Point(516, 151)
        Me.TXTCOMMAMT.MaxLength = 50
        Me.TXTCOMMAMT.Name = "TXTCOMMAMT"
        Me.TXTCOMMAMT.ReadOnly = True
        Me.TXTCOMMAMT.Size = New System.Drawing.Size(68, 23)
        Me.TXTCOMMAMT.TabIndex = 12
        Me.TXTCOMMAMT.TabStop = False
        Me.TXTCOMMAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MiscSale
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(619, 558)
        Me.Controls.Add(Me.BlendPanel2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "MiscSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Misc Sale"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel2.ResumeLayout(False)
        Me.BlendPanel2.PerformLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel2 As VbPowerPack.BlendPanel
    Friend WithEvents TXTBILLNO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CHKALL As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTBALAMT As TextBox
    Friend WithEvents LBLBALAMT As Label
    Friend WithEvents TXTRECDAMT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTOCCUPATION As TextBox
    Friend WithEvents LBLOCCUPATION As Label
    Friend WithEvents TXTINWORDS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTGRANDTOTAL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTDISC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTSUBTOTAL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GRIDCHARGES As DataGridView
    Friend WithEvents GSRNO As DataGridViewTextBoxColumn
    Friend WithEvents GCHARGE As DataGridViewTextBoxColumn
    Friend WithEvents GAMT As DataGridViewTextBoxColumn
    Friend WithEvents CMDSEARCH As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CMBAMOUNT As ComboBox
    Friend WithEvents TXTNO As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents TOOLDELETE As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Toolprevious As ToolStripButton
    Friend WithEvents toolnext As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CMBMRDNO As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents CMDDELETE As Button
    Friend WithEvents TXTPATIENTNAME As TextBox
    Friend WithEvents DTDATE As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents TXTMOBILE As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TXTPLACE As TextBox
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TXTSEX As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents CMDEXIT As Button
    Friend WithEvents CMDSAVE As Button
    Friend WithEvents CMDCLEAR As Button
    Friend WithEvents TXTREMARKS As TextBox
    Friend WithEvents LBLREMARK As Label
    Friend WithEvents EP As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCOMMAMT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTCOMMPER As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBDOCTOR As ComboBox
End Class
