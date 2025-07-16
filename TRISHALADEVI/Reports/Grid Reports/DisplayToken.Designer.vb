<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayToken
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
        Me.TXTUNCHECKED = New System.Windows.Forms.TextBox()
        Me.TXTCHECHED = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTTOTALPATIENTS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTFOLLOWUP = New System.Windows.Forms.TextBox()
        Me.TXTRENEW = New System.Windows.Forms.TextBox()
        Me.TXTNEW = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CMDSAVE = New System.Windows.Forms.Button()
        Me.RBENTERED = New System.Windows.Forms.RadioButton()
        Me.RBPENDING = New System.Windows.Forms.RadioButton()
        Me.CMDREFRESH = New System.Windows.Forms.Button()
        Me.gridbilldetails = New DevExpress.XtraGrid.GridControl()
        Me.gridbill = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GTOKENNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTOKENTIME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GOPDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GENTRYDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GPLACE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GGRANDTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRECDAMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GBILLNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GENTRYTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTOKENDONE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BlendPanel1.SuspendLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.TXTUNCHECKED)
        Me.BlendPanel1.Controls.Add(Me.TXTCHECHED)
        Me.BlendPanel1.Controls.Add(Me.Label2)
        Me.BlendPanel1.Controls.Add(Me.Label3)
        Me.BlendPanel1.Controls.Add(Me.TXTTOTALPATIENTS)
        Me.BlendPanel1.Controls.Add(Me.Label1)
        Me.BlendPanel1.Controls.Add(Me.TXTFOLLOWUP)
        Me.BlendPanel1.Controls.Add(Me.TXTRENEW)
        Me.BlendPanel1.Controls.Add(Me.TXTNEW)
        Me.BlendPanel1.Controls.Add(Me.Label14)
        Me.BlendPanel1.Controls.Add(Me.Label13)
        Me.BlendPanel1.Controls.Add(Me.Label12)
        Me.BlendPanel1.Controls.Add(Me.Label15)
        Me.BlendPanel1.Controls.Add(Me.Label23)
        Me.BlendPanel1.Controls.Add(Me.CMDSAVE)
        Me.BlendPanel1.Controls.Add(Me.RBENTERED)
        Me.BlendPanel1.Controls.Add(Me.RBPENDING)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.gridbilldetails)
        Me.BlendPanel1.Controls.Add(Me.cmdexit)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1260, 582)
        Me.BlendPanel1.TabIndex = 10
        '
        'TXTUNCHECKED
        '
        Me.TXTUNCHECKED.BackColor = System.Drawing.Color.Linen
        Me.TXTUNCHECKED.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUNCHECKED.Location = New System.Drawing.Point(771, 547)
        Me.TXTUNCHECKED.MaxLength = 25
        Me.TXTUNCHECKED.Name = "TXTUNCHECKED"
        Me.TXTUNCHECKED.ReadOnly = True
        Me.TXTUNCHECKED.Size = New System.Drawing.Size(42, 23)
        Me.TXTUNCHECKED.TabIndex = 1011
        Me.TXTUNCHECKED.TabStop = False
        Me.TXTUNCHECKED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTCHECHED
        '
        Me.TXTCHECHED.BackColor = System.Drawing.Color.Linen
        Me.TXTCHECHED.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCHECHED.Location = New System.Drawing.Point(643, 547)
        Me.TXTCHECHED.MaxLength = 25
        Me.TXTCHECHED.Name = "TXTCHECHED"
        Me.TXTCHECHED.ReadOnly = True
        Me.TXTCHECHED.Size = New System.Drawing.Size(42, 23)
        Me.TXTCHECHED.TabIndex = 1010
        Me.TXTCHECHED.TabStop = False
        Me.TXTCHECHED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(700, 551)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1009
        Me.Label2.Text = "Un Checked"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(590, 551)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 1008
        Me.Label3.Text = "Checked"
        '
        'TXTTOTALPATIENTS
        '
        Me.TXTTOTALPATIENTS.BackColor = System.Drawing.Color.Linen
        Me.TXTTOTALPATIENTS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALPATIENTS.Location = New System.Drawing.Point(103, 547)
        Me.TXTTOTALPATIENTS.MaxLength = 25
        Me.TXTTOTALPATIENTS.Name = "TXTTOTALPATIENTS"
        Me.TXTTOTALPATIENTS.ReadOnly = True
        Me.TXTTOTALPATIENTS.Size = New System.Drawing.Size(42, 23)
        Me.TXTTOTALPATIENTS.TabIndex = 1007
        Me.TXTTOTALPATIENTS.TabStop = False
        Me.TXTTOTALPATIENTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 551)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 1006
        Me.Label1.Text = "Total Patients"
        '
        'TXTFOLLOWUP
        '
        Me.TXTFOLLOWUP.BackColor = System.Drawing.Color.Linen
        Me.TXTFOLLOWUP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFOLLOWUP.Location = New System.Drawing.Point(467, 547)
        Me.TXTFOLLOWUP.MaxLength = 25
        Me.TXTFOLLOWUP.Name = "TXTFOLLOWUP"
        Me.TXTFOLLOWUP.ReadOnly = True
        Me.TXTFOLLOWUP.Size = New System.Drawing.Size(42, 23)
        Me.TXTFOLLOWUP.TabIndex = 1005
        Me.TXTFOLLOWUP.TabStop = False
        Me.TXTFOLLOWUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTRENEW
        '
        Me.TXTRENEW.BackColor = System.Drawing.Color.Linen
        Me.TXTRENEW.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTRENEW.Location = New System.Drawing.Point(333, 547)
        Me.TXTRENEW.MaxLength = 25
        Me.TXTRENEW.Name = "TXTRENEW"
        Me.TXTRENEW.ReadOnly = True
        Me.TXTRENEW.Size = New System.Drawing.Size(42, 23)
        Me.TXTRENEW.TabIndex = 1004
        Me.TXTRENEW.TabStop = False
        Me.TXTRENEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNEW
        '
        Me.TXTNEW.BackColor = System.Drawing.Color.Linen
        Me.TXTNEW.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNEW.Location = New System.Drawing.Point(228, 547)
        Me.TXTNEW.MaxLength = 25
        Me.TXTNEW.Name = "TXTNEW"
        Me.TXTNEW.ReadOnly = True
        Me.TXTNEW.Size = New System.Drawing.Size(42, 23)
        Me.TXTNEW.TabIndex = 1003
        Me.TXTNEW.TabStop = False
        Me.TXTNEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 551)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 15)
        Me.Label14.TabIndex = 1002
        Me.Label14.Text = "Follow Ups"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(289, 551)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 15)
        Me.Label13.TabIndex = 1001
        Me.Label13.Text = "Renew"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(196, 551)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 15)
        Me.Label12.TabIndex = 1000
        Me.Label12.Text = "New"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(227, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 14)
        Me.Label15.TabIndex = 810
        Me.Label15.Text = "Patient Checked"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Location = New System.Drawing.Point(208, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(18, 17)
        Me.Label23.TabIndex = 809
        Me.Label23.Text = "   "
        '
        'CMDSAVE
        '
        Me.CMDSAVE.BackColor = System.Drawing.Color.Transparent
        Me.CMDSAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDSAVE.FlatAppearance.BorderSize = 0
        Me.CMDSAVE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSAVE.ForeColor = System.Drawing.Color.Black
        Me.CMDSAVE.Location = New System.Drawing.Point(952, 547)
        Me.CMDSAVE.Name = "CMDSAVE"
        Me.CMDSAVE.Size = New System.Drawing.Size(80, 28)
        Me.CMDSAVE.TabIndex = 808
        Me.CMDSAVE.Text = "&Save"
        Me.CMDSAVE.UseVisualStyleBackColor = False
        '
        'RBENTERED
        '
        Me.RBENTERED.AutoSize = True
        Me.RBENTERED.BackColor = System.Drawing.Color.Transparent
        Me.RBENTERED.Location = New System.Drawing.Point(116, 4)
        Me.RBENTERED.Name = "RBENTERED"
        Me.RBENTERED.Size = New System.Drawing.Size(66, 19)
        Me.RBENTERED.TabIndex = 807
        Me.RBENTERED.Text = "Entered"
        Me.RBENTERED.UseVisualStyleBackColor = False
        '
        'RBPENDING
        '
        Me.RBPENDING.AutoSize = True
        Me.RBPENDING.BackColor = System.Drawing.Color.Transparent
        Me.RBPENDING.Checked = True
        Me.RBPENDING.Location = New System.Drawing.Point(41, 4)
        Me.RBPENDING.Name = "RBPENDING"
        Me.RBPENDING.Size = New System.Drawing.Size(68, 19)
        Me.RBPENDING.TabIndex = 806
        Me.RBPENDING.TabStop = True
        Me.RBPENDING.Text = "Pending"
        Me.RBPENDING.UseVisualStyleBackColor = False
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(1038, 547)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 326
        Me.CMDREFRESH.Text = "&Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'gridbilldetails
        '
        Me.gridbilldetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbilldetails.Location = New System.Drawing.Point(12, 37)
        Me.gridbilldetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gridbilldetails.MainView = Me.gridbill
        Me.gridbilldetails.Name = "gridbilldetails"
        Me.gridbilldetails.Size = New System.Drawing.Size(1251, 504)
        Me.gridbilldetails.TabIndex = 256
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GTOKENNO, Me.GTOKENTIME, Me.GOPDNO, Me.GENTRYDATE, Me.GDATE, Me.GMRDNO, Me.GNAME, Me.GAGE, Me.GPLACE, Me.GTYPE, Me.GGRANDTOTAL, Me.GRECDAMT, Me.GBILLNO, Me.GENTRYTYPE, Me.GTOKENDONE})
        Me.gridbill.GridControl = Me.gridbilldetails
        Me.gridbill.Name = "gridbill"
        Me.gridbill.OptionsBehavior.Editable = False
        Me.gridbill.OptionsSelection.CheckBoxSelectorColumnWidth = 40
        Me.gridbill.OptionsSelection.MultiSelect = True
        Me.gridbill.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
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
        Me.GTOKENNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TOKENNO", "{0}")})
        Me.GTOKENNO.Visible = True
        Me.GTOKENNO.VisibleIndex = 1
        '
        'GTOKENTIME
        '
        Me.GTOKENTIME.Caption = "Time"
        Me.GTOKENTIME.FieldName = "TOKENTIME"
        Me.GTOKENTIME.Name = "GTOKENTIME"
        Me.GTOKENTIME.Visible = True
        Me.GTOKENTIME.VisibleIndex = 2
        '
        'GOPDNO
        '
        Me.GOPDNO.Caption = "Sr. No"
        Me.GOPDNO.FieldName = "TEMPOPDNO"
        Me.GOPDNO.Name = "GOPDNO"
        Me.GOPDNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        '
        'GENTRYDATE
        '
        Me.GENTRYDATE.Caption = "Entry Date"
        Me.GENTRYDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GENTRYDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GENTRYDATE.FieldName = "ENTRYDATE"
        Me.GENTRYDATE.Name = "GENTRYDATE"
        Me.GENTRYDATE.Visible = True
        Me.GENTRYDATE.VisibleIndex = 3
        '
        'GDATE
        '
        Me.GDATE.Caption = "Follow Up Date"
        Me.GDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GDATE.FieldName = "DATE"
        Me.GDATE.Name = "GDATE"
        Me.GDATE.Visible = True
        Me.GDATE.VisibleIndex = 4
        Me.GDATE.Width = 100
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD.No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 5
        Me.GMRDNO.Width = 100
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 6
        Me.GNAME.Width = 200
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 7
        Me.GAGE.Width = 50
        '
        'GPLACE
        '
        Me.GPLACE.Caption = "Village"
        Me.GPLACE.FieldName = "PLACE"
        Me.GPLACE.Name = "GPLACE"
        Me.GPLACE.Visible = True
        Me.GPLACE.VisibleIndex = 8
        Me.GPLACE.Width = 100
        '
        'GTYPE
        '
        Me.GTYPE.Caption = "Type"
        Me.GTYPE.FieldName = "TYPE"
        Me.GTYPE.Name = "GTYPE"
        Me.GTYPE.Visible = True
        Me.GTYPE.VisibleIndex = 9
        '
        'GGRANDTOTAL
        '
        Me.GGRANDTOTAL.Caption = "Total Amt"
        Me.GGRANDTOTAL.FieldName = "GRANDTOTAL"
        Me.GGRANDTOTAL.Name = "GGRANDTOTAL"
        Me.GGRANDTOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GGRANDTOTAL.Visible = True
        Me.GGRANDTOTAL.VisibleIndex = 10
        Me.GGRANDTOTAL.Width = 80
        '
        'GRECDAMT
        '
        Me.GRECDAMT.Caption = "Recd Amt"
        Me.GRECDAMT.FieldName = "RECDAMT"
        Me.GRECDAMT.Name = "GRECDAMT"
        Me.GRECDAMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GRECDAMT.Visible = True
        Me.GRECDAMT.VisibleIndex = 11
        Me.GRECDAMT.Width = 80
        '
        'GBILLNO
        '
        Me.GBILLNO.Caption = "Bill No"
        Me.GBILLNO.FieldName = "BILLNO"
        Me.GBILLNO.Name = "GBILLNO"
        Me.GBILLNO.Visible = True
        Me.GBILLNO.VisibleIndex = 12
        '
        'GENTRYTYPE
        '
        Me.GENTRYTYPE.Caption = "Entry Type"
        Me.GENTRYTYPE.FieldName = "ENTRYTYPE"
        Me.GENTRYTYPE.Name = "GENTRYTYPE"
        '
        'GTOKENDONE
        '
        Me.GTOKENDONE.Caption = "Token Done"
        Me.GTOKENDONE.FieldName = "TOKENDONE"
        Me.GTOKENDONE.Name = "GTOKENDONE"
        Me.GTOKENDONE.Visible = True
        Me.GTOKENDONE.VisibleIndex = 13
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatAppearance.BorderSize = 0
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Location = New System.Drawing.Point(1121, 547)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(80, 28)
        Me.cmdexit.TabIndex = 4
        Me.cmdexit.Text = "E&xit"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1260, 25)
        Me.ToolStrip1.TabIndex = 255
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = Global.TRISHALADEVI.My.Resources.Resources.Excel_icon
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'DisplayToken
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1260, 582)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "DisplayToken"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Display Token"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents CMDREFRESH As Button
    Private WithEvents gridbilldetails As DevExpress.XtraGrid.GridControl
    Private WithEvents gridbill As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GTOKENNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENTIME As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GOPDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENTRYDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPLACE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GGRANDTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRECDAMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GBILLNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdexit As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents CMDSAVE As Button
    Friend WithEvents RBENTERED As RadioButton
    Friend WithEvents RBPENDING As RadioButton
    Friend WithEvents GENTRYTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENDONE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TXTUNCHECKED As TextBox
    Friend WithEvents TXTCHECHED As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTTOTALPATIENTS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTFOLLOWUP As TextBox
    Friend WithEvents TXTRENEW As TextBox
    Friend WithEvents TXTNEW As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
