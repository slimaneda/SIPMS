Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Définissez le titre du formulaire.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("À propos de {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = " Copyright 2023 "
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Dim disc As String = "SIPMS (Sales Inventory and Purchase Management System) is a software solution integrated with SQL Server databases. It automates sales, inventory, and purchasing processes, leveraging SQL Server's capabilities for efficient data management, enhancing operational efficiency and informed decision-making."

        Me.TextBoxDescription.Text = " Description : " & Environment.NewLine & disc



    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub


End Class
