<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos_relacion
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
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim FisicoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos_relacion))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CAT = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.viadeadministracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FisicoTextBox = New System.Windows.Forms.TextBox()
        Me.Inventario_inicialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Recetas_dataset = New Almacen.recetas_dataset()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CategoriasTableAdapter = New Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter()
        Me.Inventario_inicialTableAdapter = New Almacen.recetas_datasetTableAdapters.inventario_inicialTableAdapter()
        Me.AgregarAConsultaExternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CategoriaLabel = New System.Windows.Forms.Label()
        FisicoLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventario_inicialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(390, 54)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(95, 24)
        CategoriaLabel.TabIndex = 2
        CategoriaLabel.Text = "Categoria:"
        '
        'FisicoLabel
        '
        FisicoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        FisicoLabel.AutoSize = True
        FisicoLabel.Location = New System.Drawing.Point(12, 277)
        FisicoLabel.Name = "FisicoLabel"
        FisicoLabel.Size = New System.Drawing.Size(90, 13)
        FisicoLabel.TabIndex = 2
        FisicoLabel.Text = "Inventario Inicial :"
        AddHandler FisicoLabel.DoubleClick, AddressOf Me.FisicoLabel_DoubleClick
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(CategoriaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CAT)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.filtro)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(936, 445)
        Me.SplitContainer1.SplitterDistance = 92
        Me.SplitContainer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(677, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "FILTAR"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CAT
        '
        Me.CAT.DataSource = Me.CategoriasBindingSource
        Me.CAT.DisplayMember = "Categoria"
        Me.CAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAT.FormattingEnabled = True
        Me.CAT.Location = New System.Drawing.Point(491, 51)
        Me.CAT.Name = "CAT"
        Me.CAT.Size = New System.Drawing.Size(180, 32)
        Me.CAT.TabIndex = 3
        Me.CAT.ValueMember = "Id_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar :"
        '
        'filtro
        '
        Me.filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtro.Location = New System.Drawing.Point(76, 51)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(263, 26)
        Me.filtro.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ProductosDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.Controls.Add(FisicoLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.FisicoTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Size = New System.Drawing.Size(936, 349)
        Me.SplitContainer2.SplitterDistance = 753
        Me.SplitContainer2.TabIndex = 1
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeColumns = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvid, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.descripcion_factura, Me.viadeadministracion, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn17})
        Me.ProductosDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowHeadersVisible = False
        Me.ProductosDataGridView.Size = New System.Drawing.Size(753, 349)
        Me.ProductosDataGridView.TabIndex = 0
        '
        'dgvid
        '
        Me.dgvid.DataPropertyName = "id_producto"
        Me.dgvid.HeaderText = "ID"
        Me.dgvid.Name = "dgvid"
        Me.dgvid.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 64
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.CategoriasBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Categoria"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id_categoria"
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 49
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nickname"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nickname"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 78
        '
        'descripcion_factura
        '
        Me.descripcion_factura.DataPropertyName = "descripcion_factura"
        Me.descripcion_factura.HeaderText = "Descripcion Factura"
        Me.descripcion_factura.Name = "descripcion_factura"
        Me.descripcion_factura.Width = 127
        '
        'viadeadministracion
        '
        Me.viadeadministracion.DataPropertyName = "viadeadministracion"
        Me.viadeadministracion.HeaderText = "via"
        Me.viadeadministracion.Name = "viadeadministracion"
        Me.viadeadministracion.Width = 46
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Precentacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precentacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 95
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "grupo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "grupo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 59
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerStocksToolStripMenuItem, Me.AgregarAConsultaExternaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(217, 70)
        '
        'VerStocksToolStripMenuItem
        '
        Me.VerStocksToolStripMenuItem.Name = "VerStocksToolStripMenuItem"
        Me.VerStocksToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.VerStocksToolStripMenuItem.Text = "Ver Stocks"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(3, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "ver movimientos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FisicoTextBox
        '
        Me.FisicoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FisicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventario_inicialBindingSource, "fisico", True))
        Me.FisicoTextBox.Location = New System.Drawing.Point(108, 274)
        Me.FisicoTextBox.Name = "FisicoTextBox"
        Me.FisicoTextBox.ReadOnly = True
        Me.FisicoTextBox.Size = New System.Drawing.Size(68, 20)
        Me.FisicoTextBox.TabIndex = 3
        '
        'Inventario_inicialBindingSource
        '
        Me.Inventario_inicialBindingSource.DataMember = "inventario_inicial"
        Me.Inventario_inicialBindingSource.DataSource = Me.Recetas_dataset
        '
        'Recetas_dataset
        '
        Me.Recetas_dataset.DataSetName = "recetas_dataset"
        Me.Recetas_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STOCK POR AREA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(0, 26)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(176, 242)
        Me.dgv.TabIndex = 0
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Nothing
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Nothing
        Me.ProductosBindingNavigator.DeleteItem = Nothing
        Me.ProductosBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ProductosBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton3})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Nothing
        Me.ProductosBindingNavigator.MoveLastItem = Nothing
        Me.ProductosBindingNavigator.MoveNextItem = Nothing
        Me.ProductosBindingNavigator.MovePreviousItem = Nothing
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Nothing
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(936, 39)
        Me.ProductosBindingNavigator.TabIndex = 1
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(89, 36)
        Me.ToolStripButton2.Text = "Ver Todo"
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(117, 36)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(208, 36)
        Me.ToolStripButton3.Text = "Actualizar Descripcion en Stock"
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'Inventario_inicialTableAdapter
        '
        Me.Inventario_inicialTableAdapter.ClearBeforeFill = True
        '
        'AgregarAConsultaExternaToolStripMenuItem
        '
        Me.AgregarAConsultaExternaToolStripMenuItem.Name = "AgregarAConsultaExternaToolStripMenuItem"
        Me.AgregarAConsultaExternaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AgregarAConsultaExternaToolStripMenuItem.Text = "Agregar a Consulta Externa"
        '
        'productos_relacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 445)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "productos_relacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventario_inicialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Recetas_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ProductosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents filtro As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CAT As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion_factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents viadeadministracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Recetas_dataset As Almacen.recetas_dataset
    Friend WithEvents Inventario_inicialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inventario_inicialTableAdapter As Almacen.recetas_datasetTableAdapters.inventario_inicialTableAdapter
    Friend WithEvents FisicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AgregarAConsultaExternaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
