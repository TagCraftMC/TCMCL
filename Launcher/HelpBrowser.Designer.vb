<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpBrowser))
        Me.HelpBRW = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitTagCraftMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpBRW
        '
        Me.HelpBRW.AllowWebBrowserDrop = False
        Me.HelpBRW.ContextMenuStrip = Me.ContextMenuStrip1
        Me.HelpBRW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBRW.IsWebBrowserContextMenuEnabled = False
        Me.HelpBRW.Location = New System.Drawing.Point(0, 0)
        Me.HelpBRW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HelpBRW.Name = "HelpBRW"
        Me.HelpBRW.ScriptErrorsSuppressed = True
        Me.HelpBRW.Size = New System.Drawing.Size(854, 562)
        Me.HelpBRW.TabIndex = 0
        Me.HelpBRW.Url = New System.Uri("http://www.tagcraftmc.com/launcherhelp", System.UriKind.Absolute)
        Me.HelpBRW.WebBrowserShortcutsEnabled = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.VisitTagCraftMCToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(140, 48)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'VisitTagCraftMCToolStripMenuItem
        '
        Me.VisitTagCraftMCToolStripMenuItem.Name = "VisitTagCraftMCToolStripMenuItem"
        Me.VisitTagCraftMCToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.VisitTagCraftMCToolStripMenuItem.Text = "Visit TagCraftMC"
        '
        'HelpBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 562)
        Me.Controls.Add(Me.HelpBRW)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "HelpBrowser"
        Me.Text = "Minecraft Launcher Help"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpBRW As System.Windows.Forms.WebBrowser
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitTagCraftMCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
