<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim Date_SoldLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim IssueLabel As System.Windows.Forms.Label
        Me.CustomersVer3DataSet = New updateDB.customersVer3DataSet()
        Me.CustomerList1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerList1TableAdapter = New updateDB.customersVer3DataSetTableAdapters.customerList1TableAdapter()
        Me.TableAdapterManager = New updateDB.customersVer3DataSetTableAdapters.TableAdapterManager()
        Me.CustomerList1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerList1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Date_SoldDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.IssueTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        Date_SoldLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        IssueLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersVer3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerList1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerList1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerList1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomersVer3DataSet
        '
        Me.CustomersVer3DataSet.DataSetName = "customersVer3DataSet"
        Me.CustomersVer3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerList1BindingSource
        '
        Me.CustomerList1BindingSource.DataMember = "customerList1"
        Me.CustomerList1BindingSource.DataSource = Me.CustomersVer3DataSet
        '
        'CustomerList1TableAdapter
        '
        Me.CustomerList1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerList1TableAdapter = Me.CustomerList1TableAdapter
        Me.TableAdapterManager.UpdateOrder = updateDB.customersVer3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerList1BindingNavigator
        '
        Me.CustomerList1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerList1BindingNavigator.BindingSource = Me.CustomerList1BindingSource
        Me.CustomerList1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerList1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerList1BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerList1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerList1BindingNavigatorSaveItem})
        Me.CustomerList1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerList1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerList1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerList1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerList1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerList1BindingNavigator.Name = "CustomerList1BindingNavigator"
        Me.CustomerList1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerList1BindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.CustomerList1BindingNavigator.TabIndex = 0
        Me.CustomerList1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerList1BindingNavigatorSaveItem
        '
        Me.CustomerList1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerList1BindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerList1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerList1BindingNavigatorSaveItem.Name = "CustomerList1BindingNavigatorSaveItem"
        Me.CustomerList1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustomerList1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(24, 57)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(119, 54)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(236, 22)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(24, 85)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(119, 82)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(236, 22)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(24, 113)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 17)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(119, 110)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(236, 22)
        Me.LastNameTextBox.TabIndex = 6
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(24, 141)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(69, 17)
        CategoryLabel.TabIndex = 7
        CategoryLabel.Text = "Category:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(24, 169)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(78, 17)
        ProductIDLabel.TabIndex = 9
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(119, 166)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(236, 22)
        Me.ProductIDTextBox.TabIndex = 10
        '
        'Date_SoldLabel
        '
        Date_SoldLabel.AutoSize = True
        Date_SoldLabel.Location = New System.Drawing.Point(24, 198)
        Date_SoldLabel.Name = "Date_SoldLabel"
        Date_SoldLabel.Size = New System.Drawing.Size(74, 17)
        Date_SoldLabel.TabIndex = 11
        Date_SoldLabel.Text = "Date Sold:"
        '
        'Date_SoldDateTimePicker
        '
        Me.Date_SoldDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerList1BindingSource, "Date Sold", True))
        Me.Date_SoldDateTimePicker.Location = New System.Drawing.Point(119, 194)
        Me.Date_SoldDateTimePicker.Name = "Date_SoldDateTimePicker"
        Me.Date_SoldDateTimePicker.Size = New System.Drawing.Size(236, 22)
        Me.Date_SoldDateTimePicker.TabIndex = 12
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(24, 225)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 13
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(119, 222)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(236, 22)
        Me.AddressTextBox.TabIndex = 14
        '
        'IssueLabel
        '
        IssueLabel.AutoSize = True
        IssueLabel.Location = New System.Drawing.Point(24, 253)
        IssueLabel.Name = "IssueLabel"
        IssueLabel.Size = New System.Drawing.Size(45, 17)
        IssueLabel.TabIndex = 15
        IssueLabel.Text = "Issue:"
        '
        'IssueTextBox
        '
        Me.IssueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerList1BindingSource, "Issue", True))
        Me.IssueTextBox.Location = New System.Drawing.Point(119, 250)
        Me.IssueTextBox.Name = "IssueTextBox"
        Me.IssueTextBox.Size = New System.Drawing.Size(236, 22)
        Me.IssueTextBox.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CustomerList1BindingSource
        Me.ComboBox1.DisplayMember = "Category"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(119, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 24)
        Me.ComboBox1.TabIndex = 17
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Date_SoldLabel)
        Me.Controls.Add(Me.Date_SoldDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(IssueLabel)
        Me.Controls.Add(Me.IssueTextBox)
        Me.Controls.Add(Me.CustomerList1BindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Seller | Add Customer"
        CType(Me.CustomersVer3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerList1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerList1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerList1BindingNavigator.ResumeLayout(False)
        Me.CustomerList1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomersVer3DataSet As customersVer3DataSet
    Friend WithEvents CustomerList1BindingSource As BindingSource
    Friend WithEvents CustomerList1TableAdapter As customersVer3DataSetTableAdapters.customerList1TableAdapter
    Friend WithEvents TableAdapterManager As customersVer3DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerList1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerList1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Date_SoldDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents IssueTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
