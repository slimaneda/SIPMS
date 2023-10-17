Public Class ClassStock


	Public Code_stockid As Integer
	Public code_facture As String
	Public Date_purchase As String
	Public Code_Sup As Integer
	Public Name_Sup As String

	Public Code_pt As Integer
	Public Name_pt As String
	Public Quantity_Pt As Double
	Public Price_Pt As Double
	Public TOTALamont As Double

	Public TOTALPayement As Double
	Public TOTALPayementdue As Double

	Public NOTES As String

	Sub save_Update(proc As String)
		Using cmd As New SqlClient.SqlCommand(proc, sqlcon)
			cmd.CommandType = CommandType.StoredProcedure


			cmd.Parameters.Add("Code_fct", SqlDbType.Int).Value = Code_stockid
			cmd.Parameters.Add("Code_facture", SqlDbType.NVarChar, 50).Value = code_facture
			cmd.Parameters.Add("Date_purchase", SqlDbType.NVarChar, 50).Value = Date_purchase
			cmd.Parameters.Add("Code_Sup", SqlDbType.Int).Value = Code_Sup
			cmd.Parameters.Add("Name_Sup", SqlDbType.NVarChar, 50).Value = Name_Sup


			cmd.Parameters.Add("Code_Pt", SqlDbType.Int).Value = Code_Pt
			cmd.Parameters.Add("Name_Pt", SqlDbType.NVarChar, 50).Value = Name_Pt
			cmd.Parameters.Add("Quantity_Pt", SqlDbType.Decimal, 18, 2).Value = Quantity_Pt
			cmd.Parameters.Add("Price_Pt", SqlDbType.Decimal, 18, 2).Value = Price_Pt
			cmd.Parameters.Add("Total", SqlDbType.Decimal, 18, 2).Value = TOTALamont


			cmd.Parameters.Add("Total_Payement", SqlDbType.Decimal, 18, 2).Value = TOTALPayement
			cmd.Parameters.Add("Rest_NonPayement", SqlDbType.Decimal, 18, 2).Value = TOTALPayementdue

			cmd.Parameters.Add("Notes", SqlDbType.NVarChar, 1000).Value = NOTES
			cmd.ExecuteNonQuery()

		End Using




	End Sub

	Sub deletdata(proc As String)
		Using cmd As New SqlClient.SqlCommand(proc, sqlcon)
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Parameters.Add("@code_fct", SqlDbType.Int).Value = Code_stockid
			cmd.ExecuteNonQuery()
		End Using
	End Sub
End Class
