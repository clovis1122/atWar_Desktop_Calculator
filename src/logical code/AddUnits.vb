Public Class AddUnits

    Private Sub AddUnits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddTroop_Click(sender As Object, e As EventArgs) Handles AddTroop.Click
        Dim i = 1
        For Each item As ListViewItem In ListView1.Items
            If (item.Checked) Then
                Add.setId(i)
                Add.ShowDialog()
            End If
            i += 1
        Next
    End Sub

    Private Sub CustomTroop_Click(sender As Object, e As EventArgs) Handles CustomTroop.Click
        CustomAdd.ShowDialog()
    End Sub
End Class
