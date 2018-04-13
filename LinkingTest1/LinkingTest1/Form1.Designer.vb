<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet11 = New LinkingTest1.DataSet1()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT student.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     student"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\testdata.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `student` (`SName`, `SNo`) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SName", System.Data.OleDb.OleDbType.VarWChar, 0, "SName"), New System.Data.OleDb.OleDbParameter("SNo", System.Data.OleDb.OleDbType.[Integer], 0, "SNo")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE `student` SET `SName` = ?, `SNo` = ? WHERE (((? = 1 AND `SName` IS NULL) O" &
    "R (`SName` = ?)) AND (`SNo` = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("SName", System.Data.OleDb.OleDbType.VarWChar, 0, "SName"), New System.Data.OleDb.OleDbParameter("SNo", System.Data.OleDb.OleDbType.[Integer], 0, "SNo"), New System.Data.OleDb.OleDbParameter("IsNull_SName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SNo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SNo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM `student` WHERE (((? = 1 AND `SName` IS NULL) OR (`SName` = ?)) AND (" &
    "`SNo` = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("IsNull_SName", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SName", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_SName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_SNo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SNo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "student", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SName", "SName"), New System.Data.Common.DataColumnMapping("SNo", "SNo")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.DataSource = Me.StudentBindingSource
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(12, 12)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(288, 208)
        Me.DataGrid1.TabIndex = 0
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.DataSet11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(336, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 594)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents DataGrid1 As DataGrid
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents Button1 As Button
End Class
