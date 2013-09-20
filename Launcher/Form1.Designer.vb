<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.a = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.b = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.c = New System.Windows.Forms.ToolStripStatusLabel()
        Me.HelpBTN = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LauncherToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lvLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Launcher.My.Resources.Resources.Launch
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(294, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Minecraft", 12.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(304, 259)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(78, 70)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Launcher.My.Resources.Resources.Options
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(28, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.Launcher.My.Resources.Resources.Exit_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(28, 427)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Minecraft", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel8, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.a, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.b, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.c})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.LauncherToolTip.SetToolTip(Me.StatusStrip1, "The status of our servers. Green: Online - Red: Offline - Gray: Querying")
        Me.StatusStrip1.Visible = False
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel8.Margin = New System.Windows.Forms.Padding(160, 3, 0, 2)
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel8.Text = "Network Status:"
        Me.ToolStripStatusLabel8.ToolTipText = "Status of our servers"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel7.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = Global.Launcher.My.Resources.Resources.online
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel1.Text = "Factions"
        Me.ToolStripStatusLabel1.ToolTipText = "Factions is online: play.tagcraftmc.com"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Image = Global.Launcher.My.Resources.Resources.offline
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(94, 17)
        Me.ToolStripStatusLabel3.Text = "Factions"
        Me.ToolStripStatusLabel3.ToolTipText = "Factions is offline: play.tagcraftmc.com"
        Me.ToolStripStatusLabel3.Visible = False
        '
        'a
        '
        Me.a.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.a.ForeColor = System.Drawing.Color.White
        Me.a.Image = Global.Launcher.My.Resources.Resources.unknown
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(94, 17)
        Me.a.Text = "Factions"
        Me.a.ToolTipText = "Factions is querying: play.tagcraftmc.com"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Image = Global.Launcher.My.Resources.Resources.online
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(137, 17)
        Me.ToolStripStatusLabel2.Text = "Hunger Games"
        Me.ToolStripStatusLabel2.Visible = False
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Image = Global.Launcher.My.Resources.Resources.offline
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(137, 17)
        Me.ToolStripStatusLabel4.Text = "Hunger Games"
        Me.ToolStripStatusLabel4.Visible = False
        '
        'b
        '
        Me.b.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.b.ForeColor = System.Drawing.Color.White
        Me.b.Image = Global.Launcher.My.Resources.Resources.unknown
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(137, 17)
        Me.b.Text = "Hunger Games"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Image = Global.Launcher.My.Resources.Resources.online
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripStatusLabel5.Text = "TeamSpeak"
        Me.ToolStripStatusLabel5.Visible = False
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Image = Global.Launcher.My.Resources.Resources.offline
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(112, 17)
        Me.ToolStripStatusLabel6.Text = "TeamSpeak"
        Me.ToolStripStatusLabel6.Visible = False
        '
        'c
        '
        Me.c.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.c.ForeColor = System.Drawing.Color.White
        Me.c.Image = Global.Launcher.My.Resources.Resources.unknown
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(112, 17)
        Me.c.Text = "TeamSpeak"
        '
        'HelpBTN
        '
        Me.HelpBTN.BackColor = System.Drawing.Color.Transparent
        Me.HelpBTN.BackgroundImage = Global.Launcher.My.Resources.Resources.HelpandInfo
        Me.HelpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HelpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HelpBTN.Location = New System.Drawing.Point(28, 369)
        Me.HelpBTN.Name = "HelpBTN"
        Me.HelpBTN.Size = New System.Drawing.Size(196, 40)
        Me.HelpBTN.TabIndex = 3
        Me.HelpBTN.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        '
        'LauncherToolTip
        '
        Me.LauncherToolTip.BackColor = System.Drawing.Color.DodgerBlue
        Me.LauncherToolTip.ForeColor = System.Drawing.Color.White
        Me.LauncherToolTip.OwnerDraw = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Minecraft", 6.25!)
        Me.LinkLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(293, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 11)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Click here to update"
        Me.LinkLabel1.Visible = False
        '
        'lvLBL
        '
        Me.lvLBL.AutoSize = True
        Me.lvLBL.BackColor = System.Drawing.Color.Transparent
        Me.lvLBL.Font = New System.Drawing.Font("Minecraft", 6.25!)
        Me.lvLBL.ForeColor = System.Drawing.Color.Red
        Me.lvLBL.Location = New System.Drawing.Point(0, 2)
        Me.lvLBL.Name = "lvLBL"
        Me.lvLBL.Size = New System.Drawing.Size(294, 11)
        Me.lvLBL.TabIndex = 9
        Me.lvLBL.Text = "Warning: Your version of the launcher is out of date."
        Me.lvLBL.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(341, 526)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Version 1.20"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(762, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 11
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'BackgroundWorker2
        '
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.Launcher.My.Resources.Resources.Visit
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(28, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 40)
        Me.Button4.TabIndex = 14
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Launcher.My.Resources.Resources.TextBG2
        Me.PictureBox1.Location = New System.Drawing.Point(294, 250)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 40)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Launcher.My.Resources.Resources.TextBG2
        Me.PictureBox2.Location = New System.Drawing.Point(294, 310)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 40)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minecraft", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(293, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Minecraft Account Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(316, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Minecraft Version"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(216, 543)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(365, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Minecraft © 2013 Mojang. All rights reserved"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(306, 353)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 21)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Remember Account"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Minecraft", 9.75!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(597, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Latest News"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Minecraft", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.Launcher.My.Resources.Resources.News
        Me.Label6.Location = New System.Drawing.Point(556, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 217)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Launcher.My.Resources.Resources.Logo
        Me.PictureBox3.Location = New System.Drawing.Point(28, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(724, 136)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Minecraft", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(301, 320)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1, 541)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.ChalkieFinal_zps9ed55b9c
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvLBL)
        Me.Controls.Add(Me.HelpBTN)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TagCraftMC Launcher"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HelpBTN As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents a As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents b As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents c As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LauncherToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lvLBL As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
