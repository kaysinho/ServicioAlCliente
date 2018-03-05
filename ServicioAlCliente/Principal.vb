Public Class Principal
    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Dim form = New Adm_EvaluacionDesempeño()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Dim form = New User_EvaluacionDesempeño()
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub AdministradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministradorToolStripMenuItem.Click
        Dim form = New Adm_IndicadoresGestion()
        form.MdiParent = Me
        form.Show()
    End Sub
End Class