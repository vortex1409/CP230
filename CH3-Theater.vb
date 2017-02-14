Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            'Declaration Block'
            'Declaration of Variables with Textbox Values Assigned'
            Dim AdultTicketPrice As Double = Convert.ToDouble(txtPricePerTicketA.Text)
            Dim AdultTicketSold As Double = Convert.ToDouble(txtTicketsSoldA.Text)
            Dim ChildTicketPrice As Double = Convert.ToDouble(txtPricePerTicketC.Text)
            Dim ChildTicketSold As Double = Convert.ToDouble(txtTicketSoldC.Text)
            Dim GrossTicketSales, NetTicketSales, TotalGrossAdultTicketSales, TotalGrossChildTicketSales, TotalNetAdultTicketSales, TotalNetChildTicketSales As Double
            Const InternalSales As Double = 0.2

            'Math Block'
            'Calculates Total Gross & Net Adult and Child Ticket Sales'
            TotalGrossAdultTicketSales = AdultTicketPrice * AdultTicketSold
            TotalGrossChildTicketSales = ChildTicketPrice * ChildTicketSold
            GrossTicketSales = TotalGrossAdultTicketSales + TotalGrossChildTicketSales
            NetTicketSales = GrossTicketSales * InternalSales
            TotalNetAdultTicketSales = TotalGrossAdultTicketSales * InternalSales
            TotalNetChildTicketSales = TotalGrossChildTicketSales * InternalSales

            'Output Block'
            'Outputs the values from the Math Block into read-only textboxes'
            'The Values have to be Converted from Doubles to Strings'
            roAdultSalesN.Text = "$" + Convert.ToString(TotalNetAdultTicketSales)
            roChildSalesN.Text = "$" + Convert.ToString(TotalNetChildTicketSales)
            roTotalRevenueN.Text = "$" + Convert.ToString(NetTicketSales)
            roAdultTicketSalesG.Text = "$" + Convert.ToString(TotalGrossAdultTicketSales)
            roChildSalesG.Text = "$" + Convert.ToString(TotalGrossChildTicketSales)
            roGrossRev.Text = "$" + Convert.ToString(GrossTicketSales)
        Catch ex As Exception
            'If the User does not enter a numeric value in any of the fields'
            'This message is shown'
            MessageBox.Show("Please Enter Numeric Values")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset Block'
        'Clears the textboxes of the form both writeable and readonly'
        txtPricePerTicketA.Clear()
        txtPricePerTicketC.Clear()
        txtTicketSoldC.Clear()
        txtTicketsSoldA.Clear()
        roAdultSalesN.Clear()
        roAdultTicketSalesG.Clear()
        roChildSalesG.Clear()
        roChildSalesN.Clear()
        roGrossRev.Clear()
        roTotalRevenueN.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the Active Form'
        Me.Close()
    End Sub
End Class
