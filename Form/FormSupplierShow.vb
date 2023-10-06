Public Class FormSupplierShow
    Dim cls As New ClassSupplier
    Private Sub FormSupplierShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_searchId.Focus()
        Show_DGV(DGV, "Select_Supplier")

    End Sub
End Class