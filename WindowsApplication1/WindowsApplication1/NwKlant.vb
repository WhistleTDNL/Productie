Public Class NwKlant

    Dim ds As DataSet = New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()

    Private Sub KnopNwKlantLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopNwKlantLeegmaken.Click
        TxtNwKlantNr.Text = ""
        TxtNwKlantNaam.Text = ""
        TxtNwKlantAdres.Text = ""
        TxtNwKlantPc.Text = ""
        TxtNwKlantPlaats.Text = ""
        TxtNwKlantLand.Text = ""
    End Sub



    Private Sub KnopNwKlantOpslaan_Click(sender As Object, e As EventArgs) Handles KnopNwKlantOpslaan.Click
        Dim NwKlantNaam As String = TxtNwKlantNaam.Text
        Dim NwKlantAdres As String = TxtNwKlantAdres.Text
        Dim NwKlantPC As String = TxtNwKlantPc.Text
        Dim NwKlantPlaats As String = TxtNwKlantPlaats.Text
        Dim NwKlantLand As String = TxtNwKlantLand.Text
        Dim sql As String = "INSERT INTO klanten (klantnaam, klantadres,klantpc, klantwoonplaats, klantland) VALUES (@nwklantnaam, @nwklantadres, @nwklantpc, @nwklantplaats, @nwklantland)"

        Using myConnection
            Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                myConnection.Open()
                sqlcom.Parameters.Add("@nwklantnaam", OleDb.OleDbType.VarChar).Value = NwKlantNaam
                sqlcom.Parameters.Add("@nwklantadres", OleDb.OleDbType.VarChar).Value = NwKlantAdres
                sqlcom.Parameters.Add("@nwklantpc", OleDb.OleDbType.VarChar).Value = NwKlantPC
                sqlcom.Parameters.Add("@nwklantplaats", OleDb.OleDbType.VarChar).Value = NwKlantPlaats
                sqlcom.Parameters.Add("@nwklantland", OleDb.OleDbType.VarChar).Value = NwKlantLand
                Dim icount As Integer = sqlcom.ExecuteNonQuery()
                MsgBox(icount & " Nieuwe klant aangemaakt")
            End Using
        End Using

        Me.Close()
    End Sub

    Private Sub KnopNwKlantSluiten_Click(sender As Object, e As EventArgs) Handles KnopNwKlantSluiten.Click
        Me.Close()
    End Sub

End Class