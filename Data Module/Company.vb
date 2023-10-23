Public Class Company
    Private _Name_company As String
    Private _Adress As String
    Private _Contact As String
    Private _Email As String
    Private _TIN As String
    Private _ST As String
    Private _CIN As String
    Private _photo As Byte()

    Property Name_Company As String
        Set(value As String)
            _Name_company = value
        End Set
        Get
            Return _Name_company
        End Get
    End Property

    Property adress As String
        Set(value As String)
            _Adress = value
        End Set
        Get
            Return _Adress
        End Get
    End Property

    Property Contact As String
        Set(value As String)
            _Contact = value
        End Set
        Get
            Return _Contact
        End Get
    End Property
    Property EMail As String
        Set(value As String)
            _Email = value
        End Set
        Get
            Return _Email
        End Get
    End Property
    Property TIN As String
        Set(value As String)
            _TIN = value
        End Set
        Get
            Return _TIN
        End Get
    End Property

    Property ST As String
        Set(value As String)
            _ST = value
        End Set
        Get
            Return _ST
        End Get
    End Property
    Property CIN As String
        Set(value As String)
            _CIN = value
        End Set
        Get
            Return _CIN
        End Get
    End Property

    Property photo As Byte()
        Get
            Return _photo
        End Get
        Set(value As Byte())
            _photo = value
        End Set
    End Property

End Class
