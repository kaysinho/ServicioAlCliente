
Imports System.Data.SqlClient
Public Class clsEvaluacionDesempeño
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function Listar() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeño"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("evades_intId", 0)
            sqlComm.Parameters.AddWithValue("evades_strPregunta", "")
            sqlComm.Parameters.AddWithValue("evades_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Evaluaciones")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function SeleccionaUno(Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeño"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("evades_intId", Id)
            sqlComm.Parameters.AddWithValue("evades_strPregunta", "")
            sqlComm.Parameters.AddWithValue("evades_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Evaluacion")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Sub Guardar(Accion As String, Pregunta As String, Tipo As String, Id As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeño"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("evades_intId", Id)
            sqlComm.Parameters.AddWithValue("evades_strPregunta", Pregunta)
            sqlComm.Parameters.AddWithValue("evades_strTipo", Tipo)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function NuevoId() As Int32
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spEvaluacionDesempeño"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "MaxId")
            sqlComm.Parameters.AddWithValue("evades_intId", 0)
            sqlComm.Parameters.AddWithValue("evades_strPregunta", "")
            sqlComm.Parameters.AddWithValue("evades_strTipo", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("IntId")
            Using (reader)
                dt.Load(reader)
                Return dt(0)(0)
            End Using
        End Using
    End Function
End Class
