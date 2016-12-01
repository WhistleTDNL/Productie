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
        Me.DataBaseSetting = New System.Windows.Forms.TabControl()
        Me.DBTypeAccess = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MSAccessDatasource = New System.Windows.Forms.TextBox()
        Me.MSAccessProvider = New System.Windows.Forms.TextBox()
        Me.DBTypeMSSQL = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MSSQLPassword = New System.Windows.Forms.TextBox()
        Me.MSSQLUser = New System.Windows.Forms.TextBox()
        Me.MSSQLDatabase = New System.Windows.Forms.TextBox()
        Me.MSSQLServer = New System.Windows.Forms.TextBox()
        Me.DBTypeMySQL = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MySQLPassword = New System.Windows.Forms.TextBox()
        Me.MySQLUser = New System.Windows.Forms.TextBox()
        Me.MySQLDatabase = New System.Windows.Forms.TextBox()
        Me.MySQLServer = New System.Windows.Forms.TextBox()
        Me.KnopSluiten = New System.Windows.Forms.Button()
        Me.KnopOpslaan = New System.Windows.Forms.Button()
        Me.DataBaseSetting.SuspendLayout()
        Me.DBTypeAccess.SuspendLayout()
        Me.DBTypeMSSQL.SuspendLayout()
        Me.DBTypeMySQL.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataBaseSetting
        '
        Me.DataBaseSetting.Controls.Add(Me.DBTypeAccess)
        Me.DataBaseSetting.Controls.Add(Me.DBTypeMSSQL)
        Me.DataBaseSetting.Controls.Add(Me.DBTypeMySQL)
        Me.DataBaseSetting.Location = New System.Drawing.Point(12, 12)
        Me.DataBaseSetting.Name = "DataBaseSetting"
        Me.DataBaseSetting.SelectedIndex = 0
        Me.DataBaseSetting.Size = New System.Drawing.Size(356, 171)
        Me.DataBaseSetting.TabIndex = 0
        '
        'DBTypeAccess
        '
        Me.DBTypeAccess.Controls.Add(Me.Label11)
        Me.DBTypeAccess.Controls.Add(Me.Label12)
        Me.DBTypeAccess.Controls.Add(Me.MSAccessDatasource)
        Me.DBTypeAccess.Controls.Add(Me.MSAccessProvider)
        Me.DBTypeAccess.Location = New System.Drawing.Point(4, 22)
        Me.DBTypeAccess.Name = "DBTypeAccess"
        Me.DBTypeAccess.Padding = New System.Windows.Forms.Padding(3)
        Me.DBTypeAccess.Size = New System.Drawing.Size(348, 145)
        Me.DBTypeAccess.TabIndex = 0
        Me.DBTypeAccess.Text = "MS Access"
        Me.DBTypeAccess.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Datasource"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Provider"
        '
        'MSAccessDatasource
        '
        Me.MSAccessDatasource.Location = New System.Drawing.Point(76, 33)
        Me.MSAccessDatasource.Name = "MSAccessDatasource"
        Me.MSAccessDatasource.Size = New System.Drawing.Size(266, 20)
        Me.MSAccessDatasource.TabIndex = 33
        '
        'MSAccessProvider
        '
        Me.MSAccessProvider.Location = New System.Drawing.Point(76, 6)
        Me.MSAccessProvider.Name = "MSAccessProvider"
        Me.MSAccessProvider.Size = New System.Drawing.Size(266, 20)
        Me.MSAccessProvider.TabIndex = 32
        '
        'DBTypeMSSQL
        '
        Me.DBTypeMSSQL.Controls.Add(Me.Label5)
        Me.DBTypeMSSQL.Controls.Add(Me.Label4)
        Me.DBTypeMSSQL.Controls.Add(Me.Label3)
        Me.DBTypeMSSQL.Controls.Add(Me.Label2)
        Me.DBTypeMSSQL.Controls.Add(Me.MSSQLPassword)
        Me.DBTypeMSSQL.Controls.Add(Me.MSSQLUser)
        Me.DBTypeMSSQL.Controls.Add(Me.MSSQLDatabase)
        Me.DBTypeMSSQL.Controls.Add(Me.MSSQLServer)
        Me.DBTypeMSSQL.Location = New System.Drawing.Point(4, 22)
        Me.DBTypeMSSQL.Name = "DBTypeMSSQL"
        Me.DBTypeMSSQL.Padding = New System.Windows.Forms.Padding(3)
        Me.DBTypeMSSQL.Size = New System.Drawing.Size(348, 145)
        Me.DBTypeMSSQL.TabIndex = 1
        Me.DBTypeMSSQL.Text = "MS SQL"
        Me.DBTypeMSSQL.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Server"
        '
        'MSSQLPassword
        '
        Me.MSSQLPassword.Location = New System.Drawing.Point(63, 103)
        Me.MSSQLPassword.Name = "MSSQLPassword"
        Me.MSSQLPassword.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLPassword.TabIndex = 27
        '
        'MSSQLUser
        '
        Me.MSSQLUser.Location = New System.Drawing.Point(63, 76)
        Me.MSSQLUser.Name = "MSSQLUser"
        Me.MSSQLUser.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLUser.TabIndex = 26
        '
        'MSSQLDatabase
        '
        Me.MSSQLDatabase.Location = New System.Drawing.Point(63, 49)
        Me.MSSQLDatabase.Name = "MSSQLDatabase"
        Me.MSSQLDatabase.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLDatabase.TabIndex = 25
        '
        'MSSQLServer
        '
        Me.MSSQLServer.Location = New System.Drawing.Point(63, 22)
        Me.MSSQLServer.Name = "MSSQLServer"
        Me.MSSQLServer.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLServer.TabIndex = 24
        '
        'DBTypeMySQL
        '
        Me.DBTypeMySQL.Controls.Add(Me.Label1)
        Me.DBTypeMySQL.Controls.Add(Me.Label6)
        Me.DBTypeMySQL.Controls.Add(Me.Label7)
        Me.DBTypeMySQL.Controls.Add(Me.Label8)
        Me.DBTypeMySQL.Controls.Add(Me.MySQLPassword)
        Me.DBTypeMySQL.Controls.Add(Me.MySQLUser)
        Me.DBTypeMySQL.Controls.Add(Me.MySQLDatabase)
        Me.DBTypeMySQL.Controls.Add(Me.MySQLServer)
        Me.DBTypeMySQL.Location = New System.Drawing.Point(4, 22)
        Me.DBTypeMySQL.Name = "DBTypeMySQL"
        Me.DBTypeMySQL.Size = New System.Drawing.Size(348, 145)
        Me.DBTypeMySQL.TabIndex = 2
        Me.DBTypeMySQL.Text = "My SQL"
        Me.DBTypeMySQL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Database"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Server"
        '
        'MySQLPassword
        '
        Me.MySQLPassword.Location = New System.Drawing.Point(66, 103)
        Me.MySQLPassword.Name = "MySQLPassword"
        Me.MySQLPassword.Size = New System.Drawing.Size(279, 20)
        Me.MySQLPassword.TabIndex = 35
        '
        'MySQLUser
        '
        Me.MySQLUser.Location = New System.Drawing.Point(66, 76)
        Me.MySQLUser.Name = "MySQLUser"
        Me.MySQLUser.Size = New System.Drawing.Size(279, 20)
        Me.MySQLUser.TabIndex = 34
        '
        'MySQLDatabase
        '
        Me.MySQLDatabase.Location = New System.Drawing.Point(66, 49)
        Me.MySQLDatabase.Name = "MySQLDatabase"
        Me.MySQLDatabase.Size = New System.Drawing.Size(279, 20)
        Me.MySQLDatabase.TabIndex = 33
        '
        'MySQLServer
        '
        Me.MySQLServer.Location = New System.Drawing.Point(66, 22)
        Me.MySQLServer.Name = "MySQLServer"
        Me.MySQLServer.Size = New System.Drawing.Size(279, 20)
        Me.MySQLServer.TabIndex = 32
        '
        'KnopSluiten
        '
        Me.KnopSluiten.Location = New System.Drawing.Point(289, 185)
        Me.KnopSluiten.Name = "KnopSluiten"
        Me.KnopSluiten.Size = New System.Drawing.Size(75, 23)
        Me.KnopSluiten.TabIndex = 23
        Me.KnopSluiten.Text = "Sluiten"
        Me.KnopSluiten.UseVisualStyleBackColor = True
        '
        'KnopOpslaan
        '
        Me.KnopOpslaan.Location = New System.Drawing.Point(12, 185)
        Me.KnopOpslaan.Name = "KnopOpslaan"
        Me.KnopOpslaan.Size = New System.Drawing.Size(75, 23)
        Me.KnopOpslaan.TabIndex = 22
        Me.KnopOpslaan.Text = "Opslaan"
        Me.KnopOpslaan.UseVisualStyleBackColor = True
        '
        'OptiesDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 220)
        Me.Controls.Add(Me.DataBaseSetting)
        Me.Controls.Add(Me.KnopOpslaan)
        Me.Controls.Add(Me.KnopSluiten)
        Me.Name = "OptiesDatabase"
        Me.Text = "OptiesDatabase"
        Me.DataBaseSetting.ResumeLayout(False)
        Me.DBTypeAccess.ResumeLayout(False)
        Me.DBTypeAccess.PerformLayout()
        Me.DBTypeMSSQL.ResumeLayout(False)
        Me.DBTypeMSSQL.PerformLayout()
        Me.DBTypeMySQL.ResumeLayout(False)
        Me.DBTypeMySQL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataBaseSetting As TabControl
    Friend WithEvents DBTypeAccess As TabPage
    Friend WithEvents DBTypeMSSQL As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MSSQLPassword As TextBox
    Friend WithEvents MSSQLUser As TextBox
    Friend WithEvents MSSQLDatabase As TextBox
    Friend WithEvents MSSQLServer As TextBox
    Friend WithEvents KnopSluiten As Button
    Friend WithEvents KnopOpslaan As Button
    Friend WithEvents DBTypeMySQL As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MSAccessDatasource As TextBox
    Friend WithEvents MSAccessProvider As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MySQLPassword As TextBox
    Friend WithEvents MySQLUser As TextBox
    Friend WithEvents MySQLDatabase As TextBox
    Friend WithEvents MySQLServer As TextBox
End Class
