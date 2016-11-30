Public Class Klanten
    Dim ds As DataSet = New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()

    Private Sub KnopZoekKlant_Click(sender As Object, e As EventArgs) Handles KnopZoekKlant.Click
        myConnection.Open()
        If Not TxtKlantenKlantNr.Text = "" Then
            source1.Filter = "klantnr = " & TxtKlantenKlantNr.Text
            KlantenDataGridView.Refresh()
        Else
            source1.Filter = "klantnaam like '%" & TxtKlantenKlantNaam.Text & "%' and klantadres like '%" & TxtKlantenKlantAdres.Text & "%' and klantwoonplaats like '%" & TxtKlantenKlantPlaats.Text & "%' and klantland like '%" & TxtKlantenKlantLand.Text & "%' and klantpc like '%" & TxtKlantenKlantPc.Text & "%'"
        End If
        KlantenDataGridView.Refresh()
        myConnection.Close()
    End Sub

    Private Sub NwKlant_Load(sender As Object, e As EventArgs) Handles Me.Load
        myConnection.ConnectionString = DBPath
        myConnection.Open()
        da = New OleDb.OleDbDataAdapter("Select * from klanten", myConnection)
        da.Fill(ds, "Klanten")
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        KlantenDataGridView.DataSource = view1
        KlantenDataGridView.Refresh()
        myConnection.Close()
    End Sub

    Private Sub KnopNieuweKlant_Click(sender As Object, e As EventArgs) Handles KnopNieuweKlant.Click
        NwKlant.Show()
        Me.Close()
    End Sub

    Private Sub KnopKlantenSluiten_Click(sender As Object, e As EventArgs) Handles KnopKlantenSluiten.Click
        Me.Close()
    End Sub

    Private Sub KnopKlantenLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopKlantenLeegmaken.Click
        TxtKlantenKlantAdres.Text = ""
        TxtKlantenKlantNaam.Text = ""
        TxtKlantenKlantNr.Text = ""
        TxtKlantenKlantPc.Text = ""
        TxtKlantenKlantPlaats.Text = ""
        TxtKlantenKlantLand.Text = ""
        Call KnopZoekKlant_Click(sender, e)
    End Sub
End Class