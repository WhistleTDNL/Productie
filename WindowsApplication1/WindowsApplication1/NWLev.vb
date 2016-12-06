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
        TxtNwLevLand.Text = ""
        TxtNwLevNr.Text = ""
    End Sub



    Private Sub KnopNwLevOpslaan_Click(sender As Object, e As EventArgs) Handles KnopNwLevOpslaan.Click
        Dim NwLevNaam As String = TxtNwLevNaam.Text
        Dim NwLevAdres As String = TxtNwLevAdres.Text
        Dim NwLevPC As String = TxtNwLevPc.Text
        Dim NwLevPlaats As String = TxtNwLevPlaats.Text
        Dim NwLevLand As String = TxtNwLevLand.Text
        Dim sql As String = "INSERT INTO Leveranciers (levnaam, levadres, levpc, levwoonplaats, levland) VALUES (@NwLevnaam, @NwLevadres, @NwLevpc, @NwLevplaats, @NwLevland)"

        Using myConnection
            Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                myConnection.Open()
                sqlcom.Parameters.Add("@NwLevnaam", OleDb.OleDbType.VarChar).Value = NwLevNaam
                sqlcom.Parameters.Add("@NwLevadres", OleDb.OleDbType.VarChar).Value = NwLevAdres
                sqlcom.Parameters.Add("@NwLevpc", OleDb.OleDbType.VarChar).Value = NwLevPC
                sqlcom.Parameters.Add("@NwLevplaats", OleDb.OleDbType.VarChar).Value = NwLevPlaats
                sqlcom.Parameters.Add("@NwLevland", OleDb.OleDbType.VarChar).Value = NwLevLand
                Dim icount As Integer = sqlcom.ExecuteNonQuery()
                MsgBox(icount & " Nieuwe klant aangemaakt")
            End Using
        End Using

        Me.Close()
    End Sub

    Private Sub KnopNwLevSluiten_Click(sender As Object, e As EventArgs) Handles KnopNwLevSluiten.Click
        Me.Close()
    End Sub

End Class