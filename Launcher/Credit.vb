
Public Class Credit
#Region "ClientAreaMove Handling"
    Private Const WM_NCHITTEST As Integer = &H84
    Private Const HTCLIENT As Integer = &H1
    Private Const HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then
                    m.Result = HTCAPTION
                End If
            Case Else
                'Make sure you pass unhandled messages back to the default message handler.
                MyBase.WndProc(m)
        End Select
    End Sub
#End Region

    Private Sub FadeForm(ByVal TotalSeconds As Single)
        If TotalSeconds = 0 Then
            Me.Opacity = 1
            Exit Sub
        End If

        Dim [then] As Double = DateAndTime.Timer
        Dim difference As Double = 0

        'difference is the percentage of the total seconds elapsed
        Do While difference < 1
            Me.Opacity = difference

            difference = (DateAndTime.Timer - [then]) / TotalSeconds
            System.Threading.Thread.Sleep(10)
        Loop

        Me.Opacity = 1

    End Sub

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        FadeForm(1.5)
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter

        Button1.BackgroundImage = My.Resources.ExitHover

    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave

        Button1.BackgroundImage = My.Resources.Exit_

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Credit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Form2.centerForm(Me) '// center Form of Main Form.
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://fontstruct.com/fontstructions/show/432966")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://www.youtube.com/user/CyborgPancakeZ")
    End Sub
End Class