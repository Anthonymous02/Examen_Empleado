Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection
    Public Sub Conectar()
        Try
            con.ConnectionString = "Data Source=STARK;Initial Catalog=practica001;Integrated Security=True"
            con.Open()
            MessageBox.Show(con.State.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Module
