Public Class Form6
    Private Sub btnSolServicios_Click(sender As Object, e As EventArgs) Handles btnSolServicios.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cboRegistro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegistro.SelectedIndexChanged
        Dim idUsuario As String = Form1.id_usuario

        If cboRegistro.Text = "Todo" Then
            dgvRegistro.DataSource = CapaDatos.Class1.ConsultarTodo(idUsuario)
        Else
            dgvRegistro.DataSource = CapaDatos.Class1.ConsultarServicio(idUsuario, cboRegistro.Text)
        End If
    End Sub
End Class