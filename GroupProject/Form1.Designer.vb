<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnWork = New System.Windows.Forms.Button()
        Me.btnSport = New System.Windows.Forms.Button()
        Me.btnEnt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWork
        '
        Me.btnWork.BackColor = System.Drawing.Color.Cornsilk
        Me.btnWork.BackgroundImage = CType(resources.GetObject("btnWork.BackgroundImage"), System.Drawing.Image)
        Me.btnWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWork.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnWork.ForeColor = System.Drawing.Color.Black
        Me.btnWork.Image = CType(resources.GetObject("btnWork.Image"), System.Drawing.Image)
        Me.btnWork.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWork.Location = New System.Drawing.Point(21, 133)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(616, 67)
        Me.btnWork.TabIndex = 0
        Me.btnWork.Text = "At work"
        Me.btnWork.UseVisualStyleBackColor = False
        '
        'btnSport
        '
        Me.btnSport.BackColor = System.Drawing.Color.Cornsilk
        Me.btnSport.BackgroundImage = CType(resources.GetObject("btnSport.BackgroundImage"), System.Drawing.Image)
        Me.btnSport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSport.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSport.ForeColor = System.Drawing.Color.Black
        Me.btnSport.Image = CType(resources.GetObject("btnSport.Image"), System.Drawing.Image)
        Me.btnSport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSport.Location = New System.Drawing.Point(21, 206)
        Me.btnSport.Name = "btnSport"
        Me.btnSport.Size = New System.Drawing.Size(616, 67)
        Me.btnSport.TabIndex = 1
        Me.btnSport.Text = "In Sports"
        Me.btnSport.UseVisualStyleBackColor = False
        '
        'btnEnt
        '
        Me.btnEnt.BackColor = System.Drawing.Color.Cornsilk
        Me.btnEnt.BackgroundImage = CType(resources.GetObject("btnEnt.BackgroundImage"), System.Drawing.Image)
        Me.btnEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnt.Font = New System.Drawing.Font("Copperplate Gothic Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEnt.ForeColor = System.Drawing.Color.Black
        Me.btnEnt.Image = CType(resources.GetObject("btnEnt.Image"), System.Drawing.Image)
        Me.btnEnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEnt.Location = New System.Drawing.Point(21, 279)
        Me.btnEnt.Name = "btnEnt"
        Me.btnEnt.Size = New System.Drawing.Size(616, 67)
        Me.btnEnt.TabIndex = 2
        Me.btnEnt.Text = "In Entertainment"
        Me.btnEnt.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(659, 465)
        Me.Controls.Add(Me.btnEnt)
        Me.Controls.Add(Me.btnSport)
        Me.Controls.Add(Me.btnWork)
        Me.Name = "frmMenu"
        Me.Text = "x"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWork As Button
    Friend WithEvents btnSport As Button
    Friend WithEvents btnEnt As Button
End Class
