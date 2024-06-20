Imports System.Windows.Forms.DataFormats

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of FormData)

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from backend (you'll need to implement the logic to fetch data from the backend)
        submissions = FetchSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub DisplaySubmission()
        ' Display the current submission (you'll need to update this to display the actual data)
        Dim submission = submissions(currentIndex)
        lblName.Text = submission.Name
        lblEmail.Text = submission.Email
        lblPhone.Text = submission.Phone
        lblGitHub.Text = submission.GitHubLink
        lblStopwatchTime.Text = submission.StopwatchTime.ToString()
    End Sub

    Private Function FetchSubmissions() As List(Of FormData)
        ' Implement logic to fetch submissions from backend
        Return New List(Of FormData)()
    End Function
End Class
