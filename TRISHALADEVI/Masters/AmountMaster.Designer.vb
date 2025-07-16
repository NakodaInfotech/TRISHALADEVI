<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AmountMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AmountMaster))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.LBLTOTALAMT = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TOOLOPEN = New System.Windows.Forms.ToolStripButton()
        Me.TOOLSAVE = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTAMT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBCHARGES = New System.Windows.Forms.ComboBox()
        Me.TXTSRNO = New System.Windows.Forms.TextBox()
        Me.GRIDCHARGES = New System.Windows.Forms.DataGridView()
        Me.LBLCHARGES = New System.Windows.Forms.Label()
        Me.TXTAMOUNT = New System.Windows.Forms.TextBox()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.LBLAMOUNT = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GSRNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GCHARGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAMT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlendPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.LBLTOTALAMT)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Controls.Add(Me.TXTAMT)
        Me.BlendPanel1.Controls.Add(Me.Label1)
        Me.BlendPanel1.Controls.Add(Me.CMBCHARGES)
        Me.BlendPanel1.Controls.Add(Me.TXTSRNO)
        Me.BlendPanel1.Controls.Add(Me.GRIDCHARGES)
        Me.BlendPanel1.Controls.Add(Me.LBLCHARGES)
        Me.BlendPanel1.Controls.Add(Me.TXTAMOUNT)
        Me.BlendPanel1.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel1.Controls.Add(Me.LBLAMOUNT)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(475, 388)
        Me.BlendPanel1.TabIndex = 0
        '
        'LBLTOTALAMT
        '
        Me.LBLTOTALAMT.BackColor = System.Drawing.Color.Transparent
        Me.LBLTOTALAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTALAMT.ForeColor = System.Drawing.Color.Black
        Me.LBLTOTALAMT.Location = New System.Drawing.Point(284, 316)
        Me.LBLTOTALAMT.Name = "LBLTOTALAMT"
        Me.LBLTOTALAMT.Size = New System.Drawing.Size(103, 15)
        Me.LBLTOTALAMT.TabIndex = 10
        Me.LBLTOTALAMT.Text = "0"
        Me.LBLTOTALAMT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOOLOPEN, Me.TOOLSAVE, Me.TOOLDELETE, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(475, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TOOLOPEN
        '
        Me.TOOLOPEN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TOOLOPEN.Image = CType(resources.GetObject("TOOLOPEN.Image"), System.Drawing.Image)
        Me.TOOLOPEN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOOLOPEN.Name = "TOOLOPEN"
        Me.TOOLOPEN.Size = New System.Drawing.Size(23, 22)
        Me.TOOLOPEN.Text = "&Open"
        '
        'TOOLSAVE
        '
        Me.TOOLSAVE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TOOLSAVE.Image = CType(resources.GetObject("TOOLSAVE.Image"), System.Drawing.Image)
        Me.TOOLSAVE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TOOLSAVE.Name = "TOOLSAVE"
        Me.TOOLSAVE.Size = New System.Drawing.Size(23, 22)
        Me.TOOLSAVE.Text = "&Save"
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
        'TXTAMT
        '
        Me.TXTAMT.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTAMT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAMT.Location = New System.Drawing.Point(286, 86)
        Me.TXTAMT.MaxLength = 100
        Me.TXTAMT.Name = "TXTAMT"
        Me.TXTAMT.Size = New System.Drawing.Size(100, 23)
        Me.TXTAMT.TabIndex = 2
        Me.TXTAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total"
        '
        'CMBCHARGES
        '
        Me.CMBCHARGES.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCHARGES.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCHARGES.DropDownWidth = 300
        Me.CMBCHARGES.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCHARGES.FormattingEnabled = True
        Me.CMBCHARGES.ItemHeight = 15
        Me.CMBCHARGES.Location = New System.Drawing.Point(66, 86)
        Me.CMBCHARGES.MaxDropDownItems = 14
        Me.CMBCHARGES.Name = "CMBCHARGES"
        Me.CMBCHARGES.Size = New System.Drawing.Size(220, 23)
        Me.CMBCHARGES.TabIndex = 1
        '
        'TXTSRNO
        '
        Me.TXTSRNO.BackColor = System.Drawing.Color.Linen
        Me.TXTSRNO.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSRNO.Location = New System.Drawing.Point(26, 86)
        Me.TXTSRNO.Name = "TXTSRNO"
        Me.TXTSRNO.ReadOnly = True
        Me.TXTSRNO.Size = New System.Drawing.Size(40, 23)
        Me.TXTSRNO.TabIndex = 1
        Me.TXTSRNO.TabStop = False
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
        Me.GRIDCHARGES.Location = New System.Drawing.Point(26, 109)
        Me.GRIDCHARGES.Margin = New System.Windows.Forms.Padding(2)
        Me.GRIDCHARGES.MultiSelect = False
        Me.GRIDCHARGES.Name = "GRIDCHARGES"
        Me.GRIDCHARGES.RowHeadersVisible = False
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        Me.GRIDCHARGES.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GRIDCHARGES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRIDCHARGES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRIDCHARGES.Size = New System.Drawing.Size(394, 205)
        Me.GRIDCHARGES.TabIndex = 4
        Me.GRIDCHARGES.TabStop = False
        '
        'LBLCHARGES
        '
        Me.LBLCHARGES.AutoSize = True
        Me.LBLCHARGES.BackColor = System.Drawing.Color.Transparent
        Me.LBLCHARGES.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCHARGES.Location = New System.Drawing.Point(25, 68)
        Me.LBLCHARGES.Name = "LBLCHARGES"
        Me.LBLCHARGES.Size = New System.Drawing.Size(51, 15)
        Me.LBLCHARGES.TabIndex = 11
        Me.LBLCHARGES.Text = "Charges"
        '
        'TXTAMOUNT
        '
        Me.TXTAMOUNT.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTAMOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAMOUNT.Location = New System.Drawing.Point(113, 42)
        Me.TXTAMOUNT.MaxLength = 100
        Me.TXTAMOUNT.Name = "TXTAMOUNT"
        Me.TXTAMOUNT.Size = New System.Drawing.Size(233, 23)
        Me.TXTAMOUNT.TabIndex = 0
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(240, 348)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 5
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
        Me.CMDEXIT.Location = New System.Drawing.Point(326, 348)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 6
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
        Me.CMDOK.Location = New System.Drawing.Point(68, 348)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 3
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
        Me.CMDCLEAR.Location = New System.Drawing.Point(154, 348)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 4
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'LBLAMOUNT
        '
        Me.LBLAMOUNT.AutoSize = True
        Me.LBLAMOUNT.BackColor = System.Drawing.Color.Transparent
        Me.LBLAMOUNT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAMOUNT.Location = New System.Drawing.Point(62, 46)
        Me.LBLAMOUNT.Name = "LBLAMOUNT"
        Me.LBLAMOUNT.Size = New System.Drawing.Size(49, 15)
        Me.LBLAMOUNT.TabIndex = 12
        Me.LBLAMOUNT.Text = "Amount"
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
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
        'AmountMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(475, 388)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "AmountMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Amount Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GRIDCHARGES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents CMBCHARGES As ComboBox
    Friend WithEvents TXTSRNO As TextBox
    Friend WithEvents GRIDCHARGES As DataGridView
    Friend WithEvents LBLCHARGES As Label
    Friend WithEvents TXTAMOUNT As TextBox
    Friend WithEvents CMDDELETE As Button
    Friend WithEvents CMDEXIT As Button
    Friend WithEvents CMDOK As Button
    Friend WithEvents CMDCLEAR As Button
    Friend WithEvents LBLAMOUNT As Label
    Friend WithEvents TXTAMT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TOOLOPEN As ToolStripButton
    Friend WithEvents TOOLSAVE As ToolStripButton
    Friend WithEvents TOOLDELETE As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EP As ErrorProvider
    Friend WithEvents LBLTOTALAMT As Label
    Friend WithEvents GSRNO As DataGridViewTextBoxColumn
    Friend WithEvents GCHARGE As DataGridViewTextBoxColumn
    Friend WithEvents GAMT As DataGridViewTextBoxColumn
End Class
