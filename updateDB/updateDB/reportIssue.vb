Imports System.Data.OleDb

Public Class reportIssue

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim custID, PID, CN, Iss, SQLstring As String
        Dim dtProperties As New DataTable()
        Dim dbDataAdapter As OleDbDataAdapter
        custID = CID.Text
        PID = ProID.Text
        CN = Contact.Text
        Iss = Issue.Text

        dbDataAdapter = New OleDbDataAdapter()
        OleDbDataAdapter1.Fill(CustomersVer3DataSet1)

        Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = customersVer3.mdb"
        SQLstring = "INSERT INTO issuesList1 (CustomerID,ProductID,ContactNumber,Issue) VALUES (" & "'" & custID & "'" & "," & "'" & PID & "'" & "," & "'" & CN & "'" & "," & "'" & Iss & "'" & ")"
        Me.OleDbDataAdapter1.Update(CustomersVer3DataSet1)



    End Sub
End Class