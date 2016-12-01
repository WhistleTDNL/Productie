Public Class HoofdScherm

    Private Sub AfsluitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfsluitenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ArtikelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArtikelToolStripMenuItem1.Click
        Art.Show()
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        OptiesDatabase.Show()
    End Sub

    Private Sub GrondstofToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrondstofToolStripMenuItem.Click
        GrondStof.Show()
    End Sub

    Private Sub KlantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KlantToolStripMenuItem.Click
        Klanten.Show()
    End Sub

    Private Sub LeverancierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeverancierToolStripMenuItem.Click
        Lev.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        NwOrder.Show()
    End Sub

    Private Sub OverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class
