<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Signup_password = New System.Windows.Forms.TextBox()
        Me.Signup_username = New System.Windows.Forms.TextBox()
        Me.First_name = New System.Windows.Forms.TextBox()
        Me.Last_name = New System.Windows.Forms.TextBox()
        Me.Signup_Confirm = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Signup_button = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.Icon_picturebox = New System.Windows.Forms.PictureBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Signup_password
        '
        Me.Signup_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Signup_password.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_password.Location = New System.Drawing.Point(304, 217)
        Me.Signup_password.Multiline = True
        Me.Signup_password.Name = "Signup_password"
        Me.Signup_password.Size = New System.Drawing.Size(178, 30)
        Me.Signup_password.TabIndex = 50
        Me.Signup_password.Text = "Password"
        '
        'Signup_username
        '
        Me.Signup_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Signup_username.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_username.Location = New System.Drawing.Point(304, 182)
        Me.Signup_username.Multiline = True
        Me.Signup_username.Name = "Signup_username"
        Me.Signup_username.Size = New System.Drawing.Size(178, 30)
        Me.Signup_username.TabIndex = 49
        Me.Signup_username.Text = "Username"
        '
        'First_name
        '
        Me.First_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.First_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_name.Location = New System.Drawing.Point(304, 112)
        Me.First_name.Multiline = True
        Me.First_name.Name = "First_name"
        Me.First_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.First_name.Size = New System.Drawing.Size(178, 30)
        Me.First_name.TabIndex = 55
        Me.First_name.Text = "First Name"
        '
        'Last_name
        '
        Me.Last_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Last_name.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_name.Location = New System.Drawing.Point(304, 147)
        Me.Last_name.Multiline = True
        Me.Last_name.Name = "Last_name"
        Me.Last_name.Size = New System.Drawing.Size(178, 30)
        Me.Last_name.TabIndex = 56
        Me.Last_name.Text = "Last Name"
        '
        'Signup_Confirm
        '
        Me.Signup_Confirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Signup_Confirm.FlatAppearance.BorderSize = 0
        Me.Signup_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Signup_Confirm.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Signup_Confirm.Location = New System.Drawing.Point(351, 259)
        Me.Signup_Confirm.Name = "Signup_Confirm"
        Me.Signup_Confirm.Size = New System.Drawing.Size(92, 33)
        Me.Signup_Confirm.TabIndex = 61
        Me.Signup_Confirm.Text = "Signup"
        Me.Signup_Confirm.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Icon_picturebox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Max_Button)
        Me.Panel1.Controls.Add(Me.Min_Button)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 47)
        Me.Panel1.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(43, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Sentinnel Antivirus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.First_name)
        Me.Panel2.Controls.Add(Me.Signup_username)
        Me.Panel2.Controls.Add(Me.Signup_password)
        Me.Panel2.Controls.Add(Me.Signup_Confirm)
        Me.Panel2.Controls.Add(Me.Last_name)
        Me.Panel2.Location = New System.Drawing.Point(131, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 321)
        Me.Panel2.TabIndex = 64
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Signup_button)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(254, 321)
        Me.Panel3.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 42)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Register with your personal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "details to use the app"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Signup_button
        '
        Me.Signup_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Signup_button.FlatAppearance.BorderSize = 0
        Me.Signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Signup_button.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Signup_button.Location = New System.Drawing.Point(80, 205)
        Me.Signup_button.Name = "Signup_button"
        Me.Signup_button.Size = New System.Drawing.Size(92, 33)
        Me.Signup_button.TabIndex = 50
        Me.Signup_button.Text = "SIGN IN"
        Me.Signup_button.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(323, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 31)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Get Started"
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(275, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 28)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Tell us who you are"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Window_Button
        '
        Me.Window_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Window_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.maximize__1_
        Me.Window_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Window_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Window_Button.FlatAppearance.BorderSize = 0
        Me.Window_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Window_Button.Location = New System.Drawing.Point(733, 13)
        Me.Window_Button.Name = "Window_Button"
        Me.Window_Button.Size = New System.Drawing.Size(25, 25)
        Me.Window_Button.TabIndex = 63
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(47, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 31)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Get Started"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Window_Button)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Signup_password As TextBox
    Friend WithEvents Signup_username As TextBox
    Friend WithEvents First_name As TextBox
    Friend WithEvents Last_name As TextBox
    Friend WithEvents Signup_Confirm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Icon_picturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Window_Button As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Signup_button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
