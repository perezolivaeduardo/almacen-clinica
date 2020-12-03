<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos_modificar
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
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim NicknameLabel As System.Windows.Forms.Label
        Dim PrecentacionLabel As System.Windows.Forms.Label
        Dim EmpaqueLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim VentaLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim Descripcion_facturaLabel As System.Windows.Forms.Label
        Dim ViadeadministracionLabel As System.Windows.Forms.Label
        Dim Clave_satLabel As System.Windows.Forms.Label
        Dim Unidad_satLabel As System.Windows.Forms.Label
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NicknameTextBox = New System.Windows.Forms.TextBox()
        Me.PrecentacionTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.VentaTextBox = New System.Windows.Forms.TextBox()
        Me.Control_caducidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConsignaCheckBox = New System.Windows.Forms.CheckBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Descripcion_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.ViadeadministracionTextBox = New System.Windows.Forms.TextBox()
        Me.NofacturarCheckBox = New System.Windows.Forms.CheckBox()
        Me.Clave_satTextBox = New System.Windows.Forms.TextBox()
        Me.Unidad_satTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.EmpaqueTextBox = New System.Windows.Forms.TextBox()
        Id_productoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        NicknameLabel = New System.Windows.Forms.Label()
        PrecentacionLabel = New System.Windows.Forms.Label()
        EmpaqueLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        VentaLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        Descripcion_facturaLabel = New System.Windows.Forms.Label()
        ViadeadministracionLabel = New System.Windows.Forms.Label()
        Clave_satLabel = New System.Windows.Forms.Label()
        Unidad_satLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Location = New System.Drawing.Point(570, 15)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(86, 18)
        Id_productoLabel.TabIndex = 1
        Id_productoLabel.Text = "id producto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(54, 86)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(91, 18)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'NicknameLabel
        '
        NicknameLabel.AutoSize = True
        NicknameLabel.Location = New System.Drawing.Point(69, 116)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New System.Drawing.Size(76, 18)
        NicknameLabel.TabIndex = 5
        NicknameLabel.Text = "nickname:"
        '
        'PrecentacionLabel
        '
        PrecentacionLabel.AutoSize = True
        PrecentacionLabel.Location = New System.Drawing.Point(46, 152)
        PrecentacionLabel.Name = "PrecentacionLabel"
        PrecentacionLabel.Size = New System.Drawing.Size(99, 18)
        PrecentacionLabel.TabIndex = 7
        PrecentacionLabel.Text = "Precentacion:"
        '
        'EmpaqueLabel
        '
        EmpaqueLabel.AutoSize = True
        EmpaqueLabel.Location = New System.Drawing.Point(226, 152)
        EmpaqueLabel.Name = "EmpaqueLabel"
        EmpaqueLabel.Size = New System.Drawing.Size(75, 18)
        EmpaqueLabel.TabIndex = 9
        EmpaqueLabel.Text = "Empaque:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(430, 152)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(50, 18)
        CostoLabel.TabIndex = 11
        CostoLabel.Text = "costo:"
        '
        'VentaLabel
        '
        VentaLabel.AutoSize = True
        VentaLabel.Location = New System.Drawing.Point(609, 152)
        VentaLabel.Name = "VentaLabel"
        VentaLabel.Size = New System.Drawing.Size(47, 18)
        VentaLabel.TabIndex = 13
        VentaLabel.Text = "venta:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(575, 201)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(30, 18)
        IvaLabel.TabIndex = 19
        IvaLabel.Text = "iva:"
        '
        'Descripcion_facturaLabel
        '
        Descripcion_facturaLabel.AutoSize = True
        Descripcion_facturaLabel.Location = New System.Drawing.Point(10, 40)
        Descripcion_facturaLabel.Name = "Descripcion_facturaLabel"
        Descripcion_facturaLabel.Size = New System.Drawing.Size(140, 18)
        Descripcion_facturaLabel.TabIndex = 21
        Descripcion_facturaLabel.Text = "Descripcion factura:"
        '
        'ViadeadministracionLabel
        '
        ViadeadministracionLabel.AutoSize = True
        ViadeadministracionLabel.Location = New System.Drawing.Point(46, 201)
        ViadeadministracionLabel.Name = "ViadeadministracionLabel"
        ViadeadministracionLabel.Size = New System.Drawing.Size(157, 18)
        ViadeadministracionLabel.TabIndex = 23
        ViadeadministracionLabel.Text = "Via de Administracion :"
        '
        'Clave_satLabel
        '
        Clave_satLabel.AutoSize = True
        Clave_satLabel.Location = New System.Drawing.Point(77, 70)
        Clave_satLabel.Name = "Clave_satLabel"
        Clave_satLabel.Size = New System.Drawing.Size(73, 18)
        Clave_satLabel.TabIndex = 27
        Clave_satLabel.Text = "Clave sat:"
        '
        'Unidad_satLabel
        '
        Unidad_satLabel.AutoSize = True
        Unidad_satLabel.Location = New System.Drawing.Point(68, 103)
        Unidad_satLabel.Name = "Unidad_satLabel"
        Unidad_satLabel.Size = New System.Drawing.Size(82, 18)
        Unidad_satLabel.TabIndex = 29
        Unidad_satLabel.Text = "Unidad sat:"
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Enabled = False
        Me.Id_productoTextBox.Location = New System.Drawing.Point(662, 12)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Id_productoTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(151, 83)
        Me.DescripcionTextBox.MaxLength = 50
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(611, 24)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nickname", True))
        Me.NicknameTextBox.Location = New System.Drawing.Point(151, 113)
        Me.NicknameTextBox.MaxLength = 50
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(611, 24)
        Me.NicknameTextBox.TabIndex = 6
        '
        'PrecentacionTextBox
        '
        Me.PrecentacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Precentacion", True))
        Me.PrecentacionTextBox.Location = New System.Drawing.Point(151, 149)
        Me.PrecentacionTextBox.Name = "PrecentacionTextBox"
        Me.PrecentacionTextBox.Size = New System.Drawing.Size(62, 24)
        Me.PrecentacionTextBox.TabIndex = 8
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(486, 149)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(100, 24)
        Me.CostoTextBox.TabIndex = 12
        Me.CostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VentaTextBox
        '
        Me.VentaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "venta", True))
        Me.VentaTextBox.Location = New System.Drawing.Point(662, 149)
        Me.VentaTextBox.Name = "VentaTextBox"
        Me.VentaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.VentaTextBox.TabIndex = 14
        Me.VentaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Control_caducidadCheckBox
        '
        Me.Control_caducidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "control_caducidad", True))
        Me.Control_caducidadCheckBox.Location = New System.Drawing.Point(323, 198)
        Me.Control_caducidadCheckBox.Name = "Control_caducidadCheckBox"
        Me.Control_caducidadCheckBox.Size = New System.Drawing.Size(157, 24)
        Me.Control_caducidadCheckBox.TabIndex = 16
        Me.Control_caducidadCheckBox.Text = "Control Caducidad"
        Me.Control_caducidadCheckBox.UseVisualStyleBackColor = True
        '
        'ConsignaCheckBox
        '
        Me.ConsignaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "consigna", True))
        Me.ConsignaCheckBox.Location = New System.Drawing.Point(482, 198)
        Me.ConsignaCheckBox.Name = "ConsignaCheckBox"
        Me.ConsignaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ConsignaCheckBox.TabIndex = 18
        Me.ConsignaCheckBox.Text = "Consigna"
        Me.ConsignaCheckBox.UseVisualStyleBackColor = True
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(611, 198)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(29, 24)
        Me.IvaTextBox.TabIndex = 20
        '
        'Descripcion_facturaTextBox
        '
        Me.Descripcion_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "descripcion_factura", True))
        Me.Descripcion_facturaTextBox.Location = New System.Drawing.Point(151, 37)
        Me.Descripcion_facturaTextBox.MaxLength = 50
        Me.Descripcion_facturaTextBox.Name = "Descripcion_facturaTextBox"
        Me.Descripcion_facturaTextBox.Size = New System.Drawing.Size(549, 24)
        Me.Descripcion_facturaTextBox.TabIndex = 22
        '
        'ViadeadministracionTextBox
        '
        Me.ViadeadministracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "viadeadministracion", True))
        Me.ViadeadministracionTextBox.Location = New System.Drawing.Point(206, 198)
        Me.ViadeadministracionTextBox.Name = "ViadeadministracionTextBox"
        Me.ViadeadministracionTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ViadeadministracionTextBox.TabIndex = 24
        '
        'NofacturarCheckBox
        '
        Me.NofacturarCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductosBindingSource, "nofacturar", True))
        Me.NofacturarCheckBox.Location = New System.Drawing.Point(151, 127)
        Me.NofacturarCheckBox.Name = "NofacturarCheckBox"
        Me.NofacturarCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.NofacturarCheckBox.TabIndex = 26
        Me.NofacturarCheckBox.Text = "No Faturar "
        Me.NofacturarCheckBox.UseVisualStyleBackColor = True
        '
        'Clave_satTextBox
        '
        Me.Clave_satTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "clave_sat", True))
        Me.Clave_satTextBox.Location = New System.Drawing.Point(151, 67)
        Me.Clave_satTextBox.MaxLength = 8
        Me.Clave_satTextBox.Name = "Clave_satTextBox"
        Me.Clave_satTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Clave_satTextBox.TabIndex = 28
        '
        'Unidad_satTextBox
        '
        Me.Unidad_satTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "unidad_sat", True))
        Me.Unidad_satTextBox.Location = New System.Drawing.Point(151, 97)
        Me.Unidad_satTextBox.MaxLength = 3
        Me.Unidad_satTextBox.Name = "Unidad_satTextBox"
        Me.Unidad_satTextBox.Size = New System.Drawing.Size(48, 24)
        Me.Unidad_satTextBox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Descripcion_facturaTextBox)
        Me.GroupBox1.Controls.Add(Unidad_satLabel)
        Me.GroupBox1.Controls.Add(Descripcion_facturaLabel)
        Me.GroupBox1.Controls.Add(Me.Unidad_satTextBox)
        Me.GroupBox1.Controls.Add(Me.NofacturarCheckBox)
        Me.GroupBox1.Controls.Add(Clave_satLabel)
        Me.GroupBox1.Controls.Add(Me.Clave_satTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 162)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Facturacion."
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(687, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(606, 405)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'EmpaqueTextBox
        '
        Me.EmpaqueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Empaque", True))
        Me.EmpaqueTextBox.Location = New System.Drawing.Point(307, 149)
        Me.EmpaqueTextBox.Name = "EmpaqueTextBox"
        Me.EmpaqueTextBox.Size = New System.Drawing.Size(100, 24)
        Me.EmpaqueTextBox.TabIndex = 34
        '
        'Productos_modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(791, 469)
        Me.Controls.Add(Me.EmpaqueTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(ViadeadministracionLabel)
        Me.Controls.Add(Me.ViadeadministracionTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(Me.ConsignaCheckBox)
        Me.Controls.Add(Me.Control_caducidadCheckBox)
        Me.Controls.Add(VentaLabel)
        Me.Controls.Add(Me.VentaTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(EmpaqueLabel)
        Me.Controls.Add(PrecentacionLabel)
        Me.Controls.Add(Me.PrecentacionTextBox)
        Me.Controls.Add(NicknameLabel)
        Me.Controls.Add(Me.NicknameTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Id_productoLabel)
        Me.Controls.Add(Me.Id_productoTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Productos_modificar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos_modificar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents Id_productoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicknameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecentacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VentaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Control_caducidadCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ConsignaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents IvaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ViadeadministracionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NofacturarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Clave_satTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Unidad_satTextBox As System.Windows.Forms.TextBox
    Private WithEvents Descripcion_facturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EmpaqueTextBox As System.Windows.Forms.TextBox
End Class
