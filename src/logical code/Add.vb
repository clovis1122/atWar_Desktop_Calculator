Public Class Add

    Dim ID As Integer
    Dim def_unit As New Stack.default_unit()

    Public Sub setId(ByVal _id As Integer)
        ID = _id
    End Sub

    Public Function getId()
        Return ID
    End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub AddCustom_Click(sender As Object, e As EventArgs)
        Me.Close()
        CustomAdd.setId(ID)
        CustomAdd.ShowDialog()
    End Sub

    Private Function CustomcreateItem(ByVal _count As Integer, ByVal ImgIndex As Integer) As ListViewItem
        Dim newitem As ListViewItem = New ListViewItem(" " + CustomAdd.Type.Text, ImgIndex)
        newitem.SubItems.Add(CustomAdd.Attack.Value.ToString)
        newitem.SubItems.Add(CustomAdd.Defend.Value.ToString)
        newitem.SubItems.Add(CustomAdd.Critical.Value.ToString + "%")
        newitem.SubItems.Add(CustomAdd.HP.Value.ToString)
        newitem.SubItems.Add(_count.ToString)
        newitem.SubItems.Add("Defensive Bonuses")
        Return newitem
    End Function

    Private Function createItem(ByVal _unit As Stack.Preset_unit, ByVal _count As Integer, ByVal ImgIndex As Integer) As ListViewItem
        Dim newitem As ListViewItem = New ListViewItem(_unit.GetName, ImgIndex)
        newitem.SubItems.Add(_unit.GetAttack.ToString)
        newitem.SubItems.Add(_unit.GetDefense.ToString)
        newitem.SubItems.Add((_unit.GetCritical * 100).ToString + "%")
        newitem.SubItems.Add(_unit.GetHP.ToString)
        newitem.SubItems.Add(_count.ToString)
        newitem.SubItems.Add("Defensive Bonuses")
        For Each i As ListViewItem In _unit.GetDefensiveBonuses().Items
            newitem.SubItems.Add(i.SubItems.Item(1).Text + "," + i.Text)
        Next
        Return newitem
    End Function

    Private Sub addTroop(ByRef stack As Stack, ByVal _count As Integer)
        Select Case ID
            Case 0
                stack.add(CustomcreateItem(_count, ID))
            Case 1
                stack.add(createItem(def_unit.General, _count, ID))
            Case 2
                stack.add(createItem(def_unit.Militia, _count, ID))
            Case 3
                stack.add(createItem(def_unit.Infantry, _count, ID))
            Case 4
                stack.add(createItem(def_unit.Tank, _count, ID))
            Case 5
                stack.add(createItem(def_unit.Marine, _count, ID))
            Case 6
                stack.add(createItem(def_unit.AntiAircraft, _count, ID))
            Case 7
                stack.add(createItem(def_unit.Submarine, _count, ID))
            Case 8
                stack.add(createItem(def_unit.Destroyer, _count, ID))
            Case 9
                stack.add(createItem(def_unit.Transport, _count, ID))
            Case 10
                stack.add(createItem(def_unit.Bomber, _count, ID))
            Case 11
                stack.add(createItem(def_unit.Helicopter, _count, ID))
            Case 12
                stack.add(createItem(def_unit.Stealth, _count, ID))
            Case 13
                stack.add(createItem(def_unit.SentryPlane, _count, ID))
            Case 14
                stack.add(createItem(def_unit.AirTransport, _count, ID))
        End Select

    End Sub

    Private Sub Done_Click(sender As Object, e As EventArgs) Handles Done.Click
        If (Stack1count.Value <> 0) Then
            addTroop(Calculator.Stacks(0), Stack1count.Value)

        End If

        If (Stack2count.Value <> 0) Then
            addTroop(Calculator.Stacks(1), Stack2count.Value)
        End If

        If (Stack3count.Value <> 0) Then
            addTroop(Calculator.Stacks(2), Stack3count.Value)
        End If

        If (Stack4count.Value <> 0) Then
            addTroop(Calculator.Stacks(3), Stack4count.Value)
        End If

        Me.Close()
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Stack1count.Enabled = Not (Calculator.Stacks(0).Status.SelectedIndex = 0)
        Stack2count.Enabled = Not (Calculator.Stacks(1).Status.SelectedIndex = 0)
        Stack3count.Enabled = Not (Calculator.Stacks(2).Status.SelectedIndex = 0)
        Stack4count.Enabled = Not (Calculator.Stacks(3).Status.SelectedIndex = 0)
        Stack1count.Value = 0
        Stack2count.Value = 0
        Stack3count.Value = 0
        Stack4count.Value = 0

        SelectedUnit.Text = "How many do you want to add?"

        Select Case ID
            Case 0
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " " + CustomAdd.Type.Text)
            Case 1
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Generals ")
            Case 2
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Militias ")
            Case 3
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Infantries ")
            Case 4
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Tanks ")
            Case 5
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Marines ")
            Case 6
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " AntiAircrafts ")
            Case 7
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Submarines ")
            Case 8
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Destroyers ")
            Case 9
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Sea Transports ")
            Case 10
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Bombers ")
            Case 11
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Helicopters ")
            Case 12
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Stealths ")
            Case 13
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Sentry Planes ")
            Case 14
                SelectedUnit.Text = SelectedUnit.Text.Insert(8, " Air Transports ")
        End Select
    End Sub

End Class