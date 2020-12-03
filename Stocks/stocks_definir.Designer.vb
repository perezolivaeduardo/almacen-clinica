<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stocks_definir
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
        Dim AreaLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btn_consumible = New System.Windows.Forms.Button()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstaAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodasLasAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaDeGastosUnAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.StocksDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.CategoriasTableAdapter = New Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter()
        Me.StocksTableAdapter = New Almacen.clinicaDataSetTableAdapters.stocksTableAdapter()
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter()
        Me.ImprimirConsumiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CategoriaLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.StocksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoriaLabel.Location = New System.Drawing.Point(2, 4)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(70, 16)
        CategoriaLabel.TabIndex = 2
        CategoriaLabel.Text = "Categoria:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AreaLabel.Location = New System.Drawing.Point(12, 46)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(55, 18)
        AreaLabel.TabIndex = 1
        AreaLabel.Text = "AREA :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1009, 445)
        Me.SplitContainer1.SplitterDistance = 434
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(CategoriaLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.CategoriaComboBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.buscar)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ProductosDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(434, 445)
        Me.SplitContainer3.SplitterDistance = 57
        Me.SplitContainer3.TabIndex = 0
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataSource = Me.CategoriasBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(80, 3)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(297, 21)
        Me.CategoriaComboBox.TabIndex = 3
        Me.CategoriaComboBox.ValueMember = "Id_categoria"
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
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar :"
        '
        'buscar
        '
        Me.buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscar.Location = New System.Drawing.Point(128, 29)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(287, 22)
        Me.buscar.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 345)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(434, 39)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.Almacen.My.Resources.Resources.icono_medicamento
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(175, 36)
        Me.ToolStripButton4.Text = "Agregar Nuevo Producto"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Almacen.My.Resources.Resources.Log_Off
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeColumns = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.Descripcion, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.id_categoria})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.RowHeadersVisible = False
        Me.ProductosDataGridView.Size = New System.Drawing.Size(434, 384)
        Me.ProductosDataGridView.TabIndex = 1
        '
        'id_producto
        '
        Me.id_producto.DataPropertyName = "id_producto"
        Me.id_producto.HeaderText = "ID"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        Me.id_producto.Width = 43
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "nickname"
        Me.DataGridViewTextBoxColumn7.HeaderText = "nickname"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 78
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Precentacion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Precentacion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 95
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Empaque"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Empaque"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 77
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 58
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "venta"
        Me.DataGridViewTextBoxColumn11.HeaderText = "venta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 59
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "consigna"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "consigna"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 56
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "minimo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "minimo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 64
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "maximo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "maximo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 67
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "equivale"
        Me.DataGridViewTextBoxColumn14.HeaderText = "equivale"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 72
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn15.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 46
        '
        'id_categoria
        '
        Me.id_categoria.DataPropertyName = "id_categoria"
        Me.id_categoria.HeaderText = "id_categoria"
        Me.id_categoria.Name = "id_categoria"
        Me.id_categoria.ReadOnly = True
        Me.id_categoria.Width = 90
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.btn_consumible)
        Me.SplitContainer2.Panel1.Controls.Add(AreaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AreaComboBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.StocksDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(571, 445)
        Me.SplitContainer2.SplitterDistance = 79
        Me.SplitContainer2.TabIndex = 0
        '
        'btn_consumible
        '
        Me.btn_consumible.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_consumible.Location = New System.Drawing.Point(506, 46)
        Me.btn_consumible.Name = "btn_consumible"
        Me.btn_consumible.Size = New System.Drawing.Size(53, 22)
        Me.btn_consumible.TabIndex = 3
        Me.btn_consumible.Text = "Consumible"
        Me.btn_consumible.UseVisualStyleBackColor = True
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataSource = Me.AreasBindingSource
        Me.AreaComboBox.DisplayMember = "area"
        Me.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AreaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(68, 42)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(185, 26)
        Me.AreaComboBox.TabIndex = 2
        Me.AreaComboBox.ValueMember = "id_area"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.btn_guardar, Me.ToolStripButton2, Me.ToolStripSplitButton2, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(571, 39)
        Me.ToolStrip1.TabIndex = 0
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
        Me.ToolStripButton3.Image = Global.Almacen.My.Resources.Resources.Note_Book
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(121, 36)
        Me.ToolStripButton3.Text = "Modificar Lista"
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.Almacen.My.Resources.Resources.Save_Copy
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(85, 36)
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.ToolTipText = "Guardar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources._Error
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(131, 36)
        Me.ToolStripButton2.Text = "Quitar de la Lista"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StocksToolStripMenuItem, Me.HojaDeGastosUnAreaToolStripMenuItem, Me.ImprimirConsumiblesToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = Global.Almacen.My.Resources.Resources.Printer
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripSplitButton2.Text = "ToolStripSplitButton2"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstaAreaToolStripMenuItem, Me.TodasLasAreasToolStripMenuItem})
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.StocksToolStripMenuItem.Text = "Stocks"
        '
        'EstaAreaToolStripMenuItem
        '
        Me.EstaAreaToolStripMenuItem.Name = "EstaAreaToolStripMenuItem"
        Me.EstaAreaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EstaAreaToolStripMenuItem.Text = "Esta Area"
        '
        'TodasLasAreasToolStripMenuItem
        '
        Me.TodasLasAreasToolStripMenuItem.Name = "TodasLasAreasToolStripMenuItem"
        Me.TodasLasAreasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.TodasLasAreasToolStripMenuItem.Text = "Todas las Areas"
        '
        'HojaDeGastosUnAreaToolStripMenuItem
        '
        Me.HojaDeGastosUnAreaToolStripMenuItem.Name = "HojaDeGastosUnAreaToolStripMenuItem"
        Me.HojaDeGastosUnAreaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.HojaDeGastosUnAreaToolStripMenuItem.Text = "Hoja de Gastos un Area"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Almacen.My.Resources.Resources.Registry_Mechanic
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'StocksDataGridView
        '
        Me.StocksDataGridView.AllowUserToAddRows = False
        Me.StocksDataGridView.AllowUserToDeleteRows = False
        Me.StocksDataGridView.AllowUserToOrderColumns = True
        Me.StocksDataGridView.AllowUserToResizeColumns = False
        Me.StocksDataGridView.AllowUserToResizeRows = False
        Me.StocksDataGridView.AutoGenerateColumns = False
        Me.StocksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StocksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvarea, Me.dgvcate, Me.DataGridViewTextBoxColumn4, Me.dgvd, Me.DataGridViewTextBoxColumn16, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn5})
        Me.StocksDataGridView.DataSource = Me.StocksBindingSource
        Me.StocksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StocksDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.StocksDataGridView.Name = "StocksDataGridView"
        Me.StocksDataGridView.RowHeadersVisible = False
        Me.StocksDataGridView.Size = New System.Drawing.Size(571, 362)
        Me.StocksDataGridView.TabIndex = 0
        '
        'dgvarea
        '
        Me.dgvarea.DataPropertyName = "id_area"
        Me.dgvarea.HeaderText = "id_area"
        Me.dgvarea.Name = "dgvarea"
        Me.dgvarea.Visible = False
        Me.dgvarea.Width = 67
        '
        'dgvcate
        '
        Me.dgvcate.DataPropertyName = "id_categoria"
        Me.dgvcate.HeaderText = "Cate"
        Me.dgvcate.Name = "dgvcate"
        Me.dgvcate.Width = 54
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 43
        '
        'dgvd
        '
        Me.dgvd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgvd.DataPropertyName = "descripcion"
        Me.dgvd.HeaderText = "descripcion"
        Me.dgvd.Name = "dgvd"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "maximo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 60
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "consumible"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "consumible"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 66
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "imprimir"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "imprimir"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 47
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "dosis"
        Me.DataGridViewTextBoxColumn18.HeaderText = "dosis"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        Me.DataGridViewTextBoxColumn18.Width = 56
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "minimo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "minimo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 64
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "stocks"
        Me.StocksBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'ImprimirConsumiblesToolStripMenuItem
        '
        Me.ImprimirConsumiblesToolStripMenuItem.Name = "ImprimirConsumiblesToolStripMenuItem"
        Me.ImprimirConsumiblesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ImprimirConsumiblesToolStripMenuItem.Text = "Imprimir Consumibles"
        '
        'stocks_definir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 445)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "stocks_definir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCKS"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.StocksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents buscar As System.Windows.Forms.TextBox
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As Almacen.clinicaDataSetTableAdapters.stocksTableAdapter
    Friend WithEvents StocksDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaDeGastosUnAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents EstaAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodasLasAreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_consumible As System.Windows.Forms.Button
    Friend WithEvents ImprimirConsumiblesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
