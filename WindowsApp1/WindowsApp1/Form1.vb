Public Class Form1
    Dim src, n, i, j, a(100), flag, len As Integer
    Dim str As String

    Public Sub Swap(Of T)(ByRef d1 As T, ByRef d2 As T)
        Dim d = d2
        d2 = d1
        d1 = d
    End Sub

    Public Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'CREATE
ListBoxInputFor_n:
        ListBox1.ClearSelected()
        str = InputBox("Enter the Number of elements: ")
        If IsNumeric(str) Then
            n = str
        Else
            MsgBox("Error! Please try a numeric value.")
            GoTo ListBoxInputFor_n  'GOES BACK to taking input for n
            Return
        End If


        For i = 0 To n - 1 Step 1
            a(i) = InputBox("Enter The number: ")
            ListBox1.Items.Add(a(i))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'SEARCH
        flag = 1
        src = InputBox("Enter the number to search: ")
        For i = 0 To a.Length() Step 1
            If a(i) = src Then
                flag = 0
                Exit For
            End If
        Next

        MsgBox("The value is available at point " & i + 1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'SORT ASCENDING
        ListBox2.Items.Add("The List Sorted In ascending order is : ")

        For i = 0 To n - 2 Step 1
            For j = i + 1 To n - 1 Step 1
                If a(i) > a(j) Then
                    Swap(Of Integer)(a(i), a(j))
                End If
            Next j
        Next i

        For i = 0 To n - 1 Step 1
            ListBox2.Items.Add(a(i))
        Next

    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()  'Since Form1 cannot refer to itself, we use Me
    End Sub
End Class