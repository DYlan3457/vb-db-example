'TODO put these in separate classes.

'Contains a User, CoffeeShop and Review structure.

Public Structure User
    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Username + "(" + Email + ")"
    End Function

End Structure


Public Structure CoffeeShop

    Private _address As String
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set

    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Name + ", " + Address
    End Function

End Structure


Public Structure Review

    Private _rating As Integer
    Public Property Rating() As Integer
        Get
            Return _rating
        End Get
        Set(ByVal value As Integer)
            _rating = value
        End Set
    End Property


    Private _reviewText As String
    Public Property ReviewText() As String
        Get
            Return _reviewText
        End Get
        Set(ByVal value As String)
            _reviewText = value
        End Set
    End Property

    Private _userID As Integer
    Public Property UserID() As Integer
        Get
            Return _userID
        End Get
        Set(ByVal value As Integer)
            _userID = value
        End Set
    End Property

    Private _user As User
    Public Property TheUser() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            _user = value
        End Set
    End Property

    Private _userName As String
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property


    Private _coffeeShopID As Integer
    Public Property ShopID() As Integer
        Get
            Return _coffeeShopID
        End Get
        Set(ByVal value As Integer)
            _coffeeShopID = value
        End Set
    End Property

    Private _coffeeShop As CoffeeShop
    Public Property TheCoffeeShop() As CoffeeShop
        Get
            Return _coffeeShop
        End Get
        Set(ByVal value As CoffeeShop)
            _coffeeShop = value
        End Set
    End Property

    Private _date As Date
    Public Property ReviewDate() As Date
        Get
            Return _date
        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property

    'Used for the display in the GUI
    Public Overrides Function ToString() As String
        Return String.Format("{0} stars - {1} - {2} - {3} ", Rating, ReviewText, UserName, ReviewDate.ToShortDateString)
    End Function

End Structure