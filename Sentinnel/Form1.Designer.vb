<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Scan_log = New System.Windows.Forms.ListBox()
        Me.File_Scan = New System.Windows.Forms.Button()
        Me.Scan_result = New System.Windows.Forms.ListBox()
        Me.Log_out = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Folder_Scan = New System.Windows.Forms.Button()
        Me.ActiveUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.Icon_picturebox = New System.Windows.Forms.PictureBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        Me.Scan_animation = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Scan_animation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(325, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Last Scanned Dir : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(325, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Files Scanned :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.White
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(225, 337)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(86, 46)
        Me.Cancel_Button.TabIndex = 35
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(439, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(439, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 15)
        Me.Label2.TabIndex = 33
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Timer
        '
        Me.Timer.AutoSize = True
        Me.Timer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer.ForeColor = System.Drawing.Color.Transparent
        Me.Timer.Location = New System.Drawing.Point(439, 363)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(0, 15)
        Me.Timer.TabIndex = 32
        Me.Timer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(325, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Threats :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Red
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 295)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(192, 23)
        Me.ProgressBar1.TabIndex = 27
        '
        'Scan_log
        '
        Me.Scan_log.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Scan_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_log.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Scan_log.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan_log.ForeColor = System.Drawing.Color.White
        Me.Scan_log.FormattingEnabled = True
        Me.Scan_log.ItemHeight = 19
        Me.Scan_log.Location = New System.Drawing.Point(211, 126)
        Me.Scan_log.Name = "Scan_log"
        Me.Scan_log.Size = New System.Drawing.Size(282, 192)
        Me.Scan_log.TabIndex = 26
        '
        'File_Scan
        '
        Me.File_Scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.File_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.File_Scan.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.File_Scan.ForeColor = System.Drawing.Color.White
        Me.File_Scan.Location = New System.Drawing.Point(13, 337)
        Me.File_Scan.Name = "File_Scan"
        Me.File_Scan.Size = New System.Drawing.Size(100, 100)
        Me.File_Scan.TabIndex = 29
        Me.File_Scan.Text = "File Scan"
        Me.File_Scan.UseVisualStyleBackColor = False
        '
        'Scan_result
        '
        Me.Scan_result.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Scan_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_result.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Scan_result.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan_result.ForeColor = System.Drawing.Color.White
        Me.Scan_result.FormattingEnabled = True
        Me.Scan_result.ItemHeight = 19
        Me.Scan_result.Location = New System.Drawing.Point(499, 126)
        Me.Scan_result.Name = "Scan_result"
        Me.Scan_result.Size = New System.Drawing.Size(289, 192)
        Me.Scan_result.TabIndex = 28
        '
        'Log_out
        '
        Me.Log_out.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Log_out.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_out.ForeColor = System.Drawing.Color.White
        Me.Log_out.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Log_out.Location = New System.Drawing.Point(225, 390)
        Me.Log_out.Name = "Log_out"
        Me.Log_out.Size = New System.Drawing.Size(87, 47)
        Me.Log_out.TabIndex = 40
        Me.Log_out.Text = "Log Out"
        Me.Log_out.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Icon_picturebox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Max_Button)
        Me.Panel1.Controls.Add(Me.Min_Button)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 47)
        Me.Panel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Sentinnel Antivirus"
        '
        'Folder_Scan
        '
        Me.Folder_Scan.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Folder_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Folder_Scan.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folder_Scan.ForeColor = System.Drawing.Color.White
        Me.Folder_Scan.Location = New System.Drawing.Point(119, 337)
        Me.Folder_Scan.Name = "Folder_Scan"
        Me.Folder_Scan.Size = New System.Drawing.Size(100, 100)
        Me.Folder_Scan.TabIndex = 42
        Me.Folder_Scan.Text = "Folder Scan"
        Me.Folder_Scan.UseVisualStyleBackColor = False
        '
        'ActiveUser
        '
        Me.ActiveUser.AutoSize = True
        Me.ActiveUser.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveUser.Location = New System.Drawing.Point(51, 63)
        Me.ActiveUser.Name = "ActiveUser"
        Me.ActiveUser.Size = New System.Drawing.Size(37, 19)
        Me.ActiveUser.TabIndex = 43
        Me.ActiveUser.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sentinnel.My.Resources.Resources.giphy__6_
        Me.PictureBox1.Location = New System.Drawing.Point(13, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Window_Button
        '
        Me.Window_Button.BackColor = System.Drawing.Color.Transparent
        Me.Window_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.maximize__1_
        Me.Window_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Window_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Window_Button.FlatAppearance.BorderSize = 0
        Me.Window_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Window_Button.Location = New System.Drawing.Point(733, 13)
        Me.Window_Button.Name = "Window_Button"
        Me.Window_Button.Size = New System.Drawing.Size(25, 25)
        Me.Window_Button.TabIndex = 6
        Me.Window_Button.UseVisualStyleBackColor = False
        '
        'Icon_picturebox
        '
        Me.Icon_picturebox.Image = Global.Sentinnel.My.Resources.Resources.urjja
        Me.Icon_picturebox.Location = New System.Drawing.Point(12, 12)
        Me.Icon_picturebox.Name = "Icon_picturebox"
        Me.Icon_picturebox.Size = New System.Drawing.Size(25, 25)
        Me.Icon_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Icon_picturebox.TabIndex = 46
        Me.Icon_picturebox.TabStop = False
        '
        'Close_Button
        '
        Me.Close_Button.BackColor = System.Drawing.Color.Transparent
        Me.Close_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.close
        Me.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Button.FlatAppearance.BorderSize = 0
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Location = New System.Drawing.Point(763, 12)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(25, 25)
        Me.Close_Button.TabIndex = 3
        Me.Close_Button.UseVisualStyleBackColor = False
        '
        'Max_Button
        '
        Me.Max_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.fullscreen_exit
        Me.Max_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Max_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Max_Button.FlatAppearance.BorderSize = 0
        Me.Max_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Max_Button.Location = New System.Drawing.Point(732, 12)
        Me.Max_Button.Name = "Max_Button"
        Me.Max_Button.Size = New System.Drawing.Size(25, 25)
        Me.Max_Button.TabIndex = 4
        Me.Max_Button.UseVisualStyleBackColor = True
        '
        'Min_Button
        '
        Me.Min_Button.BackColor = System.Drawing.Color.Transparent
        Me.Min_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.minus
        Me.Min_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Min_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min_Button.FlatAppearance.BorderSize = 0
        Me.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min_Button.Location = New System.Drawing.Point(701, 12)
        Me.Min_Button.Name = "Min_Button"
        Me.Min_Button.Size = New System.Drawing.Size(25, 25)
        Me.Min_Button.TabIndex = 5
        Me.Min_Button.UseVisualStyleBackColor = False
        '
        'Scan_animation
        '
        Me.Scan_animation.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Scan_animation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_animation.Image = Global.Sentinnel.My.Resources.Resources.start
        Me.Scan_animation.Location = New System.Drawing.Point(12, 100)
        Me.Scan_animation.Name = "Scan_animation"
        Me.Scan_animation.Size = New System.Drawing.Size(193, 189)
        Me.Scan_animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Scan_animation.TabIndex = 25
        Me.Scan_animation.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(207, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "File List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(495, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Viruses Found"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ActiveUser)
        Me.Controls.Add(Me.Folder_Scan)
        Me.Controls.Add(Me.Window_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Log_out)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Scan_log)
        Me.Controls.Add(Me.File_Scan)
        Me.Controls.Add(Me.Scan_result)
        Me.Controls.Add(Me.Scan_animation)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Scan_animation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Scan_log As ListBox
    Friend WithEvents File_Scan As Button
    Friend WithEvents Scan_result As ListBox
    Friend WithEvents Log_out As Button
    Friend WithEvents Scan_animation As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Icon_picturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Window_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Folder_Scan As Button
    Friend WithEvents ActiveUser As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
