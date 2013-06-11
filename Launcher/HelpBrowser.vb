Public Class HelpBrowser

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        HelpBRW.Document.ExecCommand("copy", False, Nothing)

    End Sub
End Class