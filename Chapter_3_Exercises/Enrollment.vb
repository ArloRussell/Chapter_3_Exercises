Option Strict On
Option Infer Off
Option Explicit On
Public Class Enrollment
    'A. Russell
    '2/22/24
    'Exercise 4
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim EnStr As String = TxtNum.Text
        Dim enNum As Integer
        Static Dim tot As Integer
        Integer.TryParse(EnStr, enNum)
        tot += enNum

        TxtTot.Text = tot.ToString("N0")
        TxtNum.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class