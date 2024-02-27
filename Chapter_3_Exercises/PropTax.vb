Option Strict On
Option Infer Off
Option Explicit On
Public Class PropTax
    'A. Russell
    '2/22/24
    'Exercise 2
    Const Tax As Double = 0.0135
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim valueStr As String = TxtAV.Text
        If valueStr = "" Then
            MessageBox.Show("Please enter a value")
        End If
        Dim value As Double
        Double.TryParse(valueStr, value)
        Dim proptax As Double = value * Tax

        txtPT.Text = proptax.ToString("C2")


    End Sub

    Private Sub TxtAV_TextChanged(sender As Object, e As EventArgs) Handles TxtAV.TextChanged
        txtPT.Text = ""
    End Sub
End Class