<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturar_inventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(capturar_inventarios))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.fecha = New System.Windows.Forms.DateTimePicker
        Me.Comboarea = New System.Windows.Forms.ComboBox
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvstock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvcontado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.consumo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InventariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.InventariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.InventariosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inventariosTableAdapter
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblcantidad = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventariosBindingNavigator.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Comboarea)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Size = New System.Drawing.Size(653, 298)
        Me.SplitContainer1.SplitterDistance = 67
        Me.SplitContainer1.TabIndex = 0
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(136, 44)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 1
        '
        'Comboarea
        '
        Me.Comboarea.DataSource = Me.AreasBindingSource
        Me.Comboarea.DisplayMember = "area"
        Me.Comboarea.FormattingEnabled = True
        Me.Comboarea.Location = New System.Drawing.Point(0, 44)
        Me.Comboarea.Name = "Comboarea"
        Me.Comboarea.Size = New System.Drawing.Size(121, 21)
        Me.Comboarea.TabIndex = 0
        Me.Comboarea.ValueMember = "id_area"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.dgvstock, Me.dgvcontado, Me.consumo})
        Me.dgv.DataSource = Me.InventariosBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(653, 227)
        Me.dgv.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 59
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_area"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_area"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 67
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 53
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Id_categoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Id_categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 91
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 77
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'dgvstock
        '
        Me.dgvstock.DataPropertyName = "stock"
        Me.dgvstock.HeaderText = "stock"
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.Width = 58
        '
        'dgvcontado
        '
        Me.dgvcontado.DataPropertyName = "contado"
        Me.dgvcontado.HeaderText = "contado"
        Me.dgvcontado.Name = "dgvcontado"
        Me.dgvcontado.Width = 71
        '
        'consumo
        '
        Me.consumo.DataPropertyName = "consumo"
        Me.consumo.HeaderText = "consumo"
        Me.consumo.Name = "consumo"
        Me.consumo.ReadOnly = True
        Me.consumo.Width = 75
        '
        'InventariosBindingSource
        '
        Me.InventariosBindingSource.DataMember = "inventarios"
        Me.InventariosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'InventariosBindingNavigator
        '
        Me.InventariosBindingNavigator.AddNewItem = Nothing
        Me.InventariosBindingNavigator.BindingSource = Me.InventariosBindingSource
        Me.InventariosBindingNavigator.CountItem = Nothing
        Me.InventariosBindingNavigator.DeleteItem = Nothing
        Me.InventariosBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.InventariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.InventariosBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton3})
        Me.InventariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventariosBindingNavigator.MoveFirstItem = Nothing
        Me.InventariosBindingNavigator.MoveLastItem = Nothing
        Me.InventariosBindingNavigator.MoveNextItem = Nothing
        Me.InventariosBindingNavigator.MovePreviousItem = Nothing
        Me.InventariosBindingNavigator.Name = "InventariosBindingNavigator"
        Me.InventariosBindingNavigator.PositionItem = Nothing
        Me.InventariosBindingNavigator.Size = New System.Drawing.Size(653, 39)
        Me.InventariosBindingNavigator.TabIndex = 1
        Me.InventariosBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.Note_Book
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(106, 36)
        Me.ToolStripButton2.Text = "Cargar Hoja"
        '
        'InventariosBindingNavigatorSaveItem
        '
        Me.InventariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventariosBindingNavigatorSaveItem.Name = "InventariosBindingNavigatorSaveItem"
        Me.InventariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(117, 36)
        Me.InventariosBindingNavigatorSaveItem.Text = "Guardar datos"
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
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Almacen.My.Resources.Resources.Printer
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'InventariosTableAdapter
        '
        Me.InventariosTableAdapter.ClearBeforeFill = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblcantidad})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 202)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(653, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblcantidad
        '
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(15, 20)
        Me.lblcantidad.Text = "-"
        '
        'capturar_inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 298)
        Me.Controls.Add(Me.InventariosBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "capturar_inventarios"
        Me.Text = "capturar_inventarios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventariosBindingNavigator.ResumeLayout(False)
        Me.InventariosBindingNavigator.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents InventariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventariosTableAdapter As Almacen.clinicaDataSetTableAdapters.inventariosTableAdapter
    Friend WithEvents InventariosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents InventariosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Comboarea As System.Windows.Forms.ComboBox
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcontado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents consumo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblcantidad As System.Windows.Forms.ToolStripStatusLabel
End Class
