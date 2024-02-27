Option Strict On
Option Infer Off
Option Explicit On
Public Class AreaCalc
    'A. Russell
    '2/26/24
    'Exercise 5

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim length As Double
        Dim width As Double

        input = TxtLen.Text
        Double.TryParse(input, length)
        input = TxtWid.Text
        Double.TryParse(input, width)
        Dim sqfeet As Double = length * width
        Dim sqyards As Double = sqfeet / 9

        TxtFeet.Text = sqfeet.ToString("N1")
        TxtYards.Text = sqyards.ToString("N1")
    End Sub

    Private Sub TxtLen_TextChanged(sender As Object, e As EventArgs) Handles TxtLen.TextChanged
        TxtFeet.Text = ""
        TxtYards.Text = ""
    End Sub

    Private Sub TxtWid_TextChanged(sender As Object, e As EventArgs) Handles TxtWid.TextChanged
        TxtFeet.Text = ""
        TxtYards.Text = ""
    End Sub
End Class