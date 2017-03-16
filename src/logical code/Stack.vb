Public Class Stack
    'Classes

    Private Class unit

        ' To Document The Code
        ' ''' <summary>
        ' ''' Procedure description
        ' ''' </summary>
        ' ''' <param name="someVariable">someVariable description.</param>
        ' ''' <param name="someVariable">someVariable description.</param>
        ' ''' <remarks></remarks>

        'Item(0) 'Type/Name'
        'Item(1) 'attack'
        'Item(2) 'defense'
        'Item(3) 'Critical'
        'Item(4) 'HP'
        'Item(5) 'Count'
        'Item(6) 'Bonuses'


        'Default Names:
        'General
        'Militia
        'Infantry
        'Tanks
        'Marines
        'Anti-aircraft
        'Submarine
        'Destroyer
        'Sea Transport
        'Bombers
        'Helicopters
        'Stealth
        'Sentry Plane
        'Air Transport


        Private Class DefensiveBonus
            Public type As String
            Public bonus As Integer

            Sub New(ByVal _type As String, ByVal _bonus As Integer)
                type = _type
                bonus = _bonus
            End Sub

        End Class

        Dim attack, defense, hp, max_hp, count, max_count As Integer
        Dim critical As Double
        Dim Dead As Boolean
        Dim index As Integer
        Dim defbonus As Integer

        Public type As String
        Private Bonuses As List(Of DefensiveBonus)

        Public Sub New(ByVal _unit As ListViewItem)
            attack = GetValue(_unit.SubItems(1).Text)
            defense = GetValue(_unit.SubItems(2).Text)
            hp = GetValue(_unit.SubItems(4).Text)
            max_hp = hp
            count = GetValue(_unit.SubItems(5).Text)
            max_count = count
            critical = GetValue(_unit.SubItems(3).Text) / 100
            Dead = False
            type = _unit.SubItems(0).Text

            Bonuses = New List(Of DefensiveBonus)

            For i As Integer = 7 To _unit.SubItems.Count - 1
                Bonuses.Add(New DefensiveBonus(_unit.SubItems(i).Text.Substring(_unit.SubItems(i).Text.IndexOf(",") + 1), Stack.GetValue(_unit.SubItems(i).Text)))
            Next
            defbonus = 0
        End Sub


        Public Sub addBonuses(ByVal _type As String, _bonus As Integer)
            Bonuses.Add(New DefensiveBonus(_type, _bonus))
        End Sub

        Public Sub Clearbonuses()
            Bonuses.Clear()
        End Sub

        Public Sub SetDefensiveBonus(ByVal enemy As String)
            defbonus = 0
            If (Bonuses.Count > 0) Then
                For Each i As DefensiveBonus In Bonuses
                    If (i.type.Equals(enemy) Or (i.type.Equals("InCity") And inCity) Or (i.type.Equals("DefensiveLine") And inDefensiveLine)) Then
                        defbonus += i.bonus
                    End If
                Next
            End If
        End Sub

        Public Sub SetIndex(ByVal NewIndex As Integer)
            index = NewIndex
        End Sub

        Public Function GetIndex() As Integer
            Return index
        End Function

        Public Function GetAttackBonus()
            Return (count * (attack + 1))
        End Function

        Public Function GetDefenseBonus()
            Return (count * (defense + defbonus + 1))
        End Function

        Public Function GetAttack()
            Return attack
        End Function

        Public Function GetDefense()
            Return defense
        End Function

        Public Function getCount() As Integer
            Return count
        End Function

        Public Function GetRoll(ByVal isAttacking As Boolean, ByVal multiplier As Double, ByRef rand As System.Random) As Integer
            Dim roll As Integer

            If (isAttacking) Then
                roll = CascadingRandom(attack, multiplier, rand)
                If (attack > 15) AndAlso (roll <= (attack / 2)) Then
                    roll = (attack \ 2)
                End If

                If (critical <> 0) AndAlso Critical_hit(rand) Then
                    roll = (roll + attack)
                End If

            Else
                roll = CascadingRandom(Math.Max(1, defense + defbonus), multiplier, rand)

                If (defense > 15) AndAlso (roll <= (defense / 2)) Then
                    roll = (defense \ 2)
                End If

                If (critical <> 0) AndAlso Critical_hit(rand) Then
                    roll = (roll + defense)
                End If
            End If
            Return roll
        End Function

        Public Function Damaged(ByRef damage As Integer) As Integer
            While (damage >= hp)
                damage = (damage - hp)
                hp = max_hp
                count -= 1
                If (count = 0) Then
                    Dead = True
                    Return damage
                End If
            End While
            hp = (hp - damage)
            Return 0
        End Function

        Public Function IsDead() As Boolean
            Return Dead
        End Function

        Private Function Critical_hit(ByVal rand As System.Random) As Boolean
            If (rand.NextDouble() <= critical) Then
                Return True
            End If
            Return False
        End Function

        Private Function CascadingRandom(ByVal MaxRoll As Integer, ByVal multiplier As Double, ByRef rand As System.Random) As Integer
            If (multiplier < 1) Then
                Dim value As Integer = 1
                For i As Integer = 1 To (MaxRoll - 1)
                    If (rand.NextDouble > multiplier) Then
                        Exit For
                    End If
                    value += 1
                Next

                If ((value = MaxRoll) AndAlso (rand.NextDouble <= multiplier)) Then
                    Return CascadingRandom(MaxRoll, multiplier, rand)
                End If

                Return value
            End If
            Return (Math.Ceiling(rand.Next(0, MaxRoll)) + 1)
        End Function

        Public Sub restore()
            count = max_count
            hp = max_hp
            Dead = False
        End Sub

    End Class

    Public Class Preset_unit
        Dim attack, defense, hp As Integer
        Dim Critical As Double
        Dim name As String
        Dim DefensiveBonuses As ListView

        Public Sub New(ByVal _name As String, ByVal _att As Integer, ByVal _def As Integer, ByVal _critical As Double, ByVal _hp As Integer, ByRef Defbonus As ListView)
            name = _name
            attack = _att
            defense = _def
            hp = _hp
            Critical = _critical / 100
            DefensiveBonuses = Defbonus
        End Sub

        Public Function GetName() As String
            Return name
        End Function
        Public Function GetAttack() As Integer
            Return attack
        End Function
        Public Function GetDefense() As Integer
            Return defense
        End Function
        Public Function GetHP() As Integer
            Return hp
        End Function
        Public Function GetCritical() As Double
            Return Critical
        End Function

        Public Function GetDefensiveBonuses() As ListView
            Return DefensiveBonuses
        End Function

    End Class

    Public Class default_unit

        Public Shared Function GetNames() As List(Of String)
            Dim Names As List(Of String) = New List(Of String)
            Names.Add("General")
            Names.Add("Militia")
            Names.Add("Infantry")
            Names.Add("Tanks")
            Names.Add("Marines")
            Names.Add("Anti-aircraft")
            Names.Add("Submarine")
            Names.Add("Destroyer")
            Names.Add("Sea Transport")
            Names.Add("Bombers")
            Names.Add("Helicopters")
            Names.Add("Stealth")
            Names.Add("Sentry Plane")
            Names.Add("Air Transport")
            Return Names
        End Function

        Public Function General() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("General", 1, 1, 0, 1, bonus)
        End Function

        Public Function Militia() As Preset_unit
            Dim bonus As ListView = New ListView()
            bonus.Items.Add("Helicopters")
            bonus.Items.Item(0).SubItems.Add("-1")
            Return New Preset_unit("Militia", 3, 4, 0, 7, bonus)
        End Function

        Public Function Infantry() As Preset_unit
            Dim bonus As ListView = New ListView()
            bonus.Items.Add("Helicopters")
            bonus.Items.Item(0).SubItems.Add("-2")
            Return New Preset_unit("Infantry", 4, 6, 5, 7, bonus)
        End Function

        Public Function Tank() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Tanks", 8, 4, 5, 7, bonus)
        End Function

        Public Function Marine() As Preset_unit
            Dim bonus As ListView = New ListView()
            bonus.Items.Add("Infantry")
            bonus.Items.Item(0).SubItems.Add("1")
            Return New Preset_unit("Marines", 7, 3, 5, 7, bonus)
        End Function

        Public Function AntiAircraft() As Preset_unit
            Dim bonus As ListView = New ListView()
            bonus.Items.Add("Stealth")
            bonus.Items.Item(0).SubItems.Add("8")

            bonus.Items.Add("Bombers")
            bonus.Items.Item(1).SubItems.Add("8")

            bonus.Items.Add("Helicopters")
            bonus.Items.Item(2).SubItems.Add("8")

            bonus.Items.Add("Air Transport")
            bonus.Items.Item(3).SubItems.Add("8")

            bonus.Items.Add("Sentry Plane")
            bonus.Items.Item(4).SubItems.Add("8")

            Return New Preset_unit("Anti-aircraft", 1, 3, 5, 7, bonus)
        End Function

        Public Function Submarine() As Preset_unit
            Dim bonus As ListView = New ListView()

            bonus.Items.Add("Bombers")
            bonus.Items.Item(0).SubItems.Add("1")

            bonus.Items.Add("Infantry")
            bonus.Items.Item(1).SubItems.Add("1")

            bonus.Items.Add("Destroyer")
            bonus.Items.Item(2).SubItems.Add("2")

            Return New Preset_unit("Submarine", 7, 5, 5, 7, bonus)
        End Function

        Public Function Destroyer() As Preset_unit
            Dim bonus As ListView = New ListView()

            bonus.Items.Add("Bombers")
            bonus.Items.Item(0).SubItems.Add("1")

            bonus.Items.Add("Submarine")
            bonus.Items.Item(1).SubItems.Add("-1")

            Return New Preset_unit("Destroyer", 9, 7, 5, 7, bonus)
        End Function

        Public Function Transport() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Sea Transport", 1, 2, 5, 7, bonus)
        End Function

        Public Function Bomber() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Bombers", 6, 6, 5, 7, bonus)
        End Function

        Public Function Helicopter() As Preset_unit
            Dim bonus As ListView = New ListView()
            bonus.Items.Add("Stealth")
            bonus.Items.Item(0).SubItems.Add("-2")

            Return New Preset_unit("Helicopters", 6, 4, 5, 7, bonus)
        End Function

        Public Function Stealth() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Stealth", 7, 4, 5, 7, bonus)
        End Function

        Public Function SentryPlane() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Sentry Plane", 1, 4, 0, 7, bonus)
        End Function

        Public Function AirTransport() As Preset_unit
            Dim bonus As ListView = New ListView()
            Return New Preset_unit("Air Transport", 1, 2, 5, 7, bonus)
        End Function
    End Class

    Public Class Statistic
        Private T_victory As Integer
        Private T_UnitsAlive As Double
        Private T_AttackRolls As Double
        Private T_DefenseRolls As Double
        Private T_waves As Double

        Sub New()
            T_UnitsAlive = T_AttackRolls = T_DefenseRolls = T_waves = T_victory = 0
        End Sub

        Public Sub NextWave()
            T_waves += 1
        End Sub
        Public Sub Clear()
            T_UnitsAlive = 0
            T_AttackRolls = 0
            T_DefenseRolls = 0
            T_waves = 0
            T_victory = 0
        End Sub

        Public Sub Victory()
            T_victory += 1
        End Sub
        Public Function GetVictories()
            Return T_victory
        End Function

        Public Sub AddAttackRoll(ByVal _value As Integer)
            T_AttackRolls += _value
        End Sub
        Public Function GetAvgAtt() As Double
            Return (T_AttackRolls * 1.0 / T_waves)
        End Function


        Public Sub AddDefenseRoll(ByVal _value As Integer)
            T_DefenseRolls += _value
        End Sub
        Public Function GetAvgDef() As Double
            Return (T_DefenseRolls * 1.0 / T_waves)
        End Function

        Public Sub AddUnitsAlive(ByVal _value As Integer)
            T_UnitsAlive += _value
        End Sub
        Public Function GetAvgUnitsAlive(ByVal _loop As Integer) As Double
            Return (T_UnitsAlive / _loop)
        End Function

    End Class

    'Attributes

    Public ID As Integer
    Private General As Boolean

    Private units As List(Of unit)
    Private UnitCount As Integer
    Private _IsAttacking As Boolean
    Private _IsDead As Boolean
    Private defender As Boolean
    Private currentUnit As unit
    Private stat As Statistic


    Public OriginalStack As List(Of ListViewItem)
    Public Shared inCity As Boolean
    Public Shared inDefensiveLine As Boolean


    Public GDefense As Boolean
    Public GMilitiaHP As Boolean
    Public GInfantryA As Boolean
    Public GTankA As Boolean
    Public GBomberA As Boolean
    Public GLucky As Boolean

    Public StrongAA As Boolean
    Public SaferTrans As Boolean
    Public LuckyTank As Boolean
    Public LuckyMil As Boolean
    Public LuckyMar As Boolean
    Public LuckyInf As Boolean



    'Start & Utility


    Public Sub build()
        units.Clear()
        UnitCount = 0
        stat.Clear()

        If StackView.Items.Count = 0 Then
            Return
        End If

        For Each i As ListViewItem In StackView.Items
            add(New unit(i))
        Next

        SetNewUnit()
    End Sub

    Private Sub SetNewUnit()
        If _IsAttacking = True Then
            currentUnit = MaxAttackUnit()
        Else
            currentUnit = MaxDefenseUnit()
        End If
    End Sub

    Public Sub PrintStats(ByRef txtbox As RichTextBox, ByVal _loop As Integer, ByVal avgattDef As Boolean, ByVal avgUnitAlive As Boolean)

        txtbox.AppendText(vbCrLf & vbCrLf & "Stack " + ID.ToString)

        If (isAttacking()) Then
            txtbox.AppendText("(attacking):")
        Else
            txtbox.AppendText("(defending):")
        End If
        txtbox.AppendText(vbCrLf & "Wins: " + stat.GetVictories.ToString)
        txtbox.AppendText(vbCrLf & "(%): " + (100 * stat.GetVictories / _loop).ToString)

        If (avgattDef) Then
            txtbox.AppendText(vbCrLf & "Avg.Att: " + Format(stat.GetAvgAtt, "0.00"))
            txtbox.AppendText(vbCrLf & "Avg.Def: " + Format(stat.GetAvgDef, "0.00"))
        End If

        If (avgUnitAlive) Then
            txtbox.AppendText(vbCrLf & "Avg. units alive " + Format(stat.GetAvgUnitsAlive(_loop), "0.00"))
        End If
    End Sub

    Public Shared Function GetValue(ByVal s As String) As Integer

        Dim val As String = ""
        Dim i As Integer = 0

        While ((i < s.Count) AndAlso (Char.IsNumber(s(i)) Or s(i) = "-"))
            val += s(i)
            i += 1
        End While
        Return val
    End Function

    Public Function GetStackUnits() As ListView.ListViewItemCollection
        Return StackView.Items
    End Function

    'Methods used by the class objects and load

    Private Sub Stack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnitCount = 0
        inCity = True
        inDefensiveLine = False


        OriginalStack = New List(Of ListViewItem)
        units = New List(Of unit)
        stat = New Statistic()

        GDefense = True
        GMilitiaHP = True
        GInfantryA = True
        GTankA = True
        GBomberA = True
        GLucky = True

        StrongAA = True
        SaferTrans = True
        LuckyTank = True
        LuckyMil = True
        LuckyMar = True
        LuckyInf = True
        Bonus.Enabled = False

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        If (Delete.Text = "Remove") Then
            For Each i As ListViewItem In StackView.Items
                If (i.Selected) Then
                    StackView.Items.Remove(i)
                End If
            Next
            StackView_SelectedIndexChanged(Nothing, Nothing)
        Else
            StackView.Items.Clear()
            RemoveAll()
        End If

    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        Dim custom As CustomizeStack = New CustomizeStack()
        custom.stack = Me
        custom.ShowDialog()
    End Sub

    Private Sub Status_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Status.SelectionChangeCommitted

        Dim active As Boolean = Not (Status.SelectedIndex = 0)

        StackView.Enabled = active
        Delete.Enabled = active
        Strategy.Enabled = active
        Config.Enabled = active

        If Not (active) Then
            RemoveAll()
            StackView.Items.Clear()
        End If

        If (Status.SelectedIndex = 2) Then
            _IsAttacking = False
            defender = True
        Else
            _IsAttacking = True
            defender = False

        End If

    End Sub

    Private Sub Strategy_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Strategy.SelectionChangeCommitted
        addModifiers()
    End Sub

    Public Sub UpdateState()
        Status_SelectionChangeCommitted(Nothing, Nothing)
        StackGroup.Text = "Stack " + ID.ToString
    End Sub

    Private Sub StackView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StackView.SelectedIndexChanged
        Dim bol As Boolean = False

        For Each i As ListViewItem In StackView.Items
            If (i.Selected) Then
                bol = True
            End If
        Next
        If (bol) Then
            Delete.Text = "Remove"
        Else
            Delete.Text = "Clear"
        End If

        Bonus.Enabled = bol
    End Sub

    Private Sub Bonus_Click(sender As Object, e As EventArgs) Handles Bonus.Click
        For Each i As ListViewItem In StackView.Items
            If (i.Selected) Then
                Dim go As ShowBonuses = New ShowBonuses()
                go.X = i
                go.Show()
                go.loadlist()
            End If
        Next
    End Sub


    'Status

    Public Function IsDead() As Boolean
        Return _IsDead
    End Function

    Public Function isAttacking() As Boolean
        Return _IsAttacking
    End Function

    Public Function isDefender() As Boolean
        Return defender
    End Function

    Public Sub SetStatus(ByVal _status As Boolean)
        _IsAttacking = _status
    End Sub

    Public Sub changeStatus()
        _IsAttacking = Not _IsAttacking

    End Sub

    Public Sub True_Defender(ByVal _defender As Boolean)
        defender = _defender
    End Sub

    Public Function IsActive() As Boolean
        If (Not Status.SelectedIndex.Equals(0)) Then
            Return True
        End If
        Return False
    End Function

    Public Function ableToFight() As Boolean
        If (StackView.Items.Count > 0) Then
            Return True
        End If
        Return False
    End Function

    'Add troops

    Private Sub add(NewUnit As unit)

        Select Case Strategy.Text
            Case "Perfect Defense"
                If (NewUnit.type.Equals("Infantry")) Then
                    NewUnit.addBonuses("Tanks", 1)
                End If

            Case "Desert Storm"
                If (NewUnit.type.Equals("Helicopters")) Then
                    NewUnit.addBonuses("Stealth", 1)
                End If
        End Select


        NewUnit.SetIndex(units.Count())
        units.Add(NewUnit)
        UnitCount += 1


    End Sub

    Public Sub add(ByVal _unit As ListViewItem)
        OriginalStack.Add(_unit)

        If (_unit.SubItems.Item(0).Text.Equals("General") And Not General) Then
            General = True
        End If
        If (General) Then
            StackView.Items.Add(StrategiesModifiers(GeneralModifiers(UpgradeModifiers(_unit.Clone))))
        Else
            StackView.Items.Add(StrategiesModifiers(UpgradeModifiers(_unit.Clone)))
        End If
        addModifiers()

    End Sub

    'Battle Methods

    Public Function GetRoll(ByVal multiplier As Integer, ByVal rand As Random) As Integer
        SetNewUnit()
        Dim roll As Integer = currentUnit.GetRoll(isAttacking, multiplier, rand)
        If (_IsAttacking) Then
            stat.AddAttackRoll(roll)
        Else
            stat.AddDefenseRoll(roll)
        End If

        stat.NextWave()

        Return roll
    End Function

    Private Function MaxAttackUnit() As unit
        Dim i As Integer = 0

        While ((units.Item(i) Is Nothing) Or units.Item(i).IsDead())
            i += 1
        End While

        Dim _unit As unit = units.Item(i)
        If (UnitCount > 1) Then
            For Each item In units

                If (Not item.IsDead() And (_unit.GetAttack() < item.GetAttack())) Then
                    _unit = item
                End If
            Next
        End If
        Return _unit
    End Function

    Private Function MaxDefenseUnit() As unit
        Dim i As Integer = 0

        While ((units.Item(i) Is Nothing) Or units.Item(i).IsDead())
            i += 1
        End While

        Dim _unit As unit = units.Item(i)
        If (UnitCount > 1) Then
            For Each item In units

                If (Not item.IsDead() And (_unit.GetDefense() < item.GetDefense())) Then
                    _unit = item
                End If

            Next
        End If
        Return _unit
    End Function

    Public Function getBonus() As Integer
        Dim bonus As Integer = 0

        If (isAttacking()) Then
            For Each item In units
                If (Not item.IsDead()) Then
                    bonus += item.GetAttackBonus()
                End If
            Next
        Else
            For Each item In units
                If (Not item.IsDead()) Then
                    bonus += item.GetDefenseBonus()
                End If
            Next
        End If

        Return bonus
    End Function

    Public Sub Damaged(ByRef damage)
        currentUnit.Damaged(damage)

        While currentUnit.IsDead()
            UnitCount -= 1
            If (UnitCount = 0) Then
                _IsDead = True
                Return
            Else
                SetNewUnit()
            End If

            currentUnit.Damaged(damage)
        End While
    End Sub

    Public Sub BattleOver()
        'Set stats

        If Not (_IsDead) Then
            stat.Victory()
        End If

        stat.AddUnitsAlive(UnitCount)

        'Restore the stack

        For Each item In units
            item.restore()
        Next

        _IsDead = False
        UnitCount = units.Count()
        _IsAttacking = Not defender
    End Sub

    Public Sub SetDefensiveBonus(ByVal enemy As String)
        currentUnit.SetDefensiveBonus(enemy)
    End Sub

    Public Function CurrentUnitType()
        Return currentUnit.type
    End Function

    'Modifiers

    Public Sub addModifiers()
        StackView.Items.Clear()
        If Not (OriginalStack.Count().Equals(0)) Then
            For Each item As ListViewItem In OriginalStack
                If (General) Then
                    StackView.Items.Add(StrategiesModifiers(GeneralModifiers(UpgradeModifiers(item.Clone))))
                Else
                    StackView.Items.Add(StrategiesModifiers(UpgradeModifiers(item.Clone)))
                End If
            Next
            UpdateDifferenceModifiers()
        End If
    End Sub

    Private Function GeneralModifiers(ByRef _unit As ListViewItem) As ListViewItem
        'ALL GEN UPGRADES'
        If (GDefense) Then
            _unit.SubItems.Item(2).Text = _unit.SubItems.Item(2).Text(0).ToString + 1 'Defense'
        End If

        If (GLucky) Then
            _unit.SubItems.Item(3).Text =
                           (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
        End If


        Select Case _unit.SubItems.Item(0).Text

            Case "Militia"
                If (GMilitiaHP) Then
                    _unit.SubItems.Item(4).Text = _unit.SubItems.Item(4).Text(0).ToString + 1 'HP'
                End If


            Case "Infantry"
                If (GInfantryA) Then
                    _unit.SubItems.Item(1).Text = _unit.SubItems.Item(1).Text(0).ToString + 1 'Attack'
                End If

            Case "Tanks"
                If (GTankA) Then
                    _unit.SubItems.Item(1).Text = _unit.SubItems.Item(1).Text(0).ToString + 1 'Attack'
                End If

            Case "Bombers"
                If (GBomberA) Then
                    _unit.SubItems.Item(1).Text = _unit.SubItems.Item(1).Text(0).ToString + 1 'Attack'
                End If
            Case Else 'Nothing'
        End Select

        Return _unit
    End Function

    Private Function UpgradeModifiers(ByRef _unit As ListViewItem) As ListViewItem
        'ALL UPGRADES'
        '+1 def antiaircraft
        '+1 crit tank
        '+3 HP transports

        '+2 crit militia
        '+2 crit marines
        '+2 crit Infantries

        Select Case _unit.SubItems.Item(0).Text
            Case "Militia"
                If (LuckyMil) Then
                    _unit.SubItems.Item(3).Text =
            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                End If

            Case "Marines"
                If (LuckyMar) Then
                    _unit.SubItems.Item(3).Text =
            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                End If

            Case "Infantry"
                If (LuckyInf) Then
                    _unit.SubItems.Item(3).Text =
            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                End If

            Case "Tanks"
                If (LuckyTank) Then
                    _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 1).ToString + "%" 'Critical
                End If


            Case "Anti-aircraft"
                If (StrongAA) Then
                    _unit.SubItems.Item(2).Text += 1 'Defense'
                End If


            Case "Air Transport", "Sea Transport"
                If (SaferTrans) Then
                    _unit.SubItems.Item(4).Text += 3 'HP'
                End If
            Case Else 'Nothing'
        End Select
        Return _unit

    End Function

    Private Function StrategiesModifiers(ByVal _unit As ListViewItem) As ListViewItem
        Select Case Strategy.Text

            Case "None" 'Nothing'
            'Item(0) 'Type/Name'
            'Item(1) 'attack'
            'Item(2) 'defense'
            'Item(3) 'Critical'
            'Item(4) 'HP'
            'Item(5) 'Count'
            'Item(6) 'Bonuses"

            Case "Blitzkrieg"
                _unit.SubItems.Item(2).Text -= 1 'Defense'

                If (_unit.SubItems.Item(0).Text.Equals("Infantry")) Then
                    _unit.SubItems.Add("-1,InCity") 'Defense Nerf in-city'
                End If

            Case "Desert Storm"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Militia"
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                    Case "Infantry", "Tanks"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                    Case "Bombers"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                    Case "Helicopters"
                        _unit.SubItems.Item(1).Text += 2 'Attack'
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                    Case Else 'Nothing'
                End Select

            Case "Great Combinator"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Infantry"
                        _unit.SubItems.Item(1).Text -= 2 'Attack'
                        _unit.SubItems.Item(4).Text += 1 'HP'
                    Case "Tanks"
                        _unit.SubItems.Item(2).Text -= 2 'Defense'
                        _unit.SubItems.Item(4).Text += 1 'HP'
                    Case Else 'Nothing'
                End Select

            Case "Guerrilla Warfare"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Militia"
                        _unit.SubItems.Item(1).Text += 1 'Attack'
                        _unit.SubItems.Item(2).Text += 1 'Defense'

                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                        _unit.SubItems.Add("1,InCity") 'Defense Boost in-city'
                        _unit.SubItems.Add("1,DefensiveLine") 'Defense Boost in DefensiveLine'

                    Case "Infantry", "Tanks"
                        _unit.SubItems.Item(1).Text -= 2 'Attack'
                        _unit.SubItems.Item(2).Text -= 2 'Defense'
                    Case Else 'Nothing'
                End Select

            Case "Hybrid Warfare"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Militia"
                        _unit.SubItems.Item(1).Text += 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                    Case "Infantry"
                        _unit.SubItems.Item(1).Text -= 3 'Attack'
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                    Case "Tanks"
                        _unit.SubItems.Item(1).Text += 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 3 'Defense'
                    Case "Submarine", "Bombers", "Stealth"
                        _unit.SubItems.Item(1).Text -= 2 'Attack'
                        _unit.SubItems.Item(2).Text -= 2 'Defense'
                    Case "Marines"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                        _unit.SubItems.Add("-1,InCity") 'Defense Nerf in-city'
                        _unit.SubItems.Add(-"1,DefensiveLine") 'Defense Nerf in DefensiveLine'
                    Case Else 'Nothing'
                End Select

            Case "Imperialist"
                _unit.SubItems.Item(1).Text -= 1 'Attack'

                If (_unit.SubItems.Item(0).Text.Equals("Militia")) Then
                    _unit.SubItems.Add("1,InCity") 'Defense Boost in-city'
                    _unit.SubItems.Add("1,DefensiveLine") 'Defense Boost in DefensiveLine'
                End If

            Case "Iron Fist"
                _unit.SubItems.Item(4).Text += 2 'HP'

            Case "Lucky Bastard"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Militia", "Infantry", "Marines"
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 10).ToString + "%" 'Critical'
                    Case Else
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 12).ToString + "%" 'Critical'
                End Select


            Case "Master of Stealth"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Tanks", "Destroyer"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                    Case "Marines"
                        _unit.SubItems.Item(1).Text += 1 'Attack'
                    Case "Submarine"
                        _unit.SubItems.Item(1).Text += 2 'Attack'
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case "Stealth"
                        _unit.SubItems.Item(1).Text += 2 'Attack'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case Else 'Nothing'
                End Select

            Case "Naval Commander"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Tanks"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) - 2).ToString + "%" 'Critical'
                    Case "Submarine", "Destroyer"
                        _unit.SubItems.Item(1).Text += 2 'Attack'
                        _unit.SubItems.Item(2).Text += 2 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case "Sea Transport"
                        _unit.SubItems.Item(2).Text += 2 'Defense'
                    Case Else 'Nothing'
                End Select

            Case "Perfect Defense"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Tanks", "Destroyer", "Bombers"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) - 2).ToString + "%" 'Critical'
                    Case "Militia"
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case "Infantry"
                        _unit.SubItems.Item(2).Text += 1 'Defense'
                        _unit.SubItems.Add("1,Tanks") 'Defense Boost against Tanks'
                    Case Else 'Nothing'
                End Select

            Case "Relentless Attack"
                Select Case _unit.SubItems.Item(0).Text
                    Case "Infantry"
                        _unit.SubItems.Item(2).Text -= 1 'Defense Nerf InCity'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) - 2).ToString + "%" 'Critical'

                        _unit.SubItems.Add("-1,InCity") 'Defense Boost in-city'
                        _unit.SubItems.Add("-1,DefensiveLine") 'Defense Boost in DefensiveLine'


                    Case "Tanks"
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'

                    Case "Bombers"
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                    Case Else 'Nothing'
                End Select

            Case "Sky Menace"

                Select Case _unit.SubItems.Item(0).Text
                    Case "Infantry"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) - 2).ToString + "%" 'Critical'

                    Case "Tanks"
                        _unit.SubItems.Item(1).Text -= 1 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) - 2).ToString + "%" 'Critical'

                    Case "Bombers"
                        _unit.SubItems.Item(1).Text += 2 'Attack'
                        _unit.SubItems.Item(2).Text -= 1 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case "Stealth"
                        _unit.SubItems.Item(1).Text += 2 'Attack'

                    Case "Air Transport"
                        _unit.SubItems.Item(1).Text += 1 'Attack'
                        _unit.SubItems.Item(2).Text += 2 'Defense'
                        _unit.SubItems.Item(3).Text =
                            (_unit.SubItems.Item(3).Text.Substring(0, _unit.SubItems.Item(3).Text.Length - 1) + 2).ToString + "%" 'Critical'
                    Case Else 'Nothing'
                End Select
        End Select

        Return _unit
    End Function

    Private Sub UpdateDifferenceModifiers()

        'Item(0) 'Type/Name'
        'Item(1) 'attack'
        'Item(2) 'defense'
        'Item(3) 'Critical'
        'Item(4) 'HP'
        'Item(5) 'Count'
        'Item(6) 'Bonuses'




        For i As Integer = 0 To StackView.Items.Count - 1
            For j As Integer = 1 To 4
                Dim original As Integer = GetValue(OriginalStack.Item(i).SubItems.Item(j).Text())
                Dim modified As Integer = GetValue(StackView.Items.Item(i).SubItems(j).Text())

                Dim diff As Integer = modified - original
                If Not (diff = 0) Then
                    Dim s As String = modified.ToString()
                    If (j = 3) Then
                        s += "%"
                    End If
                    s += " ("
                    If (diff > 0) Then
                        s += "+ " + diff.ToString
                    Else
                        s += diff.ToString
                    End If
                    s += ")"

                    StackView.Items.Item(i).SubItems(j).Text() = s
                End If
            Next
        Next

    End Sub

    'Clear'

    Public Sub RemoveAll()
        If Not (units Is Nothing) Then
            units.Clear()
            UnitCount = 0
        End If
        StackView.Items.Clear()
        OriginalStack.Clear()
        General = False

    End Sub

    'FINISH

End Class