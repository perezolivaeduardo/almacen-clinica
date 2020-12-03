<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lotes_modificar_fechas
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
        Dim LoteLabel As System.Windows.Forms.Label
        Dim Fecha_entradaLabel As System.Windows.Forms.Label
        Dim Fecha_caducidadLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Recetas_dataset = New Almacen.recetas_dataset
        Me.Inv_lotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_lotesTableAdapter = New Almacen.recetas_datasetTableAdapters.inv_lotesTableAdapter
        Me.LoteTextBox = New System.Windows.Forms.TextBox
        Me.Fecha_entradaDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Fecha_caducidadDateTimePicker = New System.Windows.Forms.DateTimePicker
        LoteLabel = New System.Windows.Forms.Label
        Fecha_entradaLabel = New System.Windows.Forms.Label
        Fecha_caducidadLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_lotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(198, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'LoteLabel
        '
        LoteLabel.AutoSize = True
        LoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoteLabel.Location = New System.Drawing.Point(102, 22)
        LoteLabel.Name = "LoteLabel"
        LoteLabel.Size = New System.Drawing.Size(45, 20)
        LoteLabel.TabIndex = 2
        LoteLabel.Text = "Lote:"
        '
        'Fecha_entradaLabel
        '
        Fecha_entradaLabel.AutoSize = True
        Fecha_entradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_entradaLabel.Location = New System.Drawing.Point(30, 51)
        Fecha_entradaLabel.Name = "Fecha_entradaLabel"
        Fecha_entradaLabel.Size = New System.Drawing.Size(117, 20)
        Fecha_entradaLabel.TabIndex = 3
        Fecha_entradaLabel.Text = "Fecha entrada:"
        '
        'Fecha_caducidadLabel
        '
        Fecha_caducidadLabel.AutoSize = True
        Fecha_caducidadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_caducidadLabel.Location = New System.Drawing.Point(12, 83)
        Fecha_caducidadLabel.Name = "Fecha_caducidadLabel"
        Fecha_caducidadLabel.Size = New System.Drawing.Size(135, 20)
        Fecha_caducidadLabel.TabIndex = 5
        Fecha_caducidadLabel.Text = "Fecha caducidad:"
        '
        'Recetas_dataset
        '
        Me.Recetas_dataset.DataSetName = "recetas_dataset"
        Me.Recetas_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inv_lotesBindingSource
        '
        Me.Inv_lotesBindingSource.DataMember = "inv_lotes"
        Me.Inv_lotesBindingSource.DataSource = Me.Recetas_dataset
        '
        'Inv_lotesTableAdapter
        '
        Me.Inv_lotesTableAdapter.ClearBeforeFill = True
        '
        'LoteTextBox
        '
        Me.LoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_lotesBindingSource, "lote", True))
        Me.LoteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoteTextBox.Location = New System.Drawing.Point(153, 22)
        Me.LoteTextBox.Name = "LoteTextBox"
        Me.LoteTextBox.Size = New System.Drawing.Size(100, 24)
        Me.LoteTextBox.TabIndex = 7
        '
        'Fecha_entradaDateTimePicker
        '
        Me.Fecha_entradaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inv_lotesBindingSource, "fecha_entrada", True))
        Me.Fecha_entradaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_entradaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_entradaDateTimePicker.Location = New System.Drawing.Point(153, 51)
        Me.Fecha_entradaDateTimePicker.Name = "Fecha_entradaDateTimePicker"
        Me.Fecha_entradaDateTimePicker.Size = New System.Drawing.Size(129, 24)
        Me.Fecha_entradaDateTimePicker.TabIndex = 8
        '
        'Fecha_caducidadDateTimePicker
        '
        Me.Fecha_caducidadDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inv_lotesBindingSource, "fecha_caducidad", True))
        Me.Fecha_caducidadDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_caducidadDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_caducidadDateTimePicker.Location = New System.Drawing.Point(153, 83)
        Me.Fecha_caducidadDateTimePicker.Name = "Fecha_caducidadDateTimePicker"
        Me.Fecha_caducidadDateTimePicker.Size = New System.Drawing.Size(129, 24)
        Me.Fecha_caducidadDateTimePicker.TabIndex = 9
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(356, 182)
        Me.Controls.Add(Me.Fecha_caducidadDateTimePicker)
        Me.Controls.Add(Me.Fecha_entradaDateTimePicker)
        Me.Controls.Add(Me.LoteTextBox)
        Me.Controls.Add(Fecha_caducidadLabel)
        Me.Controls.Add(Fecha_entradaLabel)
        Me.Controls.Add(LoteLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Fechas"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_lotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Recetas_dataset As Almacen.recetas_dataset
    Friend WithEvents Inv_lotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_lotesTableAdapter As Almacen.recetas_datasetTableAdapters.inv_lotesTableAdapter
    Friend WithEvents LoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_entradaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_caducidadDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
