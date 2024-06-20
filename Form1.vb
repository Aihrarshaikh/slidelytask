Public Class Form1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub btnSearchEditSubmission_Click(sender As Object, e As EventArgs) Handles btnSearchEditSubmission.Click
        Dim searchEditForm As New SearchEditForm()
        searchEditForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSearchEditSubmission.PerformClick()
        End If
    End Sub
End Class
