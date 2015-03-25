Imports System.Data.SqlClient

'       **********  TODO Better SQL Exception handling *****************
' TODO When new user or coffee shop is added, update the user and coffee shop comboboxes
'TODO pop-up window with all coffee shops and list of reviews

Public Class Form1

    Dim objConnection As New SqlConnection("server=localhost\sqlexpress;database=restaurants;user id=sa;password=clara") 'Change to your actual password!
    Dim objTableNameDataAdapter As SqlDataAdapter
    Dim objUserNamesDataAdapter As SqlDataAdapter
    Dim objCoffeeShopNamesDataAdapter As SqlDataAdapter

    Dim objTableNamesDataTable As New DataTable()
    Dim objUserNamesDataTable As New DataTable()
    Dim objCoffeeShopNamesDataTable As New DataTable()

    Dim objReviewAdapter As SqlDataAdapter
    Dim objReviewDataTable As New DataTable()

    Dim allDataFromTableDataAdapter As SqlDataAdapter
    Dim addDataFromTableDataTable As DataTable


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fetch names of tables and display them in first combobox
        objTableNameDataAdapter = New SqlDataAdapter("select name from sys.tables", objConnection)
        objTableNameDataAdapter.Fill(objTableNamesDataTable)
        cboTableNames.DataSource = objTableNamesDataTable
        Dim tableNameColumn As String = "name"
        cboTableNames.DisplayMember = tableNameColumn   'this is the name of the column from the query results.
        'Tells the combobox which column to display as the combobox choices.
        cboTableNames.ValueMember = tableNameColumn  'This tells the combobox what data to return when SelectedValue is called.
        'you need to set ValueMember for the combobbox to return the String value for the column. Otherwise it will return a datagridrow which isn't as useful.

        selectFirstOrDisplayError(cboTableNames, "No database tables found")

        'Fetch all usernames and add to cboUsers
        objUserNamesDataAdapter = New SqlDataAdapter("select username from users", objConnection)
        objUserNamesDataAdapter.Fill(objUserNamesDataTable)
        cboUsers.DataSource = objUserNamesDataTable
        Dim usernameColumn As String = "username"
        cboUsers.DisplayMember = usernameColumn
        cboUsers.ValueMember = usernameColumn
        selectFirstOrDisplayError(cboUsers, "No users found")

        'Fetch all coffee shop names and add to cboCoffeeShops
        objCoffeeShopNamesDataAdapter = New SqlDataAdapter("select name from coffeeshops", objConnection)
        objCoffeeShopNamesDataAdapter.Fill(objCoffeeShopNamesDataTable)
        cboCoffeeShops.DataSource = objCoffeeShopNamesDataTable
        Dim columnName As String = "name"
        cboCoffeeShops.DisplayMember = columnName  'This is the column name you want to display
        cboCoffeeShops.ValueMember = columnName 'This is the column that is returned when you query the combobox for the value selected
        selectFirstOrDisplayError(cboCoffeeShops, "No coffee shops found")

    End Sub


    '   Private Sub saveReviewButton_Click(sender As Object, e As EventArgs) Handles saveReviewButton.Click
    Private Sub dontcallme()

        'TODO VALIDATION

        Dim username As String = cboUsers.SelectedValue
        Dim coffeeShop As String = cboCoffeeShops.SelectedValue

        Dim rating As Integer = tbrRating.Value
        Dim review As String = txtReview.Text

        'Need to add this review. But, we need the user's ID and coffee shop ID, not their names

        'Method one: Write a query to fetch the user's ID for their user name; 
        ' SELECT userid from users where username = user
        'another query to get the coffee shop from the coffeeshop table
        ' SELECT shopid from coffeeshops where name = coffeshop
        'Use this info to create an insert statement
        ' INSERT INTO reviews VALUES ( shopid, userid, rating, review )

        Dim getUserIdSQL As String = "select userid from users where username = '" + username + "'"
        objReviewAdapter = New SqlDataAdapter(getUserIdSQL, objConnection)
        objReviewAdapter.Fill(objReviewDataTable)

        'The data should be the first thing in the first row... we only expect one row to be returned 
        '(notice when the tables were created, username was defined as unique - it must be different in each row.
        'CHECK NUMBER OF ROWS RETURNED HERE!

        Dim userId As Integer = objReviewDataTable.Rows.Item(0).Item(0)

        objReviewAdapter = New SqlDataAdapter("select shopid from coffeeshops where name = '" + coffeeShop + "'", objConnection)
        objReviewAdapter.Fill(objReviewDataTable)

        'The data should be the first thing in the first row... we only expect one row to be returned 
        '(remember when the tables were created, username was defined as unique - it must be different in each row.)

        Dim shopID As Integer = objReviewDataTable.Rows.Item(0).Item(0)

        'TODO is there a better syntax for the line above ^^^^  ?

        'Need a string like this:     "insert into reviews values ( 1, 2, 5, 'excellent coffee', 'today's date')"
        'Notice that you'd have to turn your integer numbers into strings, such as in the line below to form the SQL string. Annoying, huh? 
        'Dim newReviewInsertSQL As String = "insert into reviews values ( " + CStr(shopID) + " , " + CStr(userId) + " , " + CStr(rating) + " , '" + review + "', '" + Date.Now().ToShortDateString + "')"

        'This is a better approach - using parameters. Need to create a SQLCommand object to help. 

        'Create a string with @parameter statements in - one for each value we'll need to replace with data
        Dim insertUserSQL As String = "insert into reviews values(@shopid, @userid, @rating, @reviewtext, @date)"

        'Create a SQLCommand object, need to tell it the SQL string  and the DB connection
        Dim insertNewReviewSQLCommand As New SqlCommand(insertUserSQL, objConnection)

        'Replace the parameters - the @userid, @rating, etc. with data
        insertNewReviewSQLCommand.Parameters.AddWithValue("@shopid", shopID)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@userid", userId)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@rating", rating)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@reviewtext", review)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@date", Date.Now)

        'Parameters are a much safer approach than building a SQL command. Easier to create a string with the correct format
        'And, it prevents a security issue called SQL injection which is really serious. 


        'Here, don't need a datatable - this is an update we are issuing to the DB which doesn't return anything.
        '(Actually, either it works and returns the number of rows changed (which we'll ignore here), or the update fails and a SQLException is thrown.)
        'So open the connection, create the command, execute it, close the connection.

        Try
            objConnection.Open()
            insertNewReviewSQLCommand.ExecuteNonQuery()
            objConnection.Close()
            MessageBox.Show("Added new review - you can verify in datagrid above")

        Catch se As SqlException
            MessageBox.Show("Error adding new review to database : " & se.Message)
        End Try

        'Coming next: method two: write one query to do the whole thing. Comment this entire method,
        'Uncomment the alternative version of the method below - the SQL query is more complex but the code is much
        'shorter and the faster - better to make one request than 3.

    End Sub


    Private Sub saveReviewButton_Click(sender As Object, e As EventArgs) Handles saveReviewButton.Click

        Dim username As String = cboUsers.SelectedValue
        Dim coffeeShop As String = cboCoffeeShops.SelectedValue

        Dim rating As Integer = tbrRating.Value
        Dim review As String = txtReview.Text

        'Need to add this review. But, we need the user's ID and coffee shop ID, not their names

        'Method two - write one query that requests the user's ID for their user name; 
        'and  coffee shop from the coffeeshop id, and use these in the update query.   Example:      

        '           insert into reviews values ( (Select shopid from coffeeshops where name = 'C# Cafe'),
        '           (Select userid from users where username = 'Molly Mocha'), 5, 'Awesome', '2015-01-01' )

        'Now we don't need to read in the data from two queries and store it. 
        'Let's use parameters again.
        'Create a string with @parameter statements in - one for each value we'll need to replace with data

        Dim insertReviewSQL As String = "insert into reviews values ( (Select shopid from coffeeshops where name = @shopname), (Select userid from users where username = @username), @rating, @reviewText, @date) "

        'Create a SQLCommand object, need to tell it the SQL string  and the DB connection
        Dim insertNewReviewSQLCommand As New SqlCommand(insertReviewSQL, objConnection)

        'Replace the parameters - the @userid, @rating, etc. with data
        insertNewReviewSQLCommand.Parameters.AddWithValue("@shopname", coffeeShop)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@username", username)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@rating", rating)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@reviewtext", review)
        insertNewReviewSQLCommand.Parameters.AddWithValue("@date", Date.Now)

        'Parameters are a much safer approach than building a SQL command. Easier to create a string with the correct format
        'And, it prevents a security issue called SQL injection which is really serious. 

        'Here, don't need a datatable - this is an update we are issuing to the DB which doesn't return anything.
        '(Actually, either it works and returns the number of rows changed (which we'll ignore here), or the update fails and a SQLException is thrown.)
        'So open the connection, create the command, execute it, close the connection.

        Try
            objConnection.Open()
            insertNewReviewSQLCommand.ExecuteNonQuery()
            objConnection.Close()
            MessageBox.Show("Added new review - you can verify in datagrid above")
        Catch se As SqlException
            'Again, useful to check the error code. 515 is unable to insert because there was no coffee shop found with that name, or no user found with that username.
            'The database won't be changed in this event.
            If se.Number = 515 Then
                MessageBox.Show("Coffee shop or user not found in database")
            Else
                MessageBox.Show("Database error :" & se.Message)  'Again, don't do this in production code!
            End If

        End Try

    End Sub




    'Display the rating trackbar's value in a label. 
    Private Sub tbrRating_Scroll(sender As Object, e As EventArgs) Handles tbrRating.Scroll
        lblRating.Text = CStr(tbrRating.Value)
    End Sub

    'A quit button. TODO - an are you sure message, and you might want to make sure
    'you've saved any data needed
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    'Helper method to select first item of a combo box, or display an error message box
    'if the combo box has no items. called by Form1 load
    Private Sub selectFirstOrDisplayError(comboBox As ComboBox, errorMessage As String)

        If comboBox.Items.Count > 0 Then
            comboBox.SelectedIndex = 0
        Else
            MessageBox.Show(errorMessage)
            comboBox.Enabled = False
        End If

    End Sub


    Private Sub btnDisplayData_Click(sender As Object, e As EventArgs) Handles btnDisplayData.Click

        'Identify the table name and fetch all the data

        Dim tablename As String = cboTableNames.SelectedValue

        If tablename Is Nothing Then
            Return
        End If

        Dim selectAllSQL As String = "select * from " & tablename

        'Replace previous DataTable with new one, update the DataGridView's data source.
        allDataFromTableDataAdapter = New SqlDataAdapter(selectAllSQL, objConnection)
        addDataFromTableDataTable = New DataTable()
        allDataFromTableDataAdapter.Fill(addDataFromTableDataTable)

        grdViewDatabase.DataSource = addDataFromTableDataTable

    End Sub

    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click

        'Pop up a box to ask for the username and email
        If NewUserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Fetch new user from Tag, extract username and email

            Dim user As User = CType(NewUserDialog.Tag, User)

            Dim newUserInsertSQL As String = "insert into users values (@username, @email)"

            Dim sqlAddUserCommand As New SqlCommand(newUserInsertSQL, objConnection)
            sqlAddUserCommand.Parameters.AddWithValue("@username", user.Username)
            sqlAddUserCommand.Parameters.AddWithValue("@email", user.Email)

            Try
                objConnection.Open()
                sqlAddUserCommand.ExecuteNonQuery()
                objConnection.Close()

                MessageBox.Show("New user added, reload table in datagrid view to verify")

            Catch se As SqlException
                'If this username already exists, we'll get a specific SQLException 
                'SQL Exceptions contain an error code, to help identify different types of errors.
                'Trying to insert a row with a unique column value that duplicates the same value
                ' in another row generates a SQLException with error code 2627. You can look these up online - Google "SQL Server error codes"
                If se.Number = 2627 Then
                    'Duplicate row, this user already exists
                    MessageBox.Show("This user or email already exists the database in, try again")
                Else
                    MessageBox.Show("Database error: " & se.Message) 'Don't display the exception message in production code!
                End If

            End Try

        End If

    End Sub


    Private Sub btnAddNewCoffeeShop_Click(sender As Object, e As EventArgs) Handles btnAddNewCoffeeShop.Click

        'Pop up a box to ask for the username and email
        If NewCoffeeShopDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Fetch new user from Tag, extract username and email

            Dim coffee As CoffeeShop = CType(NewCoffeeShopDialog.Tag, CoffeeShop)

            Dim newCoffeeInsertSQL As String = "insert into coffeeshops values (@name, @address)"

            Dim sqlAddCoffeeCommand As New SqlCommand(newCoffeeInsertSQL, objConnection)
            sqlAddCoffeeCommand.Parameters.AddWithValue("@name", coffee.Name)
            sqlAddCoffeeCommand.Parameters.AddWithValue("@address", coffee.Address)

            Try
                objConnection.Open()
                sqlAddCoffeeCommand.ExecuteNonQuery()
                objConnection.Close()

                MessageBox.Show("New coffee shop added, reload table in datagrid view to verify")

            Catch se As SqlException
                'If this username already exists, we'll get a specific SQLException 
                'SQL Exceptions contain an error code, to help identify different types of errors.
                'Trying to insert a row with a unique column value that duplicates the same value
                ' in another row generates a SQLException with error code 2627. You can look these up online - Google "SQL Server error codes"
                If se.Number = 2627 Then
                    'Duplicate row, this user already exists
                    MessageBox.Show("This coffee shop or address already exists in the database, try again")
                Else
                    MessageBox.Show("Database error: " & se.Message) 'Don't display the exception message in production code!
                End If

            End Try

        End If

    End Sub


End Class
