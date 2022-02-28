Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        TextBox4.Text = a + b + c
        TextBox5.Text = (a + b + c) / 3
        d = TextBox5.Text
        If d >= 90 Then
            TextBox6.Text = "A"
        ElseIf d >= 80 Then
            TextBox6.Text = "B"
        ElseIf d >= 70 Then
            TextBox6.Text = "C"
        ElseIf d >= 60 Then
            TextBox6.Text = "D"
        ElseIf d >= 50 Then
            TextBox6.Text = "E"
        ElseIf d >= 35 Then
            TextBox6.Text = "f"
        Else

        End If
        If d >= 35 Then
            TextBox7.Text = "PASS"
        Else
            TextBox7.Text = "fail"

        End If

    End Sub
End Class
