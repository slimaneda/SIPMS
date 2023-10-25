Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Public Class UserDal

    Public Function insert(user As User) As Integer
        Const proc As String = "insertuser"  ' Name of the stored procedure
        Dim args As New Dictionary(Of String, Object) From
        {
            {"@Username", user.Username},
            {"@Password", user.Password},
            {"@d1", user.d1},
            {"@d2", user.d2},
            {"@d3", user.d3},
            {"@d4", user.d4},
            {"@d5", user.d5},
            {"@d6", user.d6},
            {"@d7", user.d7},
            {"@d8", user.d8},
            {"@d9", user.d9},
            {"@d10", user.d10},
            {"@d11", user.d11},
            {"@d12", user.d12},
            {"@d13", user.d13},
            {"@d14", user.d14},
            {"@d15", user.d15}
        }
        Return SqlConnectionManager.ExecuteWrite(proc, args)
    End Function



    Public Function Delete(user As User) As Integer
        Return SqlConnectionManager.ExecuteWrite("DeleteUser", New Dictionary(Of String, Object) From {{"@Username", user.Username}})
    End Function

    Public Function getser(user As User) As DataRow
        Const proc As String = "SELECT * FROM [dbo].[User] WHERE [Username] = @Username AND [Password] = @Password"
        Dim args As New Dictionary(Of String, Object) From
            {
             {"@Username", user.Username},
            {"@Password", user.Password}
        }

        Return SqlConnectionManager.GetUserByUsername(proc, args)
    End Function
    Public Function Verify(user As User) As String
        Const proc As String = "Selectlogin"
        Dim args As New Dictionary(Of String, Object) From
            {
             {"@Username", user.Username},
            {"@Password", user.Password}
        }

        Return SqlConnectionManager.DataExists(proc, args)
    End Function


End Class
