Public Class HoofdScherm

    Private Sub AfsluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfsluitenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ArtikelToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        NwArt.Show()
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        OptiesDatabase.Show()
    End Sub

    Private Sub GrondstofToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GrondStof.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        NwOrder.Show()
    End Sub

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Dim UCLev As New UCLev
    Dim UCKlanten As New UCKlanten
    Dim UCStamgegevens As New Stamgegevens
    Dim UCArtikelen As New UCArtikelen
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 1 Then
            Dim LVIndex As Integer = ListView1.SelectedItems(0).Index
            If LVIndex = 0 Then
                SplitContainer1.Panel2.Controls.Clear()
                UCKlanten.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(UCKlanten)
            ElseIf LVIndex = 1 Then
                SplitContainer1.Panel2.Controls.Clear()
                UCLev.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(UCLev)
            ElseIf LVIndex = 2 Then
                SplitContainer1.Panel2.Controls.Clear()
                UCLev.Dock = DockStyle.Fill
                SplitContainer1.Panel2.Controls.Add(UCArtikelen)
            End If
        End If
    End Sub

    Private Sub StamgegevensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StamgegevensToolStripMenuItem.Click
        SplitContainer1.Panel2.Controls.Clear()
        UCStamgegevens.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(UCStamgegevens)
    End Sub
End Class
