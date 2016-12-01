Public Class OptiesDatabase
    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        My.Settings.DBType = DataBaseSetting.SelectedIndex
        If DataBaseSetting.SelectedIndex = 0 Then
            My.Settings.DBServer = MSAccessProvider.Text
            My.Settings.DBDatabase = MSAccessDatasource.Text
        ElseIf DataBaseSetting.SelectedIndex = 1 Then
            My.Settings.DBServer = MSSQLServer.Text
            My.Settings.DBDatabase = MSSQLDatabase.Text
            My.Settings.DBUser = MSSQLUser.Text
            My.Settings.DBPassword = MSSQLPassword.Text
        ElseIf DataBaseSetting.SelectedIndex = 2 Then
            My.Settings.DBServer = MySQLServer.Text
            My.Settings.DBDatabase = MySQLServer.Text
            My.Settings.DBUser = MySQLUser.Text
            My.Settings.DBPassword = MySQLPassword.Text
        End If
    End Sub

    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub OptiesDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim SelTab As Integer = My.Settings.DBType
        DataBaseSetting.SelectTab(SelTab)
        If SelTab = 0 Then
            MSAccessProvider.Text = My.Settings.DBServer
            MSAccessDatasource.Text = My.Settings.DBDatabase
        ElseIf SelTab = 1 Then
            MSSQLServer.Text = My.Settings.DBServer
            MSSQLDatabase.Text = My.Settings.DBDatabase
            MSSQLUser.Text = My.Settings.DBUser
            MSSQLPassword.Text = My.Settings.DBPassword
        ElseIf SelTab = 2 Then
            MySQLServer.Text = My.Settings.DBServer
            MySQLServer.Text = My.Settings.DBDatabase
            MySQLUser.Text = My.Settings.DBUser
            MySQLPassword.Text = My.Settings.DBPassword
        End If
    End Sub
End Class