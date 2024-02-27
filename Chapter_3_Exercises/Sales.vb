Option Strict On
Option Infer Off
Option Explicit On
Public Class Sales
    'A. Russell
    '2/27/24
    'Exercise 10
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim input As String
        Dim jim, karen, martin, jper, kper, mper, total As Double
        input = TxtJim.Text
        Double.TryParse(input, jim)
        input = TxtKaren.Text
        Double.TryParse(input, karen)
        input = TxtMartin.Text
        Double.TryParse(input, martin)
        total = jim + karen + martin
        jper = jim / total
        kper = karen / total
        mper = martin / total

        TxtJimPer.Text = jper.ToString("P1")
        TxtKarenPer.Text = kper.ToString("P2")
        TxtMartinPer.Text = mper.ToString("P2")
    End Sub

    Private Sub TxtJim_TextChanged(sender As Object, e As EventArgs) Handles TxtJim.TextChanged
        TxtKarenPer.Text = ""
        TxtMartinPer.Text = ""
        TxtJimPer.Text = ""
    End Sub

    Private Sub TxtKaren_TextChanged(sender As Object, e As EventArgs) Handles TxtKaren.TextChanged
        TxtJimPer.Text = ""
        TxtMartinPer.Text = ""
        TxtKarenPer.Text = ""
    End Sub

    Private Sub TxtMartin_TextChanged(sender As Object, e As EventArgs) Handles TxtMartin.TextChanged
        TxtKarenPer.Text = ""
        TxtJimPer.Text = ""
        TxtMartinPer.Text = ""
    End Sub
End Class