Imports System.Data.SqlClient
Imports System.Data
Public Class clsTestVestuariosRespuestas
    Private sqlCon, sqlCon2 As SqlConnection
    Dim objConexion As clsConexion = New clsConexion

    Public Sub Guardar(dtRespuestas As DataTable)
        sqlCon = objConexion.Conexion()
        sqlCon2 = objConexion.Conexion()

        'Guardamos el Test
        Using (sqlCon)
            Dim RowResp As DataRow = dtRespuestas.Rows(0)
            Dim IdEstudiante As String = RowResp.Item("IdEstudiante")

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "spTestVestuariosRespuesta"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("strTipoAccion", "Guardar")
            sqlComm.Parameters.AddWithValue("tesvesres_intId", 0)
            sqlComm.Parameters.AddWithValue("tesvesres_strIdEstudiante", IdEstudiante)
            sqlComm.Parameters.AddWithValue("tesvesres_dtmFecha", DateTime.Now.ToString())
            sqlCon.Open()
            sqlComm.ExecuteNonQuery()

            Using (sqlCon2)
                For Each r As DataRow In dtRespuestas.Rows
                    Dim IdPregunta As String = r.Item("IdPregunta")
                    Dim IdRespuesta As String = r.Item("IdRespuesta")
                    Dim sqlComm2 As New SqlCommand
                    sqlComm2.Connection = sqlCon2
                    sqlComm2.CommandText = "spTestVestuariosRespuestaOpciones"
                    sqlComm2.CommandType = CommandType.StoredProcedure
                    sqlComm2.Parameters.AddWithValue("strTipoAccion", "Guardar")
                    sqlComm2.Parameters.AddWithValue("tesvesresopc_intId", 0)
                    sqlComm2.Parameters.AddWithValue("tesvesresopc_intIdTest", intId())
                    sqlComm2.Parameters.AddWithValue("tesvesresopc_intIdPregunta", IdPregunta)
                    sqlComm2.Parameters.AddWithValue("tesvesresopc_intIdRespuesta", IdRespuesta)
                    If sqlCon2.State = ConnectionState.Closed Then
                        sqlCon2.Open()
                    End If
                    sqlComm2.ExecuteNonQuery()
                Next
            End Using

        End Using

        sqlCon.Close()
        sqlCon2.Close()

    End Sub

    Public Function intId() As Int32
        sqlCon = objConexion.Conexion()

        Using (sqlCon)

            Dim sqlComm As New SqlCommand
            Dim reader As SqlDataReader

            sqlComm.Connection = sqlCon


            sqlComm.CommandText = "spTestVestuariosRespuesta"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("strTipoAccion", "MaxId")
            sqlComm.Parameters.AddWithValue("tesvesres_intId", 0)
            sqlComm.Parameters.AddWithValue("tesvesres_strIdEstudiante", "")
            sqlComm.Parameters.AddWithValue("tesvesres_dtmFecha", "")

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
