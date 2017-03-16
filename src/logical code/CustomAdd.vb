Public Class CustomAdd
    Dim ID As Integer

    Public Sub setId(ByVal _id As Integer)
        ID = _id
    End Sub
    Public Function getId()
        Return ID
    End Function

    Private Sub cancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Add_custom_Click(sender As Object, e As EventArgs) Handles Add_custom.Click
        Add.setId(0)
        Add.ShowDialog()

    End Sub

    Private Sub CustomAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Type.SelectedIndex = 0
    End Sub
End Class