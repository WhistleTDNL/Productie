Public Class NWLev

    Dim ds As DataSet = New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()

    Private Sub KnopNwLevLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopNwLevLeegmaken.Click
        TxtNwLevAdres.Text = ""
        TxtNwLevNaam.Text = ""
        TxtNwLevPc.Text = ""
        TxtNwLevPlaats.Text = ""
        BoxNwLevLand.Text = ""
        TxtNwLevNr.Text = ""
    End Sub



    Private Sub KnopNwLevOpslaan_Click(sender As Object, e As EventArgs) Handles KnopNwLevOpslaan.Click
        Dim NwLevNaam As String = TxtNwLevNaam.Text
        Dim NwLevAdres As String = TxtNwLevAdres.Text
        Dim NwLevPC As String = TxtNwLevPc.Text
        Dim NwLevPlaats As String = TxtNwLevPlaats.Text
        Dim NwLevLand As String = BoxNwLevLand.SelectedValue
        Dim sql As String = "INSERT INTO Lev (levnaam, levadres, levpc, levwoon, levlandid) VALUES (?, ?, ?, ?, ?)"
        myConnection.ConnectionString = My.Settings.DBPATH
        Using myConnection
            Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                myConnection.Open()
                sqlcom.Parameters.Add("@NwLevnaam", OleDb.OleDbType.VarChar).Value = NwLevNaam
                sqlcom.Parameters.Add("@NwLevadres", OleDb.OleDbType.VarChar).Value = NwLevAdres
                sqlcom.Parameters.Add("@NwLevpc", OleDb.OleDbType.VarChar).Value = NwLevPC
                sqlcom.Parameters.Add("@NwLevplaats", OleDb.OleDbType.VarChar).Value = NwLevPlaats
                sqlcom.Parameters.Add("@NwLevland", OleDb.OleDbType.Integer).Value = NwLevLand
                Dim icount As Integer = sqlcom.ExecuteNonQuery()
                MsgBox(icount & " Nieuwe leverancier aangemaakt")
            End Using
        End Using

        Me.Close()
    End Sub

    Private Sub KnopNwLevSluiten_Click(sender As Object, e As EventArgs) Handles KnopNwLevSluiten.Click
        Me.Close()
    End Sub

    Private Sub NWLev_Load(sender As Object, e As EventArgs) Handles Me.Load
        myConnection.ConnectionString = My.Settings.DBPATH
        Dim query As String = "select * from landen"
        Using myConnection
            myConnection.Open()
            Using sqlcom = New OleDbCommand(query, myConnection)
                Dim rs As OleDbDataReader = sqlcom.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                BoxNwLevLand.ValueMember = "idlanden"
                BoxNwLevLand.DisplayMember = "landoms"
                BoxNwLevLand.DataSource = dt
            End Using
        End Using
    End Sub
End Class