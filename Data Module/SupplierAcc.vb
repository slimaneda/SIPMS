Public Class SupplierAcc
    Private _SuppId As Integer
    Private _SuppName As String
    Private _Detail As String
    Private _Inv As String
    Private _Debit As Decimal
    Private _Credit As Decimal


    Property SuppId As Integer
        Set(value As Integer)
            _SuppId = value
        End Set
        Get
            SuppId = _SuppId
        End Get
    End Property
    Property SuppName As String
        Set(value As String)
            _SuppName = value
        End Set
        Get
            SuppName = _SuppName
        End Get
    End Property
    Property Detail As String
        Set(value As String)
            _Detail = value
        End Set
        Get
            Detail = _Detail
        End Get
    End Property
    Property Inv As String
        Set(value As String)
            _Inv = value
        End Set
        Get
            Inv = _Inv
        End Get
    End Property
    Property Debit As Decimal
        Set(value As Decimal)
            _Debit = value
        End Set
        Get
            Debit = _Debit
        End Get
    End Property
    Property Credit As Decimal
        Set(value As Decimal)
            _Credit = value
        End Set
        Get
            Credit = _Credit
        End Get
    End Property


End Class
