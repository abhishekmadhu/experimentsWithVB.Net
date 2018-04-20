Public Class customerAddIssue
    Private Sub CustomerList1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerList1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerList1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersVer3DataSet)

    End Sub

    Private Sub customerAddIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersVer3DataSet.customerList1' table. You can move, or remove it, as needed.
        Me.CustomerList1TableAdapter.Fill(Me.CustomersVer3DataSet.customerList1)
    End Sub
End Class