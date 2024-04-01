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
        Me.components = New System.ComponentModel.Container()
        Me.AdminDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SentinnelDBDataSet = New Sentinnel.SentinnelDBDataSet()
        Me.VirusDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VirusHashBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VirusListDataSet = New Sentinnel.VirusListDataSet()
        Me.UserDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataTableAdapter = New Sentinnel.VirusListDataSetTableAdapters.UserDataTableAdapter()
        Me.VirusHashBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VirusHashTableAdapter = New Sentinnel.VirusListDataSetTableAdapters.VirusHashTableAdapter()
        Me.UserDBTableAdapter = New Sentinnel.SentinnelDBDataSetTableAdapters.UserDBTableAdapter()
        Me.VirusDBTableAdapter = New Sentinnel.SentinnelDBDataSetTableAdapters.VirusDBTableAdapter()
        Me.AdminDBTableAdapter = New Sentinnel.SentinnelDBDataSetTableAdapters.AdminDBTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Inf_score = New System.Windows.Forms.TextBox()
        Me.Virus_title = New System.Windows.Forms.Label()
        Me.File_count = New System.Windows.Forms.TextBox()
        Me.Date_box = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.User_title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.adminDGV = New System.Windows.Forms.DataGridView()
        Me.AdminKeyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.UserDGV = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VirusDGV = New System.Windows.Forms.TabPage()
        Me.TotalfrequencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VirusnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Md5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Window_Button = New System.Windows.Forms.Button()
        Me.Icon_picturebox = New System.Windows.Forms.PictureBox()
        Me.Close_Button = New System.Windows.Forms.Button()
        Me.Max_Button = New System.Windows.Forms.Button()
        Me.Min_Button = New System.Windows.Forms.Button()
        CType(Me.AdminDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SentinnelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VirusDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.VirusHashBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VirusListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VirusHashBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.adminDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VirusDGV.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminDBBindingSource
        '
        Me.AdminDBBindingSource.DataMember = "AdminDB"
        Me.AdminDBBindingSource.DataSource = Me.SentinnelDBDataSet
        '
        'SentinnelDBDataSet
        '
        Me.SentinnelDBDataSet.DataSetName = "SentinnelDBDataSet"
        Me.SentinnelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VirusDBBindingSource
        '
        Me.VirusDBBindingSource.DataMember = "VirusDB"
        Me.VirusDBBindingSource.DataSource = Me.SentinnelDBDataSet
        '
        'UserDBBindingSource
        '
        Me.UserDBBindingSource.DataMember = "UserDB"
        Me.UserDBBindingSource.DataSource = Me.SentinnelDBDataSet
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
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 47)
        Me.Panel1.TabIndex = 42
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
        'VirusHashBindingSource1
        '
        Me.VirusHashBindingSource1.DataMember = "VirusHash"
        Me.VirusHashBindingSource1.DataSource = Me.VirusListDataSet
        '
        'VirusListDataSet
        '
        Me.VirusListDataSet.DataSetName = "VirusListDataSet"
        Me.VirusListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserDataBindingSource
        '
        Me.UserDataBindingSource.DataMember = "UserData"
        Me.UserDataBindingSource.DataSource = Me.VirusListDataSet
        '
        'UserDataTableAdapter
        '
        Me.UserDataTableAdapter.ClearBeforeFill = True
        '
        'VirusHashBindingSource
        '
        Me.VirusHashBindingSource.DataMember = "VirusHash"
        Me.VirusHashBindingSource.DataSource = Me.VirusListDataSet
        '
        'VirusHashTableAdapter
        '
        Me.VirusHashTableAdapter.ClearBeforeFill = True
        '
        'UserDBTableAdapter
        '
        Me.UserDBTableAdapter.ClearBeforeFill = True
        '
        'VirusDBTableAdapter
        '
        Me.VirusDBTableAdapter.ClearBeforeFill = True
        '
        'AdminDBTableAdapter
        '
        Me.AdminDBTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Files Scanned"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Date Joined"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Infection Score"
        '
        'Inf_score
        '
        Me.Inf_score.Location = New System.Drawing.Point(161, 145)
        Me.Inf_score.Name = "Inf_score"
        Me.Inf_score.Size = New System.Drawing.Size(100, 25)
        Me.Inf_score.TabIndex = 70
        '
        'Virus_title
        '
        Me.Virus_title.AutoSize = True
        Me.Virus_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Virus_title.ForeColor = System.Drawing.Color.White
        Me.Virus_title.Location = New System.Drawing.Point(369, 10)
        Me.Virus_title.Name = "Virus_title"
        Me.Virus_title.Size = New System.Drawing.Size(154, 25)
        Me.Virus_title.TabIndex = 74
        Me.Virus_title.Text = "Virus Statistics"
        '
        'File_count
        '
        Me.File_count.Location = New System.Drawing.Point(161, 112)
        Me.File_count.Name = "File_count"
        Me.File_count.Size = New System.Drawing.Size(100, 25)
        Me.File_count.TabIndex = 69
        '
        'Date_box
        '
        Me.Date_box.Location = New System.Drawing.Point(161, 79)
        Me.Date_box.Name = "Date_box"
        Me.Date_box.Size = New System.Drawing.Size(100, 25)
        Me.Date_box.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(370, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Viruses Found"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"User1", "User2", "User3", "User4"})
        Me.ComboBox1.Location = New System.Drawing.Point(223, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 67
        '
        'User_title
        '
        Me.User_title.AutoSize = True
        Me.User_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_title.ForeColor = System.Drawing.Color.White
        Me.User_title.Location = New System.Drawing.Point(19, 10)
        Me.User_title.Name = "User_title"
        Me.User_title.Size = New System.Drawing.Size(150, 25)
        Me.User_title.TabIndex = 66
        Me.User_title.Text = "User Statistics"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(370, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Global Frequency"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(175, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 20)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "User"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.VirusDGV)
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(801, 402)
        Me.TabControl1.TabIndex = 54
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TextBox12)
        Me.TabPage1.Controls.Add(Me.DataGridView3)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.User_title)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Inf_score)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Virus_title)
        Me.TabPage1.Controls.Add(Me.Date_box)
        Me.TabPage1.Controls.Add(Me.File_count)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(793, 376)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Statistics"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.adminDGV)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(793, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Admin DB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Admin Key"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(11, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.TextBox1.TabIndex = 76
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 25)
        Me.TextBox2.TabIndex = 74
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(152, 90)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 25)
        Me.TextBox3.TabIndex = 75
        '
        'adminDGV
        '
        Me.adminDGV.AutoGenerateColumns = False
        Me.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.adminDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdminKeyDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.adminDGV.DataSource = Me.AdminDBBindingSource
        Me.adminDGV.Location = New System.Drawing.Point(6, 220)
        Me.adminDGV.Name = "adminDGV"
        Me.adminDGV.Size = New System.Drawing.Size(781, 150)
        Me.adminDGV.TabIndex = 68
        '
        'AdminKeyDataGridViewTextBoxColumn
        '
        Me.AdminKeyDataGridViewTextBoxColumn.DataPropertyName = "adminKey"
        Me.AdminKeyDataGridViewTextBoxColumn.HeaderText = "adminKey"
        Me.AdminKeyDataGridViewTextBoxColumn.Name = "AdminKeyDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 25)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Edit AdminDB"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.TextBox8)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TextBox4)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.UserDGV)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(793, 376)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "User DB"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(11, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 20)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Last Name"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(152, 183)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 25)
        Me.TextBox8.TabIndex = 89
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(11, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 20)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "First Name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(152, 152)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 25)
        Me.TextBox7.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(11, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 20)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Username"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(11, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 20)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Join Date"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(152, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 25)
        Me.TextBox4.TabIndex = 83
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(152, 59)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 25)
        Me.TextBox5.TabIndex = 81
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(152, 90)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 25)
        Me.TextBox6.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(10, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 25)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Edit UserDB"
        '
        'UserDGV
        '
        Me.UserDGV.AutoGenerateColumns = False
        Me.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn1, Me.PasswordDataGridViewTextBoxColumn1, Me.JoindateDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn})
        Me.UserDGV.DataSource = Me.UserDataBindingSource
        Me.UserDGV.Location = New System.Drawing.Point(6, 220)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.Size = New System.Drawing.Size(781, 150)
        Me.UserDGV.TabIndex = 0
        '
        'UsernameDataGridViewTextBoxColumn1
        '
        Me.UsernameDataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn1.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn1.Name = "UsernameDataGridViewTextBoxColumn1"
        '
        'PasswordDataGridViewTextBoxColumn1
        '
        Me.PasswordDataGridViewTextBoxColumn1.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn1.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn1.Name = "PasswordDataGridViewTextBoxColumn1"
        '
        'JoindateDataGridViewTextBoxColumn
        '
        Me.JoindateDataGridViewTextBoxColumn.DataPropertyName = "joindate"
        Me.JoindateDataGridViewTextBoxColumn.HeaderText = "joindate"
        Me.JoindateDataGridViewTextBoxColumn.Name = "JoindateDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'VirusDGV
        '
        Me.VirusDGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.VirusDGV.Controls.Add(Me.Button2)
        Me.VirusDGV.Controls.Add(Me.Label18)
        Me.VirusDGV.Controls.Add(Me.Label19)
        Me.VirusDGV.Controls.Add(Me.Label20)
        Me.VirusDGV.Controls.Add(Me.TextBox9)
        Me.VirusDGV.Controls.Add(Me.TextBox10)
        Me.VirusDGV.Controls.Add(Me.TextBox11)
        Me.VirusDGV.Controls.Add(Me.Label21)
        Me.VirusDGV.Controls.Add(Me.DataGridView1)
        Me.VirusDGV.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VirusDGV.Location = New System.Drawing.Point(4, 22)
        Me.VirusDGV.Name = "VirusDGV"
        Me.VirusDGV.Padding = New System.Windows.Forms.Padding(3)
        Me.VirusDGV.Size = New System.Drawing.Size(793, 376)
        Me.VirusDGV.TabIndex = 3
        Me.VirusDGV.Text = "Virus DB"
        '
        'TotalfrequencyDataGridViewTextBoxColumn
        '
        Me.TotalfrequencyDataGridViewTextBoxColumn.DataPropertyName = "totalfrequency"
        Me.TotalfrequencyDataGridViewTextBoxColumn.HeaderText = "totalfrequency"
        Me.TotalfrequencyDataGridViewTextBoxColumn.Name = "TotalfrequencyDataGridViewTextBoxColumn"
        '
        'VirusnameDataGridViewTextBoxColumn
        '
        Me.VirusnameDataGridViewTextBoxColumn.DataPropertyName = "virusname"
        Me.VirusnameDataGridViewTextBoxColumn.HeaderText = "virusname"
        Me.VirusnameDataGridViewTextBoxColumn.Name = "VirusnameDataGridViewTextBoxColumn"
        '
        'Md5DataGridViewTextBoxColumn
        '
        Me.Md5DataGridViewTextBoxColumn.DataPropertyName = "md5"
        Me.Md5DataGridViewTextBoxColumn.HeaderText = "md5"
        Me.Md5DataGridViewTextBoxColumn.Name = "Md5DataGridViewTextBoxColumn"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Md5DataGridViewTextBoxColumn, Me.VirusnameDataGridViewTextBoxColumn, Me.TotalfrequencyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VirusDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(781, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(11, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 20)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Virus Nsme"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(11, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 20)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "MD5"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(11, 121)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 20)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Total Frequency"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(152, 121)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 25)
        Me.TextBox9.TabIndex = 83
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(152, 59)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 25)
        Me.TextBox10.TabIndex = 81
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(152, 90)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 25)
        Me.TextBox11.TabIndex = 82
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(10, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 25)
        Me.Label21.TabIndex = 80
        Me.Label21.Text = "Edit VirusDB"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(374, 79)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(402, 123)
        Me.DataGridView2.TabIndex = 82
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(374, 243)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(402, 123)
        Me.DataGridView3.TabIndex = 83
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(350, 0)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(10, 376)
        Me.TextBox12.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(698, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 31)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 31)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(698, 183)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 31)
        Me.Button3.TabIndex = 92
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Window_Button
        '
        Me.Window_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
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
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Window_Button)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPage"
        Me.Text = "AdminPage"
        CType(Me.AdminDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SentinnelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VirusDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VirusHashBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VirusListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VirusHashBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.adminDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VirusDGV.ResumeLayout(False)
        Me.VirusDGV.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Icon_picturebox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Close_Button As Button
    Friend WithEvents Max_Button As Button
    Friend WithEvents Min_Button As Button
    Friend WithEvents Window_Button As Button
    Friend WithEvents VirusListDataSet As VirusListDataSet
    Friend WithEvents UserDataBindingSource As BindingSource
    Friend WithEvents UserDataTableAdapter As VirusListDataSetTableAdapters.UserDataTableAdapter
    Friend WithEvents VirusHashBindingSource As BindingSource
    Friend WithEvents VirusHashTableAdapter As VirusListDataSetTableAdapters.VirusHashTableAdapter
    Friend WithEvents VirusHashBindingSource1 As BindingSource
    Friend WithEvents SentinnelDBDataSet As SentinnelDBDataSet
    Friend WithEvents UserDBBindingSource As BindingSource
    Friend WithEvents UserDBTableAdapter As SentinnelDBDataSetTableAdapters.UserDBTableAdapter
    Friend WithEvents VirusDBBindingSource As BindingSource
    Friend WithEvents VirusDBTableAdapter As SentinnelDBDataSetTableAdapters.VirusDBTableAdapter
    Friend WithEvents AdminDBBindingSource As BindingSource
    Friend WithEvents AdminDBTableAdapter As SentinnelDBDataSetTableAdapters.AdminDBTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Inf_score As TextBox
    Friend WithEvents Virus_title As Label
    Friend WithEvents File_count As TextBox
    Friend WithEvents Date_box As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents User_title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents adminDGV As DataGridView
    Friend WithEvents AdminKeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDGV As DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JoindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents VirusDGV As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Md5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VirusnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalfrequencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
