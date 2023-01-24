<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.cboFecha = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboHora = New System.Windows.Forms.ComboBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnPagP = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboServicio
        '
        Me.cboServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.Items.AddRange(New Object() {"Consultas y evaluaciones médicas con previa cita", "Referencias a especialidades médicas", "Certificado de buena salud", "Solicitudes de estudios de gabinete", "Administración gratuita de medicamentos básicos", "Curaciones y corte de puntos", "Control de peso y talla", "Control de presión arterial", "Inhaloterapias", "Aplicación de medicamentos inyectables", "Toma de glicemia capilar"})
        Me.cboServicio.Location = New System.Drawing.Point(216, 59)
        Me.cboServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(303, 30)
        Me.cboServicio.TabIndex = 2
        '
        'cboFecha
        '
        Me.cboFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboFecha.FormattingEnabled = True
        Me.cboFecha.Location = New System.Drawing.Point(216, 111)
        Me.cboFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFecha.Name = "cboFecha"
        Me.cboFecha.Size = New System.Drawing.Size(303, 30)
        Me.cboFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(89, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(89, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(89, 175)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hora"
        '
        'cboHora
        '
        Me.cboHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboHora.FormattingEnabled = True
        Me.cboHora.Location = New System.Drawing.Point(216, 164)
        Me.cboHora.Margin = New System.Windows.Forms.Padding(4)
        Me.cboHora.Name = "cboHora"
        Me.cboHora.Size = New System.Drawing.Size(303, 30)
        Me.cboHora.TabIndex = 7
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnviar.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnEnviar.Location = New System.Drawing.Point(261, 222)
        Me.btnEnviar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 30)
        Me.btnEnviar.TabIndex = 8
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnPagP
        '
        Me.btnPagP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPagP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagP.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPagP.Location = New System.Drawing.Point(16, 40)
        Me.btnPagP.Name = "btnPagP"
        Me.btnPagP.Size = New System.Drawing.Size(153, 32)
        Me.btnPagP.TabIndex = 4
        Me.btnPagP.Text = "Página principal"
        Me.btnPagP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagP.UseVisualStyleBackColor = False
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerfil.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPerfil.Location = New System.Drawing.Point(325, 40)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(65, 32)
        Me.btnPerfil.TabIndex = 6
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnRegistro)
        Me.GroupBox1.Controls.Add(Me.btnPerfil)
        Me.GroupBox1.Controls.Add(Me.btnPagP)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(598, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clínica Universitaria"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(396, 40)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 32)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistro.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnRegistro.Location = New System.Drawing.Point(175, 40)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(144, 32)
        Me.btnRegistro.TabIndex = 29
        Me.btnRegistro.Text = "Registro de citas"
        Me.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnEnviar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboHora)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboFecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboServicio)
        Me.GroupBox2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 273)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Solicitar cita o servicio"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solicitud de un Servicio o Cita"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboServicio As ComboBox
    Friend WithEvents cboFecha As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboHora As ComboBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnPagP As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
