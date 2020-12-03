<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KardexGlobal
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
        Dim InicialLabel As System.Windows.Forms.Label
        Dim ENTLabel As System.Windows.Forms.Label
        Dim SalidasLabel As System.Windows.Forms.Label
        Dim FinalLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Rpt_productosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rpt_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chk_cargarresumen = New System.Windows.Forms.CheckBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Inventario_finalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalTextBox = New System.Windows.Forms.TextBox()
        Me.SalidasTextBox = New System.Windows.Forms.TextBox()
        Me.ENTTextBox = New System.Windows.Forms.TextBox()
        Me.InicialTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_movimintos_al_inventario_area_resumenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_movimientos_al_inventario_x_areaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_movimientos_al_inventario_x_areaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Rpt_productosTableAdapter = New Almacen.clinicaDataSetTableAdapters.rpt_productosTableAdapter()
        Me.Inventario_finalTableAdapter = New Almacen.clinicaDataSetTableAdapters.Inventario_finalTableAdapter()
        Me.Sql_movimintos_al_inventario_area_resumenTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_movimintos_al_inventario_area_resumenTableAdapter()
        Me.Sql_movimientos_al_inventario_x_areaTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_movimientos_al_inventario_x_areaTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        InicialLabel = New System.Windows.Forms.Label()
        ENTLabel = New System.Windows.Forms.Label()
        SalidasLabel = New System.Windows.Forms.Label()
        FinalLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Rpt_productosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Inventario_finalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.Sql_movimintos_al_inventario_area_resumenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_movimintos_al_inventario_area_resumenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_movimientos_al_inventario_x_areaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_movimientos_al_inventario_x_areaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InicialLabel
        '
        InicialLabel.AutoSize = True
        InicialLabel.Location = New System.Drawing.Point(17, 51)
        InicialLabel.Name = "InicialLabel"
        InicialLabel.Size = New System.Drawing.Size(136, 20)
        InicialLabel.TabIndex = 6
        InicialLabel.Text = "Existencia_inicial :"
        '
        'ENTLabel
        '
        ENTLabel.AutoSize = True
        ENTLabel.Location = New System.Drawing.Point(71, 79)
        ENTLabel.Name = "ENTLabel"
        ENTLabel.Size = New System.Drawing.Size(82, 20)
        ENTLabel.TabIndex = 8
        ENTLabel.Text = "Entradas :"
        '
        'SalidasLabel
        '
        SalidasLabel.AutoSize = True
        SalidasLabel.Location = New System.Drawing.Point(82, 114)
        SalidasLabel.Name = "SalidasLabel"
        SalidasLabel.Size = New System.Drawing.Size(69, 20)
        SalidasLabel.TabIndex = 10
        SalidasLabel.Text = "Salidas :"
        '
        'FinalLabel
        '
        FinalLabel.AutoSize = True
        FinalLabel.Location = New System.Drawing.Point(13, 146)
        FinalLabel.Name = "FinalLabel"
        FinalLabel.Size = New System.Drawing.Size(138, 20)
        FinalLabel.TabIndex = 12
        FinalLabel.Text = "Existencia Actual :"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(16, 19)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(53, 20)
        FechaLabel.TabIndex = 14
        FechaLabel.Text = "fecha:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1083, 612)
        Me.SplitContainer1.SplitterDistance = 636
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtfiltro)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Rpt_productosDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(636, 612)
        Me.SplitContainer2.SplitterDistance = 81
        Me.SplitContainer2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar :"
        '
        'txtfiltro
        '
        Me.txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltro.Location = New System.Drawing.Point(101, 47)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(395, 31)
        Me.txtfiltro.TabIndex = 0
        '
        'Rpt_productosDataGridView
        '
        Me.Rpt_productosDataGridView.AllowUserToAddRows = False
        Me.Rpt_productosDataGridView.AllowUserToDeleteRows = False
        Me.Rpt_productosDataGridView.AutoGenerateColumns = False
        Me.Rpt_productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Rpt_productosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Rpt_productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rpt_productosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.dgvid, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Rpt_productosDataGridView.DataSource = Me.Rpt_productosBindingSource
        Me.Rpt_productosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rpt_productosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Rpt_productosDataGridView.Name = "Rpt_productosDataGridView"
        Me.Rpt_productosDataGridView.ReadOnly = True
        Me.Rpt_productosDataGridView.RowHeadersVisible = False
        Me.Rpt_productosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Rpt_productosDataGridView.Size = New System.Drawing.Size(636, 527)
        Me.Rpt_productosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_categoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cat"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 29
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'dgvid
        '
        Me.dgvid.DataPropertyName = "id_producto"
        Me.dgvid.HeaderText = "ID"
        Me.dgvid.Name = "dgvid"
        Me.dgvid.ReadOnly = True
        Me.dgvid.Width = 43
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "provedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "provedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 49
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
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "consigna"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "consigna"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "equivale"
        Me.DataGridViewTextBoxColumn12.HeaderText = "equivale"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 72
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn13.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 46
        '
        'Rpt_productosBindingSource
        '
        Me.Rpt_productosBindingSource.DataMember = "rpt_productos"
        Me.Rpt_productosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.chk_cargarresumen)
        Me.SplitContainer3.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer3.Panel1.Controls.Add(FinalLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.FinalTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(SalidasLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.SalidasTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(ENTLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.ENTTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(InicialLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.InicialTextBox)
        Me.SplitContainer3.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Size = New System.Drawing.Size(443, 612)
        Me.SplitContainer3.SplitterDistance = 224
        Me.SplitContainer3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(17, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 26)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Resumen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chk_cargarresumen
        '
        Me.chk_cargarresumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_cargarresumen.AutoSize = True
        Me.chk_cargarresumen.Checked = True
        Me.chk_cargarresumen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_cargarresumen.Location = New System.Drawing.Point(197, 197)
        Me.chk_cargarresumen.Name = "chk_cargarresumen"
        Me.chk_cargarresumen.Size = New System.Drawing.Size(234, 24)
        Me.chk_cargarresumen.TabIndex = 16
        Me.chk_cargarresumen.Text = "Cargar Resumen Automatico"
        Me.chk_cargarresumen.UseVisualStyleBackColor = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inventario_finalBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(157, 15)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(100, 26)
        Me.FechaDateTimePicker.TabIndex = 15
        '
        'Inventario_finalBindingSource
        '
        Me.Inventario_finalBindingSource.DataMember = "Inventario_final"
        Me.Inventario_finalBindingSource.DataSource = Me.ClinicaDataSet
        '
        'FinalTextBox
        '
        Me.FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventario_finalBindingSource, "final", True))
        Me.FinalTextBox.Location = New System.Drawing.Point(157, 143)
        Me.FinalTextBox.Name = "FinalTextBox"
        Me.FinalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.FinalTextBox.TabIndex = 13
        Me.FinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalidasTextBox
        '
        Me.SalidasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventario_finalBindingSource, "salidas", True))
        Me.SalidasTextBox.Location = New System.Drawing.Point(157, 111)
        Me.SalidasTextBox.Name = "SalidasTextBox"
        Me.SalidasTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SalidasTextBox.TabIndex = 11
        Me.SalidasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ENTTextBox
        '
        Me.ENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventario_finalBindingSource, "ENT", True))
        Me.ENTTextBox.Location = New System.Drawing.Point(157, 79)
        Me.ENTTextBox.Name = "ENTTextBox"
        Me.ENTTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ENTTextBox.TabIndex = 9
        Me.ENTTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'InicialTextBox
        '
        Me.InicialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventario_finalBindingSource, "inicial", True))
        Me.InicialTextBox.Location = New System.Drawing.Point(157, 47)
        Me.InicialTextBox.Name = "InicialTextBox"
        Me.InicialTextBox.Size = New System.Drawing.Size(100, 26)
        Me.InicialTextBox.TabIndex = 7
        Me.InicialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 384)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(435, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Movimientos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.Sql_movimintos_al_inventario_area_resumenDataGridView)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.AutoScroll = True
        Me.SplitContainer4.Panel2.Controls.Add(Me.Sql_movimientos_al_inventario_x_areaDataGridView)
        Me.SplitContainer4.Size = New System.Drawing.Size(429, 352)
        Me.SplitContainer4.SplitterDistance = 205
        Me.SplitContainer4.TabIndex = 1
        '
        'Sql_movimintos_al_inventario_area_resumenDataGridView
        '
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AllowUserToAddRows = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AllowUserToDeleteRows = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AllowUserToResizeColumns = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AllowUserToResizeRows = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AutoGenerateColumns = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.cantidad})
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.DataSource = Me.Sql_movimintos_al_inventario_area_resumenBindingSource
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.GridColor = System.Drawing.Color.Black
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.Name = "Sql_movimintos_al_inventario_area_resumenDataGridView"
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.ReadOnly = True
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.RowHeadersVisible = False
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.Size = New System.Drawing.Size(205, 352)
        Me.Sql_movimintos_al_inventario_area_resumenDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 69
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn14.HeaderText = "area"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 53
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "inv_movimientos_tipo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 53
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "inv_tipos_tipo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 73
        '
        'Sql_movimintos_al_inventario_area_resumenBindingSource
        '
        Me.Sql_movimintos_al_inventario_area_resumenBindingSource.DataMember = "sql_movimintos_al_inventario_area_resumen"
        Me.Sql_movimintos_al_inventario_area_resumenBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Sql_movimientos_al_inventario_x_areaDataGridView
        '
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AllowUserToAddRows = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AllowUserToDeleteRows = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AllowUserToResizeColumns = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AllowUserToResizeRows = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AutoGenerateColumns = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.DataSource = Me.Sql_movimientos_al_inventario_x_areaBindingSource
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.Name = "Sql_movimientos_al_inventario_x_areaDataGridView"
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.ReadOnly = True
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.RowHeadersVisible = False
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.Size = New System.Drawing.Size(220, 352)
        Me.Sql_movimientos_al_inventario_x_areaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn25.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 59
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "inv_tipos_tipo"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "entradas"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Ent"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 48
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "surtido"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Sal."
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 50
        '
        'Sql_movimientos_al_inventario_x_areaBindingSource
        '
        Me.Sql_movimientos_al_inventario_x_areaBindingSource.DataMember = "sql_movimientos_al_inventario_x_area"
        Me.Sql_movimientos_al_inventario_x_areaBindingSource.DataSource = Me.ClinicaDataSet
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(435, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Estadistica"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Rpt_productosTableAdapter
        '
        Me.Rpt_productosTableAdapter.ClearBeforeFill = True
        '
        'Inventario_finalTableAdapter
        '
        Me.Inventario_finalTableAdapter.ClearBeforeFill = True
        '
        'Sql_movimintos_al_inventario_area_resumenTableAdapter
        '
        Me.Sql_movimintos_al_inventario_area_resumenTableAdapter.ClearBeforeFill = True
        '
        'Sql_movimientos_al_inventario_x_areaTableAdapter
        '
        Me.Sql_movimientos_al_inventario_x_areaTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(636, 39)
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
        'KardexGlobal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 612)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "KardexGlobal"
        Me.Text = "KardexGlobal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Rpt_productosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Inventario_finalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.Sql_movimintos_al_inventario_area_resumenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_movimintos_al_inventario_area_resumenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_movimientos_al_inventario_x_areaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_movimientos_al_inventario_x_areaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents Rpt_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rpt_productosTableAdapter As Almacen.clinicaDataSetTableAdapters.rpt_productosTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Rpt_productosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Inventario_finalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inventario_finalTableAdapter As Almacen.clinicaDataSetTableAdapters.Inventario_finalTableAdapter
    Friend WithEvents FinalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalidasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ENTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InicialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sql_movimintos_al_inventario_area_resumenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_movimintos_al_inventario_area_resumenTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_movimintos_al_inventario_area_resumenTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_movimintos_al_inventario_area_resumenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chk_cargarresumen As System.Windows.Forms.CheckBox
    Friend WithEvents Sql_movimientos_al_inventario_x_areaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_movimientos_al_inventario_x_areaTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_movimientos_al_inventario_x_areaTableAdapter
    Friend WithEvents Sql_movimientos_al_inventario_x_areaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
