Option Strict On
Option Infer Off
Option Explicit On
Public Class Orders
    'A. Russell
    '2/22/24
    'Exercise 3
    Private total As Integer = 0
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim NumStr As String = TxtNumOrd.Text
        Dim num As Integer
        Integer.TryParse(NumStr, num)
        total += num

        TxtTot.Text = total.ToString("N0")
        TxtNumOrd.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnSub_Click(sender As Object, e As EventArgs) Handles BtnSub.Click
        Dim NumStr As String = TxtNumOrd.Text
        Dim num As Integer
        Integer.TryParse(NumStr, num)
        total -= num

        TxtTot.Text = total.ToString("N0")
        TxtNumOrd.Text = ""
    End Sub
End Class