<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infomation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infomation))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtboxinfo = New System.Windows.Forms.RichTextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSave)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtboxinfo)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(558, 403)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(449, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 34)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save to file"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtboxinfo
        '
        Me.txtboxinfo.BackColor = System.Drawing.Color.Gray
        Me.txtboxinfo.BulletIndent = 1
        Me.txtboxinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxinfo.Font = New System.Drawing.Font("Segoe UI Variable Text Semiligh", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxinfo.Location = New System.Drawing.Point(0, 0)
        Me.txtboxinfo.Name = "txtboxinfo"
        Me.txtboxinfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtboxinfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtboxinfo.Size = New System.Drawing.Size(558, 403)
        Me.txtboxinfo.TabIndex = 0
        Me.txtboxinfo.Text = resources.GetString("txtboxinfo.Text")
        '
        'infomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "infomation"
        Me.Text = "infomation"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnSave As Button
    Friend WithEvents txtboxinfo As RichTextBox
End Class
