﻿Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection
Imports System.Drawing.Text
Imports TagAPIx
Imports Newtonsoft.Json


Public Class Form1

    Public Shared mem As String
    Public Shared ver As String

    '-----------------------

    Public Shared version As String
    Public Shared replacedir As String
    Public Shared replacename As String

    '-----------------------

    Dim progresshere As Integer

    Dim nom As String
    Dim nomx As String

    'Dim mem As String
    Public Shared mempass As String


    Dim server As Boolean

    Dim HG As Boolean

    Dim TS As Boolean

    Dim LauncherVersion As Boolean


    Public Shared accessOP As String
    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim line As String

    Dim oFilex As System.IO.File
    Dim oWritex As System.IO.StreamWriter
    Dim oReadx As System.IO.StreamReader

    Dim oFilec As System.IO.File
    Dim oWritec As System.IO.StreamWriter
    Dim oReadc As System.IO.StreamReader

    Dim oFiley As System.IO.File
    Dim oWritey As System.IO.StreamWriter
    Dim oReady As System.IO.StreamReader

    Dim oFilep As System.IO.File
    Dim oWritep As System.IO.StreamWriter
    Dim oReadp As System.IO.StreamReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Please choose an Account Name. This is needed even if you're just playing Single Player", "Are you my mommy?")
            ElseIf ComboBox1.Text = "" Then
                MessageBox.Show("Please choose a Version. This is needed even if you're just playing Single Player", "Are you my mommy?")
            Else
                Button1.Enabled = False

                versionnumberwriter()
                rememberaccountwriter()
                usernamewriter()

                '-------------------------- Memory check old config
                memorypasswriter()
                '-------------------------- Memory check ends
                BackgroundWorker3.RunWorkerAsync()

            End If
        Catch ex As Exception

        End Try


    End Sub
    Function centerForm(ByVal Form_to_Center As Form) As Point
        Dim pLocation As New Point
        pLocation.X = (Me.Left + (Me.Width - Form_to_Center.Width) / 2) '// set the X coordinates.
        pLocation.Y = (Me.Top + (Me.Height - Form_to_Center.Height) / 2) '// set the Y coordinates.
        Return pLocation '// return the Location to the Form it was called from.
    End Function

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Launch_Draw(sender As Object, e As System.Windows.Forms.DrawToolTipEventArgs) Handles LauncherToolTip.Draw
        e.DrawBackground()
        e.DrawText()
    End Sub
    'Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles LauncherToolTip.Popup
    'e.ToolTipSize = New Size(300, 300)
    'End Sub
    Dim pfc As New PrivateFontCollection()





    'Read up
    '-----------------------------------------------------------------------
    'Write down

    Public Sub usernamewriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("username:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
        objReader.Write(line.Replace(b, "username:" + TextBox1.Text))
        objReader.Close()


    End Sub


    Public Sub rememberaccountwriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("rememberaccount:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        If CheckBox1.Checked = True Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "rememberaccount:true"))
            objReader.Close()
        ElseIf CheckBox1.Checked = False Then
            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "rememberaccount:false"))
            objReader.Close()

        End If


    End Sub


    Public Sub versionnumberwriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("versionnumber:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
        objReader.Write(line.Replace(b, "versionnumber:" + ComboBox1.Text))
        objReader.Close()


    End Sub
    'Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles LauncherToolTip.Popup
    'e.ToolTipSize = New Size(300, 300)
    'End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Dim i As Integer
        i = Rnd() * 15 + 1

        Select Case i

            Case 1
                Me.BackgroundImage = My.Resources.Version130
            Case 2
                Me.BackgroundImage = My.Resources.UpdateHover
            Case 3
                Me.BackgroundImage = My.Resources.Visit
            Case 4
                Me.BackgroundImage = My.Resources.VisitHover
            Case 5
                Me.BackgroundImage = My.Resources.VisitHover1
            Case 6
                Me.BackgroundImage = My.Resources.Warning
            Case 7
                Me.BackgroundImage = My.Resources.UnableToLoadNews
            Case 8
                Me.BackgroundImage = My.Resources.Thanks2
            Case 9
                Me.BackgroundImage = My.Resources.TextBG2
            Case 10
                Me.BackgroundImage = My.Resources.Promise
            Case 11
                Me.BackgroundImage = My.Resources.OutOfDate
            Case 12
                Me.BackgroundImage = My.Resources.OptionsHover
            Case 13
                Me.BackgroundImage = My.Resources.Options1
            Case 14
                Me.BackgroundImage = My.Resources.online
            Case 15
                Me.BackgroundImage = My.Resources.ModsHover


        End Select

    End Sub
    'Dim Timer2 As Timer

    Public Sub runtimecatchwriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
       

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("runtimecatch:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        If b = "runtimecatch:false" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "runtimecatch:true"))
            objReader.Close()

        End If


    End Sub


    Public Sub tagoptionswriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("tagoptions:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        If b = "tagoptions:false" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "tagoptions:true"))
            objReader.Close()

        End If


    End Sub


    Public Sub memorypasswriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("memorypass:") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")
            line = sr.ReadToEnd()
        End Using

        If b = "memorypass:false" Then

            Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            'objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/options.txt")
            objReader.Write(line.Replace(b, "memorypass:true"))
            objReader.Close()

        End If


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load




        Dim di As New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions")
        For Each subdi As DirectoryInfo In di.GetDirectories

            'MsgBox(subdi.Name)
            ComboBox1.Items.Add(subdi.Name)
        Next


        readoptions()



        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()



        If runtimecatch = "false" Then
            WebBrowser1.Navigate(New Uri("http://www.tagcraftmc.com/launcherhits"))
        ElseIf runtimecatch = "true" Then
            WebBrowser1.Navigate(New Uri("http://www.tagcraftmc.com/launcherads"))
        End If

        '------------------------------------------------------------

        runtimecatchwriter()


        If TextBox1.Text = "" Then
            TextBox1.Select()
        Else
            'nothing
        End If

    End Sub
    Public Sub lv()
        Dim client As WebClient = New WebClient()
        If InternetConnection() = False Then
            LauncherVersion = True

        Else
            Try
                Dim URL As String = "http://cp.tagcraftmc.com/status/LauncherVersion/Version.http"
                Dim result As String = client.DownloadString(URL)
                'Debug.Print("DEBUG CHECK STRING DOWNLOAD: {0}", result)
                If (LCase(Label4.Text) = result) Then 'lower case it all incase I am drunk and do VeRsIoN 9001

                    LauncherVersion = True
                Else

                    LauncherVersion = False
                End If

            Catch ex As Exception

                LauncherVersion = False

            End Try
        End If


    End Sub


    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://cp.tagcraftmc.com/status/LauncherVersion/Version.http")
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tagoptionswriter()
        Form2.Show()
    End Sub

    Private Sub HelpBTN_Click(sender As Object, e As EventArgs) Handles HelpBTN.Click
        HelpBrowser.Show()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()

    End Sub
    Private Sub lvLBL_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvLBL.MouseDown
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com/launcherupdate")
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter

        Button4.BackgroundImage = My.Resources.VisitHover

    End Sub
    Private Sub Button4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave

        Button4.BackgroundImage = My.Resources.Visit

    End Sub
    Private Sub Button2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter

        Button2.BackgroundImage = My.Resources.OptionsHover

    End Sub
    Private Sub Button2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave

        Button2.BackgroundImage = My.Resources.Options

    End Sub
    Private Sub HelpBTN_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBTN.MouseEnter

        HelpBTN.BackgroundImage = My.Resources.HelpandInfoHover

    End Sub
    Private Sub HelpBTN_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpBTN.MouseLeave

        HelpBTN.BackgroundImage = My.Resources.HelpandInfo

    End Sub
    Private Sub Button3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter

        Button3.BackgroundImage = My.Resources.ExitHover

    End Sub
    Private Sub Button3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave

        Button3.BackgroundImage = My.Resources.Exit_

    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.BackgroundImage = My.Resources.LaunchHover

    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Button1.BackgroundImage = My.Resources.Launch

    End Sub
    Private Sub Button5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter

        Button5.BackgroundImage = My.Resources.UpdateHover

    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave

        Button5.BackgroundImage = My.Resources.Update

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com")
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "HelloChalkie" Or TextBox1.Text = "HelloAmmar" Then
            MessageBox.Show("Hello " + Environment.UserName + " how is it going? Congrats on finding an Easter Egg/Secret." + Environment.NewLine + "We hope you're enjoying Minecraft and have a great day." + Environment.NewLine + "- TagCraftMC", "Hi Five, you found an Easter Egg/Secret", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        progresshere = 0
        TagAPIx.Class1.optionreader()
        TagAPIx.Class1.main()
        TagAPIx.Class1.extractfile()


    End Sub

    Public Sub aftereverything()
        mainx()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UpdatesandMods.Show()
    End Sub

    Public Shared username As String
    Public Shared versionnumber As String
    Public Shared rememberaccount As String
    Public Shared debugmode As String
    Public Shared memory As String
    Public Shared memorypass As String
    Public Shared tagoptions As String
    Public Shared runtimecatch As String
    'structure of options.txt
    'username:Ammar_Ahmad
    'versionnumber:
    'rememberaccount:
    'debugmode:
    'memory:
    'tagoptions:
    'runtimecatch:


    Public Sub readoptions()
        'how options will work...
        '1 file read. it has options in this format (option):(value)
        'vb project saves ONLY! (read on load!)
        'C# api reads ONLY!

        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            Dim a As String

            Do
                a = reader.ReadLine

                Try
                    If a.Contains("username:") Then
                        username = a.Replace("username:", "")

                        TextBox1.Text = username

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("versionnumber:") Then
                        versionnumber = a.Replace("versionnumber:", "")

                        ComboBox1.Text = versionnumber

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("rememberaccount:") Then
                        rememberaccount = a.Replace("rememberaccount:", "")

                        If rememberaccount = "true" Then
                            CheckBox1.Checked = True
                        ElseIf rememberaccount = "false" Then
                            CheckBox1.Checked = False
                            TextBox1.Text = ""
                        Else
                            CheckBox1.Checked = False
                            TextBox1.Text = ""
                        End If

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("debugmode:") Then
                        debugmode = a.Replace("debugmode:", "")

                        If debugmode = "true" Then
                            Form2.CheckBox1.Checked = True
                            Form2.check = True

                        ElseIf debugmode = "false" Then
                            Form2.CheckBox1.Checked = False
                            Form2.check = False

                        Else
                            Form2.CheckBox1.Checked = False
                            Form2.check = False

                        End If

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("memory:") Then
                        memory = a.Replace("memory:", "")
                        If debugmode = "true" Then
                            Form2.ComboBox2.Text = "512M"
                        ElseIf debugmode = "false" Then
                            Form2.ComboBox2.Text = memory
                        End If

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("memorypass:") Then
                        memorypass = a.Replace("memorypass:", "")

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("tagoptions:") Then
                        tagoptions = a.Replace("tagoptions:", "")

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("runtimecatch:") Then
                        runtimecatch = a.Replace("runtimecatch:", "")

                    Else
                        ' do nothing!
                    End If

                Catch ex As Exception
                    'a is nothing now...
                End Try

            Loop Until a Is Nothing

            reader.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        oReadp = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ComboBox1.Text + ".txt")
        version = oReadp.ReadLine


        oReadp.Close()
        aftereverything()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim client As WebClient = New WebClient()
        Try
            Dim URL As String = "http://tagcraftmc.net78.net/info/test.rtf"
            Dim updatesinfo As String = client.DownloadString(URL)

            TransparentRichTextBox1.Rtf = updatesinfo

        Catch ex As Exception
            'nothin
        End Try

    End Sub
End Class
