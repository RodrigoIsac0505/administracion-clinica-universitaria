Public Class Form10
    Private Sub btnPagP_Click(sender As Object, e As EventArgs) Handles btnPagP.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub btnRegCitas_Click(sender As Object, e As EventArgs) Handles btnRegCitas.Click
        Me.Hide()
        Form11.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim dtDatos As DataTable = New DataTable
        Dim id_cita, fechad As String
        Dim cont As Integer = 0
        Dim array1() As String

        fechad = cboInicio.Text

        For t = 0 To 24
            If fechad = cboInicio.Text Then
                ReDim Preserve array1(t)
                array1(t) = fechad
                fechad = (DateAdd("h", 1, cboInicio.Text))
                cont = cont + 1
            Else
                cont = cont + 1
                ReDim Preserve array1(t)
                array1(t) = fechad
                fechad = (DateAdd("h", 1, fechad))
            End If
            Dim temp As String
            temp = (DateAdd("h", 1, cboFinal.Text))
            If fechad = temp Then
                cont = cont - 1
                Exit For
            End If

        Next

        dtDatos = CapaDatos.Class1.cronograma(cboServicio.Text, dtpCalendario.Text)

        id_cita = dtDatos.Rows(0).Item("id_cita")

        'MOSTRAR JUNTOS:
        For I As Integer = 0 To cont
            CapaDatos.Class1.horaCita(id_cita, array1(I))
        Next

        MsgBox("Se agrego el servicio")
    End Sub

    Private Sub cboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpCalendario.Format = DateTimePickerFormat.Custom
        dtpCalendario.CustomFormat = "yyyy/MM/dd"
    End Sub
End Class