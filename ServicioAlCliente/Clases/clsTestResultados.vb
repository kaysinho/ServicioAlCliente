Imports System.Data.SqlClient
Imports System.Data
Public Class clsTestResultados
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Sub Guardar(TipoTest As String, Resultado As Double, IdUsuario As String)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestResultados"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Guardar")
            sqlComm.Parameters.AddWithValue("restes_intId", 0)
            sqlComm.Parameters.AddWithValue("restes_strTipoTest", TipoTest)
            sqlComm.Parameters.AddWithValue("restes_fltResultado", Resultado)
            sqlComm.Parameters.AddWithValue("restes_strIdUsuario", IdUsuario)
            sqlComm.Parameters.AddWithValue("restes_dtmFechaTest", DateTime.Now)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function GetResultadosUsuario(IdUsuario As String) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestResultados"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoUsuario")
            sqlComm.Parameters.AddWithValue("restes_intId", 0)
            sqlComm.Parameters.AddWithValue("restes_strTipoTest", "")
            sqlComm.Parameters.AddWithValue("restes_fltResultado", "")
            sqlComm.Parameters.AddWithValue("restes_strIdUsuario", IdUsuario)
            sqlComm.Parameters.AddWithValue("restes_dtmFechaTest", DateTime.Now)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Resultados")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetResultadosUsuarioModulo(IdUsuario As String, TipoTest As String) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestResultados"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoUsuarioTipoTest")
            sqlComm.Parameters.AddWithValue("restes_intId", 0)
            sqlComm.Parameters.AddWithValue("restes_strTipoTest", TipoTest)
            sqlComm.Parameters.AddWithValue("restes_fltResultado", "")
            sqlComm.Parameters.AddWithValue("restes_strIdUsuario", IdUsuario)
            sqlComm.Parameters.AddWithValue("restes_dtmFechaTest", DateTime.Now)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Resultados")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
End Class
