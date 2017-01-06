Public Class Stamgegevens

    Dim UCStamgegevens As New UCStamgegevens
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For Each Control In SplitContainer1.Panel2.Controls
            If Control.ToString = "SimProdPlan.UCStamgegevens" Then
                Control.Dispose()
            End If
        Next Control
        Dim UCStamgegevens As New UCStamgegevens
        If ListView1.SelectedItems.Count = 1 Then
            Dim LVIndex As Integer = ListView1.SelectedItems(0).Index
            tempStamgegevensTable = ListView1.SelectedItems(0).Tag
            SplitContainer1.Panel2.Controls.Clear()
            UCStamgegevens.Dock = DockStyle.Fill
            SplitContainer1.Panel2.Controls.Add(UCStamgegevens)
        End If
    End Sub
End Class
