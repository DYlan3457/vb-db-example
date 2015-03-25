Imports System.Windows.Forms

Public Class NewUserDialog


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text

        If username = "" Or email = "" Then
            MessageBox.Show("Please enter all data")

            'TODO validate email address in correct format

            Return
        End If

        Dim newUser As New User()
        newUser.Email = email
        newUser.Username = username

        'Save the new user in the Tag property
        Tag = newUser

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub NewUserDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear any previously entered data
        txtEmail.Text = ""
        txtUsername.Text = ""

    End Sub
End Class
