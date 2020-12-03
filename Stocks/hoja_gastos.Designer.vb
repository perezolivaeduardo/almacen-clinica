<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoja_gastos
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
        Me.sql_alma_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sql_alma_stocksTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_alma_stocksTableAdapter
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sql_alma_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_sql_alma_stocks"
        ReportDataSource1.Value = Me.sql_alma_stocksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Hoja_de_gastos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(477, 377)
        Me.ReportViewer1.TabIndex = 0
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sql_alma_stocksBindingSource
        '
        Me.sql_alma_stocksBindingSource.DataMember = "sql_alma_stocks"
        Me.sql_alma_stocksBindingSource.DataSource = Me.clinicaDataSet
        '
        'sql_alma_stocksTableAdapter
        '
        Me.sql_alma_stocksTableAdapter.ClearBeforeFill = True
        '
        'hoja_gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 377)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "hoja_gastos"
        Me.Text = "hoja_gastos"
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sql_alma_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_alma_stocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents sql_alma_stocksTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_alma_stocksTableAdapter
End Class
