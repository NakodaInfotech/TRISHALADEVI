<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimDetails
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
        Me.BlendPanel1 = New VbPowerPack.BlendPanel
        Me.CMDREFRESH = New System.Windows.Forms.Button
        Me.CMDEDIT = New System.Windows.Forms.Button
        Me.GRIDCLAIMDETAILS = New DevExpress.XtraGrid.GridControl
        Me.GRIDCLAIM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GSRNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMRDNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GUHLDNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GCLAIMNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GMOBILE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSEX = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSURGERY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GILLNESS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSURGERYDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GSANCTIONDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GADMISSIONDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GDISCHAREDATE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CMDADD = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.lbl = New System.Windows.Forms.Label
        Me.BlendPanel1.SuspendLayout()
        CType(Me.GRIDCLAIMDETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDCLAIM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.CMDEDIT)
        Me.BlendPanel1.Controls.Add(Me.GRIDCLAIMDETAILS)
        Me.BlendPanel1.Controls.Add(Me.CMDADD)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.lbl)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1034, 581)
        Me.BlendPanel1.TabIndex = 6
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(830, 19)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 790
        Me.CMDREFRESH.Text = "&Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'CMDEDIT
        '
        Me.CMDEDIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEDIT.FlatAppearance.BorderSize = 0
        Me.CMDEDIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEDIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEDIT.Location = New System.Drawing.Point(919, 19)
        Me.CMDEDIT.Name = "CMDEDIT"
        Me.CMDEDIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEDIT.TabIndex = 791
        Me.CMDEDIT.Text = "E&dit"
        Me.CMDEDIT.UseVisualStyleBackColor = False
        '
        'GRIDCLAIMDETAILS
        '
        Me.GRIDCLAIMDETAILS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDCLAIMDETAILS.Location = New System.Drawing.Point(21, 60)
        Me.GRIDCLAIMDETAILS.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GRIDCLAIMDETAILS.MainView = Me.GRIDCLAIM
        Me.GRIDCLAIMDETAILS.Name = "GRIDCLAIMDETAILS"
        Me.GRIDCLAIMDETAILS.Size = New System.Drawing.Size(993, 467)
        Me.GRIDCLAIMDETAILS.TabIndex = 7
        Me.GRIDCLAIMDETAILS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRIDCLAIM})
        '
        'GRIDCLAIM
        '
        Me.GRIDCLAIM.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDCLAIM.Appearance.Row.Options.UseFont = True
        Me.GRIDCLAIM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GSRNO, Me.GNAME, Me.GMRDNO, Me.GUHLDNO, Me.GCLAIMNO, Me.GMOBILE, Me.GAGE, Me.GSEX, Me.GSURGERY, Me.GILLNESS, Me.GSURGERYDATE, Me.GSANCTIONDATE, Me.GADMISSIONDATE, Me.GDISCHAREDATE})
        Me.GRIDCLAIM.GridControl = Me.GRIDCLAIMDETAILS
        Me.GRIDCLAIM.Name = "GRIDCLAIM"
        Me.GRIDCLAIM.OptionsBehavior.AllowIncrementalSearch = True
        Me.GRIDCLAIM.OptionsBehavior.Editable = False
        Me.GRIDCLAIM.OptionsView.ColumnAutoWidth = False
        Me.GRIDCLAIM.OptionsView.ShowAutoFilterRow = True
        Me.GRIDCLAIM.OptionsView.ShowFooter = True
        '
        'GSRNO
        '
        Me.GSRNO.Caption = "Sr. No"
        Me.GSRNO.FieldName = "SRNO"
        Me.GSRNO.ImageIndex = 1
        Me.GSRNO.Name = "GSRNO"
        Me.GSRNO.Visible = True
        Me.GSRNO.VisibleIndex = 0
        Me.GSRNO.Width = 50
        '
        'GNAME
        '
        Me.GNAME.Caption = "Patient Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.ImageIndex = 0
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 1
        Me.GNAME.Width = 150
        '
        'GMRDNO
        '
        Me.GMRDNO.Caption = "MRD No"
        Me.GMRDNO.FieldName = "MRDNO"
        Me.GMRDNO.Name = "GMRDNO"
        Me.GMRDNO.Visible = True
        Me.GMRDNO.VisibleIndex = 2
        Me.GMRDNO.Width = 100
        '
        'GUHLDNO
        '
        Me.GUHLDNO.Caption = "UHLD No"
        Me.GUHLDNO.FieldName = "UHLDNO"
        Me.GUHLDNO.Name = "GUHLDNO"
        Me.GUHLDNO.Visible = True
        Me.GUHLDNO.VisibleIndex = 3
        Me.GUHLDNO.Width = 100
        '
        'GCLAIMNO
        '
        Me.GCLAIMNO.Caption = "Claim No"
        Me.GCLAIMNO.FieldName = "CLAIMNO"
        Me.GCLAIMNO.Name = "GCLAIMNO"
        Me.GCLAIMNO.Visible = True
        Me.GCLAIMNO.VisibleIndex = 4
        Me.GCLAIMNO.Width = 100
        '
        'GMOBILE
        '
        Me.GMOBILE.Caption = "Mobile"
        Me.GMOBILE.FieldName = "MOBILE"
        Me.GMOBILE.Name = "GMOBILE"
        Me.GMOBILE.Visible = True
        Me.GMOBILE.VisibleIndex = 5
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
        'GSEX
        '
        Me.GSEX.Caption = "Sex"
        Me.GSEX.FieldName = "SEX"
        Me.GSEX.Name = "GSEX"
        Me.GSEX.Visible = True
        Me.GSEX.VisibleIndex = 7
        Me.GSEX.Width = 50
        '
        'GSURGERY
        '
        Me.GSURGERY.Caption = "Surgery"
        Me.GSURGERY.FieldName = "SURGERY"
        Me.GSURGERY.Name = "GSURGERY"
        Me.GSURGERY.Visible = True
        Me.GSURGERY.VisibleIndex = 8
        Me.GSURGERY.Width = 150
        '
        'GILLNESS
        '
        Me.GILLNESS.Caption = "Illness"
        Me.GILLNESS.FieldName = "ILLNESS"
        Me.GILLNESS.Name = "GILLNESS"
        Me.GILLNESS.Visible = True
        Me.GILLNESS.VisibleIndex = 9
        Me.GILLNESS.Width = 150
        '
        'GSURGERYDATE
        '
        Me.GSURGERYDATE.Caption = "Surgery Date"
        Me.GSURGERYDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GSURGERYDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GSURGERYDATE.FieldName = "SURGERYDATE"
        Me.GSURGERYDATE.Name = "GSURGERYDATE"
        Me.GSURGERYDATE.Visible = True
        Me.GSURGERYDATE.VisibleIndex = 10
        Me.GSURGERYDATE.Width = 100
        '
        'GSANCTIONDATE
        '
        Me.GSANCTIONDATE.Caption = "Sanction Date"
        Me.GSANCTIONDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GSANCTIONDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GSANCTIONDATE.FieldName = "SANCTIONDATE"
        Me.GSANCTIONDATE.Name = "GSANCTIONDATE"
        Me.GSANCTIONDATE.Visible = True
        Me.GSANCTIONDATE.VisibleIndex = 11
        Me.GSANCTIONDATE.Width = 100
        '
        'GADMISSIONDATE
        '
        Me.GADMISSIONDATE.Caption = "Admission Date"
        Me.GADMISSIONDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GADMISSIONDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GADMISSIONDATE.FieldName = "ADMISSIONDATE"
        Me.GADMISSIONDATE.Name = "GADMISSIONDATE"
        Me.GADMISSIONDATE.Visible = True
        Me.GADMISSIONDATE.VisibleIndex = 12
        Me.GADMISSIONDATE.Width = 100
        '
        'GDISCHAREDATE
        '
        Me.GDISCHAREDATE.Caption = "Discharge Date"
        Me.GDISCHAREDATE.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.GDISCHAREDATE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GDISCHAREDATE.FieldName = "DISCHARGEDATE"
        Me.GDISCHAREDATE.Name = "GDISCHAREDATE"
        Me.GDISCHAREDATE.Visible = True
        Me.GDISCHAREDATE.VisibleIndex = 13
        Me.GDISCHAREDATE.Width = 100
        '
        'CMDADD
        '
        Me.CMDADD.BackColor = System.Drawing.Color.Transparent
        Me.CMDADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDADD.FlatAppearance.BorderSize = 0
        Me.CMDADD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADD.ForeColor = System.Drawing.Color.Black
        Me.CMDADD.Location = New System.Drawing.Point(434, 538)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(80, 28)
        Me.CMDADD.TabIndex = 1
        Me.CMDADD.Text = "&Add New"
        Me.CMDADD.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(520, 538)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 2
        Me.CMDEXIT.Text = "&Exit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(20, 43)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(140, 14)
        Me.lbl.TabIndex = 251
        Me.lbl.Text = "Select a claim to Change"
        '
        'ClaimDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1034, 581)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ClaimDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Claim Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        CType(Me.GRIDCLAIMDETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDCLAIM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Private WithEvents GRIDCLAIMDETAILS As DevExpress.XtraGrid.GridControl
    Private WithEvents GRIDCLAIM As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GSRNO As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMRDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GUHLDNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCLAIMNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMOBILE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSURGERY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GILLNESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSURGERYDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSANCTIONDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GADMISSIONDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CMDADD As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents GDISCHAREDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CMDREFRESH As System.Windows.Forms.Button
    Friend WithEvents CMDEDIT As System.Windows.Forms.Button
End Class
