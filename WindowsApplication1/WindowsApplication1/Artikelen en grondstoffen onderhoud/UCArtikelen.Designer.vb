<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCArtikelen
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
        Me.ArtDataGridView = New System.Windows.Forms.DataGridView()
        Me.KnopZoek = New System.Windows.Forms.Button()
        Me.KnopNieuw = New System.Windows.Forms.Button()
        Me.KnopLeegmaken = New System.Windows.Forms.Button()
        Me.KnopOnderhoud = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.idartsupp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idartstof = New System.Windows.Forms.TextBox()
        Me.idarttyp = New System.Windows.Forms.TextBox()
        Me.idartsrt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Artnr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.artdoos = New System.Windows.Forms.TextBox()
        Me.artverp = New System.Windows.Forms.TextBox()
        Me.artloop = New System.Windows.Forms.TextBox()
        Me.artmaat = New System.Windows.Forms.TextBox()
        Me.artoms = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ArtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArtDataGridView
        '
        Me.ArtDataGridView.AllowUserToAddRows = False
        Me.ArtDataGridView.AllowUserToDeleteRows = False
        Me.ArtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtDataGridView.Location = New System.Drawing.Point(3, 134)
        Me.ArtDataGridView.Name = "ArtDataGridView"
        Me.ArtDataGridView.ReadOnly = True
        Me.ArtDataGridView.Size = New System.Drawing.Size(1185, 304)
        Me.ArtDataGridView.TabIndex = 0
        '
        'KnopZoek
        '
        Me.KnopZoek.Location = New System.Drawing.Point(12, 105)
        Me.KnopZoek.Name = "KnopZoek"
        Me.KnopZoek.Size = New System.Drawing.Size(75, 23)
        Me.KnopZoek.TabIndex = 30
        Me.KnopZoek.Text = "Zoeken"
        Me.KnopZoek.UseVisualStyleBackColor = True
        '
        'KnopNieuw
        '
        Me.KnopNieuw.Location = New System.Drawing.Point(174, 105)
        Me.KnopNieuw.Name = "KnopNieuw"
        Me.KnopNieuw.Size = New System.Drawing.Size(75, 23)
        Me.KnopNieuw.TabIndex = 32
        Me.KnopNieuw.Text = "Nieuw"
        Me.KnopNieuw.UseVisualStyleBackColor = True
        '
        'KnopLeegmaken
        '
        Me.KnopLeegmaken.Location = New System.Drawing.Point(93, 105)
        Me.KnopLeegmaken.Name = "KnopLeegmaken"
        Me.KnopLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.KnopLeegmaken.TabIndex = 33
        Me.KnopLeegmaken.Text = "Leegmaken"
        Me.KnopLeegmaken.UseVisualStyleBackColor = True
        '
        'KnopOnderhoud
        '
        Me.KnopOnderhoud.Location = New System.Drawing.Point(255, 105)
        Me.KnopOnderhoud.Name = "KnopOnderhoud"
        Me.KnopOnderhoud.Size = New System.Drawing.Size(75, 23)
        Me.KnopOnderhoud.TabIndex = 34
        Me.KnopOnderhoud.Text = "Onderhoud"
        Me.KnopOnderhoud.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idartsupp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.idartstof)
        Me.GroupBox1.Controls.Add(Me.idarttyp)
        Me.GroupBox1.Controls.Add(Me.idartsrt)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Artnr)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.artdoos)
        Me.GroupBox1.Controls.Add(Me.artverp)
        Me.GroupBox1.Controls.Add(Me.artloop)
        Me.GroupBox1.Controls.Add(Me.artmaat)
        Me.GroupBox1.Controls.Add(Me.artoms)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1185, 96)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'idartsupp
        '
        Me.idartsupp.Location = New System.Drawing.Point(967, 13)
        Me.idartsupp.Name = "idartsupp"
        Me.idartsupp.Size = New System.Drawing.Size(209, 20)
        Me.idartsupp.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(917, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Support"
        '
        'idartstof
        '
        Me.idartstof.Location = New System.Drawing.Point(697, 65)
        Me.idartstof.Name = "idartstof"
        Me.idartstof.Size = New System.Drawing.Size(209, 20)
        Me.idartstof.TabIndex = 19
        '
        'idarttyp
        '
        Me.idarttyp.Location = New System.Drawing.Point(697, 39)
        Me.idarttyp.Name = "idarttyp"
        Me.idarttyp.Size = New System.Drawing.Size(209, 20)
        Me.idarttyp.TabIndex = 18
        '
        'idartsrt
        '
        Me.idartsrt.Location = New System.Drawing.Point(697, 13)
        Me.idartsrt.Name = "idartsrt"
        Me.idartsrt.Size = New System.Drawing.Size(209, 20)
        Me.idartsrt.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(659, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Stof"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(659, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(659, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Soort"
        '
        'Artnr
        '
        Me.Artnr.Location = New System.Drawing.Point(112, 13)
        Me.Artnr.Name = "Artnr"
        Me.Artnr.Size = New System.Drawing.Size(209, 20)
        Me.Artnr.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Artikelnummer"
        '
        'artdoos
        '
        Me.artdoos.Location = New System.Drawing.Point(440, 65)
        Me.artdoos.Name = "artdoos"
        Me.artdoos.Size = New System.Drawing.Size(209, 20)
        Me.artdoos.TabIndex = 11
        '
        'artverp
        '
        Me.artverp.Location = New System.Drawing.Point(440, 39)
        Me.artverp.Name = "artverp"
        Me.artverp.Size = New System.Drawing.Size(209, 20)
        Me.artverp.TabIndex = 10
        '
        'artloop
        '
        Me.artloop.Location = New System.Drawing.Point(440, 13)
        Me.artloop.Name = "artloop"
        Me.artloop.Size = New System.Drawing.Size(209, 20)
        Me.artloop.TabIndex = 9
        '
        'artmaat
        '
        Me.artmaat.Location = New System.Drawing.Point(112, 66)
        Me.artmaat.Name = "artmaat"
        Me.artmaat.Size = New System.Drawing.Size(209, 20)
        Me.artmaat.TabIndex = 8
        '
        'artoms
        '
        Me.artoms.Location = New System.Drawing.Point(112, 39)
        Me.artoms.Name = "artoms"
        Me.artoms.Size = New System.Drawing.Size(209, 20)
        Me.artoms.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Doosmaat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(334, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Verpakkingseenheid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Loopmeters"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Maat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Omschrijving"
        '
        'UCArtikelen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KnopZoek)
        Me.Controls.Add(Me.KnopNieuw)
        Me.Controls.Add(Me.KnopLeegmaken)
        Me.Controls.Add(Me.KnopOnderhoud)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ArtDataGridView)
        Me.Name = "UCArtikelen"
        Me.Size = New System.Drawing.Size(1197, 441)
        CType(Me.ArtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ArtDataGridView As DataGridView
    Friend WithEvents KnopZoek As Button
    Friend WithEvents KnopNieuw As Button
    Friend WithEvents KnopLeegmaken As Button
    Friend WithEvents KnopOnderhoud As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Artnr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents artdoos As TextBox
    Friend WithEvents artverp As TextBox
    Friend WithEvents artloop As TextBox
    Friend WithEvents artmaat As TextBox
    Friend WithEvents artoms As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idartstof As TextBox
    Friend WithEvents idarttyp As TextBox
    Friend WithEvents idartsrt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents idartsupp As TextBox
    Friend WithEvents Label10 As Label
End Class
