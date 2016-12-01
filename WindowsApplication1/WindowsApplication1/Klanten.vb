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
        da = New OleDb.OleDbDataAdapter("Select * from Klanten", myConnection)
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

    Private Sub KnopKlantenOnderhoud_Click(sender As Object, e As EventArgs) Handles KnopKlantenOnderhoud.Click
        Dim HuidigeRij As Integer = KlantenDataGridView.CurrentRow.Index
        If IsNumeric(HuidigeRij) Then
            Dim KlantId As String = KlantenDataGridView.Rows(HuidigeRij).Cells(0).Value.ToString
            Dim KlantNaam As String = KlantenDataGridView.Rows(HuidigeRij).Cells(1).Value.ToString
            Dim KlantAdres As String = KlantenDataGridView.Rows(HuidigeRij).Cells(2).Value.ToString
            Dim KlantPc As String = KlantenDataGridView.Rows(HuidigeRij).Cells(3).Value.ToString
            Dim KlantWoonplaats As String = KlantenDataGridView.Rows(HuidigeRij).Cells(4).Value.ToString
            Dim KlantLand As String = KlantenDataGridView.Rows(HuidigeRij).Cells(5).Value.ToString
            tempKlantArray(0) = KlantId
            tempKlantArray(1) = KlantNaam
            tempKlantArray(2) = KlantAdres
            tempKlantArray(3) = KlantPc
            tempKlantArray(4) = KlantWoonplaats
            tempKlantArray(5) = KlantLand
        End If
        OndKlant.Show()
    End Sub
End Class