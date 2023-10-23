Public Class Product
    Private _code As Integer
    Private _name As String
    Private _Notes As String
    Private _items As String
    Private _minirecord As Decimal
    Private _Qunatity As Decimal

    Property Code As Integer
        Get
            Return _code
        End Get
        Set(ByVal value As Integer)
            _code = value
        End Set
    End Property
    Property Name As String
        Get
            Name = _name
        End Get
        Set(value As String)
            _name = value
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
    Property items As String
        Get
            items = _items
        End Get
        Set(value As String)
            _items = value
        End Set
    End Property
    Property minirecord As Decimal
        Get
            minirecord = _minirecord
        End Get
        Set(value As Decimal)
            _minirecord = value
        End Set
    End Property
    Property Quantity As Decimal
        Get
            Quantity = _Qunatity
        End Get
        Set(value As Decimal)
            _Qunatity = value
        End Set
    End Property
End Class
