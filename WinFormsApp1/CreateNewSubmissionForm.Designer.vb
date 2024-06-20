Imports System.Windows.Forms.DataFormats

Public Class CreateNewSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Create a new FormData object with the input data
        Dim newSubmission As New FormData With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = stopwatch.ElapsedMilliseconds
        }

        ' Submit the data to the backend (you'll need to implement the logic to send data to the backend)
        SubmitSubmission(newSubmission)
        MessageBox.Show("Submission successful!")
        ClearForm()
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStopwatch.Text = "Start"
        Else
            stopwatch.Start()
            btnStopwatch.Text = "Stop"
        End If
    End Sub

    Private Sub ClearForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHubLink.Clear()
        stopwatch.Reset()
        btnStopwatch.Text = "Start"
    End Sub

    Private Sub SubmitSubmission(submission As FormData)
        ' Implement logic to submit the submission to the backend
    End Sub
End Class
