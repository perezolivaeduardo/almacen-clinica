<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recetas
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recetas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trc = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.tr = New System.Windows.Forms.TextBox()
        Me.lc = New System.Windows.Forms.TextBox()
        Me.ls = New System.Windows.Forms.TextBox()
        Me.barra = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.EditarRecetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_borrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ficha = New System.Windows.Forms.GroupBox()
        Me.Sql_inv_movimientosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_inv_movimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblfolio = New System.Windows.Forms.Label()
        Me.doc = New System.Windows.Forms.ComboBox()
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvp = New System.Windows.Forms.DataGridView()
        Me.dgvproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.dgvlotes = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvlotecantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_lote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cerrado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AsignarFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvsqllotesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecetasDataGridView = New System.Windows.Forms.DataGridView()
        Me.dgvrid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvidp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvrecetacantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AsignarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarDeMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter()
        Me.RecetasTableAdapter = New Almacen.clinicaDataSetTableAdapters.recetasTableAdapter()
        Me.MedicosTableAdapter = New Almacen.clinicaDataSetTableAdapters.medicosTableAdapter()
        Me.Inv_sql_lotesTableAdapter = New Almacen.clinicaDataSetTableAdapters.inv_sql_lotesTableAdapter()
        Me.Sql_inv_movimientosTableAdapter = New Almacen.clinicaDataSetTableAdapters.sql_inv_movimientosTableAdapter()
        NombreLabel = New System.Windows.Forms.Label()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.barra.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ficha.SuspendLayout()
        CType(Me.Sql_inv_movimientosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_inv_movimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dgvlotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.InvsqllotesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Dock = System.Windows.Forms.DockStyle.Top
        NombreLabel.Location = New System.Drawing.Point(0, 263)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(69, 20)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "Nombre:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtexistencia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.trc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtstock)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tr)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ls)
        Me.SplitContainer1.Panel1.Controls.Add(Me.barra)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1190, 625)
        Me.SplitContainer1.SplitterDistance = 71
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1020, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Existencia :"
        '
        'txtexistencia
        '
        Me.txtexistencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtexistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexistencia.Location = New System.Drawing.Point(1109, 42)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.ReadOnly = True
        Me.txtexistencia.Size = New System.Drawing.Size(78, 24)
        Me.txtexistencia.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(900, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Cant."
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(774, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Recetas :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(638, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cant."
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "stock"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(424, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lotes en sistema :"
        '
        'trc
        '
        Me.trc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trc.Location = New System.Drawing.Point(946, 42)
        Me.trc.Name = "trc"
        Me.trc.ReadOnly = True
        Me.trc.Size = New System.Drawing.Size(68, 24)
        Me.trc.TabIndex = 6
        '
        'txtstock
        '
        Me.txtstock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(204, 43)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.ReadOnly = True
        Me.txtstock.Size = New System.Drawing.Size(64, 24)
        Me.txtstock.TabIndex = 4
        '
        'tr
        '
        Me.tr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tr.Location = New System.Drawing.Point(847, 42)
        Me.tr.Name = "tr"
        Me.tr.ReadOnly = True
        Me.tr.Size = New System.Drawing.Size(53, 24)
        Me.tr.TabIndex = 5
        '
        'lc
        '
        Me.lc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lc.Location = New System.Drawing.Point(704, 42)
        Me.lc.Name = "lc"
        Me.lc.ReadOnly = True
        Me.lc.Size = New System.Drawing.Size(64, 24)
        Me.lc.TabIndex = 4
        '
        'ls
        '
        Me.ls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ls.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ls.Location = New System.Drawing.Point(559, 42)
        Me.ls.Name = "ls"
        Me.ls.ReadOnly = True
        Me.ls.Size = New System.Drawing.Size(73, 24)
        Me.ls.TabIndex = 3
        '
        'barra
        '
        Me.barra.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripSplitButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.btn_borrar, Me.ToolStripSeparator2, Me.ToolStripButton4})
        Me.barra.Location = New System.Drawing.Point(0, 0)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(1190, 39)
        Me.barra.TabIndex = 0
        Me.barra.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.Log_Off
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarRecetasToolStripMenuItem, Me.AsignarToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = Global.Almacen.My.Resources.Resources.Registry_Mechanic
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripSplitButton2.Text = "ToolStripSplitButton2"
        '
        'EditarRecetasToolStripMenuItem
        '
        Me.EditarRecetasToolStripMenuItem.Name = "EditarRecetasToolStripMenuItem"
        Me.EditarRecetasToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.EditarRecetasToolStripMenuItem.Text = "Editar Recetas"
        '
        'AsignarToolStripMenuItem
        '
        Me.AsignarToolStripMenuItem.Name = "AsignarToolStripMenuItem"
        Me.AsignarToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AsignarToolStripMenuItem.Text = "Asignar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(109, 36)
        Me.ToolStripButton3.Text = "Surtir Receta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(94, 36)
        Me.ToolStripButton1.Text = "Ver receta"
        '
        'btn_borrar
        '
        Me.btn_borrar.Image = Global.Almacen.My.Resources.Resources._Error
        Me.btn_borrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(113, 36)
        Me.btn_borrar.Text = "Borrar receta."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(150, 36)
        Me.ToolStripButton4.Text = "Relacion de Surtidos"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.ficha)
        Me.SplitContainer2.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.doc)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvp)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1190, 550)
        Me.SplitContainer2.SplitterDistance = 417
        Me.SplitContainer2.TabIndex = 0
        '
        'ficha
        '
        Me.ficha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ficha.Controls.Add(Me.Sql_inv_movimientosDataGridView)
        Me.ficha.Controls.Add(Me.btn_salir)
        Me.ficha.Controls.Add(Me.Label8)
        Me.ficha.Controls.Add(Me.lblfolio)
        Me.ficha.Location = New System.Drawing.Point(5, 321)
        Me.ficha.Name = "ficha"
        Me.ficha.Size = New System.Drawing.Size(325, 271)
        Me.ficha.TabIndex = 4
        Me.ficha.TabStop = False
        Me.ficha.Text = "Surtido"
        Me.ficha.Visible = False
        '
        'Sql_inv_movimientosDataGridView
        '
        Me.Sql_inv_movimientosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_inv_movimientosDataGridView.AutoGenerateColumns = False
        Me.Sql_inv_movimientosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_inv_movimientosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_inv_movimientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_inv_movimientosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Sql_inv_movimientosDataGridView.DataSource = Me.Sql_inv_movimientosBindingSource
        Me.Sql_inv_movimientosDataGridView.Location = New System.Drawing.Point(10, 45)
        Me.Sql_inv_movimientosDataGridView.Name = "Sql_inv_movimientosDataGridView"
        Me.Sql_inv_movimientosDataGridView.RowHeadersVisible = False
        Me.Sql_inv_movimientosDataGridView.Size = New System.Drawing.Size(309, 178)
        Me.Sql_inv_movimientosDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 41
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn7.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 44
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Expr1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cant."
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 72
        '
        'Sql_inv_movimientosBindingSource
        '
        Me.Sql_inv_movimientosBindingSource.DataMember = "sql_inv_movimientos"
        Me.Sql_inv_movimientosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_salir
        '
        Me.btn_salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_salir.Location = New System.Drawing.Point(244, 229)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 30)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(176, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Surtido No."
        '
        'lblfolio
        '
        Me.lblfolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfolio.AutoSize = True
        Me.lblfolio.ForeColor = System.Drawing.Color.Red
        Me.lblfolio.Location = New System.Drawing.Point(262, 22)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(57, 20)
        Me.lblfolio.TabIndex = 1
        Me.lblfolio.Text = "Label7"
        '
        'doc
        '
        Me.doc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Nombre", True))
        Me.doc.DataSource = Me.MedicosBindingSource
        Me.doc.DisplayMember = "Nombre"
        Me.doc.FormattingEnabled = True
        Me.doc.Location = New System.Drawing.Point(5, 286)
        Me.doc.Name = "doc"
        Me.doc.Size = New System.Drawing.Size(288, 28)
        Me.doc.TabIndex = 3
        Me.doc.ValueMember = "Id"
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "medicos"
        Me.MedicosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'dgvp
        '
        Me.dgvp.AllowUserToResizeColumns = False
        Me.dgvp.AllowUserToResizeRows = False
        Me.dgvp.AutoGenerateColumns = False
        Me.dgvp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvproducto, Me.DataGridViewTextBoxColumn6})
        Me.dgvp.DataSource = Me.ProductosBindingSource
        Me.dgvp.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvp.Location = New System.Drawing.Point(0, 0)
        Me.dgvp.Name = "dgvp"
        Me.dgvp.RowHeadersVisible = False
        Me.dgvp.Size = New System.Drawing.Size(400, 263)
        Me.dgvp.TabIndex = 0
        '
        'dgvproducto
        '
        Me.dgvproducto.DataPropertyName = "id_producto"
        Me.dgvproducto.HeaderText = "id_producto"
        Me.dgvproducto.Name = "dgvproducto"
        Me.dgvproducto.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.AutoScroll = True
        Me.SplitContainer3.Panel1.Controls.Add(Me.dgvlotes)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.RecetasDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(769, 550)
        Me.SplitContainer3.SplitterDistance = 205
        Me.SplitContainer3.TabIndex = 1
        '
        'dgvlotes
        '
        Me.dgvlotes.AllowUserToAddRows = False
        Me.dgvlotes.AllowUserToDeleteRows = False
        Me.dgvlotes.AllowUserToResizeColumns = False
        Me.dgvlotes.AllowUserToResizeRows = False
        Me.dgvlotes.AutoGenerateColumns = False
        Me.dgvlotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvlotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.Nombre, Me.factura, Me.fecha_Factura, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.dgvlotecantidad, Me.lote, Me.DataGridViewCheckBoxColumn1, Me.id_doc, Me.id_lote, Me.cerrado})
        Me.dgvlotes.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvlotes.DataSource = Me.InvsqllotesBindingSource
        Me.dgvlotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlotes.Location = New System.Drawing.Point(0, 0)
        Me.dgvlotes.Name = "dgvlotes"
        Me.dgvlotes.RowHeadersVisible = False
        Me.dgvlotes.Size = New System.Drawing.Size(769, 205)
        Me.dgvlotes.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 43
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 69
        '
        'factura
        '
        Me.factura.DataPropertyName = "factura"
        Me.factura.HeaderText = "factura"
        Me.factura.Name = "factura"
        Me.factura.Width = 65
        '
        'fecha_Factura
        '
        Me.fecha_Factura.DataPropertyName = "fecha_Factura"
        Me.fecha_Factura.HeaderText = "fecha_Factura"
        Me.fecha_Factura.Name = "fecha_Factura"
        Me.fecha_Factura.Width = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha_entrada"
        Me.DataGridViewTextBoxColumn3.HeaderText = "F.Entrada"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 78
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha_caducidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "F.Caducidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'dgvlotecantidad
        '
        Me.dgvlotecantidad.DataPropertyName = "cantidad"
        Me.dgvlotecantidad.HeaderText = "cantidad"
        Me.dgvlotecantidad.Name = "dgvlotecantidad"
        Me.dgvlotecantidad.Width = 73
        '
        'lote
        '
        Me.lote.DataPropertyName = "lote"
        Me.lote.HeaderText = "lote"
        Me.lote.Name = "lote"
        Me.lote.Width = 49
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "libro"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "libro"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 32
        '
        'id_doc
        '
        Me.id_doc.DataPropertyName = "id_doc"
        Me.id_doc.HeaderText = "id_doc"
        Me.id_doc.Name = "id_doc"
        Me.id_doc.Width = 64
        '
        'id_lote
        '
        Me.id_lote.DataPropertyName = "id_lote"
        Me.id_lote.HeaderText = "id_lote"
        Me.id_lote.Name = "id_lote"
        Me.id_lote.Width = 63
        '
        'cerrado
        '
        Me.cerrado.DataPropertyName = "cerrado"
        Me.cerrado.HeaderText = "cerrado"
        Me.cerrado.Name = "cerrado"
        Me.cerrado.Width = 49
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarFacturaToolStripMenuItem, Me.ModificarFechasToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 48)
        '
        'AsignarFacturaToolStripMenuItem
        '
        Me.AsignarFacturaToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.AsignarFacturaToolStripMenuItem.Name = "AsignarFacturaToolStripMenuItem"
        Me.AsignarFacturaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AsignarFacturaToolStripMenuItem.Text = "Asignar Factura"
        '
        'ModificarFechasToolStripMenuItem
        '
        Me.ModificarFechasToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.ModificarFechasToolStripMenuItem.Name = "ModificarFechasToolStripMenuItem"
        Me.ModificarFechasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ModificarFechasToolStripMenuItem.Text = "Modificar Fechas"
        '
        'InvsqllotesBindingSource
        '
        Me.InvsqllotesBindingSource.DataMember = "inv_sql_lotes"
        Me.InvsqllotesBindingSource.DataSource = Me.ClinicaDataSet
        '
        'RecetasDataGridView
        '
        Me.RecetasDataGridView.AllowUserToAddRows = False
        Me.RecetasDataGridView.AllowUserToDeleteRows = False
        Me.RecetasDataGridView.AutoGenerateColumns = False
        Me.RecetasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RecetasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvrid, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.dgvidp, Me.DataGridViewTextBoxColumn24, Me.dgvrecetacantidad, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn1})
        Me.RecetasDataGridView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.RecetasDataGridView.DataSource = Me.RecetasBindingSource
        Me.RecetasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecetasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.RecetasDataGridView.Name = "RecetasDataGridView"
        Me.RecetasDataGridView.ReadOnly = True
        Me.RecetasDataGridView.RowHeadersVisible = False
        Me.RecetasDataGridView.Size = New System.Drawing.Size(769, 341)
        Me.RecetasDataGridView.TabIndex = 0
        '
        'dgvrid
        '
        Me.dgvrid.DataPropertyName = "Id"
        Me.dgvrid.HeaderText = "Id"
        Me.dgvrid.Name = "dgvrid"
        Me.dgvrid.ReadOnly = True
        Me.dgvrid.Width = 41
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 59
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "hs"
        Me.DataGridViewTextBoxColumn19.HeaderText = "hs"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 43
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "id_medico"
        Me.DataGridViewTextBoxColumn20.HeaderText = "id_medico"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 80
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn21.HeaderText = "MEDICO"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 74
        '
        'dgvidp
        '
        Me.dgvidp.DataPropertyName = "id_producto"
        Me.dgvidp.HeaderText = "id_producto"
        Me.dgvidp.Name = "dgvidp"
        Me.dgvidp.ReadOnly = True
        Me.dgvidp.Visible = False
        Me.dgvidp.Width = 88
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 88
        '
        'dgvrecetacantidad
        '
        Me.dgvrecetacantidad.DataPropertyName = "cantidad"
        Me.dgvrecetacantidad.HeaderText = "cantidad"
        Me.dgvrecetacantidad.Name = "dgvrecetacantidad"
        Me.dgvrecetacantidad.ReadOnly = True
        Me.dgvrecetacantidad.Width = 73
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "lote"
        Me.DataGridViewTextBoxColumn13.HeaderText = "lote"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 49
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "indicaciones"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Indicaciones"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 92
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "id_paciente"
        Me.DataGridViewTextBoxColumn27.HeaderText = "id_paciente"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Visible = False
        Me.DataGridViewTextBoxColumn27.Width = 87
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Paciente"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Paciente"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 74
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Especialidad"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Especialidad"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 92
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Dirección"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 77
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 65
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "cedula"
        Me.DataGridViewTextBoxColumn32.HeaderText = "cedula"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 64
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_lote"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_lote"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 63
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarLoteToolStripMenuItem, Me.CambiarDeMedicoToolStripMenuItem, Me.CambiarCantidadToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(200, 70)
        '
        'AsignarLoteToolStripMenuItem
        '
        Me.AsignarLoteToolStripMenuItem.Enabled = False
        Me.AsignarLoteToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.AsignarLoteToolStripMenuItem.Name = "AsignarLoteToolStripMenuItem"
        Me.AsignarLoteToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.AsignarLoteToolStripMenuItem.Text = "Asignar Lote"
        '
        'CambiarDeMedicoToolStripMenuItem
        '
        Me.CambiarDeMedicoToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CambiarDeMedicoToolStripMenuItem.Name = "CambiarDeMedicoToolStripMenuItem"
        Me.CambiarDeMedicoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CambiarDeMedicoToolStripMenuItem.Text = "Cambiar de Medico"
        '
        'CambiarCantidadToolStripMenuItem
        '
        Me.CambiarCantidadToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.CambiarCantidadToolStripMenuItem.Name = "CambiarCantidadToolStripMenuItem"
        Me.CambiarCantidadToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CambiarCantidadToolStripMenuItem.Text = "Cambiar Cantidad"
        '
        'RecetasBindingSource
        '
        Me.RecetasBindingSource.DataMember = "recetas"
        Me.RecetasBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'RecetasTableAdapter
        '
        Me.RecetasTableAdapter.ClearBeforeFill = True
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'Inv_sql_lotesTableAdapter
        '
        Me.Inv_sql_lotesTableAdapter.ClearBeforeFill = True
        '
        'Sql_inv_movimientosTableAdapter
        '
        Me.Sql_inv_movimientosTableAdapter.ClearBeforeFill = True
        '
        'recetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 625)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "recetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "recetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.barra.ResumeLayout(False)
        Me.barra.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ficha.ResumeLayout(False)
        Me.ficha.PerformLayout()
        CType(Me.Sql_inv_movimientosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_inv_movimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dgvlotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.InvsqllotesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.RecetasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Almacen.clinicaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents dgvp As System.Windows.Forms.DataGridView
    Friend WithEvents RecetasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecetasTableAdapter As Almacen.clinicaDataSetTableAdapters.recetasTableAdapter
    Friend WithEvents RecetasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barra As System.Windows.Forms.ToolStrip
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicosTableAdapter As Almacen.clinicaDataSetTableAdapters.medicosTableAdapter
    Friend WithEvents doc As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvlotes As System.Windows.Forms.DataGridView
    Friend WithEvents lc As System.Windows.Forms.TextBox
    Friend WithEvents ls As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents trc As System.Windows.Forms.TextBox
    Friend WithEvents tr As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents EditarRecetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvsqllotesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Inv_sql_lotesTableAdapter As Almacen.clinicaDataSetTableAdapters.inv_sql_lotesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtexistencia As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AsignarFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarDeMedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvrid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvidp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvrecetacantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha_Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvlotecantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_lote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cerrado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ModificarFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CambiarCantidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_borrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents ficha As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sql_inv_movimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_inv_movimientosTableAdapter As Almacen.clinicaDataSetTableAdapters.sql_inv_movimientosTableAdapter
    Friend WithEvents Sql_inv_movimientosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
