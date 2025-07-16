<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IpdDetails
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
        Me.GIPNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GPLACE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GADMISSIONDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDTDISCHARGEDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAPPOINTMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSURGERYNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMEDICALHISTORY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRBS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GPERSONALHISTORY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GPULSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTEMPRATURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GBP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GANATHALOGISTIC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GRECDAMT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GGRANDTOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GORALMEDICINE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSIGNOUTISSUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GALLERGY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GHIV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTOKENNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GTOKENTIME = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.BlendPanel1.Size = New System.Drawing.Size(1184, 581)
        Me.BlendPanel1.TabIndex = 8
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(553, 535)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 326
        Me.CMDREFRESH.Text = "&Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'gridbilldetails
        '
        Me.gridbilldetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbilldetails.Location = New System.Drawing.Point(13, 49)
        Me.gridbilldetails.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gridbilldetails.MainView = Me.gridbill
        Me.gridbilldetails.Name = "gridbilldetails"
        Me.gridbilldetails.Size = New System.Drawing.Size(1158, 480)
        Me.gridbilldetails.TabIndex = 256
        Me.gridbilldetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbill})
        '
        'gridbill
        '
        Me.gridbill.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridbill.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridbill.Appearance.Row.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.gridbill.Appearance.Row.Options.UseFont = True
        Me.gridbill.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GIPNO, Me.GMRDNO, Me.GNAME, Me.GAGE, Me.GPLACE, Me.GADMISSIONDATE, Me.GDTDISCHARGEDATE, Me.GAPPOINTMENT, Me.GSURGERYNAME, Me.GGRANDTOTAL, Me.GRECDAMT, Me.GMEDICALHISTORY, Me.GRBS, Me.GPERSONALHISTORY, Me.GPULSE, Me.GTEMPRATURE, Me.GBP, Me.GANATHALOGISTIC, Me.GORALMEDICINE, Me.GSIGNOUTISSUE, Me.GALLERGY, Me.GHIV, Me.GTOKENNO, Me.GTOKENTIME})
        Me.gridbill.GridControl = Me.gridbilldetails
        Me.gridbill.Name = "gridbill"
        Me.gridbill.OptionsBehavior.Editable = False
        Me.gridbill.OptionsView.ColumnAutoWidth = False
        Me.gridbill.OptionsView.ShowAutoFilterRow = True
        Me.gridbill.OptionsView.ShowFooter = True
        Me.gridbill.OptionsView.ShowGroupPanel = False
        '
        'GIPNO
        '
        Me.GIPNO.Caption = "Sr. No"
        Me.GIPNO.FieldName = "TEMPIPDNO"
        Me.GIPNO.Name = "GIPNO"
        Me.GIPNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.GIPNO.Visible = True
        Me.GIPNO.VisibleIndex = 0
        Me.GIPNO.Width = 60
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD.No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 1
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 2
        Me.GNAME.Width = 200
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 3
        Me.GAGE.Width = 50
        '
        'GPLACE
        '
        Me.GPLACE.Caption = "Village"
        Me.GPLACE.FieldName = "PLACE"
        Me.GPLACE.Name = "GPLACE"
        Me.GPLACE.Visible = True
        Me.GPLACE.VisibleIndex = 4
        Me.GPLACE.Width = 100
        '
        'GADMISSIONDATE
        '
        Me.GADMISSIONDATE.Caption = "Admission Date "
        Me.GADMISSIONDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GADMISSIONDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GADMISSIONDATE.Name = "GADMISSIONDATE"
        Me.GADMISSIONDATE.Visible = True
        Me.GADMISSIONDATE.VisibleIndex = 5
        Me.GADMISSIONDATE.Width = 100
        '
        'GDTDISCHARGEDATE
        '
        Me.GDTDISCHARGEDATE.Caption = "Discharge Date"
        Me.GDTDISCHARGEDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GDTDISCHARGEDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GDTDISCHARGEDATE.FieldName = "DTDISCHARGE"
        Me.GDTDISCHARGEDATE.Name = "GDTDISCHARGEDATE"
        Me.GDTDISCHARGEDATE.Visible = True
        Me.GDTDISCHARGEDATE.VisibleIndex = 6
        Me.GDTDISCHARGEDATE.Width = 100
        '
        'GAPPOINTMENT
        '
        Me.GAPPOINTMENT.Caption = "Appoint Date"
        Me.GAPPOINTMENT.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GAPPOINTMENT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GAPPOINTMENT.FieldName = "DTAPPOINTMENT"
        Me.GAPPOINTMENT.Name = "GAPPOINTMENT"
        Me.GAPPOINTMENT.Visible = True
        Me.GAPPOINTMENT.VisibleIndex = 7
        Me.GAPPOINTMENT.Width = 100
        '
        'GSURGERYNAME
        '
        Me.GSURGERYNAME.Caption = "Surgery Name "
        Me.GSURGERYNAME.FieldName = "SURGERY"
        Me.GSURGERYNAME.Name = "GSURGERYNAME"
        Me.GSURGERYNAME.Visible = True
        Me.GSURGERYNAME.VisibleIndex = 8
        Me.GSURGERYNAME.Width = 150
        '
        'GMEDICALHISTORY
        '
        Me.GMEDICALHISTORY.Caption = "Medical History"
        Me.GMEDICALHISTORY.FieldName = "HISTORY"
        Me.GMEDICALHISTORY.Name = "GMEDICALHISTORY"
        Me.GMEDICALHISTORY.Visible = True
        Me.GMEDICALHISTORY.VisibleIndex = 11
        Me.GMEDICALHISTORY.Width = 120
        '
        'GRBS
        '
        Me.GRBS.Caption = "Rbs"
        Me.GRBS.FieldName = "RBS"
        Me.GRBS.Name = "GRBS"
        Me.GRBS.Visible = True
        Me.GRBS.VisibleIndex = 12
        '
        'GPERSONALHISTORY
        '
        Me.GPERSONALHISTORY.Caption = "Personal History"
        Me.GPERSONALHISTORY.FieldName = "PERSONALHISTORY"
        Me.GPERSONALHISTORY.Name = "GPERSONALHISTORY"
        Me.GPERSONALHISTORY.Visible = True
        Me.GPERSONALHISTORY.VisibleIndex = 13
        '
        'GPULSE
        '
        Me.GPULSE.Caption = "Pulse"
        Me.GPULSE.FieldName = "PULSE"
        Me.GPULSE.Name = "GPULSE"
        Me.GPULSE.Visible = True
        Me.GPULSE.VisibleIndex = 14
        '
        'GTEMPRATURE
        '
        Me.GTEMPRATURE.Caption = "Temprature"
        Me.GTEMPRATURE.FieldName = "TEMPRATURE"
        Me.GTEMPRATURE.Name = "GTEMPRATURE"
        Me.GTEMPRATURE.Visible = True
        Me.GTEMPRATURE.VisibleIndex = 15
        '
        'GBP
        '
        Me.GBP.Caption = "B.P."
        Me.GBP.FieldName = "BP"
        Me.GBP.Name = "GBP"
        Me.GBP.Visible = True
        Me.GBP.VisibleIndex = 16
        '
        'GANATHALOGISTIC
        '
        Me.GANATHALOGISTIC.Caption = "ANAESTHESIOLOGIST"
        Me.GANATHALOGISTIC.FieldName = "ANATHALOGIST"
        Me.GANATHALOGISTIC.Name = "GANATHALOGISTIC"
        Me.GANATHALOGISTIC.Visible = True
        Me.GANATHALOGISTIC.VisibleIndex = 17
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
        'GGRANDTOTAL
        '
        Me.GGRANDTOTAL.Caption = "Grand Total"
        Me.GGRANDTOTAL.FieldName = "GRANDTOTAL"
        Me.GGRANDTOTAL.Name = "GGRANDTOTAL"
        Me.GGRANDTOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.GGRANDTOTAL.Visible = True
        Me.GGRANDTOTAL.VisibleIndex = 9
        Me.GGRANDTOTAL.Width = 80
        '
        'GORALMEDICINE
        '
        Me.GORALMEDICINE.Caption = "Oral Medicine "
        Me.GORALMEDICINE.FieldName = "ORALMEDICINE"
        Me.GORALMEDICINE.Name = "GORALMEDICINE"
        Me.GORALMEDICINE.Visible = True
        Me.GORALMEDICINE.VisibleIndex = 18
        '
        'GSIGNOUTISSUE
        '
        Me.GSIGNOUTISSUE.Caption = "Sign Out Issue"
        Me.GSIGNOUTISSUE.FieldName = "ISSUE"
        Me.GSIGNOUTISSUE.Name = "GSIGNOUTISSUE"
        Me.GSIGNOUTISSUE.Visible = True
        Me.GSIGNOUTISSUE.VisibleIndex = 19
        '
        'GALLERGY
        '
        Me.GALLERGY.Caption = "Allergy"
        Me.GALLERGY.FieldName = "ALLERGY"
        Me.GALLERGY.Name = "GALLERGY"
        Me.GALLERGY.Visible = True
        Me.GALLERGY.VisibleIndex = 20
        '
        'GHIV
        '
        Me.GHIV.Caption = "HIV"
        Me.GHIV.FieldName = "HIV"
        Me.GHIV.Name = "GHIV"
        Me.GHIV.Visible = True
        Me.GHIV.VisibleIndex = 21
        '
        'GTOKENNO
        '
        Me.GTOKENNO.Caption = "Token No"
        Me.GTOKENNO.FieldName = "TOKENNO"
        Me.GTOKENNO.Name = "GTOKENNO"
        Me.GTOKENNO.Visible = True
        Me.GTOKENNO.VisibleIndex = 22
        '
        'GTOKENTIME
        '
        Me.GTOKENTIME.Caption = "Time"
        Me.GTOKENTIME.FieldName = "TOKENTIME"
        Me.GTOKENTIME.Name = "GTOKENTIME"
        Me.GTOKENTIME.Visible = True
        Me.GTOKENTIME.VisibleIndex = 23
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatAppearance.BorderSize = 0
        Me.cmdexit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Location = New System.Drawing.Point(636, 535)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
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
        Me.cmdok.Location = New System.Drawing.Point(469, 535)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(80, 28)
        Me.cmdok.TabIndex = 3
        Me.cmdok.Text = "&Ok"
        Me.cmdok.UseVisualStyleBackColor = False
        '
        'IpdDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1184, 581)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "IpdDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IPD Details"
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
    Private WithEvents gridbilldetails As DevExpress.XtraGrid.GridControl
    Private WithEvents gridbill As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GIPNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPLACE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GADMISSIONDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDTDISCHARGEDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdexit As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents cmdok As Button
    Friend WithEvents CMDREFRESH As Button
    Friend WithEvents GSURGERYNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMEDICALHISTORY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRBS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPERSONALHISTORY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GANATHALOGISTIC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GPULSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTEMPRATURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GBP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAPPOINTMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GRECDAMT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GGRANDTOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GORALMEDICINE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSIGNOUTISSUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GALLERGY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GHIV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GTOKENTIME As DevExpress.XtraGrid.Columns.GridColumn
End Class
