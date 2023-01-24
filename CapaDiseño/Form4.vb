Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim id_cita, id_usuario As Integer
        Dim dtDatos As DataTable = New DataTable
        dtDatos = CapaDatos.Class1.MostrarIdCita(cboFecha.Text, cboHora.Text)
        id_cita = dtDatos.Rows(0).Item("id_cita")
        id_usuario = Form1.id_usuario
        CapaDatos.Class1.registrarCita(id_cita, id_usuario, cboHora.Text)
        MsgBox("Se agrego la cita")
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Me.Hide()
        Form6.Show()
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

    Private Sub cboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged
        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.ConsultarFecha(cboServicio.Text)
        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            cboFecha.Items.Clear()
            For i = 0 To d Step 1
                cboFecha.Items.Add(dtDatos.Rows(i).Item("fecha"))
            Next
        End If
    End Sub

    Private Sub cboFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFecha.SelectedIndexChanged
        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.ConsultarHora(cboFecha.Text, cboServicio.Text)
        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            cboHora.Items.Clear()
            For i = 0 To d Step 1
                cboHora.Items.Add(dtDatos.Rows(i).Item("hora"))
            Next
        End If
    End Sub

End Class