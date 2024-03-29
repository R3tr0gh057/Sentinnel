﻿Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignUp

    'code to move the form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public loc As Point = Homepage.lastFormLocation
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\--PROJECTS2024--\Sentinnel\Sentinnel\SentinnelDB.mdf;Integrated Security=True;Connect Timeout=30"

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    'Taskbar buttons
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Close()
        Homepage.Show()
        Homepage.Location = New Point(Me.Location)
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

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Signup_Confirm_Click(sender As Object, e As EventArgs) Handles Signup_Confirm.Click
        'Database code to add user to the database
        Try
            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    ' Checking if the end user is authenticated
                    Dim query As String = "INSERT INTO [dbo].[UserDB] ([username], [password], [joindate], [firstname], [lastname], [filesScanned], [virusFrequency]) VALUES (N'@username      ', N'@password      ', N'@joindate', N'@firstname      ', N'@lastname      ', 0, 0)"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", Signup_username.Text)
                        command.Parameters.AddWithValue("@Password", Signup_password.Text)
                        command.Parameters.AddWithValue("@joindate", TimeOfDay.ToString)
                        command.Parameters.AddWithValue("@firstname", First_name.Text)
                        command.Parameters.AddWithValue("@lastname", Last_name.Text)

                        Me.Hide()
                        Form1.Show()
                        Form1.Location = New Point(Me.Location)

                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Me.Hide()
                    Form1.Show()
                    Form1.Location = New Point(Me.Location)
                End Try
            End Using

        Catch ex As Exception

        End Try

        Me.Close()
        Homepage.Show()
        Location = New Point(Me.Location)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class