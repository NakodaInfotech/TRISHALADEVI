<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorMaster))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TOOLDELETE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTMOBILE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TXTADDRESS = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.CMBCOUNTRY = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CMDDELETE = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.CMDOK = New System.Windows.Forms.Button()
        Me.CMDCLEAR = New System.Windows.Forms.Button()
        Me.CMBSTATE = New System.Windows.Forms.ComboBox()
        Me.CMBCITY = New System.Windows.Forms.ComboBox()
        Me.CMBAREA = New System.Windows.Forms.ComboBox()
        Me.CMBSEX = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CMBSPECIALIZATION = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLVILLAGE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlendPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.TOOLDELETE, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(513, 25)
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
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.Location = New System.Drawing.Point(149, 44)
        Me.TXTNAME.MaxLength = 100
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTNAME.TabIndex = 0
        '
        'TXTMOBILE
        '
        Me.TXTMOBILE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMOBILE.Location = New System.Drawing.Point(149, 325)
        Me.TXTMOBILE.MaxLength = 25
        Me.TXTMOBILE.Name = "TXTMOBILE"
        Me.TXTMOBILE.Size = New System.Drawing.Size(233, 23)
        Me.TXTMOBILE.TabIndex = 9
        Me.TXTMOBILE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(102, 329)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Mobile"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(97, 276)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Address"
        '
        'EP
        '
        Me.EP.BlinkRate = 0
        Me.EP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.EP.ContainerControl = Me
        '
        'TXTADDRESS
        '
        Me.TXTADDRESS.BackColor = System.Drawing.SystemColors.Window
        Me.TXTADDRESS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTADDRESS.ForeColor = System.Drawing.Color.Black
        Me.TXTADDRESS.Location = New System.Drawing.Point(149, 247)
        Me.TXTADDRESS.MaxLength = 200
        Me.TXTADDRESS.Multiline = True
        Me.TXTADDRESS.Name = "TXTADDRESS"
        Me.TXTADDRESS.Size = New System.Drawing.Size(233, 72)
        Me.TXTADDRESS.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.CMBCOUNTRY)
        Me.BlendPanel1.Controls.Add(Me.Label5)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Controls.Add(Me.TXTNAME)
        Me.BlendPanel1.Controls.Add(Me.TXTMOBILE)
        Me.BlendPanel1.Controls.Add(Me.Label13)
        Me.BlendPanel1.Controls.Add(Me.Label12)
        Me.BlendPanel1.Controls.Add(Me.TXTADDRESS)
        Me.BlendPanel1.Controls.Add(Me.CMDDELETE)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.CMDCLEAR)
        Me.BlendPanel1.Controls.Add(Me.CMBSTATE)
        Me.BlendPanel1.Controls.Add(Me.CMBCITY)
        Me.BlendPanel1.Controls.Add(Me.CMBAREA)
        Me.BlendPanel1.Controls.Add(Me.CMBSEX)
        Me.BlendPanel1.Controls.Add(Me.Label10)
        Me.BlendPanel1.Controls.Add(Me.CMBSPECIALIZATION)
        Me.BlendPanel1.Controls.Add(Me.Label9)
        Me.BlendPanel1.Controls.Add(Me.LBLVILLAGE)
        Me.BlendPanel1.Controls.Add(Me.Label4)
        Me.BlendPanel1.Controls.Add(Me.Label3)
        Me.BlendPanel1.Controls.Add(Me.TXTAGE)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.Label15)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(513, 407)
        Me.BlendPanel1.TabIndex = 0
        '
        'CMBCOUNTRY
        '
        Me.CMBCOUNTRY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCOUNTRY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCOUNTRY.BackColor = System.Drawing.Color.White
        Me.CMBCOUNTRY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCOUNTRY.FormattingEnabled = True
        Me.CMBCOUNTRY.Items.AddRange(New Object() {""})
        Me.CMBCOUNTRY.Location = New System.Drawing.Point(149, 218)
        Me.CMBCOUNTRY.MaxLength = 100
        Me.CMBCOUNTRY.Name = "CMBCOUNTRY"
        Me.CMBCOUNTRY.Size = New System.Drawing.Size(233, 23)
        Me.CMBCOUNTRY.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(98, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 840
        Me.Label5.Text = "Country"
        '
        'CMDDELETE
        '
        Me.CMDDELETE.BackColor = System.Drawing.Color.Transparent
        Me.CMDDELETE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDDELETE.FlatAppearance.BorderSize = 0
        Me.CMDDELETE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDDELETE.ForeColor = System.Drawing.Color.Black
        Me.CMDDELETE.Location = New System.Drawing.Point(259, 364)
        Me.CMDDELETE.Name = "CMDDELETE"
        Me.CMDDELETE.Size = New System.Drawing.Size(80, 28)
        Me.CMDDELETE.TabIndex = 12
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
        Me.CMDEXIT.Location = New System.Drawing.Point(345, 364)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 13
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
        Me.CMDOK.Location = New System.Drawing.Point(87, 364)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 10
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
        Me.CMDCLEAR.Location = New System.Drawing.Point(173, 364)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.Size = New System.Drawing.Size(80, 28)
        Me.CMDCLEAR.TabIndex = 11
        Me.CMDCLEAR.Text = "&Clear"
        Me.CMDCLEAR.UseVisualStyleBackColor = False
        '
        'CMBSTATE
        '
        Me.CMBSTATE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBSTATE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBSTATE.BackColor = System.Drawing.Color.White
        Me.CMBSTATE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSTATE.FormattingEnabled = True
        Me.CMBSTATE.Items.AddRange(New Object() {""})
        Me.CMBSTATE.Location = New System.Drawing.Point(149, 189)
        Me.CMBSTATE.MaxLength = 100
        Me.CMBSTATE.Name = "CMBSTATE"
        Me.CMBSTATE.Size = New System.Drawing.Size(233, 23)
        Me.CMBSTATE.TabIndex = 6
        '
        'CMBCITY
        '
        Me.CMBCITY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBCITY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBCITY.BackColor = System.Drawing.Color.White
        Me.CMBCITY.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCITY.FormattingEnabled = True
        Me.CMBCITY.Items.AddRange(New Object() {""})
        Me.CMBCITY.Location = New System.Drawing.Point(149, 160)
        Me.CMBCITY.MaxLength = 100
        Me.CMBCITY.Name = "CMBCITY"
        Me.CMBCITY.Size = New System.Drawing.Size(233, 23)
        Me.CMBCITY.TabIndex = 5
        '
        'CMBAREA
        '
        Me.CMBAREA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBAREA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBAREA.BackColor = System.Drawing.Color.LemonChiffon
        Me.CMBAREA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBAREA.FormattingEnabled = True
        Me.CMBAREA.Items.AddRange(New Object() {""})
        Me.CMBAREA.Location = New System.Drawing.Point(149, 131)
        Me.CMBAREA.MaxLength = 100
        Me.CMBAREA.Name = "CMBAREA"
        Me.CMBAREA.Size = New System.Drawing.Size(233, 23)
        Me.CMBAREA.TabIndex = 4
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
        Me.CMBSEX.Location = New System.Drawing.Point(299, 73)
        Me.CMBSEX.Name = "CMBSEX"
        Me.CMBSEX.Size = New System.Drawing.Size(83, 23)
        Me.CMBSEX.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(114, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "State"
        '
        'CMBSPECIALIZATION
        '
        Me.CMBSPECIALIZATION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBSPECIALIZATION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBSPECIALIZATION.BackColor = System.Drawing.Color.White
        Me.CMBSPECIALIZATION.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSPECIALIZATION.FormattingEnabled = True
        Me.CMBSPECIALIZATION.Items.AddRange(New Object() {""})
        Me.CMBSPECIALIZATION.Location = New System.Drawing.Point(149, 102)
        Me.CMBSPECIALIZATION.MaxLength = 100
        Me.CMBSPECIALIZATION.Name = "CMBSPECIALIZATION"
        Me.CMBSPECIALIZATION.Size = New System.Drawing.Size(233, 23)
        Me.CMBSPECIALIZATION.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(271, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Sex"
        '
        'LBLVILLAGE
        '
        Me.LBLVILLAGE.BackColor = System.Drawing.Color.Transparent
        Me.LBLVILLAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLVILLAGE.Location = New System.Drawing.Point(88, 135)
        Me.LBLVILLAGE.Name = "LBLVILLAGE"
        Me.LBLVILLAGE.Size = New System.Drawing.Size(60, 15)
        Me.LBLVILLAGE.TabIndex = 43
        Me.LBLVILLAGE.Text = "Area"
        Me.LBLVILLAGE.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Specialization"
        '
        'TXTAGE
        '
        Me.TXTAGE.BackColor = System.Drawing.Color.LemonChiffon
        Me.TXTAGE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAGE.Location = New System.Drawing.Point(149, 73)
        Me.TXTAGE.MaxLength = 3
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(72, 23)
        Me.TXTAGE.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Age"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(70, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 15)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Doctor Name"
        '
        'DoctorMaster
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(513, 407)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "DoctorMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Doctor Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents TOOLDELETE As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TXTNAME As TextBox
    Friend WithEvents TXTMOBILE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents EP As ErrorProvider
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents TXTADDRESS As TextBox
    Friend WithEvents CMDDELETE As Button
    Friend WithEvents CMDEXIT As Button
    Friend WithEvents CMDOK As Button
    Friend WithEvents CMDCLEAR As Button
    Friend WithEvents CMBSTATE As ComboBox
    Friend WithEvents CMBCITY As ComboBox
    Friend WithEvents CMBAREA As ComboBox
    Friend WithEvents CMBSEX As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CMBSPECIALIZATION As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLVILLAGE As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CMBCOUNTRY As ComboBox
    Friend WithEvents Label5 As Label
End Class
