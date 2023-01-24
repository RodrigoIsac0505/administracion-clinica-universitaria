Public Class Form13
    Private Sub cboUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUser.SelectedIndexChanged
        Dim dtDatos As DataTable = New DataTable
        Dim tipo As String
        dtDatos = CapaDatos.Class1.verInfoUser(cboUser.Text)
        txtCorreo.Text = dtDatos.Rows(0).Item("correo")
        txtCPass.Text = dtDatos.Rows(0).Item("password")
        txtNPass.Text = dtDatos.Rows(0).Item("password")
        If dtDatos.Rows(0).Item("tipo_usuario") = "1" Then
            cboTipoUser.Text = "Paciente"
        End If

        If dtDatos.Rows(0).Item("tipo_usuario") = "2" Then
            cboTipoUser.Text = "Secretaria"
        End If

        If dtDatos.Rows(0).Item("tipo_usuario") = "3" Then
            cboTipoUser.Text = "Administrador"
        End If

    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.verInfoUserCorreo()
        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            For i = 0 To d Step 1
                cboUser.Items.Add(dtDatos.Rows(i).Item("correo"))
            Next
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        If txtNPass.Text = txtCPass.Text Then
            Dim tipo As String
            If cboTipoUser.Text = "Paciente" Then
                tipo = "1"
            End If

            If cboTipoUser.Text = "Secretaria" Then
                tipo = "2"
            End If

            If cboTipoUser.Text = "Administrador" Then
                tipo = "3"
            End If

            CapaDatos.Class1.updateUserAdmin(txtCorreo.Text, txtCPass.Text, tipo, cboUser.Text)
            MsgBox("Perfil Actualizado Correctamente")
        Else
            MsgBox("Por favor introduzca contraseña iguales")
        End If
    End Sub

    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form12.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class