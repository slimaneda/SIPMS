Public Class TempStock
    Private _Code_Product As Integer
    Private _Quantity_Pt As Double

    Property Code_Product As Integer
        Get
            Return _Code_Product
        End Get
        Set(value As Integer)
            _Code_Product = value
        End Set
    End Property
    Property Quantity_Pt As Double
        Get
            Return _Quantity_Pt
        End Get
        Set(value As Double)
            _Quantity_Pt = value
        End Set
    End Property

End Class
