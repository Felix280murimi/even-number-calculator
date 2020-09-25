Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim i As Integer
        Dim numsum As Integer
        numsum = 0
        For i = 1 To 10 Step 2
            numsum = numsum + i
        Next i
        MessageBox.Show("The sum of the Even integr in the range 1 to " & 1 - 1 & "is" & numsum)
        MessageBox.Show("Enjoy life in the WORLD OF NUMBERS")
    End Sub
End Class
