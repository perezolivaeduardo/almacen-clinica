<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class surtido_subir_nube
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(surtido_subir_nube))
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProgresBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Alm_surtidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Alm_surtidosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Alm_surtidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alm_surtidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nubedataset = New Almacen.nubedataset()
        Me.Alm_surtidosTableAdapter = New Almacen.nubedatasetTableAdapters.alm_surtidosTableAdapter()
        Me.TableAdapterManager = New Almacen.nubedatasetTableAdapters.TableAdapterManager()
        Me.lblcadena = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Alm_surtidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Alm_surtidosBindingNavigator.SuspendLayout()
        CType(Me.Alm_surtidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alm_surtidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nubedataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(12, 30)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 20)
        Me.fecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgresBar, Me.lblcadena})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 603)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProgresBar
        '
        Me.ProgresBar.Name = "ProgresBar"
        Me.ProgresBar.Size = New System.Drawing.Size(100, 16)
        Me.ProgresBar.ToolTipText = "Registros en el surtido"
        '
        'Alm_surtidosBindingNavigator
        '
        Me.Alm_surtidosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Alm_surtidosBindingNavigator.BindingSource = Me.Alm_surtidosBindingSource
        Me.Alm_surtidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Alm_surtidosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Alm_surtidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Alm_surtidosBindingNavigatorSaveItem})
        Me.Alm_surtidosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Alm_surtidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Alm_surtidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Alm_surtidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Alm_surtidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Alm_surtidosBindingNavigator.Name = "Alm_surtidosBindingNavigator"
        Me.Alm_surtidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Alm_surtidosBindingNavigator.Size = New System.Drawing.Size(682, 25)
        Me.Alm_surtidosBindingNavigator.TabIndex = 3
        Me.Alm_surtidosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Alm_surtidosBindingNavigatorSaveItem
        '
        Me.Alm_surtidosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Alm_surtidosBindingNavigatorSaveItem.Image = CType(resources.GetObject("Alm_surtidosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Alm_surtidosBindingNavigatorSaveItem.Name = "Alm_surtidosBindingNavigatorSaveItem"
        Me.Alm_surtidosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Alm_surtidosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Alm_surtidosDataGridView
        '
        Me.Alm_surtidosDataGridView.AutoGenerateColumns = False
        Me.Alm_surtidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Alm_surtidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7})
        Me.Alm_surtidosDataGridView.DataSource = Me.Alm_surtidosBindingSource
        Me.Alm_surtidosDataGridView.Location = New System.Drawing.Point(12, 95)
        Me.Alm_surtidosDataGridView.Name = "Alm_surtidosDataGridView"
        Me.Alm_surtidosDataGridView.Size = New System.Drawing.Size(602, 370)
        Me.Alm_surtidosDataGridView.TabIndex = 4
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(12, 56)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(129, 23)
        Me.btn_ver.TabIndex = 5
        Me.btn_ver.Text = "Ver info del servidor"
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_surtido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_surtido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "entregado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "entregado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn7.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Alm_surtidosBindingSource
        '
        Me.Alm_surtidosBindingSource.DataMember = "alm_surtidos"
        Me.Alm_surtidosBindingSource.DataSource = Me.Nubedataset
        '
        'Nubedataset
        '
        Me.Nubedataset.DataSetName = "nubedataset"
        Me.Nubedataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alm_surtidosTableAdapter
        '
        Me.Alm_surtidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alm_surtidosTableAdapter = Me.Alm_surtidosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.inventario_fisicoTableAdapter = Nothing
        Me.TableAdapterManager.sys_notificacionesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Almacen.nubedatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'lblcadena
        '
        Me.lblcadena.Name = "lblcadena"
        Me.lblcadena.Size = New System.Drawing.Size(12, 17)
        Me.lblcadena.Text = "-"
        '
        'surtido_subir_nube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 625)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.Alm_surtidosDataGridView)
        Me.Controls.Add(Me.Alm_surtidosBindingNavigator)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fecha)
        Me.Name = "surtido_subir_nube"
        Me.Text = "surtido_subir_nube"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Alm_surtidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Alm_surtidosBindingNavigator.ResumeLayout(False)
        Me.Alm_surtidosBindingNavigator.PerformLayout()
        CType(Me.Alm_surtidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alm_surtidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nubedataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ProgresBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Nubedataset As Almacen.nubedataset
    Friend WithEvents Alm_surtidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Alm_surtidosTableAdapter As Almacen.nubedatasetTableAdapters.alm_surtidosTableAdapter
    Friend WithEvents TableAdapterManager As Almacen.nubedatasetTableAdapters.TableAdapterManager
    Friend WithEvents Alm_surtidosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Alm_surtidosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Alm_surtidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_ver As System.Windows.Forms.Button
    Friend WithEvents lblcadena As System.Windows.Forms.ToolStripStatusLabel
End Class
