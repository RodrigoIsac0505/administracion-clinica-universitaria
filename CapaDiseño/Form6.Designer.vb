<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.dgvRegistro = New System.Windows.Forms.DataGridView()
        Me.cboRegistro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPagP = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnSolServicios = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRegistro
        '
        Me.dgvRegistro.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistro.GridColor = System.Drawing.Color.Azure
        Me.dgvRegistro.Location = New System.Drawing.Point(14, 212)
        Me.dgvRegistro.Name = "dgvRegistro"
        Me.dgvRegistro.Size = New System.Drawing.Size(587, 213)
        Me.dgvRegistro.TabIndex = 0
        '
        'cboRegistro
        '
        Me.cboRegistro.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.cboRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboRegistro.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegistro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.cboRegistro.FormattingEnabled = True
        Me.cboRegistro.Items.AddRange(New Object() {"Todo", "Consultas y evaluaciones médicas con previa cita", "Consultas y evaluaciones de urgencias", "Referencias a especialidades médicas", "Certificado de buena salud", "Solicitudes de estudios de gabinete", "Administración gratuita de medicamentos básicos", "Curaciones y corte de puntos", "Control de peso y talla", "Control de presión arterial", "Inhaloterapias", "Aplicación de medicamentos inyectables", "Toma de glicemia capilar"})
        Me.cboRegistro.Location = New System.Drawing.Point(14, 156)
        Me.cboRegistro.Name = "cboRegistro"
        Me.cboRegistro.Size = New System.Drawing.Size(587, 27)
        Me.cboRegistro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Registro de:"
        '
        'btnPagP
        '
        Me.btnPagP.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnPagP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPagP.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPagP.Location = New System.Drawing.Point(15, 41)
        Me.btnPagP.Name = "btnPagP"
        Me.btnPagP.Size = New System.Drawing.Size(146, 32)
        Me.btnPagP.TabIndex = 13
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
        Me.btnPerfil.Location = New System.Drawing.Point(352, 41)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(63, 32)
        Me.btnPerfil.TabIndex = 15
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'btnSolServicios
        '
        Me.btnSolServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSolServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSolServicios.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolServicios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSolServicios.Location = New System.Drawing.Point(167, 41)
        Me.btnSolServicios.Name = "btnSolServicios"
        Me.btnSolServicios.Size = New System.Drawing.Size(179, 32)
        Me.btnSolServicios.TabIndex = 12
        Me.btnSolServicios.Text = "Solicitud de servivios"
        Me.btnSolServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSolServicios.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnSolServicios)
        Me.GroupBox1.Controls.Add(Me.btnPerfil)
        Me.GroupBox1.Controls.Add(Me.btnPagP)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 86)
        Me.GroupBox1.TabIndex = 2
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
        Me.btnSalir.Location = New System.Drawing.Point(421, 41)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 32)
        Me.btnSalir.TabIndex = 31
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 446)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboRegistro)
        Me.Controls.Add(Me.dgvRegistro)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Servicios o Citas"
        CType(Me.dgvRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRegistro As DataGridView
    Friend WithEvents cboRegistro As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPagP As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnSolServicios As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSalir As Button
End Class
