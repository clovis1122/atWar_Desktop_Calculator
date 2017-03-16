<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add
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
        Me.Stack4count = New System.Windows.Forms.NumericUpDown()
        Me.Stack3count = New System.Windows.Forms.NumericUpDown()
        Me.Stack2count = New System.Windows.Forms.NumericUpDown()
        Me.Stack1count = New System.Windows.Forms.NumericUpDown()
        Me.Stack4_label = New System.Windows.Forms.Label()
        Me.Stack3_label = New System.Windows.Forms.Label()
        Me.Stack2_label = New System.Windows.Forms.Label()
        Me.Stack1_label = New System.Windows.Forms.Label()
        Me.SelectedUnit = New System.Windows.Forms.Label()
        Me.Done = New System.Windows.Forms.Button()
        CType(Me.Stack4count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stack3count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stack2count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stack1count, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stack4count
        '
        Me.Stack4count.Location = New System.Drawing.Point(127, 115)
        Me.Stack4count.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.Stack4count.Name = "Stack4count"
        Me.Stack4count.Size = New System.Drawing.Size(42, 20)
        Me.Stack4count.TabIndex = 26
        '
        'Stack3count
        '
        Me.Stack3count.Location = New System.Drawing.Point(128, 89)
        Me.Stack3count.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.Stack3count.Name = "Stack3count"
        Me.Stack3count.Size = New System.Drawing.Size(41, 20)
        Me.Stack3count.TabIndex = 25
        '
        'Stack2count
        '
        Me.Stack2count.Location = New System.Drawing.Point(128, 63)
        Me.Stack2count.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.Stack2count.Name = "Stack2count"
        Me.Stack2count.Size = New System.Drawing.Size(41, 20)
        Me.Stack2count.TabIndex = 24
        '
        'Stack1count
        '
        Me.Stack1count.Location = New System.Drawing.Point(128, 37)
        Me.Stack1count.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.Stack1count.Name = "Stack1count"
        Me.Stack1count.Size = New System.Drawing.Size(41, 20)
        Me.Stack1count.TabIndex = 23
        '
        'Stack4_label
        '
        Me.Stack4_label.AutoSize = True
        Me.Stack4_label.Location = New System.Drawing.Point(12, 115)
        Me.Stack4_label.Name = "Stack4_label"
        Me.Stack4_label.Size = New System.Drawing.Size(44, 13)
        Me.Stack4_label.TabIndex = 22
        Me.Stack4_label.Text = "Stack 4"
        '
        'Stack3_label
        '
        Me.Stack3_label.AutoSize = True
        Me.Stack3_label.Location = New System.Drawing.Point(12, 89)
        Me.Stack3_label.Name = "Stack3_label"
        Me.Stack3_label.Size = New System.Drawing.Size(44, 13)
        Me.Stack3_label.TabIndex = 21
        Me.Stack3_label.Text = "Stack 3"
        '
        'Stack2_label
        '
        Me.Stack2_label.AutoSize = True
        Me.Stack2_label.Location = New System.Drawing.Point(12, 63)
        Me.Stack2_label.Name = "Stack2_label"
        Me.Stack2_label.Size = New System.Drawing.Size(44, 13)
        Me.Stack2_label.TabIndex = 20
        Me.Stack2_label.Text = "Stack 2"
        '
        'Stack1_label
        '
        Me.Stack1_label.AutoSize = True
        Me.Stack1_label.Location = New System.Drawing.Point(12, 37)
        Me.Stack1_label.Name = "Stack1_label"
        Me.Stack1_label.Size = New System.Drawing.Size(44, 13)
        Me.Stack1_label.TabIndex = 19
        Me.Stack1_label.Text = "Stack 1"
        '
        'SelectedUnit
        '
        Me.SelectedUnit.AutoSize = True
        Me.SelectedUnit.Location = New System.Drawing.Point(12, 9)
        Me.SelectedUnit.Name = "SelectedUnit"
        Me.SelectedUnit.Size = New System.Drawing.Size(157, 13)
        Me.SelectedUnit.TabIndex = 17
        Me.SelectedUnit.Text = "How many do you want to add?"
        '
        'Done
        '
        Me.Done.Location = New System.Drawing.Point(15, 141)
        Me.Done.Name = "Done"
        Me.Done.Size = New System.Drawing.Size(154, 23)
        Me.Done.TabIndex = 27
        Me.Done.Text = "Done"
        Me.Done.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(174, 173)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.Stack4count)
        Me.Controls.Add(Me.Stack3count)
        Me.Controls.Add(Me.Stack2count)
        Me.Controls.Add(Me.Stack1count)
        Me.Controls.Add(Me.Stack4_label)
        Me.Controls.Add(Me.Stack3_label)
        Me.Controls.Add(Me.Stack2_label)
        Me.Controls.Add(Me.Stack1_label)
        Me.Controls.Add(Me.SelectedUnit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Add"
        Me.Text = "Add"
        CType(Me.Stack4count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stack3count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stack2count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stack1count, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Stack4count As System.Windows.Forms.NumericUpDown
    Friend WithEvents Stack3count As System.Windows.Forms.NumericUpDown
    Friend WithEvents Stack2count As System.Windows.Forms.NumericUpDown
    Friend WithEvents Stack1count As System.Windows.Forms.NumericUpDown
    Friend WithEvents Stack4_label As System.Windows.Forms.Label
    Friend WithEvents Stack3_label As System.Windows.Forms.Label
    Friend WithEvents Stack2_label As System.Windows.Forms.Label
    Friend WithEvents Stack1_label As System.Windows.Forms.Label
    Friend WithEvents SelectedUnit As System.Windows.Forms.Label
    Friend WithEvents Done As System.Windows.Forms.Button
End Class
