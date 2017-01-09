Public Class NWStamgegevens
    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click

    End Sub

    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub NWStamgegevens_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GetColumns(tempStamgegevensTable)
    End Sub


    Private Function GetColumns(QTable As String)
        Dim Labels = {Label1, Label2, Label3, Label4}
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        Dim strSql As String = "Select sep.value From sys.tables st inner Join sys.columns sc on st.object_id = sc.object_id Left Join sys.extended_properties sep on st.object_id = sep.major_id And sc.column_id = sep.minor_id And sep.name = 'MS_Description' where st.name = '" & QTable & "'"

        Dim dtb As New DataTable
        Using cnn As New OleDbConnection(My.Settings.DBPATH)
            cnn.Open()
            Using dad As New OleDbDataAdapter(strSql, cnn)
                dad.Fill(dtb)
            End Using
            cnn.Close()
        End Using

        For i As Integer = 0 To 3
            TxtBoxes(i).Visible = False
            Labels(i).Visible = False
        Next

        For i As Integer = 0 To dtb.Rows.Count - 1
            TxtBoxes(i).Visible = True
            Labels(i).Visible = True
            Labels(i).Text = dtb.Rows(i)(0).ToString()
        Next
    End Function


End Class