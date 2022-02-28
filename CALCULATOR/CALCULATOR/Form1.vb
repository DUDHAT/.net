Public Class Form1
    Dim VAL1, VAL2 As Integer
    Dim sign As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        VAL1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "+"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        VAL1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "-"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        VAL1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "*"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        VAL1 = TextBox1.Text
        TextBox1.Clear()
        TextBox1.Focus()
        sign = "/"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        VAL2 = TextBox1.Text
        If sign = "+" Then
            TextBox1.Text = VAL1 + VAL2
        ElseIf sign = "-" Then
            TextBox1.Text = VAL1 - VAL2
        ElseIf sign = "*" Then
            TextBox1.Text = VAL1 * VAL2
        ElseIf sign = "/" Then
            TextBox1.Text = VAL1 / VAL2
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
