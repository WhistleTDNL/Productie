Public Class UCKlanten

    Dim ds As DataSet = New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Private Function LoadData(query As String, tablenaam As String)
        myConnection.ConnectionString = My.Settings.DBPATH
        myConnection.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(query, myConnection)
        da.Fill(ds, tablenaam)
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        KlantenDataGridView.DataSource = view1
        KlantenDataGridView.Refresh()
        myConnection.Close()
    End Function

    Private Sub KnopZoekKlant_Click(sender As Object, e As EventArgs) Handles KnopZoekKlant.Click
        myConnection.ConnectionString = DBPath
        myConnection.Open()
        If Not TxtKlantenKlantNr.Text = "" Then
            source1.Filter = "klantnr = " & TxtKlantenKlantNr.Text
        Else
            source1.Filter = "klantnaam like '%" & TxtKlantenKlantNaam.Text & "%' and klantadres like '%" & TxtKlantenKlantAdres.Text & "%' and klantwoon like '%" & TxtKlantenKlantPlaats.Text & "%' and klantlandid like '%" & TxtKlantenKlantLand.Text & "%' and klantpc like '%" & TxtKlantenKlantPc.Text & "%'"
        End If
        KlantenDataGridView.Refresh()
        myConnection.Close()
        Call LoadData("Select * from Klant", "Klant")
    End Sub

    Private Sub NwKlant_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadData("Select * from Klant", "Klant")
    End Sub

    Private Sub KnopNieuweKlant_Click(sender As Object, e As EventArgs) Handles KnopNieuweKlant.Click
        NwKlant.Show()
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
            tempOndArray(0) = KlantId
            tempOndArray(1) = KlantNaam
            tempOndArray(2) = KlantAdres
            tempOndArray(3) = KlantPc
            tempOndArray(4) = KlantWoonplaats
            tempOndArray(5) = KlantLand
            tempOndArray(6) = "k"
        End If
        Onderhouden.Show()
    End Sub
End Class
