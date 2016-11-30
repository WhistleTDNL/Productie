<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptiesDatabase
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
        Me.TxtDatabaseServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDatabaseDataSource = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDatabaseCatalog = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDatabaseProvider = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxIntegratedSecurity = New System.Windows.Forms.CheckBox()
        Me.KnopOpslaan = New System.Windows.Forms.Button()
        Me.KnopSluiten = New System.Windows.Forms.Button()
        Me.CheckBoxTrustedConnection = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioKnopAccess = New System.Windows.Forms.RadioButton()
        Me.RadioknopMSSQL = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDatabaseDataSource2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDatabaseProvider2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDatabaseServer
        '
        Me.TxtDatabaseServer.Location = New System.Drawing.Point(308, 36)
        Me.TxtDatabaseServer.Name = "TxtDatabaseServer"
        Me.TxtDatabaseServer.Size = New System.Drawing.Size(132, 20)
        Me.TxtDatabaseServer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Datasource"
        '
        'TxtDatabaseDataSource
        '
        Me.TxtDatabaseDataSource.Location = New System.Drawing.Point(308, 62)
        Me.TxtDatabaseDataSource.Name = "TxtDatabaseDataSource"
        Me.TxtDatabaseDataSource.Size = New System.Drawing.Size(132, 20)
        Me.TxtDatabaseDataSource.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Initial Catalog"
        '
        'TxtDatabaseCatalog
        '
        Me.TxtDatabaseCatalog.Location = New System.Drawing.Point(308, 88)
        Me.TxtDatabaseCatalog.Name = "TxtDatabaseCatalog"
        Me.TxtDatabaseCatalog.Size = New System.Drawing.Size(132, 20)
        Me.TxtDatabaseCatalog.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Provider"
        '
        'TxtDatabaseProvider
        '
        Me.TxtDatabaseProvider.Location = New System.Drawing.Point(308, 114)
        Me.TxtDatabaseProvider.Name = "TxtDatabaseProvider"
        Me.TxtDatabaseProvider.Size = New System.Drawing.Size(132, 20)
        Me.TxtDatabaseProvider.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Integrated Security"
        '
        'CheckBoxIntegratedSecurity
        '
        Me.CheckBoxIntegratedSecurity.AutoSize = True
        Me.CheckBoxIntegratedSecurity.Location = New System.Drawing.Point(118, 137)
        Me.CheckBoxIntegratedSecurity.Name = "CheckBoxIntegratedSecurity"
        Me.CheckBoxIntegratedSecurity.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxIntegratedSecurity.TabIndex = 10
        Me.CheckBoxIntegratedSecurity.UseVisualStyleBackColor = True
        '
        'KnopOpslaan
        '
        Me.KnopOpslaan.Location = New System.Drawing.Point(145, 181)
        Me.KnopOpslaan.Name = "KnopOpslaan"
        Me.KnopOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.KnopOpslaan.TabIndex = 11
        Me.KnopOpslaan.Text = "Opslaan"
        Me.KnopOpslaan.UseVisualStyleBackColor = True
        '
        'KnopSluiten
        '
        Me.KnopSluiten.Location = New System.Drawing.Point(6, 181)
        Me.KnopSluiten.Name = "KnopSluiten"
        Me.KnopSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopSluiten.TabIndex = 12
        Me.KnopSluiten.Text = "Sluiten"
        Me.KnopSluiten.UseVisualStyleBackColor = True
        '
        'CheckBoxTrustedConnection
        '
        Me.CheckBoxTrustedConnection.AutoSize = True
        Me.CheckBoxTrustedConnection.Location = New System.Drawing.Point(118, 157)
        Me.CheckBoxTrustedConnection.Name = "CheckBoxTrustedConnection"
        Me.CheckBoxTrustedConnection.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTrustedConnection.TabIndex = 13
        Me.CheckBoxTrustedConnection.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Trusted Connection"
        '
        'RadioKnopAccess
        '
        Me.RadioKnopAccess.AutoSize = True
        Me.RadioKnopAccess.Checked = True
        Me.RadioKnopAccess.Location = New System.Drawing.Point(12, 8)
        Me.RadioKnopAccess.Name = "RadioKnopAccess"
        Me.RadioKnopAccess.Size = New System.Drawing.Size(60, 17)
        Me.RadioKnopAccess.TabIndex = 15
        Me.RadioKnopAccess.TabStop = True
        Me.RadioKnopAccess.Text = "Access"
        Me.RadioKnopAccess.UseVisualStyleBackColor = True
        '
        'RadioknopMSSQL
        '
        Me.RadioknopMSSQL.AutoSize = True
        Me.RadioknopMSSQL.Location = New System.Drawing.Point(240, 13)
        Me.RadioknopMSSQL.Name = "RadioknopMSSQL"
        Me.RadioknopMSSQL.Size = New System.Drawing.Size(92, 17)
        Me.RadioknopMSSQL.TabIndex = 16
        Me.RadioknopMSSQL.TabStop = True
        Me.RadioknopMSSQL.Text = "Microsoft SQL"
        Me.RadioknopMSSQL.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Datasource"
        '
        'TxtDatabaseDataSource2
        '
        Me.TxtDatabaseDataSource2.Location = New System.Drawing.Point(90, 31)
        Me.TxtDatabaseDataSource2.Name = "TxtDatabaseDataSource2"
        Me.TxtDatabaseDataSource2.Size = New System.Drawing.Size(127, 20)
        Me.TxtDatabaseDataSource2.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Provider"
        '
        'TxtDatabaseProvider2
        '
        Me.TxtDatabaseProvider2.Location = New System.Drawing.Point(90, 57)
        Me.TxtDatabaseProvider2.Name = "TxtDatabaseProvider2"
        Me.TxtDatabaseProvider2.Size = New System.Drawing.Size(127, 20)
        Me.TxtDatabaseProvider2.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtDatabaseProvider2)
        Me.GroupBox1.Controls.Add(Me.KnopOpslaan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtDatabaseDataSource2)
        Me.GroupBox1.Controls.Add(Me.RadioKnopAccess)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 207)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxTrustedConnection)
        Me.GroupBox2.Controls.Add(Me.CheckBoxIntegratedSecurity)
        Me.GroupBox2.Controls.Add(Me.KnopSluiten)
        Me.GroupBox2.Location = New System.Drawing.Point(231, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 207)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'OptiesDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 222)
        Me.Controls.Add(Me.RadioknopMSSQL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDatabaseProvider)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDatabaseCatalog)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDatabaseDataSource)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDatabaseServer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "OptiesDatabase"
        Me.Text = "OptiesDatabase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDatabaseServer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDatabaseDataSource As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDatabaseCatalog As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDatabaseProvider As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBoxIntegratedSecurity As CheckBox
    Friend WithEvents KnopOpslaan As Button
    Friend WithEvents KnopSluiten As Button
    Friend WithEvents CheckBoxTrustedConnection As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioKnopAccess As RadioButton
    Friend WithEvents RadioknopMSSQL As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDatabaseDataSource2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDatabaseProvider2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
