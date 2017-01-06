Public Class OptiesDatabase



    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        My.Settings.DBType = DataBaseSetting.SelectedIndex
        If DataBaseSetting.SelectedIndex = 0 Then
            My.Settings.DBServer = MSAccessProvider.Text
            My.Settings.DBDatabase = MSAccessDatasource.Text
        ElseIf DataBaseSetting.SelectedIndex = 1 Then
            My.Settings.DBServer = MSSQLServer.Text
            My.Settings.DBDatabase = MSSQLDatabase.Text
            My.Settings.DBSSLI = MSSQLSec.CheckState
            My.Settings.DBUser = MSSQLUser.Text
            My.Settings.DBPassword = MSSQLPassword.Text
        End If

        Dim DatabaseServer As String = My.Settings.DBServer
        Dim DatabaseDatabase As String = My.Settings.DBDatabase
        Dim DatabaseUser As String = My.Settings.DBUser
        Dim DatabasePassword As String = My.Settings.DBPassword
        Dim DatabaseType As Integer = My.Settings.DBType
        If DatabaseType = 0 Then
            My.Settings.DBPATH = "Provider=" & DatabaseServer & ";Data Source =" & DatabaseDatabase
        ElseIf databasetype = 1 Then
            My.Settings.DBPATH = "Provider=SQLOLEDB; Server=" & DatabaseServer & ";Database=" & DatabaseDatabase & "; Integrated Security=SSPI;"
        End If
    End Sub



    Function TestConn() As Boolean
        Try
            myConnection.ConnectionString = My.Settings.DBPATH
            myConnection.Open()
            myConnection.Close()
            Return True
        Catch ex As Exception
            MsgBox("Cannot connect to database")
            Return False
        End Try
    End Function

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
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testmyConn As Boolean
        testmyConn = TestConn()
        If testmyConn Then
            MsgBox("Connection Succeeded")
        Else
            MsgBox("Connection failed")
        End If
    End Sub

    Private Sub MSSQLSec_CheckedChanged(sender As Object, e As EventArgs) Handles MSSQLSec.CheckedChanged
        If MSSQLSec.Checked = True Then
            MSSQLUser.Enabled = False
            MSSQLPassword.Enabled = False
        ElseIf MSSQLSec.Checked = False Then
            MSSQLUser.Enabled = True
            MSSQLPassword.Enabled = True
        End If
    End Sub
End Class