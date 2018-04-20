<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customerOrSeller
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
        Me.customer = New System.Windows.Forms.Button()
        Me.seller = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'customer
        '
        Me.customer.Location = New System.Drawing.Point(160, 60)
        Me.customer.Name = "customer"
        Me.customer.Size = New System.Drawing.Size(464, 121)
        Me.customer.TabIndex = 0
        Me.customer.Text = "Customer"
        Me.customer.UseVisualStyleBackColor = True
        '
        'seller
        '
        Me.seller.Location = New System.Drawing.Point(160, 225)
        Me.seller.Name = "seller"
        Me.seller.Size = New System.Drawing.Size(464, 121)
        Me.seller.TabIndex = 1
        Me.seller.Text = "Seller"
        Me.seller.UseVisualStyleBackColor = True
        '
        'customerOrSeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.seller)
        Me.Controls.Add(Me.customer)
        Me.Name = "customerOrSeller"
        Me.Text = "customerOrSeller"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customer As Button
    Friend WithEvents seller As Button
End Class
