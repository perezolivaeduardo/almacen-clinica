<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultar_consumo_de_consumibles
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
        Me.inv_resumen_consumo_hojas_cerradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicaDataSet = New Almacen.clinicaDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label2 = New System.Windows.Forms.Label
        Me.salir = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.al = New System.Windows.Forms.DateTimePicker
        Me.del = New System.Windows.Forms.DateTimePicker
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.inv_resumen_consumo_hojas_cerradasTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_resumen_consumo_hojas_cerradasTableAdapter
        CType(Me.inv_resumen_consumo_hojas_cerradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'inv_resumen_consumo_hojas_cerradasBindingSource
        '
        Me.inv_resumen_consumo_hojas_cerradasBindingSource.DataMember = "inv_resumen_consumo_hojas_cerradas"
        Me.inv_resumen_consumo_hojas_cerradasBindingSource.DataSource = Me.clinicaDataSet
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.del)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(647, 333)
        Me.SplitContainer1.SplitterDistance = 42
        Me.SplitContainer1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "al"
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(535, 14)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 4
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo :"
        '
        'al
        '
        Me.al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.al.Location = New System.Drawing.Point(208, 14)
        Me.al.Name = "al"
        Me.al.Size = New System.Drawing.Size(104, 20)
        Me.al.TabIndex = 1
        '
        'del
        '
        Me.del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.del.Location = New System.Drawing.Point(67, 14)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(104, 20)
        Me.del.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_inv_resumen_consumo_hojas_cerradas"
        ReportDataSource1.Value = Me.inv_resumen_consumo_hojas_cerradasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.reporte_de_consumibles.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(647, 287)
        Me.ReportViewer1.TabIndex = 0
        '
        'inv_resumen_consumo_hojas_cerradasTableAdapter
        '
        Me.inv_resumen_consumo_hojas_cerradasTableAdapter.ClearBeforeFill = True
        '
        'consultar_consumo_de_consumibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 333)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "consultar_consumo_de_consumibles"
        Me.Text = "Consultar Consumibles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.inv_resumen_consumo_hojas_cerradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inv_resumen_consumo_hojas_cerradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents inv_resumen_consumo_hojas_cerradasTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_resumen_consumo_hojas_cerradasTableAdapter
    Friend WithEvents del As System.Windows.Forms.DateTimePicker
    Friend WithEvents al As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
