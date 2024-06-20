Public Class ViewSubmissionsForm
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Open the View Submissions form
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Open the Create New Submission form
        Dim createNewSubmissionForm As New CreateNewSubmissionForm()
        createNewSubmissionForm.Show()
    End Sub
End Class
