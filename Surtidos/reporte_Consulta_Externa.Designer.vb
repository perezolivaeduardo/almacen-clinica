<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_Consulta_Externa
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clinicaDataSet = New Almacen.clinicaDataSet
        Me.inv_resumen_consumo_consulta_externaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inv_resumen_consumo_consulta_externaTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_resumen_consumo_consulta_externaTableAdapter
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inv_resumen_consumo_consulta_externaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_inv_resumen_consumo_consulta_externa"
        ReportDataSource1.Value = Me.inv_resumen_consumo_consulta_externaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.reporte_consulta_externa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(532, 430)
        Me.ReportViewer1.TabIndex = 0
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'inv_resumen_consumo_consulta_externaBindingSource
        '
        Me.inv_resumen_consumo_consulta_externaBindingSource.DataMember = "inv_resumen_consumo_consulta_externa"
        Me.inv_resumen_consumo_consulta_externaBindingSource.DataSource = Me.clinicaDataSet
        '
        'inv_resumen_consumo_consulta_externaTableAdapter
        '
        Me.inv_resumen_consumo_consulta_externaTableAdapter.ClearBeforeFill = True
        '
        'reporte_Consulta_Externa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 430)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reporte_Consulta_Externa"
        Me.Text = "Consumo Consulta Externa"
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inv_resumen_consumo_consulta_externaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inv_resumen_consumo_consulta_externaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents inv_resumen_consumo_consulta_externaTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_resumen_consumo_consulta_externaTableAdapter
End Class
