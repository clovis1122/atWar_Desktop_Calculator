Public Class ShowBonuses

    Public X As ListViewItem

    Private Sub ShowBonuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Selected unit: " + X.SubItems(0).Text
    End Sub

    Public Sub loadlist()
        For i As Integer = 7 To X.SubItems.Count - 1
            Dim a As ListViewItem = New ListViewItem
            a.SubItems(0).Text = X.SubItems(i).Text.Substring(X.SubItems(i).Text.IndexOf(",") + 1)
            a.SubItems.Add(Stack.GetValue(X.SubItems(i).Text))
            ListView1.Items.Add(a)
        Next
    End Sub
End Class