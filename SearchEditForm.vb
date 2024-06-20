Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class SearchEditForm
    Private ReadOnly client As HttpClient

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/api/")
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim email = txtSearchEmail.Text
            Dim response = Await client.GetAsync("search?email=" & email)
            response.EnsureSuccessStatusCode()
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Dim json = JObject.Parse(responseBody)
            txtEditName.Text = json("name").ToString()
            txtEditEmail.Text = json("email").ToString()
            txtEditPhone.Text = json("phone").ToString()
            txtEditGithubLink.Text = json("github_link").ToString()
            txtEditStopwatchTime.Text = json("stopwatch_time").ToString()
        Catch ex As HttpRequestException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim email = txtSearchEmail.Text
            Dim json = New JObject()
            json("name") = txtEditName.Text
            json("email") = txtEditEmail.Text
            json("phone") = txtEditPhone.Text
            json("github_link") = txtEditGithubLink.Text
            json("stopwatch_time") = txtEditStopwatchTime.Text

            Dim content = New StringContent(json.ToString(), Encoding.UTF8, "application/json")
            Dim response = Await client.PutAsync("edit?email=" & email, content)
            response.EnsureSuccessStatusCode()

            ' Show success message
            MessageBox.Show("Data updated successfully")

            ' Clear text fields
            txtEditName.Text = ""
            txtEditEmail.Text = ""
            txtEditPhone.Text = ""
            txtEditGithubLink.Text = ""
            txtEditStopwatchTime.Text = ""
            txtSearchEmail.Text = ""

        Catch ex As HttpRequestException
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchEditForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.Q Then
            btnSearch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub SearchEditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
