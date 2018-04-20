Public Class Form3
    Private Sub CustomerList1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerList1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerList1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersVer3DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersVer3DataSet.customerList1' table. You can move, or remove it, as needed.
        Me.CustomerList1TableAdapter.Fill(Me.CustomersVer3DataSet.customerList1)

    End Sub

    Private Sub CustomerList1BindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles CustomerList1BindingNavigator.RefreshItems

    End Sub
End Class