Imports System.Net.Sockets
Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Net

Public Class Form1
    Dim nom As String
    Dim nomx As String

    Dim mem As String
    Dim mempass As String


    Dim server As Boolean

    Dim HG As Boolean

    Dim TS As Boolean

    Dim LauncherVersion As Boolean


    Dim accessOP As String
    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim line As String

    Dim oFilex As System.IO.File
    Dim oWritex As System.IO.StreamWriter
    Dim oReadx As System.IO.StreamReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim q As String
        q = TextBox2.Text


        Try
            Dim objReader As StreamWriter


            objReader = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
            objReader.Write(TextBox1.Text)
            objReader.Close()

        Catch ex As Exception

        End Try



        Try

            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()


            If mem = vbNullString Then
                mempass = "0"

            Else
                mempass = "1"

            End If

        Catch ex As Exception

        End Try



        Try
            If mempass = "0" Then
                '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                'programfiles for 64 bit
                'x86 for 32
                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + q + " --assetsDir " + appData + "assets"

                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    ' info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                End If











            ElseIf mempass = "1" Then

                If accessOP = "0" And Form2.CheckBox1.Checked = False And mempass = "1" Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx" + mem + " -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"


                    '                    info.Arguments = "-Xms" + "256m" + " -Xmx" + mem + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End



                ElseIf accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    'info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx" + mem + " -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    ' info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                End If



            End If





        Catch ex As Exception

            If mempass = "0" Then

                If accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '         info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '                info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
                    '                info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                End If

            ElseIf mempass = "1" Then
                If accessOP = "0" And Form2.CheckBox1.Checked = False And mempass = "1" Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '                info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx" + mem + " -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End


                ElseIf accessOP = "0" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '         info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End
                ElseIf accessOP = "1" And Form2.CheckBox1.Checked = False Then
                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    '                info.FileName = "javaw"
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
                    info.CreateNoWindow = True
                    info.Arguments = "-Xmx" + mem + " -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -0 --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
                    process.StartInfo = info
                    process.Start()
                    End

                ElseIf Form2.CheckBox1.Checked = True Then

                    Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
                    Dim process As New Process
                    Dim info As New ProcessStartInfo
                    info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
                    '                info.FileName = "java"
                    '  info.CreateNoWindow = True
                    info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\1.6.1\1.6.1_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\1.6.1\1.6.1.jar net.minecraft.client.main.Main --username " + TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.1 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
                    process.StartInfo = info
                    process.Start()
                    End

                End If

            End If
        End Try



    End Sub

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        accessOP = "0"

        BackgroundWorker1.RunWorkerAsync()
        'SavedTooltilForeColor = GetSysColor(COLOR_INFOTEXT) 'save fore color

        'Try
        'Dim toolTip1 As New ToolTip()
        'toolTip1.AutoPopDelay = 5000
        'toolTip1.InitialDelay = 1000
        'toolTip1.ReshowDelay = 500
        'toolTip1.ShowAlways = True
        'toolTip1.SetToolTip(Me.Button1, "My button1")
        'toolTip1.SetToolTip(Me.Button2, "My Button1")
        'toolTip1.ToolTipTitle("help")
        'Catch ex As Exception

        'End Try
        Try
            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/runtimecatch.txt")
            '            ComboBox2.Text = oReadx.ReadLine

            nomx = oReadx.ReadLine


            oReadx.Close()

          

        Catch ex As Exception

        End Try

        If nomx = "" Then
            WebBrowser1.Navigate(New Uri("http://www.tagcraftmc.com/launcherhits"))
        ElseIf nomx = "open" Then
            'do nothing

        End If


        Try

            Dim objReaderx As StreamWriter


            objReaderx = New StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/runtimecatch.txt")
            objReaderx.Write("open")
            objReaderx.Close()

        Catch ex As Exception

        End Try

        Try
            oRead = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/taguser.txt")
            TextBox1.Text = oRead.ReadLine


            oRead.Close()


            oReadx = IO.File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/TagCraftMC Files/Settings/memory.txt")
            mem = oReadx.ReadLine


            oReadx.Close()


        Catch ex As Exception

        End Try

        If TextBox1.Text = "" Then
            TextBox1.Select()
        Else
            'nothing
        End If

        If mem = vbNullString Then
            mempass = "0"

        Else
            mempass = "1"

        End If

        '        x()
        '       y()
        '      z()
    End Sub




    Public Sub x()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            '     tcpClient.Connect("192.95.29.101", 25565)
            tcpClient.Connect("factions.tagcraftmc.com", 25565)

            'main   
            '            ToolStripStatusLabel1.Visible = True
            server = True

        Catch ex As Exception
            'ToolStripStatusLabel3.Visible = True
            server = False


        End Try
    End Sub

    Public Sub y()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            ' tcpClient.Connect("192.95.29.101", 25566)
            tcpClient.Connect("hungergames.tagcraftmc.com", 25566)

            'HG
            ' ToolStripStatusLabel2.Visible = True
            HG = True

        Catch ex As Exception
            'ToolStripStatusLabel4.Visible = True
            HG = False


        End Try
    End Sub

    Public Sub z()
        Dim tcpClient As TcpClient = New TcpClient()
        Try
            ' tcpClient.Connect("192.95.29.101", 25566)
            tcpClient.Connect("tsq.tagcraftmc.com", 10011)

            'TS
            '       ToolStripStatusLabel5.Visible = True
            TS = True

        Catch ex As Exception
            'ToolStripStatusLabel6.Visible = True
            TS = False

        End Try
    End Sub
    Public Sub lv()
        Dim client As WebClient = New WebClient()
        Try
            Dim URL As String = "http://files.enjin.com/256377/CamelLauncher/version.http"
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





    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        accessOP = "1"
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



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        '       System.Threading.Thread.Sleep(10)
        x()
        y()
        z()
        lv()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            a.Visible = False
            b.Visible = False
            c.Visible = False
            lvLBL.Visible = False

        Catch ex As Exception

        End Try

        If LauncherVersion = True Then
            lvLBL.Visible = False
            LinkLabel1.Visible = False


        Else
            lvLBL.Visible = True
            LinkLabel1.Visible = True

        End If

        If server = True Then
            ToolStripStatusLabel1.Visible = True
            ToolStripStatusLabel3.Visible = False


        Else
            ToolStripStatusLabel3.Visible = True
            ToolStripStatusLabel1.Visible = False


        End If

        If HG = True Then
            ToolStripStatusLabel2.Visible = True
            ToolStripStatusLabel4.Visible = False


        Else
            ToolStripStatusLabel4.Visible = True
            ToolStripStatusLabel2.Visible = False


        End If

        If TS = True Then
            ToolStripStatusLabel5.Visible = True
            ToolStripStatusLabel6.Visible = False


        Else
            ToolStripStatusLabel6.Visible = True
            ToolStripStatusLabel5.Visible = False

        End If

        BackgroundWorker1.RunWorkerAsync()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.tagcraftmc.com/launcherupdate")
    End Sub
End Class
