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
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.cbversions = New System.Windows.Forms.ComboBox()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Download Percentage:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(387, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Download:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Download Speed:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(387, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Time Remaining:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Download Status:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(178, 83)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(203, 13)
        Me.ProgressBar1.TabIndex = 5
        '
        'lblpct
        '
        Me.lblpct.AutoSize = True
        Me.lblpct.BackColor = System.Drawing.Color.Transparent
        Me.lblpct.Location = New System.Drawing.Point(500, 70)
        Me.lblpct.Name = "lblpct"
        Me.lblpct.Size = New System.Drawing.Size(21, 13)
        Me.lblpct.TabIndex = 6
        Me.lblpct.Text = "0%"
        '
        'lblspeed
        '
        Me.lblspeed.AutoSize = True
        Me.lblspeed.Location = New System.Drawing.Point(476, 83)
        Me.lblspeed.Name = "lblspeed"
        Me.lblspeed.Size = New System.Drawing.Size(40, 13)
        Me.lblspeed.TabIndex = 7
        Me.lblspeed.Text = "0 KB/s"
        '
        'lblsize
        '
        Me.lblsize.AutoSize = True
        Me.lblsize.Location = New System.Drawing.Point(442, 57)
        Me.lblsize.Name = "lblsize"
        Me.lblsize.Size = New System.Drawing.Size(68, 13)
        Me.lblsize.TabIndex = 8
        Me.lblsize.Text = "0 MB / 0 MB"
        '
        'lbleta
        '
        Me.lbleta.AutoSize = True
        Me.lbleta.Location = New System.Drawing.Point(470, 99)
        Me.lbleta.Name = "lbleta"
        Me.lbleta.Size = New System.Drawing.Size(49, 13)
        Me.lbleta.TabIndex = 9
        Me.lbleta.Text = "00:00:00"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(263, 99)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(24, 13)
        Me.lblstatus.TabIndex = 10
        Me.lblstatus.Text = "Idle"
        '
        'btnstart
        '
        Me.btnstart.Location = New System.Drawing.Point(178, 56)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(122, 23)
        Me.btnstart.TabIndex = 11
        Me.btnstart.Text = "Download and Install"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Enabled = False
        Me.btncancel.Location = New System.Drawing.Point(306, 56)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 12
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(12, 142)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnrefresh.TabIndex = 13
        Me.btnrefresh.Text = "Refresh List"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'cbversions
        '
        Me.cbversions.FormattingEnabled = True
        Me.cbversions.Location = New System.Drawing.Point(12, 115)
        Me.cbversions.Name = "cbversions"
        Me.cbversions.Size = New System.Drawing.Size(161, 21)
        Me.cbversions.TabIndex = 14
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversion.Location = New System.Drawing.Point(179, 23)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(154, 20)
        Me.lblversion.TabIndex = 17
        Me.lblversion.Text = "No Version Selected"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.Launcher.My.Resources.Resources._0_0_0
        Me.PictureBox1.Image = Global.Launcher.My.Resources.Resources._0_0_0
        Me.PictureBox1.InitialImage = Global.Launcher.My.Resources.Resources._0_0_0
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 88)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'UpdatesandMods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 310)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbversions)
        Me.Controls.Add(Me.btnrefresh)
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
        Me.Name = "UpdatesandMods"
        Me.Text = "UpdatesandMods"
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
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents cbversions As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblversion As System.Windows.Forms.Label
End Class
