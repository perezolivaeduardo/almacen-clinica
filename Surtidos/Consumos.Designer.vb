<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consumos
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.sql_alma_productos_XareaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicaDataSet = New Almacen.clinicaDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Filtrar_area = New System.Windows.Forms.CheckBox
        Me.descripciontxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.boton_quitar_filtros = New System.Windows.Forms.Button
        Me.AreaComboBox = New System.Windows.Forms.ComboBox
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.sql_alma_productos_XareaTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_alma_productos_XareaTableAdapter
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.sql_alma_productos_XareaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sql_alma_productos_XareaBindingSource
        '
        Me.sql_alma_productos_XareaBindingSource.DataMember = "sql_alma_productos_Xarea"
        Me.sql_alma_productos_XareaBindingSource.DataSource = Me.clinicaDataSet
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Filtrar_area)
        Me.SplitContainer1.Panel1.Controls.Add(Me.descripciontxt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_quitar_filtros)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AreaComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(899, 414)
        Me.SplitContainer1.SplitterDistance = 59
        Me.SplitContainer1.TabIndex = 0
        '
        'Filtrar_area
        '
        Me.Filtrar_area.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Filtrar_area.AutoSize = True
        Me.Filtrar_area.Location = New System.Drawing.Point(607, 8)
        Me.Filtrar_area.Name = "Filtrar_area"
        Me.Filtrar_area.Size = New System.Drawing.Size(99, 17)
        Me.Filtrar_area.TabIndex = 8
        Me.Filtrar_area.Text = "Filtrar por area :"
        Me.Filtrar_area.UseVisualStyleBackColor = True
        '
        'descripciontxt
        '
        Me.descripciontxt.Location = New System.Drawing.Point(96, 32)
        Me.descripciontxt.Name = "descripciontxt"
        Me.descripciontxt.Size = New System.Drawing.Size(185, 20)
        Me.descripciontxt.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Filtrar Producto : "
        '
        'boton_quitar_filtros
        '
        Me.boton_quitar_filtros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_quitar_filtros.Location = New System.Drawing.Point(781, 33)
        Me.boton_quitar_filtros.Name = "boton_quitar_filtros"
        Me.boton_quitar_filtros.Size = New System.Drawing.Size(106, 23)
        Me.boton_quitar_filtros.TabIndex = 5
        Me.boton_quitar_filtros.Text = "Quitar Filtro"
        Me.boton_quitar_filtros.UseVisualStyleBackColor = True
        '
        'AreaComboBox
        '
        Me.AreaComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AreaComboBox.DataSource = Me.AreasBindingSource
        Me.AreaComboBox.DisplayMember = "area"
        Me.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaComboBox.Enabled = False
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(709, 6)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(178, 21)
        Me.AreaComboBox.TabIndex = 4
        Me.AreaComboBox.ValueMember = "area"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.clinicaDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 20)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cargar Movimientos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha :"
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(61, 9)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(97, 20)
        Me.del.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(899, 351)
        Me.dgv.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "clinicaDataSet_sql_alma_productos_Xarea"
        ReportDataSource1.Value = Me.sql_alma_productos_XareaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 15)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(122, 94)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_alma_productos_XareaTableAdapter
        '
        Me.sql_alma_productos_XareaTableAdapter.ClearBeforeFill = True
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(287, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 20)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cargar Movimientos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Consumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 414)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Consumos"
        Me.Text = "Consumos"
        CType(Me.sql_alma_productos_XareaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_alma_productos_XareaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents sql_alma_productos_XareaTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_alma_productos_XareaTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents boton_quitar_filtros As System.Windows.Forms.Button
    Friend WithEvents descripciontxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Filtrar_area As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
