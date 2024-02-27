Option Strict On
Option Infer Off
Option Explicit On
Public Class Form1
    'A. Russell
    '2/22/24
    'Exercise 1
    Private Sub BtnEx_Click(sender As Object, e As EventArgs) Handles BtnEx.Click
        Me.Close()
    End Sub

    Private Function CalcTenPercent(cs As Double) As Double
        Return cs * 0.1
    End Function
    Private Function CalcProjected(cs As Double, per As Double) As Double
        Return cs + per
    End Function

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim strCS As String = TxtCS.Text
        If strCS = "" Then
            MessageBox.Show("Please enter a number for the current sales")
            Return
        End If
        Dim cs As Double
        Double.TryParse(strCS, cs)
        Dim inc As Double = CalcTenPercent(cs)
        Dim ps As Double = CalcProjected(cs, inc)

        TxtInc.Text = inc.ToString("C2")
        TxtPS.Text = ps.ToString("C2")
    End Sub

    Private Sub TxtCS_TextChanged(sender As Object, e As EventArgs) Handles TxtCS.TextChanged
        TxtPS.Text = ""
        TxtInc.Text = ""
    End Sub
End Class
