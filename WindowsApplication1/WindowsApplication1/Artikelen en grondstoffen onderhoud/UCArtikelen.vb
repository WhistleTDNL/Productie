Public Class UCArtikelen

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
        ArtDataGridView.DataSource = view1
        ArtDataGridView.Refresh()
        myConnection.Close()
    End Function

    Private Sub UCArtikelen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadData("Select artnr , a.artoms , a.artmaat , a.artloop  , a.artverp, a.artdoos, s.artsrtoms, t.arttypoms, idartstof , idartsupp From artbst as a left join artsrt as s on s.idartsrt = a.idartsrt left join arttyp as t on t.idarttyp = a.idarttyp ", "artbst")
    End Sub

    Private Sub KnopZoek_Click(sender As Object, e As EventArgs) Handles KnopZoek.Click
        source1.Filter = "artnr like '%" & Artnr.Text &
                        "%' and artoms like '%" & artoms.Text &
                        "%' and artmaat like '%" & artmaat.Text &
                        "%' and artloop like '%" & artloop.Text &
                        "%' and artverp like '%" & artverp.Text &
                        "%' and artdoos like '%" & artdoos.Text &
                        "%' and artsrtoms like '%" & idartsrt.Text &
                        "%' and arttypoms like '%" & idarttyp.Text &
                        "%' and idartstof like '%" & idartstof.Text &
                        "%' and idartsupp like '%" & idartsupp.Text & "%'"
        ArtDataGridView.Refresh()
        Call LoadData("Select  artnr,artoms,artmaat,artloop,artverp,artdoos,idartsrt,idarttyp,idartstof,idartsupp From artbst", "artbst")
    End Sub

    Private Sub KnopNieuw_Click(sender As Object, e As EventArgs) Handles KnopNieuw.Click
        NwArt.Show()
    End Sub

    Private Sub KnopLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopLeegmaken.Click
        For Each Control In {Artnr, artoms, artmaat, artloop, artverp, artdoos, idartsrt, idarttyp, idartstof, idartsupp}
            Control.Text = ""
        Next
        Call KnopZoek_Click(sender, e)
    End Sub

    Private Sub KnopOnderhoud_Click(sender As Object, e As EventArgs) Handles KnopOnderhoud.Click
        Dim Textboxes As Array = {Artnr, artoms, artmaat, artloop, artverp, artdoos, idartsrt, idarttyp, idartstof, idartsupp}
        Dim HuidigeRij As Integer = ArtDataGridView.CurrentRow.Index
        If IsNumeric(HuidigeRij) Then
            For i As Integer = 0 To 9
                tempOndArtArray(i) = ArtDataGridView.Rows(HuidigeRij).Cells(i).Value.ToString
            Next
        End If
        NwArt.Show()
    End Sub
End Class
