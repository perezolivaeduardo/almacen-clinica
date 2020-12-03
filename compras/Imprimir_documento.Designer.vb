<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Imprimir_documento
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
        Me.sql_entradas_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicaDataSet = New Almacen.clinicaDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sql_entradas_detalleTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_entradas_detalleTableAdapter()
        CType(Me.sql_entradas_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sql_entradas_detalleBindingSource
        '
        Me.sql_entradas_detalleBindingSource.DataMember = "sql_entradas_detalle"
        Me.sql_entradas_detalleBindingSource.DataSource = Me.clinicaDataSet
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sql_entradas_detalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.ENTRADA.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(545, 356)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_entradas_detalleTableAdapter
        '
        Me.sql_entradas_detalleTableAdapter.ClearBeforeFill = True
        '
        'Imprimir_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 356)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Imprimir_documento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ENTRADA DE ALMACEN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.sql_entradas_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_entradas_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents sql_entradas_detalleTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_entradas_detalleTableAdapter
End Class
