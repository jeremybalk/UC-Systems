<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartScherm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartScherm))
        Me.ToolButton = New System.Windows.Forms.Button()
        Me.FacturerenButton = New System.Windows.Forms.Button()
        Me.ControleButton = New System.Windows.Forms.Button()
        Me.GoedkeuringButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ToolButton
        '
        Me.ToolButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolButton.Location = New System.Drawing.Point(305, 230)
        Me.ToolButton.Margin = New System.Windows.Forms.Padding(10)
        Me.ToolButton.Name = "ToolButton"
        Me.ToolButton.Size = New System.Drawing.Size(172, 44)
        Me.ToolButton.TabIndex = 4
        Me.ToolButton.Text = "Tool"
        Me.ToolButton.UseVisualStyleBackColor = True
        '
        'FacturerenButton
        '
        Me.FacturerenButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturerenButton.Location = New System.Drawing.Point(305, 166)
        Me.FacturerenButton.Margin = New System.Windows.Forms.Padding(10)
        Me.FacturerenButton.Name = "FacturerenButton"
        Me.FacturerenButton.Size = New System.Drawing.Size(172, 44)
        Me.FacturerenButton.TabIndex = 3
        Me.FacturerenButton.Text = "Factureren"
        Me.FacturerenButton.UseVisualStyleBackColor = True
        '
        'ControleButton
        '
        Me.ControleButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControleButton.Location = New System.Drawing.Point(305, 38)
        Me.ControleButton.Margin = New System.Windows.Forms.Padding(10)
        Me.ControleButton.Name = "ControleButton"
        Me.ControleButton.Size = New System.Drawing.Size(172, 44)
        Me.ControleButton.TabIndex = 1
        Me.ControleButton.Text = "Controle"
        Me.ControleButton.UseVisualStyleBackColor = True
        '
        'GoedkeuringButton
        '
        Me.GoedkeuringButton.Location = New System.Drawing.Point(305, 102)
        Me.GoedkeuringButton.Margin = New System.Windows.Forms.Padding(10)
        Me.GoedkeuringButton.Name = "GoedkeuringButton"
        Me.GoedkeuringButton.Size = New System.Drawing.Size(172, 44)
        Me.GoedkeuringButton.TabIndex = 2
        Me.GoedkeuringButton.Text = "Goedkeuring"
        Me.GoedkeuringButton.UseVisualStyleBackColor = True
        '
        'StartScherm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.Controls.Add(Me.GoedkeuringButton)
        Me.Controls.Add(Me.ControleButton)
        Me.Controls.Add(Me.FacturerenButton)
        Me.Controls.Add(Me.ToolButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StartScherm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "UC Systems-SC Export"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolButton As System.Windows.Forms.Button
    Friend WithEvents FacturerenButton As System.Windows.Forms.Button
    Friend WithEvents ControleButton As System.Windows.Forms.Button
    Friend WithEvents GoedkeuringButton As System.Windows.Forms.Button
End Class
