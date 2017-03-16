Public Class CustomizeStack

    Public stack As Stack

    Private Sub CustomizeStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InCity.Checked = stack.inCity
        InDefensiveLine.Checked = stack.inDefensiveLine
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim custom As Upgrades = New Upgrades()
        Upgrades.stack = stack
        Upgrades.ShowDialog()
        Me.Close()
    End Sub

    Private Sub InCity_Click(sender As Object, e As EventArgs) Handles InCity.Click
        InDefensiveLine.Checked = False
        stack.inCity = InCity.Checked
        stack.inDefensiveLine = False
        stack.addModifiers()
    End Sub

    Private Sub InDefensiveLine_Click(sender As Object, e As EventArgs) Handles InDefensiveLine.Click
        InCity.Checked = False
        stack.inCity = False
        stack.inDefensiveLine = InDefensiveLine.Checked
        stack.addModifiers()
    End Sub

End Class