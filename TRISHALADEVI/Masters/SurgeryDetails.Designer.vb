<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SurgeryDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BlendPanel1 = New VbPowerPack.BlendPanel()
        Me.BlendPanel2 = New VbPowerPack.BlendPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GRIDMEDICINES = New System.Windows.Forms.DataGridView()
        Me.GMEDSRNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GMEDICINE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTPROCEDURE = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PBEXCEL = New System.Windows.Forms.PictureBox()
        Me.GRIDNAME = New DevExpress.XtraGrid.GridControl()
        Me.GRIDSURGERY = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CMDREFRESH = New System.Windows.Forms.Button()
        Me.CMDADD = New System.Windows.Forms.Button()
        Me.CMDEDIT = New System.Windows.Forms.Button()
        Me.CMDEXIT = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BlendPanel1.SuspendLayout()
        Me.BlendPanel2.SuspendLayout()
        CType(Me.GRIDMEDICINES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GRIDSURGERY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.BlendPanel2)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(713, 562)
        Me.BlendPanel1.TabIndex = 0
        '
        'BlendPanel2
        '
        Me.BlendPanel2.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel2.Controls.Add(Me.Label2)
        Me.BlendPanel2.Controls.Add(Me.GRIDMEDICINES)
        Me.BlendPanel2.Controls.Add(Me.Label1)
        Me.BlendPanel2.Controls.Add(Me.TXTPROCEDURE)
        Me.BlendPanel2.Controls.Add(Me.TXTNAME)
        Me.BlendPanel2.Controls.Add(Me.Label18)
        Me.BlendPanel2.Controls.Add(Me.PBEXCEL)
        Me.BlendPanel2.Controls.Add(Me.GRIDNAME)
        Me.BlendPanel2.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel2.Controls.Add(Me.CMDADD)
        Me.BlendPanel2.Controls.Add(Me.CMDEDIT)
        Me.BlendPanel2.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel2.Controls.Add(Me.Label21)
        Me.BlendPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlendPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel2.Name = "BlendPanel2"
        Me.BlendPanel2.Size = New System.Drawing.Size(713, 562)
        Me.BlendPanel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(342, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 898
        Me.Label2.Text = "Medicines"
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
        Me.GRIDMEDICINES.BackgroundColor = System.Drawing.Color.Linen
        Me.GRIDMEDICINES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRIDMEDICINES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRIDMEDICINES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRIDMEDICINES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRIDMEDICINES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GMEDSRNO, Me.GMEDICINE})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRIDMEDICINES.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRIDMEDICINES.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRIDMEDICINES.Location = New System.Drawing.Point(407, 256)
        Me.GRIDMEDICINES.Margin = New System.Windows.Forms.Padding(2)
        Me.GRIDMEDICINES.MultiSelect = False
        Me.GRIDMEDICINES.Name = "GRIDMEDICINES"
        Me.GRIDMEDICINES.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        Me.GRIDMEDICINES.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GRIDMEDICINES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRIDMEDICINES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRIDMEDICINES.Size = New System.Drawing.Size(290, 162)
        Me.GRIDMEDICINES.TabIndex = 897
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 895
        Me.Label1.Text = "Procedure"
        '
        'TXTPROCEDURE
        '
        Me.TXTPROCEDURE.BackColor = System.Drawing.Color.Linen
        Me.TXTPROCEDURE.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROCEDURE.Location = New System.Drawing.Point(407, 116)
        Me.TXTPROCEDURE.MaxLength = 300
        Me.TXTPROCEDURE.Multiline = True
        Me.TXTPROCEDURE.Name = "TXTPROCEDURE"
        Me.TXTPROCEDURE.Size = New System.Drawing.Size(290, 133)
        Me.TXTPROCEDURE.TabIndex = 894
        '
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.Linen
        Me.TXTNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.Location = New System.Drawing.Point(407, 56)
        Me.TXTNAME.MaxLength = 100
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(233, 23)
        Me.TXTNAME.TabIndex = 887
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(324, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 15)
        Me.Label18.TabIndex = 871
        Me.Label18.Text = "Surgery Name"
        '
        'PBEXCEL
        '
        Me.PBEXCEL.Image = Global.TRISHALADEVI.My.Resources.Resources.Excel_icon
        Me.PBEXCEL.Location = New System.Drawing.Point(497, 13)
        Me.PBEXCEL.Name = "PBEXCEL"
        Me.PBEXCEL.Size = New System.Drawing.Size(25, 25)
        Me.PBEXCEL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEXCEL.TabIndex = 241
        Me.PBEXCEL.TabStop = False
        '
        'GRIDNAME
        '
        Me.GRIDNAME.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDNAME.Location = New System.Drawing.Point(12, 33)
        Me.GRIDNAME.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GRIDNAME.MainView = Me.GRIDSURGERY
        Me.GRIDNAME.Name = "GRIDNAME"
        Me.GRIDNAME.Size = New System.Drawing.Size(308, 517)
        Me.GRIDNAME.TabIndex = 0
        Me.GRIDNAME.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GRIDSURGERY})
        '
        'GRIDSURGERY
        '
        Me.GRIDSURGERY.Appearance.Row.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRIDSURGERY.Appearance.Row.Options.UseFont = True
        Me.GRIDSURGERY.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GNAME})
        Me.GRIDSURGERY.GridControl = Me.GRIDNAME
        Me.GRIDSURGERY.Name = "GRIDSURGERY"
        Me.GRIDSURGERY.OptionsBehavior.AllowIncrementalSearch = True
        Me.GRIDSURGERY.OptionsBehavior.Editable = False
        Me.GRIDSURGERY.OptionsCustomization.AllowColumnMoving = False
        Me.GRIDSURGERY.OptionsCustomization.AllowGroup = False
        Me.GRIDSURGERY.OptionsView.ColumnAutoWidth = False
        Me.GRIDSURGERY.OptionsView.ShowAutoFilterRow = True
        Me.GRIDSURGERY.OptionsView.ShowGroupPanel = False
        '
        'GNAME
        '
        Me.GNAME.Caption = "Name"
        Me.GNAME.FieldName = "NAME"
        Me.GNAME.Name = "GNAME"
        Me.GNAME.Visible = True
        Me.GNAME.VisibleIndex = 0
        Me.GNAME.Width = 275
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.Black
        Me.CMDREFRESH.Location = New System.Drawing.Point(528, 13)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 3
        Me.CMDREFRESH.Text = "&Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'CMDADD
        '
        Me.CMDADD.BackColor = System.Drawing.Color.Transparent
        Me.CMDADD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDADD.FlatAppearance.BorderSize = 0
        Me.CMDADD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDADD.ForeColor = System.Drawing.Color.Black
        Me.CMDADD.Location = New System.Drawing.Point(411, 522)
        Me.CMDADD.Name = "CMDADD"
        Me.CMDADD.Size = New System.Drawing.Size(80, 28)
        Me.CMDADD.TabIndex = 2
        Me.CMDADD.Text = "&Add New"
        Me.CMDADD.UseVisualStyleBackColor = False
        '
        'CMDEDIT
        '
        Me.CMDEDIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEDIT.FlatAppearance.BorderSize = 0
        Me.CMDEDIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEDIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEDIT.Location = New System.Drawing.Point(617, 13)
        Me.CMDEDIT.Name = "CMDEDIT"
        Me.CMDEDIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEDIT.TabIndex = 4
        Me.CMDEDIT.Text = "E&dit"
        Me.CMDEDIT.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.Black
        Me.CMDEXIT.Location = New System.Drawing.Point(497, 522)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 3
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(15, 13)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(171, 14)
        Me.Label21.TabIndex = 232
        Me.Label21.Text = "Double Click on Patient to Edit"
        '
        'SurgeryDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(713, 562)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SurgeryDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Surgery Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel2.ResumeLayout(False)
        Me.BlendPanel2.PerformLayout()
        CType(Me.GRIDMEDICINES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEXCEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDNAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GRIDSURGERY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents BlendPanel2 As VbPowerPack.BlendPanel
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PBEXCEL As System.Windows.Forms.PictureBox
    Private WithEvents GRIDNAME As DevExpress.XtraGrid.GridControl
    Private WithEvents GRIDSURGERY As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CMDREFRESH As System.Windows.Forms.Button
    Friend WithEvents CMDADD As System.Windows.Forms.Button
    Friend WithEvents CMDEDIT As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTPROCEDURE As System.Windows.Forms.TextBox
    Friend WithEvents GRIDMEDICINES As System.Windows.Forms.DataGridView
    Friend WithEvents GMEDSRNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GMEDICINE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
