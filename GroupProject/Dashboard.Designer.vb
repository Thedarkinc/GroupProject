<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim LPoint1 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        Dim LPoint2 As Guna.Charts.WinForms.LPoint = New Guna.Charts.WinForms.LPoint()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.panelmenu = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PaymentsBar = New Guna.Charts.WinForms.GunaBarDataset()
        Me.progress = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.panelmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AnimatedGIF = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button3.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button3.BorderRadius = 20
        Me.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2Button3.CustomizableEdges.BottomRight = False
        Me.Guna2Button3.CustomizableEdges.TopRight = False
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button3.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button3.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(3, 237)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.SystemColors.MenuBar
        Me.Guna2Button3.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "View Under Paid"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button4.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button4.BorderRadius = 20
        Me.Guna2Button4.CustomizableEdges.BottomRight = False
        Me.Guna2Button4.CustomizableEdges.TopRight = False
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button4.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button4.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(3, 302)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.PressedColor = System.Drawing.SystemColors.MenuBar
        Me.Guna2Button4.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button4.TabIndex = 7
        Me.Guna2Button4.Text = "View stats"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AnimatedGIF = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button2.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.CustomizableEdges.BottomRight = False
        Me.Guna2Button2.CustomizableEdges.TopRight = False
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button2.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button2.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(3, 175)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.SystemColors.MenuBar
        Me.Guna2Button2.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "View Most paid"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.Checked = True
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.CustomizableEdges.BottomRight = False
        Me.Guna2Button1.CustomizableEdges.TopRight = False
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.MediumOrchid
        Me.Guna2Button1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(3, 124)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.SystemColors.MenuBar
        Me.Guna2Button1.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "View Workers"
        '
        'panelmenu
        '
        Me.panelmenu.AutoRoundedCorners = True
        Me.panelmenu.AutoSize = True
        Me.panelmenu.BackColor = System.Drawing.Color.RoyalBlue
        Me.panelmenu.BorderRadius = 97
        Me.panelmenu.Controls.Add(Me.Guna2Button1)
        Me.panelmenu.Controls.Add(Me.Guna2Button2)
        Me.panelmenu.Controls.Add(Me.Guna2Button4)
        Me.panelmenu.Controls.Add(Me.Guna2Button3)
        Me.panelmenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.panelmenu.Location = New System.Drawing.Point(1, 12)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(196, 450)
        Me.panelmenu.TabIndex = 0
        '
        'PaymentsBar
        '
        Me.PaymentsBar.BarPercentage = 1.0R
        Me.PaymentsBar.BorderColors.AddRange(New System.Drawing.Color() {System.Drawing.Color.Black})
        LPoint1.Label = "Males"
        LPoint1.Y = 10.0R
        LPoint2.Label = "Female"
        LPoint2.Y = 5.0R
        Me.PaymentsBar.DataPoints.AddRange(New Guna.Charts.WinForms.LPoint() {LPoint1, LPoint2})
        Me.PaymentsBar.FillColors.AddRange(New System.Drawing.Color() {System.Drawing.Color.Blue, System.Drawing.Color.DeepPink})
        Me.PaymentsBar.IndexLabelForeColor = System.Drawing.Color.White
        Me.PaymentsBar.Label = "Payments"
        '
        'progress
        '
        Me.progress.TargetForm = Me
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(814, 474)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.panelmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelmenu As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PaymentsBar As Guna.Charts.WinForms.GunaBarDataset
    Friend WithEvents progress As Guna.UI2.WinForms.Guna2TaskBarProgress
End Class
