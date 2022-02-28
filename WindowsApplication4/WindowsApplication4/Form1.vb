Public Class Form1

    Sub MySub()
        Dim a, b, c As Integer
        a = 10
        b = 20
        c = a + b
        MsgBox(c)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = TextBox3.Text
        b = TextBox2.Text
        c = a + b
        TextBox1.Text = c
        MySub()
    End Sub
    Function hello()
        Dim a, b As Integer
        a = 10
        b = 20
        Return a + b
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox(hello())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("hello world", "msgbox", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim name As String
        name = InputBox("ente the name", "ssw")
        MsgBox(name)
    End Sub
End Class
