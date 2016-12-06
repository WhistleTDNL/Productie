<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLev
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
        Me.KnopZoekLev = New System.Windows.Forms.Button()
        Me.KnopNieuweLev = New System.Windows.Forms.Button()
        Me.TxtLevNr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtLevLand = New System.Windows.Forms.TextBox()
        Me.TxtLevPlaats = New System.Windows.Forms.TextBox()
        Me.TxtLevPc = New System.Windows.Forms.TextBox()
        Me.TxtLevAdres = New System.Windows.Forms.TextBox()
        Me.TxtLevNaam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KnopLevLeegmaken = New System.Windows.Forms.Button()
        Me.KnopLevOnderhoud = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LevDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LevDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KnopZoekLev
        '
        Me.KnopZoekLev.Location = New System.Drawing.Point(12, 183)
        Me.KnopZoekLev.Name = "KnopZoekLev"
        Me.KnopZoekLev.Size = New System.Drawing.Size(75, 23)
        Me.KnopZoekLev.TabIndex = 24
        Me.KnopZoekLev.Text = "Zoeken"
        Me.KnopZoekLev.UseVisualStyleBackColor = True
        '
        'KnopNieuweLev
        '
        Me.KnopNieuweLev.Location = New System.Drawing.Point(174, 183)
        Me.KnopNieuweLev.Name = "KnopNieuweLev"
        Me.KnopNieuweLev.Size = New System.Drawing.Size(75, 23)
        Me.KnopNieuweLev.TabIndex = 26
        Me.KnopNieuweLev.Text = "Nieuw"
        Me.KnopNieuweLev.UseVisualStyleBackColor = True
        '
        'TxtLevNr
        '
        Me.TxtLevNr.Location = New System.Drawing.Point(112, 13)
        Me.TxtLevNr.Name = "TxtLevNr"
        Me.TxtLevNr.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevNr.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Leveranciernummer"
        '
        'TxtLevLand
        '
        Me.TxtLevLand.Location = New System.Drawing.Point(112, 144)
        Me.TxtLevLand.Name = "TxtLevLand"
        Me.TxtLevLand.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevLand.TabIndex = 11
        '
        'TxtLevPlaats
        '
        Me.TxtLevPlaats.Location = New System.Drawing.Point(112, 118)
        Me.TxtLevPlaats.Name = "TxtLevPlaats"
        Me.TxtLevPlaats.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevPlaats.TabIndex = 10
        '
        'TxtLevPc
        '
        Me.TxtLevPc.Location = New System.Drawing.Point(112, 92)
        Me.TxtLevPc.Name = "TxtLevPc"
        Me.TxtLevPc.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevPc.TabIndex = 9
        '
        'TxtLevAdres
        '
        Me.TxtLevAdres.Location = New System.Drawing.Point(112, 66)
        Me.TxtLevAdres.Name = "TxtLevAdres"
        Me.TxtLevAdres.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevAdres.TabIndex = 8
        '
        'TxtLevNaam
        '
        Me.TxtLevNaam.Location = New System.Drawing.Point(112, 39)
        Me.TxtLevNaam.Name = "TxtLevNaam"
        Me.TxtLevNaam.Size = New System.Drawing.Size(209, 20)
        Me.TxtLevNaam.TabIndex = 7
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
        'KnopLevLeegmaken
        '
        Me.KnopLevLeegmaken.Location = New System.Drawing.Point(93, 183)
        Me.KnopLevLeegmaken.Name = "KnopLevLeegmaken"
        Me.KnopLevLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopLevLeegmaken.TabIndex = 27
        Me.KnopLevLeegmaken.Text = "Leegmaken"
        Me.KnopLevLeegmaken.UseVisualStyleBackColor = True
        '
        'KnopLevOnderhoud
        '
        Me.KnopLevOnderhoud.Location = New System.Drawing.Point(255, 183)
        Me.KnopLevOnderhoud.Name = "KnopLevOnderhoud"
        Me.KnopLevOnderhoud.Size = New System.Drawing.Size(75, 23)
        Me.KnopLevOnderhoud.TabIndex = 29
        Me.KnopLevOnderhoud.Text = "Onderhoud"
        Me.KnopLevOnderhoud.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtLevNr)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtLevLand)
        Me.GroupBox1.Controls.Add(Me.TxtLevPlaats)
        Me.GroupBox1.Controls.Add(Me.TxtLevPc)
        Me.GroupBox1.Controls.Add(Me.TxtLevAdres)
        Me.GroupBox1.Controls.Add(Me.TxtLevNaam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 176)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'LevDataGridView
        '
        Me.LevDataGridView.AllowUserToAddRows = False
        Me.LevDataGridView.AllowUserToDeleteRows = False
        Me.LevDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LevDataGridView.Location = New System.Drawing.Point(12, 213)
        Me.LevDataGridView.Name = "LevDataGridView"
        Me.LevDataGridView.ReadOnly = True
        Me.LevDataGridView.Size = New System.Drawing.Size(898, 333)
        Me.LevDataGridView.TabIndex = 30
        '
        'UCLev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LevDataGridView)
        Me.Controls.Add(Me.KnopZoekLev)
        Me.Controls.Add(Me.KnopNieuweLev)
        Me.Controls.Add(Me.KnopLevLeegmaken)
        Me.Controls.Add(Me.KnopLevOnderhoud)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCLev"
        Me.Size = New System.Drawing.Size(913, 549)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LevDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KnopZoekLev As Button
    Friend WithEvents KnopNieuweLev As Button
    Friend WithEvents TxtLevNr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtLevLand As TextBox
    Friend WithEvents TxtLevPlaats As TextBox
    Friend WithEvents TxtLevPc As TextBox
    Friend WithEvents TxtLevAdres As TextBox
    Friend WithEvents TxtLevNaam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KnopLevLeegmaken As Button
    Friend WithEvents KnopLevOnderhoud As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LevDataGridView As DataGridView
End Class
