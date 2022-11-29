Public Class Form3
    Public Shared Quo, Vel1, Acc1 As Single

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Quota di lancio (in metri)"
        Label2.Text = "Velocità di lancio (km/h)"
        Label3.Text = "Accelerazione di gravità (m/s²)"
        TextBox1.Text = "1500"
        TextBox2.Text = "500"
        TextBox3.Text = "9,8"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quo = CSng(TextBox1.Text)
        Vel1 = CSng(TextBox2.Text)
        Acc1 = CSng(TextBox3.Text)
        Close()
    End Sub

End Class