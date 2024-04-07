Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class AdminPage

    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\--PROJECTS2024--\Sentinnel\Sentinnel\SentinnelDB.mdf;Integrated Security=True;Connect Timeout=30"
    Dim username As String = Homepage.user

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
        DataGridView3.DataSource = getDataTable("SELECT virus_md5 AS VirusMD5, COUNT(*) AS VirusCount FROM VirusFinding GROUP BY virus_md5 ORDER BY VirusCount ASC", Homepage.user)
        ' Adjust the width of columns to fit their content
        For Each column As DataGridViewColumn In DataGridView3.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        AdminGV.DataSource = getDataTable("SELECT * FROM AdminDB", Homepage.user)
        ' Adjust the width of columns to fit their content
        For Each column As DataGridViewColumn In AdminGV.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        userGV.DataSource = getDataTable("SELECT * FROM UserDB", Homepage.user)
        ' Adjust the width of columns to fit their content
        For Each column As DataGridViewColumn In userGV.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        VirusGV.DataSource = getDataTable("SELECT * FROM VirusFinding", Homepage.user)
        ' Adjust the width of columns to fit their content
        For Each column As DataGridViewColumn In VirusGV.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        DataGridView2.ClearSelection()
        DataGridView3.ClearSelection()
        If Not String.IsNullOrEmpty(ComboBox1.Text) Then
            Dim datequery As String = "SELECT joindate FROM UserDB WHERE username = @username"
            Dim filequery As String = "SELECT SUM(files_scanned) FROM ScanData WHERE username = @username"
            Dim infquery As String = "SELECT COUNT(virus_md5) FROM VirusFinding WHERE username = @username"
            Try
                Dim joindate As String = sendQuery(datequery, "joindate", ComboBox1.Text)
                Dim filescanned As String = getScalar(filequery, ComboBox1.Text)
                Dim infection As String = getScalar(infquery, ComboBox1.Text)
                Date_box.Text = joindate
                File_count.Text = filescanned
                Inf_score.Text = infection

                DataGridView2.DataSource = getDataTable("SELECT id, virus_md5, file_path, finding_date FROM VirusFinding WHERE username = @Username", ComboBox1.Text)

            Catch ex As Exception
                MessageBox.Show("Error retrieving joindate: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Function to send queries and get required values for user details
    Public Function sendQuery(query As String, attrib As String, username As String) As String
        Dim value As String = ""
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    Dim reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        value = Convert.ToString(reader(attrib))
                        Return value
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return value
    End Function

    ' function to return integer values
    Public Function getScalar(query As String, user As String) As Decimal
        Dim count As Decimal = 0.00
        'connection logic
        'direct communication without function
        Try
            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Username", user)
                        If IsDBNull(command.ExecuteScalar()) Then
                            count = 0.00
                        Else
                            count = Convert.ToDecimal(command.ExecuteScalar())
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return count

    End Function

    'to return tabel data
    Private Function getDataTable(query As String, username As String) As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving data: " & ex.Message)
        End Try

        Return dataTable
    End Function

    Private Sub adminUpdate_Click(sender As Object, e As EventArgs) Handles adminUpdate.Click
        Dim adminKey As String = TextBox1.Text
        Dim username As String = TextBox3.Text
        Dim password As String = TextBox2.Text

        If Not String.IsNullOrEmpty(adminKey) AndAlso Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO AdminDB (adminKey, username, password) VALUES (@AdminKey, @Username, @Password)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AdminKey", adminKey)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Admin added successfully.")

                    ' Refresh tables
                    AdminGV.DataSource = getDataTable("SELECT * FROM AdminDB", Homepage.user)
                    ' Adjust the width of columns to fit their content
                    For Each column As DataGridViewColumn In AdminGV.Columns
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Next
                    ' Clear textboxes after successful insertion
                    TextBox1.Text = ""
                    TextBox3.Text = ""
                    TextBox2.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub

    Private Sub userUpdate_Click(sender As Object, e As EventArgs) Handles userUpdate.Click
        Dim username As String = TextBox5.Text
        Dim password As String = TextBox6.Text
        Dim joinDate As Date = DateTime.Parse(DateTimePicker1.Text)
        Dim firstName As String = TextBox7.Text
        Dim lastName As String = TextBox8.Text

        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(DateTimePicker1.Text) AndAlso Not String.IsNullOrEmpty(firstName) AndAlso Not String.IsNullOrEmpty(lastName) Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO UserDB (username, password, joindate, firstname, lastname) VALUES (@Username, @Password, @JoinDate, @FirstName, @LastName)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@JoinDate", joinDate)
                command.Parameters.AddWithValue("@FirstName", firstName)
                command.Parameters.AddWithValue("@LastName", lastName)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("User data inserted successfully.")

                    ' Refresh tables
                    userGV.DataSource = getDataTable("SELECT * FROM UserDB", Homepage.user)
                    ' Adjust the width of columns to fit their content
                    For Each column As DataGridViewColumn In userGV.Columns
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Next

                    ' Clear textboxes after successful insertion
                    TextBox5.Text = ""
                    TextBox6.Text = ""
                    TextBox7.Text = ""
                    TextBox8.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please fill in all fields.")
        End If
    End Sub

    Private Sub virusUpdate_Click(sender As Object, e As EventArgs) Handles virusUpdate.Click
        Dim username As String = TextBox11.Text
        Dim virus_md5 As String = TextBox15.Text
        Dim file_path As String = TextBox16.Text
        Dim finding_date As DateTime

        If DateTime.TryParse(DateTimePicker2.Text, finding_date) Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO VirusFinding (username, virus_md5, file_path, finding_date) VALUES (@Username, @VirusMD5, @FilePath, @FindingDate)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@VirusMD5", virus_md5)
                command.Parameters.AddWithValue("@FilePath", file_path)
                command.Parameters.AddWithValue("@FindingDate", finding_date)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Data inserted successfully.")

                    ' Refresh tables
                    VirusGV.DataSource = getDataTable("SELECT * FROM VirusFinding", Homepage.user)
                    ' Adjust the width of columns to fit their content
                    For Each column As DataGridViewColumn In VirusGV.Columns
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Next

                    ' Clear textboxes after successful insertion
                    TextBox11.Text = ""
                    TextBox15.Text = ""
                    TextBox16.Text = ""
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Invalid date format. Please enter the date in correct format (e.g., YYYY-MM-DD HH:MM:SS).")
        End If
    End Sub

    Private Sub InsertData(values() As String)
        ' Establish connection
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create SQL command to insert data into Applications table
            Dim sql As String = "INSERT INTO Applications ([Full_Name], [Date_of_Birth], [Email], [Phone], [Address], [Course_Stream], [Course_Name], [Amount], [Payment_Method]) " &
                                "VALUES (@FullName, @DateOfBirth, @Email, @Phone, @Address, @CourseStream, @CourseName, @Amount, @PaymentMethod)"
            Using cmd As New SqlCommand(sql, connection)
                ' Add parameters
                cmd.Parameters.AddWithValue("@FullName", values(0))
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(values(1)))
                cmd.Parameters.AddWithValue("@Email", values(2))
                cmd.Parameters.AddWithValue("@Phone", values(3))
                cmd.Parameters.AddWithValue("@Address", values(4))
                cmd.Parameters.AddWithValue("@CourseStream", values(5))
                cmd.Parameters.AddWithValue("@CourseName", values(6))
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(values(7)))
                cmd.Parameters.AddWithValue("@PaymentMethod", values(8))

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Refresh DataGridView
                'LoadDataIntoDataGridView()

                ' Clear textboxes
                For Each textbox As TextBox In Me.Controls.OfType(Of TextBox)()
                    textbox.Clear()
                Next
            End Using
        End Using
    End Sub

    Private Sub UpdateData(id As Integer, values() As String)
        ' Establish connection
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create SQL command to update data in Applications table
            Dim sql As String = "UPDATE Applications SET [Full_Name] = @FullName, [Date_of_Birth] = @DateOfBirth, [Email] = @Email, [Phone] = @Phone, [Address] = @Address, " &
                                "[Course_Stream] = @CourseStream, [Course_Name] = @CourseName, [Amount] = @Amount, [Payment_Method] = @PaymentMethod WHERE [id] = @id"
            Using cmd As New SqlCommand(sql, connection)
                ' Add parameters
                cmd.Parameters.AddWithValue("@FullName", values(0))
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(values(1)))
                cmd.Parameters.AddWithValue("@Email", values(2))
                cmd.Parameters.AddWithValue("@Phone", values(3))
                cmd.Parameters.AddWithValue("@Address", values(4))
                cmd.Parameters.AddWithValue("@CourseStream", values(5))
                cmd.Parameters.AddWithValue("@CourseName", values(6))
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(values(7)))
                cmd.Parameters.AddWithValue("@PaymentMethod", values(8))
                cmd.Parameters.AddWithValue("@id", id)

                ' Execute the command
                cmd.ExecuteNonQuery()

                ' Refresh DataGridView
                'LoadDataIntoDataGridView()

                ' Clear textboxes
                For Each textbox As TextBox In Me.Controls.OfType(Of TextBox)()
                    textbox.Clear()
                Next
            End Using
        End Using
    End Sub
End Class