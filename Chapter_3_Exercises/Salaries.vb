Option Strict On
Option Infer Off
Option Explicit On
Public Class Salaries
    'A. Russell
    '2/26/24
    'Exercise 6
    Private fiveper As Double = 0.05
    Private eightper As Double = 0.08
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Txt5.Text = ""
        Txt5New.Text = ""
        Txt8.Text = ""
        Txt8New.Text = ""
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim sal, five, fivenew, eight, eightnew As Double

        input = TxtCurrent.Text
        Double.TryParse(input, sal)

        five = sal * fiveper
        fivenew = five + sal
        eight = sal * eightper
        eightnew = eight + sal

        Txt5.Text = five.ToString("C2")
        Txt5New.Text = fivenew.ToString("C2")
        Txt8.Text = eight.ToString("C2")
        Txt8New.Text = eightnew.ToString("C2")

    End Sub

    Private Sub TxtCurrent_TextChanged(sender As Object, e As EventArgs) Handles TxtCurrent.TextChanged
        Txt5.Text = ""
        Txt5New.Text = ""
        Txt8.Text = ""
        Txt8New.Text = ""
    End Sub
End Class