﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.HelpBRW = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HelpBRW
        '
        Me.HelpBRW.AllowNavigation = False
        Me.HelpBRW.AllowWebBrowserDrop = False
        Me.HelpBRW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HelpBRW.IsWebBrowserContextMenuEnabled = False
        Me.HelpBRW.Location = New System.Drawing.Point(0, 0)
        Me.HelpBRW.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HelpBRW.Name = "HelpBRW"
        Me.HelpBRW.Size = New System.Drawing.Size(854, 562)
        Me.HelpBRW.TabIndex = 0
        Me.HelpBRW.Url = New System.Uri("http://www.tagcraftmc.com/launcherhelp", System.UriKind.Absolute)
        Me.HelpBRW.WebBrowserShortcutsEnabled = False
        '
        'HelpBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 562)
        Me.Controls.Add(Me.HelpBRW)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "HelpBrowser"
        Me.Text = "TagCraftMC Launcher Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpBRW As System.Windows.Forms.WebBrowser
End Class