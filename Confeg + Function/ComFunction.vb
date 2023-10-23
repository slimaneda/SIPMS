Imports System.Data.SqlClient

Class ComFunction
    Inherits Conexion
    '                         function ALLOW  only Numbre  IN TEXTBOX 
    Public Sub AllowOnlyNumbre(e As KeyPressEventArgs)
        If (Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "."c) Then
            e.Handled = True
        End If
    End Sub





    '                           Numbere Auto index
    Public Function CODE_GEN(TbL_name, ID_) As Integer
        CODE_GEN = 0
        Conexion.conecta()

        Try
            Using dt As New DataTable
                dt.Clear()
                Dim da As New SqlDataAdapter("SELECT * FROM " & TbL_name & " ORDER BY " & ID_, Conexion.con)
                da.Fill(dt)
                If dt.Rows.Count <> 0 Then
                    Dim I = dt.Rows.Count - 1
                    CODE_GEN = Val(dt.Rows(I).Item(ID_))
                End If
            End Using
        Catch ex As Exception

        End Try
        Conexion.desconectar()

    End Function

    '                            Appearance Data in datagridview 
    Public Sub Show_DGV(datagridview As DataGridView, num_Proc As String)
        Conexion.conecta()

        datagridview.Text = ""
        Try
            Using dt As New DataTable
                dt.Clear()
                Dim da As New SqlDataAdapter(num_Proc, con)
                da.Fill(dt)
                datagridview.EndEdit()
                datagridview.ClearSelection()
                datagridview.DataSource = dt.DefaultView
            End Using

        Catch ex As Exception
        End Try
        Conexion.desconectar()
    End Sub

    '                              Appearance Data in Combobox 
    Public Sub Show_COMBO(Proc As String, Combo As ComboBox, item As String)
        Conexion.conecta()
        Using cmd As New SqlCommand(Proc, Conexion.con)
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Combo.Items.Add(dr(item).ToString())

            End While
        End Using
        Conexion.desconectar()

    End Sub
    '                               
    Public Sub ClearTextboxes(control As Control)           ' Clears all TextBox controls on the form
        For Each clt As Control In control.Controls

            If TypeOf clt Is TextBox Then
                CType(clt, TextBox).Text = String.Empty
            ElseIf clt.HasChildren Then
                ClearTextboxes(clt)
            End If
        Next
    End Sub

    Public Sub ReadOnlyTxtBox(control As Control, result As Boolean) ' Sets all TextBox controls on the form to read-only
        For Each clt As Control In control.Controls

            If TypeOf clt Is TextBox Then
                CType(clt, TextBox).ReadOnly = result

            End If
        Next
    End Sub
End Class
