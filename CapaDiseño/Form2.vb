Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegist.Click
        Dim cadena As String = txtCorreo.Text

        If txtNombre.Text = "" Then
            MsgBox("Por favor introduzca su nombre")
        ElseIf txtApellido.Text = "" Then
            MsgBox("Por favor introduzca su apellido")
        ElseIf txtCedula.Text = "" Then
            MsgBox("Por favor introduzca su cédula")
        ElseIf txtCorreo.Text = "" Then
            MsgBox("Por favor introduzca su correo")
        ElseIf (Convert.ToString(cadena.IndexOf("@utp.ac.pa", 0) + 1)) = 0 Then
            MsgBox("Debe ser miembro de la UTP")
        ElseIf txtContra.Text <> txtConCon.Text Then
            MsgBox("Por favor introduzca correctamente su contraseña")
        Else
            CapaDatos.Class1.Registro(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtCorreo.Text, txtContra.Text)
            MsgBox("Se agrego correctamente")
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class