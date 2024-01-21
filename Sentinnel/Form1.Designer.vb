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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Label()
        Me.Folder_Scan = New System.Windows.Forms.RadioButton()
        Me.Quick_Scan = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Scan_log = New System.Windows.Forms.ListBox()
        Me.Scan_button = New System.Windows.Forms.Button()
        Me.Scan_result = New System.Windows.Forms.ListBox()
        Me.Scan_animation = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Scan_animation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(349, 326)
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
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(349, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Files Scanned :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Window_Button)
        Me.Panel1.Controls.Add(Me.Close_Button)
        Me.Panel1.Controls.Add(Me.Max_Button)
        Me.Panel1.Controls.Add(Me.Min_Button)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(797, 59)
        Me.Panel1.TabIndex = 36
        '
        'Window_Button
        '
        Me.Window_Button.BackgroundImage = CType(resources.GetObject("Window_Button.BackgroundImage"), System.Drawing.Image)
        Me.Window_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Window_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Window_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Window_Button.Location = New System.Drawing.Point(732, 12)
        Me.Window_Button.Name = "Window_Button"
        Me.Window_Button.Size = New System.Drawing.Size(25, 25)
        Me.Window_Button.TabIndex = 6
        Me.Window_Button.UseVisualStyleBackColor = True
        '
        'Close_Button
        '
        Me.Close_Button.BackgroundImage = Global.Sentinnel.My.Resources.Resources.closewhite
        Me.Close_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_Button.Location = New System.Drawing.Point(763, 12)
        Me.Close_Button.Name = "Close_Button"
        Me.Close_Button.Size = New System.Drawing.Size(25, 25)
        Me.Close_Button.TabIndex = 3
        Me.Close_Button.UseVisualStyleBackColor = True
        '
        'Max_Button
        '
        Me.Max_Button.BackgroundImage = CType(resources.GetObject("Max_Button.BackgroundImage"), System.Drawing.Image)
        Me.Max_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Max_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Max_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Max_Button.Location = New System.Drawing.Point(732, 12)
        Me.Max_Button.Name = "Max_Button"
        Me.Max_Button.Size = New System.Drawing.Size(25, 25)
        Me.Max_Button.TabIndex = 4
        Me.Max_Button.UseVisualStyleBackColor = True
        '
        'Min_Button
        '
        Me.Min_Button.BackgroundImage = CType(resources.GetObject("Min_Button.BackgroundImage"), System.Drawing.Image)
        Me.Min_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Min_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Min_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min_Button.Location = New System.Drawing.Point(701, 12)
        Me.Min_Button.Name = "Min_Button"
        Me.Min_Button.Size = New System.Drawing.Size(25, 25)
        Me.Min_Button.TabIndex = 5
        Me.Min_Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Sentinnel Antivirus - v12"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.ForeColor = System.Drawing.Color.Transparent
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cancel_Button.Location = New System.Drawing.Point(702, 287)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(87, 26)
        Me.Cancel_Button.TabIndex = 35
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(462, 374)
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
        Me.Label2.Location = New System.Drawing.Point(462, 326)
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
        Me.Timer.Location = New System.Drawing.Point(462, 350)
        Me.Timer.Name = "Timer"
        Me.Timer.Size = New System.Drawing.Size(0, 15)
        Me.Timer.TabIndex = 32
        Me.Timer.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Folder_Scan
        '
        Me.Folder_Scan.AutoSize = True
        Me.Folder_Scan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Folder_Scan.ForeColor = System.Drawing.Color.Transparent
        Me.Folder_Scan.Location = New System.Drawing.Point(18, 421)
        Me.Folder_Scan.Name = "Folder_Scan"
        Me.Folder_Scan.Size = New System.Drawing.Size(89, 19)
        Me.Folder_Scan.TabIndex = 31
        Me.Folder_Scan.TabStop = True
        Me.Folder_Scan.Text = "Folder Scan"
        Me.Folder_Scan.UseVisualStyleBackColor = True
        '
        'Quick_Scan
        '
        Me.Quick_Scan.AutoSize = True
        Me.Quick_Scan.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quick_Scan.ForeColor = System.Drawing.Color.Transparent
        Me.Quick_Scan.Location = New System.Drawing.Point(18, 398)
        Me.Quick_Scan.Name = "Quick_Scan"
        Me.Quick_Scan.Size = New System.Drawing.Size(86, 19)
        Me.Quick_Scan.TabIndex = 30
        Me.Quick_Scan.TabStop = True
        Me.Quick_Scan.Text = "Quick Scan"
        Me.Quick_Scan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(349, 374)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(349, 290)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(346, 23)
        Me.ProgressBar1.TabIndex = 27
        '
        'Scan_log
        '
        Me.Scan_log.BackColor = System.Drawing.Color.Black
        Me.Scan_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_log.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Scan_log.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan_log.ForeColor = System.Drawing.Color.Transparent
        Me.Scan_log.FormattingEnabled = True
        Me.Scan_log.Location = New System.Drawing.Point(349, 66)
        Me.Scan_log.Name = "Scan_log"
        Me.Scan_log.Size = New System.Drawing.Size(440, 106)
        Me.Scan_log.TabIndex = 26
        '
        'Scan_button
        '
        Me.Scan_button.FlatAppearance.BorderSize = 0
        Me.Scan_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Scan_button.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan_button.ForeColor = System.Drawing.Color.Transparent
        Me.Scan_button.Location = New System.Drawing.Point(144, 219)
        Me.Scan_button.Name = "Scan_button"
        Me.Scan_button.Size = New System.Drawing.Size(62, 26)
        Me.Scan_button.TabIndex = 29
        Me.Scan_button.Text = "Scan"
        Me.Scan_button.UseVisualStyleBackColor = True
        '
        'Scan_result
        '
        Me.Scan_result.BackColor = System.Drawing.Color.Black
        Me.Scan_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_result.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Scan_result.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scan_result.ForeColor = System.Drawing.Color.Transparent
        Me.Scan_result.FormattingEnabled = True
        Me.Scan_result.Location = New System.Drawing.Point(349, 178)
        Me.Scan_result.Name = "Scan_result"
        Me.Scan_result.Size = New System.Drawing.Size(440, 106)
        Me.Scan_result.TabIndex = 28
        '
        'Scan_animation
        '
        Me.Scan_animation.Image = Global.Sentinnel.My.Resources.Resources.giphy__6_
        Me.Scan_animation.Location = New System.Drawing.Point(12, 66)
        Me.Scan_animation.Name = "Scan_animation"
        Me.Scan_animation.Size = New System.Drawing.Size(326, 326)
        Me.Scan_animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Scan_animation.TabIndex = 25
        Me.Scan_animation.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Timer)
        Me.Controls.Add(Me.Folder_Scan)
        Me.Controls.Add(Me.Quick_Scan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Scan_log)
        Me.Controls.Add(Me.Scan_button)
        Me.Controls.Add(Me.Scan_result)
        Me.Controls.Add(Me.Scan_animation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Scan_animation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Window_Button As Button
    Friend WithEvents Close_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer As Label
    Friend WithEvents Folder_Scan As RadioButton
    Friend WithEvents Quick_Scan As RadioButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Scan_log As ListBox
    Friend WithEvents Scan_animation As PictureBox
    Friend WithEvents Scan_button As Button
    Friend WithEvents Scan_result As ListBox
End Class
