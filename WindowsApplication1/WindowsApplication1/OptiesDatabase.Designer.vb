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
        Me.KnopSluiten = New System.Windows.Forms.Button()
        Me.KnopOpslaan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DBTypeMSSQL = New System.Windows.Forms.TabPage()
        Me.MSSQLServer = New System.Windows.Forms.TextBox()
        Me.MSSQLDatabase = New System.Windows.Forms.TextBox()
        Me.MSSQLUser = New System.Windows.Forms.TextBox()
        Me.MSSQLPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DBTypeAccess = New System.Windows.Forms.TabPage()
        Me.MSAccessProvider = New System.Windows.Forms.TextBox()
        Me.MSAccessDatasource = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataBaseSetting = New System.Windows.Forms.TabControl()
        Me.MSSQLSec = New System.Windows.Forms.CheckBox()
        Me.DBTypeMSSQL.SuspendLayout()
        Me.DBTypeAccess.SuspendLayout()
        Me.DataBaseSetting.SuspendLayout()
        Me.SuspendLayout()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Test verbinding"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DBTypeMSSQL
        '
        Me.DBTypeMSSQL.Controls.Add(Me.MSSQLSec)
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
        'MSSQLServer
        '
        Me.MSSQLServer.Location = New System.Drawing.Point(63, 22)
        Me.MSSQLServer.Name = "MSSQLServer"
        Me.MSSQLServer.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLServer.TabIndex = 24
        '
        'MSSQLDatabase
        '
        Me.MSSQLDatabase.Location = New System.Drawing.Point(63, 49)
        Me.MSSQLDatabase.Name = "MSSQLDatabase"
        Me.MSSQLDatabase.Size = New System.Drawing.Size(279, 20)
        Me.MSSQLDatabase.TabIndex = 25
        '
        'MSSQLUser
        '
        Me.MSSQLUser.Location = New System.Drawing.Point(63, 102)
        Me.MSSQLUser.Name = "MSSQLUser"
        Me.MSSQLUser.Size = New System.Drawing.Size(94, 20)
        Me.MSSQLUser.TabIndex = 26
        '
        'MSSQLPassword
        '
        Me.MSSQLPassword.Location = New System.Drawing.Point(231, 102)
        Me.MSSQLPassword.Name = "MSSQLPassword"
        Me.MSSQLPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MSSQLPassword.Size = New System.Drawing.Size(111, 20)
        Me.MSSQLPassword.TabIndex = 27
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Database"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Password"
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
        'MSAccessProvider
        '
        Me.MSAccessProvider.Location = New System.Drawing.Point(76, 6)
        Me.MSAccessProvider.Name = "MSAccessProvider"
        Me.MSAccessProvider.Size = New System.Drawing.Size(266, 20)
        Me.MSAccessProvider.TabIndex = 32
        '
        'MSAccessDatasource
        '
        Me.MSAccessDatasource.Location = New System.Drawing.Point(76, 33)
        Me.MSAccessDatasource.Name = "MSAccessDatasource"
        Me.MSAccessDatasource.Size = New System.Drawing.Size(266, 20)
        Me.MSAccessDatasource.TabIndex = 33
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Datasource"
        '
        'DataBaseSetting
        '
        Me.DataBaseSetting.Controls.Add(Me.DBTypeAccess)
        Me.DataBaseSetting.Controls.Add(Me.DBTypeMSSQL)
        Me.DataBaseSetting.Location = New System.Drawing.Point(12, 12)
        Me.DataBaseSetting.Name = "DataBaseSetting"
        Me.DataBaseSetting.SelectedIndex = 0
        Me.DataBaseSetting.Size = New System.Drawing.Size(356, 171)
        Me.DataBaseSetting.TabIndex = 0
        '
        'MSSQLSec
        '
        Me.MSSQLSec.AutoSize = True
        Me.MSSQLSec.Checked = True
        Me.MSSQLSec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MSSQLSec.Location = New System.Drawing.Point(63, 77)
        Me.MSSQLSec.Name = "MSSQLSec"
        Me.MSSQLSec.Size = New System.Drawing.Size(115, 17)
        Me.MSSQLSec.TabIndex = 32
        Me.MSSQLSec.Text = "Integrated Security"
        Me.MSSQLSec.UseVisualStyleBackColor = True
        '
        'OptiesDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 220)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataBaseSetting)
        Me.Controls.Add(Me.KnopOpslaan)
        Me.Controls.Add(Me.KnopSluiten)
        Me.Name = "OptiesDatabase"
        Me.Text = "OptiesDatabase"
        Me.DBTypeMSSQL.ResumeLayout(False)
        Me.DBTypeMSSQL.PerformLayout()
        Me.DBTypeAccess.ResumeLayout(False)
        Me.DBTypeAccess.PerformLayout()
        Me.DataBaseSetting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KnopSluiten As Button
    Friend WithEvents KnopOpslaan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DBTypeMSSQL As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MSSQLPassword As TextBox
    Friend WithEvents MSSQLUser As TextBox
    Friend WithEvents MSSQLDatabase As TextBox
    Friend WithEvents MSSQLServer As TextBox
    Friend WithEvents DBTypeAccess As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MSAccessDatasource As TextBox
    Friend WithEvents MSAccessProvider As TextBox
    Friend WithEvents DataBaseSetting As TabControl
    Friend WithEvents MSSQLSec As CheckBox
End Class
