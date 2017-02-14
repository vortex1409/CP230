Public Class Form1

    'Class Level Declarations'
    Const NewRate As Double = 0.089
    Const UsedRate As Double = 0.095
    Dim AnnualRate As Double = NewRate

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Clears Listbox for New Execution
        lbppm.Items.Clear()

        'Exception Handling'
        Try
            'Declaration Block'
            Dim VehicleCost As Double = Convert.ToDouble(txtCost.Text)
            Dim DownPayment As Double = Convert.ToDouble(txtDown.Text)
            Dim Loan As Double
            Dim MonthlyPayment As Double
            Dim Interest As Double
            Dim Principal As Double
            Dim Months As Double = Convert.ToDouble(txtMonths.Text)
            Dim j As Integer

            'Calculated Loan & Monthly Payment Pre-Loop
            Loan = VehicleCost - DownPayment
            MonthlyPayment = Pmt(AnnualRate / 12, Months, -Loan)

            'Loop used to Add Values to Listbox'
            For j = 1 To Months

                'Calculates the Interest & Principal Amounts
                Interest = IPmt(AnnualRate / 12, j, Months, -Loan)
                Principal = PPmt(AnnualRate / 12, j, Months, -Loan)

                'Adds Values to Listbox every loop
                lbppm.Items.Add("Month: " + j.ToString("d2") + " Payment: $" + MonthlyPayment.ToString("n2") + " Interest: $" + Interest.ToString("n2") + " Principal: $" + Principal.ToString("n2"))
            Next
        Catch ex As Exception
            MessageBox.Show("Inputs must be Valid")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the Textboxes, read-only textbox, radio buttons and listbox
        txtCost.Clear()
        txtDown.Clear()
        txtMonths.Clear()
        roRate.Clear()
        lbppm.Items.Clear()
        rdNew.Checked = False
        rdUsed.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes Active Form'
        Me.Close()
    End Sub

    Private Sub rdNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdNew.CheckedChanged
        'Changes the Rate if the Radio Button is checked and displays the new rate to a read-only textbox'
        If (rdNew.Checked = True) Then
            AnnualRate = NewRate
            roRate.Text = Convert.ToString(NewRate * 100) + "%"
        End If
    End Sub

    Private Sub rdUsed_CheckedChanged(sender As Object, e As EventArgs) Handles rdUsed.CheckedChanged
        'Changes the Rate if the Radio Button is checked and displays the new rate to a read-only textbox'
        If (rdUsed.Checked = True) Then
            AnnualRate = UsedRate
            roRate.Text = Convert.ToString(UsedRate * 100) + "%"
        End If
    End Sub
End Class
