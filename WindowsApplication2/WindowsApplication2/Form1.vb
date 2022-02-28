Public Class Form1
  
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val1, val2 As Integer
        val1 = TextBox1.Text
        val2 = TextBox2.Text
        TextBox3.Text = val1 + val2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim val1, val2 As Integer
        val1 = TextBox1.Text
        val2 = TextBox2.Text
        TextBox3.Text = val1 - val2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim val1, val2 As Integer
        val1 = TextBox1.Text
        val2 = TextBox2.Text
        TextBox3.Text = val1 * val2
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim val1, val2 As Double
        val1 = TextBox1.Text
        val2 = TextBox2.Text
        TextBox3.Text = val1 / val2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim val1 As Double
        Dim val2 As Integer
        val1 = TextBox4.Text
        val2 = val1
        TextBox5.Text = val2
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a(2) As Integer
        a(0) = 10
        a(1) = 20
        ListBox1.Items.Add(a(0))
        ListBox1.Items.Add(a(1))
    End Sub
End Class
