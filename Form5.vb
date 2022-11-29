Public Class Form5
    Public Shared Time As Integer
    Public Shared Tmax, Xmax, Ymax, X, Y, Vel1, Acc1, Quo As Single
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quo = Form3.Quo
        Vel1 = Form3.Vel1
        Acc1 = Form3.Acc1
        If (Quo = 0 And Form3.Quo = 0) Then Quo = 1500
        If (Vel1 = 0 And Form3.Vel1 = 0) Then Vel1 = 500
        If (Acc1 = 0 And Form3.Acc1 = 0) Then Acc1 = 9.80665
        Tmax = Math.Sqrt(2 * Quo / Acc1)
        Tmax = Math.Abs(Tmax)
        Xmax = (Vel1 * 1000 / 3600) * Tmax
        Ymax = Quo
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Dati di ingresso :") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Quota di lancio (Km) : " & (Quo / 1000)) & vbCrLf
        TextBox1.Text &= ("Quota di lancio (m) : " & Quo) & vbCrLf
        TextBox1.Text &= ("Velocità di lancio (Km/h) : " & Vel1) & vbCrLf
        TextBox1.Text &= ("Velocità di lancio (m/s) : " & Vel1 * 1000 / 3600) & vbCrLf
        TextBox1.Text &= ("Accelerazione di gravità (m/s²) : " & Acc1) & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Valori calcolati :") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Tempo Massimo (sec) : " & Tmax) & vbCrLf
        TextBox1.Text &= ("Distanza di caduta (m) : " & Xmax) & vbCrLf
        TextBox1.Text &= ("Altezza di lancio (m) : " & Ymax) & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Valori istante per istante") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        Time = 0
        While (Time < Tmax)
            X = (Vel1 * 1000 / 3600) * Time
            Y = Quo - ((Acc1 / 2) * Time ^ 2)
            TextBox1.Text &= ("Tempo (sec) : " & Time & "    Ascissa (m) : " & X & "    Ordinata (m) : " & Y) & vbCrLf
            Time = Time + Tmax / 20
        End While
        TextBox1.Text &= vbCrLf
    End Sub
End Class