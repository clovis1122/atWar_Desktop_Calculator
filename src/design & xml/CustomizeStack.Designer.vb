<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomizeStack
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
        Me.InCity = New System.Windows.Forms.CheckBox()
        Me.InDefensiveLine = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'InCity
        '
        Me.InCity.AutoSize = True
        Me.InCity.Location = New System.Drawing.Point(11, 7)
        Me.InCity.Name = "InCity"
        Me.InCity.Size = New System.Drawing.Size(54, 17)
        Me.InCity.TabIndex = 0
        Me.InCity.Text = "In city"
        Me.InCity.UseVisualStyleBackColor = True
        '
        'InDefensiveLine
        '
        Me.InDefensiveLine.AutoSize = True
        Me.InDefensiveLine.Location = New System.Drawing.Point(11, 30)
        Me.InDefensiveLine.Name = "InDefensiveLine"
        Me.InDefensiveLine.Size = New System.Drawing.Size(103, 17)
        Me.InDefensiveLine.TabIndex = 1
        Me.InDefensiveLine.Text = "In defensive line"
        Me.InDefensiveLine.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 50)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(83, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Edit Upgrades..."
        '
        'CustomizeStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(125, 76)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.InDefensiveLine)
        Me.Controls.Add(Me.InCity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomizeStack"
        Me.Text = "CustomizeStack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InCity As CheckBox
    Friend WithEvents InDefensiveLine As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
