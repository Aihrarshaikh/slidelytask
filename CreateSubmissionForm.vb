Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private ReadOnly client As HttpClient
    Private stopwatch As Stopwatch
    Private stopwatchRunning As Boolean

    Public Sub New()
        InitializeComponent()
        client = New HttpClient()
        client.BaseAddress = New Uri("http://localhost:3000/")
        stopwatch = New Stopwatch()
        stopwatchRunning = True
        Timer1.Interval = 1000
        Timer1.Enabled = True
        StartStopwatch()
    End Sub

    Private Sub StartStopwatch()
        stopwatch.Start()
        stopwatchRunning = True
        UpdateStopwatchLabel()
    End Sub

    Private Sub StopStopwatch()
        stopwatch.Stop()
        stopwatchRunning = False
        UpdateStopwatchLabel()
    End Sub
    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        Dim ts As TimeSpan = stopwatch.Elapsed
        lblStopwatchTime.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            StopStopwatch()
            Dim submission As New Dictionary(Of String, String) From {
                {"name", txtName.Text},
                {"email", txtEmail.Text},
                {"phone", txtPhone.Text},
                {"github_link", txtGithubLink.Text},
                {"stopwatch_time", lblStopwatchTime.Text}
            }

            ' Serialize the submission dictionary to JSON
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            ' Send the POST request
            Dim response = Await client.PostAsync("api/submit", content)
            response.EnsureSuccessStatusCode()

            ' Get the response body
            Dim responseBody = Await response.Content.ReadAsStringAsync()
            MessageBox.Show("Submission response: " & responseBody)


            ' Clear all text fields
            txtName.Text = ""
            txtEmail.Text = ""
            txtPhone.Text = ""
            txtGithubLink.Text = ""

            ' Reset stopwatch
            stopwatch.Reset()
            stopwatchRunning = True
            StartStopwatch()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            If stopwatchRunning Then
                StopStopwatch()
            Else
                StartStopwatch()
            End If
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatchRunning Then
            UpdateStopwatchLabel()
        End If
    End Sub

    Private Sub txtGithubLink_TextChanged(sender As Object, e As EventArgs) Handles txtGithubLink.TextChanged

    End Sub

    Private Sub lblStopwatchTime_Click(sender As Object, e As EventArgs) Handles lblStopwatchTime.Click

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged











    End Sub
End Class
