<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Progress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddUnits1 = New atWarCalculator.AddUnits()
        Me.Simulator1 = New atWarCalculator.Simulator()
        Me.Stack4 = New atWarCalculator.Stack()
        Me.Stack2 = New atWarCalculator.Stack()
        Me.Stack3 = New atWarCalculator.Stack()
        Me.Stack1 = New atWarCalculator.Stack()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Progress)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Location = New System.Drawing.Point(152, 337)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(987, 24)
        Me.Panel1.TabIndex = 55
        '
        'Progress
        '
        Me.Progress.AutoSize = True
        Me.Progress.Location = New System.Drawing.Point(3, 6)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(51, 13)
        Me.Progress.TabIndex = 30
        Me.Progress.Text = "Progress:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ProgressBar1.Location = New System.Drawing.Point(54, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(930, 18)
        Me.ProgressBar1.TabIndex = 29
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 293)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(138, 68)
        Me.Panel2.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Clovis and Darkmace"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Made by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-2, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Version 3.11 (13.SEPT.16)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "atWar Calculator"
        '
        'AddUnits1
        '
        Me.AddUnits1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddUnits1.Location = New System.Drawing.Point(9, 12)
        Me.AddUnits1.Name = "AddUnits1"
        Me.AddUnits1.Size = New System.Drawing.Size(138, 281)
        Me.AddUnits1.TabIndex = 63
        '
        'Simulator1
        '
        Me.Simulator1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Simulator1.Location = New System.Drawing.Point(935, 15)
        Me.Simulator1.Name = "Simulator1"
        Me.Simulator1.Size = New System.Drawing.Size(204, 317)
        Me.Simulator1.TabIndex = 62
        '
        'Stack4
        '
        Me.Stack4.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Stack4.Location = New System.Drawing.Point(546, 175)
        Me.Stack4.Name = "Stack4"
        Me.Stack4.Size = New System.Drawing.Size(386, 157)
        Me.Stack4.TabIndex = 60
        '
        'Stack2
        '
        Me.Stack2.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Stack2.Location = New System.Drawing.Point(153, 175)
        Me.Stack2.Name = "Stack2"
        Me.Stack2.Size = New System.Drawing.Size(386, 157)
        Me.Stack2.TabIndex = 59
        '
        'Stack3
        '
        Me.Stack3.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Stack3.Location = New System.Drawing.Point(545, 15)
        Me.Stack3.Name = "Stack3"
        Me.Stack3.Size = New System.Drawing.Size(386, 157)
        Me.Stack3.TabIndex = 58
        '
        'Stack1
        '
        Me.Stack1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Stack1.Location = New System.Drawing.Point(153, 15)
        Me.Stack1.Name = "Stack1"
        Me.Stack1.Size = New System.Drawing.Size(386, 157)
        Me.Stack1.TabIndex = 57
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1142, 363)
        Me.Controls.Add(Me.AddUnits1)
        Me.Controls.Add(Me.Simulator1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Stack4)
        Me.Controls.Add(Me.Stack2)
        Me.Controls.Add(Me.Stack3)
        Me.Controls.Add(Me.Stack1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Calculator"
        Me.Text = "atWar Battle Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Progress As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Stack1 As Stack
    Friend WithEvents Stack3 As Stack
    Friend WithEvents Stack2 As Stack
    Friend WithEvents Stack4 As Stack
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Simulator1 As Simulator
    Friend WithEvents AddUnits1 As AddUnits
End Class
