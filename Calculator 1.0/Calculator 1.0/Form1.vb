Public Class Form1

    Public num1 As Integer
    Public num2 As Integer
    Public sum As Integer
    Public diff As Integer
    Public qoutient As Double
    Public product As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        sum = num1 + num2
        TextBox3.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = TextBox1.Text - TextBox2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        product = num1 * num2
        TextBox3.Text = product

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub
End Class
