Imports System.IO
Imports System.Security.Cryptography 'md5 converter
Imports System.Text
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Runtime.InteropServices

Public Class Form1

    'code to move the form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public lastFormLocation As Point

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Scan_animation.Hide()

    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        lastFormLocation = Me.Location
    End Sub

    'Taskbar buttons
    Private Sub Close_Button_Click(sender As Object, e As EventArgs) Handles Close_Button.Click
        Me.Hide()
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

    'Scanner Code
    'Quick Scan Function call
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Quick_Scan.Click

        Scan_animation.Show()
        FolderBrowserDialog1.SelectedPath = "D:\"
        Try
            For Each strDir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly)
                For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                    Scan_log.Items.Add(strFile)
                Next strFile
            Next strDir
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            For Each strFile As String In System.IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
                Scan_log.Items.Add(strFile)
            Next strFile
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Folder Scan Function call
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Folder_Scan.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Scan_animation.Show()
            Scan_log.Items.Clear()
        Else
            Exit Sub
        End If

        Try
            For Each strFile As String In System.IO.Directory.GetFiles(FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
                Scan_log.Items.Add(strFile)
            Next strFile
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Scan Logic
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = CInt(Conversions.ToString(Scan_log.Items.Count))
        Timer.Text = Conversions.ToString(Scan_log.Items.Count)
        Scan_log.Enabled = False
        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try
                Scan_log.SelectedIndex = Scan_log.SelectedIndex + 1
                Label2.Text = Scan_log.SelectedItem.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("D:\list.txt").ToString 'path to virus md5 list
                ProgressBar1.Increment(1)
                Label3.Text = Conversions.ToString(Scan_result.Items.Count)
                Timer.Text = Conversions.ToString(ProgressBar1.Value)
                scanbox.Text = read.ToString
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim fs As FileStream = New FileStream(CStr(Scan_log.SelectedItem), FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(fs)
                fs.Close()
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashbyte As Byte

                For Each hashbyte In hash
                    buff.Append(String.Format("{0:X2}", hashbyte))
                Next

                If scanbox.Text.Contains(buff.ToString) Then
                    Scan_result.Items.Add(Scan_log.SelectedItem)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Scan_log.Enabled = True
            Timer1.Stop()
            If Scan_result.Items.Count > 0 Then
                MessageBox.Show("Scan Completed. There are " + vbCrLf + Scan_result.Items.Count + " possible malicious files.", CStr(MessageBoxButtons.OK))
                Scan_animation.Hide()
                Quick_Scan.Text = "Scan"
                Exit Sub
            End If
            MessageBox.Show("Scan Complete." + vbCrLf + "No threats were found.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            Quick_Scan.Text = "Scan"
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Timer1.Stop()
        If Scan_result.Items.Count > 0 Then
            MessageBox.Show("Scan Completed. There are " + vbCrLf + Scan_result.Items.Count + " possible malicious files.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            Quick_Scan.Text = "Scan"
            ProgressBar1.Value = 0
            Scan_log.Items.Clear()
        Else
            MessageBox.Show("Scan Complete." + vbCrLf + "No threats were found.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            Quick_Scan.Text = "Scan"
            ProgressBar1.Value = 0
            Scan_log.Items.Clear()
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Log_out_Click(sender As Object, e As EventArgs) Handles Log_out.Click
        Me.Close()
        Homepage.Show()
        Homepage.Location = New Point(Me.Location)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class