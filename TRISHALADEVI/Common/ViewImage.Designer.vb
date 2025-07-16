<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewImage
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
        Me.PBSOFTCOPY = New System.Windows.Forms.PictureBox
        CType(Me.PBSOFTCOPY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBSOFTCOPY
        '
        Me.PBSOFTCOPY.BackColor = System.Drawing.Color.Transparent
        Me.PBSOFTCOPY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBSOFTCOPY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBSOFTCOPY.ErrorImage = Nothing
        Me.PBSOFTCOPY.InitialImage = Nothing
        Me.PBSOFTCOPY.Location = New System.Drawing.Point(0, 0)
        Me.PBSOFTCOPY.Name = "PBSOFTCOPY"
        Me.PBSOFTCOPY.Size = New System.Drawing.Size(794, 726)
        Me.PBSOFTCOPY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBSOFTCOPY.TabIndex = 418
        Me.PBSOFTCOPY.TabStop = False
        '
        'ViewImage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(794, 726)
        Me.Controls.Add(Me.PBSOFTCOPY)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "ViewImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image"
        CType(Me.PBSOFTCOPY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PBSOFTCOPY As System.Windows.Forms.PictureBox
End Class
