Public Class Form6
    Public Vel2, Massa As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vel2 = Val(TextBox1.Text)
        Massa = Val(TextBox2.Text)
        Label4.Text = "L'impulso da imprimere al proiettile per fargli acquisire la Velocità iniziale voluta risulta:"
        Label5.Text = "(Kg x metro/sec) :   " & ((Vel2 * 1000 / 3600) * Massa)
    End Sub

End Class