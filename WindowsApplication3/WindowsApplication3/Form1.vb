Public Class Form1

    Sub Form1_Load()
        Dim a, b, c As Integer
        a = 20
        b = 20
        c = 30
        MsgBox(c + a + b)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1_Load()
    End Sub
End Class
