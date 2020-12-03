<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventarios_movimientos
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.InvsqldocumentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.inv_sql_surtidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inv_sql_documentosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_documentosTableAdapter
        Me.inv_sql_surtidoTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New Almacen.clinicaDataSetTableAdapters.areasTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.InvtipostipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvsqldocumentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(685, 411)
        Me.SplitContainer1.SplitterDistance = 307
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComboBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Size = New System.Drawing.Size(307, 411)
        Me.SplitContainer2.SplitterDistance = 85
        Me.SplitContainer2.TabIndex = 0
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.InvtipostipoDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.area, Me.FechaDataGridViewTextBoxColumn})
        Me.dgv.DataSource = Me.InvsqldocumentosBindingSource
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(307, 322)
        Me.dgv.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "clinicaDataSet_inv_sql_surtido"
        ReportDataSource6.Value = Me.inv_sql_surtidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.hoja_entrega.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(374, 411)
        Me.ReportViewer1.TabIndex = 0
        '
        'InvsqldocumentosBindingSource
        '
        Me.InvsqldocumentosBindingSource.DataMember = "inv_sql_documentos"
        Me.InvsqldocumentosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'inv_sql_surtidoBindingSource
        '
        Me.inv_sql_surtidoBindingSource.DataMember = "inv_sql_surtido"
        Me.inv_sql_surtidoBindingSource.DataSource = Me.ClinicaDataSet
        '
        'Inv_sql_documentosTableAdapter
        '
        Me.Inv_sql_documentosTableAdapter.ClearBeforeFill = True
        '
        'inv_sql_surtidoTableAdapter
        '
        Me.inv_sql_surtidoTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.AreasBindingSource
        Me.ComboBox1.DisplayMember = "area"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(75, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "area"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Area :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 43)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha :"
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        Me.Id.Width = 41
        '
        'InvtipostipoDataGridViewTextBoxColumn
        '
        Me.InvtipostipoDataGridViewTextBoxColumn.DataPropertyName = "inv_tipos_tipo"
        Me.InvtipostipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.InvtipostipoDataGridViewTextBoxColumn.Name = "InvtipostipoDataGridViewTextBoxColumn"
        Me.InvtipostipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvtipostipoDataGridViewTextBoxColumn.Width = 53
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioDataGridViewTextBoxColumn.Width = 51
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "area"
        Me.area.Name = "area"
        Me.area.ReadOnly = True
        Me.area.Width = 53
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 59
        '
        'inventarios_movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 411)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "inventarios_movimientos"
        Me.Text = "inventarios_movimientos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvsqldocumentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents InvsqldocumentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_sql_documentosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_documentosTableAdapter
    Friend WithEvents inv_sql_surtidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inv_sql_surtidoTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Almacen.clinicaDataSetTableAdapters.areasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvtipostipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
