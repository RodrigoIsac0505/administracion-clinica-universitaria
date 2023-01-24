Public Class Form7
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim id As String = Form1.id_usuario

        If txtNPass.Text = txtCPass.Text Then
            CapaDatos.Class1.ACTUALIZARUSUARIO(txtNombre.Text, txtApellido.Text, txtNPass.Text, id)
            MsgBox("Perfil Actualizado Correctamente")
        Else
            MsgBox("Por favor introduzca contraseña iguales")
        End If

    End Sub

    Private Sub btnSolServicios_Click(sender As Object, e As EventArgs) Handles btnSolServicios.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnRegCitas_Click(sender As Object, e As EventArgs) Handles btnRegCitas.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim dtDatos As DataTable = New DataTable
        Dim id As String = Form1.id_usuario

        dtDatos = CapaDatos.Class1.verInfo(id)
        txtNombre.Text = dtDatos.Rows(0).Item("nombre")
        txtApellido.Text = dtDatos.Rows(0).Item("apellido")
        txtCPass.Text = dtDatos.Rows(0).Item("password")
        txtNPass.Text = dtDatos.Rows(0).Item("password")

    End Sub
End Class