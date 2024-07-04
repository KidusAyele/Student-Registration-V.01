<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userstable
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.ext1 = New System.Windows.Forms.RadioButton()
        Me.register = New System.Windows.Forms.Button()
        Me.w = New System.Windows.Forms.RadioButton()
        Me.r = New System.Windows.Forms.RadioButton()
        Me.dateform = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idtext = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exitform = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CmdView = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lastname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.firstname)
        Me.GroupBox1.Controls.Add(Me.ext1)
        Me.GroupBox1.Controls.Add(Me.register)
        Me.GroupBox1.Controls.Add(Me.w)
        Me.GroupBox1.Controls.Add(Me.r)
        Me.GroupBox1.Controls.Add(Me.dateform)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.idtext)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 226)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"cosc", "acc", "mark"})
        Me.ComboBox1.Location = New System.Drawing.Point(116, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 89
        Me.ComboBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Last name"
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(114, 37)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(142, 20)
        Me.lastname.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "First name:"
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(114, 11)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(142, 20)
        Me.firstname.TabIndex = 85
        '
        'ext1
        '
        Me.ext1.AutoSize = True
        Me.ext1.Location = New System.Drawing.Point(85, 147)
        Me.ext1.Name = "ext1"
        Me.ext1.Size = New System.Drawing.Size(71, 17)
        Me.ext1.TabIndex = 84
        Me.ext1.Text = "Extension"
        Me.ext1.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.register.Location = New System.Drawing.Point(85, 193)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(75, 23)
        Me.register.TabIndex = 82
        Me.register.Text = "Register"
        Me.register.UseVisualStyleBackColor = True
        '
        'w
        '
        Me.w.AutoSize = True
        Me.w.Location = New System.Drawing.Point(85, 170)
        Me.w.Name = "w"
        Me.w.Size = New System.Drawing.Size(75, 17)
        Me.w.TabIndex = 81
        Me.w.Text = "weeknend"
        Me.w.UseVisualStyleBackColor = True
        '
        'r
        '
        Me.r.AutoSize = True
        Me.r.Checked = True
        Me.r.Location = New System.Drawing.Point(85, 124)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(62, 17)
        Me.r.TabIndex = 80
        Me.r.TabStop = True
        Me.r.Text = "Regular"
        Me.r.UseVisualStyleBackColor = True
        '
        'dateform
        '
        Me.dateform.Location = New System.Drawing.Point(85, 98)
        Me.dateform.Name = "dateform"
        Me.dateform.Size = New System.Drawing.Size(129, 20)
        Me.dateform.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Departement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "your id is:"
        '
        'idtext
        '
        Me.idtext.BackColor = System.Drawing.Color.White
        Me.idtext.Location = New System.Drawing.Point(326, 14)
        Me.idtext.Name = "idtext"
        Me.idtext.Size = New System.Drawing.Size(198, 20)
        Me.idtext.TabIndex = 76
        Me.idtext.Tag = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(616, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 205)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Lastname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Firstname"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(131, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(131, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Select ID"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(131, 31)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(183, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(131, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'exitform
        '
        Me.exitform.Location = New System.Drawing.Point(917, 541)
        Me.exitform.Name = "exitform"
        Me.exitform.Size = New System.Drawing.Size(75, 23)
        Me.exitform.TabIndex = 84
        Me.exitform.Text = "Logout"
        Me.exitform.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(155, 255)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(692, 266)
        Me.DataGridView1.TabIndex = 78
        '
        'CmdView
        '
        Me.CmdView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.Location = New System.Drawing.Point(687, 537)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(2)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(93, 27)
        Me.CmdView.TabIndex = 79
        Me.CmdView.Text = "VIEW"
        Me.CmdView.UseVisualStyleBackColor = True
        '
        'userstable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1032, 590)
        Me.Controls.Add(Me.exitform)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userstable"
        Me.Text = "userstable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lastname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents ext1 As System.Windows.Forms.RadioButton
    Friend WithEvents register As System.Windows.Forms.Button
    Friend WithEvents w As System.Windows.Forms.RadioButton
    Friend WithEvents r As System.Windows.Forms.RadioButton
    Friend WithEvents dateform As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idtext As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents exitform As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdView As System.Windows.Forms.Button
End Class
