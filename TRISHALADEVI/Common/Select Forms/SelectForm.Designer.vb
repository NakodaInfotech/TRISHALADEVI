<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.BlendPanel1 = New VbPowerPack.BlendPanel
        Me.CMDREFRESH = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMDOK = New System.Windows.Forms.Button
        Me.RBPART = New System.Windows.Forms.RadioButton
        Me.RBSTART = New System.Windows.Forms.RadioButton
        Me.LBSELECT = New System.Windows.Forms.Label
        Me.TXTNAME = New System.Windows.Forms.TextBox
        Me.GRID = New System.Windows.Forms.DataGridView
        Me.TXTFRM = New System.Windows.Forms.TextBox
        Me.BlendPanel1.SuspendLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BlendPanel1
        '
        Me.BlendPanel1.Blend = New VbPowerPack.BlendFill(VbPowerPack.BlendStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(248, Byte), Integer)), System.Drawing.SystemColors.Window)
        Me.BlendPanel1.Controls.Add(Me.TXTFRM)
        Me.BlendPanel1.Controls.Add(Me.CMDREFRESH)
        Me.BlendPanel1.Controls.Add(Me.CMDEXIT)
        Me.BlendPanel1.Controls.Add(Me.CMDOK)
        Me.BlendPanel1.Controls.Add(Me.RBPART)
        Me.BlendPanel1.Controls.Add(Me.RBSTART)
        Me.BlendPanel1.Controls.Add(Me.LBSELECT)
        Me.BlendPanel1.Controls.Add(Me.TXTNAME)
        Me.BlendPanel1.Controls.Add(Me.GRID)
        Me.BlendPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlendPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BlendPanel1.Name = "BlendPanel1"
        Me.BlendPanel1.Size = New System.Drawing.Size(334, 512)
        Me.BlendPanel1.TabIndex = 1
        '
        'CMDREFRESH
        '
        Me.CMDREFRESH.BackColor = System.Drawing.Color.Transparent
        Me.CMDREFRESH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDREFRESH.FlatAppearance.BorderSize = 0
        Me.CMDREFRESH.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDREFRESH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CMDREFRESH.Location = New System.Drawing.Point(127, 450)
        Me.CMDREFRESH.Name = "CMDREFRESH"
        Me.CMDREFRESH.Size = New System.Drawing.Size(80, 28)
        Me.CMDREFRESH.TabIndex = 327
        Me.CMDREFRESH.Text = "Refresh"
        Me.CMDREFRESH.UseVisualStyleBackColor = False
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.Transparent
        Me.CMDEXIT.FlatAppearance.BorderSize = 0
        Me.CMDEXIT.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CMDEXIT.Location = New System.Drawing.Point(213, 450)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(80, 28)
        Me.CMDEXIT.TabIndex = 328
        Me.CMDEXIT.Text = "E&xit"
        Me.CMDEXIT.UseVisualStyleBackColor = False
        '
        'CMDOK
        '
        Me.CMDOK.BackColor = System.Drawing.Color.Transparent
        Me.CMDOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDOK.FlatAppearance.BorderSize = 0
        Me.CMDOK.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CMDOK.Location = New System.Drawing.Point(41, 450)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(80, 28)
        Me.CMDOK.TabIndex = 326
        Me.CMDOK.Text = "&Ok"
        Me.CMDOK.UseVisualStyleBackColor = False
        '
        'RBPART
        '
        Me.RBPART.AutoSize = True
        Me.RBPART.BackColor = System.Drawing.Color.Transparent
        Me.RBPART.Checked = True
        Me.RBPART.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPART.Location = New System.Drawing.Point(192, 39)
        Me.RBPART.Name = "RBPART"
        Me.RBPART.Size = New System.Drawing.Size(115, 19)
        Me.RBPART.TabIndex = 246
        Me.RBPART.TabStop = True
        Me.RBPART.Text = "Any Part of Field"
        Me.RBPART.UseVisualStyleBackColor = False
        '
        'RBSTART
        '
        Me.RBSTART.AutoSize = True
        Me.RBSTART.BackColor = System.Drawing.Color.Transparent
        Me.RBSTART.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBSTART.Location = New System.Drawing.Point(192, 12)
        Me.RBSTART.Name = "RBSTART"
        Me.RBSTART.Size = New System.Drawing.Size(82, 19)
        Me.RBSTART.TabIndex = 245
        Me.RBSTART.Text = "From Start"
        Me.RBSTART.UseVisualStyleBackColor = False
        '
        'LBSELECT
        '
        Me.LBSELECT.AutoSize = True
        Me.LBSELECT.BackColor = System.Drawing.Color.Transparent
        Me.LBSELECT.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.LBSELECT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBSELECT.Location = New System.Drawing.Point(28, 12)
        Me.LBSELECT.Name = "LBSELECT"
        Me.LBSELECT.Size = New System.Drawing.Size(100, 23)
        Me.LBSELECT.TabIndex = 247
        Me.LBSELECT.Text = "Select Form"
        '
        'TXTNAME
        '
        Me.TXTNAME.BackColor = System.Drawing.Color.White
        Me.TXTNAME.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNAME.ForeColor = System.Drawing.Color.Black
        Me.TXTNAME.Location = New System.Drawing.Point(27, 73)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(168, 22)
        Me.TXTNAME.TabIndex = 241
        '
        'GRID
        '
        Me.GRID.AllowUserToAddRows = False
        Me.GRID.AllowUserToDeleteRows = False
        Me.GRID.AllowUserToResizeColumns = False
        Me.GRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.GRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GRID.BackgroundColor = System.Drawing.Color.White
        Me.GRID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GRID.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GRID.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GRID.DefaultCellStyle = DataGridViewCellStyle3
        Me.GRID.GridColor = System.Drawing.SystemColors.ControlText
        Me.GRID.Location = New System.Drawing.Point(27, 96)
        Me.GRID.Margin = New System.Windows.Forms.Padding(2)
        Me.GRID.MultiSelect = False
        Me.GRID.Name = "GRID"
        Me.GRID.ReadOnly = True
        Me.GRID.RowHeadersVisible = False
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.GRID.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GRID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GRID.Size = New System.Drawing.Size(280, 335)
        Me.GRID.TabIndex = 242
        '
        'TXTFRM
        '
        Me.TXTFRM.BackColor = System.Drawing.Color.White
        Me.TXTFRM.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFRM.ForeColor = System.Drawing.Color.Black
        Me.TXTFRM.Location = New System.Drawing.Point(314, 0)
        Me.TXTFRM.Name = "TXTFRM"
        Me.TXTFRM.ReadOnly = True
        Me.TXTFRM.Size = New System.Drawing.Size(17, 23)
        Me.TXTFRM.TabIndex = 329
        Me.TXTFRM.TabStop = False
        Me.TXTFRM.Visible = False
        '
        'SelectForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(334, 512)
        Me.Controls.Add(Me.BlendPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BlendPanel1.ResumeLayout(False)
        Me.BlendPanel1.PerformLayout()
        CType(Me.GRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlendPanel1 As VbPowerPack.BlendPanel
    Friend WithEvents CMDREFRESH As System.Windows.Forms.Button
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents RBPART As System.Windows.Forms.RadioButton
    Friend WithEvents RBSTART As System.Windows.Forms.RadioButton
    Friend WithEvents LBSELECT As System.Windows.Forms.Label
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents GRID As System.Windows.Forms.DataGridView
    Friend WithEvents TXTFRM As System.Windows.Forms.TextBox

End Class
