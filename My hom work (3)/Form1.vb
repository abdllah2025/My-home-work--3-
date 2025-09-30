Public Class Form1
    Public x, y As Integer

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (x + y).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (x - y).ToString
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = (x * y).ToString
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = (x / y).ToString
        End If

    End Sub
End Class
