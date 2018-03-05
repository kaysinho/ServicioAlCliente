Imports System.Data.SqlClient
Imports System.Data
Public Class clsSopaDeLetras
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function GetPalabras() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spSopaDeLetras"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("soplet_intId", "")
            sqlComm.Parameters.AddWithValue("soplet_strPalabra", "")
            sqlComm.Parameters.AddWithValue("soplet_strTipo", "")
            sqlComm.Parameters.AddWithValue("soplet_strImagen", "")
            sqlComm.Parameters.AddWithValue("soplet_strPalabraIngles", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Palabras")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetAcion(Accion As String) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spSopaDeLetras"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("soplet_intId", "")
            sqlComm.Parameters.AddWithValue("soplet_strPalabra", "")
            sqlComm.Parameters.AddWithValue("soplet_strTipo", "")
            sqlComm.Parameters.AddWithValue("soplet_strImagen", "")
            sqlComm.Parameters.AddWithValue("soplet_strPalabraIngles", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Palabras")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetPalabra(Accion As String, Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spSopaDeLetras"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("soplet_intId", Id)
            sqlComm.Parameters.AddWithValue("soplet_strPalabra", "")
            sqlComm.Parameters.AddWithValue("soplet_strTipo", "")
            sqlComm.Parameters.AddWithValue("soplet_strImagen", "")
            sqlComm.Parameters.AddWithValue("soplet_strPalabraIngles", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Palabras")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function

    Sub Guardar(Accion As String, Id As Integer, Palabra As String, PalabraIn As String, Tipo As String, Ruta As String)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spSopaDeLetras"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("soplet_intId", Id)
            sqlComm.Parameters.AddWithValue("soplet_strPalabra", Palabra)
            sqlComm.Parameters.AddWithValue("soplet_strTipo", Tipo)
            sqlComm.Parameters.AddWithValue("soplet_strImagen", Ruta)
            sqlComm.Parameters.AddWithValue("soplet_strPalabraIngles", PalabraIn)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
End Class
