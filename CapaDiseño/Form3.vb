Public Class Form3
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim c, em, id, id_citaRegistro As String
        Dim dtDatos As DataTable = New DataTable
        id = Form1.id_usuario
        em = CStr(cboEmergencia.Text)
        c = em + " " + CStr(txtDescripcion.Text)
        Dim horaActual As New DateTime(DateTime.Now.TimeOfDay.Ticks)

        dtDatos = CapaDatos.Class1.CitaRapida("Consultas y evaluaciones de urgencias", DateTime.Now.ToString("yyyy/MM/dd"))

        id_citaRegistro = dtDatos.Rows(0).Item("id_cita")

        CapaDatos.Class1.CitaRapida2(id_citaRegistro, id, horaActual, c)
        cboEmergencia.SelectedItem = "Seleccione un tipo"
        txtDescripcion.Text = " "
        MsgBox("Emergencia enviada")
    End Sub

    Private Sub BtnRegMedico_Click(sender As Object, e As EventArgs) Handles BtnRegMedico.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub btnSolServicio_Click(sender As Object, e As EventArgs) Handles btnSolServicio.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class