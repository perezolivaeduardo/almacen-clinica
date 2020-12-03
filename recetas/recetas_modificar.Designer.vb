<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recetas_modificar
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Id_medicoLabel As System.Windows.Forms.Label
        Me.Recetas_dataset = New Almacen.recetas_dataset
        Me.RecetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetasTableAdapter = New Almacen.recetas_datasetTableAdapters.recetasTableAdapter
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.Id_medicoTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicosTableAdapter = New Almacen.clinicaDataSetTableAdapters.medicosTableAdapter
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        IdLabel = New System.Windows.Forms.Label
        Id_medicoLabel = New System.Windows.Forms.Label
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(13, 36)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(82, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id Medico:"
        '
        'Id_medicoLabel
        '
        Id_medicoLabel.AutoSize = True
        Id_medicoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_medicoLabel.Location = New System.Drawing.Point(31, 69)
        Id_medicoLabel.Name = "Id_medicoLabel"
        Id_medicoLabel.Size = New System.Drawing.Size(64, 20)
        Id_medicoLabel.TabIndex = 3
        Id_medicoLabel.Text = "Medico:"
        '
        'Recetas_dataset
        '
        Me.Recetas_dataset.DataSetName = "recetas_dataset"
        Me.Recetas_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecetasBindingSource
        '
        Me.RecetasBindingSource.DataMember = "recetas"
        Me.RecetasBindingSource.DataSource = Me.Recetas_dataset
        '
        'RecetasTableAdapter
        '
        Me.RecetasTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecetasBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(101, 36)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(48, 26)
        Me.IdTextBox.TabIndex = 2
        '
        'Id_medicoTextBox
        '
        Me.Id_medicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecetasBindingSource, "id_medico", True))
        Me.Id_medicoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_medicoTextBox.Location = New System.Drawing.Point(101, 69)
        Me.Id_medicoTextBox.Name = "Id_medicoTextBox"
        Me.Id_medicoTextBox.Size = New System.Drawing.Size(48, 26)
        Me.Id_medicoTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(305, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "medicos"
        Me.MedicosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RecetasBindingSource, "id_medico", True))
        Me.NombreComboBox.DataSource = Me.MedicosBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(155, 69)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(236, 28)
        Me.NombreComboBox.TabIndex = 7
        Me.NombreComboBox.ValueMember = "Id"
        '
        'recetas_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(418, 180)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Id_medicoLabel)
        Me.Controls.Add(Me.Id_medicoTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Name = "recetas_modificar"
        Me.Text = "Asignar Medico"
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Recetas_dataset As Almacen.recetas_dataset
    Friend WithEvents RecetasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecetasTableAdapter As Almacen.recetas_datasetTableAdapters.recetasTableAdapter
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_medicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicosTableAdapter As Almacen.clinicaDataSetTableAdapters.medicosTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
End Class
