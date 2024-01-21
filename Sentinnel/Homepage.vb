Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class Homepage

    'code to move the form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    'Taskbar buttons
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
    End Sub

    Private Sub Max_Button_Click(sender As Object, e As EventArgs) Handles Max_Button.Click
        Me.WindowState = FormWindowState.Maximized
        Max_Button.Hide()
        Window_Button.Show()
    End Sub

    Private Sub Min_Button_Click(sender As Object, e As EventArgs) Handles Min_Button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Window_Button_Click(sender As Object, e As EventArgs) Handles Window_Button.Click
        Me.WindowState = FormWindowState.Normal
        Window_Button.Hide()
        Max_Button.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Hide()
        Admin_key.Hide()
    End Sub

    Private Sub Admin_button_Click(sender As Object, e As EventArgs) Handles Admin_button.Click
        Label4.Show()
        Admin_key.Show()
    End Sub

    Private Sub User_button_Click(sender As Object, e As EventArgs) Handles User_button.Click
        Label4.Hide()
        Admin_key.Hide()
    End Sub

    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        If Login_username.Text = "Toad" And Login_password.Text = "Toad" Then
            Me.Hide()
            Form1.Show()

        ElseIf Login_username.Text = "Toad" And Login_password.Text = "Toad" And Admin_key.Text = "Toad" Then

        End If
    End Sub
End Class