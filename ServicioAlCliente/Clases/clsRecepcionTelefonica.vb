Imports System.Data.SqlClient
Imports System.Data
Public Class clsRecepcionTelefonica
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function GetConversacion(IdProtocolo As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spRecepcionTelefonica"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("rectel_intId", "")
            sqlComm.Parameters.AddWithValue("rectel_strTexto", "")
            sqlComm.Parameters.AddWithValue("rectel_intOrden", "")
            sqlComm.Parameters.AddWithValue("rectel_bitEmpleado", "")
            sqlComm.Parameters.AddWithValue("rectel_strTextoIngles", "")
            sqlComm.Parameters.AddWithValue("rectel_fkIdProtocolo", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Preguntas")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetRecepcionGrid(IdProtocolo As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spRecepcionTelefonica"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("rectel_intId", "")
            sqlComm.Parameters.AddWithValue("rectel_strTexto", "")
            sqlComm.Parameters.AddWithValue("rectel_intOrden", "")
            sqlComm.Parameters.AddWithValue("rectel_bitEmpleado", "")
            sqlComm.Parameters.AddWithValue("rectel_strTextoIngles", "")
            sqlComm.Parameters.AddWithValue("rectel_fkIdProtocolo", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Preguntas")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetRecepcionSeleccion(Id As Integer, IdProtocolo As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spRecepcionTelefonica"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("rectel_intId", Id)
            sqlComm.Parameters.AddWithValue("rectel_strTexto", "")
            sqlComm.Parameters.AddWithValue("rectel_intOrden", "")
            sqlComm.Parameters.AddWithValue("rectel_bitEmpleado", "")
            sqlComm.Parameters.AddWithValue("rectel_strTextoIngles", "")
            sqlComm.Parameters.AddWithValue("rectel_fkIdProtocolo", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Preguntas")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Sub GuardarRec(Accion As String, Id As Integer, Texto As String, TextoIn As String, Orden As Integer, IdProtocolo As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spRecepcionTelefonica"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("rectel_intId", Id)
            sqlComm.Parameters.AddWithValue("rectel_strTexto", Texto)
            sqlComm.Parameters.AddWithValue("rectel_intOrden", Orden)
            sqlComm.Parameters.AddWithValue("rectel_bitEmpleado", 1)
            sqlComm.Parameters.AddWithValue("rectel_strTextoIngles", TextoIn)
            sqlComm.Parameters.AddWithValue("rectel_fkIdProtocolo", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
    Sub EliminarRec(IdProtocolo As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spRecepcionTelefonica"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Eliminar")
            sqlComm.Parameters.AddWithValue("rectel_intId", 0)
            sqlComm.Parameters.AddWithValue("rectel_strTexto", "")
            sqlComm.Parameters.AddWithValue("rectel_intOrden", 0)
            sqlComm.Parameters.AddWithValue("rectel_bitEmpleado", 1)
            sqlComm.Parameters.AddWithValue("rectel_strTextoIngles", "")
            sqlComm.Parameters.AddWithValue("rectel_fkIdProtocolo", IdProtocolo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
    Public Function GetCadena() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spCadenaSuministros"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("cadsum_intId", "")
            sqlComm.Parameters.AddWithValue("cadsum_strTexto", "")
            sqlComm.Parameters.AddWithValue("cadsum_intOrden", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Cadena")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetCadenaGrid() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spCadenaSuministros"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("cadsum_intId", "")
            sqlComm.Parameters.AddWithValue("cadsum_strTexto", "")
            sqlComm.Parameters.AddWithValue("cadsum_intOrden", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Preguntas")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetCadenaSeleccion(Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spCadenaSuministros"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("cadsum_intId", Id)
            sqlComm.Parameters.AddWithValue("cadsum_strTexto", "")
            sqlComm.Parameters.AddWithValue("cadsum_intOrden", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Preguntas")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Sub GuardarCad(Accion As String, Id As Integer, Texto As String, Orden As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spCadenaSuministros"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("cadsum_intId", Id)
            sqlComm.Parameters.AddWithValue("cadsum_strTexto", Texto)
            sqlComm.Parameters.AddWithValue("cadsum_intOrden", Orden)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
End Class
