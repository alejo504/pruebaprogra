Public Class FormColores
    Private Sub FormColores_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtColores.BackColor = Color.Red
    End Sub

    Private Sub btnazul_Click(sender As Object, e As EventArgs) Handles btnblue.Click
        txtColores.BackColor = Color.Blue

    End Sub

    Private Sub btnyellow_Click(sender As Object, e As EventArgs) Handles btnyellow.Click
        txtColores.BackColor = Color.Yellow
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnpink.Click
        txtColores.BackColor = Color.Pink
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles green.Click
        txtColores.BackColor = Color.Green
    End Sub
End Class
