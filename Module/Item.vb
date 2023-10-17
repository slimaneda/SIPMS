Imports System.Security.Cryptography

Public Class Item
    Private _Code_item As Integer
    Private _Name_item As String
    Private _photo As Byte()


    Property Code_item As Integer
        Get
            Return _Code_item
        End Get
        Set(ByVal value As Integer)
            _Code_item = value
        End Set
    End Property

    Property Name_item As String
        Get
            Return _Name_item

        End Get
        Set(value As String)
            _Name_item = value
        End Set
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
