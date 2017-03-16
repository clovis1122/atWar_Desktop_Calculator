<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUnits
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("General", 0)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Militia", 1)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Infantry", 2)
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Tanks", 3)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Marines", 4)
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Anti-aircraft", 5)
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Submarine", 6)
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Destroyer", 7)
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Transport", 8)
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Bombers", 9)
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Helicopters", 10)
        Dim ListViewItem26 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Stealth", 11)
        Dim ListViewItem27 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Sentry Plane", 12)
        Dim ListViewItem28 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Air Transport", 13)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUnits))
        Me.DefaultUnits = New System.Windows.Forms.GroupBox()
        Me.CustomTroop = New System.Windows.Forms.Button()
        Me.AddTroop = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DefaultUnits.SuspendLayout()
        Me.SuspendLayout()
        '
        'DefaultUnits
        '
        Me.DefaultUnits.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DefaultUnits.Controls.Add(Me.CustomTroop)
        Me.DefaultUnits.Controls.Add(Me.AddTroop)
        Me.DefaultUnits.Controls.Add(Me.ListView1)
        Me.DefaultUnits.Location = New System.Drawing.Point(3, 3)
        Me.DefaultUnits.Name = "DefaultUnits"
        Me.DefaultUnits.Size = New System.Drawing.Size(133, 275)
        Me.DefaultUnits.TabIndex = 53
        Me.DefaultUnits.TabStop = False
        Me.DefaultUnits.Text = "Add default unit"
        '
        'CustomTroop
        '
        Me.CustomTroop.Location = New System.Drawing.Point(64, 244)
        Me.CustomTroop.Name = "CustomTroop"
        Me.CustomTroop.Size = New System.Drawing.Size(64, 25)
        Me.CustomTroop.TabIndex = 2
        Me.CustomTroop.Text = "Custom"
        Me.CustomTroop.UseVisualStyleBackColor = True
        '
        'AddTroop
        '
        Me.AddTroop.Location = New System.Drawing.Point(6, 244)
        Me.AddTroop.Name = "AddTroop"
        Me.AddTroop.Size = New System.Drawing.Size(64, 25)
        Me.AddTroop.TabIndex = 1
        Me.AddTroop.Text = "Add"
        Me.AddTroop.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ForeColor = System.Drawing.SystemColors.WindowText
        ListViewItem15.IndentCount = 1
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        ListViewItem25.StateImageIndex = 0
        ListViewItem26.StateImageIndex = 0
        ListViewItem27.StateImageIndex = 0
        ListViewItem28.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25, ListViewItem26, ListViewItem27, ListViewItem28})
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(122, 219)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.SmallIcon
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "general.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Militia.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Infantry.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Tank.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Marine.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Anti-aircraft.jpg")
        Me.ImageList1.Images.SetKeyName(6, "Submarine.jpg")
        Me.ImageList1.Images.SetKeyName(7, "Destroyer.jpg")
        Me.ImageList1.Images.SetKeyName(8, "Transport.jpg")
        Me.ImageList1.Images.SetKeyName(9, "Bombers.jpg")
        Me.ImageList1.Images.SetKeyName(10, "Helicopters.jpg")
        Me.ImageList1.Images.SetKeyName(11, "Stealth.jpg")
        Me.ImageList1.Images.SetKeyName(12, "Sentry Plane.jpg")
        Me.ImageList1.Images.SetKeyName(13, "Air Transport.jpg")
        '
        'AddUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Controls.Add(Me.DefaultUnits)
        Me.Name = "AddUnits"
        Me.Size = New System.Drawing.Size(139, 281)
        Me.DefaultUnits.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DefaultUnits As GroupBox
    Friend WithEvents CustomTroop As Button
    Friend WithEvents AddTroop As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ImageList1 As ImageList
End Class
