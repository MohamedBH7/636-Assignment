Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim num1 As Double = Double.Parse(TextBox1.Text)
            Dim num2 As Double = Double.Parse(TextBox2.Text)
            Dim addition As Double = num1 + num2
            Dim subtraction As Double = num1 - num2
            Dim multiplication As Double = num1 * num2

            If num2 = 0 Then
                Label6.Text = "Error: Division by zero is not allowed."
            Else
                Dim division As Double = num1 / num2

                Label6.Text = $"The division ({num1} / {num2}) = {division.ToString()}"
            End If

            Label3.Text = $"The addition of({num1} + {num2}) = {addition.ToString()}"
            Label4.Text = $"The subtraction({num1} - {num2}) = {subtraction.ToString()}"
            Label5.Text = $"The multiplication({num1} * {num2}) = {multiplication.ToString()}"

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
    End Sub
End Class
