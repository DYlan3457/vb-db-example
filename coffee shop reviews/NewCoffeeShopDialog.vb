Imports System.Windows.Forms

Public Class NewCoffeeShopDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        Dim name As String = txtName.Text
        Dim address As String = txtAddress.Text

        If name = "" Or address = "" Then
            MessageBox.Show("Please enter all data")
            Return
        End If

        Dim newShop As New CoffeeShop()
        newShop.Name = name
        newShop.Address = address
        'Save the new coffee shop in the Tag property
        Tag = newShop

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewCoffeeShopDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear any previous data entered
        txtName.Clear()
        txtAddress.Clear()
        'Set the focus to the name textbox
        ActiveControl = txtName

    End Sub
End Class
