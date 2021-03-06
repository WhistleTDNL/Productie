﻿Public Class NwKlant

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
        BoxNwKlantLand.Text = ""
    End Sub



    Private Sub KnopNwKlantOpslaan_Click(sender As Object, e As EventArgs) Handles KnopNwKlantOpslaan.Click
        Dim NwKlantNaam As String = TxtNwKlantNaam.Text
        Dim NwKlantAdres As String = TxtNwKlantAdres.Text
        Dim NwKlantPC As String = TxtNwKlantPc.Text
        Dim NwKlantPlaats As String = TxtNwKlantPlaats.Text
        Dim NwKlantLand As Integer = BoxNwKlantLand.SelectedValue
        myConnection.ConnectionString = My.Settings.DBPATH
        Dim sql As String = "INSERT INTO klant (klantnaam, klantadres,klantpc, klantwoon, klantlandid) VALUES (?, ?, ?, ?, ?)"
        If NwKlantNaam = "" Or NwKlantAdres = "" Or NwKlantPC = "" Or NwKlantPlaats = "" Then
            MsgBox("Een van de velden is leeg, klant niet opgeslagen.")
        Else
            Using myConnection
                Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                    myConnection.Open()
                    sqlcom.Parameters.Add("@nwklantnaam", OleDb.OleDbType.VarChar).Value = NwKlantNaam
                    sqlcom.Parameters.Add("@nwklantadres", OleDb.OleDbType.VarChar).Value = NwKlantAdres
                    sqlcom.Parameters.Add("@nwklantpc", OleDb.OleDbType.VarChar).Value = NwKlantPC
                    sqlcom.Parameters.Add("@nwklantplaats", OleDb.OleDbType.VarChar).Value = NwKlantPlaats
                    sqlcom.Parameters.Add("@nwklantland", OleDb.OleDbType.Integer).Value = NwKlantLand
                    Dim icount As Integer = sqlcom.ExecuteNonQuery()
                    MsgBox(icount & " Nieuwe klant aangemaakt")
                End Using
            End Using

            Me.Close()
        End If
    End Sub

    Private Sub KnopNwKlantSluiten_Click(sender As Object, e As EventArgs) Handles KnopNwKlantSluiten.Click
        Me.Close()
    End Sub

    Private Sub NwKlant_Load(sender As Object, e As EventArgs) Handles Me.Load
        myConnection.ConnectionString = My.Settings.DBPATH
        Dim query As String = "select * from landen"
        Using myConnection
            myConnection.Open()
            Using sqlcom = New OleDbCommand(query, myConnection)
                Dim rs As OleDbDataReader = sqlcom.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                BoxNwKlantLand.ValueMember = "idlanden"
                BoxNwKlantLand.DisplayMember = "landoms"
                BoxNwKlantLand.DataSource = dt
            End Using
        End Using
    End Sub
End Class