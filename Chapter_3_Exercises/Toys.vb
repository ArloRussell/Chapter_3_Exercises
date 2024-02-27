Option Strict On
Option Infer Off
Option Explicit On
Public Class Toys
    'A. Russell
    '2/26/24
    'Exercise 8
    Const twpack As Double = 14.99
    Const fipack As Double = 6.99
    Const toPack As Double = 2.5
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim twelve, five, two, twtot, fitot, totot, ship, packtot, costtot As Double

        input = Txt12.Text
        Double.TryParse(input, twelve)
        input = Txt5.Text
        Double.TryParse(input, five)
        input = Txt2.Text
        Double.TryParse(input, two)
        input = TxtShip.Text
        Double.TryParse(input, ship)

        twtot = twelve * twpack
        fitot = five * fipack
        totot = two * toPack
        packtot = twelve + five + two
        costtot = twtot + fitot + totot + ship

        Txt12Cost.Text = twtot.ToString("C2")
        Txt5Cost.Text = fitot.ToString("C2")
        Txt2Cost.Text = totot.ToString("C2")
        TxtPackTot.Text = packtot.ToString("N0")
        TxtCostTot.Text = costtot.ToString("C2")
    End Sub

    Private Sub Txt12_TextChanged(sender As Object, e As EventArgs) Handles Txt12.TextChanged
        Txt12Cost.Text = ""
        Txt5Cost.Text = ""
        Txt2Cost.Text = ""
        TxtPackTot.Text = ""
        TxtCostTot.Text = ""
    End Sub

    Private Sub Txt5_TextChanged(sender As Object, e As EventArgs) Handles Txt5.TextChanged
        Txt12Cost.Text = ""
        Txt5Cost.Text = ""
        Txt2Cost.Text = ""
        TxtPackTot.Text = ""
        TxtCostTot.Text = ""
    End Sub

    Private Sub Txt2_TextChanged(sender As Object, e As EventArgs) Handles Txt2.TextChanged
        Txt12Cost.Text = ""
        Txt5Cost.Text = ""
        Txt2Cost.Text = ""
        TxtPackTot.Text = ""
        TxtCostTot.Text = ""
    End Sub

    Private Sub TxtShip_TextChanged(sender As Object, e As EventArgs) Handles TxtShip.TextChanged
        Txt12Cost.Text = ""
        Txt5Cost.Text = ""
        Txt2Cost.Text = ""
        TxtPackTot.Text = ""
        TxtCostTot.Text = ""
    End Sub
End Class