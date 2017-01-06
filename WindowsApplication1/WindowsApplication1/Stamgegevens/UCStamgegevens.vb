Public Class UCStamgegevens

    Dim ds As DataSet = New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim sbuilder As New OleDbCommandBuilder(da)
    Dim source1 As New BindingSource()

    Private Function LoadData(query As String, tablenaam As String)
        myConnection.ConnectionString = My.Settings.DBPATH
        myConnection.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter(query, myConnection)
        da.Fill(ds, tablenaam)
        Dim view1 As New DataView(tables(0))
        source1.DataSource = view1
        DataGridView.DataSource = view1
        DataGridView.Refresh()
        myConnection.Close()
    End Function

    Private Sub UCStamgegevens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QTable As String = tempStamgegevensTable
        Call LoadData("select * from " & QTable, QTable)
        Dim Labels = {Label1, Label2, Label3, Label4}
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        For Each Label In Labels
            Label.Visible = False
            Label.Enabled = False
        Next
        For Each TxtBox In TxtBoxes
            TxtBox.Visible = False
            TxtBox.Enabled = False
        Next
        For i As Integer = 0 To (DataGridView.Columns.Count - 1)
            Labels(i).Visible = True
            Labels(i).Enabled = True
            TxtBoxes(i).Visible = True
            TxtBoxes(i).Enabled = True
            Labels(i).Text = DataGridView.Columns(i).HeaderText
        Next
    End Sub

    Private Sub KnopLeegmaken_Click(sender As Object, e As EventArgs) Handles KnopLeegmaken.Click
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        For Each Txtbox In TxtBoxes
            Txtbox.Text = ""
        Next
        Call KnopZoek_Click(sender, e)
    End Sub

    Private Sub KnopZoek_Click(sender As Object, e As EventArgs) Handles KnopZoek.Click
        Dim QTable As String = tempStamgegevensTable
        Dim Labels = {Label1, Label2, Label3, Label4}
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        Dim Filterstring As String = ""

        myConnection.ConnectionString = My.Settings.DBPATH
        myConnection.Open()

        For i As Integer = 0 To (DataGridView.Columns.Count - 1)
            Filterstring = Filterstring + Labels(i).Text & "like '%" & TxtBoxes(i).Text & "%'"
            If i > 0 Then
                Filterstring = Filterstring + " and "
            End If
        Next

        DataGridView.Refresh()
        myConnection.Close()
        Call LoadData("Select * from " & QTable, QTable)
    End Sub

    Private Sub KnopNieuw_Click(sender As Object, e As EventArgs) Handles KnopNieuw.Click
        NWStamgegevens.Show()
    End Sub
End Class
