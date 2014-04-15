Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection
Imports System.Drawing.Text
Imports TagAPIx
Imports Newtonsoft.Json
Imports System.Text

'username:Ammar_Ahmad
'versionnumber:1.7.8
'rememberaccount:true
'debugmode:true
'memorypass:true
'memory:3072M
'tagoptions:true
'runtimecatch:true
'latestcrash:{pathcomeshere}


Public Class Form1
    Implements IComparer

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
    Public Shared URL As String
    Public Shared result As String

    Dim server As Boolean

    Dim HG As Boolean

    Dim TS As Boolean

    Dim LauncherVersion As Boolean
    Dim updatenonet As Boolean
    Dim updatesinfo As String
    Dim updatesinforesult As String

    Dim UUIDCon As String

    Public Shared accessOP As String

    Dim line As String

    Dim oFilep As System.IO.File
    Dim oWritep As System.IO.StreamWriter
    Dim oReadp As System.IO.StreamReader



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox1.Text = " " Or TextBox1.Text = "  " Or TextBox1.Text = "   " Or TextBox1.Text = "    " Or TextBox1.Text = "     " Or TextBox1.Text = "      " Or TextBox1.Text = "       " Or TextBox1.Text = "        " Or TextBox1.Text = "         " Or TextBox1.Text = "          " Or TextBox1.Text = "           " Or TextBox1.Text = "            " Or TextBox1.Text = "             " Or TextBox1.Text = "              " Or TextBox1.Text = "               " Or TextBox1.Text = "                " Then
                MessageBox.Show("Please choose an Account Name. This is needed even if you're just playing Single Player", "Are you my mommy?")
            ElseIf ComboBox1.Text = "" Then
                MessageBox.Show("Please choose a Version. This is needed even if you're just playing Single Player", "Are you my mommy?")
            Else
                Button1.BackgroundImage = My.Resources.LoadingUUID
                Label9.Visible = True
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


    Public Sub latestcrashwriter()
        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

        Dim a As String
        Dim b As String = ""


        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("latestcrash:") Then
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
        objReader.Write(line.Replace(b, "latestcrash:" + pathoferror))
        objReader.Close()


    End Sub

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
                Me.BackgroundImage = My.Resources.NewsBGV9
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


    Dim dirinfo As DirectoryInfo
    Dim allFiles() As FileInfo

    Dim pathoferror As String
    Dim getoldlogtocheckwithnew As String

    Dim error_on_off As Integer = 0


    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Try

            Dim File1 As FileInfo
            Dim File2 As FileInfo

            File1 = DirectCast(x, FileInfo)
            File2 = DirectCast(y, FileInfo)

            Compare = DateTime.Compare(File1.LastWriteTime, File2.LastWriteTime)


        Catch ex As Exception

        End Try


        Dim returnval As Integer
        Return returnval

    End Function

    Public Sub lookuplog()
        Try

            dirinfo = New DirectoryInfo((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/crash-reports"))

            allFiles = dirinfo.GetFiles("*.txt")
            Array.Sort(allFiles, New Form1)
            For Each fl As FileInfo In allFiles
                'MsgBox(fl.FullName.ToString())
                fl.FullName.ToString()
                If Not fl.FullName.ToString() = vbNullString Then
                    pathoferror = fl.FullName.ToString()

                End If
            Next

            'MsgBox(pathoferror)
            'get latest log...

            If getoldlogtocheckwithnew = pathoferror Then
                'do nothing...
            Else
                'new error log stored.
                latestcrashwriter()

                If pathoferror = vbNullString Then
                    ' do nothing...
                Else

                    '  MsgBox(pathoferror)
                    error_on_off = 1

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub BackgroundWorker5_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label9.Location = New Point(294, 449)
        Try
            File.Delete("launcher.old.exe")
        Catch ex As Exception

        End Try
        Try
            File.Delete("ClientUpdate.zip")
        Catch ex As Exception

        End Try
        Try
            File.Delete("MinecraftUpdate.zip")
        Catch ex As Exception

        End Try

        'error log stuff here...

       
       


        Dim di As New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions")
        For Each subdi As DirectoryInfo In di.GetDirectories

            'MsgBox(subdi.Name)
            ComboBox1.Items.Add(subdi.Name)
        Next


        readoptions()

        lookuplog()

        If error_on_off = 1 Then
            MsgBox(pathoferror)
        End If

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
                URL = "http://files.tagcraftmc.com/launcher/clientversions.html?t=" + DateTime.Now.ToLocalTime()
                result = (LCase(client.DownloadString(URL)))
                'Debug.Print("DEBUG CHECK STRING DOWNLOAD: {0}", result)
                If (LCase(Label4.Text) = result) Then 'lower case it all incase I am drunk and do VeRsIoN 9001

                    LauncherVersion = True
                    'Debug.Print("Worked")
                Else

                    LauncherVersion = False
                    'Debug.Print("Failed")
                End If

            Catch ex As Exception

                LauncherVersion = False
                'Debug.Print("Crash")

            End Try
        End If


    End Sub


    Private Function InternetConnection() As Boolean
        Dim req As System.Net.WebRequest = System.Net.WebRequest.Create("http://files.tagcraftmc.com/launcher/clientversions.html?t=" + DateTime.Now.ToLocalTime())
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

    Public Sub readoptionsforoptions()

        Try

            Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/options.txt")

            Dim a As String

            Do
                a = reader.ReadLine

                Try

                    If a.Contains("debugmode:") Then
                        debugmode = a.Replace("debugmode:", "")

                        If debugmode = "true" Then
                            Form2.ComboBox4x.Text = "Enabled"
                            Form2.check = True

                        ElseIf debugmode = "false" Then
                            Form2.ComboBox4x.Text = "Disabled"
                            Form2.check = False

                        Else
                            Form2.ComboBox4x.Text = "Disabled"
                            Form2.check = False

                        End If

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("memory:") Then
                        memory = a.Replace("memory:", "")
                        Form2.ComboBox1.Text = memory

                    Else
                        ' do nothing!
                    End If


                Catch ex As Exception

                End Try

            Loop Until a Is Nothing

            reader.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tagoptionswriter()
        readoptionsforoptions()
        Form2.Show()
    End Sub

    Private Sub HelpBTN_Click(sender As Object, e As EventArgs) Handles HelpBTN.Click
        'There is really no need to create a browser for help, just open a page.
        'HelpBrowser.Show()
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com/launcherhelp")
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

        Button5.BackgroundImage = My.Resources.MinecraftUpdatesHover

    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave

        Button5.BackgroundImage = My.Resources.MinecraftUpdates

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

    Dim responseFromServer As String

    Public Sub getUUID()
        Try

            Dim request As WebRequest = WebRequest.Create("https://api.mojang.com/profiles/minecraft")

            request.Method = "POST"

            Dim postData As String = "[""" + TextBox1.Text + """]"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/json"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            responseFromServer = reader.ReadToEnd()

            reader.Close()
            dataStream.Close()
            response.Close()

            'if it doesn't contain id go offline mode

            If responseFromServer.Contains("""id""") Then
                'convert it to xml
                convert_json_UUID_to_Xml_UUID_bc_I_Still_Dont_Know_How_To_Work_With_Json()

            End If

            If Not responseFromServer.Contains("""id""") Then
                responseFromServer = "OFFLINE_MODE"
                UUIDCon = responseFromServer

            End If




        Catch ex As Exception
            ' yeah I am lazy... screw proper error handling

            responseFromServer = "OFFLINE_MODE"
            UUIDCon = responseFromServer

        End Try

        'save value to the txt generated.

    End Sub

    Dim jsonString As String

    Public Sub convert_json_UUID_to_Xml_UUID_bc_I_Still_Dont_Know_How_To_Work_With_Json()
        Try
            responseFromServer = responseFromServer.Replace("[", "")
            responseFromServer = responseFromServer.Replace("]", "")

            Dim node As XNode = JsonConvert.DeserializeXNode(responseFromServer, "Root")

            jsonString = node.ToString()

            '-------------------------- Get the UUID from the XML ----------------------------

            GetVal_UUID()

        Catch ex As Exception
            responseFromServer = "OFFLINE_MODE"
            UUIDCon = responseFromServer
        End Try
    End Sub


    Public Sub GetVal_UUID()
        Try

            Dim aLine As String
            Dim strReader As New StringReader(jsonString)

            While True
                aLine = strReader.ReadLine()
                If aLine Is Nothing Then

                    Exit While
                Else
                    If aLine.Contains("<id>") Then
                        'MsgBox(aLine)
                        'put the UUID to variable...
                        aLine = aLine.Replace("<id>", "")
                        aLine = aLine.Replace("</id>", "")
                        aLine = aLine.Replace(" ", "")
                        UUIDCon = aLine

                        Exit While
                    End If
                End If
            End While

        Catch ex As Exception
            responseFromServer = "OFFLINE_MODE"
            UUIDCon = responseFromServer

        End Try
    End Sub


    Public Sub writeUUIDtoVersions()

        Dim reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ComboBox1.Text + ".txt")

        Dim a As String
        Dim b As String = ""
        Dim x As String = "--uuid OFFLINE_MODE"

        Do
            a = reader.ReadLine
            'MsgBox(a)
            Try
                If a.Contains("--uuid OFFLINE_MODE") Then
                    b = a
                    'MsgBox(a)
                End If
            Catch ex As Exception
                'a is nothing now...
            End Try

        Loop Until a Is Nothing

        reader.Close()

        '
        Using sr As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ComboBox1.Text + ".txt")
            line = sr.ReadToEnd()
        End Using


        line = line.Replace("--uuid OFFLINE_MODE", "--uuid " + UUIDCon)
        Dim objReader As New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ComboBox1.Text + ".txt")



        objReader.Write(line)
        objReader.Close()

        version = line



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' this is a timeout method so that MC starts up at X time
        mainx()
    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        getUUID()

    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        writeUUIDtoVersions()
        mainx()

    End Sub

    Public Sub aftereverything()
        Timer1.Enabled = True

        BackgroundWorker4.RunWorkerAsync()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UpdatesandMods.Show()
    End Sub

    Public Shared username As String
    Public Shared versionnumber As String
    Public Shared rememberaccount As String
    Public Shared debugmode As String
    Public Shared memory As String
    Public Shared memoryx As Integer
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
                            Form2.ComboBox4x.Text = "Enabled"
                            Form2.check = True

                        ElseIf debugmode = "false" Then
                            Form2.ComboBox4x.Text = "Disabled"
                            Form2.check = False

                        Else
                            Form2.ComboBox4x.Text = "Disabled"
                            Form2.check = False

                        End If

                    Else
                        ' do nothing!
                    End If

                    If a.Contains("memory:") Then
                        memory = a.Replace("memory:", "")
                        Form2.ComboBox1.Text = memory

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

                    If a.Contains("latestcrash:") Then
                        getoldlogtocheckwithnew = a.Replace("latestcrash:", "")

                        ' MsgBox(getoldlogtocheckwithnew)
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

    Public Sub readjsonforurl()
        Dim FILE_NAME As String = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions/" + ComboBox1.Text + "/" + ComboBox1.Text + ".json")

        Dim TextLine As String = ""

        Dim objReader As New System.IO.StreamReader(FILE_NAME)

        Do While objReader.Peek() <> -1

            TextLine = TextLine & objReader.ReadLine() & vbNewLine

        Loop

        If TextLine.Contains("url") Then
            If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/versions/" + ComboBox1.Text + "/DownloadR.AMMAR") = False Then

                DownloadR.Show()
            Else
                aftereverything()
            End If
            ' DownloadR.Show()
        Else
            aftereverything()
        End If

        '        MsgBox("File Does Not Exist")

    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        oReadp = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/versions/" + ComboBox1.Text + ".txt")
        version = oReadp.ReadLine


        oReadp.Close()
        '------------------ File resource downloader comes here...

        'open file check if it contains any url in it. if it does do downloadr.show
        ' else do aftereverything()

        readjsonforurl()

        ' 
    End Sub
    Public Sub newsupdate()
        Dim client As WebClient = New WebClient()
        If InternetConnection() = False Then
            updatenonet = True

        Else
            Try
                Dim URL As String = "http://files.tagcraftmc.com/launcher/minecraftnews.html?t=" + DateTime.Now.ToLocalTime()
                updatesinforesult = client.DownloadString(URL).Replace("\red0\green0\blue0", "\red255\green255\blue255")

                'updatesinforesult.Replace("\red0\green176\blue80", "\red255\green255\blue255")
                'TransparentRichTextBox2.Find("\red0\green176\blue80")
                'TransparentRichTextBox2.SelectedText = "\red255\green255\blue255"

                'updatesinforesult = updatesinfo

            Catch ex As Exception
                '
            End Try
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        lv()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If LauncherVersion = False Then
            'lvLBL.Visible = True
            Form3.Show()

        ElseIf LauncherVersion = True Then
            'lvLBL.Visible = False
        End If
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        newsupdate()
    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If updatenonet = True Then
            TransparentRichTextBox2.Text = "Unable to get the news, sorry"
        Else
            TransparentRichTextBox2.Rtf = updatesinforesult
        End If

    End Sub


    Private Sub TransparentRichTextBox2_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles TransparentRichTextBox2.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False
        ElseIf CheckBox1.Checked = False Then
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub LauncherToolTip_Popup(sender As Object, e As PopupEventArgs) Handles LauncherToolTip.Popup

    End Sub

End Class
