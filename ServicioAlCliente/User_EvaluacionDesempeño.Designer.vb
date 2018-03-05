<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_EvaluacionDesempeño
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
        Me.grbPrincipal = New System.Windows.Forms.GroupBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreArea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreCandidato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelColaborativo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbPrincipal
        '
        Me.grbPrincipal.Controls.Add(Me.Label2)
        Me.grbPrincipal.Controls.Add(Me.btnSiguiente)
        Me.grbPrincipal.Controls.Add(Me.lblTituloForm)
        Me.grbPrincipal.Controls.Add(Me.txtFecha)
        Me.grbPrincipal.Controls.Add(Me.Label5)
        Me.grbPrincipal.Controls.Add(Me.txtNombreArea)
        Me.grbPrincipal.Controls.Add(Me.Label4)
        Me.grbPrincipal.Controls.Add(Me.txtNombreCandidato)
        Me.grbPrincipal.Controls.Add(Me.Label1)
        Me.grbPrincipal.Controls.Add(Me.PanelColaborativo)
        Me.grbPrincipal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grbPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grbPrincipal.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPrincipal.Location = New System.Drawing.Point(16, 9)
        Me.grbPrincipal.Name = "grbPrincipal"
        Me.grbPrincipal.Size = New System.Drawing.Size(1038, 571)
        Me.grbPrincipal.TabIndex = 17
        Me.grbPrincipal.TabStop = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(932, 542)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 44
        Me.btnSiguiente.Text = "Continuar"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.Font = New System.Drawing.Font("Arial Unicode MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTituloForm.Location = New System.Drawing.Point(318, 23)
        Me.lblTituloForm.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(243, 25)
        Me.lblTituloForm.TabIndex = 43
        Me.lblTituloForm.Text = "Evaluacion de Desempeño"
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(800, 92)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(207, 25)
        Me.txtFecha.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(796, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Fecha:"
        '
        'txtNombreArea
        '
        Me.txtNombreArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreArea.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreArea.Location = New System.Drawing.Point(442, 92)
        Me.txtNombreArea.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtNombreArea.Name = "txtNombreArea"
        Me.txtNombreArea.Size = New System.Drawing.Size(341, 25)
        Me.txtNombreArea.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(438, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nombre del Area:"
        '
        'txtNombreCandidato
        '
        Me.txtNombreCandidato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCandidato.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCandidato.Location = New System.Drawing.Point(21, 92)
        Me.txtNombreCandidato.Margin = New System.Windows.Forms.Padding(3, 7, 3, 3)
        Me.txtNombreCandidato.Name = "txtNombreCandidato"
        Me.txtNombreCandidato.Size = New System.Drawing.Size(408, 25)
        Me.txtNombreCandidato.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nombre del Candidato:"
        '
        'PanelColaborativo
        '
        Me.PanelColaborativo.AutoScroll = True
        Me.PanelColaborativo.BackColor = System.Drawing.Color.White
        Me.PanelColaborativo.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelColaborativo.Location = New System.Drawing.Point(6, 173)
        Me.PanelColaborativo.Name = "PanelColaborativo"
        Me.PanelColaborativo.Size = New System.Drawing.Size(1001, 363)
        Me.PanelColaborativo.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(426, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Asigne un valor de 1 a 5, siendo 5 el mayor puntaje y 1 el menor"
        '
        'User_EvaluacionDesempeño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1098, 586)
        Me.Controls.Add(Me.grbPrincipal)
        Me.Name = "User_EvaluacionDesempeño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evaluacion Desempeño"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbPrincipal.ResumeLayout(False)
        Me.grbPrincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbPrincipal As GroupBox
    Friend WithEvents PanelColaborativo As Panel
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreArea As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreCandidato As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTituloForm As Label
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Label2 As Label
End Class
