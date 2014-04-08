<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatesandMods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatesandMods))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblpct = New System.Windows.Forms.Label()
        Me.lblspeed = New System.Windows.Forms.Label()
        Me.lblsize = New System.Windows.Forms.Label()
        Me.lbleta = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cbversions = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.TransparentRichTextBox1 = New Launcher.TransparentRichTextBox()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(402, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Download Percentage:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(402, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Download:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(402, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Download Speed:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(402, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time Remaining:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(176, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Download and Install Status:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(179, 142)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(217, 13)
        Me.ProgressBar1.TabIndex = 5
        '
        'lblpct
        '
        Me.lblpct.AutoSize = True
        Me.lblpct.BackColor = System.Drawing.Color.Transparent
        Me.lblpct.ForeColor = System.Drawing.Color.White
        Me.lblpct.Location = New System.Drawing.Point(515, 128)
        Me.lblpct.Name = "lblpct"
        Me.lblpct.Size = New System.Drawing.Size(21, 13)
        Me.lblpct.TabIndex = 6
        Me.lblpct.Text = "0%"
        '
        'lblspeed
        '
        Me.lblspeed.AutoSize = True
        Me.lblspeed.BackColor = System.Drawing.Color.Transparent
        Me.lblspeed.ForeColor = System.Drawing.Color.White
        Me.lblspeed.Location = New System.Drawing.Point(491, 141)
        Me.lblspeed.Name = "lblspeed"
        Me.lblspeed.Size = New System.Drawing.Size(40, 13)
        Me.lblspeed.TabIndex = 7
        Me.lblspeed.Text = "0 KB/s"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.BackColor = System.Drawing.Color.Transparent
        Me.lblsize.ForeColor = System.Drawing.Color.White
        Me.lblsize.Location = New System.Drawing.Point(457, 115)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(68, 13)
        Me.lblsize.TabIndex = 8
        Me.lblsize.Text = "0 MB / 0 MB"
        '
        'lbleta
        '
        Me.lbleta.AutoSize = True
        Me.lbleta.BackColor = System.Drawing.Color.Transparent
        Me.lbleta.ForeColor = System.Drawing.Color.White
        Me.lbleta.Location = New System.Drawing.Point(485, 157)
        Me.lbleta.Name = "lbleta"
        Me.lbleta.Size = New System.Drawing.Size(49, 13)
        Me.lbleta.TabIndex = 9
        Me.lbleta.Text = "00:00:00"
        '
        'lblstatus
        '
        Me.lblstatus.BackColor = System.Drawing.Color.Transparent
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Location = New System.Drawing.Point(314, 158)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(82, 13)
        Me.lblstatus.TabIndex = 10
        Me.lblstatus.Text = "Idle"
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(179, 113)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(122, 23)
        Me.btnstart.TabIndex = 11
        Me.btnstart.Text = "Download and Install"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Location = New System.Drawing.Point(307, 113)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(89, 23)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cbversions
        '
        Me.cbversions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbversions.Enabled = False
        Me.cbversions.FormattingEnabled = True
        Me.cbversions.Location = New System.Drawing.Point(12, 115)
        Me.cbversions.Name = "cbversions"
        Me.cbversions.Size = New System.Drawing.Size(161, 21)
        Me.cbversions.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Launcher.My.Resources.Resources.ChooseVersion
        Me.PictureBox1.Image = Global.Launcher.My.Resources.Resources.ChooseVersion
        Me.PictureBox1.InitialImage = Global.Launcher.My.Resources.Resources._0_0_0
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 88)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'TransparentRichTextBox1
        '
        Me.TransparentRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransparentRichTextBox1.ForeColor = System.Drawing.Color.White
        Me.TransparentRichTextBox1.Location = New System.Drawing.Point(180, 22)
        Me.TransparentRichTextBox1.Name = "TransparentRichTextBox1"
        Me.TransparentRichTextBox1.ReadOnly = True
        Me.TransparentRichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.TransparentRichTextBox1.Size = New System.Drawing.Size(392, 87)
        Me.TransparentRichTextBox1.TabIndex = 18
        Me.TransparentRichTextBox1.Text = ""
        '
        'BackgroundWorker3
        '
        '
        'UpdatesandMods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.ModsGUI_Final
        Me.ClientSize = New System.Drawing.Size(584, 183)
        Me.Controls.Add(Me.TransparentRichTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbversions)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.lbleta)
        Me.Controls.Add(Me.lblsize)
        Me.Controls.Add(Me.lblspeed)
        Me.Controls.Add(Me.lblpct)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdatesandMods"
        Me.Text = "Minecraft Updates"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblpct As System.Windows.Forms.Label
    Friend WithEvents lblspeed As System.Windows.Forms.Label
    Friend WithEvents lblsize As System.Windows.Forms.Label
    Friend WithEvents lbleta As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents cbversions As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TransparentRichTextBox1 As Launcher.TransparentRichTextBox
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
End Class
