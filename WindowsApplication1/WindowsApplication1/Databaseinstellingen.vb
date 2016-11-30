Module Databaseinstellingen

    Public DatabaseServer As String = ""
    Public DatabaseProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Public DatabaseDataSource As String = "E:\Dev\Werk\ProductieLM.accdb"
    Public DatabaseCatalog As String = ""
    Public DatabaseIntegratedSecurity = False
    Public DatabaseTrustedConnection = False
    Public DatabaseType As String = "ACCESS"
    Public DBPath As String = DatabaseProvider & DatabaseDataSource
    Public Con As System.Data.OleDb.OleDbConnection
    Public provider As String
    Public dataFile As String
    Public connString As String
    Public myConnection As OleDb.OleDbConnection = New OleDb.OleDbConnection

End Module
