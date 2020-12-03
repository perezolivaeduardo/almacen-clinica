<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inv_calcula_Existencia
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
        Me.components = New System.ComponentModel.Container
        Dim AreaLabel As System.Windows.Forms.Label
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.hinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.fecha_mov = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Status = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.bar = New System.Windows.Forms.ToolStripProgressBar
        Me.tr = New System.Windows.Forms.ToolStripStatusLabel
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter
        Me.lista = New System.Windows.Forms.CheckedListBox
        AreaLabel = New System.Windows.Forms.Label
        Me.Status.SuspendLayout()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AreaLabel.Location = New System.Drawing.Point(428, 9)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(164, 24)
        AreaLabel.TabIndex = 10
        AreaLabel.Text = "Seleccionar Areas"
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(243, 45)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(151, 29)
        Me.fecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha del Inventario :"
        '
        'hinicio
        '
        Me.hinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hinicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.hinicio.Location = New System.Drawing.Point(243, 161)
        Me.hinicio.Name = "hinicio"
        Me.hinicio.Size = New System.Drawing.Size(151, 29)
        Me.hinicio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hora de Inicio Inventario :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Consumos a partir del :"
        '
        'fecha_mov
        '
        Me.fecha_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_mov.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_mov.Location = New System.Drawing.Point(243, 102)
        Me.fecha_mov.Name = "fecha_mov"
        Me.fecha_mov.Size = New System.Drawing.Size(151, 29)
        Me.fecha_mov.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(253, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "calcula"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(334, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.bar, Me.tr})
        Me.Status.Location = New System.Drawing.Point(0, 302)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(638, 22)
        Me.Status.TabIndex = 9
        Me.Status.Text = "StatusStrip1"
        Me.Status.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel1.Text = "Calculando"
        '
        'bar
        '
        Me.bar.Name = "bar"
        Me.bar.Size = New System.Drawing.Size(100, 16)
        '
        'tr
        '
        Me.tr.Name = "tr"
        Me.tr.Size = New System.Drawing.Size(0, 17)
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'lista
        '
        Me.lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(432, 45)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(177, 274)
        Me.lista.TabIndex = 11
        '
        'inv_calcula_Existencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 324)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fecha_mov)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hinicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fecha)
        Me.Name = "inv_calcula_Existencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Existencias"
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fecha_mov As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tr As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents lista As System.Windows.Forms.CheckedListBox
End Class
