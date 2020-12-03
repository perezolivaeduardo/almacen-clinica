<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventarios_hojas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.inv_lista_productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicaDataSet = New Almacen.clinicaDataSet()
        Me.sql_alma_productos_XareaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inv_lista_productosTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_lista_productosTableAdapter()
        Me.sql_alma_productos_XareaTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_alma_productos_XareaTableAdapter()
        CType(Me.inv_lista_productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sql_alma_productos_XareaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inv_lista_productosBindingSource
        '
        Me.inv_lista_productosBindingSource.DataMember = "inv_lista_productos"
        Me.inv_lista_productosBindingSource.DataSource = Me.clinicaDataSet
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_alma_productos_XareaBindingSource
        '
        Me.sql_alma_productos_XareaBindingSource.DataMember = "sql_alma_productos_Xarea"
        Me.sql_alma_productos_XareaBindingSource.DataSource = Me.clinicaDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_inv_lista_productos"
        ReportDataSource1.Value = Me.inv_lista_productosBindingSource
        ReportDataSource2.Name = "clinicaDataSet_sql_alma_productos_Xarea"
        ReportDataSource2.Value = Me.sql_alma_productos_XareaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.lista_para_inventarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(730, 347)
        Me.ReportViewer1.TabIndex = 0
        '
        'inv_lista_productosTableAdapter
        '
        Me.inv_lista_productosTableAdapter.ClearBeforeFill = True
        '
        'sql_alma_productos_XareaTableAdapter
        '
        Me.sql_alma_productos_XareaTableAdapter.ClearBeforeFill = True
        '
        'inventarios_hojas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 347)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "inventarios_hojas"
        Me.Text = "inventarios_hojas"
        CType(Me.inv_lista_productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sql_alma_productos_XareaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inv_lista_productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents sql_alma_productos_XareaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents inv_lista_productosTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_lista_productosTableAdapter
    Friend WithEvents sql_alma_productos_XareaTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_alma_productos_XareaTableAdapter
End Class
