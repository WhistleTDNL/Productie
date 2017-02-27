Public Class NWStamgegevens
    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        Dim TxtBoxes = {Txt1, Txt2, Txt3, Txt4}
        Dim strSql As String = "select sc.name from sys.tables st inner join sys.columns sc on st.object_id = sc.object_id where st.name = '" & tempStamgegevensTable & "'"

        Dim dtb As New DataTable
        Using cnn As New OleDbConnection(My.Settings.DBPATH)
            cnn.Open()
            Using dad As New OleDbDataAdapter(strSql, cnn)
                dad.Fill(dtb)
            End Using
            cnn.Close()
        End Using

        Dim InsertString As String = ""
        Dim ValuesString As String = ""
        For i As Integer = 1 To dtb.Rows.Count - 1
            If i = 1 Then
                InsertString = InsertString & dtb.Rows(i)(0).ToString()
            Else
                InsertString = InsertString & ", " & dtb.Rows(i)(0).ToString()
            End If
            If i = 1 Then
                ValuesString = ValuesString + "?"
            Else
                ValuesString = ValuesString + ", ?"
            End If
        Next

        Dim cmdSql As String = "INSERT INTO " & tempStamgegevensTable & "(" & InsertString & ") VALUES " & "(" & ValuesString & ")"
        MsgBox(cmdSql)
        Using cnn As New OleDbConnection(My.Settings.DBPATH)
            Using sqlcom = New System.Data.OleDb.OleDbCommand(cmdSql, cnn)
                cnn.Open()
                For i As Integer = 1 To dtb.Rows.Count - 1
                    sqlcom.Parameters.Add("@" & dtb.Rows(i)(0).ToString(), OleDb.OleDbType.VarChar).Value = TxtBoxes(i).Text
                Next
                Dim icount As Integer = sqlcom.ExecuteNonQuery()
                MsgBox(icount & " Nieuwe regel aangemaakt")
            End Using
        End Using

    End Sub



    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub NWStamgegevens_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GetColumns(tempStamgegevensTable)
        Txt1.Enabled = False
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