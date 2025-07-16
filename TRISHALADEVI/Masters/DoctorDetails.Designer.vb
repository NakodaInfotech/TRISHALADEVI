<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DoctorDetails
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
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.CMDADD = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.PBEXCEL = New System.Windows.Forms.PictureBox()
        Me.CMDREFRESH = New System.Windows.Forms.Button()
        Me.CMDEDIT = New System.Windows.Forms.Button()
        Me.GRIDNAME = New DevExpress.XtraGrid.GridControl()
        Me.GRIDDOCTOR = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAGE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSEX = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSPECIALIZATION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GAREA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSTATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCOUNTRY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GADDRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GMOBILENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDOCTORID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BlendPanel1.SuspendLayout()
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDDOCTOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.CMDADD)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.PBEXCEL)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.CMDEDIT)
        Me.BlendPanel1.Controls.Add(Me.GRIDNAME)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(1234, 581)
        Me.BlendPanel1.TabIndex = 1
        '
        'CMDADD
        '
        Me.CMDADD.BackColor = System.Drawing.Color.Transparent
        Me.CMDADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDADD.FlatAppearance.BorderSize = 0
        Me.CMDADD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADD.ForeColor = System.Drawing.Color.Black
        Me.CMDADD.Location = New System.Drawing.Point(464, 548)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(80, 28)
        Me.CMDADD.TabIndex = 245
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
        Me.CMDEXIT.Location = New System.Drawing.Point(722, 548)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 246
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'PBEXCEL
        '
        Me.PBEXCEL.Image = Global.TRISHALADEVI.My.Resources.Resources.Excel_icon
        Me.PBEXCEL.Location = New System.Drawing.Point(433, 550)
        Me.PBEXCEL.Name = "PBEXCEL"
        Me.PBEXCEL.Size = New System.Drawing.Size(25, 25)
        Me.PBEXCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEXCEL.TabIndex = 244
        Me.PBEXCEL.TabStop = False
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(550, 548)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 242
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
        Me.CMDEDIT.Location = New System.Drawing.Point(636, 548)
        Me.CMDEDIT.Name = "CMDEDIT"
        Me.CMDEDIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEDIT.TabIndex = 243
        Me.CMDEDIT.Text = "E&dit"
        Me.CMDEDIT.UseVisualStyleBackColor = False
        '
        'GRIDNAME
        '
        Me.GRIDNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDNAME.Location = New System.Drawing.Point(9, 3)
        Me.GRIDNAME.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GRIDNAME.MainView = Me.GRIDDOCTOR
        Me.GRIDNAME.Name = "GRIDNAME"
        Me.GRIDNAME.Size = New System.Drawing.Size(1225, 539)
        Me.GRIDNAME.TabIndex = 1
        Me.GRIDNAME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRIDDOCTOR})
        '
        'GRIDDOCTOR
        '
        Me.GRIDDOCTOR.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDDOCTOR.Appearance.Row.Options.UseFont = True
        Me.GRIDDOCTOR.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GNAME, Me.GAGE, Me.GSEX, Me.GSPECIALIZATION, Me.GAREA, Me.GCITY, Me.GSTATE, Me.GCOUNTRY, Me.GADDRESS, Me.GMOBILENO, Me.GDOCTORID})
        Me.GRIDDOCTOR.GridControl = Me.GRIDNAME
        Me.GRIDDOCTOR.Name = "GRIDDOCTOR"
        Me.GRIDDOCTOR.OptionsBehavior.AllowIncrementalSearch = True
        Me.GRIDDOCTOR.OptionsBehavior.Editable = False
        Me.GRIDDOCTOR.OptionsCustomization.AllowColumnMoving = False
        Me.GRIDDOCTOR.OptionsCustomization.AllowGroup = False
        Me.GRIDDOCTOR.OptionsView.ColumnAutoWidth = False
        Me.GRIDDOCTOR.OptionsView.ShowAutoFilterRow = True
        Me.GRIDDOCTOR.OptionsView.ShowGroupPanel = False
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 0
        Me.GNAME.Width = 250
        '
        'GAGE
        '
        Me.GAGE.Caption = "Age"
        Me.GAGE.FieldName = "AGE"
        Me.GAGE.Name = "GAGE"
        Me.GAGE.Visible = True
        Me.GAGE.VisibleIndex = 1
        '
        'GSEX
        '
        Me.GSEX.Caption = "Sex"
        Me.GSEX.FieldName = "SEX"
        Me.GSEX.Name = "GSEX"
        Me.GSEX.Visible = True
        Me.GSEX.VisibleIndex = 2
        '
        'GSPECIALIZATION
        '
        Me.GSPECIALIZATION.Caption = "Specialization"
        Me.GSPECIALIZATION.FieldName = "SPECIALIZATION"
        Me.GSPECIALIZATION.Name = "GSPECIALIZATION"
        Me.GSPECIALIZATION.Visible = True
        Me.GSPECIALIZATION.VisibleIndex = 3
        Me.GSPECIALIZATION.Width = 120
        '
        'GAREA
        '
        Me.GAREA.Caption = "Area"
        Me.GAREA.FieldName = "AREA"
        Me.GAREA.Name = "GAREA"
        Me.GAREA.Visible = True
        Me.GAREA.VisibleIndex = 4
        Me.GAREA.Width = 120
        '
        'GCITY
        '
        Me.GCITY.Caption = "City"
        Me.GCITY.FieldName = "CITY"
        Me.GCITY.Name = "GCITY"
        Me.GCITY.Visible = True
        Me.GCITY.VisibleIndex = 5
        Me.GCITY.Width = 120
        '
        'GSTATE
        '
        Me.GSTATE.Caption = "State"
        Me.GSTATE.FieldName = "STATE"
        Me.GSTATE.Name = "GSTATE"
        Me.GSTATE.Visible = True
        Me.GSTATE.VisibleIndex = 6
        Me.GSTATE.Width = 120
        '
        'GCOUNTRY
        '
        Me.GCOUNTRY.Caption = "Country"
        Me.GCOUNTRY.FieldName = "COUNTRY"
        Me.GCOUNTRY.Name = "GCOUNTRY"
        Me.GCOUNTRY.Visible = True
        Me.GCOUNTRY.VisibleIndex = 7
        '
        'GADDRESS
        '
        Me.GADDRESS.Caption = "Address"
        Me.GADDRESS.FieldName = "ADDRESS"
        Me.GADDRESS.Name = "GADDRESS"
        Me.GADDRESS.Visible = True
        Me.GADDRESS.VisibleIndex = 8
        Me.GADDRESS.Width = 100
        '
        'GMOBILENO
        '
        Me.GMOBILENO.Caption = "Mobile No"
        Me.GMOBILENO.FieldName = "MOBILENO"
        Me.GMOBILENO.Name = "GMOBILENO"
        Me.GMOBILENO.Visible = True
        Me.GMOBILENO.VisibleIndex = 9
        Me.GMOBILENO.Width = 120
        '
        'GDOCTORID
        '
        Me.GDOCTORID.Caption = "DOCTORID"
        Me.GDOCTORID.FieldName = "DOCTORID"
        Me.GDOCTORID.Name = "GDOCTORID"
        '
        'DoctorDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1234, 581)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "DoctorDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "DoctorDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDDOCTOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Private WithEvents GRIDNAME As DevExpress.XtraGrid.GridControl
    Private WithEvents GRIDDOCTOR As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAGE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSEX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSPECIALIZATION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GAREA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSTATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCOUNTRY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GADDRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GMOBILENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PBEXCEL As PictureBox
    Friend WithEvents CMDREFRESH As Button
    Friend WithEvents CMDEDIT As Button
    Friend WithEvents CMDADD As Button
    Friend WithEvents CMDEXIT As Button
    Friend WithEvents GDOCTORID As DevExpress.XtraGrid.Columns.GridColumn
End Class
