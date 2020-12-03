<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relacion_de_entradas
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.recetas_dataset = New Almacen.recetas_dataset()
        Me.relacion_de_entradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.relacion_de_entradasTableAdapter = New Almacen.recetas_datasetTableAdapters.relacion_de_entradasTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_del = New System.Windows.Forms.DateTimePicker()
        Me.date_al = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.recetas_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relacion_de_entradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_al)
        Me.SplitContainer1.Panel1.Controls.Add(Me.date_del)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(948, 646)
        Me.SplitContainer1.SplitterDistance = 55
        Me.SplitContainer1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.relacion_de_entradasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Almacen.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(948, 587)
        Me.ReportViewer1.TabIndex = 0
        '
        'recetas_dataset
        '
        Me.recetas_dataset.DataSetName = "recetas_dataset"
        Me.recetas_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'relacion_de_entradasBindingSource
        '
        Me.relacion_de_entradasBindingSource.DataMember = "relacion de entradas"
        Me.relacion_de_entradasBindingSource.DataSource = Me.recetas_dataset
        '
        'relacion_de_entradasTableAdapter
        '
        Me.relacion_de_entradasTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Periodo :"
        '
        'date_del
        '
        Me.date_del.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_del.Location = New System.Drawing.Point(68, 15)
        Me.date_del.Name = "date_del"
        Me.date_del.Size = New System.Drawing.Size(111, 20)
        Me.date_del.TabIndex = 3
        '
        'date_al
        '
        Me.date_al.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_al.Location = New System.Drawing.Point(212, 15)
        Me.date_al.Name = "date_al"
        Me.date_al.Size = New System.Drawing.Size(111, 20)
        Me.date_al.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "al:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ver Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Relacion_de_entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 646)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Relacion_de_entradas"
        Me.Text = "Relacion_de_entradas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.recetas_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relacion_de_entradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents relacion_de_entradasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents recetas_dataset As Almacen.recetas_dataset
    Friend WithEvents relacion_de_entradasTableAdapter As Almacen.recetas_datasetTableAdapters.relacion_de_entradasTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents date_al As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_del As System.Windows.Forms.DateTimePicker
End Class
