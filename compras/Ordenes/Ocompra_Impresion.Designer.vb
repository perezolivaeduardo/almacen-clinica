<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ocompra_Impresion
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
        Me.OcompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdenesDS = New Almacen.OrdenesDS()
        Me.Ocompra_detalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.OcompraTableAdapter = New Almacen.OrdenesDSTableAdapters.OcompraTableAdapter()
        Me.Ocompra_detalleTableAdapter = New Almacen.OrdenesDSTableAdapters.Ocompra_detalleTableAdapter()
        Me.numero = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.OcompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdenesDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ocompra_detalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Ocompra_detalleBindingSource
        '
        Me.Ocompra_detalleBindingSource.DataMember = "Ocompra_detalle"
        Me.Ocompra_detalleBindingSource.DataSource = Me.OrdenesDS
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OcompraBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.Ocompra_detalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.OrdendeCompra.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(21, 39)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(895, 562)
        Me.ReportViewer1.TabIndex = 0
        '
        'OcompraTableAdapter
        '
        Me.OcompraTableAdapter.ClearBeforeFill = True
        '
        'Ocompra_detalleTableAdapter
        '
        Me.Ocompra_detalleTableAdapter.ClearBeforeFill = True
        '
        'numero
        '
        Me.numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numero.Location = New System.Drawing.Point(21, 639)
        Me.numero.Name = "numero"
        Me.numero.Size = New System.Drawing.Size(100, 20)
        Me.numero.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(127, 636)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ocompra_Impresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 671)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numero)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Ocompra_Impresion"
        Me.Text = "Ocompra_Impresion"
        CType(Me.OcompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdenesDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ocompra_detalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents OcompraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdenesDS As Almacen.OrdenesDS
    Friend WithEvents Ocompra_detalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OcompraTableAdapter As Almacen.OrdenesDSTableAdapters.OcompraTableAdapter
    Friend WithEvents Ocompra_detalleTableAdapter As Almacen.OrdenesDSTableAdapters.Ocompra_detalleTableAdapter
    Friend WithEvents numero As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
