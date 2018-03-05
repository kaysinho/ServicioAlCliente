Imports System.Data.SqlClient
Public Class clsEvaluacionDesempeñoOpciones
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function ListarOpcionesAzar(IdPregunta As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeñoOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("evadesopc_intId", "")
            sqlComm.Parameters.AddWithValue("evadesopc_strTexto", "")
            sqlComm.Parameters.AddWithValue("evadesopc_fkIdEvaDes", IdPregunta)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Opciones")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function ListarOpciones(IdProtocolo As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeñoOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("evadesopc_intId", "")
            sqlComm.Parameters.AddWithValue("evadesopc_strTexto", "")
            sqlComm.Parameters.AddWithValue("evadesopc_fkIdEvaDes", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Opciones")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function SeleccionaUno(Id As Integer, IdPregunta As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeñoOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("evadesopc_intId", Id)
            sqlComm.Parameters.AddWithValue("evadesopc_strTexto", "")
            sqlComm.Parameters.AddWithValue("evadesopc_fkIdEvaDes", IdPregunta)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Opcion")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Sub Guardar(Accion As String, Id As Integer, Texto As String, IdPregunta As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeñoOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("evadesopc_intId", Id)
            sqlComm.Parameters.AddWithValue("evadesopc_strTexto", Texto)
            sqlComm.Parameters.AddWithValue("evadesopc_fkIdEvaDes", IdPregunta)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
    Sub EliminarTodos(IdPregunta As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeñoOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "EliminarTodos")
            sqlComm.Parameters.AddWithValue("evadesopc_intId", 0)
            sqlComm.Parameters.AddWithValue("evadesopc_strTexto", "")
            sqlComm.Parameters.AddWithValue("evadesopc_fkIdEvaDes", IdPregunta)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub

End Class
