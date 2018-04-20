<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportIssue
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
        Dim IssueLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportIssue))
        Me.CID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Issue = New System.Windows.Forms.TextBox()
        Me.Contact = New System.Windows.Forms.TextBox()
        Me.ProID = New System.Windows.Forms.TextBox()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomersVer3DataSet1 = New updateDB.customersVer3DataSet()
        IssueLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersVer3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IssueLabel
        '
        IssueLabel.AutoSize = True
        IssueLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IssueLabel.Location = New System.Drawing.Point(84, 225)
        IssueLabel.Name = "IssueLabel"
        IssueLabel.Size = New System.Drawing.Size(65, 22)
        IssueLabel.TabIndex = 15
        IssueLabel.Text = "Issue:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(84, 174)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(145, 22)
        CategoryLabel.TabIndex = 25
        CategoryLabel.Text = "ContactNumber"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.Location = New System.Drawing.Point(84, 130)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(110, 22)
        ProductIDLabel.TabIndex = 26
        ProductIDLabel.Text = "Product ID:"
        '
        'CID
        '
        Me.CID.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CID.Location = New System.Drawing.Point(303, 80)
        Me.CID.Name = "CID"
        Me.CID.Size = New System.Drawing.Size(361, 28)
        Me.CID.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Enter Your Customer ID"
        '
        'Issue
        '
        Me.Issue.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Issue.Location = New System.Drawing.Point(303, 227)
        Me.Issue.Multiline = True
        Me.Issue.Name = "Issue"
        Me.Issue.Size = New System.Drawing.Size(361, 26)
        Me.Issue.TabIndex = 20
        '
        'Contact
        '
        Me.Contact.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.Location = New System.Drawing.Point(303, 176)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(361, 28)
        Me.Contact.TabIndex = 29
        '
        'ProID
        '
        Me.ProID.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProID.Location = New System.Drawing.Point(303, 132)
        Me.ProID.Name = "ProID"
        Me.ProID.Size = New System.Drawing.Size(361, 28)
        Me.ProID.TabIndex = 33
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT issueList1.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     issueList1"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\customersVer3.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `issueList1` (`CustomerID`, `ProductID`, `ContactNumber`, `Issue`) VA" &
    "LUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 0, "CustomerID"), New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.VarWChar, 0, "ProductID"), New System.Data.OleDb.OleDbParameter("ContactNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "ContactNumber"), New System.Data.OleDb.OleDbParameter("Issue", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Issue")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 0, "CustomerID"), New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.VarWChar, 0, "ProductID"), New System.Data.OleDb.OleDbParameter("ContactNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "ContactNumber"), New System.Data.OleDb.OleDbParameter("Issue", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Issue"), New System.Data.OleDb.OleDbParameter("Original_SerialNumber", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CustomerID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ProductID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ContactNumber", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ContactNumber", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SerialNumber", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SerialNumber", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_CustomerID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ProductID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ProductID", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_ContactNumber", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ContactNumber", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactNumber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "issueList1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SerialNumber", "SerialNumber"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ContactNumber", "ContactNumber"), New System.Data.Common.DataColumnMapping("Issue", "Issue")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(517, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 64)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomersVer3DataSet1
        '
        Me.CustomersVer3DataSet1.DataSetName = "customersVer3DataSet"
        Me.CustomersVer3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'reportIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 700)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Contact)
        Me.Controls.Add(Me.ProID)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.Issue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CID)
        Me.Controls.Add(IssueLabel)
        Me.Name = "reportIssue"
        Me.Text = "reportIssue"
        CType(Me.CustomersVer3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Issue As TextBox
    Friend WithEvents Contact As TextBox
    Friend WithEvents ProID As TextBox
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents Button1 As Button
    Friend WithEvents CustomersVer3DataSet1 As customersVer3DataSet

End Class
