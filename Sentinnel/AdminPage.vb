Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class AdminPage

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\--PROJECTS2024--\Sentinnel\Sentinnel\SentinnelDB.mdf;Integrated Security=True;Connect Timeout=30"

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
    Private Sub AdminPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SentinnelDBDataSet.AdminDB' table. You can move, or remove it, as needed.
        Me.AdminDBTableAdapter.Fill(Me.SentinnelDBDataSet.AdminDB)
        'TODO: This line of code loads data into the 'SentinnelDBDataSet.VirusDB' table. You can move, or remove it, as needed.
        Me.VirusDBTableAdapter.Fill(Me.SentinnelDBDataSet.VirusDB)
        'TODO: This line of code loads data into the 'SentinnelDBDataSet.UserDB' table. You can move, or remove it, as needed.
        Me.UserDBTableAdapter.Fill(Me.SentinnelDBDataSet.UserDB)
        'TODO: This line of code loads data into the 'VirusListDataSet.VirusHash' table. You can move, or remove it, as needed.
        Me.VirusHashTableAdapter.Fill(Me.VirusListDataSet.VirusHash)
        'TODO: This line of code loads data into the 'VirusListDataSet.UserData' table. You can move, or remove it, as needed.
        Me.UserDataTableAdapter.Fill(Me.VirusListDataSet.UserData)
        Panel4.Hide()

        ComboBox1.Items.Clear()

        ' Storing attributes in an array
        Dim userCounts As New List(Of String)()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT username FROM UserDB"
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        Dim userCount As String = Convert.ToString(reader("username"))
                        userCounts.Add(userCount)
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        ' Convert List(Of Integer) to array if needed
        Dim userCountsArray As String() = userCounts.ToArray()
        Dim counter As Integer = userCountsArray.Length - 1

        While (counter > -1)
            ComboBox1.Items.Add(userCountsArray(counter))
            counter -= 1
        End While

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub User_Stat_Click(sender As Object, e As EventArgs) Handles User_Stat.Click
        Panel3.Show()
        Panel4.Hide()
    End Sub

    Private Sub Database_Manage_Click(sender As Object, e As EventArgs) Handles Database_Manage.Click
        Panel4.Show()
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

        Dim query As String = "SELECT joindate FROM UserDB WHERE username = " & ComboBox1.SelectedItem
        Try
            Date_box.Text = sendQuery(query, "joindate")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    ' Function to send queries and get required values for user details
    Public Function sendQuery(query As String, attrib As String) As String
        Dim value As String = ""
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        value = Convert.ToString(reader(attrib))
                        Return value
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
        Return value
    End Function
End Class