<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recepcion_de_Mercancia
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Id_proveedorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim FacturaLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim Quien_recibioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recepcion_de_Mercancia))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Inv_recepcion_mercanciaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proveedor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quien_recibio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrarecibo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.numero_entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_recepcion_mercanciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.btn_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ContrareciboCheckBox = New System.Windows.Forms.CheckBox()
        Me.Quien_recibioTextBox = New System.Windows.Forms.TextBox()
        Me.btn_proveedor = New System.Windows.Forms.Button()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FacturaTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.EstatusTextBox = New System.Windows.Forms.TextBox()
        Me.Id_user_capturoTextBox = New System.Windows.Forms.TextBox()
        Me.Inv_recepcion_mercanciaTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_recepcion_mercanciaTableAdapter()
        Me.ProveedoresTableAdapter = New Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.lblpendinentes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_ver_capturadas = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        Id_proveedorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        FacturaLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Quien_recibioLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Inv_recepcion_mercanciaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_recepcion_mercanciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barra.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(314, 42)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 18)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'Id_proveedorLabel
        '
        Id_proveedorLabel.AutoSize = True
        Id_proveedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_proveedorLabel.Location = New System.Drawing.Point(18, 87)
        Id_proveedorLabel.Name = "Id_proveedorLabel"
        Id_proveedorLabel.Size = New System.Drawing.Size(85, 18)
        Id_proveedorLabel.TabIndex = 2
        Id_proveedorLabel.Text = "Proveedor :"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(54, 117)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 18)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "fecha:"
        '
        'FacturaLabel
        '
        FacturaLabel.AutoSize = True
        FacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FacturaLabel.Location = New System.Drawing.Point(45, 142)
        FacturaLabel.Name = "FacturaLabel"
        FacturaLabel.Size = New System.Drawing.Size(57, 18)
        FacturaLabel.TabIndex = 6
        FacturaLabel.Text = "factura:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.Location = New System.Drawing.Point(7, 168)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(95, 18)
        ComentariosLabel.TabIndex = 8
        ComentariosLabel.Text = "comentarios:"
        '
        'Quien_recibioLabel
        '
        Quien_recibioLabel.AutoSize = True
        Quien_recibioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quien_recibioLabel.Location = New System.Drawing.Point(7, 261)
        Quien_recibioLabel.Name = "Quien_recibioLabel"
        Quien_recibioLabel.Size = New System.Drawing.Size(99, 18)
        Quien_recibioLabel.TabIndex = 17
        Quien_recibioLabel.Text = "Quien recibio:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Inv_recepcion_mercanciaDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.barra)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.ContrareciboCheckBox)
        Me.SplitContainer1.Panel2.Controls.Add(Quien_recibioLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Quien_recibioTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_proveedor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtproveedor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_guardar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(IdLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Id_proveedorLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_proveedorTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(FechaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer1.Panel2.Controls.Add(FacturaLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FacturaTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(ComentariosLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EstatusTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Id_user_capturoTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(1168, 404)
        Me.SplitContainer1.SplitterDistance = 687
        Me.SplitContainer1.TabIndex = 0
        '
        'Inv_recepcion_mercanciaDataGridView
        '
        Me.Inv_recepcion_mercanciaDataGridView.AllowUserToAddRows = False
        Me.Inv_recepcion_mercanciaDataGridView.AllowUserToResizeColumns = False
        Me.Inv_recepcion_mercanciaDataGridView.AllowUserToResizeRows = False
        Me.Inv_recepcion_mercanciaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_recepcion_mercanciaDataGridView.AutoGenerateColumns = False
        Me.Inv_recepcion_mercanciaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Inv_recepcion_mercanciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Inv_recepcion_mercanciaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.id_proveedor, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.quien_recibio, Me.contrarecibo, Me.numero_entrada})
        Me.Inv_recepcion_mercanciaDataGridView.DataSource = Me.Inv_recepcion_mercanciaBindingSource
        Me.Inv_recepcion_mercanciaDataGridView.Location = New System.Drawing.Point(21, 62)
        Me.Inv_recepcion_mercanciaDataGridView.Name = "Inv_recepcion_mercanciaDataGridView"
        Me.Inv_recepcion_mercanciaDataGridView.RowHeadersVisible = False
        Me.Inv_recepcion_mercanciaDataGridView.Size = New System.Drawing.Size(654, 299)
        Me.Inv_recepcion_mercanciaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 43
        '
        'id_proveedor
        '
        Me.id_proveedor.DataPropertyName = "id_proveedor"
        Me.id_proveedor.DataSource = Me.ProveedoresBindingSource
        Me.id_proveedor.DisplayMember = "Nombre"
        Me.id_proveedor.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.id_proveedor.HeaderText = "Proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        Me.id_proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.id_proveedor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.id_proveedor.ValueMember = "Id"
        Me.id_proveedor.Width = 81
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "factura"
        Me.DataGridViewTextBoxColumn4.HeaderText = "factura"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn5.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn6.HeaderText = "estatus"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'quien_recibio
        '
        Me.quien_recibio.DataPropertyName = "quien_recibio"
        Me.quien_recibio.HeaderText = "Recibio"
        Me.quien_recibio.Name = "quien_recibio"
        Me.quien_recibio.Width = 68
        '
        'contrarecibo
        '
        Me.contrarecibo.DataPropertyName = "contrarecibo"
        Me.contrarecibo.HeaderText = "CT"
        Me.contrarecibo.Name = "contrarecibo"
        Me.contrarecibo.ToolTipText = "Contrarecibo"
        Me.contrarecibo.Width = 27
        '
        'numero_entrada
        '
        Me.numero_entrada.DataPropertyName = "numero_entrada"
        Me.numero_entrada.HeaderText = "# Entrada"
        Me.numero_entrada.Name = "numero_entrada"
        Me.numero_entrada.Width = 79
        '
        'Inv_recepcion_mercanciaBindingSource
        '
        Me.Inv_recepcion_mercanciaBindingSource.DataMember = "inv_recepcion_mercancia"
        Me.Inv_recepcion_mercanciaBindingSource.DataSource = Me.ClinicaDataSet
        '
        'barra
        '
        Me.barra.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.barra.BindingSource = Me.Inv_recepcion_mercanciaBindingSource
        Me.barra.CountItem = Nothing
        Me.barra.DeleteItem = Nothing
        Me.barra.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.btn_Eliminar, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.btn_ver_capturadas})
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.MoveFirstItem = Nothing
        Me.barra.MoveLastItem = Nothing
        Me.barra.MoveNextItem = Nothing
        Me.barra.MovePreviousItem = Nothing
        Me.barra.Name = "barra"
        Me.barra.PositionItem = Nothing
        Me.barra.Size = New System.Drawing.Size(687, 39)
        Me.barra.TabIndex = 1
        Me.barra.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(121, 36)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Image = Global.Almacen.My.Resources.Resources._Error
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.RightToLeftAutoMirrorImage = True
        Me.btn_Eliminar.Size = New System.Drawing.Size(132, 36)
        Me.btn_Eliminar.Text = "Eliminar Registro"
        Me.btn_Eliminar.Visible = False
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.orden
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(132, 36)
        Me.ToolStripButton2.Text = "Registrar Entrada"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblpendinentes})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(687, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ContrareciboCheckBox
        '
        Me.ContrareciboCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Inv_recepcion_mercanciaBindingSource, "contrarecibo", True))
        Me.ContrareciboCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContrareciboCheckBox.Location = New System.Drawing.Point(289, 262)
        Me.ContrareciboCheckBox.Name = "ContrareciboCheckBox"
        Me.ContrareciboCheckBox.Size = New System.Drawing.Size(129, 24)
        Me.ContrareciboCheckBox.TabIndex = 19
        Me.ContrareciboCheckBox.Text = "Contra Recibo"
        Me.ContrareciboCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ContrareciboCheckBox.UseVisualStyleBackColor = True
        '
        'Quien_recibioTextBox
        '
        Me.Quien_recibioTextBox.AutoCompleteCustomSource.AddRange(New String() {"Glemy", "Lili"})
        Me.Quien_recibioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "quien_recibio", True))
        Me.Quien_recibioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quien_recibioTextBox.Location = New System.Drawing.Point(109, 261)
        Me.Quien_recibioTextBox.Name = "Quien_recibioTextBox"
        Me.Quien_recibioTextBox.Size = New System.Drawing.Size(161, 24)
        Me.Quien_recibioTextBox.TabIndex = 18
        '
        'btn_proveedor
        '
        Me.btn_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_proveedor.Location = New System.Drawing.Point(424, 83)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(47, 23)
        Me.btn_proveedor.TabIndex = 15
        Me.btn_proveedor.Text = "..."
        Me.btn_proveedor.UseVisualStyleBackColor = True
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(109, 81)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(309, 24)
        Me.txtproveedor.TabIndex = 14
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.Location = New System.Drawing.Point(343, 326)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 13
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(262, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(343, 42)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(75, 24)
        Me.IdTextBox.TabIndex = 1
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "id_proveedor", True))
        Me.Id_proveedorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(212, 82)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(23, 24)
        Me.Id_proveedorTextBox.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inv_recepcion_mercanciaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(109, 112)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 24)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'FacturaTextBox
        '
        Me.FacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "factura", True))
        Me.FacturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacturaTextBox.Location = New System.Drawing.Point(109, 138)
        Me.FacturaTextBox.Name = "FacturaTextBox"
        Me.FacturaTextBox.Size = New System.Drawing.Size(200, 24)
        Me.FacturaTextBox.TabIndex = 7
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(109, 164)
        Me.ComentariosTextBox.MaxLength = 255
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(309, 88)
        Me.ComentariosTextBox.TabIndex = 9
        '
        'EstatusTextBox
        '
        Me.EstatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "estatus", True))
        Me.EstatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstatusTextBox.Location = New System.Drawing.Point(109, 228)
        Me.EstatusTextBox.Name = "EstatusTextBox"
        Me.EstatusTextBox.Size = New System.Drawing.Size(31, 24)
        Me.EstatusTextBox.TabIndex = 11
        '
        'Id_user_capturoTextBox
        '
        Me.Id_user_capturoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_recepcion_mercanciaBindingSource, "id_user_capturo", True))
        Me.Id_user_capturoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_user_capturoTextBox.Location = New System.Drawing.Point(355, 228)
        Me.Id_user_capturoTextBox.Name = "Id_user_capturoTextBox"
        Me.Id_user_capturoTextBox.Size = New System.Drawing.Size(47, 24)
        Me.Id_user_capturoTextBox.TabIndex = 17
        '
        'Inv_recepcion_mercanciaTableAdapter
        '
        Me.Inv_recepcion_mercanciaTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(136, 36)
        Me.ToolStripButton3.Text = "Actualizar Listado"
        '
        'lblpendinentes
        '
        Me.lblpendinentes.Name = "lblpendinentes"
        Me.lblpendinentes.Size = New System.Drawing.Size(12, 17)
        Me.lblpendinentes.Text = "-"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btn_ver_capturadas
        '
        Me.btn_ver_capturadas.Image = Global.Almacen.My.Resources.Resources.Binoculars
        Me.btn_ver_capturadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ver_capturadas.Name = "btn_ver_capturadas"
        Me.btn_ver_capturadas.Size = New System.Drawing.Size(120, 36)
        Me.btn_ver_capturadas.Text = "Ver capturadas"
        '
        'Recepcion_de_Mercancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 404)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Recepcion_de_Mercancia"
        Me.Text = "Recepcion_de_Mercancia"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Inv_recepcion_mercanciaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_recepcion_mercanciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barra.ResumeLayout(False)
        Me.barra.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents Inv_recepcion_mercanciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_recepcion_mercanciaTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_recepcion_mercanciaTableAdapter
    Friend WithEvents barra As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_proveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FacturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EstatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_proveedor As System.Windows.Forms.Button
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Inv_recepcion_mercanciaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents Id_user_capturoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_Eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContrareciboCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Quien_recibioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_proveedor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quien_recibio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contrarecibo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents numero_entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblpendinentes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_ver_capturadas As System.Windows.Forms.ToolStripButton
End Class
