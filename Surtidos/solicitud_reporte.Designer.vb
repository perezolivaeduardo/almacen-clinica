<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solicitud_reporte
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
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.freporte = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.inv_sql_surtidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clinicaDataSet = New Almacen.clinicaDataSet()
        Me.inv_sql_surtidoTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_Salir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.freporte)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 387)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(555, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Todo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 14)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "HOJA DE ENTREGA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Salir.Location = New System.Drawing.Point(821, 16)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(60, 23)
        Me.btn_Salir.TabIndex = 3
        Me.btn_Salir.Text = "SALIR"
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(235, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RESUMEN DEL SURTIDO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha del corte :"
        '
        'freporte
        '
        Me.freporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.freporte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.freporte.Location = New System.Drawing.Point(125, 14)
        Me.freporte.Name = "freporte"
        Me.freporte.Size = New System.Drawing.Size(104, 23)
        Me.freporte.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "clinicaDataSet_inv_sql_surtido"
        ReportDataSource5.Value = Me.inv_sql_surtidoBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Almacen.hoja_entrega.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(932, 340)
        Me.ReportViewer2.TabIndex = 1
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "clinicaDataSet_inv_sql_surtido"
        ReportDataSource6.Value = Me.inv_sql_surtidoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.surtido.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(932, 340)
        Me.ReportViewer1.TabIndex = 0
        '
        'inv_sql_surtidoBindingSource
        '
        Me.inv_sql_surtidoBindingSource.DataMember = "inv_sql_surtido"
        Me.inv_sql_surtidoBindingSource.DataSource = Me.clinicaDataSet
        '
        'clinicaDataSet
        '
        Me.clinicaDataSet.DataSetName = "clinicaDataSet"
        Me.clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'inv_sql_surtidoTableAdapter
        '
        Me.inv_sql_surtidoTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(636, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "HOJA FIN DE SEMANA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'solicitud_reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Salir
        Me.ClientSize = New System.Drawing.Size(932, 387)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "solicitud_reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.inv_sql_surtidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents inv_sql_surtidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents inv_sql_surtidoTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_surtidoTableAdapter
    Friend WithEvents freporte As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
