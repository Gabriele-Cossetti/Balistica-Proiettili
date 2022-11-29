Public Class Form4
    Public Shared Time As Integer
    Public Shared Tmax, Xmax, Ymax, Max, X, Y, Vel, Acc, Ang As Single

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Vel = Form2.Vel
        Acc = Form2.Acc
        Ang = Form2.Ang
        If (Vel = 0 And Form2.Vel = 0) Then Vel = 500
        If (Acc = 0 And Form2.Acc = 0) Then Acc = 9.80665
        If (Ang = 0 And Form2.Ang = 0) Then Ang = 45
        Tmax = 2 * (Vel * 1000 / 3600) / Acc * Math.Sin(Ang * 3.14159265358979 / 180)
        Tmax = Math.Abs(Tmax)
        Xmax = (2 * Math.Sin(Ang * 3.14159265358979 / 180) * Math.Cos(Ang * 3.14159265358979 / 180) * (Vel * 1000 / 3600) ^ 2) / Acc
        Ymax = ((Vel * 1000 / 3600) ^ 2 * Math.Sin(Ang * 3.14159265358979 / 180) ^ 2) / (2 * Acc)
        If Max = 0 Then Max = ((Vel * 1000 / 3600) ^ 2) / Acc
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Dati di ingresso :") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Velocità iniziale (Km/h) : " & Vel) & vbCrLf
        TextBox1.Text &= ("Velocità iniziale (m/sec) : " & (Vel * 1000 / 3600)) & vbCrLf
        TextBox1.Text &= ("Angolazione (gradi) : " & Ang) & vbCrLf
        TextBox1.Text &= ("Angolazione (radianti) : " & (Ang * 3.14159265358979 / 180)) & vbCrLf
        TextBox1.Text &= ("Accelerazione di gravità (m/s²) : " & Acc) & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Valori calcolati :") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Tempo Massimo (sec) : " & Tmax) & vbCrLf
        TextBox1.Text &= ("Distanza di caduta (m) : " & Xmax) & vbCrLf
        TextBox1.Text &= ("Altezza massima raggiunta (m) : " & Ymax) & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        TextBox1.Text &= ("Valori istante per istante") & vbCrLf
        TextBox1.Text &= ("------------------------------------------") & vbCrLf
        Time = 0
        While (Time < Tmax)
            X = (Vel * 1000 / 3600) * Time * Math.Cos(Ang * 3.14159265358979 / 180)
            Y = (Vel * 1000 / 3600) * Time * Math.Sin(Ang * 3.14159265358979 / 180) - (Acc * Time ^ 2) / 2
            TextBox1.Text &= ("Tempo (sec) : " & Time & "    Ascissa (m) : " & X & "    Ordinata (m) : " & Y) & vbCrLf
            Time = Time + Tmax / 20
        End While
        TextBox1.Text &= vbCrLf
    End Sub
End Class