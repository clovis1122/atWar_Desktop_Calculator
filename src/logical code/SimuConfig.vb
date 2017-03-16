Public Class SimuConfig
    Private Sub SimuConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AvgAttDef.Checked = Simulator.avgAttDef
        AvgAlive.Checked = Simulator.avgUnitsAlive
        Append.Checked = Simulator.append
    End Sub

    Private Sub AvgAttDef_CheckedChanged(sender As Object, e As EventArgs) Handles AvgAttDef.CheckedChanged
        Simulator.avgAttDef = AvgAttDef.Checked
    End Sub

    Private Sub AvgAlive_CheckedChanged(sender As Object, e As EventArgs) Handles AvgAlive.CheckedChanged
        Simulator.avgUnitsAlive = AvgAlive.Checked
    End Sub

    Private Sub Append_CheckedChanged(sender As Object, e As EventArgs) Handles Append.CheckedChanged
        Simulator.append = Append.Checked
    End Sub

End Class