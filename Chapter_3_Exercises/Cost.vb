Option Strict On
Option Infer Off
Option Explicit On
Public Class Cost
    'A. Russell
    '2/26/24
    'Exercise 7
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim people, allow, cost As Double
        input = TxtPeople.Text
        Double.TryParse(input, people)
        input = TxtExpen.Text
        Double.TryParse(input, allow)
        cost = allow * people

        TxtCost.Text = cost.ToString("C2")
    End Sub

    Private Sub TxtPeople_TextChanged(sender As Object, e As EventArgs) Handles TxtPeople.TextChanged
        TxtCost.Text = ""
    End Sub

    Private Sub TxtExpen_TextChanged(sender As Object, e As EventArgs) Handles TxtExpen.TextChanged
        TxtCost.Text = ""
    End Sub
End Class