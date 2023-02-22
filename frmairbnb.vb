Public Class Form1

    Const _cdecCostPerNight As Decimal = 79D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumNights.Clear()
        txtNumNights.Focus()
        lblCostHead.Text = "Only" & Space(1) & _cdecCostPerNight.ToString("C") & Space(1) & Space(1) & "per night"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumNights.Clear()
        txtNumNights.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String = txtNumNights.Text
        Dim intNumNights As Integer = 0
        Dim decTotalCost As Decimal = 0D


        If Integer.TryParse(strNumNights, intNumNights) Then
            decTotalCost = intNumNights * _cdecCostPerNight
            lblCostDisplay.Text = decTotalCost.ToString("C")
        Else
            MessageBox.Show("Please enter a valid number of nights.")
        End If
    End Sub
End Class
