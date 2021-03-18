<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminManageStudent
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.TbAddress = New System.Windows.Forms.TextBox()
        Me.TbGender = New System.Windows.Forms.ComboBox()
        Me.DTPBirth = New System.Windows.Forms.DateTimePicker()
        Me.TbPhone = New System.Windows.Forms.TextBox()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPhoto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CbKelas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(337, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Form"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(54, 81)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(796, 264)
        Me.DGV.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date Of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Phone Number"
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(405, 370)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(142, 22)
        Me.TbName.TabIndex = 7
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(405, 398)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.Size = New System.Drawing.Size(142, 36)
        Me.TbAddress.TabIndex = 8
        '
        'TbGender
        '
        Me.TbGender.FormattingEnabled = True
        Me.TbGender.Items.AddRange(New Object() {"L", "P"})
        Me.TbGender.Location = New System.Drawing.Point(405, 441)
        Me.TbGender.Name = "TbGender"
        Me.TbGender.Size = New System.Drawing.Size(142, 21)
        Me.TbGender.TabIndex = 9
        '
        'DTPBirth
        '
        Me.DTPBirth.Location = New System.Drawing.Point(405, 473)
        Me.DTPBirth.Name = "DTPBirth"
        Me.DTPBirth.Size = New System.Drawing.Size(142, 22)
        Me.DTPBirth.TabIndex = 10
        '
        'TbPhone
        '
        Me.TbPhone.Location = New System.Drawing.Point(405, 504)
        Me.TbPhone.Name = "TbPhone"
        Me.TbPhone.Size = New System.Drawing.Size(142, 22)
        Me.TbPhone.TabIndex = 11
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(566, 370)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(142, 22)
        Me.TbId.TabIndex = 15
        Me.TbId.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 547)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Photo"
        '
        'TbPhoto
        '
        Me.TbPhoto.Location = New System.Drawing.Point(405, 538)
        Me.TbPhoto.Name = "TbPhoto"
        Me.TbPhoto.Size = New System.Drawing.Size(142, 22)
        Me.TbPhoto.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(553, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 22)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CbKelas
        '
        Me.CbKelas.FormattingEnabled = True
        Me.CbKelas.Items.AddRange(New Object() {"L", "P"})
        Me.CbKelas.Location = New System.Drawing.Point(405, 575)
        Me.CbKelas.Name = "CbKelas"
        Me.CbKelas.Size = New System.Drawing.Size(142, 21)
        Me.CbKelas.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 583)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Kelas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(462, 602)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 38)
        Me.BtnCancel.TabIndex = 26
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(381, 602)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 38)
        Me.BtnDelete.TabIndex = 25
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(300, 602)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 38)
        Me.BtnInput.TabIndex = 24
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'AdminManageStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.CbKelas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbPhoto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.TbPhone)
        Me.Controls.Add(Me.DTPBirth)
        Me.Controls.Add(Me.TbGender)
        Me.Controls.Add(Me.TbAddress)
        Me.Controls.Add(Me.TbName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminManageStudent"
        Me.Text = "AdminManageStudent"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbName As TextBox
    Friend WithEvents TbAddress As TextBox
    Friend WithEvents TbGender As ComboBox
    Friend WithEvents DTPBirth As DateTimePicker
    Friend WithEvents TbPhone As TextBox
    Friend WithEvents TbId As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbPhoto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CbKelas As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnInput As Button
End Class
