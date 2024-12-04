Public Class Form1
    Dim a As Double
    Dim b As Double
    Dim op As String

    Private Sub btnRT_Click(sender As Object, e As EventArgs) Handles btnRT.Click
        b = Val(txt.Text)
        If op = "+" Then
            txt.Text = (a + b).ToString
        End If
        If op = "*" Then
            txt.Text = (a * b).ToString
        End If
        If op = "-" Then
            txt.Text = (a - b).ToString
        End If
        If op = "/" Then
            txt.Text = (a / b).ToString
        End If
    End Sub

    Private Sub btnPLUS_Click(sender As Object, e As EventArgs) Handles btnPLUS.Click
        a = Val(txt.Text)
        txt.Clear()
        op = "+"
    End Sub

    Private Sub btnMOINS_Click(sender As Object, e As EventArgs) Handles btnMOINS.Click
        a = Val(txt.Text)
        txt.Clear()
        op = "-"
    End Sub

    Private Sub btnFOIS_Click(sender As Object, e As EventArgs) Handles btnFOIS.Click
        a = Val(txt.Text)
        txt.Clear()
        op = "*"
    End Sub

    Private Sub btnSUR_Click(sender As Object, e As EventArgs) Handles btnSUR.Click
        a = Val(txt.Text)
        txt.Clear()
        op = "/"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txt.Text = txt.Text + "0"
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txt.Text = txt.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txt.Text = txt.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt.Text = txt.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txt.Text = txt.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txt.Text = txt.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txt.Text = txt.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txt.Text = txt.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txt.Text = txt.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txt.Text = txt.Text + "9"
    End Sub

    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        Me.Close()
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txt.Clear()
    End Sub
End Class
