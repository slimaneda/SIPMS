Public Class Customer
    Private _code As Integer
    Private _Name As String
    Private _Gender As String
    Private _Adress As String
    Private _City As String
    Private _Zip As String
    Private _state As String
    Private _Contact As String

    Private _Email As String
    Private _Notes As String
    Private _photo As Image
    Property code As Integer
        Get
            code = _code
        End Get
        Set(value As Integer)
            _code = value
        End Set
    End Property

    Property Name As String
        Get
            Name = _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Property Gender As String
        Get
            Gender = _Gender
        End Get
        Set(value As String)
            _Gender = value
        End Set
    End Property

    Property Adress As String
        Get
            Adress = _Adress
        End Get
        Set(value As String)
            _Adress = value
        End Set
    End Property

    Property City As String
        Get
            City = _City
        End Get
        Set(value As String)
            _City = value
        End Set
    End Property

    Property Zip As String
        Get
            Zip = _Zip
        End Get
        Set(value As String)
            _Zip = value
        End Set
    End Property
    Property State As String
        Get
            State = _state
        End Get
        Set(value As String)
            _state = value
        End Set
    End Property

    Property contact As String
        Get
            contact = _Contact
        End Get
        Set(value As String)
            _Contact = value
        End Set
    End Property

    Property Email As String
        Get
            Email = _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Property Notes As String
        Get
            Notes = _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

    Property photo As Image
        Get
            Return _photo
        End Get
        Set(value As Image)
            _photo = value
        End Set
    End Property




End Class
