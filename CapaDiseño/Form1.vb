Public Class Form1
    Public id_usuario As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSesion.Click
        Dim dtDatos As DataTable = New DataTable
        Dim tipoUsuario As String

        If txtCorreo.Text = "" Then
            MsgBox("Por favor introduzca su correo institucional")
        ElseIf txtPas.Text = "" Then
            MsgBox("Por favor introduzca su contraseña")
        Else
            dtDatos = CapaDatos.Class1.Login(txtCorreo.Text, txtPas.Text)

            If dtDatos.Rows.Count > 0 Then
                tipoUsuario = dtDatos.Rows(0).Item("tipo_usuario")
                id_usuario = dtDatos.Rows(0).Item("id_usuario")
                If tipoUsuario = "1" Then
                    Me.Hide()
                    Form3.Show()
                ElseIf tipoUsuario = "2" Then
                    Me.Hide()
                    Form9.Show()
                Else
                    Me.Hide()
                    Form12.Show()
                End If
            Else
                MsgBox("Datos incorrectos")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles imgSalir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
