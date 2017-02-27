Public Class NwArt


    Private Sub BtnAnnuleren_Click(sender As Object, e As EventArgs) Handles BtnAnnuleren.Click
        Close()
    End Sub

    Private Sub BtnLeegmaken_Click(sender As Object, e As EventArgs) Handles BtnLeegmaken.Click
        Dim TxtBoxes As Array = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, ComboBox1, ComboBox2, ComboBox3, ComboBox4}
        For Each Box In TxtBoxes
            Box.Text = ""
        Next
    End Sub
End Class