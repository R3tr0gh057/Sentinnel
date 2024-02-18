﻿Imports System.Runtime.InteropServices
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
End Class