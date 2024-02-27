Option Strict On
Option Infer Off
Option Explicit On
Public Class Grades
    'A. Russell
    '2/26/24
    'Exercise 9
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim pass, passper, fail, failper, total As Double
        input = TxtP.Text
        Double.TryParse(input, pass)
        input = TxtF.Text
        Double.TryParse(input, fail)
        total = pass + fail
        passper = pass / total
        failper = fail / total

        TxtPPer.Text = passper.ToString("P1")
        TxtFPer.Text = failper.ToString("P1")
    End Sub

    Private Sub TxtP_TextChanged(sender As Object, e As EventArgs) Handles TxtP.TextChanged
        TxtPPer.Text = ""
        TxtFPer.Text = ""
    End Sub

    Private Sub TxtF_TextChanged(sender As Object, e As EventArgs) Handles TxtF.TextChanged
        TxtPPer.Text = ""
        TxtFPer.Text = ""
    End Sub
End Class