<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NwKlant
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
        Me.KnopNwKlantLeegmaken = New System.Windows.Forms.Button()
        Me.TxtNwKlantNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNwKlantPlaats = New System.Windows.Forms.TextBox()
        Me.TxtNwKlantPc = New System.Windows.Forms.TextBox()
        Me.TxtNwKlantAdres = New System.Windows.Forms.TextBox()
        Me.TxtNwKlantNaam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KnopNwKlantOpslaan = New System.Windows.Forms.Button()
        Me.KnopNwKlantSluiten = New System.Windows.Forms.Button()
        Me.BoxNwKlantLand = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BoxNwKlantLand)
        Me.GroupBox1.Controls.Add(Me.KnopNwKlantLeegmaken)
        Me.GroupBox1.Controls.Add(Me.TxtNwKlantNr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNwKlantPlaats)
        Me.GroupBox1.Controls.Add(Me.TxtNwKlantPc)
        Me.GroupBox1.Controls.Add(Me.TxtNwKlantAdres)
        Me.GroupBox1.Controls.Add(Me.TxtNwKlantNaam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.KnopNwKlantOpslaan)
        Me.GroupBox1.Controls.Add(Me.KnopNwKlantSluiten)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 199)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'KnopNwKlantLeegmaken
        '
        Me.KnopNwKlantLeegmaken.Location = New System.Drawing.Point(123, 170)
        Me.KnopNwKlantLeegmaken.Name = "KnopNwKlantLeegmaken"
        Me.KnopNwKlantLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopNwKlantLeegmaken.TabIndex = 7
        Me.KnopNwKlantLeegmaken.Text = "Leegmaken"
        Me.KnopNwKlantLeegmaken.UseVisualStyleBackColor = True
        '
        'TxtNwKlantNr
        '
        Me.TxtNwKlantNr.Enabled = False
        Me.TxtNwKlantNr.Location = New System.Drawing.Point(73, 13)
        Me.TxtNwKlantNr.Name = "TxtNwKlantNr"
        Me.TxtNwKlantNr.Size = New System.Drawing.Size(232, 20)
        Me.TxtNwKlantNr.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Klantnummer"
        '
        'TxtNwKlantPlaats
        '
        Me.TxtNwKlantPlaats.Location = New System.Drawing.Point(73, 118)
        Me.TxtNwKlantPlaats.Name = "TxtNwKlantPlaats"
        Me.TxtNwKlantPlaats.Size = New System.Drawing.Size(232, 20)
        Me.TxtNwKlantPlaats.TabIndex = 4
        '
        'TxtNwKlantPc
        '
        Me.TxtNwKlantPc.Location = New System.Drawing.Point(73, 92)
        Me.TxtNwKlantPc.Name = "TxtNwKlantPc"
        Me.TxtNwKlantPc.Size = New System.Drawing.Size(232, 20)
        Me.TxtNwKlantPc.TabIndex = 3
        '
        'TxtNwKlantAdres
        '
        Me.TxtNwKlantAdres.Location = New System.Drawing.Point(73, 66)
        Me.TxtNwKlantAdres.Name = "TxtNwKlantAdres"
        Me.TxtNwKlantAdres.Size = New System.Drawing.Size(232, 20)
        Me.TxtNwKlantAdres.TabIndex = 2
        '
        'TxtNwKlantNaam
        '
        Me.TxtNwKlantNaam.Location = New System.Drawing.Point(73, 39)
        Me.TxtNwKlantNaam.Name = "TxtNwKlantNaam"
        Me.TxtNwKlantNaam.Size = New System.Drawing.Size(232, 20)
        Me.TxtNwKlantNaam.TabIndex = 1
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
        'KnopNwKlantOpslaan
        '
        Me.KnopNwKlantOpslaan.Location = New System.Drawing.Point(9, 170)
        Me.KnopNwKlantOpslaan.Name = "KnopNwKlantOpslaan"
        Me.KnopNwKlantOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.KnopNwKlantOpslaan.TabIndex = 6
        Me.KnopNwKlantOpslaan.Text = "Opslaan"
        Me.KnopNwKlantOpslaan.UseVisualStyleBackColor = True
        '
        'KnopNwKlantSluiten
        '
        Me.KnopNwKlantSluiten.Location = New System.Drawing.Point(230, 170)
        Me.KnopNwKlantSluiten.Name = "KnopNwKlantSluiten"
        Me.KnopNwKlantSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopNwKlantSluiten.TabIndex = 8
        Me.KnopNwKlantSluiten.Text = "Annuleren"
        Me.KnopNwKlantSluiten.UseVisualStyleBackColor = True
        '
        'BoxNwKlantLand
        '
        Me.BoxNwKlantLand.FormattingEnabled = True
        Me.BoxNwKlantLand.Location = New System.Drawing.Point(73, 143)
        Me.BoxNwKlantLand.Name = "BoxNwKlantLand"
        Me.BoxNwKlantLand.Size = New System.Drawing.Size(232, 21)
        Me.BoxNwKlantLand.TabIndex = 13
        '
        'NwKlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 225)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NwKlant"
        Me.Text = "Nieuw Klant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNwKlantNr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNwKlantPlaats As TextBox
    Friend WithEvents TxtNwKlantPc As TextBox
    Friend WithEvents TxtNwKlantAdres As TextBox
    Friend WithEvents TxtNwKlantNaam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KnopNwKlantOpslaan As Button
    Friend WithEvents KnopNwKlantSluiten As Button
    Friend WithEvents KnopNwKlantLeegmaken As Button
    Friend WithEvents BoxNwKlantLand As ComboBox
End Class
