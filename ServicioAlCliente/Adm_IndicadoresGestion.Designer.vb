<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Adm_IndicadoresGestion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adm_IndicadoresGestion))
        Me.grbPrincipal = New System.Windows.Forms.GroupBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GridOpciones = New System.Windows.Forms.DataGridView()
        Me.Texto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridPrincipal = New System.Windows.Forms.DataGridView()
        Me.txtCodExamen = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.txtPregunta = New System.Windows.Forms.TextBox()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnAgragarOpcion = New System.Windows.Forms.Button()
        Me.grbPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPrincipal
        '
        Me.grbPrincipal.Controls.Add(Me.cmbTipo)
        Me.grbPrincipal.Controls.Add(Me.Label1)
        Me.grbPrincipal.Controls.Add(Me.GroupBox1)
        Me.grbPrincipal.Controls.Add(Me.GridPrincipal)
        Me.grbPrincipal.Controls.Add(Me.txtCodExamen)
        Me.grbPrincipal.Controls.Add(Me.ToolStrip1)
        Me.grbPrincipal.Controls.Add(Me.txtPregunta)
        Me.grbPrincipal.Controls.Add(Me.lblPregunta)
        Me.grbPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grbPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbPrincipal.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPrincipal.Location = New System.Drawing.Point(14, 10)
        Me.grbPrincipal.Name = "grbPrincipal"
        Me.grbPrincipal.Size = New System.Drawing.Size(659, 583)
        Me.grbPrincipal.TabIndex = 16
        Me.grbPrincipal.TabStop = False
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Gerencial", "Mandos medios", "Operativos"})
        Me.cmbTipo.Location = New System.Drawing.Point(78, 98)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(250, 23)
        Me.cmbTipo.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tipo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgragarOpcion)
        Me.GroupBox1.Controls.Add(Me.GridOpciones)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 273)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'GridOpciones
        '
        Me.GridOpciones.BackgroundColor = System.Drawing.Color.White
        Me.GridOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Texto})
        Me.GridOpciones.Location = New System.Drawing.Point(6, 48)
        Me.GridOpciones.Name = "GridOpciones"
        Me.GridOpciones.Size = New System.Drawing.Size(632, 218)
        Me.GridOpciones.TabIndex = 28
        '
        'Texto
        '
        Me.Texto.Frozen = True
        Me.Texto.HeaderText = "Texto"
        Me.Texto.Name = "Texto"
        Me.Texto.Width = 600
        '
        'GridPrincipal
        '
        Me.GridPrincipal.AllowUserToAddRows = False
        Me.GridPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPrincipal.Location = New System.Drawing.Point(6, 406)
        Me.GridPrincipal.Name = "GridPrincipal"
        Me.GridPrincipal.Size = New System.Drawing.Size(644, 171)
        Me.GridPrincipal.TabIndex = 28
        '
        'txtCodExamen
        '
        Me.txtCodExamen.AutoSize = True
        Me.txtCodExamen.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodExamen.ForeColor = System.Drawing.Color.Maroon
        Me.txtCodExamen.Location = New System.Drawing.Point(635, 72)
        Me.txtCodExamen.Name = "txtCodExamen"
        Me.txtCodExamen.Size = New System.Drawing.Size(15, 13)
        Me.txtCodExamen.TabIndex = 23
        Me.txtCodExamen.Text = "0"
        Me.txtCodExamen.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(653, 39)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Nuevo"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "Nuevo"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "Nuevo"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "Nuevo"
        '
        'txtPregunta
        '
        Me.txtPregunta.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPregunta.Enabled = False
        Me.txtPregunta.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregunta.ForeColor = System.Drawing.Color.Black
        Me.txtPregunta.Location = New System.Drawing.Point(78, 68)
        Me.txtPregunta.Name = "txtPregunta"
        Me.txtPregunta.Size = New System.Drawing.Size(551, 22)
        Me.txtPregunta.TabIndex = 0
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.ForeColor = System.Drawing.Color.Black
        Me.lblPregunta.Location = New System.Drawing.Point(12, 72)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(58, 15)
        Me.lblPregunta.TabIndex = 15
        Me.lblPregunta.Text = "Pregunta"
        '
        'btnAgragarOpcion
        '
        Me.btnAgragarOpcion.Location = New System.Drawing.Point(6, 21)
        Me.btnAgragarOpcion.Name = "btnAgragarOpcion"
        Me.btnAgragarOpcion.Size = New System.Drawing.Size(111, 23)
        Me.btnAgragarOpcion.TabIndex = 29
        Me.btnAgragarOpcion.Text = "Agregar Opción"
        Me.btnAgragarOpcion.UseVisualStyleBackColor = True
        '
        'Adm_IndicadoresGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 605)
        Me.Controls.Add(Me.grbPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Adm_IndicadoresGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analisis de Desempeño"
        Me.grbPrincipal.ResumeLayout(False)
        Me.grbPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPrincipal As GroupBox
    Friend WithEvents GridPrincipal As DataGridView
    Friend WithEvents txtCodExamen As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents txtPregunta As TextBox
    Friend WithEvents lblPregunta As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GridOpciones As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Texto As DataGridViewTextBoxColumn
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents btnAgragarOpcion As Button
End Class
