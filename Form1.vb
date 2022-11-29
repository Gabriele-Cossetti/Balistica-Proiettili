Imports System.Buffers
Imports System.Reflection.Emit
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Public Shared PiGreco As Single = 3.14159265358979
    Public Shared Vel, Ang, Acc, Quo, Vel1, Acc1, Max, Tmax, Xmax, Ymax, X, Y As Single
    Public Shared Time As Integer
    Dim Piano As Graphics

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Piano = Me.CreateGraphics()
    End Sub
    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Call Sfondo()
        Call TracciaDaTerra()
        Call TracciaDaCielo()
    End Sub

    Private Sub TracciaDaTerra()
        Dim Dimensione, K1, K2, Costante As Integer
        Me.Width = Size.Width
        Me.Height = Size.Height
        If Me.Height > Me.Width Then
            Dimensione = Me.Width
        Else
            Dimensione = Me.Height
        End If
        If Vel = 0 And Form2.Vel = 0 Then Vel = 500 * 1000 / 3600
        If Ang = 0 And Form2.Ang = 0 Then Ang = 45 * PiGreco / 180
        If Acc = 0 And Form2.Acc = 0 Then Acc = 9.80665
        Tmax = 2 * Vel / Acc * Math.Sin(Ang)
        Tmax = Math.Abs(Tmax)
        Xmax = (2 * Math.Sin(Ang) * Math.Cos(Ang) * Vel ^ 2) / Acc
        Ymax = (Vel ^ 2 * Math.Sin(Ang) ^ 2) / (2 * Acc)
        If Max = 0 Then Max = (Vel ^ 2) / Acc
        Time = 0
        Costante = 60
        While (Time < Tmax)
            X = Vel * Time * Math.Cos(Ang)
            Y = Vel * Time * Math.Sin(Ang) - (Acc * Time ^ 2) / 2
            K1 = (Dimensione - Costante) / Max * X
            K2 = (Dimensione - Costante) - ((Dimensione - Costante) / Max * Y)
            Piano.FillEllipse(Brushes.Yellow, K1, K2, 5, 5)
            Time = Time + Tmax / 30
        End While
        Me.Update()
    End Sub

    Public Sub TracciaDaCielo()
        Dim Dimensione, K1, K2, Costante As Integer
        Me.Width = Size.Width
        Me.Height = Size.Height
        If Me.Height > Me.Width Then
            Dimensione = Me.Width
        Else
            Dimensione = Me.Height
        End If
        If Quo = 0 And Form3.Quo = 0 Then Quo = 1500
        If Vel1 = 0 And Form3.Vel1 = 0 Then Vel1 = 500.0 * 1000 / 3600
        If Acc1 = 0 And Form3.Acc1 = 0 Then Acc1 = 9.80665
        Tmax = Math.Sqrt(2 * Quo / Acc1)
        Tmax = Math.Abs(Tmax)
        Xmax = Vel1 * Tmax
        Ymax = Quo
        If Max < Quo Then
            Call Sfondo()
            Max = Quo
        End If
        Time = 0
        Costante = 60
        While (Time < Tmax)
            X = Vel1 * Time
            Y = Quo - ((Acc1 / 2) * Time ^ 2) - 200
            K1 = (Dimensione - Costante) / Max * X
            K2 = (Dimensione - Costante) - ((Dimensione - Costante) / Max * Y)
            Piano.FillEllipse(Brushes.GreenYellow, K1, K2, 5, 5)
            Time = Time + Tmax / 20
        End While
    End Sub

    Public Sub Sfondo()
        AutoSize = True
        Me.Width = Size.Width
        Me.Height = Size.Height
        Dim K1, K2 As Integer
        Piano.FillRectangle(Brushes.Blue, 2, 43, Me.Size.Width - 25, Me.Size.Height - 104)
        Dim pen As New Pen(Color.GreenYellow, 1)
        For K1 = 1 To Me.Width Step Me.Width / 10
            Piano.DrawLine(pen, K1, 1, K1, Me.Height)
        Next K1
        For K2 = (Me.Height + 250) To 1 Step -Me.Height / 10
            Piano.DrawLine(pen, 1, K2, Me.Width, K2)
        Next K2
        pen.Dispose()
    End Sub

    Private Sub ProiettileDaTerraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProiettileDaTerraToolStripMenuItem.Click
        Form2.ShowDialog()
        Vel = Form2.Vel * 1000 / 3600
        Ang = Form2.Ang * PiGreco / 180
        Acc = Form2.Acc
        Call TracciaDaTerra()
    End Sub

    Private Sub ProiettileDaCieloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProiettileDaCieloToolStripMenuItem.Click
        Form3.ShowDialog()
        Quo = Form3.Quo
        Vel1 = Form3.Vel1 * 1000 / 3600
        Acc1 = Form3.Acc1
        Call TracciaDaCielo()
    End Sub

    Private Sub PulisciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PulisciToolStripMenuItem.Click
        Call Sfondo()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProiettileDaTerraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProiettileDaTerraToolStripMenuItem1.Click
        Form4.ShowDialog()
        '-----------------------------
    End Sub

    Private Sub ProiettileDaCieloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProiettileDaCieloToolStripMenuItem1.Click
        Form5.ShowDialog()
        '-----------------------------------
    End Sub

    Private Sub ImpulsoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpulsoToolStripMenuItem.Click
        Form6.ShowDialog()
        '-----------------------------------
    End Sub
End Class
