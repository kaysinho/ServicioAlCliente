Imports System.Data.SqlClient
Imports System.Data
Public Class clsTiposCRM
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function GetTipos() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTiposCRM"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("tipcrm_intId", "")
            sqlComm.Parameters.AddWithValue("tipcrm_strDescripcion", "")
            sqlComm.Parameters.AddWithValue("tipcrm_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Tipos")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetTiposGrid() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTiposCRM"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("tipcrm_intId", "")
            sqlComm.Parameters.AddWithValue("tipcrm_strDescripcion", "")
            sqlComm.Parameters.AddWithValue("tipcrm_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Tipos")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetTipo(Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTiposCRM"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("tipcrm_intId", Id)
            sqlComm.Parameters.AddWithValue("tipcrm_strDescripcion", "")
            sqlComm.Parameters.AddWithValue("tipcrm_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Tipos")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Sub Guardar(Accion As String, Id As Integer, Texto As String, Tipo As String)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTiposCRM"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("tipcrm_intId", Id)
            sqlComm.Parameters.AddWithValue("tipcrm_strDescripcion", Texto)
            sqlComm.Parameters.AddWithValue("tipcrm_strTipo", Tipo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
End Class
