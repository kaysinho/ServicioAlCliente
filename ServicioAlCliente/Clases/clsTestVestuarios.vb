Imports System.Data.SqlClient
Imports System.Data
Public Class clsTestVestuarios
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Function CargarTestVestuarios() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodoAlAzar")
            sqlComm.Parameters.AddWithValue("tesves_intId", 0)
            sqlComm.Parameters.AddWithValue("tesves_srtNombrePrenda", "")
            sqlComm.Parameters.AddWithValue("tesves_strNombrePrendaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitSexoPrenda", 0)
            sqlComm.Parameters.AddWithValue("tesves_strRutaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitEstado", 0)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Test")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function CargarParaGrid() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("tesves_intId", 0)
            sqlComm.Parameters.AddWithValue("tesves_srtNombrePrenda", "")
            sqlComm.Parameters.AddWithValue("tesves_strNombrePrendaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitSexoPrenda", 0)
            sqlComm.Parameters.AddWithValue("tesves_strRutaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitEstado", 0)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Test")
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
            sqlComm.CommandText = "spTestVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaUno")
            sqlComm.Parameters.AddWithValue("tesves_intId", Id)
            sqlComm.Parameters.AddWithValue("tesves_srtNombrePrenda", "")
            sqlComm.Parameters.AddWithValue("tesves_strNombrePrendaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitSexoPrenda", 0)
            sqlComm.Parameters.AddWithValue("tesves_strRutaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitEstado", 0)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Test")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
    Public Function MaxId() As Int32
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "Max")
            sqlComm.Parameters.AddWithValue("tesves_intId", "")
            sqlComm.Parameters.AddWithValue("tesves_srtNombrePrenda", "")
            sqlComm.Parameters.AddWithValue("tesves_strNombrePrendaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitSexoPrenda", 0)
            sqlComm.Parameters.AddWithValue("tesves_strRutaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitEstado", 0)
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
    Public Sub Guardar(Accion As String, Id As Integer, Pregunta As String, Ruta As String, Genero As Boolean, Estado As Boolean)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spTestVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("tesves_intId", Id)
            sqlComm.Parameters.AddWithValue("tesves_srtNombrePrenda", Pregunta)
            sqlComm.Parameters.AddWithValue("tesves_strNombrePrendaImagen", "")
            sqlComm.Parameters.AddWithValue("tesves_bitSexoPrenda", Genero)
            sqlComm.Parameters.AddWithValue("tesves_strRutaImagen", Ruta)
            sqlComm.Parameters.AddWithValue("tesves_bitEstado", Estado)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
End Class
