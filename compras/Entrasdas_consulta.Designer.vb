<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrasdas_consulta
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.combopv = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.dgv_doc = New System.Windows.Forms.DataGridView()
        Me.dgvfolio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProveedoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inv_documentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_lote = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Inv_lotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_documentosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter()
        Me.Inv_lotesTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_lotesTableAdapter()
        Me.ProveedoresTableAdapter = New Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter()
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.imprimir = New System.Windows.Forms.CheckBox()
        NombreLabel = New System.Windows.Forms.Label()
        FolioLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgv_lote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv_lotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(5, 52)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 0
        NombreLabel.Text = "Nombre:"
        '
        'FolioLabel
        '
        FolioLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FolioLabel.AutoSize = True
        FolioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FolioLabel.Location = New System.Drawing.Point(260, 12)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(49, 24)
        FolioLabel.TabIndex = 1
        FolioLabel.Text = "folio:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(907, 405)
        Me.SplitContainer1.SplitterDistance = 485
        Me.SplitContainer1.TabIndex = 0
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.imprimir)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
        Me.SplitContainer2.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.combopv)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv_doc)
        Me.SplitContainer2.Size = New System.Drawing.Size(485, 405)
        Me.SplitContainer2.SplitterDistance = 103
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(485, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Almacen.My.Resources.Resources.Printer
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(155, 36)
        Me.ToolStripButton1.Text = "Imprimir Documento"
        '
        'combopv
        '
        Me.combopv.DataSource = Me.ProveedoresBindingSource
        Me.combopv.DisplayMember = "Nombre"
        Me.combopv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combopv.FormattingEnabled = True
        Me.combopv.Location = New System.Drawing.Point(80, 49)
        Me.combopv.Name = "combopv"
        Me.combopv.Size = New System.Drawing.Size(390, 28)
        Me.combopv.TabIndex = 1
        Me.combopv.ValueMember = "Id"
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
        'dgv_doc
        '
        Me.dgv_doc.AllowUserToAddRows = False
        Me.dgv_doc.AllowUserToOrderColumns = True
        Me.dgv_doc.AllowUserToResizeColumns = False
        Me.dgv_doc.AllowUserToResizeRows = False
        Me.dgv_doc.AutoGenerateColumns = False
        Me.dgv_doc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_doc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvfolio, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgv_doc.DataSource = Me.Inv_documentosBindingSource
        Me.dgv_doc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_doc.Location = New System.Drawing.Point(0, 0)
        Me.dgv_doc.Name = "dgv_doc"
        Me.dgv_doc.RowHeadersVisible = False
        Me.dgv_doc.Size = New System.Drawing.Size(485, 298)
        Me.dgv_doc.TabIndex = 0
        '
        'dgvfolio
        '
        Me.dgvfolio.DataPropertyName = "folio"
        Me.dgvfolio.HeaderText = "folio"
        Me.dgvfolio.Name = "dgvfolio"
        Me.dgvfolio.ReadOnly = True
        Me.dgvfolio.Width = 51
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "F.Entrada"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_proveedor"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.ProveedoresBindingSource1
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn7.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "Id"
        Me.DataGridViewTextBoxColumn7.Width = 81
        '
        'ProveedoresBindingSource1
        '
        Me.ProveedoresBindingSource1.DataMember = "proveedores"
        Me.ProveedoresBindingSource1.DataSource = Me.ClinicaDataSet
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "factura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "factura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fecha_Factura"
        Me.DataGridViewTextBoxColumn9.HeaderText = "F.Factura"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 77
        '
        'Inv_documentosBindingSource
        '
        Me.Inv_documentosBindingSource.DataMember = "inv_documentos"
        Me.Inv_documentosBindingSource.DataSource = Me.ClinicaDataSet
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
        Me.SplitContainer3.Panel1.Controls.Add(FolioLabel)
        Me.SplitContainer3.Panel1.Controls.Add(Me.FolioTextBox)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.dgv_lote)
        Me.SplitContainer3.Size = New System.Drawing.Size(418, 405)
        Me.SplitContainer3.SplitterDistance = 45
        Me.SplitContainer3.TabIndex = 0
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inv_documentosBindingSource, "folio", True))
        Me.FolioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FolioTextBox.Location = New System.Drawing.Point(315, 9)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(100, 29)
        Me.FolioTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lotes en la factura"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(340, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Actualiza"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_lote
        '
        Me.dgv_lote.AllowUserToAddRows = False
        Me.dgv_lote.AllowUserToDeleteRows = False
        Me.dgv_lote.AllowUserToResizeColumns = False
        Me.dgv_lote.AllowUserToResizeRows = False
        Me.dgv_lote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_lote.AutoGenerateColumns = False
        Me.dgv_lote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_lote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewCheckBoxColumn1})
        Me.dgv_lote.DataSource = Me.Inv_lotesBindingSource
        Me.dgv_lote.Location = New System.Drawing.Point(0, 0)
        Me.dgv_lote.Name = "dgv_lote"
        Me.dgv_lote.RowHeadersVisible = False
        Me.dgv_lote.Size = New System.Drawing.Size(418, 312)
        Me.dgv_lote.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ProductosBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Descripcion"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prod"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id_producto"
        Me.DataGridViewTextBoxColumn3.Width = 54
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "lote"
        Me.DataGridViewTextBoxColumn17.HeaderText = "lote"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 49
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_entrada"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha_entrada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 101
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha_caducidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha_caducidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 115
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "tipo_entrada"
        Me.DataGridViewTextBoxColumn10.HeaderText = "tipo_entrada"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 91
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn11.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 73
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "comentario"
        Me.DataGridViewTextBoxColumn12.HeaderText = "comentario"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 84
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "usados"
        Me.DataGridViewTextBoxColumn13.HeaderText = "usados"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 66
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "caducados"
        Me.DataGridViewTextBoxColumn14.HeaderText = "caducados"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 85
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn15.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 51
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 58
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "libro"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "libro"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 32
        '
        'Inv_lotesBindingSource
        '
        Me.Inv_lotesBindingSource.DataMember = "inv_lotes"
        Me.Inv_lotesBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Inv_documentosTableAdapter
        '
        Me.Inv_documentosTableAdapter.ClearBeforeFill = True
        '
        'Inv_lotesTableAdapter
        '
        Me.Inv_lotesTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.Binoculars
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(95, 36)
        Me.ToolStripButton2.Text = "Ver Todas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'imprimir
        '
        Me.imprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imprimir.AutoSize = True
        Me.imprimir.Location = New System.Drawing.Point(372, 83)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(98, 17)
        Me.imprimir.TabIndex = 3
        Me.imprimir.Text = "Imprimir Directo"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Entrasdas_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 405)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Entrasdas_consulta"
        Me.Text = "Entrasdas_consulta"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_documentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgv_lote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv_lotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents Inv_documentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_documentosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_documentosTableAdapter
    Friend WithEvents dgv_doc As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents Inv_lotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_lotesTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_lotesTableAdapter
    Friend WithEvents dgv_lote As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Almacen.clinicaDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents combopv As System.Windows.Forms.ComboBox
    Friend WithEvents ProveedoresBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dgvfolio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents imprimir As System.Windows.Forms.CheckBox
End Class
