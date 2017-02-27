<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Onderhouden
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtOndNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtOndPlaats = New System.Windows.Forms.TextBox()
        Me.TxtOndPc = New System.Windows.Forms.TextBox()
        Me.TxtOndAdres = New System.Windows.Forms.TextBox()
        Me.TxtOndNaam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KnopOpslaan = New System.Windows.Forms.Button()
        Me.KnopSluiten = New System.Windows.Forms.Button()
        Me.BoxOndLand = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BoxOndLand)
        Me.GroupBox1.Controls.Add(Me.TxtOndNr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtOndPlaats)
        Me.GroupBox1.Controls.Add(Me.TxtOndPc)
        Me.GroupBox1.Controls.Add(Me.TxtOndAdres)
        Me.GroupBox1.Controls.Add(Me.TxtOndNaam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 176)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TxtOndNr
        '
        Me.TxtOndNr.Enabled = False
        Me.TxtOndNr.Location = New System.Drawing.Point(117, 13)
        Me.TxtOndNr.Name = "TxtOndNr"
        Me.TxtOndNr.Size = New System.Drawing.Size(232, 20)
        Me.TxtOndNr.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Relatienummer"
        '
        'TxtOndPlaats
        '
        Me.TxtOndPlaats.Location = New System.Drawing.Point(117, 118)
        Me.TxtOndPlaats.Name = "TxtOndPlaats"
        Me.TxtOndPlaats.Size = New System.Drawing.Size(232, 20)
        Me.TxtOndPlaats.TabIndex = 10
        '
        'TxtOndPc
        '
        Me.TxtOndPc.Location = New System.Drawing.Point(117, 92)
        Me.TxtOndPc.Name = "TxtOndPc"
        Me.TxtOndPc.Size = New System.Drawing.Size(232, 20)
        Me.TxtOndPc.TabIndex = 9
        '
        'TxtOndAdres
        '
        Me.TxtOndAdres.Location = New System.Drawing.Point(117, 66)
        Me.TxtOndAdres.Name = "TxtOndAdres"
        Me.TxtOndAdres.Size = New System.Drawing.Size(232, 20)
        Me.TxtOndAdres.TabIndex = 8
        '
        'TxtOndNaam
        '
        Me.TxtOndNaam.Location = New System.Drawing.Point(117, 39)
        Me.TxtOndNaam.Name = "TxtOndNaam"
        Me.TxtOndNaam.Size = New System.Drawing.Size(232, 20)
        Me.TxtOndNaam.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Land"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Woonplaats"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Postcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Adres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Naam"
        '
        'KnopOpslaan
        '
        Me.KnopOpslaan.Location = New System.Drawing.Point(12, 194)
        Me.KnopOpslaan.Name = "KnopOpslaan"
        Me.KnopOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.KnopOpslaan.TabIndex = 3
        Me.KnopOpslaan.Text = "Opslaan"
        Me.KnopOpslaan.UseVisualStyleBackColor = True
        '
        'KnopSluiten
        '
        Me.KnopSluiten.Location = New System.Drawing.Point(292, 194)
        Me.KnopSluiten.Name = "KnopSluiten"
        Me.KnopSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopSluiten.TabIndex = 4
        Me.KnopSluiten.Text = "Sluiten"
        Me.KnopSluiten.UseVisualStyleBackColor = True
        '
        'BoxOndLand
        '
        Me.BoxOndLand.FormattingEnabled = True
        Me.BoxOndLand.Location = New System.Drawing.Point(117, 145)
        Me.BoxOndLand.Name = "BoxOndLand"
        Me.BoxOndLand.Size = New System.Drawing.Size(232, 21)
        Me.BoxOndLand.TabIndex = 14
        '
        'Onderhouden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 223)
        Me.Controls.Add(Me.KnopSluiten)
        Me.Controls.Add(Me.KnopOpslaan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Onderhouden"
        Me.Text = "Onderhouden"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtOndNr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtOndPlaats As TextBox
    Friend WithEvents TxtOndPc As TextBox
    Friend WithEvents TxtOndAdres As TextBox
    Friend WithEvents TxtOndNaam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KnopOpslaan As Button
    Friend WithEvents KnopSluiten As Button
    Friend WithEvents BoxOndLand As ComboBox
End Class
