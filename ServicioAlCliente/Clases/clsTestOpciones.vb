Imports System.Data.SqlClient
Imports System.Data

Public Class clsTestOpciones
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Sub Guardar(Pregunta As String, Verdadero As Boolean, IdExamen As Int32)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Guardar")
            sqlComm.Parameters.AddWithValue("tesopc_intId", 0)
            sqlComm.Parameters.AddWithValue("tesopc_strPregunta", Pregunta)
            sqlComm.Parameters.AddWithValue("tesopc_bitVerdadero", Verdadero)
            sqlComm.Parameters.AddWithValue("tesopc_fkIdTest", IdExamen)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function GetOpciones(IdTest As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaPorTest")
            sqlComm.Parameters.AddWithValue("tesopc_intId", 0)
            sqlComm.Parameters.AddWithValue("tesopc_strPregunta", "")
            sqlComm.Parameters.AddWithValue("tesopc_bitVerdadero", "")
            sqlComm.Parameters.AddWithValue("tesopc_fkIdTest", IdTest)
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
    Public Sub DeleteOpciones(IdTest As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestOpciones"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "EliminarOpciones")
            sqlComm.Parameters.AddWithValue("tesopc_intId", 0)
            sqlComm.Parameters.AddWithValue("tesopc_strPregunta", "")
            sqlComm.Parameters.AddWithValue("tesopc_bitVerdadero", "")
            sqlComm.Parameters.AddWithValue("tesopc_fkIdTest", IdTest)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub


End Class
