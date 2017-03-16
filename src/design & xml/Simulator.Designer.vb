<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulator
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Config = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.RichTextBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.looper = New System.Windows.Forms.NumericUpDown()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox7.SuspendLayout()
        CType(Me.looper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox7.Controls.Add(Me.Config)
        Me.GroupBox7.Controls.Add(Me.Result)
        Me.GroupBox7.Controls.Add(Me.Start)
        Me.GroupBox7.Controls.Add(Me.looper)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(197, 312)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Simulator"
        '
        'Config
        '
        Me.Config.Image = Global.atWarCalculator.My.Resources.Resources.Screenshot_1
        Me.Config.Location = New System.Drawing.Point(120, 19)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(25, 23)
        Me.Config.TabIndex = 62
        Me.Config.Text = "  "
        Me.Config.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.Location = New System.Drawing.Point(6, 46)
        Me.Result.Name = "Result"
        Me.Result.ReadOnly = True
        Me.Result.Size = New System.Drawing.Size(185, 262)
        Me.Result.TabIndex = 5
        Me.Result.Text = " "
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(146, 19)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(46, 23)
        Me.Start.TabIndex = 3
        Me.Start.Text = "Go!"
        Me.Start.UseVisualStyleBackColor = True
        '
        'looper
        '
        Me.looper.Location = New System.Drawing.Point(50, 20)
        Me.looper.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.looper.Name = "looper"
        Me.looper.Size = New System.Drawing.Size(69, 20)
        Me.looper.TabIndex = 2
        Me.looper.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 22)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "Repeat:"
        '
        'Simulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "Simulator"
        Me.Size = New System.Drawing.Size(204, 319)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.looper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Config As Button
    Friend WithEvents Result As RichTextBox
    Friend WithEvents Start As Button
    Friend WithEvents looper As NumericUpDown
    Friend WithEvents Label29 As Label
End Class
