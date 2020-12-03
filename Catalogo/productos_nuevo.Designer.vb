<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos_nuevo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim Id_provLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NicknameLabel As System.Windows.Forms.Label
        Dim PrecentacionLabel As System.Windows.Forms.Label
        Dim EmpaqueLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim Control_caducidadLabel As System.Windows.Forms.Label
        Dim ConsignaLabel As System.Windows.Forms.Label
        Dim MinimoLabel As System.Windows.Forms.Label
        Dim MaximoLabel As System.Windows.Forms.Label
        Dim EquivaleLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim GrupoLabel As System.Windows.Forms.Label
        Dim Descripcion_facturaLabel As System.Windows.Forms.Label
        Dim ViadeadministracionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos_nuevo))
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.btn_salir = New System.Windows.Forms.ToolStripButton()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_provTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NicknameTextBox = New System.Windows.Forms.TextBox()
        Me.PrecentacionTextBox = New System.Windows.Forms.TextBox()
        Me.EmpaqueTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Control_caducidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConsignaCheckBox = New System.Windows.Forms.CheckBox()
        Me.MinimoTextBox = New System.Windows.Forms.TextBox()
        Me.MaximoTextBox = New System.Windows.Forms.TextBox()
        Me.EquivaleTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.GrupoTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.ViadeadministracionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.idc = New System.Windows.Forms.TextBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Id_productoLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        Id_provLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NicknameLabel = New System.Windows.Forms.Label()
        PrecentacionLabel = New System.Windows.Forms.Label()
        EmpaqueLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        Control_caducidadLabel = New System.Windows.Forms.Label()
        ConsignaLabel = New System.Windows.Forms.Label()
        MinimoLabel = New System.Windows.Forms.Label()
        MaximoLabel = New System.Windows.Forms.Label()
        EquivaleLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        GrupoLabel = New System.Windows.Forms.Label()
        Descripcion_facturaLabel = New System.Windows.Forms.Label()
        ViadeadministracionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Location = New System.Drawing.Point(489, 75)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(24, 13)
        Id_productoLabel.TabIndex = 1
        Id_productoLabel.Text = "ID :"
        AddHandler Id_productoLabel.Click, AddressOf Me.Id_productoLabel_Click
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(79, 73)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(42, 13)
        CodigoLabel.TabIndex = 3
        CodigoLabel.Text = "codigo:"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Location = New System.Drawing.Point(56, 96)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(65, 13)
        Id_categoriaLabel.TabIndex = 5
        Id_categoriaLabel.Text = "id categoria:"
        '
        'Id_provLabel
        '
        Id_provLabel.AutoSize = True
        Id_provLabel.Location = New System.Drawing.Point(59, 122)
        Id_provLabel.Name = "Id_provLabel"
        Id_provLabel.Size = New System.Drawing.Size(62, 13)
        Id_provLabel.TabIndex = 7
        Id_provLabel.Text = "Proveedor :"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(94, 145)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(27, 13)
        TipoLabel.TabIndex = 9
        TipoLabel.Text = "tipo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(55, 174)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripcion:"
        '
        'NicknameLabel
        '
        NicknameLabel.AutoSize = True
        NicknameLabel.Location = New System.Drawing.Point(65, 200)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New System.Drawing.Size(56, 13)
        NicknameLabel.TabIndex = 13
        NicknameLabel.Text = "nickname:"
        '
        'PrecentacionLabel
        '
        PrecentacionLabel.AutoSize = True
        PrecentacionLabel.Location = New System.Drawing.Point(48, 229)
        PrecentacionLabel.Name = "PrecentacionLabel"
        PrecentacionLabel.Size = New System.Drawing.Size(73, 13)
        PrecentacionLabel.TabIndex = 15
        PrecentacionLabel.Text = "Precentacion:"
        '
        'EmpaqueLabel
        '
        EmpaqueLabel.AutoSize = True
        EmpaqueLabel.Location = New System.Drawing.Point(66, 258)
        EmpaqueLabel.Name = "EmpaqueLabel"
        EmpaqueLabel.Size = New System.Drawing.Size(55, 13)
        EmpaqueLabel.TabIndex = 17
        EmpaqueLabel.Text = "Empaque:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(85, 287)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 19
        CostoLabel.Text = "costo:"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(268, 287)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(37, 13)
        VentaLabel.TabIndex = 21
        VentaLabel.Text = "venta:"
        '
        'Control_caducidadLabel
        '
        Control_caducidadLabel.AutoSize = True
        Control_caducidadLabel.Location = New System.Drawing.Point(26, 315)
        Control_caducidadLabel.Name = "Control_caducidadLabel"
        Control_caducidadLabel.Size = New System.Drawing.Size(97, 13)
        Control_caducidadLabel.TabIndex = 23
        Control_caducidadLabel.Text = "Control Caducidad:"
        '
        'ConsignaLabel
        '
        ConsignaLabel.AutoSize = True
        ConsignaLabel.Location = New System.Drawing.Point(170, 315)
        ConsignaLabel.Name = "ConsignaLabel"
        ConsignaLabel.Size = New System.Drawing.Size(54, 13)
        ConsignaLabel.TabIndex = 25
        ConsignaLabel.Text = "Consigna:"
        '
        'MinimoLabel
        '
        MinimoLabel.AutoSize = True
        MinimoLabel.Location = New System.Drawing.Point(292, 315)
        MinimoLabel.Name = "MinimoLabel"
        MinimoLabel.Size = New System.Drawing.Size(43, 13)
        MinimoLabel.TabIndex = 27
        MinimoLabel.Text = "Minimo:"
        '
        'MaximoLabel
        '
        MaximoLabel.AutoSize = True
        MaximoLabel.Location = New System.Drawing.Point(380, 315)
        MaximoLabel.Name = "MaximoLabel"
        MaximoLabel.Size = New System.Drawing.Size(46, 13)
        MaximoLabel.TabIndex = 29
        MaximoLabel.Text = "Maximo:"
        '
        'EquivaleLabel
        '
        EquivaleLabel.AutoSize = True
        EquivaleLabel.Location = New System.Drawing.Point(65, 339)
        EquivaleLabel.Name = "EquivaleLabel"
        EquivaleLabel.Size = New System.Drawing.Size(51, 13)
        EquivaleLabel.TabIndex = 31
        EquivaleLabel.Text = "Equivale:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(91, 365)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(27, 13)
        IvaLabel.TabIndex = 33
        IvaLabel.Text = "IVA:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(78, 394)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(39, 13)
        GrupoLabel.TabIndex = 37
        GrupoLabel.Text = "Grupo:"
        '
        'Descripcion_facturaLabel
        '
        Descripcion_facturaLabel.AutoSize = True
        Descripcion_facturaLabel.Location = New System.Drawing.Point(15, 420)
        Descripcion_facturaLabel.Name = "Descripcion_facturaLabel"
        Descripcion_facturaLabel.Size = New System.Drawing.Size(102, 13)
        Descripcion_facturaLabel.TabIndex = 39
        Descripcion_facturaLabel.Text = "Descripcion factura:"
        '
        'ViadeadministracionLabel
        '
        ViadeadministracionLabel.AutoSize = True
        ViadeadministracionLabel.Location = New System.Drawing.Point(12, 446)
        ViadeadministracionLabel.Name = "ViadeadministracionLabel"
        ViadeadministracionLabel.Size = New System.Drawing.Size(110, 13)
        ViadeadministracionLabel.TabIndex = 41
        ViadeadministracionLabel.Text = "Via de administracion:"
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Nothing
        Me.ProductosBindingNavigator.DeleteItem = Nothing
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.btn_salir})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductosBindingNavigator.MoveFirstItem = Nothing
        Me.ProductosBindingNavigator.MoveLastItem = Nothing
        Me.ProductosBindingNavigator.MoveNextItem = Nothing
        Me.ProductosBindingNavigator.MovePreviousItem = Nothing
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Nothing
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(612, 25)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(105, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_salir
        '
        Me.btn_salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_salir.Image = Global.Almacen.My.Resources.Resources.Log_Off
        Me.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(23, 22)
        Me.btn_salir.Text = "ToolStripButton1"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(519, 71)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.ReadOnly = True
        Me.Id_productoTextBox.Size = New System.Drawing.Size(45, 20)
        Me.Id_productoTextBox.TabIndex = 2
        Me.Id_productoTextBox.TabStop = False
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(129, 70)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(331, 20)
        Me.CodigoTextBox.TabIndex = 4
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_categoria", True))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(129, 93)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Id_categoriaTextBox.TabIndex = 6
        '
        'Id_provTextBox
        '
        Me.Id_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_prov", True))
        Me.Id_provTextBox.Location = New System.Drawing.Point(129, 119)
        Me.Id_provTextBox.Name = "Id_provTextBox"
        Me.Id_provTextBox.Size = New System.Drawing.Size(43, 20)
        Me.Id_provTextBox.TabIndex = 8
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(129, 145)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TipoTextBox.TabIndex = 10
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(129, 174)
        Me.DescripcionTextBox.MaxLength = 50
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(331, 20)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nickname", True))
        Me.NicknameTextBox.Location = New System.Drawing.Point(129, 200)
        Me.NicknameTextBox.MaxLength = 50
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(331, 20)
        Me.NicknameTextBox.TabIndex = 14
        '
        'PrecentacionTextBox
        '
        Me.PrecentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precentacion", True))
        Me.PrecentacionTextBox.Location = New System.Drawing.Point(129, 229)
        Me.PrecentacionTextBox.MaxLength = 10
        Me.PrecentacionTextBox.Name = "PrecentacionTextBox"
        Me.PrecentacionTextBox.Size = New System.Drawing.Size(80, 20)
        Me.PrecentacionTextBox.TabIndex = 16
        '
        'EmpaqueTextBox
        '
        Me.EmpaqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Empaque", True))
        Me.EmpaqueTextBox.Location = New System.Drawing.Point(129, 255)
        Me.EmpaqueTextBox.MaxLength = 4
        Me.EmpaqueTextBox.Name = "EmpaqueTextBox"
        Me.EmpaqueTextBox.Size = New System.Drawing.Size(43, 20)
        Me.EmpaqueTextBox.TabIndex = 18
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(129, 283)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CostoTextBox.TabIndex = 20
        '
        'VentaTextBox
        '
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(311, 283)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(104, 20)
        Me.VentaTextBox.TabIndex = 22
        '
        'Control_caducidadCheckBox
        '
        Me.Control_caducidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "control_caducidad", True))
        Me.Control_caducidadCheckBox.Location = New System.Drawing.Point(129, 309)
        Me.Control_caducidadCheckBox.Name = "Control_caducidadCheckBox"
        Me.Control_caducidadCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.Control_caducidadCheckBox.TabIndex = 24
        '
        'ConsignaCheckBox
        '
        Me.ConsignaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "consigna", True))
        Me.ConsignaCheckBox.Location = New System.Drawing.Point(229, 309)
        Me.ConsignaCheckBox.Name = "ConsignaCheckBox"
        Me.ConsignaCheckBox.Size = New System.Drawing.Size(44, 24)
        Me.ConsignaCheckBox.TabIndex = 26
        '
        'MinimoTextBox
        '
        Me.MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "minimo", True))
        Me.MinimoTextBox.Location = New System.Drawing.Point(342, 311)
        Me.MinimoTextBox.Name = "MinimoTextBox"
        Me.MinimoTextBox.Size = New System.Drawing.Size(29, 20)
        Me.MinimoTextBox.TabIndex = 28
        '
        'MaximoTextBox
        '
        Me.MaximoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "maximo", True))
        Me.MaximoTextBox.Location = New System.Drawing.Point(431, 311)
        Me.MaximoTextBox.Name = "MaximoTextBox"
        Me.MaximoTextBox.Size = New System.Drawing.Size(29, 20)
        Me.MaximoTextBox.TabIndex = 30
        '
        'EquivaleTextBox
        '
        Me.EquivaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "equivale", True))
        Me.EquivaleTextBox.Location = New System.Drawing.Point(129, 339)
        Me.EquivaleTextBox.Name = "EquivaleTextBox"
        Me.EquivaleTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EquivaleTextBox.TabIndex = 32
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(129, 365)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(29, 20)
        Me.IvaTextBox.TabIndex = 34
        '
        'GrupoTextBox
        '
        Me.GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "grupo", True))
        Me.GrupoTextBox.Location = New System.Drawing.Point(129, 394)
        Me.GrupoTextBox.Name = "GrupoTextBox"
        Me.GrupoTextBox.Size = New System.Drawing.Size(29, 20)
        Me.GrupoTextBox.TabIndex = 38
        '
        'Descripcion_facturaTextBox
        '
        Me.Descripcion_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion_factura", True))
        Me.Descripcion_facturaTextBox.Location = New System.Drawing.Point(129, 420)
        Me.Descripcion_facturaTextBox.MaxLength = 50
        Me.Descripcion_facturaTextBox.Name = "Descripcion_facturaTextBox"
        Me.Descripcion_facturaTextBox.Size = New System.Drawing.Size(331, 20)
        Me.Descripcion_facturaTextBox.TabIndex = 40
        '
        'ViadeadministracionTextBox
        '
        Me.ViadeadministracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "viadeadministracion", True))
        Me.ViadeadministracionTextBox.Location = New System.Drawing.Point(129, 446)
        Me.ViadeadministracionTextBox.Name = "ViadeadministracionTextBox"
        Me.ViadeadministracionTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ViadeadministracionTextBox.TabIndex = 42
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Location = New System.Drawing.Point(7, 10)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(58, 23)
        Me.btn_guardar.TabIndex = 43
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Location = New System.Drawing.Point(71, 10)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(58, 23)
        Me.btn_cancelar.TabIndex = 44
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataSource = Me.CategoriasBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(184, 93)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(276, 21)
        Me.CategoriaComboBox.TabIndex = 45
        Me.CategoriaComboBox.ValueMember = "Id_categoria"
        '
        'idc
        '
        Me.idc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "Id_categoria", True))
        Me.idc.Location = New System.Drawing.Point(392, 93)
        Me.idc.Name = "idc"
        Me.idc.Size = New System.Drawing.Size(33, 20)
        Me.idc.TabIndex = 46
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.ProveedoresBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(184, 118)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(276, 21)
        Me.NombreComboBox.TabIndex = 47
        Me.NombreComboBox.ValueMember = "Id"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(374, 119)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(51, 20)
        Me.IdTextBox.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_guardar)
        Me.Panel1.Location = New System.Drawing.Point(456, 472)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 43)
        Me.Panel1.TabIndex = 50
        Me.Panel1.Visible = False
        '
        'productos_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(Id_productoLabel)
        Me.Controls.Add(Me.Id_productoTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Id_categoriaLabel)
        Me.Controls.Add(Me.Id_categoriaTextBox)
        Me.Controls.Add(Id_provLabel)
        Me.Controls.Add(Me.Id_provTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(NicknameLabel)
        Me.Controls.Add(Me.NicknameTextBox)
        Me.Controls.Add(PrecentacionLabel)
        Me.Controls.Add(Me.PrecentacionTextBox)
        Me.Controls.Add(EmpaqueLabel)
        Me.Controls.Add(Me.EmpaqueTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaTextBox)
        Me.Controls.Add(Control_caducidadLabel)
        Me.Controls.Add(Me.Control_caducidadCheckBox)
        Me.Controls.Add(ConsignaLabel)
        Me.Controls.Add(Me.ConsignaCheckBox)
        Me.Controls.Add(MinimoLabel)
        Me.Controls.Add(Me.MinimoTextBox)
        Me.Controls.Add(MaximoLabel)
        Me.Controls.Add(Me.MaximoTextBox)
        Me.Controls.Add(EquivaleLabel)
        Me.Controls.Add(Me.EquivaleTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(GrupoLabel)
        Me.Controls.Add(Me.GrupoTextBox)
        Me.Controls.Add(Descripcion_facturaLabel)
        Me.Controls.Add(Me.Descripcion_facturaTextBox)
        Me.Controls.Add(ViadeadministracionLabel)
        Me.Controls.Add(Me.ViadeadministracionTextBox)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.idc)
        Me.Controls.Add(Me.IdTextBox)
        Me.Name = "productos_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_productoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodigoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_categoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_provTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicknameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecentacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpaqueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Control_caducidadCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConsignaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MinimoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaximoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EquivaleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GrupoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion_facturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViadeadministracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_salir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents idc As System.Windows.Forms.TextBox
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
