<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Database_Manage = New System.Windows.Forms.Button()
        Me.User_Stat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Icon_picturebox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.User_title = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Date_box = New System.Windows.Forms.TextBox()
        Me.File_count = New System.Windows.Forms.TextBox()
        Me.Inf_score = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Virus_title = New System.Windows.Forms.Label()
        Me.Virus_found = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Action_taken = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.VirusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VirusHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VirusType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Database_Manage)
        Me.Panel2.Controls.Add(Me.User_Stat)
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 403)
        Me.Panel2.TabIndex = 42
        '
        'Database_Manage
        '
        Me.Database_Manage.Location = New System.Drawing.Point(0, 47)
        Me.Database_Manage.Name = "Database_Manage"
        Me.Database_Manage.Size = New System.Drawing.Size(200, 50)
        Me.Database_Manage.TabIndex = 39
        Me.Database_Manage.Text = "Database Manager"
        Me.Database_Manage.UseVisualStyleBackColor = True
        '
        'User_Stat
        '
        Me.User_Stat.Location = New System.Drawing.Point(0, -1)
        Me.User_Stat.Name = "User_Stat"
        Me.User_Stat.Size = New System.Drawing.Size(200, 50)
        Me.User_Stat.TabIndex = 38
        Me.User_Stat.Text = "User Statistics"
        Me.User_Stat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Icon_picturebox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Max_Button)
        Me.Panel1.Controls.Add(Me.Min_Button)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 47)
        Me.Panel1.TabIndex = 42
        '
        'Icon_picturebox
        '
        Me.Icon_picturebox.Location = New System.Drawing.Point(12, 12)
        Me.Icon_picturebox.Name = "Icon_picturebox"
        Me.Icon_picturebox.Size = New System.Drawing.Size(25, 25)
        Me.Icon_picturebox.TabIndex = 46
        Me.Icon_picturebox.TabStop = False
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
        Me.Window_Button.TabIndex = 53
        Me.Window_Button.UseVisualStyleBackColor = False
        '
        'User_title
        '
        Me.User_title.AutoSize = True
        Me.User_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_title.Location = New System.Drawing.Point(16, 12)
        Me.User_title.Name = "User_title"
        Me.User_title.Size = New System.Drawing.Size(150, 25)
        Me.User_title.TabIndex = 66
        Me.User_title.Text = "User Statistics"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"User1", "User2", "User3", "User4"})
        Me.ComboBox1.Location = New System.Drawing.Point(464, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 67
        '
        'Date_box
        '
        Me.Date_box.Location = New System.Drawing.Point(158, 71)
        Me.Date_box.Name = "Date_box"
        Me.Date_box.Size = New System.Drawing.Size(100, 20)
        Me.Date_box.TabIndex = 68
        '
        'File_count
        '
        Me.File_count.Location = New System.Drawing.Point(158, 112)
        Me.File_count.Name = "File_count"
        Me.File_count.Size = New System.Drawing.Size(100, 20)
        Me.File_count.TabIndex = 69
        '
        'Inf_score
        '
        Me.Inf_score.Location = New System.Drawing.Point(158, 153)
        Me.Inf_score.Name = "Inf_score"
        Me.Inf_score.Size = New System.Drawing.Size(100, 20)
        Me.Inf_score.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Files Scanned"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Infection Score"
        '
        'Virus_title
        '
        Me.Virus_title.AutoSize = True
        Me.Virus_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Virus_title.Location = New System.Drawing.Point(16, 211)
        Me.Virus_title.Name = "Virus_title"
        Me.Virus_title.Size = New System.Drawing.Size(154, 25)
        Me.Virus_title.TabIndex = 74
        Me.Virus_title.Text = "Virus Statistics"
        '
        'Virus_found
        '
        Me.Virus_found.Location = New System.Drawing.Point(21, 288)
        Me.Virus_found.Name = "Virus_found"
        Me.Virus_found.Size = New System.Drawing.Size(279, 96)
        Me.Virus_found.TabIndex = 75
        Me.Virus_found.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Viruses Found"
        '
        'Action_taken
        '
        Me.Action_taken.Location = New System.Drawing.Point(306, 288)
        Me.Action_taken.Name = "Action_taken"
        Me.Action_taken.Size = New System.Drawing.Size(279, 96)
        Me.Action_taken.TabIndex = 77
        Me.Action_taken.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Action Taken"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.User_title)
        Me.Panel3.Controls.Add(Me.Action_taken)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Date_box)
        Me.Panel3.Controls.Add(Me.Virus_found)
        Me.Panel3.Controls.Add(Me.File_count)
        Me.Panel3.Controls.Add(Me.Virus_title)
        Me.Panel3.Controls.Add(Me.Inf_score)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(200, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(601, 403)
        Me.Panel3.TabIndex = 79
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.DataGridView2)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(-1, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(601, 403)
        Me.Panel4.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 25)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Virus Databse"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 25)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "User Database"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VirusName, Me.VirusHash, Me.VirusType})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(557, 138)
        Me.DataGridView1.TabIndex = 79
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Username, Me.Password, Me.JoinDate, Me.FirstName, Me.LastName})
        Me.DataGridView2.Location = New System.Drawing.Point(21, 254)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(557, 138)
        Me.DataGridView2.TabIndex = 80
        '
        'VirusName
        '
        Me.VirusName.HeaderText = "Virus Name"
        Me.VirusName.MinimumWidth = 8
        Me.VirusName.Name = "VirusName"
        '
        'VirusHash
        '
        Me.VirusHash.HeaderText = "Virus Hash"
        Me.VirusHash.Name = "VirusHash"
        '
        'VirusType
        '
        Me.VirusType.HeaderText = "Virus Type"
        Me.VirusType.Name = "VirusType"
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        '
        'Password
        '
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        '
        'JoinDate
        '
        Me.JoinDate.HeaderText = "Join Date"
        Me.JoinDate.Name = "JoinDate"
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "First Name"
        Me.FirstName.Name = "FirstName"
        '
        'LastName
        '
        Me.LastName.HeaderText = "Last Name"
        Me.LastName.Name = "LastName"
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Window_Button)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Database_Manage As Button
    Friend WithEvents User_Stat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Icon_picturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Window_Button As Button
    Friend WithEvents User_title As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Date_box As TextBox
    Friend WithEvents File_count As TextBox
    Friend WithEvents Inf_score As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Virus_title As Label
    Friend WithEvents Virus_found As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Action_taken As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents JoinDate As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents VirusName As DataGridViewTextBoxColumn
    Friend WithEvents VirusHash As DataGridViewTextBoxColumn
    Friend WithEvents VirusType As DataGridViewTextBoxColumn
End Class
