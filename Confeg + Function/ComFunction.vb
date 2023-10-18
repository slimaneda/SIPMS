Imports System.Data.SqlClient

Module ComFunction
    '                         function ALLOW  only Numbre  IN TEXTBOX 
    Public Sub AllowOnlyNumbre(e As KeyPressEventArgs)
        If (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "."c) Then
            e.Handled = True
        End If
    End Sub


    '                           Numbere Auto index
    Public Function CODE_GEN(TbL_name, ID_) As Integer
        CODE_GEN = 0


        Try
            Using dt As New DataTable
                dt.Clear()
                Dim da As New SqlDataAdapter("SELECT * FROM " & TbL_name & " ORDER BY " & ID_, sqlcon)
                da.Fill(dt)
                If dt.Rows.Count <> 0 Then
                    Dim I = dt.Rows.Count - 1
                    CODE_GEN = Val(dt.Rows(I).Item(ID_))
                End If
            End Using
        Catch ex As Exception

        End Try


    End Function

    '                            Appearance Data in datagridview 
    Public Sub Show_DGV(DGV As DataGridView, num_Proc As String)
        sqlcon_Open()

        DGV.Text = ""
        Try
            Using dt As New DataTable
                dt.Clear()
                Dim da As New SqlDataAdapter(num_Proc, sqlcon)
                da.Fill(dt)
                DGV.DataSource = dt.DefaultView
            End Using

        Catch ex As Exception
        End Try
        sqlcon_Close()
    End Sub

    '                              Appearance Data in Combobox 
    Public Sub Show_COMBO(Proc As String, Combo As ComboBox, item As String)
        sqlcon_Open()
        Using cmd As New SqlCommand(Proc, sqlcon)
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Combo.Items.Add(dr(item).ToString())

            End While
        End Using
        sqlcon_Close()

    End Sub
    '                               clear textbox
    Public Sub ClearTextboxes(control As Control)
        For Each clt As Control In control.Controls

            If TypeOf clt Is TextBox Then
                CType(clt, TextBox).Text = String.Empty
            ElseIf clt.HasChildren Then
                ClearTextboxes(clt)
            End If
        Next
    End Sub
End Module
