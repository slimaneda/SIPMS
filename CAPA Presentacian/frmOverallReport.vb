Public Class frmOverallReport
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        FormGetData.lbl.Text = "Receipt"
        FormGetData.ShowDialog()
    End Sub
End Class