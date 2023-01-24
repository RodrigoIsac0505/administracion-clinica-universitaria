<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpCalendario = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.GBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegCitas = New System.Windows.Forms.Button()
        Me.btnPagP = New System.Windows.Forms.Button()
        Me.cboInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboFinal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cboFinal)
        Me.GroupBox1.Controls.Add(Me.cboInicio)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpCalendario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboServicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 296)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cronograma"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(236, 248)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(118, 30)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Final de la jornada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Inicio de jornada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'dtpCalendario
        '
        Me.dtpCalendario.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dtpCalendario.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.dtpCalendario.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCalendario.Location = New System.Drawing.Point(11, 126)
        Me.dtpCalendario.Name = "dtpCalendario"
        Me.dtpCalendario.Size = New System.Drawing.Size(584, 26)
        Me.dtpCalendario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servicio"
        '
        'cboServicio
        '
        Me.cboServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboServicio.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Items.AddRange(New Object() {"Consultas y evaluaciones médicas con previa cita", "Consultas y evaluaciones de urgencias", "Referencias a especialidades médicas", "Certificado de buena salud", "Solicitudes de estudios de gabinete", "Administración gratuita de medicamentos básicos", "Curaciones y corte de puntos", "Control de peso y talla", "Control de presión arterial", "Inhaloterapias", "Aplicación de medicamentos inyectables", "Toma de glicemia capilar"})
        Me.cboServicio.Location = New System.Drawing.Point(12, 61)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(584, 27)
        Me.cboServicio.TabIndex = 0
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GBox1.Controls.Add(Me.btnSalir)
        Me.GBox1.Controls.Add(Me.btnRegCitas)
        Me.GBox1.Controls.Add(Me.btnPagP)
        Me.GBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBox1.Location = New System.Drawing.Point(13, 12)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(614, 87)
        Me.GBox1.TabIndex = 9
        Me.GBox1.TabStop = False
        Me.GBox1.Text = "Clínica Universitaria"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(312, 40)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(57, 32)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnRegCitas
        '
        Me.btnRegCitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnRegCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegCitas.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnRegCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegCitas.Location = New System.Drawing.Point(162, 40)
        Me.btnRegCitas.Name = "btnRegCitas"
        Me.btnRegCitas.Size = New System.Drawing.Size(144, 32)
        Me.btnRegCitas.TabIndex = 25
        Me.btnRegCitas.Text = "Registro de citas"
        Me.btnRegCitas.UseVisualStyleBackColor = False
        '
        'btnPagP
        '
        Me.btnPagP.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPagP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagP.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPagP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagP.Location = New System.Drawing.Point(11, 40)
        Me.btnPagP.Name = "btnPagP"
        Me.btnPagP.Size = New System.Drawing.Size(145, 32)
        Me.btnPagP.TabIndex = 24
        Me.btnPagP.Text = "Página principal"
        Me.btnPagP.UseVisualStyleBackColor = False
        '
        'cboInicio
        '
        Me.cboInicio.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboInicio.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cboInicio.Location = New System.Drawing.Point(11, 216)
        Me.cboInicio.Name = "cboInicio"
        Me.cboInicio.Size = New System.Drawing.Size(266, 26)
        Me.cboInicio.TabIndex = 9
        '
        'cboFinal
        '
        Me.cboFinal.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboFinal.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboFinal.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.cboFinal.Location = New System.Drawing.Point(336, 216)
        Me.cboFinal.Name = "cboFinal"
        Me.cboFinal.Size = New System.Drawing.Size(259, 26)
        Me.cboFinal.TabIndex = 10
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(639, 424)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cronograma de Citas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpCalendario As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents GBox1 As GroupBox
    Friend WithEvents btnRegCitas As Button
    Friend WithEvents btnPagP As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents cboFinal As DateTimePicker
    Friend WithEvents cboInicio As DateTimePicker
End Class
