
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection


Module Module1
    Sub Main()
        '  a()
        Console.ReadLine()
    End Sub
    Sub ammar1()
        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        End

    End Sub

    Sub yasir1()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"

        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar2()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text


        End

    End Sub

    Sub yasir2()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar3()


        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        End


    End Sub

    Sub yasir3()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        ' info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar4()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir4()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"


        '                    info.Arguments = "-Xms" + "256m" + " -Xmx" + mem + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar5()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text

        End

    End Sub

    Sub yasir5()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar6()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End



    End Sub

    Sub yasir6()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar7()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir7()
        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        ' info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar8()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir8()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '         info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar9()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End


    End Sub

    Sub yasir9()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar10()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir10()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
        '                info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar11()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir11()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar12()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir12()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '         info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar13()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End


    End Sub

    Sub yasir13()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar14()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)



        End

    End Sub
    Sub yasir14()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
        '                info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -AMMARS_CAMEL_CRAFT_#2013_#TagCraftMC --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets"
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub mainx()
        Dim process As New Process
        Dim info As New ProcessStartInfo
        If Form1.ver.Contains("LiteLoader") Then

            If Environment.Is64BitOperatingSystem = True Then

                Try
                    If Form1.mempass = "0" Then
                        '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                        'programfiles for 64 bit
                        'x86 for 32
                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir1x()

                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir2x()

                        ElseIf Form2.CheckBox1.Checked = True Then
                            yasir3x()


                        End If


                    ElseIf Form1.mempass = "1" Then

                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then

                            yasir4x()


                        ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir5x()


                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir6x()


                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir7x()


                        End If



                    End If





                Catch ex As Exception

                    If Form1.mempass = "0" Then

                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir8x()


                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir9x()


                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir10x()

                        End If

                    ElseIf Form1.mempass = "1" Then
                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then
                            yasir11x()


                        ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir12x()

                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir13x()

                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir14x()

                        End If

                    End If
                End Try


            ElseIf Environment.Is64BitOperatingSystem = False Then


                If Form1.mempass = "0" Then
                    '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    'programfiles for 64 bit
                    'x86 for 32
                    If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                        ammar1x()

                    ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                        ammar2x()

                    ElseIf Form2.CheckBox1.Checked = True Then
                        ammar3x()


                    End If


                ElseIf Form1.mempass = "1" Then

                    If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then

                        ammar4x()


                    ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                        ammar5x()


                    ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                        ammar6x()


                    ElseIf Form2.CheckBox1.Checked = True Then

                        ammar7x()


                    End If



                End If





            End If

















            '----------------------------------------------------------------------------------------









        Else

















            '------------------------------------------------------------------------

            If Environment.Is64BitOperatingSystem = True Then

                Try
                    If Form1.mempass = "0" Then
                        '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                        'programfiles for 64 bit
                        'x86 for 32
                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir1()

                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir2()

                        ElseIf Form2.CheckBox1.Checked = True Then
                            yasir3()


                        End If


                    ElseIf Form1.mempass = "1" Then

                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then

                            yasir4()


                        ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir5()


                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir6()


                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir7()


                        End If



                    End If





                Catch ex As Exception

                    If Form1.mempass = "0" Then

                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir8()


                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir9()


                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir10()

                        End If

                    ElseIf Form1.mempass = "1" Then
                        If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then
                            yasir11()


                        ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                            yasir12()

                        ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                            yasir13()

                        ElseIf Form2.CheckBox1.Checked = True Then

                            yasir14()

                        End If

                    End If
                End Try


            ElseIf Environment.Is64BitOperatingSystem = False Then


                If Form1.mempass = "0" Then
                    '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    'programfiles for 64 bit
                    'x86 for 32
                    If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                        ammar1()

                    ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                        ammar2()

                    ElseIf Form2.CheckBox1.Checked = True Then
                        ammar3()


                    End If


                ElseIf Form1.mempass = "1" Then

                    If Form1.accessOP = "0" And Form2.CheckBox1.Checked = False And Form1.mempass = "1" Then

                        ammar4()


                    ElseIf Form1.accessOP = "0" And Form2.CheckBox1.Checked = False Then
                        ammar5()


                    ElseIf Form1.accessOP = "1" And Form2.CheckBox1.Checked = False Then
                        ammar6()


                    ElseIf Form2.CheckBox1.Checked = True Then

                        ammar7()


                    End If



                End If





            End If


        End If

    End Sub















    Sub ammar1x()
        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        End

    End Sub

    Sub yasir1x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"

        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar2x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text


        End

    End Sub

    Sub yasir2x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar3x()


        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        End


    End Sub

    Sub yasir3x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        ' info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar4x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir4x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"


        '                    info.Arguments = "-Xms" + "256m" + " -Xmx" + mem + " -Dsun.java2d.noddraw=true" + " -Dsun.awt.noerasebackground=true" + " -Dsun.java2d.d3d=false" + " -Dsun.java2d.opengl=false" + " -Dsun.java2d.pmoffscreen=false" + " -Djava.library.path=" + appData + "natives -cp " + appData + "minecraft.jar;" + appData + "jinput.jar;" + appData + "lwjgl.jar;" + appData + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar5x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        '        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagCraftMC -cp " + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.client.main.Main --username " + Form1.TextBox1.Text + " --session -0 --version 1.6.2 --gameDir" + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + appData + "assets", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        '           info.Arguments = "-Dsun.java2d.noddraw=true -Dsun.awt.noerasebackground=true -Dsun.java2d.d3d=false -Dsun.java2d.opengl=false -Dsun.java2d.pmoffscreen=false -Djava.library.path=" + text + "natives -cp " + text + "minecraft.jar;" + text + "jinput.jar;" + text + "lwjgl.jar;" + text + "lwjgl_util.jar net.minecraft.client.Minecraft " + Me.TextBox1.Text

        End

    End Sub

    Sub yasir5x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar6x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End



    End Sub

    Sub yasir6x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        'info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar7x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir7x()
        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        ' info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar8x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir8x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '         info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar9x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End


    End Sub

    Sub yasir9x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar10x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir10x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
        '                info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar11x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir11x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar12x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir12x()

        Dim q As String
        q = Chr(34)

        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '         info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar13x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End


    End Sub

    Sub yasir13x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        '                info.FileName = "javaw"
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = "-Xmx" + Form1.mem + " -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        '-Xms" + MiniRam[MiniRamCMBO.SelectedIndex] + " -Xmx" + MaxRam[MaxiRamCMBO.SelectedIndex] + " "
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar14x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)



        End

    End Sub
    Sub yasir14x()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe"
        '                info.FileName = "java"
        '  info.CreateNoWindow = True
        info.Arguments = "-Xmx512m -Djava.library.path=" + appData + "versions\" + Form1.ver + "\" + Form1.ver + "_TagcraftMC -cp " + appData + "libraries\com\mumfrey\liteloader\1.6.2\liteloader-1.6.2.jar;" + appData + "libraries\net\minecraft\launchwrapper\1.3\launchwrapper-1.3.jar;" + appData + "libraries\lzma\lzma\0.0.1\lzma-0.0.1.jar;" + appData + "libraries\net\sf\jopt-simple\jopt-simple\4.5\jopt-simple-4.5.jar;" + appData + "libraries\com\paulscode\codecjorbis\20101023\codecjorbis-20101023.jar;" + appData + "libraries\com\paulscode\codecwav\20101023\codecwav-20101023.jar;" + appData + "libraries\com\paulscode\libraryjavasound\20101123\libraryjavasound-20101123.jar;" + appData + "libraries\com\paulscode\librarylwjglopenal\20100824\librarylwjglopenal-20100824.jar;" + appData + "libraries\com\paulscode\soundsystem\20120107\soundsystem-20120107.jar;" + appData + "libraries\argo\argo\2.25_fixed\argo-2.25_fixed.jar;" + appData + "libraries\org\bouncycastle\bcprov-jdk15on\1.47\bcprov-jdk15on-1.47.jar;" + appData + "libraries\com\google\guava\guava\14.0\guava-14.0.jar;" + appData + "libraries\org\apache\commons\commons-lang3\3.1\commons-lang3-3.1.jar;" + appData + "libraries\commons-io\commons-io\2.4\commons-io-2.4.jar;" + appData + "libraries\net\java\jinput\jinput\2.0.5\jinput-2.0.5.jar;" + appData + "libraries\net\java\jutils\jutils\1.0.0\jutils-1.0.0.jar;" + appData + "libraries\com\google\code\gson\gson\2.2.2\gson-2.2.2.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl\2.9.0\lwjgl-2.9.0.jar;" + appData + "libraries\org\lwjgl\lwjgl\lwjgl_util\2.9.0\lwjgl_util-2.9.0.jar;" + appData + "versions\" + Form1.ver + "\" + Form1.ver + ".jar net.minecraft.launchwrapper.Launch --username " + Form1.TextBox1.Text + " --session token:0 --gameDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft" + q + " --assetsDir " + q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/assets" + q + " --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker"
        process.StartInfo = info
        process.Start()


        End

    End Sub
















    '        retValue = CreateProcess("c:\\windows\\system32\\NotePad.exe", Nothing, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
    '  retValue = CreateProcess("c:\\windows\\system32\\NotePad.exe", " C:\Users\Ammar\Desktop\a.txt", IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure PROCESS_INFORMATION
        Public hProcess As IntPtr
        Public hThread As IntPtr
        Public dwProcessID As UInteger
        Public dwThreadID As UInteger
    End Structure 'PROCESS_INFORMATION

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure SECURITY_ATTRIBUTES
        Public nLength As Integer
        Public lpSecurityDescriptor As IntPtr
        Public bInheritHandle As Boolean
    End Structure 'SECURITY_ATTRIBUTES

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure STARTUPINFO
        Public cb As UInteger
        Public lpReserved As String
        Public lpDesktop As String
        Public lpTitle As String
        Public dwX As UInteger
        Public dwY As UInteger
        Public dwXSize As UInteger
        Public dwYSize As UInteger
        Public dwXCountChars As UInteger
        Public dwYCountChars As UInteger
        Public dwFillAttribute As UInteger
        Public dwFlags As UInteger
        Public wShowWindow As Short
        Public cbReserved2 As Short
        Public lpReserved2 As IntPtr
        Public hStdInput As IntPtr
        Public hStdOutput As IntPtr
        Public hStdError As IntPtr
    End Structure 'STARTINFO
    <DllImport("kernel32.dll")> _
    Function CreateProcess( _
    ByVal lpApplicationName As String, _
    ByVal lpCommandLine As String, _
    ByVal lpProcessAttributes As IntPtr, _
    ByVal lpThreadAttributes As IntPtr, _
    ByVal bInheritHandles As Boolean, _
    ByVal dwCreationFlags As UInteger, _
    ByVal lpEnvironment As IntPtr, _
    ByVal lpCurrentDirectory As String, _
    ByRef lpStartupInfo As STARTUPINFO, _
    ByRef lpProcessInformation As PROCESS_INFORMATION) As Boolean
    End Function
End Module