Public Class Simulator

    Public Shared avgAttDef As Boolean
    Public Shared avgUnitsAlive As Boolean
    Public Shared append As Boolean
    Private NumberOfBattles As Integer

    Class Battle
        Public Sub Battle_Step_0(ByVal army1 As Stack, ByVal army2 As Stack, ByVal army3 As Stack, ByVal army4 As Stack, ByRef rand As System.Random)
            Dim stacks As List(Of Stack) = New List(Of Stack)

            If (army1.IsActive) Then
                stacks.Add(army1)
            End If

            If (army2.IsActive) Then
                stacks.Add(army2)
            End If

            If (army3.IsActive) Then
                stacks.Add(army3)
            End If

            If (army4.IsActive) Then
                stacks.Add(army4)
            End If

            Dim ArmiesAlive As Integer = stacks.Count

            While (ArmiesAlive > 1)
                If (ArmiesAlive = 2) Then
                    'Get the remaning two armies
                    Dim ra As Integer = rand.Next(2)
                    Dim RandomArmy As Stack = stacks(ra)
                    Dim RandomArmyEnemy As Stack = stacks((ra + 1) Mod 2)
                    Battle_Step_1(RandomArmy, RandomArmyEnemy, rand)
                Else
                    Dim RandomArmy As Stack = stacks(rand.Next(stacks.Count))
                    Dim RandomArmyEnemy = stacks(rand.Next(stacks.Count))
                    While RandomArmyEnemy.Equals(RandomArmy)
                        RandomArmyEnemy = stacks(rand.Next(stacks.Count))
                    End While
                    Battle_Step_1(RandomArmy, RandomArmyEnemy, rand)
                End If

                Dim i As Integer = 0
                While i < stacks.Count
                    If stacks(i).IsDead() Then
                        stacks.RemoveAt(i)
                        ArmiesAlive -= 1
                    Else
                        i += 1
                    End If
                End While
            End While

            If (army1.IsActive) Then
                army1.BattleOver()
            End If

            If (army2.IsActive) Then
                army2.BattleOver()
            End If
            If (army3.IsActive) Then
                army3.BattleOver()
            End If
            If (army4.IsActive) Then
                army4.BattleOver()
            End If
        End Sub

        Private Sub Battle_Step_1(ByRef army1 As Stack, ByRef army2 As Stack, ByRef rand As System.Random)
            If (army1.isDefender()) Then
                Battle_Step_2(army2, army1, rand)

            ElseIf (army2.isDefender()) Then
                Battle_Step_2(army1, army2, rand)
            Else
                Dim attacker As Boolean = (rand.Next(0, 2) > 0)
                army1.SetStatus(attacker)
                army2.SetStatus(Not attacker)
                Battle_Step_2(army1, army2, rand)
            End If
        End Sub

        Private Sub Battle_Step_2(ByRef attacker As Stack, ByRef defender As Stack, ByRef rand As System.Random)
            defender.SetDefensiveBonus(attacker.CurrentUnitType)

            Dim BSB() As Double = BattleStackingBonus(attacker.getBonus(), defender.getBonus())

            Dim attackerRoll As Integer = attacker.GetRoll(BSB(0), rand)
            Dim defenderRoll As Integer = defender.GetRoll(BSB(1), rand)
            attacker.Damaged(defenderRoll)
            If (attacker.IsDead()) Then
                Return
            End If
            defender.Damaged(attackerRoll)
            Return
        End Sub

        Private Function BattleStackingBonus(ByVal bon_att As Integer, ByVal bon_def As Integer) As Double()
            Dim attdef As Double = (bon_att / bon_def)
            Dim BSBonus() As Double = New Double(1) {}
            If (attdef > 1) Then
                BSBonus(0) = 1
                BSBonus(1) = ((1 + attdef) / (2 * attdef))
            ElseIf (attdef < 1) Then
                BSBonus(0) = ((attdef + 1) / 2)
                BSBonus(1) = 1
            Else
                BSBonus(0) = 1
                BSBonus(1) = 1
            End If

            Return BSBonus
        End Function

    End Class

    Private Sub InitializeStacks()
        For Each i As Stack In Calculator.Stacks
            i.build()
        Next
    End Sub

    Private Sub Simulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avgAttDef = True
        avgUnitsAlive = True
        append = False
        NumberOfBattles = 0
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click

        InitializeStacks()  'Initialize the group 1, 2, 3 and 4'

        Dim activeStacks As Integer = 0
        Dim ableToFight As Integer = 0
        Dim inDefensePosition As Integer = 0

        For Each i As Stack In Calculator.Stacks
            If (i.IsActive) Then
                activeStacks += 1
            End If

            If (i.ableToFight) Then
                ableToFight += 1
            End If

            If (i.isDefender) Then
                inDefensePosition += 1
            End If
        Next

        If (activeStacks < 2) Then
            MessageBox.Show("One or various stacks aren't active.", "Error!")
        ElseIf (inDefensePosition > 1) Then
            MessageBox.Show("One or various stacks are in Defense Position.", "Error!")
        ElseIf Not (activeStacks = ableToFight) Then
            MessageBox.Show("One or various stacks are active, but they have no units to fight with.", "Error!")
        Else
            beginBattle(Calculator.Stacks)
        End If
    End Sub

    Private Sub beginBattle(ByRef stacks() As Stack)
        If Not (append) Then
            Result.Clear()
            NumberOfBattles = 0
        End If
        NumberOfBattles += 1

        Result.AppendText("----Battle #" + NumberOfBattles.ToString + "----" & vbCrLf)

        Dim _loop As Integer = looper.Value
        Dim battle As Battle = New Battle()
        Dim rand As System.Random = New System.Random()

        Calculator.ProgressBar1.Value = 0
        Calculator.ProgressBar1.Maximum = _loop

        Dim timer As Stopwatch = Stopwatch.StartNew()

        For i As Integer = 1 To _loop
            battle.Battle_Step_0(stacks(0), stacks(1), stacks(2), stacks(3), rand)
            Calculator.ProgressBar1.Increment(1)
        Next

        timer.Stop()
        Result.AppendText("Elapsed: " + timer.ElapsedMilliseconds.ToString + " ms")

        For Each i As Stack In stacks
            If (i.ableToFight) Then
                i.PrintStats(Result, _loop, avgAttDef, avgUnitsAlive)
            End If
        Next
        Result.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub Config_Click(sender As Object, e As EventArgs) Handles Config.Click
        Dim config As SimuConfig = New SimuConfig()
        config.Show()
    End Sub

End Class
