Imports System.Data.SqlClient
Imports System.Data
Public Class clsLibretaCalificaciones
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function GetPreguntas() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spLibretaDirecciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("libdir_intId", "")
            sqlComm.Parameters.AddWithValue("libdir_strOpcion", "")
            sqlComm.Parameters.AddWithValue("libdir_bitCorrecta", "")
            sqlComm.Parameters.AddWithValue("libdir_strOptionEnglish", "")
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
    Public Function GetPreguntasGrid(Accion As String) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spLibretaDirecciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("libdir_intId", "")
            sqlComm.Parameters.AddWithValue("libdir_strOpcion", "")
            sqlComm.Parameters.AddWithValue("libdir_bitCorrecta", "")
            sqlComm.Parameters.AddWithValue("libdir_strOptionEnglish", "")
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
    Public Function GetPregunta(Accion As String, Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spLibretaDirecciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("libdir_intId", Id)
            sqlComm.Parameters.AddWithValue("libdir_strOpcion", "")
            sqlComm.Parameters.AddWithValue("libdir_bitCorrecta", "")
            sqlComm.Parameters.AddWithValue("libdir_strOptionEnglish", "")
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
    Sub Guardar(Accion As String, Id As Integer, Opcion As String, OpcionIn As String, Correcta As Boolean)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spLibretaDirecciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("libdir_intId", Id)
            sqlComm.Parameters.AddWithValue("libdir_strOpcion", Opcion)
            sqlComm.Parameters.AddWithValue("libdir_bitCorrecta", Correcta)
            sqlComm.Parameters.AddWithValue("libdir_strOptionEnglish", OpcionIn)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
    End Sub
End Class
