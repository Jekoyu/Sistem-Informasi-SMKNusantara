<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminManageSchedule
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.TbTeacher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbClass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPDay = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbId = New System.Windows.Forms.TextBox()
        Me.CbSubject = New System.Windows.Forms.ComboBox()
        Me.Cbteacher = New System.Windows.Forms.ComboBox()
        Me.CbClass = New System.Windows.Forms.ComboBox()
        Me.TbSubject = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(468, 556)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 38)
        Me.BtnCancel.TabIndex = 55
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(387, 556)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 38)
        Me.BtnDelete.TabIndex = 54
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(306, 556)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 38)
        Me.BtnInput.TabIndex = 53
        Me.BtnInput.Text = "Input"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'TbTeacher
        '
        Me.TbTeacher.Location = New System.Drawing.Point(406, 437)
        Me.TbTeacher.Name = "TbTeacher"
        Me.TbTeacher.Size = New System.Drawing.Size(142, 22)
        Me.TbTeacher.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(306, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Teacher Id"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(57, 67)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(796, 264)
        Me.DGV.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 37)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Schedule Form"
        '
        'TbClass
        '
        Me.TbClass.Location = New System.Drawing.Point(406, 465)
        Me.TbClass.Name = "TbClass"
        Me.TbClass.Size = New System.Drawing.Size(142, 22)
        Me.TbClass.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Class Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Subject Id"
        '
        'DTPDay
        '
        Me.DTPDay.Location = New System.Drawing.Point(406, 494)
        Me.DTPDay.Name = "DTPDay"
        Me.DTPDay.Size = New System.Drawing.Size(142, 22)
        Me.DTPDay.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Day"
        '
        'TbId
        '
        Me.TbId.Location = New System.Drawing.Point(406, 378)
        Me.TbId.Name = "TbId"
        Me.TbId.Size = New System.Drawing.Size(142, 22)
        Me.TbId.TabIndex = 63
        Me.TbId.Visible = False
        '
        'CbSubject
        '
        Me.CbSubject.FormattingEnabled = True
        Me.CbSubject.Location = New System.Drawing.Point(554, 409)
        Me.CbSubject.Name = "CbSubject"
        Me.CbSubject.Size = New System.Drawing.Size(142, 21)
        Me.CbSubject.TabIndex = 64
        '
        'Cbteacher
        '
        Me.Cbteacher.FormattingEnabled = True
        Me.Cbteacher.Location = New System.Drawing.Point(554, 438)
        Me.Cbteacher.Name = "Cbteacher"
        Me.Cbteacher.Size = New System.Drawing.Size(142, 21)
        Me.Cbteacher.TabIndex = 65
        '
        'CbClass
        '
        Me.CbClass.FormattingEnabled = True
        Me.CbClass.Location = New System.Drawing.Point(554, 466)
        Me.CbClass.Name = "CbClass"
        Me.CbClass.Size = New System.Drawing.Size(142, 21)
        Me.CbClass.TabIndex = 66
        '
        'TbSubject
        '
        Me.TbSubject.Location = New System.Drawing.Point(406, 406)
        Me.TbSubject.Name = "TbSubject"
        Me.TbSubject.Size = New System.Drawing.Size(142, 22)
        Me.TbSubject.TabIndex = 67
        '
        'AdminManageSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 669)
        Me.Controls.Add(Me.TbSubject)
        Me.Controls.Add(Me.CbClass)
        Me.Controls.Add(Me.Cbteacher)
        Me.Controls.Add(Me.CbSubject)
        Me.Controls.Add(Me.TbId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTPDay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TbClass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.TbTeacher)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminManageSchedule"
        Me.Text = "AdminManageSchedule"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnInput As Button
    Friend WithEvents TbTeacher As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TbClass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPDay As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TbId As TextBox
    Friend WithEvents CbSubject As ComboBox
    Friend WithEvents Cbteacher As ComboBox
    Friend WithEvents CbClass As ComboBox
    Friend WithEvents TbSubject As TextBox
End Class
