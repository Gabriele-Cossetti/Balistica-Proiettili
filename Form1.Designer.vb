<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProiettileDaTerraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProiettileDaCieloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PulisciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProiettileDaTerraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProiettileDaCieloToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpulsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisteToolStripMenuItem, Me.StimeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VisteToolStripMenuItem
        '
        Me.VisteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProiettileDaTerraToolStripMenuItem, Me.ProiettileDaCieloToolStripMenuItem, Me.PulisciToolStripMenuItem, Me.EsciToolStripMenuItem})
        Me.VisteToolStripMenuItem.Name = "VisteToolStripMenuItem"
        Me.VisteToolStripMenuItem.Size = New System.Drawing.Size(66, 29)
        Me.VisteToolStripMenuItem.Text = "Viste"
        '
        'ProiettileDaTerraToolStripMenuItem
        '
        Me.ProiettileDaTerraToolStripMenuItem.Name = "ProiettileDaTerraToolStripMenuItem"
        Me.ProiettileDaTerraToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.ProiettileDaTerraToolStripMenuItem.Text = "Proiettile da Terra"
        '
        'ProiettileDaCieloToolStripMenuItem
        '
        Me.ProiettileDaCieloToolStripMenuItem.Name = "ProiettileDaCieloToolStripMenuItem"
        Me.ProiettileDaCieloToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.ProiettileDaCieloToolStripMenuItem.Text = "Proiettile da cielo"
        '
        'PulisciToolStripMenuItem
        '
        Me.PulisciToolStripMenuItem.Name = "PulisciToolStripMenuItem"
        Me.PulisciToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.PulisciToolStripMenuItem.Text = "Pulisci"
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'StimeToolStripMenuItem
        '
        Me.StimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProiettileDaTerraToolStripMenuItem1, Me.ProiettileDaCieloToolStripMenuItem1, Me.ImpulsoToolStripMenuItem})
        Me.StimeToolStripMenuItem.Name = "StimeToolStripMenuItem"
        Me.StimeToolStripMenuItem.Size = New System.Drawing.Size(72, 29)
        Me.StimeToolStripMenuItem.Text = "Stime"
        '
        'ProiettileDaTerraToolStripMenuItem1
        '
        Me.ProiettileDaTerraToolStripMenuItem1.Name = "ProiettileDaTerraToolStripMenuItem1"
        Me.ProiettileDaTerraToolStripMenuItem1.Size = New System.Drawing.Size(250, 34)
        Me.ProiettileDaTerraToolStripMenuItem1.Text = "Proiettile da Terra"
        '
        'ProiettileDaCieloToolStripMenuItem1
        '
        Me.ProiettileDaCieloToolStripMenuItem1.Name = "ProiettileDaCieloToolStripMenuItem1"
        Me.ProiettileDaCieloToolStripMenuItem1.Size = New System.Drawing.Size(250, 34)
        Me.ProiettileDaCieloToolStripMenuItem1.Text = "Proiettile da cielo"
        '
        'ImpulsoToolStripMenuItem
        '
        Me.ImpulsoToolStripMenuItem.Name = "ImpulsoToolStripMenuItem"
        Me.ImpulsoToolStripMenuItem.Size = New System.Drawing.Size(250, 34)
        Me.ImpulsoToolStripMenuItem.Text = "Impulso"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VisteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProiettileDaTerraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProiettileDaCieloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PulisciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EsciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProiettileDaTerraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProiettileDaCieloToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImpulsoToolStripMenuItem As ToolStripMenuItem
End Class
