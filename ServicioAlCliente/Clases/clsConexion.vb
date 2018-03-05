Imports System.Data.SqlClient
Public Class clsConexion
    Public Function Conexion() As SqlConnection
        Dim strConn As String = "Data Source=DESKTOP-E0E7LDH\SQLEXPRESS;Initial Catalog=BD_SAGA;Integrated Security=True"
        Dim sqlCon As SqlConnection
        sqlCon = New SqlConnection(strConn)
        Return sqlCon
    End Function
End Class
