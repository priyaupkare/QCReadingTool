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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gbCL60 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Machine = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TOTALCOUNT = New System.Windows.Forms.Label()
        Me.BADCOUNT = New System.Windows.Forms.Label()
        Me.GOODCOUNT = New System.Windows.Forms.Label()
        Me.TARGETCOUNT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.gbCL60.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCT TYPE : "
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"--Select--", "Futuregroup printed & encoded", "Non Futuregroup printed & encoded", "CL60K output, non printed & encoded"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(363, 27)
        Me.ComboBox1.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(585, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(81, 32)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "EXIT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(496, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gbCL60
        '
        Me.gbCL60.Controls.Add(Me.TextBox5)
        Me.gbCL60.Controls.Add(Me.TextBox4)
        Me.gbCL60.Controls.Add(Me.Label6)
        Me.gbCL60.Controls.Add(Me.Button5)
        Me.gbCL60.Controls.Add(Me.ProgressBar1)
        Me.gbCL60.Controls.Add(Me.DataGridView1)
        Me.gbCL60.Controls.Add(Me.Machine)
        Me.gbCL60.Controls.Add(Me.Label12)
        Me.gbCL60.Controls.Add(Me.TextBox3)
        Me.gbCL60.Controls.Add(Me.Label11)
        Me.gbCL60.Controls.Add(Me.Button4)
        Me.gbCL60.Controls.Add(Me.TextBox2)
        Me.gbCL60.Controls.Add(Me.Label10)
        Me.gbCL60.Controls.Add(Me.TextBox1)
        Me.gbCL60.Controls.Add(Me.GroupBox1)
        Me.gbCL60.Controls.Add(Me.Button3)
        Me.gbCL60.Controls.Add(Me.Button2)
        Me.gbCL60.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCL60.Location = New System.Drawing.Point(15, 44)
        Me.gbCL60.Name = "gbCL60"
        Me.gbCL60.Size = New System.Drawing.Size(1164, 533)
        Me.gbCL60.TabIndex = 36
        Me.gbCL60.TabStop = False
        Me.gbCL60.Text = "CL60K"
        Me.gbCL60.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(906, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Label6"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(25, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(266, 51)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "RFID CALIBRATE "
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(297, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(455, 25)
        Me.ProgressBar1.TabIndex = 48
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(297, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(455, 469)
        Me.DataGridView1.TabIndex = 47
        '
        'Machine
        '
        Me.Machine.AutoSize = True
        Me.Machine.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Machine.Location = New System.Drawing.Point(44, 25)
        Me.Machine.Name = "Machine"
        Me.Machine.Size = New System.Drawing.Size(81, 17)
        Me.Machine.TabIndex = 45
        Me.Machine.Text = "MACHINE  : "
        Me.Machine.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "CL60KROLL : "
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(101, 154)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 23)
        Me.TextBox3.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "QTY TO QC : "
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(25, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(266, 49)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "ROLL FINISHED | QC DONE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(101, 182)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 23)
        Me.TextBox2.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 17)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "CUSTOMER : "
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(101, 124)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 23)
        Me.TextBox1.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TOTALCOUNT)
        Me.GroupBox1.Controls.Add(Me.BADCOUNT)
        Me.GroupBox1.Controls.Add(Me.GOODCOUNT)
        Me.GroupBox1.Controls.Add(Me.TARGETCOUNT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 320)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 202)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'TOTALCOUNT
        '
        Me.TOTALCOUNT.AutoSize = True
        Me.TOTALCOUNT.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALCOUNT.Location = New System.Drawing.Point(123, 170)
        Me.TOTALCOUNT.Name = "TOTALCOUNT"
        Me.TOTALCOUNT.Size = New System.Drawing.Size(0, 17)
        Me.TOTALCOUNT.TabIndex = 8
        '
        'BADCOUNT
        '
        Me.BADCOUNT.AutoSize = True
        Me.BADCOUNT.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BADCOUNT.Location = New System.Drawing.Point(123, 126)
        Me.BADCOUNT.Name = "BADCOUNT"
        Me.BADCOUNT.Size = New System.Drawing.Size(0, 17)
        Me.BADCOUNT.TabIndex = 7
        '
        'GOODCOUNT
        '
        Me.GOODCOUNT.AutoSize = True
        Me.GOODCOUNT.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOODCOUNT.Location = New System.Drawing.Point(123, 79)
        Me.GOODCOUNT.Name = "GOODCOUNT"
        Me.GOODCOUNT.Size = New System.Drawing.Size(0, 17)
        Me.GOODCOUNT.TabIndex = 6
        '
        'TARGETCOUNT
        '
        Me.TARGETCOUNT.AutoSize = True
        Me.TARGETCOUNT.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TARGETCOUNT.Location = New System.Drawing.Point(123, 28)
        Me.TARGETCOUNT.Name = "TARGETCOUNT"
        Me.TARGETCOUNT.Size = New System.Drawing.Size(0, 17)
        Me.TARGETCOUNT.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TOTAL COUNT  : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BAD COUNT  : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "GOOD COUNT  : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TARGET COUNT  : "
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(25, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(266, 48)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "START QC"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(25, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(266, 51)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "MEDIA CALIBRATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(762, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(67, 23)
        Me.TextBox4.TabIndex = 51
        Me.TextBox4.Text = "700"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(835, 24)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(67, 23)
        Me.TextBox5.TabIndex = 52
        Me.TextBox5.Text = "300"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1230, 589)
        Me.Controls.Add(Me.gbCL60)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "QC Task"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbCL60.ResumeLayout(False)
        Me.gbCL60.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents gbCL60 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Machine As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TOTALCOUNT As Label
    Friend WithEvents BADCOUNT As Label
    Friend WithEvents GOODCOUNT As Label
    Friend WithEvents TARGETCOUNT As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button5 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
