<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.components = New System.ComponentModel.Container()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(124, 85)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(345, 30)
        Me.txtName.TabIndex = 0
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(124, 156)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(345, 30)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(124, 227)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(345, 30)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGithubLink
        '
        Me.txtGithubLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGithubLink.Location = New System.Drawing.Point(124, 297)
        Me.txtGithubLink.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGithubLink.Multiline = True
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(345, 30)
        Me.txtGithubLink.TabIndex = 3
        Me.txtGithubLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnToggleStopwatch.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnToggleStopwatch.FlatAppearance.BorderSize = 3
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(13, 366)
        Me.btnToggleStopwatch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(272, 35)
        Me.btnToggleStopwatch.TabIndex = 4
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(13, 431)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(456, 41)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblStopwatchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopwatchTime.Location = New System.Drawing.Point(309, 366)
        Me.lblStopwatchTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(160, 35)
        Me.lblStopwatchTime.TabIndex = 6
        Me.lblStopwatchTime.Text = "00:00:00"
        Me.lblStopwatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Github Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for Task 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Phone Num"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!)
        Me.Label5.Location = New System.Drawing.Point(46, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Aihrar shaikh, slidely Task 2 - Create Submission"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 553)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreateSubmissionForm"
        Me.Text = " Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
