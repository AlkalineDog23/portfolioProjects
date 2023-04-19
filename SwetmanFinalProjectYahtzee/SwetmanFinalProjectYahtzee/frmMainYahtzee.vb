Public Class frmYahtzee
    Public userName As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'Close button
    End Sub

    Private Sub frmYahtzee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim theDate As Date = Today
        lblStsDate.Text = theDate.ToString("D")
        txtName.Focus()
        'Todays date  on load
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'Play button on click get username to be pulled into next form with error checking
        If (txtName.Text = String.Empty) Then
            MessageBox.Show("Error, Please enter valid username", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf IsNumeric(txtName.Text) Then
            MessageBox.Show("Error, Please enter valid username", "Input Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            userName = txtName.Text
        End If
        'Create instance of gameplay form
        Dim frmGamePlay As New Form
        frmGamePlay = frmInterface
        frmInterface.ShowDialog()

    End Sub
End Class
