Public Class NWStamgegevens
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub NWStamgegevens_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GetColumns(tempStamgegevensTable)
    End Sub


    Private Function GetColumns(QTable As String)
        Dim Labels = {Label1, Label2, Label3, Label4}
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        Dim strSql As String = "SELECT * FROM " & QTable
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

        For i As Integer = 0 To dtb.Columns.Count - 1
            TxtBoxes(i).Visible = True
            Labels(i).Visible = True
            Labels(i).Text = dtb.Columns(i).ColumnName
        Next
    End Function


End Class