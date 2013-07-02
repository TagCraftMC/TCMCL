Public Class HelpBrowser

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        HelpBRW.Document.ExecCommand("copy", False, Nothing)

    End Sub

    Private Sub VisitTagCraftMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitTagCraftMCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com")
    End Sub
End Class