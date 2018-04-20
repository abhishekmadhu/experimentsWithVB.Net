Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show() 'NON EDITABLE CUSTOMER VIEW FORM
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show() 'EDITABLE ADD CUSTOMER FORM
    End Sub
End Class
