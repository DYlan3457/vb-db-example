Imports System.Windows.Forms

Public Class AllDataDialog

    Private Sub AllDataDialog_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Get the hashtable from the Tag
        'Process it into a string and display
        'More sophisticated formatting is, of course, possible - I'll leave that up to you :)
        'You would probably sort coffee shops by name, or best average rating
        'And sort reviews by date

        Dim allReviews As Hashtable = CType(Tag, Hashtable)

        Dim output As String = " *** All Coffee Shops and Reviews *** " + vbNewLine + vbNewLine
        For Each shop As CoffeeShop In allReviews.Keys

            output = output + shop.Name + " - " + shop.Address + vbNewLine

            Dim allRev As ArrayList = CType(allReviews.Item(shop), ArrayList)

            If allRev.Count = 0 Then
                output = output + vbTab + " * no reviews * " + vbNewLine
            End If
            For Each review In allRev
                Console.WriteLine("adding tab")
                output = output + vbTab + review.ToString + vbNewLine
                Console.WriteLine(output)

            Next
            Console.WriteLine(output)

            output = output + vbNewLine
        Next

        Console.WriteLine(output)


        txtOutput.Text = output

    End Sub



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class
