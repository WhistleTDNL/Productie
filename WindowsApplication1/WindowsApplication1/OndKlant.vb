Public Class OndKlant
    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        Dim OndKlantNr As Integer = TxtOndKlantNr.Text
        Dim OndKlantNaam As String = TxtOndKlantNaam.Text
        Dim OndKlantAdres As String = TxtOndKlantAdres.Text
        Dim OndKlantPC As String = TxtOndKlantPc.Text
        Dim OndKlantPlaats As String = TxtOndKlantPlaats.Text
        Dim OndKlantLand As String = TxtOndKlantLand.Text
        Dim sql As String = "UPDATE klanten Set klantnaam = @nwklantnaam, klantadres = @nwklantadres, klantpc = @nwklantpc, klantwoonplaats = @nwklantplaats, klantland = @nwklantland WHERE klantnr = @nwklantnr"
        'Dim sql As String = "INSERT INTO klanten (klantnaam, klantadres,klantpc, klantwoonplaats, klantland) VALUES (@nwklantnaam, @nwklantadres, @nwklantpc, @nwklantplaats, @nwklantland)"

        Using myConnection
            Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                myConnection.Open()
                sqlcom.Parameters.Add("@nwklantnr", OleDb.OleDbType.VarChar).Value = OndKlantNr
                sqlcom.Parameters.Add("@nwklantnaam", OleDb.OleDbType.VarChar).Value = OndKlantNaam
                sqlcom.Parameters.Add("@nwklantadres", OleDb.OleDbType.VarChar).Value = OndKlantAdres
                sqlcom.Parameters.Add("@nwklantpc", OleDb.OleDbType.VarChar).Value = OndKlantPC
                sqlcom.Parameters.Add("@nwklantplaats", OleDb.OleDbType.VarChar).Value = OndKlantPlaats
                sqlcom.Parameters.Add("@nwklantland", OleDb.OleDbType.VarChar).Value = OndKlantLand
                Dim icount As Integer = sqlcom.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub OndKlant_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Aantal As Integer = tempKlantArray.Count
        If Aantal > 0 Then
            TxtOndKlantNr.Text = tempKlantArray(0)
            TxtOndKlantNaam.Text = tempKlantArray(1)
            TxtOndKlantAdres.Text = tempKlantArray(2)
            TxtOndKlantPc.Text = tempKlantArray(3)
            TxtOndKlantPlaats.Text = tempKlantArray(4)
            TxtOndKlantLand.Text = tempKlantArray(5)
            For Each item As String In tempKlantArray
                item = ""
            Next
        Else
            MsgBox("Geen klant geselecteerd")
            Me.Close()
        End If
    End Sub
End Class