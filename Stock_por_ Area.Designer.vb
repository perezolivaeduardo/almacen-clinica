<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_por__Area
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.clinicaDataSet = New Almacen.clinicaDataSet
        Me.sql_alma_stocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sql_alma_stocksTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_alma_stocksTableAdapter
        Me.boton_salir = New System.Windows.Forms.Button
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sql_alma_stocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.boton_salir)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(521, 386)
        Me.SplitContainer1.SplitterDistance = 35
        Me.SplitContainer1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "clinicaDataSet_sql_alma_stocks"
        ReportDataSource1.Value = Me.sql_alma_stocksBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Stocks.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(521, 347)
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
        'boton_salir
        '
        Me.boton_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boton_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.boton_salir.Location = New System.Drawing.Point(468, 3)
        Me.boton_salir.Name = "boton_salir"
        Me.boton_salir.Size = New System.Drawing.Size(50, 23)
        Me.boton_salir.TabIndex = 0
        Me.boton_salir.Text = "Esc"
        Me.boton_salir.UseVisualStyleBackColor = True
        '
        'Stock_por__Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.boton_salir
        Me.ClientSize = New System.Drawing.Size(521, 386)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Stock_por__Area"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock definidos por Area"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sql_alma_stocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_alma_stocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents sql_alma_stocksTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_alma_stocksTableAdapter
    Friend WithEvents boton_salir As System.Windows.Forms.Button
End Class
