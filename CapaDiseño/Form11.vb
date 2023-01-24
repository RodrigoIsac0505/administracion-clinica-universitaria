Public Class Form11
    Public fechaG As String
    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub BtnSolSrv_Click(sender As Object, e As EventArgs) Handles btnCronograma.Click
        Me.Hide()
        Form10.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dtDatos As DataTable = New DataTable
        Dim idR As String

        dtDatos = CapaDatos.Class1.ConsultarIdRegistro(cboPaciente.Text, cboFecha.Text, cboCitaServ.Text)

        idR = dtDatos.Rows(0).Item("id_registro")

        CapaDatos.Class1.updateRegistro(idR, txtDescripcion.Text)

        MsgBox("Se agrego la descripcion")

    End Sub

    Private Sub cboPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaciente.SelectedIndexChanged
        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.ConsultarFechasPaciente(cboPaciente.Text)

        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            cboFecha.Items.Clear()
            For i = 0 To d Step 1
                cboFecha.Items.Add(dtDatos.Rows(i).Item("fecha"))
            Next
        End If

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.ConsultarUsuario()
        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            cboPaciente.Items.Clear()
            For i = 0 To d Step 1
                cboPaciente.Items.Add(dtDatos.Rows(i).Item("correo"))
            Next
        End If
    End Sub

    Private Sub cboFecha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFecha.SelectedIndexChanged
        Dim dtDatos As DataTable = New DataTable
        Dim datos, d As Integer

        dtDatos = CapaDatos.Class1.ConsultarCitasPaciente(cboPaciente.Text, cboFecha.Text)
        datos = dtDatos.Rows.Count
        d = datos - 1

        If dtDatos.Rows.Count > 0 Then
            cboCitaServ.Items.Clear()
            For i = 0 To d Step 1
                cboCitaServ.Items.Add(dtDatos.Rows(i).Item("servicio"))
            Next
        End If
    End Sub
End Class