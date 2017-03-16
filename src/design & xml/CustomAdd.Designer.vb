<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomAdd
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
        Me.Add_custom = New System.Windows.Forms.Button()
        Me.Label_Attack_1 = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Critical = New System.Windows.Forms.NumericUpDown()
        Me.Label_Defense_1 = New System.Windows.Forms.Label()
        Me.Attack = New System.Windows.Forms.NumericUpDown()
        Me.HP = New System.Windows.Forms.NumericUpDown()
        Me.Label_Critical_1 = New System.Windows.Forms.Label()
        Me.Label_HP_1 = New System.Windows.Forms.Label()
        Me.Defend = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        CType(Me.Critical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Attack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Defend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add_custom
        '
        Me.Add_custom.Location = New System.Drawing.Point(15, 162)
        Me.Add_custom.Name = "Add_custom"
        Me.Add_custom.Size = New System.Drawing.Size(85, 24)
        Me.Add_custom.TabIndex = 45
        Me.Add_custom.Text = "Add"
        Me.Add_custom.UseVisualStyleBackColor = True
        '
        'Label_Attack_1
        '
        Me.Label_Attack_1.AutoSize = True
        Me.Label_Attack_1.Location = New System.Drawing.Point(12, 46)
        Me.Label_Attack_1.Name = "Label_Attack_1"
        Me.Label_Attack_1.Size = New System.Drawing.Size(41, 13)
        Me.Label_Attack_1.TabIndex = 39
        Me.Label_Attack_1.Text = "Attack:"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(91, 162)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(86, 24)
        Me.Cancel.TabIndex = 44
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Critical
        '
        Me.Critical.Location = New System.Drawing.Point(127, 126)
        Me.Critical.Name = "Critical"
        Me.Critical.Size = New System.Drawing.Size(49, 20)
        Me.Critical.TabIndex = 49
        Me.Critical.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label_Defense_1
        '
        Me.Label_Defense_1.AutoSize = True
        Me.Label_Defense_1.Location = New System.Drawing.Point(12, 77)
        Me.Label_Defense_1.Name = "Label_Defense_1"
        Me.Label_Defense_1.Size = New System.Drawing.Size(50, 13)
        Me.Label_Defense_1.TabIndex = 40
        Me.Label_Defense_1.Text = "Defense:"
        '
        'Attack
        '
        Me.Attack.Location = New System.Drawing.Point(127, 44)
        Me.Attack.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.Attack.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Attack.Name = "Attack"
        Me.Attack.Size = New System.Drawing.Size(49, 20)
        Me.Attack.TabIndex = 46
        Me.Attack.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'HP
        '
        Me.HP.Location = New System.Drawing.Point(127, 97)
        Me.HP.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.HP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(49, 20)
        Me.HP.TabIndex = 48
        Me.HP.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'Label_Critical_1
        '
        Me.Label_Critical_1.AutoSize = True
        Me.Label_Critical_1.Location = New System.Drawing.Point(12, 133)
        Me.Label_Critical_1.Name = "Label_Critical_1"
        Me.Label_Critical_1.Size = New System.Drawing.Size(58, 13)
        Me.Label_Critical_1.TabIndex = 42
        Me.Label_Critical_1.Text = "Critical (%):"
        '
        'Label_HP_1
        '
        Me.Label_HP_1.AutoSize = True
        Me.Label_HP_1.Location = New System.Drawing.Point(12, 104)
        Me.Label_HP_1.Name = "Label_HP_1"
        Me.Label_HP_1.Size = New System.Drawing.Size(25, 13)
        Me.Label_HP_1.TabIndex = 41
        Me.Label_HP_1.Text = "HP:"
        '
        'Defend
        '
        Me.Defend.Location = New System.Drawing.Point(127, 70)
        Me.Defend.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.Defend.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Defend.Name = "Defend"
        Me.Defend.Size = New System.Drawing.Size(49, 20)
        Me.Defend.TabIndex = 47
        Me.Defend.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Name/Type"
        '
        'Type
        '
        Me.Type.FormattingEnabled = True
        Me.Type.Items.AddRange(New Object() {"Other", "General", "Militia", "Infantry", "Tank", "Marine", "AntiAircraft", "Submarine", "Destroyer", "Transport", "Bomber", "Helicopter", "Stealth", "SentryPlane", "Air Transport"})
        Me.Type.Location = New System.Drawing.Point(80, 12)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(96, 21)
        Me.Type.TabIndex = 52
        '
        'CustomAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(189, 194)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add_custom)
        Me.Controls.Add(Me.Label_Attack_1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Critical)
        Me.Controls.Add(Me.Label_Defense_1)
        Me.Controls.Add(Me.Attack)
        Me.Controls.Add(Me.HP)
        Me.Controls.Add(Me.Label_Critical_1)
        Me.Controls.Add(Me.Label_HP_1)
        Me.Controls.Add(Me.Defend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CustomAdd"
        Me.Text = "CustomAdd"
        CType(Me.Critical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Attack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Defend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add_custom As System.Windows.Forms.Button
    Friend WithEvents Label_Attack_1 As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Critical As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_Defense_1 As System.Windows.Forms.Label
    Friend WithEvents Attack As System.Windows.Forms.NumericUpDown
    Friend WithEvents HP As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label_Critical_1 As System.Windows.Forms.Label
    Friend WithEvents Label_HP_1 As System.Windows.Forms.Label
    Friend WithEvents Defend As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Type As ComboBox
End Class
