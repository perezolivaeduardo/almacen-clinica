<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(productos))
        Me.Id_productoLabel = New System.Windows.Forms.Label
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ProductosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox
        Me.CodigoTextBox = New System.Windows.Forms.TextBox
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_provTextBox = New System.Windows.Forms.TextBox
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoTextBox = New System.Windows.Forms.TextBox
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox
        Me.NicknameTextBox = New System.Windows.Forms.TextBox
        Me.PrecentacionTextBox = New System.Windows.Forms.TextBox
        Me.EmpaqueTextBox = New System.Windows.Forms.TextBox
        Me.CostoTextBox = New System.Windows.Forms.TextBox
        Me.VentaTextBox = New System.Windows.Forms.TextBox
        Me.Control_caducidadCheckBox = New System.Windows.Forms.CheckBox
        Me.ConsignaCheckBox = New System.Windows.Forms.CheckBox
        Me.MinimoTextBox = New System.Windows.Forms.TextBox
        Me.MaximoTextBox = New System.Windows.Forms.TextBox
        Me.EquivaleTextBox = New System.Windows.Forms.TextBox
        Me.IvaTextBox = New System.Windows.Forms.TextBox
        Me.CategoriasTableAdapter = New Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox
        Me.ProveedoresTableAdapter = New Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
        Me.NombreComboBox = New System.Windows.Forms.ComboBox
        Me.GrupoTextBox = New System.Windows.Forms.TextBox
        CodigoLabel = New System.Windows.Forms.Label
        Id_categoriaLabel = New System.Windows.Forms.Label
        Id_provLabel = New System.Windows.Forms.Label
        TipoLabel = New System.Windows.Forms.Label
        DescripcionLabel = New System.Windows.Forms.Label
        NicknameLabel = New System.Windows.Forms.Label
        PrecentacionLabel = New System.Windows.Forms.Label
        EmpaqueLabel = New System.Windows.Forms.Label
        CostoLabel = New System.Windows.Forms.Label
        VentaLabel = New System.Windows.Forms.Label
        Control_caducidadLabel = New System.Windows.Forms.Label
        ConsignaLabel = New System.Windows.Forms.Label
        MinimoLabel = New System.Windows.Forms.Label
        MaximoLabel = New System.Windows.Forms.Label
        EquivaleLabel = New System.Windows.Forms.Label
        IvaLabel = New System.Windows.Forms.Label
        GrupoLabel = New System.Windows.Forms.Label
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(15, 15)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(92, 13)
        CodigoLabel.TabIndex = 3
        CodigoLabel.Text = "codigo de barras :"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Location = New System.Drawing.Point(52, 41)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(55, 13)
        Id_categoriaLabel.TabIndex = 5
        Id_categoriaLabel.Text = "Categoria:"
        '
        'Id_provLabel
        '
        Id_provLabel.AutoSize = True
        Id_provLabel.Location = New System.Drawing.Point(54, 70)
        Id_provLabel.Name = "Id_provLabel"
        Id_provLabel.Size = New System.Drawing.Size(53, 13)
        Id_provLabel.TabIndex = 7
        Id_provLabel.Text = "Provedor:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(76, 93)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(31, 13)
        TipoLabel.TabIndex = 9
        TipoLabel.Text = "Tipo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(41, 119)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 11
        DescripcionLabel.Text = "Descripcion:"
        '
        'NicknameLabel
        '
        NicknameLabel.AutoSize = True
        NicknameLabel.Location = New System.Drawing.Point(49, 145)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New System.Drawing.Size(58, 13)
        NicknameLabel.TabIndex = 13
        NicknameLabel.Text = "Nickname:"
        '
        'PrecentacionLabel
        '
        PrecentacionLabel.AutoSize = True
        PrecentacionLabel.Location = New System.Drawing.Point(34, 171)
        PrecentacionLabel.Name = "PrecentacionLabel"
        PrecentacionLabel.Size = New System.Drawing.Size(73, 13)
        PrecentacionLabel.TabIndex = 15
        PrecentacionLabel.Text = "Precentacion:"
        '
        'EmpaqueLabel
        '
        EmpaqueLabel.AutoSize = True
        EmpaqueLabel.Location = New System.Drawing.Point(52, 197)
        EmpaqueLabel.Name = "EmpaqueLabel"
        EmpaqueLabel.Size = New System.Drawing.Size(55, 13)
        EmpaqueLabel.TabIndex = 17
        EmpaqueLabel.Text = "Empaque:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(70, 223)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(37, 13)
        CostoLabel.TabIndex = 19
        CostoLabel.Text = "Costo:"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(69, 249)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(38, 13)
        VentaLabel.TabIndex = 21
        VentaLabel.Text = "Venta:"
        '
        'Control_caducidadLabel
        '
        Control_caducidadLabel.AutoSize = True
        Control_caducidadLabel.Location = New System.Drawing.Point(12, 277)
        Control_caducidadLabel.Name = "Control_caducidadLabel"
        Control_caducidadLabel.Size = New System.Drawing.Size(95, 13)
        Control_caducidadLabel.TabIndex = 23
        Control_caducidadLabel.Text = "control caducidad:"
        '
        'ConsignaLabel
        '
        ConsignaLabel.AutoSize = True
        ConsignaLabel.Location = New System.Drawing.Point(146, 277)
        ConsignaLabel.Name = "ConsignaLabel"
        ConsignaLabel.Size = New System.Drawing.Size(53, 13)
        ConsignaLabel.TabIndex = 25
        ConsignaLabel.Text = "consigna:"
        '
        'MinimoLabel
        '
        MinimoLabel.AutoSize = True
        MinimoLabel.Location = New System.Drawing.Point(65, 304)
        MinimoLabel.Name = "MinimoLabel"
        MinimoLabel.Size = New System.Drawing.Size(42, 13)
        MinimoLabel.TabIndex = 27
        MinimoLabel.Text = "minimo:"
        '
        'MaximoLabel
        '
        MaximoLabel.AutoSize = True
        MaximoLabel.Location = New System.Drawing.Point(62, 330)
        MaximoLabel.Name = "MaximoLabel"
        MaximoLabel.Size = New System.Drawing.Size(45, 13)
        MaximoLabel.TabIndex = 29
        MaximoLabel.Text = "maximo:"
        '
        'EquivaleLabel
        '
        EquivaleLabel.AutoSize = True
        EquivaleLabel.Location = New System.Drawing.Point(57, 356)
        EquivaleLabel.Name = "EquivaleLabel"
        EquivaleLabel.Size = New System.Drawing.Size(50, 13)
        EquivaleLabel.TabIndex = 31
        EquivaleLabel.Text = "equivale:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(83, 382)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 33
        IvaLabel.Text = "iva:"
        '
        'GrupoLabel
        '
        GrupoLabel.AutoSize = True
        GrupoLabel.Location = New System.Drawing.Point(170, 382)
        GrupoLabel.Name = "GrupoLabel"
        GrupoLabel.Size = New System.Drawing.Size(37, 13)
        GrupoLabel.TabIndex = 37
        GrupoLabel.Text = "grupo:"
        '
        'Id_productoLabel
        '
        Me.Id_productoLabel.AutoSize = True
        Me.Id_productoLabel.Enabled = False
        Me.Id_productoLabel.Location = New System.Drawing.Point(406, 11)
        Me.Id_productoLabel.Name = "Id_productoLabel"
        Me.Id_productoLabel.Size = New System.Drawing.Size(24, 13)
        Me.Id_productoLabel.TabIndex = 1
        Me.Id_productoLabel.Text = "ID :"
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
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
        Me.ProductosBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosBindingNavigatorSaveItem, Me.ToolStripButton2})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(0, 419)
        Me.ProductosBindingNavigator.MoveFirstItem = Nothing
        Me.ProductosBindingNavigator.MoveLastItem = Nothing
        Me.ProductosBindingNavigator.MoveNextItem = Nothing
        Me.ProductosBindingNavigator.MovePreviousItem = Nothing
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Nothing
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(491, 27)
        Me.ProductosBindingNavigator.TabIndex = 0
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'ProductosBindingNavigatorSaveItem
        '
        Me.ProductosBindingNavigatorSaveItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ProductosBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductosBindingNavigatorSaveItem.Name = "ProductosBindingNavigatorSaveItem"
        Me.ProductosBindingNavigatorSaveItem.Size = New System.Drawing.Size(123, 24)
        Me.ProductosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(137, 24)
        Me.ToolStripButton2.Text = "Salir sin Guardar"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(433, 8)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(35, 20)
        Me.Id_productoTextBox.TabIndex = 2
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(116, 12)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(165, 20)
        Me.CodigoTextBox.TabIndex = 4
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriasBindingSource, "Id_categoria", True))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(116, 38)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Id_categoriaTextBox.TabIndex = 6
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Id_provTextBox
        '
        Me.Id_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Id", True))
        Me.Id_provTextBox.Location = New System.Drawing.Point(116, 64)
        Me.Id_provTextBox.Name = "Id_provTextBox"
        Me.Id_provTextBox.Size = New System.Drawing.Size(38, 20)
        Me.Id_provTextBox.TabIndex = 8
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ClinicaDataSet
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(116, 90)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(38, 20)
        Me.TipoTextBox.TabIndex = 10
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(116, 116)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(352, 20)
        Me.DescripcionTextBox.TabIndex = 12
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nickname", True))
        Me.NicknameTextBox.Location = New System.Drawing.Point(116, 142)
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(352, 20)
        Me.NicknameTextBox.TabIndex = 14
        '
        'PrecentacionTextBox
        '
        Me.PrecentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precentacion", True))
        Me.PrecentacionTextBox.Location = New System.Drawing.Point(116, 168)
        Me.PrecentacionTextBox.Name = "PrecentacionTextBox"
        Me.PrecentacionTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PrecentacionTextBox.TabIndex = 16
        '
        'EmpaqueTextBox
        '
        Me.EmpaqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Empaque", True))
        Me.EmpaqueTextBox.Location = New System.Drawing.Point(116, 194)
        Me.EmpaqueTextBox.Name = "EmpaqueTextBox"
        Me.EmpaqueTextBox.Size = New System.Drawing.Size(38, 20)
        Me.EmpaqueTextBox.TabIndex = 18
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(116, 220)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CostoTextBox.TabIndex = 20
        '
        'VentaTextBox
        '
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(116, 246)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(104, 20)
        Me.VentaTextBox.TabIndex = 22
        '
        'Control_caducidadCheckBox
        '
        Me.Control_caducidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "control caducidad", True))
        Me.Control_caducidadCheckBox.Location = New System.Drawing.Point(116, 272)
        Me.Control_caducidadCheckBox.Name = "Control_caducidadCheckBox"
        Me.Control_caducidadCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.Control_caducidadCheckBox.TabIndex = 24
        '
        'ConsignaCheckBox
        '
        Me.ConsignaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "consigna", True))
        Me.ConsignaCheckBox.Location = New System.Drawing.Point(204, 272)
        Me.ConsignaCheckBox.Name = "ConsignaCheckBox"
        Me.ConsignaCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.ConsignaCheckBox.TabIndex = 26
        '
        'MinimoTextBox
        '
        Me.MinimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "minimo", True))
        Me.MinimoTextBox.Location = New System.Drawing.Point(116, 301)
        Me.MinimoTextBox.Name = "MinimoTextBox"
        Me.MinimoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.MinimoTextBox.TabIndex = 28
        '
        'MaximoTextBox
        '
        Me.MaximoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "maximo", True))
        Me.MaximoTextBox.Location = New System.Drawing.Point(116, 327)
        Me.MaximoTextBox.Name = "MaximoTextBox"
        Me.MaximoTextBox.Size = New System.Drawing.Size(104, 20)
        Me.MaximoTextBox.TabIndex = 30
        '
        'EquivaleTextBox
        '
        Me.EquivaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "equivale", True))
        Me.EquivaleTextBox.Location = New System.Drawing.Point(116, 353)
        Me.EquivaleTextBox.Name = "EquivaleTextBox"
        Me.EquivaleTextBox.Size = New System.Drawing.Size(38, 20)
        Me.EquivaleTextBox.TabIndex = 32
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(116, 379)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(38, 20)
        Me.IvaTextBox.TabIndex = 34
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "id_categoria", True))
        Me.CategoriaComboBox.DataSource = Me.CategoriasBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(160, 38)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoriaComboBox.TabIndex = 36
        Me.CategoriaComboBox.ValueMember = "Id_categoria"
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "Nombre", True))
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductosBindingSource, "id_prov", True))
        Me.NombreComboBox.DataSource = Me.ProveedoresBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(160, 65)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(308, 21)
        Me.NombreComboBox.TabIndex = 37
        Me.NombreComboBox.ValueMember = "Id"
        '
        'GrupoTextBox
        '
        Me.GrupoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "grupo", True))
        Me.GrupoTextBox.Location = New System.Drawing.Point(213, 379)
        Me.GrupoTextBox.Name = "GrupoTextBox"
        Me.GrupoTextBox.Size = New System.Drawing.Size(43, 20)
        Me.GrupoTextBox.TabIndex = 38
        '
        'productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 446)
        Me.ControlBox = False
        Me.Controls.Add(GrupoLabel)
        Me.Controls.Add(Me.GrupoTextBox)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(Me.Id_productoLabel)
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
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Name = "productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Altas a Productos"
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ProductosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Almacen.clinicaDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_productoLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GrupoTextBox As System.Windows.Forms.TextBox
End Class
