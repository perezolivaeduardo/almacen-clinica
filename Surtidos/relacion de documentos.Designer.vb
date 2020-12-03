<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class relacion_de_documentos
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
        Me.components = New System.ComponentModel.Container()
        Dim AreaLabel As System.Windows.Forms.Label
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.Inv_sql_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_sql_documentosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_documentosTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Inv_documentos_tipoTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.dgvfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_sql_documentosDataGridView = New System.Windows.Forms.DataGridView()
        AreaLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Inv_sql_documentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(419, 354)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(31, 13)
        AreaLabel.TabIndex = 8
        AreaLabel.Text = "area:"
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inv_sql_documentosBindingSource
        '
        Me.Inv_sql_documentosBindingSource.DataMember = "inv_sql_documentos"
        Me.Inv_sql_documentosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Inv_sql_documentosTableAdapter
        '
        Me.Inv_sql_documentosTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Almacen.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Almacen.My.Resources.Resources.Add_Item
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(111, 36)
        Me.ToolStripButton3.Text = "Nueva Salida"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.Printer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(89, 36)
        Me.ToolStripButton2.Text = "Imprimir"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Almacen.My.Resources.Resources._Error
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(86, 36)
        Me.ToolStripButton4.Text = "Eliminar"
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_sql_documentosBindingSource, "folio", True))
        Me.FolioTextBox.Location = New System.Drawing.Point(141, 348)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(81, 20)
        Me.FolioTextBox.TabIndex = 5
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inv_sql_documentosBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(228, 348)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'Inv_documentos_tipoTextBox
        '
        Me.Inv_documentos_tipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_sql_documentosBindingSource, "inv_documentos_tipo", True))
        Me.Inv_documentos_tipoTextBox.Location = New System.Drawing.Point(80, 348)
        Me.Inv_documentos_tipoTextBox.Name = "Inv_documentos_tipoTextBox"
        Me.Inv_documentos_tipoTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Inv_documentos_tipoTextBox.TabIndex = 8
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_sql_documentosBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(456, 351)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AreaTextBox.TabIndex = 9
        '
        'dgvfecha
        '
        Me.dgvfecha.DataPropertyName = "fecha"
        Me.dgvfecha.HeaderText = "fecha"
        Me.dgvfecha.Name = "dgvfecha"
        '
        'dgvarea
        '
        Me.dgvarea.DataPropertyName = "area"
        Me.dgvarea.HeaderText = "area"
        Me.dgvarea.Name = "dgvarea"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_area"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID Area"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'dgvfolio
        '
        Me.dgvfolio.DataPropertyName = "folio"
        Me.dgvfolio.HeaderText = "folio"
        Me.dgvfolio.Name = "dgvfolio"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "inv_tipos_tipo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'dgvtipo
        '
        Me.dgvtipo.DataPropertyName = "inv_documentos_tipo"
        Me.dgvtipo.HeaderText = "Tipo"
        Me.dgvtipo.Name = "dgvtipo"
        Me.dgvtipo.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Inv_sql_documentosDataGridView
        '
        Me.Inv_sql_documentosDataGridView.AllowUserToAddRows = False
        Me.Inv_sql_documentosDataGridView.AutoGenerateColumns = False
        Me.Inv_sql_documentosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Inv_sql_documentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inv_sql_documentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.dgvtipo, Me.DataGridViewTextBoxColumn3, Me.dgvfolio, Me.DataGridViewTextBoxColumn5, Me.dgvarea, Me.dgvfecha})
        Me.Inv_sql_documentosDataGridView.DataSource = Me.Inv_sql_documentosBindingSource
        Me.Inv_sql_documentosDataGridView.Location = New System.Drawing.Point(12, 51)
        Me.Inv_sql_documentosDataGridView.Name = "Inv_sql_documentosDataGridView"
        Me.Inv_sql_documentosDataGridView.RowHeadersVisible = False
        Me.Inv_sql_documentosDataGridView.Size = New System.Drawing.Size(992, 351)
        Me.Inv_sql_documentosDataGridView.TabIndex = 1
        '
        'relacion_de_documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 448)
        Me.Controls.Add(Me.Inv_sql_documentosDataGridView)
        Me.Controls.Add(Me.Inv_documentos_tipoTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.FolioTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(AreaLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Name = "relacion_de_documentos"
        Me.Text = "relacion_de_documentos"
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_sql_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Inv_sql_documentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents Inv_sql_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_sql_documentosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_documentosTableAdapter
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Inv_documentos_tipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvfecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inv_sql_documentosDataGridView As System.Windows.Forms.DataGridView
End Class
