<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.GBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCronograma = New System.Windows.Forms.Button()
        Me.btnRegCitas = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.GBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GBox1.Controls.Add(Me.btnSalir)
        Me.GBox1.Controls.Add(Me.btnCronograma)
        Me.GBox1.Controls.Add(Me.btnRegCitas)
        Me.GBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GBox1.Location = New System.Drawing.Point(12, 12)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(614, 87)
        Me.GBox1.TabIndex = 1
        Me.GBox1.TabStop = False
        Me.GBox1.Text = "Clínica Universitaria"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(379, 40)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(57, 32)
        Me.btnSalir.TabIndex = 26
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCronograma
        '
        Me.btnCronograma.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnCronograma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCronograma.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCronograma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnCronograma.Location = New System.Drawing.Point(22, 40)
        Me.btnCronograma.Name = "btnCronograma"
        Me.btnCronograma.Size = New System.Drawing.Size(206, 32)
        Me.btnCronograma.TabIndex = 22
        Me.btnCronograma.Text = "Cronograma de servivios"
        Me.btnCronograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCronograma.UseVisualStyleBackColor = False
        '
        'btnRegCitas
        '
        Me.btnRegCitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnRegCitas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegCitas.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btnRegCitas.Location = New System.Drawing.Point(234, 40)
        Me.btnRegCitas.Name = "btnRegCitas"
        Me.btnRegCitas.Size = New System.Drawing.Size(139, 32)
        Me.btnRegCitas.TabIndex = 25
        Me.btnRegCitas.Text = "Registro de citas"
        Me.btnRegCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegCitas.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dgvSolicitudes)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 293)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitudes"
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSolicitudes.Location = New System.Drawing.Point(20, 30)
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.Size = New System.Drawing.Size(570, 245)
        Me.dgvSolicitudes.TabIndex = 0
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBox1)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Página Principal de Secretaria"
        Me.GBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBox1 As GroupBox
    Friend WithEvents btnCronograma As Button
    Friend WithEvents btnRegCitas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents btnSalir As Button
End Class
