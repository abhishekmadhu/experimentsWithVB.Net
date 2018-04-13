Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        OleDbDataAdapter1.Fill(DataSet11)
    End Sub
End Class
