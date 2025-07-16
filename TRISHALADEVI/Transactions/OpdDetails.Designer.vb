<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpdDetails
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
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.BlendPanel1.SuspendLayout()
        CType(Me.gridbilldetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.gridbilldetails)
        Me.BlendPanel1.Controls.Add(Me.cmdexit)
        Me.BlendPanel1.Controls.Add(Me.ToolStrip1)
        Me.BlendPanel1.Controls.Add(Me.cmdok)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1169, 581)
        Me.BlendPanel1.TabIndex = 9
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(526, 547)
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
        Me.gridbilldetails.Size = New System.Drawing.Size(1137, 504)
        Me.gridbilldetails.TabIndex = 256
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GTOKENNO, Me.GTOKENTIME, Me.GOPDNO, Me.GENTRYDATE, Me.GDATE, Me.GMRDNO, Me.GNAME, Me.GAGE, Me.GPLACE, Me.GTYPE, Me.GGRANDTOTAL, Me.GRECDAMT, Me.GBILLNO})
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
        Me.GTOKENNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TOKENNO", "{0}")})
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
        Me.GENTRYDATE.VisibleIndex = 2
        '
        'GDATE
        '
        Me.GDATE.Caption = "Follow Up Date"
        Me.GDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GDATE.FieldName = "DATE"
        Me.GDATE.Name = "GDATE"
        Me.GDATE.Visible = True
        Me.GDATE.VisibleIndex = 3
        Me.GDATE.Width = 100
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD.No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 4
        Me.GMRDNO.Width = 100
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 5
        Me.GNAME.Width = 200
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 6
        Me.GAGE.Width = 50
        '
        'GPLACE
        '
        Me.GPLACE.Caption = "Village"
        Me.GPLACE.FieldName = "PLACE"
        Me.GPLACE.Name = "GPLACE"
        Me.GPLACE.Visible = True
        Me.GPLACE.VisibleIndex = 7
        Me.GPLACE.Width = 100
        '
        'GTYPE
        '
        Me.GTYPE.Caption = "Type"
        Me.GTYPE.FieldName = "TYPE"
        Me.GTYPE.Name = "GTYPE"
        Me.GTYPE.Visible = True
        Me.GTYPE.VisibleIndex = 8
        '
        'GGRANDTOTAL
        '
        Me.GGRANDTOTAL.Caption = "Total Amt"
        Me.GGRANDTOTAL.FieldName = "GRANDTOTAL"
        Me.GGRANDTOTAL.Name = "GGRANDTOTAL"
        Me.GGRANDTOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GGRANDTOTAL.Visible = True
        Me.GGRANDTOTAL.VisibleIndex = 9
        Me.GGRANDTOTAL.Width = 80
        '
        'GRECDAMT
        '
        Me.GRECDAMT.Caption = "Recd Amt"
        Me.GRECDAMT.FieldName = "RECDAMT"
        Me.GRECDAMT.Name = "GRECDAMT"
        Me.GRECDAMT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GRECDAMT.Visible = True
        Me.GRECDAMT.VisibleIndex = 10
        Me.GRECDAMT.Width = 80
        '
        'GBILLNO
        '
        Me.GBILLNO.Caption = "Bill No"
        Me.GBILLNO.FieldName = "BILLNO"
        Me.GBILLNO.Name = "GBILLNO"
        Me.GBILLNO.Visible = True
        Me.GBILLNO.VisibleIndex = 11
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatAppearance.BorderSize = 0
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Location = New System.Drawing.Point(609, 547)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(80, 28)
        Me.cmdexit.TabIndex = 4
        Me.cmdexit.Text = "E&xit"
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.toolStripSeparator, Me.PrintToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1169, 25)
        Me.ToolStrip1.TabIndex = 255
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton1.Text = "Add New"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
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
        'cmdok
        '
        Me.cmdok.BackColor = System.Drawing.Color.Transparent
        Me.cmdok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdok.FlatAppearance.BorderSize = 0
        Me.cmdok.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdok.ForeColor = System.Drawing.Color.Black
        Me.cmdok.Location = New System.Drawing.Point(442, 547)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(80, 28)
        Me.cmdok.TabIndex = 3
        Me.cmdok.Text = "&Ok"
        Me.cmdok.UseVisualStyleBackColor = False
        '
        'OpdDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1169, 581)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "OpdDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "OPD Details"
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
    Private WithEvents GOPDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPLACE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdexit As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents cmdok As Button
    Friend WithEvents GRECDAMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENTIME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GGRANDTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GBILLNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENTRYDATE As DevExpress.XtraGrid.Columns.GridColumn
End Class
