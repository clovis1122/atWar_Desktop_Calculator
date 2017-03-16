Public Class Calculator

    Public Stacks() As Stack

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Stacks = {Stack1, Stack2, Stack3, Stack4}

        Stacks(0).SetStatus(True)
        Stacks(0).True_Defender(False)
        Stacks(1).SetStatus(False)
        Stacks(1).True_Defender(True)

        Stacks(0).Status.SelectedIndex = 1
        Stacks(1).Status.SelectedIndex = 2
        Stacks(2).Status.SelectedIndex = 0
        Stacks(3).Status.SelectedIndex = 0

        Dim j As Integer = 1

        For Each i As Stack In Stacks
            i.Strategy.SelectedIndex = 0
            i.ID = j
            i.UpdateState()
            j = j + 1
        Next

    End Sub

End Class