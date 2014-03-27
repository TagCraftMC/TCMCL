<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ComboBox1x = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OptionsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBox2x = New System.Windows.Forms.ComboBox()
        Me.ComboBox3x = New System.Windows.Forms.ComboBox()
        Me.ComboBox4x = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1x
        '
        Me.ComboBox1x.AllowDrop = True
        Me.ComboBox1x.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1x.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1x.FormattingEnabled = True
        Me.ComboBox1x.Items.AddRange(New Object() {"Enabled", "Disabled"})
        Me.ComboBox1x.Location = New System.Drawing.Point(308, 185)
        Me.ComboBox1x.Name = "ComboBox1x"
        Me.ComboBox1x.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1x.TabIndex = 0
        Me.OptionsToolTip.SetToolTip(Me.ComboBox1x, "Allows you to enable Full bright.")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.Launcher.My.Resources.Resources.Fullbright
        Me.Label1.Location = New System.Drawing.Point(7, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 1
        Me.OptionsToolTip.SetToolTip(Me.Label1, "Allows you to enable Full bright." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This options makes it easy to see in caves.")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Launcher.My.Resources.Resources.SaveOptions
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(6, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 40)
        Me.Button1.TabIndex = 2
        Me.OptionsToolTip.SetToolTip(Me.Button1, "Save any Options you have changed.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.Launcher.My.Resources.Resources.Memory
        Me.Label2.Location = New System.Drawing.Point(8, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 4
        Me.OptionsToolTip.SetToolTip(Me.Label2, "Allows you to change how much memory you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Allocate to Minecraft. Its good to incr" & _
        "ease this" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you're using mods such as Forge.")
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.Launcher.My.Resources.Resources.Exit_
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Location = New System.Drawing.Point(212, 415)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 40)
        Me.Button5.TabIndex = 10
        Me.OptionsToolTip.SetToolTip(Me.Button5, "Exit the Options menu without saving any changes.")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'OptionsToolTip
        '
        Me.OptionsToolTip.BackColor = System.Drawing.Color.White
        Me.OptionsToolTip.ForeColor = System.Drawing.Color.Black
        '
        'ComboBox2x
        '
        Me.ComboBox2x.AllowDrop = True
        Me.ComboBox2x.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2x.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2x.FormattingEnabled = True
        Me.ComboBox2x.Items.AddRange(New Object() {"Enabled", "Disabled"})
        Me.ComboBox2x.Location = New System.Drawing.Point(308, 104)
        Me.ComboBox2x.Name = "ComboBox2x"
        Me.ComboBox2x.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox2x.TabIndex = 16
        Me.OptionsToolTip.SetToolTip(Me.ComboBox2x, "Allows you to see all items ID's and damage values.")
        '
        'ComboBox3x
        '
        Me.ComboBox3x.AllowDrop = True
        Me.ComboBox3x.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3x.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3x.FormattingEnabled = True
        Me.ComboBox3x.Items.AddRange(New Object() {"Enabled", "Disabled"})
        Me.ComboBox3x.Location = New System.Drawing.Point(308, 131)
        Me.ComboBox3x.Name = "ComboBox3x"
        Me.ComboBox3x.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox3x.TabIndex = 18
        Me.OptionsToolTip.SetToolTip(Me.ComboBox3x, "Allows you to see held items ID's and damage values.")
        '
        'ComboBox4x
        '
        Me.ComboBox4x.AllowDrop = True
        Me.ComboBox4x.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4x.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4x.FormattingEnabled = True
        Me.ComboBox4x.Items.AddRange(New Object() {"Enabled", "Disabled"})
        Me.ComboBox4x.Location = New System.Drawing.Point(308, 158)
        Me.ComboBox4x.Name = "ComboBox4x"
        Me.ComboBox4x.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox4x.TabIndex = 19
        Me.OptionsToolTip.SetToolTip(Me.ComboBox4x, "Makes minecraft run in debug mode. This can help ")
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"512M", "1024M", "1536M", "2048M", "3072M", "4096M", "6144M", "5120M", "7168M", "8192M"})
        Me.ComboBox1.Location = New System.Drawing.Point(308, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(94, 21)
        Me.ComboBox1.TabIndex = 21
        Me.OptionsToolTip.SetToolTip(Me.ComboBox1, "Allows you to change how much memory you")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.Launcher.My.Resources.Resources.Options2
        Me.Label3.Location = New System.Drawing.Point(148, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 30)
        Me.Label3.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Launcher.My.Resources.Resources.Credits
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(109, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 40)
        Me.Button3.TabIndex = 13
        Me.OptionsToolTip.SetToolTip(Me.Button3, "Brings up Credits and Thanks area.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Image = Global.Launcher.My.Resources.Resources.Debug
        Me.Label5.Location = New System.Drawing.Point(-2, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 14
        Me.OptionsToolTip.SetToolTip(Me.Label5, "Makes minecraft run in debug mode. This can help " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when looking for errors.")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Image = Global.Launcher.My.Resources.Resources.AdvanceIT
        Me.Label4.Location = New System.Drawing.Point(2, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 17)
        Me.Label4.TabIndex = 15
        Me.OptionsToolTip.SetToolTip(Me.Label4, "Allows you to see all items ID's and damage values.")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Image = Global.Launcher.My.Resources.Resources.HeldIT
        Me.Label6.Location = New System.Drawing.Point(2, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 17)
        Me.Label6.TabIndex = 17
        Me.OptionsToolTip.SetToolTip(Me.Label6, "Allows you to see held items ID's and damage values.")
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.OptionsArea
        Me.ClientSize = New System.Drawing.Size(414, 466)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox4x)
        Me.Controls.Add(Me.ComboBox3x)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox2x)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1x)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Minecraft Launcher Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1x As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents OptionsToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2x As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3x As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4x As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
