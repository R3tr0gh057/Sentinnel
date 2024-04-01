<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Icon_picturebox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AdminCheck = New System.Windows.Forms.RadioButton()
        Me.Login_username = New System.Windows.Forms.TextBox()
        Me.Login_password = New System.Windows.Forms.TextBox()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.Signup_button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Icon_picturebox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Window_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Min_Button)
        Me.Panel1.Controls.Add(Me.Max_Button)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 47)
        Me.Panel1.TabIndex = 51
        '
        'Icon_picturebox
        '
        Me.Icon_picturebox.BackgroundImage = CType(resources.GetObject("Icon_picturebox.BackgroundImage"), System.Drawing.Image)
        Me.Icon_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(43, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Sentinnel Antivirus"
        '
        'Window_Button
        '
        Me.Window_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Window_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.maximize__1_
        Me.Window_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Window_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Window_Button.FlatAppearance.BorderSize = 0
        Me.Window_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Window_Button.Location = New System.Drawing.Point(732, 12)
        Me.Window_Button.Name = "Window_Button"
        Me.Window_Button.Size = New System.Drawing.Size(25, 25)
        Me.Window_Button.TabIndex = 52
        Me.Window_Button.UseVisualStyleBackColor = False
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
        'Min_Button
        '
        Me.Min_Button.BackColor = System.Drawing.Color.Transparent
        Me.Min_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.minus
        Me.Min_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Min_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min_Button.FlatAppearance.BorderSize = 0
        Me.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min_Button.Location = New System.Drawing.Point(697, 12)
        Me.Min_Button.Name = "Min_Button"
        Me.Min_Button.Size = New System.Drawing.Size(25, 25)
        Me.Min_Button.TabIndex = 5
        Me.Min_Button.UseVisualStyleBackColor = False
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.AdminCheck)
        Me.Panel3.Controls.Add(Me.Login_username)
        Me.Panel3.Controls.Add(Me.Login_password)
        Me.Panel3.Controls.Add(Me.Login_button)
        Me.Panel3.Location = New System.Drawing.Point(131, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 321)
        Me.Panel3.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(42, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "User your email and password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(89, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Sign In"
        '
        'AdminCheck
        '
        Me.AdminCheck.AutoSize = True
        Me.AdminCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminCheck.Location = New System.Drawing.Point(114, 221)
        Me.AdminCheck.Name = "AdminCheck"
        Me.AdminCheck.Size = New System.Drawing.Size(54, 17)
        Me.AdminCheck.TabIndex = 51
        Me.AdminCheck.TabStop = True
        Me.AdminCheck.Text = "Admin"
        Me.AdminCheck.UseVisualStyleBackColor = True
        '
        'Login_username
        '
        Me.Login_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Login_username.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_username.Location = New System.Drawing.Point(46, 142)
        Me.Login_username.Multiline = True
        Me.Login_username.Name = "Login_username"
        Me.Login_username.Size = New System.Drawing.Size(185, 30)
        Me.Login_username.TabIndex = 42
        Me.Login_username.Text = "Username"
        '
        'Login_password
        '
        Me.Login_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Login_password.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_password.Location = New System.Drawing.Point(46, 180)
        Me.Login_password.Multiline = True
        Me.Login_password.Name = "Login_password"
        Me.Login_password.Size = New System.Drawing.Size(185, 30)
        Me.Login_password.TabIndex = 43
        Me.Login_password.Text = "Password"
        '
        'Login_button
        '
        Me.Login_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Login_button.FlatAppearance.BorderSize = 0
        Me.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_button.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_button.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Login_button.Location = New System.Drawing.Point(95, 244)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(92, 33)
        Me.Login_button.TabIndex = 44
        Me.Login_button.Text = "Login"
        Me.Login_button.UseVisualStyleBackColor = False
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
        Me.Signup_button.Text = "SIGN UP"
        Me.Signup_button.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Signup_button)
        Me.Panel2.Location = New System.Drawing.Point(404, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(254, 321)
        Me.Panel2.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 42)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Sign in to your account to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start scanning"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(47, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 31)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Hop Back In"
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Homepage"
        Me.Text = "Homepage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Icon_picturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Window_Button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Login_username As TextBox
    Friend WithEvents Login_password As TextBox
    Friend WithEvents Login_button As Button
    Friend WithEvents Signup_button As Button
    Friend WithEvents AdminCheck As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
