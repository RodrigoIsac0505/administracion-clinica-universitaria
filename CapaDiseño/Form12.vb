Public Class Form12
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim tipo As String

        If txtNPass.Text = txtCPass.Text Then

            If cboTipoUser.Text = "Paciente" Then
                tipo = "1"
            End If

            If cboTipoUser.Text = "Secretaria" Then
                tipo = "2"
            End If

            If cboTipoUser.Text = "Administrador" Then
                tipo = "3"
            End If

            CapaDatos.Class1.addUser(txtCorreo.Text, txtNPass.Text, tipo)
            MsgBox("Perfil agregado Correctamente")
        Else
            MsgBox("Por favor introduzca contraseña iguales")
        End If

    End Sub

    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form13.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class