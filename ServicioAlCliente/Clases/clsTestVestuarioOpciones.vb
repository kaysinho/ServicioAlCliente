Imports System.Data.SqlClient
Public Class clsTestVestuarioOpciones
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion

    Public Function CargarOpcionesPorTest(IdTest As Int32) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuariosOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoAlAzar")
            sqlComm.Parameters.AddWithValue("tesvesopc_intId", 0)
            sqlComm.Parameters.AddWithValue("tesvesopc_fkIdTestVestuario", IdTest)
            sqlComm.Parameters.AddWithValue("tesvesopc_strRespuesta", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("TestOpciones")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Sub Guardar(Accion As String, Id As Integer, IdPrenda As Integer, Pregunta As String)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuariosOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("tesvesopc_intId", Id)
            sqlComm.Parameters.AddWithValue("tesvesopc_fkIdTestVestuario", IdPrenda)
            sqlComm.Parameters.AddWithValue("tesvesopc_strRespuesta", Pregunta)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
End Class
