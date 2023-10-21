Public Class StockProduct
    Private _StockID As Integer
    Private _ProductID As String
    Private _ProductName As String

    Private _Qty As Decimal
    Private _Price As Decimal
    Private _TotalAmount As Decimal



    Property StockID As Integer
        Set(value As Integer)
            _StockID = value
        End Set
        Get
            StockID = _StockID
        End Get
    End Property

    Property ProductID As String
        Set(value As String)
            _ProductID = value
        End Set
        Get
            ProductID = _ProductID
        End Get
    End Property

    Property ProductName As String
        Set(value As String)
            _ProductName = value
        End Set
        Get
            ProductName = _ProductName
        End Get
    End Property
    Property Qty As Decimal
        Set(value As Decimal)
            _Qty = value
        End Set
        Get
            Qty = _Qty
        End Get
    End Property
    Property Price As Decimal
        Set(value As Decimal)
            _Price = value
        End Set
        Get
            Price = _Price
        End Get
    End Property
    Property TotalAmount As Decimal
        Set(value As Decimal)
            _TotalAmount = value
        End Set
        Get
            TotalAmount = _TotalAmount
        End Get
    End Property


End Class
