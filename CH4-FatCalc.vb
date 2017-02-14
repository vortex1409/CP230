Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            'Declaration Block'
            'Variables are declared and textbox values applied
            Dim Calories As Integer = Convert.ToInt32(txtCalories.Text)
            Dim Fat As Double = Convert.ToDouble(txtFat.Text)
            Dim Percentage, FatCalories As Double

            'Math Block'
            'Calculates the Percentage of Calories is from the Fat'
            FatCalories = Fat * 9
            Percentage = (FatCalories / Calories) * 100

            'Output Block'
            'Outputs percentage value and tells the user if the food
            ' is low fat
            roPercent.Text = Convert.ToString(Percentage) + "%"
            If (Percentage <= 12) Then
                MessageBox.Show("Low Fat Food")
            End If
        Catch ex As Exception
            MessageBox.Show("Please Enter Numeric Values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset Block'
        'Clears textboxes and read-only textboxes'
        txtCalories.Clear()
        txtFat.Clear()
        roPercent.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Active Form'
        Me.Close()
    End Sub
End Class
