Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Homepage

    'code to move the form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public lastFormLocation As Point

    Public user As String = ""
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\--PROJECTS2024--\Sentinnel\Sentinnel\SentinnelDB.mdf;Integrated Security=True;Connect Timeout=30"

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        lastFormLocation = Me.Location
    End Sub

    'Taskbar buttons
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Application.Exit()
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

    Private Sub Login_button_Click(sender As Object, e As EventArgs) Handles Login_button.Click

        ' Login logic using database
        Dim username As String = Login_username.Text
        Dim password As String = Login_password.Text

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                If (AdminCheck.Checked) Then
                    ' Checking if the admin is authenticated
                    Dim query As String = "SELECT COUNT(*) FROM AdminDB WHERE username = @Username AND password = @Password;"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            ' User exists with the provided username and password
                            ' Proceed with login
                            Me.Hide()
                            AdminPage.Show()
                            Form1.Location = New Point(Me.Location)
                        Else
                            MsgBox("Incorrect Credentials" + vbCrLf + username + vbCrLf + password)
                        End If
                    End Using

                Else
                    ' Checking if the end user is authenticated
                    Dim query As String = "SELECT COUNT(*) FROM UserDB WHERE Username = @Username AND Password = @Password"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", username)
                        command.Parameters.AddWithValue("@Password", password)

                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            ' User exists with the provided username and password
                            ' Proceed with login
                            user = username
                            Me.Hide()
                            Form1.Show()
                            Form1.Location = New Point(Me.Location)
                        Else
                            MsgBox("Incorrect Credentials" + vbCrLf + username + vbCrLf + password)
                        End If
                    End Using
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Signup_button_Click(sender As Object, e As EventArgs) Handles Signup_button.Click
        Me.Hide()
        SignUp.Show()
        SignUp.Location = New Point(Me.Location)
    End Sub

    Private Sub Login_username_GotFocus(sender As Object, e As EventArgs) Handles Login_username.GotFocus
        Login_username.Clear()
    End Sub

    Private Sub Login_username_LostFocus(sender As Object, e As EventArgs) Handles Login_username.LostFocus
        If (Login_username.Text = "") Then
            Login_username.Text = "Username"
        End If
    End Sub

    Private Sub Login_password_GotFocus(sender As Object, e As EventArgs) Handles Login_password.GotFocus
        Login_password.Clear()
    End Sub

    Private Sub Login_password_LostFocus(sender As Object, e As EventArgs) Handles Login_password.LostFocus
        If (Login_password.Text = "") Then
            Login_password.Text = "Password"
        End If
    End Sub

End Class