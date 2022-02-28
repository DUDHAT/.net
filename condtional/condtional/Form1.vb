Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a, b As Integer
        For a = 1 To 5 Step 1

            For b = 1 To 5 Step 1
                If b <= a Then
                    ListBox1.Items.Add("*")
                End If

            Next
        Next
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then
            Label1.Text = "you are pass"

        ElseIf RadioButton2.Checked Then
            Label1.Text = "you are fail"

        Else
            Label1.Text = "you are akty"
        End If
    End Sub
End Class
