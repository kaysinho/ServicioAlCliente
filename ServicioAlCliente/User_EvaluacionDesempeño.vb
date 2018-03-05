Public Class User_EvaluacionDesempeño

    Dim ObjEvaluacionDesempeño As New clsEvaluacionDesempeño
    Dim ObjEvaluacionDesempeñoOpciones As New clsEvaluacionDesempeñoOpciones
    Dim dtEvaluacionDesempeño As New DataTable
    Dim dtEvaluacionDesempeñoOpciones As New DataTable
    Dim FiltroEvaluacion = "Gerencial"
    Private Sub frmSopaDeLetras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1366, 768)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImage = Image.FromFile("Imagenes\Formulario\Monitor_fondo1.png")
        grbPrincipal.Size = New Size(1038, 571)
        grbPrincipal.Top = (Me.Height / 2) - (grbPrincipal.Height / 2)
        grbPrincipal.Left = (Me.Width / 2) - (grbPrincipal.Width / 1.93)
        CargarPreguntas()
        lblTituloForm.Text = "Evaluacion de Desempeño: " + FiltroEvaluacion
        txtFecha.Text = DateTime.Now.ToString("dddd dd, MMMM yyyy")
    End Sub
    Sub CargarPreguntas()
        dtEvaluacionDesempeño = ObjEvaluacionDesempeño.Listar()
        For Each row As DataRow In dtEvaluacionDesempeño.Rows
            If row(2) = FiltroEvaluacion Then
                Dim Pregunta As String = row(1).ToString()
                AgregarPregunta("Titulo", Pregunta)
                Dim Id As Integer = row(0).ToString()
                dtEvaluacionDesempeñoOpciones = ObjEvaluacionDesempeñoOpciones.ListarOpciones(Id)
                For Each rowOpc As DataRow In dtEvaluacionDesempeñoOpciones.Rows
                    Dim Opcion As String = rowOpc(1).ToString()
                    AgregarPregunta("", Opcion)
                Next
            End If
        Next
    End Sub
    Dim contY As Integer = 0
    Sub AgregarPregunta(Tipo, Texto)
        Dim lblPregunta As New Label
        If Tipo = "Titulo" Then
            If contY = 0 Then
                contY += 1
            Else
                contY += 3
            End If
        Else
            contY += 1
        End If

        PanelColaborativo.Controls.Add(lblPregunta)
        With lblPregunta
            .Text = Texto
            .MaximumSize = New Size(2220, 24)
            .Location = New Point((300), (24 * contY))
            .AutoSize = True
        End With
        If Tipo = "Titulo" Then
            lblPregunta.Font = New Font("Arial Unicode MS", 14, FontStyle.Regular)
        Else
            lblPregunta.Font = New Font("Arial Unicode MS", 11, FontStyle.Regular)
            Dim cmbRespuesta As New ComboBox
            cmbRespuesta.Items.Add("1")
            cmbRespuesta.Items.Add("2")
            cmbRespuesta.Items.Add("3")
            cmbRespuesta.Items.Add("4")
            cmbRespuesta.Items.Add("5")
            cmbRespuesta.DropDownStyle = ComboBoxStyle.DropDownList
            PanelColaborativo.Controls.Add(cmbRespuesta)
            cmbRespuesta.Location = New Point((600), (24 * contY))
        End If

    End Sub
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim Resultado As Integer = SumarPuntos()
        If Resultado > 0 Then
            MessageBox.Show("Resultado: " + Resultado.ToString + vbCrLf + ResultadoTabla(Resultado))
        End If
    End Sub

    Function SumarPuntos() As Integer
        Dim Suma As Int32 = 0
        For Each Combo As Control In PanelColaborativo.Controls.OfType(Of ComboBox)
            If Combo.Text = "" Then
                MessageBox.Show("Debe asignar un valor de 1 a 5 para todos los items")
                Combo.Focus()
                Return 0
                Exit For
            Else
                Suma = Suma + Convert.ToInt32(Combo.Text)
            End If
        Next
        Return Suma
    End Function
    Function ResultadoTabla(Suma As Integer) As String

        If Suma <= 120 And Suma >= 101 Then  'puntos,  es ligeramente bueno
            Return "Ligeramente Bueno"
        ElseIf Suma <= 100 And Suma >= 81 Then 'puntos , buen  desempeño
            Return "Buen Desempeño"
        ElseIf Suma = 80 Then 'puntos, para un desempeño extremadamente bueno.
            Return "Desempeño extremadamente Bueno"
        ElseIf Suma <= 79 And Suma >= 50 Then 'puntos, no es bueno ni pobre
            Return "No es Bueno ni Pobre"
        ElseIf Suma <= 49 And Suma >= 30 Then 'puntos  , desempeño pobre
            Return "Desempeño Pobre"
        ElseIf Suma <= 29 And Suma >= 1 Then 'puntos , extremadamente pobre
            Return "Extremadamente Pobre"
        End If

    End Function
End Class
