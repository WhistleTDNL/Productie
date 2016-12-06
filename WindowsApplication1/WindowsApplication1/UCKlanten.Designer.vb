<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCKlanten
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.KnopKlantenLeegmaken = New System.Windows.Forms.Button()
        Me.KnopKlantenOnderhoud = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtKlantenKlantNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtKlantenKlantLand = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantPlaats = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantPc = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantAdres = New System.Windows.Forms.TextBox()
        Me.TxtKlantenKlantNaam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KlantenDataGridView = New System.Windows.Forms.DataGridView()
        Me.KnopZoekKlant = New System.Windows.Forms.Button()
        Me.KnopNieuweKlant = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.KlantenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KnopKlantenLeegmaken
        '
        Me.KnopKlantenLeegmaken.Location = New System.Drawing.Point(93, 183)
        Me.KnopKlantenLeegmaken.Name = "KnopKlantenLeegmaken"
        Me.KnopKlantenLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopKlantenLeegmaken.TabIndex = 20
        Me.KnopKlantenLeegmaken.Text = "Leegmaken"
        Me.KnopKlantenLeegmaken.UseVisualStyleBackColor = True
        '
        'KnopKlantenOnderhoud
        '
        Me.KnopKlantenOnderhoud.Location = New System.Drawing.Point(255, 183)
        Me.KnopKlantenOnderhoud.Name = "KnopKlantenOnderhoud"
        Me.KnopKlantenOnderhoud.Size = New System.Drawing.Size(75, 23)
        Me.KnopKlantenOnderhoud.TabIndex = 22
        Me.KnopKlantenOnderhoud.Text = "Onderhoud"
        Me.KnopKlantenOnderhoud.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantNr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantLand)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantPlaats)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantPc)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantAdres)
        Me.GroupBox1.Controls.Add(Me.TxtKlantenKlantNaam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 176)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TxtKlantenKlantNr
        '
        Me.TxtKlantenKlantNr.Location = New System.Drawing.Point(113, 13)
        Me.TxtKlantenKlantNr.Name = "TxtKlantenKlantNr"
        Me.TxtKlantenKlantNr.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantNr.TabIndex = 13
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
        'TxtKlantenKlantLand
        '
        Me.TxtKlantenKlantLand.Location = New System.Drawing.Point(113, 144)
        Me.TxtKlantenKlantLand.Name = "TxtKlantenKlantLand"
        Me.TxtKlantenKlantLand.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantLand.TabIndex = 11
        '
        'TxtKlantenKlantPlaats
        '
        Me.TxtKlantenKlantPlaats.Location = New System.Drawing.Point(113, 118)
        Me.TxtKlantenKlantPlaats.Name = "TxtKlantenKlantPlaats"
        Me.TxtKlantenKlantPlaats.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantPlaats.TabIndex = 10
        '
        'TxtKlantenKlantPc
        '
        Me.TxtKlantenKlantPc.Location = New System.Drawing.Point(113, 92)
        Me.TxtKlantenKlantPc.Name = "TxtKlantenKlantPc"
        Me.TxtKlantenKlantPc.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantPc.TabIndex = 9
        '
        'TxtKlantenKlantAdres
        '
        Me.TxtKlantenKlantAdres.Location = New System.Drawing.Point(113, 66)
        Me.TxtKlantenKlantAdres.Name = "TxtKlantenKlantAdres"
        Me.TxtKlantenKlantAdres.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantAdres.TabIndex = 8
        '
        'TxtKlantenKlantNaam
        '
        Me.TxtKlantenKlantNaam.Location = New System.Drawing.Point(113, 39)
        Me.TxtKlantenKlantNaam.Name = "TxtKlantenKlantNaam"
        Me.TxtKlantenKlantNaam.Size = New System.Drawing.Size(208, 20)
        Me.TxtKlantenKlantNaam.TabIndex = 7
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
        'KlantenDataGridView
        '
        Me.KlantenDataGridView.AllowUserToAddRows = False
        Me.KlantenDataGridView.AllowUserToDeleteRows = False
        Me.KlantenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KlantenDataGridView.Location = New System.Drawing.Point(12, 212)
        Me.KlantenDataGridView.Name = "KlantenDataGridView"
        Me.KlantenDataGridView.ReadOnly = True
        Me.KlantenDataGridView.Size = New System.Drawing.Size(893, 226)
        Me.KlantenDataGridView.TabIndex = 16
        '
        'KnopZoekKlant
        '
        Me.KnopZoekKlant.Location = New System.Drawing.Point(12, 183)
        Me.KnopZoekKlant.Name = "KnopZoekKlant"
        Me.KnopZoekKlant.Size = New System.Drawing.Size(75, 23)
        Me.KnopZoekKlant.TabIndex = 17
        Me.KnopZoekKlant.Text = "Zoeken"
        Me.KnopZoekKlant.UseVisualStyleBackColor = True
        '
        'KnopNieuweKlant
        '
        Me.KnopNieuweKlant.Location = New System.Drawing.Point(174, 183)
        Me.KnopNieuweKlant.Name = "KnopNieuweKlant"
        Me.KnopNieuweKlant.Size = New System.Drawing.Size(75, 23)
        Me.KnopNieuweKlant.TabIndex = 19
        Me.KnopNieuweKlant.Text = "Nieuw"
        Me.KnopNieuweKlant.UseVisualStyleBackColor = True
        '
        'UCKlanten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KnopKlantenLeegmaken)
        Me.Controls.Add(Me.KnopKlantenOnderhoud)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KlantenDataGridView)
        Me.Controls.Add(Me.KnopZoekKlant)
        Me.Controls.Add(Me.KnopNieuweKlant)
        Me.Name = "UCKlanten"
        Me.Size = New System.Drawing.Size(909, 441)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.KlantenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KnopKlantenLeegmaken As Button
    Friend WithEvents KnopKlantenOnderhoud As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtKlantenKlantNr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtKlantenKlantLand As TextBox
    Friend WithEvents TxtKlantenKlantPlaats As TextBox
    Friend WithEvents TxtKlantenKlantPc As TextBox
    Friend WithEvents TxtKlantenKlantAdres As TextBox
    Friend WithEvents TxtKlantenKlantNaam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KlantenDataGridView As DataGridView
    Friend WithEvents KnopZoekKlant As Button
    Friend WithEvents KnopNieuweKlant As Button
End Class
