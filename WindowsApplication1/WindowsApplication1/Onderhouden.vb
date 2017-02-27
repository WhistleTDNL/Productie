Public Class Onderhouden
    Dim relType As String = tempOndArray(6)

    Private Sub KnopOpslaan_Click(sender As Object, e As EventArgs) Handles KnopOpslaan.Click
        Dim OndNr As Integer = TxtOndNr.Text
        Dim OndNaam As String = TxtOndNaam.Text
        Dim OndAdres As String = TxtOndAdres.Text
        Dim OndPC As String = TxtOndPc.Text
        Dim OndPlaats As String = TxtOndPlaats.Text
        Dim OndLand As String = BoxOndLand.SelectedValue
        Dim sql As String
        If relType = "k" Then
            sql = "UPDATE klant Set klantnaam = ?, klantadres = ?, klantpc = ?, klantwoon =?, klantlandid = ? WHERE klantnr = ?"
        ElseIf relType = "l" Then
            sql = "UPDATE lev Set levnaam = ?, levadres = ?, levpc = ?, levwoon = ?, levlandid = ? WHERE levnr = ?"
        Else
            MsgBox("Onjuiste invoer")
        End If
        myConnection.ConnectionString = My.Settings.DBPATH
        Using myConnection
            Using sqlcom = New System.Data.OleDb.OleDbCommand(sql, myConnection)
                myConnection.Open()
                sqlcom.Parameters.Add("@nwnaam", OleDb.OleDbType.VarChar).Value = OndNaam
                sqlcom.Parameters.Add("@nwadres", OleDb.OleDbType.VarChar).Value = OndAdres
                sqlcom.Parameters.Add("@nwpc", OleDb.OleDbType.VarChar).Value = OndPC
                sqlcom.Parameters.Add("@nwplaats", OleDb.OleDbType.VarChar).Value = OndPlaats
                sqlcom.Parameters.Add("@nwland", OleDb.OleDbType.Integer).Value = OndLand
                sqlcom.Parameters.Add("@nwnr", OleDb.OleDbType.Integer).Value = OndNr
                sqlcom.ExecuteNonQuery()
            End Using
        End Using
        Me.Close()
    End Sub

    Private Sub KnopSluiten_Click(sender As Object, e As EventArgs) Handles KnopSluiten.Click
        Me.Close()
    End Sub

    Private Sub OndKlant_Load(sender As Object, e As EventArgs) Handles Me.Load
        myConnection.ConnectionString = My.Settings.DBPATH
        Dim query As String = "select * from landen"
        Using myConnection
            myConnection.Open()
            Using sqlcom = New OleDbCommand(query, myConnection)
                Dim rs As OleDbDataReader = sqlcom.ExecuteReader
                Dim dt As DataTable = New DataTable
                dt.Load(rs)
                BoxOndLand.ValueMember = "idlanden"
                BoxOndLand.DisplayMember = "landoms"
                BoxOndLand.DataSource = dt
                BoxOndLand.Text = tempOndArray(5)
            End Using
        End Using
        Dim Aantal As Integer = tempOndArray.Count
        If Aantal > 0 Then
            ' Is niet op juiste volgorde als je de kolommen opnieuw indeelt.
            TxtOndNr.Text = tempOndArray(0)
            TxtOndNaam.Text = tempOndArray(1)
            TxtOndAdres.Text = tempOndArray(2)
            TxtOndPc.Text = tempOndArray(3)
            TxtOndPlaats.Text = tempOndArray(4)
            For Each item As String In tempOndArray
                item = ""
            Next
        Else
            MsgBox("Geen klant geselecteerd")
            Me.Close()
        End If
    End Sub
End Class