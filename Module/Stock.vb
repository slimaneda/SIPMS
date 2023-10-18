Public Class Stock
    Private _code As Integer

    Property Code As Integer
        Get
            Return _code
        End Get
        Set(ByVal value As Integer)
            _code = value
        End Set
    End Property
End Class
