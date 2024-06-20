Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private ReadOnly client As HttpClient
    Private currentIndex As Integer

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/api/")
        currentIndex = 0
        LoadSubmission(currentIndex)
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim response = Await client.GetAsync("read?index=" & index)
            response.EnsureSuccessStatusCode()
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Dim json As JObject = JObject.Parse(responseBody)

            txtName.Text = json("name").ToString()
            txtEmail.Text = json("email").ToString()
            txtPhone.Text = json("phone").ToString()
            txtGithubLink.Text = json("github_link").ToString()
            txtStopwatchTime.Text = json("stopwatch_time").ToString()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSubmission(currentIndex)
    End Sub

    Private Async Sub DeleteSubmission(index As Integer)
        Try
            Dim response = Await client.DeleteAsync("delete?index=" & index)
            response.EnsureSuccessStatusCode()

            MessageBox.Show("Submission deleted successfully.")

            ' Reload the current index or move to the previous one if it's the last submission
            If currentIndex > 0 Then
                currentIndex -= 1
            End If
            LoadSubmission(currentIndex)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
