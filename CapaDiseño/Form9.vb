Public Class Form9
    Private Sub btnCronograma_Click(sender As Object, e As EventArgs) Handles btnCronograma.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub btnRegCitas_Click(sender As Object, e As EventArgs) Handles btnRegCitas.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvSolicitudes.DataSource = CapaDatos.Class1.allSolicitudes()

    End Sub
End Class