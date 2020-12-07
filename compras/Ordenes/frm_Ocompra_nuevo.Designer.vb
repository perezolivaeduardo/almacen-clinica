<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ocompra_nuevo
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
        Dim Id_provedorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Nombre_contactoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CondicionescompraLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim Fecha_limite_entregaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.OcompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesDS = New Almacen.OrdenesDS()
        Me.Id_provedorTextBox = New System.Windows.Forms.TextBox()
        Me.nombre_proveedor = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Nombre_contactoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.FechaCapturaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_usuario_capturaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_usuario_modificaTextBox = New System.Windows.Forms.TextBox()
        Me.FehcaModificacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CondicionescompraTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_limite_entregaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Ocompra_detalleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ocompra_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OcompraTableAdapter = New Almacen.OrdenesDSTableAdapters.OcompraTableAdapter()
        Me.TableAdapterManager = New Almacen.OrdenesDSTableAdapters.TableAdapterManager()
        Me.Ocompra_detalleTableAdapter = New Almacen.OrdenesDSTableAdapters.Ocompra_detalleTableAdapter()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Id_provedorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Nombre_contactoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CondicionescompraLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Fecha_limite_entregaLabel = New System.Windows.Forms.Label()
        CType(Me.OcompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ocompra_detalleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ocompra_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(1004, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(89, 24)
        IdLabel.TabIndex = 1
        IdLabel.Text = "# Orden :"
        '
        'Id_provedorLabel
        '
        Id_provedorLabel.AutoSize = True
        Id_provedorLabel.Location = New System.Drawing.Point(12, 18)
        Id_provedorLabel.Name = "Id_provedorLabel"
        Id_provedorLabel.Size = New System.Drawing.Size(108, 24)
        Id_provedorLabel.TabIndex = 2
        Id_provedorLabel.Text = "Proveedor :"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(51, 56)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(69, 24)
        FechaLabel.TabIndex = 6
        FechaLabel.Text = "Fecha:"
        '
        'Nombre_contactoLabel
        '
        Nombre_contactoLabel.AutoSize = True
        Nombre_contactoLabel.Location = New System.Drawing.Point(31, 91)
        Nombre_contactoLabel.Name = "Nombre_contactoLabel"
        Nombre_contactoLabel.Size = New System.Drawing.Size(89, 24)
        Nombre_contactoLabel.TabIndex = 8
        Nombre_contactoLabel.Text = "Contacto:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(788, 94)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(90, 24)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'CondicionescompraLabel
        '
        CondicionescompraLabel.AutoSize = True
        CondicionescompraLabel.Location = New System.Drawing.Point(31, 134)
        CondicionescompraLabel.Name = "CondicionescompraLabel"
        CondicionescompraLabel.Size = New System.Drawing.Size(220, 24)
        CondicionescompraLabel.TabIndex = 16
        CondicionescompraLabel.Text = "Condiciones de Compra:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(24, 186)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(121, 24)
        ComentariosLabel.TabIndex = 18
        ComentariosLabel.Text = "Comentarios:"
        '
        'Fecha_limite_entregaLabel
        '
        Fecha_limite_entregaLabel.AutoSize = True
        Fecha_limite_entregaLabel.Location = New System.Drawing.Point(432, 134)
        Fecha_limite_entregaLabel.Name = "Fecha_limite_entregaLabel"
        Fecha_limite_entregaLabel.Size = New System.Drawing.Size(188, 24)
        Fecha_limite_entregaLabel.TabIndex = 20
        Fecha_limite_entregaLabel.Text = "Fecha limite Entrega:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "Id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(1099, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 29)
        Me.IdTextBox.TabIndex = 2
        '
        'OcompraBindingSource
        '
        Me.OcompraBindingSource.DataMember = "Ocompra"
        Me.OcompraBindingSource.DataSource = Me.OrdenesDS
        '
        'OrdenesDS
        '
        Me.OrdenesDS.DataSetName = "OrdenesDS"
        Me.OrdenesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_provedorTextBox
        '
        Me.Id_provedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "id_provedor", True))
        Me.Id_provedorTextBox.Enabled = False
        Me.Id_provedorTextBox.Location = New System.Drawing.Point(126, 17)
        Me.Id_provedorTextBox.Name = "Id_provedorTextBox"
        Me.Id_provedorTextBox.Size = New System.Drawing.Size(63, 29)
        Me.Id_provedorTextBox.TabIndex = 3
        '
        'nombre_proveedor
        '
        Me.nombre_proveedor.Enabled = False
        Me.nombre_proveedor.Location = New System.Drawing.Point(195, 17)
        Me.nombre_proveedor.Name = "nombre_proveedor"
        Me.nombre_proveedor.Size = New System.Drawing.Size(585, 29)
        Me.nombre_proveedor.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(786, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OcompraBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(126, 52)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(142, 29)
        Me.FechaDateTimePicker.TabIndex = 7
        '
        'Nombre_contactoTextBox
        '
        Me.Nombre_contactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "nombre_contacto", True))
        Me.Nombre_contactoTextBox.Location = New System.Drawing.Point(126, 91)
        Me.Nombre_contactoTextBox.MaxLength = 30
        Me.Nombre_contactoTextBox.Name = "Nombre_contactoTextBox"
        Me.Nombre_contactoTextBox.Size = New System.Drawing.Size(654, 29)
        Me.Nombre_contactoTextBox.TabIndex = 9
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(884, 91)
        Me.TelefonoTextBox.MaxLength = 20
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(153, 29)
        Me.TelefonoTextBox.TabIndex = 11
        '
        'FechaCapturaTextBox
        '
        Me.FechaCapturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "fechaCaptura", True))
        Me.FechaCapturaTextBox.Enabled = False
        Me.FechaCapturaTextBox.Location = New System.Drawing.Point(5, 645)
        Me.FechaCapturaTextBox.Name = "FechaCapturaTextBox"
        Me.FechaCapturaTextBox.Size = New System.Drawing.Size(104, 29)
        Me.FechaCapturaTextBox.TabIndex = 13
        '
        'Id_usuario_capturaTextBox
        '
        Me.Id_usuario_capturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "id_usuario_captura", True))
        Me.Id_usuario_capturaTextBox.Enabled = False
        Me.Id_usuario_capturaTextBox.Location = New System.Drawing.Point(115, 645)
        Me.Id_usuario_capturaTextBox.Name = "Id_usuario_capturaTextBox"
        Me.Id_usuario_capturaTextBox.Size = New System.Drawing.Size(30, 29)
        Me.Id_usuario_capturaTextBox.TabIndex = 14
        '
        'Id_usuario_modificaTextBox
        '
        Me.Id_usuario_modificaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "id_usuario_modifica", True))
        Me.Id_usuario_modificaTextBox.Enabled = False
        Me.Id_usuario_modificaTextBox.Location = New System.Drawing.Point(151, 645)
        Me.Id_usuario_modificaTextBox.Name = "Id_usuario_modificaTextBox"
        Me.Id_usuario_modificaTextBox.Size = New System.Drawing.Size(30, 29)
        Me.Id_usuario_modificaTextBox.TabIndex = 15
        '
        'FehcaModificacionDateTimePicker
        '
        Me.FehcaModificacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OcompraBindingSource, "fehcaModificacion", True))
        Me.FehcaModificacionDateTimePicker.Enabled = False
        Me.FehcaModificacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FehcaModificacionDateTimePicker.Location = New System.Drawing.Point(187, 645)
        Me.FehcaModificacionDateTimePicker.Name = "FehcaModificacionDateTimePicker"
        Me.FehcaModificacionDateTimePicker.Size = New System.Drawing.Size(129, 29)
        Me.FehcaModificacionDateTimePicker.TabIndex = 16
        '
        'CondicionescompraTextBox
        '
        Me.CondicionescompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "Condicionescompra", True))
        Me.CondicionescompraTextBox.Location = New System.Drawing.Point(257, 134)
        Me.CondicionescompraTextBox.MaxLength = 20
        Me.CondicionescompraTextBox.Name = "CondicionescompraTextBox"
        Me.CondicionescompraTextBox.Size = New System.Drawing.Size(157, 29)
        Me.CondicionescompraTextBox.TabIndex = 17
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "Comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(151, 169)
        Me.ComentariosTextBox.MaxLength = 255
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(992, 74)
        Me.ComentariosTextBox.TabIndex = 19
        '
        'Fecha_limite_entregaDateTimePicker
        '
        Me.Fecha_limite_entregaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OcompraBindingSource, "fecha_limite_entrega", True))
        Me.Fecha_limite_entregaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha_limite_entregaDateTimePicker.Location = New System.Drawing.Point(629, 134)
        Me.Fecha_limite_entregaDateTimePicker.Name = "Fecha_limite_entregaDateTimePicker"
        Me.Fecha_limite_entregaDateTimePicker.Size = New System.Drawing.Size(151, 29)
        Me.Fecha_limite_entregaDateTimePicker.TabIndex = 22
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(30, 542)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(177, 42)
        Me.btn_agregar.TabIndex = 23
        Me.btn_agregar.Text = "Agregar Producto"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'Ocompra_detalleDataGridView
        '
        Me.Ocompra_detalleDataGridView.AllowUserToAddRows = False
        Me.Ocompra_detalleDataGridView.AllowUserToDeleteRows = False
        Me.Ocompra_detalleDataGridView.AllowUserToOrderColumns = True
        Me.Ocompra_detalleDataGridView.AllowUserToResizeColumns = False
        Me.Ocompra_detalleDataGridView.AllowUserToResizeRows = False
        Me.Ocompra_detalleDataGridView.AutoGenerateColumns = False
        Me.Ocompra_detalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Ocompra_detalleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Ocompra_detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ocompra_detalleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.importe})
        Me.Ocompra_detalleDataGridView.DataSource = Me.Ocompra_detalleBindingSource
        Me.Ocompra_detalleDataGridView.Location = New System.Drawing.Point(35, 263)
        Me.Ocompra_detalleDataGridView.Name = "Ocompra_detalleDataGridView"
        Me.Ocompra_detalleDataGridView.RowHeadersVisible = False
        Me.Ocompra_detalleDataGridView.Size = New System.Drawing.Size(1108, 273)
        Me.Ocompra_detalleDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 31
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "partida"
        Me.DataGridViewTextBoxColumn2.HeaderText = "partida"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 72
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 52
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precentacion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "precentacion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 145
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "empaque"
        Me.DataGridViewTextBoxColumn6.HeaderText = "empaque"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 116
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 106
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "unitario"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn8.HeaderText = "unitario"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 96
        '
        'importe
        '
        Me.importe.DataPropertyName = "importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.importe.DefaultCellStyle = DataGridViewCellStyle2
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        Me.importe.Width = 98
        '
        'Ocompra_detalleBindingSource
        '
        Me.Ocompra_detalleBindingSource.DataMember = "Ocompra_detalle"
        Me.Ocompra_detalleBindingSource.DataSource = Me.OrdenesDS
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(209, 542)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 42)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Inicializa Orden de Compra"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(926, 540)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Subtotal :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(902, 575)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descuento :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(948, 610)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 24)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "I.V.A. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(952, 642)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Total :"
        '
        'OcompraTableAdapter
        '
        Me.OcompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Ocompra_detalleTableAdapter = Me.Ocompra_detalleTableAdapter
        Me.TableAdapterManager.OcompraTableAdapter = Me.OcompraTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Almacen.OrdenesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Ocompra_detalleTableAdapter
        '
        Me.Ocompra_detalleTableAdapter.ClearBeforeFill = True
        '
        'txtsubtotal
        '
        Me.txtsubtotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "subtotal", True))
        Me.txtsubtotal.Location = New System.Drawing.Point(1019, 542)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(124, 29)
        Me.txtsubtotal.TabIndex = 33
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdescuento
        '
        Me.txtdescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "descuento", True))
        Me.txtdescuento.Location = New System.Drawing.Point(1019, 577)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(124, 29)
        Me.txtdescuento.TabIndex = 34
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtiva
        '
        Me.txtiva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "iva", True))
        Me.txtiva.Location = New System.Drawing.Point(1019, 610)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(124, 29)
        Me.txtiva.TabIndex = 35
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal
        '
        Me.txttotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OcompraBindingSource, "total", True))
        Me.txttotal.Location = New System.Drawing.Point(1019, 645)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(124, 29)
        Me.txttotal.TabIndex = 36
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(745, 624)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(177, 42)
        Me.btn_guardar.TabIndex = 37
        Me.btn_guardar.Text = "Guardar Orden"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'frm_Ocompra_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 682)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ocompra_detalleDataGridView)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Fecha_limite_entregaDateTimePicker)
        Me.Controls.Add(Fecha_limite_entregaLabel)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Controls.Add(CondicionescompraLabel)
        Me.Controls.Add(Me.CondicionescompraTextBox)
        Me.Controls.Add(Me.FehcaModificacionDateTimePicker)
        Me.Controls.Add(Me.Id_usuario_modificaTextBox)
        Me.Controls.Add(Me.Id_usuario_capturaTextBox)
        Me.Controls.Add(Me.FechaCapturaTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(Nombre_contactoLabel)
        Me.Controls.Add(Me.Nombre_contactoTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nombre_proveedor)
        Me.Controls.Add(Id_provedorLabel)
        Me.Controls.Add(Me.Id_provedorTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_Ocompra_nuevo"
        Me.Text = "Orden de Compra"
        CType(Me.OcompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ocompra_detalleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ocompra_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrdenesDS As Almacen.OrdenesDS
    Friend WithEvents OcompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OcompraTableAdapter As Almacen.OrdenesDSTableAdapters.OcompraTableAdapter
    Friend WithEvents TableAdapterManager As Almacen.OrdenesDSTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_provedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nombre_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Nombre_contactoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaCapturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_usuario_capturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_usuario_modificaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FehcaModificacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CondicionescompraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_limite_entregaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Ocompra_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ocompra_detalleTableAdapter As Almacen.OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
    Friend WithEvents Ocompra_detalleDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
End Class
