<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchEditForm
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
        Me.txtSearchEmail = New System.Windows.Forms.TextBox()
        Me.lblSearchEmail = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtEditName = New System.Windows.Forms.TextBox()
        Me.lblEditName = New System.Windows.Forms.Label()
        Me.txtEditEmail = New System.Windows.Forms.TextBox()
        Me.lblEditEmail = New System.Windows.Forms.Label()
        Me.txtEditPhone = New System.Windows.Forms.TextBox()
        Me.lblEditPhone = New System.Windows.Forms.Label()
        Me.txtEditGithubLink = New System.Windows.Forms.TextBox()
        Me.lblEditGithubLink = New System.Windows.Forms.Label()
        Me.txtEditStopwatchTime = New System.Windows.Forms.TextBox()
        Me.lblEditStopwatchTime = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearchEmail
        '
        Me.txtSearchEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchEmail.Location = New System.Drawing.Point(111, 25)
        Me.txtSearchEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchEmail.Multiline = True
        Me.txtSearchEmail.Name = "txtSearchEmail"
        Me.txtSearchEmail.Size = New System.Drawing.Size(350, 30)
        Me.txtSearchEmail.TabIndex = 0
        Me.txtSearchEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSearchEmail
        '
        Me.lblSearchEmail.AutoSize = True
        Me.lblSearchEmail.Location = New System.Drawing.Point(13, 27)
        Me.lblSearchEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchEmail.Name = "lblSearchEmail"
        Me.lblSearchEmail.Size = New System.Drawing.Size(90, 16)
        Me.lblSearchEmail.TabIndex = 1
        Me.lblSearchEmail.Text = "Search Email:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSearch.Location = New System.Drawing.Point(484, 13)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(122, 48)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(CTRL+Q)"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtEditName
        '
        Me.txtEditName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditName.Location = New System.Drawing.Point(173, 74)
        Me.txtEditName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditName.Multiline = True
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(265, 25)
        Me.txtEditName.TabIndex = 3
        Me.txtEditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEditName
        '
        Me.lblEditName.AutoSize = True
        Me.lblEditName.Location = New System.Drawing.Point(53, 78)
        Me.lblEditName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditName.Name = "lblEditName"
        Me.lblEditName.Size = New System.Drawing.Size(47, 16)
        Me.lblEditName.TabIndex = 4
        Me.lblEditName.Text = "Name:"
        '
        'txtEditEmail
        '
        Me.txtEditEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditEmail.Enabled = False
        Me.txtEditEmail.Location = New System.Drawing.Point(173, 123)
        Me.txtEditEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditEmail.Multiline = True
        Me.txtEditEmail.Name = "txtEditEmail"
        Me.txtEditEmail.Size = New System.Drawing.Size(265, 25)
        Me.txtEditEmail.TabIndex = 5
        Me.txtEditEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEditEmail
        '
        Me.lblEditEmail.AutoSize = True
        Me.lblEditEmail.Location = New System.Drawing.Point(53, 127)
        Me.lblEditEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditEmail.Name = "lblEditEmail"
        Me.lblEditEmail.Size = New System.Drawing.Size(44, 16)
        Me.lblEditEmail.TabIndex = 6
        Me.lblEditEmail.Text = "Email:"
        '
        'txtEditPhone
        '
        Me.txtEditPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditPhone.Location = New System.Drawing.Point(173, 172)
        Me.txtEditPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditPhone.Multiline = True
        Me.txtEditPhone.Name = "txtEditPhone"
        Me.txtEditPhone.Size = New System.Drawing.Size(265, 25)
        Me.txtEditPhone.TabIndex = 7
        Me.txtEditPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEditPhone
        '
        Me.lblEditPhone.AutoSize = True
        Me.lblEditPhone.Location = New System.Drawing.Point(53, 176)
        Me.lblEditPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditPhone.Name = "lblEditPhone"
        Me.lblEditPhone.Size = New System.Drawing.Size(49, 16)
        Me.lblEditPhone.TabIndex = 8
        Me.lblEditPhone.Text = "Phone:"
        '
        'txtEditGithubLink
        '
        Me.txtEditGithubLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditGithubLink.Location = New System.Drawing.Point(173, 222)
        Me.txtEditGithubLink.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditGithubLink.Multiline = True
        Me.txtEditGithubLink.Name = "txtEditGithubLink"
        Me.txtEditGithubLink.Size = New System.Drawing.Size(265, 25)
        Me.txtEditGithubLink.TabIndex = 9
        Me.txtEditGithubLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEditGithubLink
        '
        Me.lblEditGithubLink.AutoSize = True
        Me.lblEditGithubLink.Location = New System.Drawing.Point(53, 225)
        Me.lblEditGithubLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditGithubLink.Name = "lblEditGithubLink"
        Me.lblEditGithubLink.Size = New System.Drawing.Size(75, 16)
        Me.lblEditGithubLink.TabIndex = 10
        Me.lblEditGithubLink.Text = "Github Link:"
        '
        'txtEditStopwatchTime
        '
        Me.txtEditStopwatchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditStopwatchTime.Location = New System.Drawing.Point(173, 271)
        Me.txtEditStopwatchTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEditStopwatchTime.Multiline = True
        Me.txtEditStopwatchTime.Name = "txtEditStopwatchTime"
        Me.txtEditStopwatchTime.Size = New System.Drawing.Size(265, 25)
        Me.txtEditStopwatchTime.TabIndex = 11
        Me.txtEditStopwatchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEditStopwatchTime
        '
        Me.lblEditStopwatchTime.AutoSize = True
        Me.lblEditStopwatchTime.Location = New System.Drawing.Point(53, 274)
        Me.lblEditStopwatchTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditStopwatchTime.Name = "lblEditStopwatchTime"
        Me.lblEditStopwatchTime.Size = New System.Drawing.Size(106, 16)
        Me.lblEditStopwatchTime.TabIndex = 12
        Me.lblEditStopwatchTime.Text = "Stopwatch Time:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Lime
        Me.btnSave.Location = New System.Drawing.Point(186, 321)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(220, 40)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save(CTRL+S)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'SearchEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 383)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblEditStopwatchTime)
        Me.Controls.Add(Me.txtEditStopwatchTime)
        Me.Controls.Add(Me.lblEditGithubLink)
        Me.Controls.Add(Me.txtEditGithubLink)
        Me.Controls.Add(Me.lblEditPhone)
        Me.Controls.Add(Me.txtEditPhone)
        Me.Controls.Add(Me.lblEditEmail)
        Me.Controls.Add(Me.txtEditEmail)
        Me.Controls.Add(Me.lblEditName)
        Me.Controls.Add(Me.txtEditName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearchEmail)
        Me.Controls.Add(Me.txtSearchEmail)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SearchEditForm"
        Me.Text = "Search and Edit Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchEmail As TextBox
    Friend WithEvents lblSearchEmail As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtEditName As TextBox
    Friend WithEvents lblEditName As Label
    Friend WithEvents txtEditEmail As TextBox
    Friend WithEvents lblEditEmail As Label
    Friend WithEvents txtEditPhone As TextBox
    Friend WithEvents lblEditPhone As Label
    Friend WithEvents txtEditGithubLink As TextBox
    Friend WithEvents lblEditGithubLink As Label
    Friend WithEvents txtEditStopwatchTime As TextBox
    Friend WithEvents lblEditStopwatchTime As Label
    Friend WithEvents btnSave As Button
End Class
