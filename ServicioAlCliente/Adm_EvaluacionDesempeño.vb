Imports System.IO
Public Class Adm_EvaluacionDesempeño
    Dim dtPregunta As New DataTable
    Dim dtOpcionesEvaluacion As New DataTable
    Dim contOpciones As Int32 = 0
    Dim objEva As New clsEvaluacionDesempeño
    Dim objEvaOpc As New clsEvaluacionDesempeñoOpciones
    Dim EstadoF As String
    Sub EstadoForm(Estado As String)
        EstadoF = Estado
        Select Case Estado
            Case "Nuevo"
                Habilitar(True)
                Limpiar()
                ToolStripButton1.Enabled = False
                ToolStripButton3.Enabled = False
                ToolStripButton4.Enabled = True
            Case "Seleccion"
                Habilitar(False)
                ToolStripButton1.Enabled = False
                ToolStripButton3.Enabled = True
                ToolStripButton4.Enabled = False
            Case "Guardado"
                Habilitar(False)
                CargarGrid()
                ToolStripButton1.Enabled = True
                ToolStripButton3.Enabled = False
                ToolStripButton4.Enabled = False
            Case "Normal"
                Habilitar(False)
                Limpiar()
                ToolStripButton1.Enabled = True
                ToolStripButton3.Enabled = False
                ToolStripButton4.Enabled = False
            Case "Edicion"
                Habilitar(True)
                ToolStripButton1.Enabled = False
                ToolStripButton3.Enabled = False
                ToolStripButton4.Enabled = True
        End Select
    End Sub

    Private Sub frmTestAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripButton1.Image = Image.FromFile("Imagenes\Formulario\newfile1.png")
        ToolStripButton2.Image = Image.FromFile("Imagenes\Formulario\Apagado2.png")
        ToolStripButton3.Image = Image.FromFile("Imagenes\Formulario\Modify.png")
        ToolStripButton4.Image = Image.FromFile("Imagenes\Formulario\save.png")
        CargarGrid()
        EstadoForm("Normal")
    End Sub
    Function ValidarOrdenDuplicado(OrdenF As Integer) As Boolean
        Dim Duplicados As Integer = 0
        For Each row As DataGridViewRow In GridOpciones.Rows
            Dim FilaMuerta As Boolean = False
            If IsNothing(row.Cells("Texto").Value) And
                IsNothing(row.Cells("Traduccion").Value) And
                IsNothing(row.Cells("Orden").Value) Then
                FilaMuerta = True
            End If

            If FilaMuerta = False Then
                Dim Orden As Int32 = Convert.ToInt32(row.Cells("Orden").Value)

                If Orden = OrdenF Then
                    Duplicados += 1
                End If
            End If
        Next

        If Duplicados > 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Validaciones() As Boolean
        If txtPregunta.Text = "" Then
            MessageBox.Show("Digite una Pregunta")
            txtPregunta.Focus()
            Return False
        End If
        If cmbTipo.SelectedItem = "" Then
            MessageBox.Show("Debe seleccionar un tipo")
            cmbTipo.Focus()
            Return False
        End If

        GridOpciones.Enabled = False
        For Each row As DataGridViewRow In GridOpciones.Rows
            Dim FilaMuerta As Boolean = False
            If IsNothing(row.Cells("Texto").Value) Then
                FilaMuerta = True
            End If

            If FilaMuerta = False Then
                Dim Texto As String = row.Cells("Texto").Value

                If Texto = "" Then
                    MessageBox.Show("Digite un Texto")
                    GridOpciones.Enabled = True
                    row.Cells("Texto").Selected = True
                    Return False
                End If
            End If
        Next

        If GridOpciones.Rows.Count <= 1 Then
            MessageBox.Show("Debes agregar al menos una Opcion")
            'GridOpciones.Rows(0).Cells(0).Selected = True
            Return False
        End If



        Return True

    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        EstadoForm("Nuevo")
        txtPregunta.Focus()

    End Sub

    Sub Habilitar(Accion As Boolean)
        txtPregunta.Enabled = Accion
        cmbTipo.Enabled = Accion
        GridOpciones.Enabled = Accion
        btnAgragarOpcion.Enabled = Accion
    End Sub
    Sub Limpiar()
        txtPregunta.Clear()
        txtCodExamen.Text = ""
        cmbTipo.SelectedItem = Nothing
        GridOpciones.Rows.Clear()
    End Sub
    Sub CargarGrid()
        GridPrincipal.DataSource = objEva.Listar
        GridPrincipal.Columns(0).Width = 35
        GridPrincipal.Columns(1).Width = 350
        GridPrincipal.Columns(2).Width = 120
        GridPrincipal.Columns(3).Width = 77
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If Validaciones() Then
            If EstadoF = "Edicion" Then
                objEva.Guardar("Editar", txtPregunta.Text, cmbTipo.SelectedItem, txtCodExamen.Text)
                objEvaOpc.EliminarTodos(txtCodExamen.Text)
                For Each row As DataGridViewRow In GridOpciones.Rows
                    Dim FilaMuerta As Boolean = False
                    If IsNothing(row.Cells("Texto").Value) Then
                        FilaMuerta = True
                    End If

                    If FilaMuerta = False Then
                        Dim Texto As String = row.Cells("Texto").Value
                        objEvaOpc.Guardar("Guardar", 0, Texto, txtCodExamen.Text)
                    End If

                Next
                EstadoForm("Guardado")
                MessageBox.Show("Se han modificado los datos")
            Else
                objEva.Guardar("Guardar", txtPregunta.Text, cmbTipo.SelectedItem, 0)
                For Each row As DataGridViewRow In GridOpciones.Rows
                    Dim FilaMuerta As Boolean = False
                    If IsNothing(row.Cells("Texto").Value) Then
                        FilaMuerta = True
                    End If

                    If FilaMuerta = False Then
                        Dim Texto As String = row.Cells("Texto").Value
                        objEvaOpc.Guardar("Guardar", 0, Texto, objEva.NuevoId)
                    End If
                Next
                EstadoForm("Guardado")
                MessageBox.Show("Se han guardado los datos")
            End If
        End If
    End Sub
    Sub EstadoEditar(dt As DataTable)
        EstadoForm("Seleccion")
        txtPregunta.Text = dt(0)("evades_strPregunta").ToString()
        txtCodExamen.Text = dt(0)("evades_intId").ToString()
        cmbTipo.SelectedItem = dt(0)("evades_strTipo").ToString()
        CargarOpciones(txtCodExamen.Text)
    End Sub
    Sub CargarOpciones(Id As Integer)
        GridOpciones.Rows.Clear()
        dtOpcionesEvaluacion = objEvaOpc.ListarOpciones(Id)
        For Each row As DataRow In dtOpcionesEvaluacion.Rows
            GridOpciones.Rows.Insert(0, row("Texto"))
        Next
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        EstadoForm("Edicion")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        EstadoForm("Normal")
        contOpciones = 0
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridPrincipal.CellMouseDoubleClick
        Try
            Dim Id As Integer = GridPrincipal.SelectedRows(0).Cells(0).Value.ToString
            EstadoEditar(objEva.SeleccionaUno(Id))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridConversacion_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridOpciones.EditingControlShowing
        Dim col As Int32 = GridOpciones.CurrentCell.ColumnIndex
        If col = 2 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        Else
            RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
        Dim cellTextBox As DataGridViewTextBoxEditingControl =
            TryCast(e.Control, DataGridViewTextBoxEditingControl)
        Dim style As DataGridViewCellStyle = e.CellStyle
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .BackColor = Color.Yellow
        End With
    End Sub
    Private Sub TextBox_keyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnAgragarOpcion_Click(sender As Object, e As EventArgs) Handles btnAgragarOpcion.Click
        GridOpciones.AllowUserToAddRows = True
        GridOpciones.Rows.Add()
    End Sub
End Class