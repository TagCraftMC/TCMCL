<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrashReader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrashReader))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransparentRichTextBox1 = New Launcher.TransparentRichTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Launcher.My.Resources.Resources.Close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(157, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 482)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tips:"
        '
        'TransparentRichTextBox1
        '
        Me.TransparentRichTextBox1.ForeColor = System.Drawing.Color.White
        Me.TransparentRichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TransparentRichTextBox1.Name = "TransparentRichTextBox1"
        Me.TransparentRichTextBox1.ReadOnly = True
        Me.TransparentRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.TransparentRichTextBox1.Size = New System.Drawing.Size(486, 467)
        Me.TransparentRichTextBox1.TabIndex = 3
        Me.TransparentRichTextBox1.Text = ""
        '
        'CrashReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.CrashReportGUI1
        Me.ClientSize = New System.Drawing.Size(510, 580)
        Me.Controls.Add(Me.TransparentRichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CrashReader"
        Me.Text = "Crash Report"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransparentRichTextBox1 As Launcher.TransparentRichTextBox
End Class
