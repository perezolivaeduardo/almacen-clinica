<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrada_nueva
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Fecha_vencimientoLabel As System.Windows.Forms.Label
        Dim Fecha_pagoLabel As System.Windows.Forms.Label
        Dim ContrareciboLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlCaducidadDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Actualizar_costo = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtlote = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.caduca = New System.Windows.Forms.DateTimePicker()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fecha_entrada = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fecha_factura = New System.Windows.Forms.DateTimePicker()
        Me.TXTFACTURA = New System.Windows.Forms.TextBox()
        Me.TXTIDPROV = New System.Windows.Forms.TextBox()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btn_borrar_partido = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cap_lotesDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cap_lotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedoresTableAdapter = New Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter()
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cap_lotesTableAdapter = New Almacen.clinicaDataSetTableAdapters.cap_lotesTableAdapter()
        Me.Inv_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_documentosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter()
        Me.Fecha_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_pago = New System.Windows.Forms.DateTimePicker()
        Me.ContrareciboCheckBox = New System.Windows.Forms.CheckBox()
        Fecha_vencimientoLabel = New System.Windows.Forms.Label()
        Fecha_pagoLabel = New System.Windows.Forms.Label()
        ContrareciboLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Cap_lotesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cap_lotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(901, 526)
        Me.SplitContainer1.SplitterDistance = 62
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(901, 460)
        Me.SplitContainer2.SplitterDistance = 386
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel1.Controls.Add(Me.ProductosDataGridView)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer4.Panel2.Controls.Add(Me.Actualizar_costo)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtlote)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer4.Panel2.Controls.Add(Me.caduca)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtcosto)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtcantidad)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtdescripcion)
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtid)
        Me.SplitContainer4.Size = New System.Drawing.Size(386, 460)
        Me.SplitContainer4.SplitterDistance = 253
        Me.SplitContainer4.TabIndex = 5
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AllowUserToResizeColumns = False
        Me.ProductosDataGridView.AllowUserToResizeRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.PrecentacionDataGridViewTextBoxColumn, Me.EmpaqueDataGridViewTextBoxColumn, Me.pcosto, Me.VentaDataGridViewTextBoxColumn, Me.ControlCaducidadDataGridViewCheckBoxColumn})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, 57)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.RowHeadersVisible = False
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(386, 196)
        Me.ProductosDataGridView.TabIndex = 3
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdproductoDataGridViewTextBoxColumn.Width = 40
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 88
        '
        'NicknameDataGridViewTextBoxColumn
        '
        Me.NicknameDataGridViewTextBoxColumn.DataPropertyName = "nickname"
        Me.NicknameDataGridViewTextBoxColumn.HeaderText = "nickname"
        Me.NicknameDataGridViewTextBoxColumn.Name = "NicknameDataGridViewTextBoxColumn"
        Me.NicknameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NicknameDataGridViewTextBoxColumn.Width = 78
        '
        'PrecentacionDataGridViewTextBoxColumn
        '
        Me.PrecentacionDataGridViewTextBoxColumn.DataPropertyName = "Precentacion"
        Me.PrecentacionDataGridViewTextBoxColumn.HeaderText = "Precentacion"
        Me.PrecentacionDataGridViewTextBoxColumn.Name = "PrecentacionDataGridViewTextBoxColumn"
        Me.PrecentacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecentacionDataGridViewTextBoxColumn.Width = 95
        '
        'EmpaqueDataGridViewTextBoxColumn
        '
        Me.EmpaqueDataGridViewTextBoxColumn.DataPropertyName = "Empaque"
        Me.EmpaqueDataGridViewTextBoxColumn.HeaderText = "Emp."
        Me.EmpaqueDataGridViewTextBoxColumn.Name = "EmpaqueDataGridViewTextBoxColumn"
        Me.EmpaqueDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpaqueDataGridViewTextBoxColumn.Width = 56
        '
        'pcosto
        '
        Me.pcosto.DataPropertyName = "costo"
        Me.pcosto.HeaderText = "costo"
        Me.pcosto.Name = "pcosto"
        Me.pcosto.ReadOnly = True
        Me.pcosto.Width = 58
        '
        'VentaDataGridViewTextBoxColumn
        '
        Me.VentaDataGridViewTextBoxColumn.DataPropertyName = "venta"
        Me.VentaDataGridViewTextBoxColumn.HeaderText = "venta"
        Me.VentaDataGridViewTextBoxColumn.Name = "VentaDataGridViewTextBoxColumn"
        Me.VentaDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaDataGridViewTextBoxColumn.Width = 59
        '
        'ControlCaducidadDataGridViewCheckBoxColumn
        '
        Me.ControlCaducidadDataGridViewCheckBoxColumn.DataPropertyName = "control caducidad"
        Me.ControlCaducidadDataGridViewCheckBoxColumn.HeaderText = "control caducidad"
        Me.ControlCaducidadDataGridViewCheckBoxColumn.Name = "ControlCaducidadDataGridViewCheckBoxColumn"
        Me.ControlCaducidadDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ControlCaducidadDataGridViewCheckBoxColumn.Width = 98
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar :"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(85, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Actualizar_costo
        '
        Me.Actualizar_costo.AutoSize = True
        Me.Actualizar_costo.Location = New System.Drawing.Point(96, 162)
        Me.Actualizar_costo.Margin = New System.Windows.Forms.Padding(2)
        Me.Actualizar_costo.Name = "Actualizar_costo"
        Me.Actualizar_costo.Size = New System.Drawing.Size(152, 17)
        Me.Actualizar_costo.TabIndex = 13
        Me.Actualizar_costo.Text = "NO ACTUALIZAR COSTO"
        Me.Actualizar_costo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Lote :"
        '
        'txtlote
        '
        Me.txtlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlote.Location = New System.Drawing.Point(96, 126)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(68, 23)
        Me.txtlote.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(296, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Caducidad :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Costo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cantidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ID:"
        '
        'caduca
        '
        Me.caduca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caduca.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.caduca.Location = New System.Drawing.Point(96, 97)
        Me.caduca.Name = "caduca"
        Me.caduca.Size = New System.Drawing.Size(95, 23)
        Me.caduca.TabIndex = 4
        '
        'txtcosto
        '
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(96, 68)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(95, 23)
        Me.txtcosto.TabIndex = 3
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(96, 38)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(68, 23)
        Me.txtcantidad.TabIndex = 2
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(96, 12)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ReadOnly = True
        Me.txtdescripcion.Size = New System.Drawing.Size(253, 20)
        Me.txtdescripcion.TabIndex = 1
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(39, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(51, 20)
        Me.txtid.TabIndex = 0
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
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel1.Controls.Add(ContrareciboLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ContrareciboCheckBox)
        Me.SplitContainer3.Panel1.Controls.Add(Fecha_pagoLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Fecha_pago)
        Me.SplitContainer3.Panel1.Controls.Add(Fecha_vencimientoLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Fecha_vencimiento)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fecha_entrada)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer3.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fecha_factura)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TXTFACTURA)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TXTIDPROV)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtfolio)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label12)
        Me.SplitContainer3.Panel2.Controls.Add(Me.txttotal)
        Me.SplitContainer3.Panel2.Controls.Add(Me.btn_borrar_partido)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Cap_lotesDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(511, 460)
        Me.SplitContainer3.SplitterDistance = 136
        Me.SplitContainer3.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(292, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "FECHA ENTRADA:"
        '
        'fecha_entrada
        '
        Me.fecha_entrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_entrada.Location = New System.Drawing.Point(399, 66)
        Me.fecha_entrada.Name = "fecha_entrada"
        Me.fecha_entrada.Size = New System.Drawing.Size(106, 20)
        Me.fecha_entrada.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FECHA FACTURA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FACTURA:"
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.ProveedoresBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(128, 8)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(223, 21)
        Me.NombreComboBox.TabIndex = 7
        Me.NombreComboBox.ValueMember = "Id"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PROVEEDOR :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FOLIO :"
        '
        'fecha_factura
        '
        Me.fecha_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_factura.Location = New System.Drawing.Point(399, 38)
        Me.fecha_factura.Name = "fecha_factura"
        Me.fecha_factura.Size = New System.Drawing.Size(106, 20)
        Me.fecha_factura.TabIndex = 3
        '
        'TXTFACTURA
        '
        Me.TXTFACTURA.Location = New System.Drawing.Point(95, 37)
        Me.TXTFACTURA.Name = "TXTFACTURA"
        Me.TXTFACTURA.Size = New System.Drawing.Size(136, 20)
        Me.TXTFACTURA.TabIndex = 2
        '
        'TXTIDPROV
        '
        Me.TXTIDPROV.Location = New System.Drawing.Point(95, 9)
        Me.TXTIDPROV.Name = "TXTIDPROV"
        Me.TXTIDPROV.ReadOnly = True
        Me.TXTIDPROV.Size = New System.Drawing.Size(27, 20)
        Me.TXTIDPROV.TabIndex = 1
        '
        'txtfolio
        '
        Me.txtfolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfolio.Location = New System.Drawing.Point(436, 7)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.ReadOnly = True
        Me.txtfolio.Size = New System.Drawing.Size(69, 20)
        Me.txtfolio.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 298)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(511, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblstatus
        '
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(12, 17)
        Me.lblstatus.Text = "-"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(348, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Sub-total :"
        '
        'txttotal
        '
        Me.txttotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttotal.Location = New System.Drawing.Point(409, 231)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(90, 20)
        Me.txttotal.TabIndex = 4
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_borrar_partido
        '
        Me.btn_borrar_partido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrar_partido.Enabled = False
        Me.btn_borrar_partido.Location = New System.Drawing.Point(11, 266)
        Me.btn_borrar_partido.Name = "btn_borrar_partido"
        Me.btn_borrar_partido.Size = New System.Drawing.Size(97, 23)
        Me.btn_borrar_partido.TabIndex = 3
        Me.btn_borrar_partido.Text = "Borrar partida"
        Me.btn_borrar_partido.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(424, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(343, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cap_lotesDataGridView
        '
        Me.Cap_lotesDataGridView.AllowUserToAddRows = False
        Me.Cap_lotesDataGridView.AllowUserToDeleteRows = False
        Me.Cap_lotesDataGridView.AllowUserToResizeColumns = False
        Me.Cap_lotesDataGridView.AllowUserToResizeRows = False
        Me.Cap_lotesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cap_lotesDataGridView.AutoGenerateColumns = False
        Me.Cap_lotesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Cap_lotesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Cap_lotesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvnum, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.dgvcantidad, Me.dgvcosto, Me.DataGridViewTextBoxColumn12, Me.lote})
        Me.Cap_lotesDataGridView.DataSource = Me.Cap_lotesBindingSource
        Me.Cap_lotesDataGridView.Location = New System.Drawing.Point(6, 3)
        Me.Cap_lotesDataGridView.Name = "Cap_lotesDataGridView"
        Me.Cap_lotesDataGridView.RowHeadersVisible = False
        Me.Cap_lotesDataGridView.Size = New System.Drawing.Size(493, 217)
        Me.Cap_lotesDataGridView.TabIndex = 0
        '
        'dgvnum
        '
        Me.dgvnum.DataPropertyName = "num"
        Me.dgvnum.HeaderText = "num"
        Me.dgvnum.Name = "dgvnum"
        Me.dgvnum.Width = 52
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn9.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 86
        '
        'dgvcantidad
        '
        Me.dgvcantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvcantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvcantidad.HeaderText = "cantidad"
        Me.dgvcantidad.Name = "dgvcantidad"
        Me.dgvcantidad.Width = 73
        '
        'dgvcosto
        '
        Me.dgvcosto.DataPropertyName = "costo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        Me.dgvcosto.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvcosto.HeaderText = "costo"
        Me.dgvcosto.Name = "dgvcosto"
        Me.dgvcosto.Width = 58
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "caducidad"
        Me.DataGridViewTextBoxColumn12.HeaderText = "caducidad"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 82
        '
        'lote
        '
        Me.lote.DataPropertyName = "lote"
        Me.lote.HeaderText = "lote"
        Me.lote.Name = "lote"
        Me.lote.Width = 49
        '
        'Cap_lotesBindingSource
        '
        Me.Cap_lotesBindingSource.DataMember = "cap_lotes"
        Me.Cap_lotesBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn1.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 67
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 43
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "decripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "decripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 73
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 58
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "caducidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "caducidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 82
        '
        'Cap_lotesTableAdapter
        '
        Me.Cap_lotesTableAdapter.ClearBeforeFill = True
        '
        'Inv_documentosBindingSource
        '
        Me.Inv_documentosBindingSource.DataMember = "inv_documentos"
        Me.Inv_documentosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Inv_documentosTableAdapter
        '
        Me.Inv_documentosTableAdapter.ClearBeforeFill = True
        '
        'Fecha_vencimientoLabel
        '
        Fecha_vencimientoLabel.AutoSize = True
        Fecha_vencimientoLabel.Location = New System.Drawing.Point(8, 89)
        Fecha_vencimientoLabel.Name = "Fecha_vencimientoLabel"
        Fecha_vencimientoLabel.Size = New System.Drawing.Size(122, 13)
        Fecha_vencimientoLabel.TabIndex = 11
        Fecha_vencimientoLabel.Text = "FECHA VENCIMIENTO:"
        '
        'Fecha_vencimiento
        '
        Me.Fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_vencimiento.Location = New System.Drawing.Point(133, 83)
        Me.Fecha_vencimiento.Name = "Fecha_vencimiento"
        Me.Fecha_vencimiento.Size = New System.Drawing.Size(98, 20)
        Me.Fecha_vencimiento.TabIndex = 12
        '
        'Fecha_pagoLabel
        '
        Fecha_pagoLabel.AutoSize = True
        Fecha_pagoLabel.Location = New System.Drawing.Point(28, 115)
        Fecha_pagoLabel.Name = "Fecha_pagoLabel"
        Fecha_pagoLabel.Size = New System.Drawing.Size(99, 13)
        Fecha_pagoLabel.TabIndex = 13
        Fecha_pagoLabel.Text = "FECHA DE PAGO :"
        '
        'Fecha_pago
        '
        Me.Fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_pago.Location = New System.Drawing.Point(133, 109)
        Me.Fecha_pago.Name = "Fecha_pago"
        Me.Fecha_pago.Size = New System.Drawing.Size(98, 20)
        Me.Fecha_pago.TabIndex = 14
        '
        'ContrareciboLabel
        '
        ContrareciboLabel.AutoSize = True
        ContrareciboLabel.Location = New System.Drawing.Point(291, 108)
        ContrareciboLabel.Name = "ContrareciboLabel"
        ContrareciboLabel.Size = New System.Drawing.Size(69, 13)
        ContrareciboLabel.TabIndex = 15
        ContrareciboLabel.Text = "contrarecibo:"
        '
        'ContrareciboCheckBox
        '
        Me.ContrareciboCheckBox.Location = New System.Drawing.Point(366, 103)
        Me.ContrareciboCheckBox.Name = "ContrareciboCheckBox"
        Me.ContrareciboCheckBox.Size = New System.Drawing.Size(37, 24)
        Me.ContrareciboCheckBox.TabIndex = 16
        Me.ContrareciboCheckBox.UseVisualStyleBackColor = True
        '
        'entrada_nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 526)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "entrada_nueva"
        Me.Text = "NUEVA ENTRADA"
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Cap_lotesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cap_lotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_factura As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTFACTURA As System.Windows.Forms.TextBox
    Friend WithEvents TXTIDPROV As System.Windows.Forms.TextBox
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents caduca As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cap_lotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cap_lotesTableAdapter As Almacen.clinicaDataSetTableAdapters.cap_lotesTableAdapter
    Friend WithEvents Cap_lotesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fecha_entrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_borrar_partido As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpaqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pcosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlCaducidadDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Actualizar_costo As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblstatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Inv_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_documentosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter
    Friend WithEvents ContrareciboCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Fecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_vencimiento As System.Windows.Forms.DateTimePicker
End Class
