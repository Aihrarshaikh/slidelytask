<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.btnSearchEditSubmission = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.Gold
        Me.btnViewSubmissions.Location = New System.Drawing.Point(23, 80)
        Me.btnViewSubmissions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(406, 63)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "View Submissions (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'btnCreateSubmission
        '
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateSubmission.Location = New System.Drawing.Point(23, 178)
        Me.btnCreateSubmission.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(406, 62)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "Create New Submission (CTRL + N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        '
        'btnSearchEditSubmission
        '
        Me.btnSearchEditSubmission.BackColor = System.Drawing.Color.LightGreen
        Me.btnSearchEditSubmission.Location = New System.Drawing.Point(23, 276)
        Me.btnSearchEditSubmission.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearchEditSubmission.Name = "btnSearchEditSubmission"
        Me.btnSearchEditSubmission.Size = New System.Drawing.Size(406, 62)
        Me.btnSearchEditSubmission.TabIndex = 2
        Me.btnSearchEditSubmission.Text = "Search/Edit Submission (CTRL + S)"
        Me.btnSearchEditSubmission.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.8!)
        Me.Label1.Location = New System.Drawing.Point(71, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aihrar Shaikh, Slidely Task 2 - Slidely Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearchEditSubmission)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnSearchEditSubmission As Button
    Friend WithEvents Label1 As Label
End Class
