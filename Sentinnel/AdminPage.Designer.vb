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
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar3 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar4 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar5 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar6 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar7 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar8 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar9 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar10 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar11 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar12 = New System.Windows.Forms.VScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(316, 124)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar1.TabIndex = 54
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Location = New System.Drawing.Point(346, 124)
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar2.TabIndex = 55
        '
        'VScrollBar3
        '
        Me.VScrollBar3.Location = New System.Drawing.Point(376, 124)
        Me.VScrollBar3.Name = "VScrollBar3"
        Me.VScrollBar3.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar3.TabIndex = 56
        '
        'VScrollBar4
        '
        Me.VScrollBar4.Location = New System.Drawing.Point(406, 124)
        Me.VScrollBar4.Name = "VScrollBar4"
        Me.VScrollBar4.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar4.TabIndex = 57
        '
        'VScrollBar5
        '
        Me.VScrollBar5.Location = New System.Drawing.Point(436, 124)
        Me.VScrollBar5.Name = "VScrollBar5"
        Me.VScrollBar5.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar5.TabIndex = 58
        '
        'VScrollBar6
        '
        Me.VScrollBar6.Location = New System.Drawing.Point(466, 124)
        Me.VScrollBar6.Name = "VScrollBar6"
        Me.VScrollBar6.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar6.TabIndex = 59
        '
        'VScrollBar7
        '
        Me.VScrollBar7.Location = New System.Drawing.Point(645, 124)
        Me.VScrollBar7.Name = "VScrollBar7"
        Me.VScrollBar7.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar7.TabIndex = 65
        '
        'VScrollBar8
        '
        Me.VScrollBar8.Location = New System.Drawing.Point(615, 124)
        Me.VScrollBar8.Name = "VScrollBar8"
        Me.VScrollBar8.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar8.TabIndex = 64
        '
        'VScrollBar9
        '
        Me.VScrollBar9.Location = New System.Drawing.Point(585, 124)
        Me.VScrollBar9.Name = "VScrollBar9"
        Me.VScrollBar9.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar9.TabIndex = 63
        '
        'VScrollBar10
        '
        Me.VScrollBar10.Location = New System.Drawing.Point(555, 124)
        Me.VScrollBar10.Name = "VScrollBar10"
        Me.VScrollBar10.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar10.TabIndex = 62
        '
        'VScrollBar11
        '
        Me.VScrollBar11.Location = New System.Drawing.Point(525, 124)
        Me.VScrollBar11.Name = "VScrollBar11"
        Me.VScrollBar11.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar11.TabIndex = 61
        '
        'VScrollBar12
        '
        Me.VScrollBar12.Location = New System.Drawing.Point(495, 124)
        Me.VScrollBar12.Name = "VScrollBar12"
        Me.VScrollBar12.Size = New System.Drawing.Size(30, 193)
        Me.VScrollBar12.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "User Statistics"
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VScrollBar7)
        Me.Controls.Add(Me.VScrollBar8)
        Me.Controls.Add(Me.VScrollBar9)
        Me.Controls.Add(Me.VScrollBar10)
        Me.Controls.Add(Me.VScrollBar11)
        Me.Controls.Add(Me.VScrollBar12)
        Me.Controls.Add(Me.VScrollBar6)
        Me.Controls.Add(Me.VScrollBar5)
        Me.Controls.Add(Me.VScrollBar4)
        Me.Controls.Add(Me.VScrollBar3)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.VScrollBar1)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents VScrollBar3 As VScrollBar
    Friend WithEvents VScrollBar4 As VScrollBar
    Friend WithEvents VScrollBar5 As VScrollBar
    Friend WithEvents VScrollBar6 As VScrollBar
    Friend WithEvents VScrollBar7 As VScrollBar
    Friend WithEvents VScrollBar8 As VScrollBar
    Friend WithEvents VScrollBar9 As VScrollBar
    Friend WithEvents VScrollBar10 As VScrollBar
    Friend WithEvents VScrollBar11 As VScrollBar
    Friend WithEvents VScrollBar12 As VScrollBar
    Friend WithEvents Label2 As Label
End Class
