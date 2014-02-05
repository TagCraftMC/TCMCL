
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Reflection


Module Module1

    Sub Main()
        Console.ReadLine()
    End Sub
    Sub ammar1()
        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir1()

        Dim q As String
        q = Chr(34)
        Dim appData As String = q + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.minecraft/" + q
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar2()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()
        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir2()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar3()


        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End


    End Sub

    Sub yasir3()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        info.Arguments = Form1.version
        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar4()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir4()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version
        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar5()
        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()

        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir5()
        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar6()

        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End



    End Sub

    Sub yasir6()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar7()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir7()
        Dim q As String
        q = Chr(34)

        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar8()

        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir8()

        Dim q As String
        q = Chr(34)

        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar9()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End


    End Sub

    Sub yasir9()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar10()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir10()

        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub


    Sub ammar11()

        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End

    End Sub

    Sub yasir11()

        Dim q As String
        q = Chr(34)

        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar12()

        Dim q As String
        q = Chr(34)

        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)

        End

    End Sub

    Sub yasir12()

        Dim q As String
        q = Chr(34)

        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End
    End Sub

    Sub ammar13()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)
        End


    End Sub

    Sub yasir13()
        Dim q As String
        q = Chr(34)
        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.CreateNoWindow = True
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub ammar14()

        Dim q As String
        q = Chr(34)
        Dim retValue As Boolean
        Dim pInfo As PROCESS_INFORMATION = New PROCESS_INFORMATION()
        Dim sInfo As STARTUPINFO = New STARTUPINFO()


        retValue = CreateProcess(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\java.exe", Form1.version, IntPtr.Zero, IntPtr.Zero, False, 0, IntPtr.Zero, Nothing, sInfo, pInfo)



        End

    End Sub
    Sub yasir14()

        Dim q As String
        q = Chr(34)

        Dim process As New Process
        Dim info As New ProcessStartInfo
        info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Java\jre7\bin\javaw.exe"
        info.Arguments = Form1.version

        process.StartInfo = info
        process.Start()


        End

    End Sub

    Sub mainx()
        Dim process As New Process
        Dim info As New ProcessStartInfo

        If Environment.Is64BitOperatingSystem = True Then

            Try
                If Form1.memorypass = "false" Then
                    '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                    'programfiles for 64 bit
                    'x86 for 32
                    If Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                        yasir1()

                    ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                        yasir2()

                    ElseIf Form1.debugmode = "true" Then
                        yasir3()


                    End If


                ElseIf Form1.memorypass = "true" Then

                    If Form1.tagoptions = "false" And Form1.debugmode = "false" And Form1.memorypass = "true" Then

                        yasir4()


                    ElseIf Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                        yasir5()


                    ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                        yasir6()


                    ElseIf Form1.debugmode = "true" Then

                        yasir7()


                    End If



                End If





            Catch ex As Exception

                If Form1.memorypass = "false" Then

                    If Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                        ammar8()


                    ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                        ammar9()


                    ElseIf Form1.debugmode = "true" Then

                        ammar10()

                    End If

                ElseIf Form1.memorypass = "true" Then
                    If Form1.tagoptions = "false" And Form1.debugmode = "false" And Form1.memorypass = "true" Then
                        ammar11()


                    ElseIf Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                        ammar12()

                    ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                        ammar13()

                    ElseIf Form1.debugmode = "true" Then

                        ammar14()

                    End If

                End If
            End Try


        ElseIf Environment.Is64BitOperatingSystem = False Then


            If Form1.memorypass = "false" Then
                '  info.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\Java\jre7\bin\java.exe"
                'programfiles for 64 bit
                'x86 for 32
                If Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                    ammar1()

                ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                    ammar2()

                ElseIf Form1.debugmode = "true" Then
                    ammar3()


                End If


            ElseIf Form1.memorypass = "true" Then

                If Form1.tagoptions = "false" And Form1.debugmode = "false" And Form1.memorypass = "true" Then

                    ammar4()


                ElseIf Form1.tagoptions = "false" And Form1.debugmode = "false" Then
                    ammar5()


                ElseIf Form1.tagoptions = "true" And Form1.debugmode = "false" Then
                    ammar6()


                ElseIf Form1.debugmode = "true" Then

                    ammar7()


                End If



            End If





        End If


    End Sub


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