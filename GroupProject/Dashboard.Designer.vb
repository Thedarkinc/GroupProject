﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AnimatedGIF = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Button3.BorderRadius = 20
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button3.CheckedState.FillColor = System.Drawing.Color.Black
        Me.Guna2Button3.CheckedState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button3.CheckedState.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button3.CustomizableEdges.BottomRight = False
        Me.Guna2Button3.CustomizableEdges.TopRight = False
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button3.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button3.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.Location = New System.Drawing.Point(12, 338)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.PressedColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Guna2Button3.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button3.TabIndex = 2
        Me.Guna2Button3.Text = "Go back"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Button4.BorderRadius = 20
        Me.Guna2Button4.BorderThickness = 1
        Me.Guna2Button4.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button4.CheckedState.FillColor = System.Drawing.Color.Black
        Me.Guna2Button4.CheckedState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button4.CheckedState.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button4.CustomizableEdges.BottomRight = False
        Me.Guna2Button4.CustomizableEdges.TopRight = False
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button4.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button4.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button4.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.Location = New System.Drawing.Point(12, 140)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.PressedColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Guna2Button4.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button4.TabIndex = 7
        Me.Guna2Button4.Text = "View stats"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AnimatedGIF = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button2.CheckedState.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.CheckedState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button2.CheckedState.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button2.CustomizableEdges.BottomRight = False
        Me.Guna2Button2.CustomizableEdges.TopRight = False
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button2.FocusedColor = System.Drawing.Color.MediumPurple
        Me.Guna2Button2.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 200)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Guna2Button2.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "How to empower women"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Maroon
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.CheckedState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button1.CheckedState.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.CheckedState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.CheckedState.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2Button1.CustomizableEdges.BottomRight = False
        Me.Guna2Button1.CustomizableEdges.TopRight = False
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.RoyalBlue
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.MediumOrchid
        Me.Guna2Button1.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Gold
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Font = New System.Drawing.Font("Perpetua Titling MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 79)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Guna2Button1.Size = New System.Drawing.Size(190, 45)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "View Workers"
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.Color.Transparent
        Me.panelmenu.BorderColor = System.Drawing.Color.White
        Me.panelmenu.BorderRadius = 20
        Me.panelmenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.panelmenu.BorderThickness = 2
        Me.panelmenu.Controls.Add(Me.Guna2Button4)
        Me.panelmenu.Controls.Add(Me.Guna2Button1)
        Me.panelmenu.Controls.Add(Me.Guna2Button3)
        Me.panelmenu.Controls.Add(Me.Guna2Button2)
        Me.panelmenu.CustomBorderColor = System.Drawing.Color.White
        Me.panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelmenu.FillColor = System.Drawing.Color.Maroon
        Me.panelmenu.FillColor2 = System.Drawing.Color.Maroon
        Me.panelmenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(205, 443)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(195, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 443)
        Me.Panel1.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(769, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.panelmenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelmenu As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PaymentsBar As Guna.Charts.WinForms.GunaBarDataset
    Friend WithEvents progress As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Panel1 As Panel
End Class
