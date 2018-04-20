Public Class customerOrSeller
    Private Sub customer_Click(sender As Object, e As EventArgs) Handles customer.Click
        Form3.Show()
    End Sub

    Private Sub seller_Click(sender As Object, e As EventArgs) Handles seller.Click
        LoginFormForSeller.Show()
    End Sub
End Class