Imports System.Data.SqlClient
Imports System.Data
Public Class clsColorVestuarios
    Private sqlCon As SqlConnection
    Dim objConexion As clsConexion = New clsConexion
    Public Sub Guardar(Accion As String, Prenda As String, Color As String, Sexo As Boolean, Color2 As String, Color3 As String, IdDiseño As Integer)
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spColorVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", Accion)
            sqlComm.Parameters.AddWithValue("colves_intId", 0)
            sqlComm.Parameters.AddWithValue("colves_strPrenda", Prenda)
            sqlComm.Parameters.AddWithValue("colves_strColor", Color)
            sqlComm.Parameters.AddWithValue("colves_bitSexo", Sexo)
            sqlComm.Parameters.AddWithValue("colves_strColor2", Color2)
            sqlComm.Parameters.AddWithValue("colves_strColor3", Color3)
            sqlComm.Parameters.AddWithValue("colves_fkIdDiseñoUniforme", IdDiseño)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
        End Using
        sqlCon.Close()
    End Sub
    Public Function GetColores() As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spColorVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionarTodo")
            sqlComm.Parameters.AddWithValue("colves_intId", 0)
            sqlComm.Parameters.AddWithValue("colves_strPrenda", "")
            sqlComm.Parameters.AddWithValue("colves_strColor", "")
            sqlComm.Parameters.AddWithValue("colves_bitSexo", "")
            sqlComm.Parameters.AddWithValue("colves_strColor2", "")
            sqlComm.Parameters.AddWithValue("colves_strColor3", "")
            sqlComm.Parameters.AddWithValue("colves_fkIdDiseñoUniforme", 0)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Colores")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function

    Public Function GetColoreDiseño(IdDiseño As Integer) As DataTable
        sqlCon = objConexion.Conexion()
        Using (sqlCon)
            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "spColorVestuarios"
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.AddWithValue("strTipoAccion", "SeleccionaColoresPorDiseño")
            sqlComm.Parameters.AddWithValue("colves_intId", 0)
            sqlComm.Parameters.AddWithValue("colves_strPrenda", "")
            sqlComm.Parameters.AddWithValue("colves_strColor", "")
            sqlComm.Parameters.AddWithValue("colves_bitSexo", "")
            sqlComm.Parameters.AddWithValue("colves_strColor2", "")
            sqlComm.Parameters.AddWithValue("colves_strColor3", "")
            sqlComm.Parameters.AddWithValue("colves_fkIdDiseñoUniforme", IdDiseño)
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()
            reader = sqlComm.ExecuteReader()
            Dim dt As DataTable = New DataTable("Colores")
            Using (reader)
                dt.Load(reader)
                Return dt
            End Using
        End Using
    End Function
End Class
