Imports System.Data.SqlClient

Public Class clsProtocoloTelefonico
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function GetProtocolos() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spProtocoloTelefonico"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoGrid")
            sqlComm.Parameters.AddWithValue("protel_intId", 0)
            sqlComm.Parameters.AddWithValue("protel_strNombre", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Diseños")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetProtocolo(Id As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spProtocoloTelefonico"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("protel_intId", Id)
            sqlComm.Parameters.AddWithValue("protel_strNombre", "")
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Diseño")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Sub Guardar(Accion As String, Diseño As String, Id As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spProtocoloTelefonico"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("protel_intId", Id)
            sqlComm.Parameters.AddWithValue("protel_strNombre", Diseño)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function MaxId() As Int32
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spProtocoloTelefonico"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "MaxId")
            sqlComm.Parameters.AddWithValue("protel_intId", 0)
            sqlComm.Parameters.AddWithValue("protel_strNombre", "")
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
