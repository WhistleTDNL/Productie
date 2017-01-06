Public Class UCLev

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
        LevDataGridView.DataSource = view1
        LevDataGridView.Refresh()
        myConnection.Close()
    End Function
    Private Sub KnopZoekLev_Click(sender As Object, e As EventArgs) Handles KnopZoekLev.Click
        If Not TxtLevNr.Text = "" Then
            source1.Filter = "levnr = " & TxtLevNr.Text
        Else
            source1.Filter = "levnaam like '%" & TxtLevNaam.Text & "%' and levadres like '%" & TxtLevAdres.Text & "%' and levwoon like '%" & TxtLevPlaats.Text & "%' and levlandid like '%" & TxtLevLand.Text & "%' and levpc like '%" & TxtLevPc.Text & "%'"
        End If
        LevDataGridView.Refresh()
        Call LoadData("Select * from Lev", "Lev")
    End Sub

    Private Sub UcLev_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadData("Select * from Lev", "Lev")
    End Sub

    Private Sub KnopNieuweLev_Click(sender As Object, e As EventArgs) Handles KnopNieuweLev.Click
        NWLev.Show()
    End Sub

    Private Sub KnopLevLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopLevLeegmaken.Click
        TxtLevAdres.Text = ""
        TxtLevNaam.Text = ""
        TxtLevNr.Text = ""
        TxtLevPc.Text = ""
        TxtLevPlaats.Text = ""
        TxtLevLand.Text = ""
        Call KnopZoekLev_Click(sender, e)
    End Sub

    Private Sub KnopLevOnderhoud_Click(sender As Object, e As EventArgs) Handles KnopLevOnderhoud.Click
        Dim HuidigeRij As Integer = LevDataGridView.CurrentRow.Index
        If IsNumeric(HuidigeRij) Then
            Dim Levid As String = LevDataGridView.Rows(HuidigeRij).Cells(0).Value.ToString
            Dim Levnaam As String = LevDataGridView.Rows(HuidigeRij).Cells(1).Value.ToString
            Dim Levadres As String = LevDataGridView.Rows(HuidigeRij).Cells(2).Value.ToString
            Dim Levpc As String = LevDataGridView.Rows(HuidigeRij).Cells(3).Value.ToString
            Dim Levwoonplaats As String = LevDataGridView.Rows(HuidigeRij).Cells(4).Value.ToString
            Dim Levland As String = LevDataGridView.Rows(HuidigeRij).Cells(5).Value.ToString
            tempOndArray(0) = Levid
            tempOndArray(1) = Levnaam
            tempOndArray(2) = Levadres
            tempOndArray(3) = Levpc
            tempOndArray(4) = Levwoonplaats
            tempOndArray(5) = Levland
            tempOndArray(6) = "l"
        End If
        Onderhouden.Show()
    End Sub
End Class
