<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir_salida
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.clinicaDataSet = New Almacen.clinicaDataSet()
        Me.inv_sql_surtidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.inv_sql_surtidoTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_inv_sql_surtido"
        ReportDataSource1.Value = Me.inv_sql_surtidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.salida_de_almacen.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(834, 571)
        Me.ReportViewer1.TabIndex = 9
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'inv_sql_surtidoBindingSource
        '
        Me.inv_sql_surtidoBindingSource.DataMember = "inv_sql_surtido"
        Me.inv_sql_surtidoBindingSource.DataSource = Me.clinicaDataSet
        '
        'inv_sql_surtidoTableAdapter
        '
        Me.inv_sql_surtidoTableAdapter.ClearBeforeFill = True
        '
        'imprimir_salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 571)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "imprimir_salida"
        Me.Text = "imprimir_salida"
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inv_sql_surtidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents inv_sql_surtidoTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter
End Class
