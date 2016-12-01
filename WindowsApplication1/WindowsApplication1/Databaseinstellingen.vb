Module Databaseinstellingen

    Public DatabaseServer As String = My.Settings.DBServer
    Public DatabaseDatabase As String = My.Settings.DBDatabase
    Public DatabaseUser As String = My.Settings.DBUser
    Public DatabasePassword As String = My.Settings.DBPassword
    Public DatabaseType As Integer = My.Settings.DBType
#If databasetype = 0 Then
    Public DBPath As String = "Provider=" & DatabaseServer & ";Data Source =" & DatabaseDatabase
#ElseIf databasetype = 1 Then
    Public DBPath As String = "Server="&DatabaseServer&";Database="&DatabaseDatabase&";User Id="&DatabaseUser&";Password="&DatabasePassword&";"
#ElseIf databasetype = 2 Then
    Public DBPath As String = "Server="&DatabaseServer&";Database="&DatabaseDatabase&";Uid="&DatabaseUser&";Pwd="&DatabasePassword&";"
#End If
    Public myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection


End Module
