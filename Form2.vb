Public Class Form2
    Public Shared Vel, Ang, Acc As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Velocità iniziale (Km/h)"
        Label2.Text = "Angolazione (gradi)"
        Label3.Text = "Accelerazione di gravità (m/s^2)"
        TextBox1.Text = "700"
        TextBox2.Text = "75"
        TextBox3.Text = "9,8"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Vel = CSng(TextBox1.Text)
        Ang = CSng(TextBox2.Text)
        Acc = CSng(TextBox3.Text)
        Me.Close()
    End Sub
End Class