Imports System.Data.SqlClient
Imports System.Data
Public Class clsTest
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Sub Guardar(NombreExamen As String, RutaArchivo As String, Estado As Boolean)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTest"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Guardar")
            sqlComm.Parameters.AddWithValue("tes_intId", 0)
            sqlComm.Parameters.AddWithValue("tes_strNombreExamen", NombreExamen)
            sqlComm.Parameters.AddWithValue("tes_strRutaPdf", RutaArchivo)
            sqlComm.Parameters.AddWithValue("tes_bitEstado", Estado)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function intId() As Int32
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTest"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "IdMax")
            sqlComm.Parameters.AddWithValue("tes_intId", 0)
            sqlComm.Parameters.AddWithValue("tes_strNombreExamen", "")
            sqlComm.Parameters.AddWithValue("tes_strRutaPdf", "")
            sqlComm.Parameters.AddWithValue("tes_bitEstado", True)
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
    Public Function GetExamenes(Accion As String) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTest"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("tes_intId", 0)
            sqlComm.Parameters.AddWithValue("tes_strNombreExamen", "")
            sqlComm.Parameters.AddWithValue("tes_strRutaPdf", "")
            sqlComm.Parameters.AddWithValue("tes_bitEstado", True)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Examenes")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetExamen(Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTest"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("tes_intId", Id)
            sqlComm.Parameters.AddWithValue("tes_strNombreExamen", "")
            sqlComm.Parameters.AddWithValue("tes_strRutaPdf", "")
            sqlComm.Parameters.AddWithValue("tes_bitEstado", True)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Examen")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Sub GuardarEdicion(NombreExamen As String, RutaArchivo As String, Id As Integer, Estado As Boolean)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTest"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Editar")
            sqlComm.Parameters.AddWithValue("tes_intId", Id)
            sqlComm.Parameters.AddWithValue("tes_strNombreExamen", NombreExamen)
            sqlComm.Parameters.AddWithValue("tes_strRutaPdf", RutaArchivo)
            sqlComm.Parameters.AddWithValue("tes_bitEstado", Estado)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
End Class
