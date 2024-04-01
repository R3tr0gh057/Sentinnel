﻿Imports System.IO
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

    ' Scanner Code
    ' Folder Scan Function call
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles File_Scan.Click

        Dim md5val As String = ""

        Dim openFileDialog As New OpenFileDialog()

        ' Set properties for the OpenFileDialog
        openFileDialog.Title = "Select a file"
        openFileDialog.Filter = "All Files|*.*"

        ' Show the OpenFileDialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedFilePath As String = openFileDialog.FileName

            ' Calculate the MD5 hash of the selected file
            Using md5 As New MD5CryptoServiceProvider()
                Using stream As New FileStream(selectedFilePath, FileMode.Open, FileAccess.Read)
                    Dim hashBytes() As Byte = md5.ComputeHash(stream)
                    Dim stringBuilder As New StringBuilder()
                    For Each hashByte As Byte In hashBytes
                        stringBuilder.Append(hashByte.ToString("x2"))
                    Next
                    Dim md5Hash As String = stringBuilder.ToString()
                    md5val = md5Hash

                    ' Load the MD5 list
                    Dim md5ListFilePath As String = "D:\list.txt" ' Path to your MD5 list file
                    Dim md5List As String = File.ReadAllText(md5ListFilePath)

                    ' Check if the calculated MD5 hash exists in the MD5 list
                    If md5List.Contains(md5Hash) Then
                        MessageBox.Show("File is in the MD5 list. It may be malicious." + vbCrLf + "MD5 : " + md5val)
                    Else
                        MessageBox.Show("File is not in the MD5 list. It seems safe." + vbCrLf + "MD5 : " + md5val)
                    End If
                End Using
            End Using
        End If

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
                File_Scan.Text = "Scan"
                Exit Sub
            End If
            MessageBox.Show("Scan Complete." + vbCrLf + "No threats were found.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            File_Scan.Text = "Scan"
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Timer1.Stop()
        If Scan_result.Items.Count > 0 Then
            MessageBox.Show("Scan Completed. There are " + vbCrLf + Scan_result.Items.Count + " possible malicious files.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            File_Scan.Text = "Scan"
            ProgressBar1.Value = 0
            Scan_log.Items.Clear()
        Else
            MessageBox.Show("Scan Complete." + vbCrLf + "No threats were found.", CStr(MessageBoxButtons.OK))
            Scan_animation.Hide()
            File_Scan.Text = "Scan"
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