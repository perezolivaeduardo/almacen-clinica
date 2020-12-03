<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_nueva
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
        Dim Id_areaLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Me.inv_sql_surtidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpaqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlCaducidadDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Inv_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_areaTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fecha_entrada = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.btn_borrar_partido = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.inv_movimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdloteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IduserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvcantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_movimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_documentosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter()
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter()
        Me.Inv_movimientosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_movimientosTableAdapter()
        Me.inv_sql_surtidoTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter()
        Id_areaLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inv_movimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_movimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_areaLabel
        '
        Id_areaLabel.AutoSize = True
        Id_areaLabel.Location = New System.Drawing.Point(17, 12)
        Id_areaLabel.Name = "Id_areaLabel"
        Id_areaLabel.Size = New System.Drawing.Size(35, 13)
        Id_areaLabel.TabIndex = 11
        Id_areaLabel.Text = "Area :"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(8, 47)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(79, 13)
        ObservacionesLabel.TabIndex = 12
        ObservacionesLabel.Text = "observaciones:"
        '
        'inv_sql_surtidoBindingSource
        '
        Me.inv_sql_surtidoBindingSource.DataMember = "inv_sql_surtido"
        Me.inv_sql_surtidoBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1033, 471)
        Me.SplitContainer1.SplitterDistance = 54
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1033, 413)
        Me.SplitContainer2.SplitterDistance = 442
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
        Me.SplitContainer4.Size = New System.Drawing.Size(442, 413)
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
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.PrecentacionDataGridViewTextBoxColumn, Me.EmpaqueDataGridViewTextBoxColumn, Me.ControlCaducidadDataGridViewCheckBoxColumn})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, 57)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.RowHeadersVisible = False
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(442, 196)
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
        Me.TextBox1.Size = New System.Drawing.Size(296, 26)
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
        Me.Label9.Visible = False
        '
        'txtlote
        '
        Me.txtlote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlote.Location = New System.Drawing.Point(96, 126)
        Me.txtlote.Name = "txtlote"
        Me.txtlote.Size = New System.Drawing.Size(68, 23)
        Me.txtlote.TabIndex = 11
        Me.txtlote.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(339, 117)
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
        Me.Label10.Visible = False
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
        Me.caduca.Visible = False
        '
        'txtcosto
        '
        Me.txtcosto.Enabled = False
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(96, 68)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(68, 23)
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
        Me.SplitContainer3.Panel1.Controls.Add(Me.AreaComboBox)
        Me.SplitContainer3.Panel1.Controls.Add(ObservacionesLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ObservacionesTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(Id_areaLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Id_areaTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer3.Panel1.Controls.Add(Me.fecha_entrada)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtfolio)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Panel2.Controls.Add(Me.btn_borrar_partido)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer3.Panel2.Controls.Add(Me.inv_movimientosDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(587, 413)
        Me.SplitContainer3.SplitterDistance = 97
        Me.SplitContainer3.TabIndex = 0
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataSource = Me.AreasBindingSource
        Me.AreaComboBox.DisplayMember = "area"
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(93, 9)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(213, 21)
        Me.AreaComboBox.TabIndex = 14
        Me.AreaComboBox.ValueMember = "id_area"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_documentosBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(93, 47)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(213, 32)
        Me.ObservacionesTextBox.TabIndex = 13
        '
        'Inv_documentosBindingSource
        '
        Me.Inv_documentosBindingSource.DataMember = "inv_documentos"
        Me.Inv_documentosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Id_areaTextBox
        '
        Me.Id_areaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_documentosBindingSource, "id_area", True))
        Me.Id_areaTextBox.Location = New System.Drawing.Point(58, 9)
        Me.Id_areaTextBox.Name = "Id_areaTextBox"
        Me.Id_areaTextBox.Size = New System.Drawing.Size(29, 20)
        Me.Id_areaTextBox.TabIndex = 12
        Me.Id_areaTextBox.Text = "60"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(415, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "FECHA :"
        '
        'fecha_entrada
        '
        Me.fecha_entrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fecha_entrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_entrada.Location = New System.Drawing.Point(469, 59)
        Me.fecha_entrada.Name = "fecha_entrada"
        Me.fecha_entrada.Size = New System.Drawing.Size(106, 20)
        Me.fecha_entrada.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FOLIO :"
        '
        'txtfolio
        '
        Me.txtfolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtfolio.Location = New System.Drawing.Point(512, 7)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.ReadOnly = True
        Me.txtfolio.Size = New System.Drawing.Size(69, 20)
        Me.txtfolio.TabIndex = 0
        '
        'btn_borrar_partido
        '
        Me.btn_borrar_partido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrar_partido.Enabled = False
        Me.btn_borrar_partido.Location = New System.Drawing.Point(6, 238)
        Me.btn_borrar_partido.Name = "btn_borrar_partido"
        Me.btn_borrar_partido.Size = New System.Drawing.Size(97, 23)
        Me.btn_borrar_partido.TabIndex = 3
        Me.btn_borrar_partido.Text = "Borrar partida"
        Me.btn_borrar_partido.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(500, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(419, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'inv_movimientosDataGridView
        '
        Me.inv_movimientosDataGridView.AllowUserToAddRows = False
        Me.inv_movimientosDataGridView.AllowUserToDeleteRows = False
        Me.inv_movimientosDataGridView.AllowUserToResizeColumns = False
        Me.inv_movimientosDataGridView.AllowUserToResizeRows = False
        Me.inv_movimientosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inv_movimientosDataGridView.AutoGenerateColumns = False
        Me.inv_movimientosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.inv_movimientosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.inv_movimientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.IdproductoDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.IdAreaDataGridViewTextBoxColumn, Me.IdloteDataGridViewTextBoxColumn, Me.IduserDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.dgvcantidad, Me.EstatusDataGridViewTextBoxColumn})
        Me.inv_movimientosDataGridView.DataSource = Me.Inv_movimientosBindingSource
        Me.inv_movimientosDataGridView.Location = New System.Drawing.Point(6, 9)
        Me.inv_movimientosDataGridView.Name = "inv_movimientosDataGridView"
        Me.inv_movimientosDataGridView.RowHeadersVisible = False
        Me.inv_movimientosDataGridView.Size = New System.Drawing.Size(575, 223)
        Me.inv_movimientosDataGridView.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 41
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.Visible = False
        Me.FolioDataGridViewTextBoxColumn.Width = 51
        '
        'IdproductoDataGridViewTextBoxColumn1
        '
        Me.IdproductoDataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IdproductoDataGridViewTextBoxColumn1.Name = "IdproductoDataGridViewTextBoxColumn1"
        Me.IdproductoDataGridViewTextBoxColumn1.Width = 43
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "DESCRIPCION"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        '
        'IdAreaDataGridViewTextBoxColumn
        '
        Me.IdAreaDataGridViewTextBoxColumn.DataPropertyName = "id_Area"
        Me.IdAreaDataGridViewTextBoxColumn.HeaderText = "id_Area"
        Me.IdAreaDataGridViewTextBoxColumn.Name = "IdAreaDataGridViewTextBoxColumn"
        Me.IdAreaDataGridViewTextBoxColumn.Visible = False
        Me.IdAreaDataGridViewTextBoxColumn.Width = 68
        '
        'IdloteDataGridViewTextBoxColumn
        '
        Me.IdloteDataGridViewTextBoxColumn.DataPropertyName = "id_lote"
        Me.IdloteDataGridViewTextBoxColumn.HeaderText = "id_lote"
        Me.IdloteDataGridViewTextBoxColumn.Name = "IdloteDataGridViewTextBoxColumn"
        Me.IdloteDataGridViewTextBoxColumn.Visible = False
        Me.IdloteDataGridViewTextBoxColumn.Width = 63
        '
        'IduserDataGridViewTextBoxColumn
        '
        Me.IduserDataGridViewTextBoxColumn.DataPropertyName = "id_user"
        Me.IduserDataGridViewTextBoxColumn.HeaderText = "id_user"
        Me.IduserDataGridViewTextBoxColumn.Name = "IduserDataGridViewTextBoxColumn"
        Me.IduserDataGridViewTextBoxColumn.Visible = False
        Me.IduserDataGridViewTextBoxColumn.Width = 66
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        Me.TipoDataGridViewTextBoxColumn.Width = 49
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Visible = False
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'dgvcantidad
        '
        Me.dgvcantidad.DataPropertyName = "cantidad"
        Me.dgvcantidad.HeaderText = "cantidad"
        Me.dgvcantidad.Name = "dgvcantidad"
        Me.dgvcantidad.Width = 73
        '
        'EstatusDataGridViewTextBoxColumn
        '
        Me.EstatusDataGridViewTextBoxColumn.DataPropertyName = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.HeaderText = "estatus"
        Me.EstatusDataGridViewTextBoxColumn.Name = "EstatusDataGridViewTextBoxColumn"
        Me.EstatusDataGridViewTextBoxColumn.Visible = False
        Me.EstatusDataGridViewTextBoxColumn.Width = 66
        '
        'Inv_movimientosBindingSource
        '
        Me.Inv_movimientosBindingSource.DataMember = "inv_movimientos"
        Me.Inv_movimientosBindingSource.DataSource = Me.ClinicaDataSet
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
        'Inv_documentosTableAdapter
        '
        Me.Inv_documentosTableAdapter.ClearBeforeFill = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'Inv_movimientosTableAdapter
        '
        Me.Inv_movimientosTableAdapter.ClearBeforeFill = True
        '
        'inv_sql_surtidoTableAdapter
        '
        Me.inv_sql_surtidoTableAdapter.ClearBeforeFill = True
        '
        'salida_nueva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 471)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "salida_nueva"
        Me.Text = "SALIDA NUEVA"
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inv_movimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_movimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
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
    Friend WithEvents inv_movimientosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtlote As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fecha_entrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_borrar_partido As System.Windows.Forms.Button
    Friend WithEvents Actualizar_costo As System.Windows.Forms.CheckBox
    Friend WithEvents Inv_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_documentosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_areaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecentacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpaqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlCaducidadDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Inv_movimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_movimientosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_movimientosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdproductoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAreaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdloteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IduserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvcantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inv_sql_surtidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inv_sql_surtidoTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter
End Class
