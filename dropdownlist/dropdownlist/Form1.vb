Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = TextBox1.Text
        ListBox1.Items.Add(a)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As String

        ListBox1.Items.RemoveAt(a)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub
End Class
