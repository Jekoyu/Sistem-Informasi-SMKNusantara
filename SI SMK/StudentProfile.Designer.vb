<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentProfile
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
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbPhoto = New System.Windows.Forms.TextBox()
        Me.TbPhone = New System.Windows.Forms.TextBox()
        Me.DTPBirth = New System.Windows.Forms.DateTimePicker()
        Me.CbGender = New System.Windows.Forms.ComboBox()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbNama
        '
        Me.TbNama.Location = New System.Drawing.Point(372, 260)
        Me.TbNama.Multiline = True
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(233, 33)
        Me.TbNama.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(344, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 144)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(250, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(365, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Form Profile"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(466, 548)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 48)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 548)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 48)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(249, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 21)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Photo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(249, 439)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 21)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Phone Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(249, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Date Of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(249, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(249, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(611, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 33)
        Me.Button1.TabIndex = 65
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TbPhoto
        '
        Me.TbPhoto.Location = New System.Drawing.Point(372, 476)
        Me.TbPhoto.Multiline = True
        Me.TbPhoto.Name = "TbPhoto"
        Me.TbPhoto.Size = New System.Drawing.Size(233, 36)
        Me.TbPhoto.TabIndex = 64
        '
        'TbPhone
        '
        Me.TbPhone.Location = New System.Drawing.Point(371, 439)
        Me.TbPhone.Name = "TbPhone"
        Me.TbPhone.Size = New System.Drawing.Size(233, 22)
        Me.TbPhone.TabIndex = 63
        '
        'DTPBirth
        '
        Me.DTPBirth.Location = New System.Drawing.Point(371, 400)
        Me.DTPBirth.Name = "DTPBirth"
        Me.DTPBirth.Size = New System.Drawing.Size(233, 22)
        Me.DTPBirth.TabIndex = 62
        '
        'CbGender
        '
        Me.CbGender.FormattingEnabled = True
        Me.CbGender.Items.AddRange(New Object() {"L", "P"})
        Me.CbGender.Location = New System.Drawing.Point(371, 361)
        Me.CbGender.Name = "CbGender"
        Me.CbGender.Size = New System.Drawing.Size(233, 21)
        Me.CbGender.TabIndex = 60
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(371, 306)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(233, 36)
        Me.TbAddress.TabIndex = 61
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'StudentProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbPhoto)
        Me.Controls.Add(Me.TbPhone)
        Me.Controls.Add(Me.DTPBirth)
        Me.Controls.Add(Me.CbGender)
        Me.Controls.Add(Me.TbAddress)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentProfile"
        Me.Text = "StudentProfile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbNama As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TbPhoto As TextBox
    Friend WithEvents TbPhone As TextBox
    Friend WithEvents DTPBirth As DateTimePicker
    Friend WithEvents CbGender As ComboBox
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
