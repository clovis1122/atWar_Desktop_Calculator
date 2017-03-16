<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimuConfig
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AvgAttDef = New System.Windows.Forms.CheckBox()
        Me.AvgAlive = New System.Windows.Forms.CheckBox()
        Me.Append = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Append)
        Me.GroupBox1.Controls.Add(Me.AvgAlive)
        Me.GroupBox1.Controls.Add(Me.AvgAttDef)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'AvgAttDef
        '
        Me.AvgAttDef.AutoSize = True
        Me.AvgAttDef.Location = New System.Drawing.Point(6, 19)
        Me.AvgAttDef.Name = "AvgAttDef"
        Me.AvgAttDef.Size = New System.Drawing.Size(109, 17)
        Me.AvgAttDef.TabIndex = 0
        Me.AvgAttDef.Text = "Show avg.att/def"
        Me.AvgAttDef.UseVisualStyleBackColor = True
        '
        'AvgAlive
        '
        Me.AvgAlive.AutoSize = True
        Me.AvgAlive.Location = New System.Drawing.Point(6, 42)
        Me.AvgAlive.Name = "AvgAlive"
        Me.AvgAlive.Size = New System.Drawing.Size(103, 17)
        Me.AvgAlive.TabIndex = 1
        Me.AvgAlive.Text = "Show units alive"
        Me.AvgAlive.UseVisualStyleBackColor = True
        '
        'Append
        '
        Me.Append.AutoSize = True
        Me.Append.Location = New System.Drawing.Point(6, 65)
        Me.Append.Name = "Append"
        Me.Append.Size = New System.Drawing.Size(109, 17)
        Me.Append.TabIndex = 2
        Me.Append.Text = "Append new calc"
        Me.Append.UseVisualStyleBackColor = True
        '
        'SimuConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(137, 106)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SimuConfig"
        Me.Text = "SimuConfig"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Append As CheckBox
    Friend WithEvents AvgAlive As CheckBox
    Friend WithEvents AvgAttDef As CheckBox
End Class
