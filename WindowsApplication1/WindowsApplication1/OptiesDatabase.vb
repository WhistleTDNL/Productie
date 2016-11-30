Public Class OptiesDatabase
    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        If DatabaseType = "MSSQL" Then
            DatabaseServer = TxtDatabaseServer.Text
            DatabaseProvider = TxtDatabaseProvider.Text
            DatabaseCatalog = TxtDatabaseCatalog.Text
            DatabaseDataSource = TxtDatabaseDataSource.Text
            DatabaseIntegratedSecurity = CheckBoxIntegratedSecurity
            DatabaseTrustedConnection = CheckBoxTrustedConnection
        Else
            DatabaseProvider = TxtDatabaseProvider2.Text
            DatabaseDataSource = TxtDatabaseDataSource2.Text
        End If
    End Sub

    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub OptiesDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DatabaseType = "ACCESS" Then
            TxtDatabaseProvider2.Text = DatabaseProvider
            TxtDatabaseDataSource2.Text = DatabaseDataSource
            RadioknopMSSQL.Checked = False
            RadioKnopAccess.Checked = True
            TxtDatabaseServer.Enabled = False
            TxtDatabaseProvider.Enabled = False
            TxtDatabaseDataSource.Enabled = False
            TxtDatabaseCatalog.Enabled = False
            CheckBoxIntegratedSecurity.Enabled = False
            CheckBoxTrustedConnection.Enabled = False
        ElseIf DatabaseType = "MSSQL" Then
            TxtDatabaseServer.Text = DatabaseServer
            TxtDatabaseProvider.Text = DatabaseProvider
            TxtDatabaseCatalog.Text = DatabaseCatalog
            TxtDatabaseDataSource.Text = DatabaseDataSource
            CheckBoxIntegratedSecurity = DatabaseIntegratedSecurity
            CheckBoxTrustedConnection = DatabaseTrustedConnection
            RadioknopMSSQL.Checked = True
            RadioKnopAccess.Checked = False
            TxtDatabaseDataSource2.Enabled = False
            TxtDatabaseProvider2.Enabled = False
        End If
    End Sub

    Private Sub RadioKnopAccess_Click(sender As Object, e As EventArgs) Handles RadioKnopAccess.Click
        TxtDatabaseServer.Enabled = False
        TxtDatabaseProvider.Enabled = False
        TxtDatabaseDataSource.Enabled = False
        TxtDatabaseCatalog.Enabled = False
        CheckBoxIntegratedSecurity.Enabled = False
        CheckBoxTrustedConnection.Enabled = False
        TxtDatabaseDataSource2.Enabled = True
        TxtDatabaseProvider2.Enabled = True
        RadioknopMSSQL.Checked = False
        DatabaseType = "ACCESS"
        DatabaseServer = ""
        DatabaseProvider = ""
        DatabaseDataSource = ""
        DatabaseCatalog = ""
        DatabaseIntegratedSecurity = False
        DatabaseTrustedConnection = False
        DatabaseType = ""
    End Sub

    Private Sub RadioknopMSSQL_Click(sender As Object, e As EventArgs) Handles RadioknopMSSQL.Click
        TxtDatabaseServer.Enabled = True
        TxtDatabaseProvider.Enabled = True
        TxtDatabaseDataSource.Enabled = True
        TxtDatabaseCatalog.Enabled = True
        CheckBoxIntegratedSecurity.Enabled = True
        CheckBoxTrustedConnection.Enabled = True
        TxtDatabaseDataSource2.Enabled = False
        TxtDatabaseProvider2.Enabled = False
        RadioKnopAccess.Checked = False
        DatabaseType = "MSSQL"
    End Sub
End Class