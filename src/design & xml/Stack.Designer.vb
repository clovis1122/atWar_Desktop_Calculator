<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stack
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stack))
        Me.StackGroup = New System.Windows.Forms.GroupBox()
        Me.Bonus = New System.Windows.Forms.Button()
        Me.Config = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Strategy = New System.Windows.Forms.ComboBox()
        Me.LabelStrategy = New System.Windows.Forms.Label()
        Me.StackView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.StackGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'StackGroup
        '
        Me.StackGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StackGroup.Controls.Add(Me.Bonus)
        Me.StackGroup.Controls.Add(Me.Config)
        Me.StackGroup.Controls.Add(Me.Delete)
        Me.StackGroup.Controls.Add(Me.Strategy)
        Me.StackGroup.Controls.Add(Me.LabelStrategy)
        Me.StackGroup.Controls.Add(Me.StackView)
        Me.StackGroup.Controls.Add(Me.Status)
        Me.StackGroup.Controls.Add(Me.LabelStatus)
        Me.StackGroup.Location = New System.Drawing.Point(3, 3)
        Me.StackGroup.Name = "StackGroup"
        Me.StackGroup.Size = New System.Drawing.Size(379, 155)
        Me.StackGroup.TabIndex = 50
        Me.StackGroup.TabStop = False
        Me.StackGroup.Text = "Stack"
        '
        'Bonus
        '
        Me.Bonus.Location = New System.Drawing.Point(274, 20)
        Me.Bonus.Name = "Bonus"
        Me.Bonus.Size = New System.Drawing.Size(21, 22)
        Me.Bonus.TabIndex = 46
        Me.Bonus.Text = "B"
        Me.Bonus.UseVisualStyleBackColor = True
        '
        'Config
        '
        Me.Config.Image = Global.atWarCalculator.My.Resources.Resources.Screenshot_1
        Me.Config.Location = New System.Drawing.Point(295, 20)
        Me.Config.Name = "Config"
        Me.Config.Size = New System.Drawing.Size(24, 23)
        Me.Config.TabIndex = 45
        Me.Config.Text = "  "
        Me.Config.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(318, 20)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(55, 22)
        Me.Delete.TabIndex = 44
        Me.Delete.Text = "Clear"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Strategy
        '
        Me.Strategy.BackColor = System.Drawing.SystemColors.Window
        Me.Strategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Strategy.FormattingEnabled = True
        Me.Strategy.Items.AddRange(New Object() {"None", "Blitzkrieg", "Desert Storm", "Great Combinator", "Guerrilla Warfare", "Hybrid Warfare", "Imperialist", "Iron Fist", "Lucky Bastard", "Master of Stealth", "Naval Commander", "Perfect Defense", "Relentless Attack", "Sky Menace"})
        Me.Strategy.Location = New System.Drawing.Point(154, 21)
        Me.Strategy.Name = "Strategy"
        Me.Strategy.Size = New System.Drawing.Size(118, 21)
        Me.Strategy.TabIndex = 43
        '
        'LabelStrategy
        '
        Me.LabelStrategy.AutoSize = True
        Me.LabelStrategy.Location = New System.Drawing.Point(108, 25)
        Me.LabelStrategy.Name = "LabelStrategy"
        Me.LabelStrategy.Size = New System.Drawing.Size(49, 13)
        Me.LabelStrategy.TabIndex = 42
        Me.LabelStrategy.Text = "Strategy:"
        '
        'StackView
        '
        Me.StackView.BackColor = System.Drawing.SystemColors.Window
        Me.StackView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.StackView.ForeColor = System.Drawing.SystemColors.WindowText
        Me.StackView.Location = New System.Drawing.Point(5, 45)
        Me.StackView.Name = "StackView"
        Me.StackView.ShowGroups = False
        Me.StackView.Size = New System.Drawing.Size(369, 100)
        Me.StackView.SmallImageList = Me.ImageList1
        Me.StackView.TabIndex = 41
        Me.StackView.UseCompatibleStateImageBehavior = False
        Me.StackView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Unit"
        Me.ColumnHeader1.Width = 82
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Attack"
        Me.ColumnHeader2.Width = 57
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Defense"
        Me.ColumnHeader3.Width = 57
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Critical"
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "HP"
        Me.ColumnHeader5.Width = 54
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Amount"
        Me.ColumnHeader6.Width = 66
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Screenshot_1.jpg")
        Me.ImageList1.Images.SetKeyName(1, "general.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Militia.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Infantry.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Tank.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Marine.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Anti-aircraft.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Submarine.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Destroyer.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Transport.jpg")
        Me.ImageList1.Images.SetKeyName(10, "Bombers.jpg")
        Me.ImageList1.Images.SetKeyName(11, "Helicopters.jpg")
        Me.ImageList1.Images.SetKeyName(12, "Stealth.jpg")
        Me.ImageList1.Images.SetKeyName(13, "Sentry Plane.jpg")
        Me.ImageList1.Images.SetKeyName(14, "Air Transport.jpg")
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.Window
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.FormattingEnabled = True
        Me.Status.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Status.Items.AddRange(New Object() {"Disable", "Attack", "Defense"})
        Me.Status.Location = New System.Drawing.Point(39, 21)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(68, 21)
        Me.Status.TabIndex = 25
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(2, 24)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(40, 13)
        Me.LabelStatus.TabIndex = 18
        Me.LabelStatus.Text = "Status:"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "None.jpg")
        Me.ImageList2.Images.SetKeyName(1, "Blitzkrieg.jpg")
        Me.ImageList2.Images.SetKeyName(2, "Desert Storm.jpg")
        Me.ImageList2.Images.SetKeyName(3, "Great Combinator.jpg")
        Me.ImageList2.Images.SetKeyName(4, "Guerrilla Warfare.jpg")
        Me.ImageList2.Images.SetKeyName(5, "Imperialist.jpg")
        Me.ImageList2.Images.SetKeyName(6, "Hybrid Warfare.jpg")
        Me.ImageList2.Images.SetKeyName(7, "Iron Fist.jpg")
        Me.ImageList2.Images.SetKeyName(8, "Lucky Bastard.jpg")
        Me.ImageList2.Images.SetKeyName(9, "Perfect Defense.jpg")
        Me.ImageList2.Images.SetKeyName(10, "Naval Commander.jpg")
        Me.ImageList2.Images.SetKeyName(11, "Master of Stealth.jpg")
        Me.ImageList2.Images.SetKeyName(12, "Relentless Attack.jpg")
        Me.ImageList2.Images.SetKeyName(13, "Sky Menace.jpg")
        '
        'Stack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.StackGroup)
        Me.Name = "Stack"
        Me.Size = New System.Drawing.Size(386, 161)
        Me.StackGroup.ResumeLayout(False)
        Me.StackGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StackGroup As GroupBox
    Friend WithEvents Config As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Strategy As ComboBox
    Friend WithEvents LabelStrategy As Label
    Friend WithEvents StackView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Status As ComboBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Bonus As Button
End Class
