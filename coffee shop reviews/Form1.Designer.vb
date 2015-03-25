<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdViewDatabase = New System.Windows.Forms.DataGridView()
        Me.cboTableNames = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.saveReviewButton = New System.Windows.Forms.Button()
        Me.cboCoffeeShops = New System.Windows.Forms.ComboBox()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.txtReview = New System.Windows.Forms.TextBox()
        Me.tbrRating = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAddNewCoffeeShop = New System.Windows.Forms.Button()
        Me.btnAddNewUser = New System.Windows.Forms.Button()
        Me.btnShowAllData = New System.Windows.Forms.Button()
        CType(Me.grdViewDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdViewDatabase
        '
        Me.grdViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDatabase.Location = New System.Drawing.Point(0, 54)
        Me.grdViewDatabase.Name = "grdViewDatabase"
        Me.grdViewDatabase.Size = New System.Drawing.Size(514, 150)
        Me.grdViewDatabase.TabIndex = 0
        '
        'cboTableNames
        '
        Me.cboTableNames.FormattingEnabled = True
        Me.cboTableNames.Location = New System.Drawing.Point(189, 24)
        Me.cboTableNames.Name = "cboTableNames"
        Me.cboTableNames.Size = New System.Drawing.Size(204, 21)
        Me.cboTableNames.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose table to display"
        '
        'saveReviewButton
        '
        Me.saveReviewButton.Location = New System.Drawing.Point(375, 175)
        Me.saveReviewButton.Name = "saveReviewButton"
        Me.saveReviewButton.Size = New System.Drawing.Size(75, 23)
        Me.saveReviewButton.TabIndex = 3
        Me.saveReviewButton.Text = "Save Review"
        Me.saveReviewButton.UseVisualStyleBackColor = True
        '
        'cboCoffeeShops
        '
        Me.cboCoffeeShops.FormattingEnabled = True
        Me.cboCoffeeShops.Location = New System.Drawing.Point(375, 29)
        Me.cboCoffeeShops.Name = "cboCoffeeShops"
        Me.cboCoffeeShops.Size = New System.Drawing.Size(121, 21)
        Me.cboCoffeeShops.TabIndex = 4
        '
        'cboUsers
        '
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(137, 29)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(121, 21)
        Me.cboUsers.TabIndex = 5
        '
        'txtReview
        '
        Me.txtReview.Location = New System.Drawing.Point(16, 85)
        Me.txtReview.MaxLength = 2047
        Me.txtReview.Multiline = True
        Me.txtReview.Name = "txtReview"
        Me.txtReview.Size = New System.Drawing.Size(319, 127)
        Me.txtReview.TabIndex = 6
        '
        'tbrRating
        '
        Me.tbrRating.LargeChange = 1
        Me.tbrRating.Location = New System.Drawing.Point(357, 112)
        Me.tbrRating.Maximum = 5
        Me.tbrRating.Name = "tbrRating"
        Me.tbrRating.Size = New System.Drawing.Size(104, 45)
        Me.tbrRating.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRating)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbrRating)
        Me.GroupBox1.Controls.Add(Me.saveReviewButton)
        Me.GroupBox1.Controls.Add(Me.txtReview)
        Me.GroupBox1.Controls.Add(Me.cboCoffeeShops)
        Me.GroupBox1.Controls.Add(Me.cboUsers)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 228)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Review"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(467, 112)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(13, 13)
        Me.lblRating.TabIndex = 11
        Me.lblRating.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Review Text (optional)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Coffee Shop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Rating (required)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDisplayData)
        Me.GroupBox2.Controls.Add(Me.grdViewDatabase)
        Me.GroupBox2.Controls.Add(Me.cboTableNames)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 202)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View Database Data"
        '
        'btnDisplayData
        '
        Me.btnDisplayData.Location = New System.Drawing.Point(405, 22)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayData.TabIndex = 12
        Me.btnDisplayData.Text = "Display data"
        Me.btnDisplayData.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(451, 466)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAddNewCoffeeShop
        '
        Me.btnAddNewCoffeeShop.Location = New System.Drawing.Point(112, 466)
        Me.btnAddNewCoffeeShop.Name = "btnAddNewCoffeeShop"
        Me.btnAddNewCoffeeShop.Size = New System.Drawing.Size(124, 23)
        Me.btnAddNewCoffeeShop.TabIndex = 13
        Me.btnAddNewCoffeeShop.Text = "Add new coffee shop"
        Me.btnAddNewCoffeeShop.UseVisualStyleBackColor = True
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.Location = New System.Drawing.Point(12, 466)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.Size = New System.Drawing.Size(94, 23)
        Me.btnAddNewUser.TabIndex = 14
        Me.btnAddNewUser.Text = "Add new user"
        Me.btnAddNewUser.UseVisualStyleBackColor = True
        '
        'btnShowAllData
        '
        Me.btnShowAllData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowAllData.Location = New System.Drawing.Point(299, 466)
        Me.btnShowAllData.Name = "btnShowAllData"
        Me.btnShowAllData.Size = New System.Drawing.Size(106, 23)
        Me.btnShowAllData.TabIndex = 15
        Me.btnShowAllData.Text = "Show All Data"
        Me.btnShowAllData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 492)
        Me.Controls.Add(Me.btnShowAllData)
        Me.Controls.Add(Me.btnAddNewUser)
        Me.Controls.Add(Me.btnAddNewCoffeeShop)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Coffee Shop Reviews"
        CType(Me.grdViewDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdViewDatabase As System.Windows.Forms.DataGridView
    Friend WithEvents cboTableNames As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents saveReviewButton As System.Windows.Forms.Button
    Friend WithEvents cboCoffeeShops As System.Windows.Forms.ComboBox
    Friend WithEvents cboUsers As System.Windows.Forms.ComboBox
    Friend WithEvents txtReview As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbrRating As System.Windows.Forms.TrackBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnDisplayData As System.Windows.Forms.Button
    Friend WithEvents btnAddNewCoffeeShop As System.Windows.Forms.Button
    Friend WithEvents btnAddNewUser As System.Windows.Forms.Button
    Friend WithEvents btnShowAllData As System.Windows.Forms.Button

End Class
