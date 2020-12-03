<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicos
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Dirección_de_correo_electrónicoLabel As System.Windows.Forms.Label
        Dim EspecialidadLabel As System.Windows.Forms.Label
        Dim Teléfono_del_trabajoLabel As System.Windows.Forms.Label
        Dim Teléfono_particularLabel As System.Windows.Forms.Label
        Dim Teléfono_móvilLabel As System.Windows.Forms.Label
        Dim DirecciónLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim Estado_ProvinciaLabel As System.Windows.Forms.Label
        Dim Código_postalLabel As System.Windows.Forms.Label
        Dim NotasLabel As System.Windows.Forms.Label
        Dim RecetaLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.MedicosDataGridView = New System.Windows.Forms.DataGridView
        Me.MedicosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Almacen.clinicaDataSet
        Me.IdTextBox = New System.Windows.Forms.TextBox
        Me.NombreTextBox = New System.Windows.Forms.TextBox
        Me.Dirección_de_correo_electrónicoTextBox = New System.Windows.Forms.TextBox
        Me.EspecialidadTextBox = New System.Windows.Forms.TextBox
        Me.Teléfono_del_trabajoTextBox = New System.Windows.Forms.TextBox
        Me.Teléfono_particularTextBox = New System.Windows.Forms.TextBox
        Me.Teléfono_móvilTextBox = New System.Windows.Forms.TextBox
        Me.DirecciónTextBox = New System.Windows.Forms.TextBox
        Me.CiudadTextBox = New System.Windows.Forms.TextBox
        Me.Estado_ProvinciaTextBox = New System.Windows.Forms.TextBox
        Me.Código_postalTextBox = New System.Windows.Forms.TextBox
        Me.NotasTextBox = New System.Windows.Forms.TextBox
        Me.RecetaCheckBox = New System.Windows.Forms.CheckBox
        Me.CedulaTextBox = New System.Windows.Forms.TextBox
        Me.MedicosTableAdapter = New Almacen.clinicaDataSetTableAdapters.medicosTableAdapter
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.receta = New System.Windows.Forms.DataGridViewCheckBoxColumn
        IdLabel = New System.Windows.Forms.Label
        NombreLabel = New System.Windows.Forms.Label
        Dirección_de_correo_electrónicoLabel = New System.Windows.Forms.Label
        EspecialidadLabel = New System.Windows.Forms.Label
        Teléfono_del_trabajoLabel = New System.Windows.Forms.Label
        Teléfono_particularLabel = New System.Windows.Forms.Label
        Teléfono_móvilLabel = New System.Windows.Forms.Label
        DirecciónLabel = New System.Windows.Forms.Label
        CiudadLabel = New System.Windows.Forms.Label
        Estado_ProvinciaLabel = New System.Windows.Forms.Label
        Código_postalLabel = New System.Windows.Forms.Label
        NotasLabel = New System.Windows.Forms.Label
        RecetaLabel = New System.Windows.Forms.Label
        CedulaLabel = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.MedicosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(280, 6)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 44)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'Dirección_de_correo_electrónicoLabel
        '
        Dirección_de_correo_electrónicoLabel.AutoSize = True
        Dirección_de_correo_electrónicoLabel.Location = New System.Drawing.Point(12, 70)
        Dirección_de_correo_electrónicoLabel.Name = "Dirección_de_correo_electrónicoLabel"
        Dirección_de_correo_electrónicoLabel.Size = New System.Drawing.Size(42, 13)
        Dirección_de_correo_electrónicoLabel.TabIndex = 4
        Dirección_de_correo_electrónicoLabel.Text = "E-Mail :"
        '
        'EspecialidadLabel
        '
        EspecialidadLabel.AutoSize = True
        EspecialidadLabel.Location = New System.Drawing.Point(12, 96)
        EspecialidadLabel.Name = "EspecialidadLabel"
        EspecialidadLabel.Size = New System.Drawing.Size(70, 13)
        EspecialidadLabel.TabIndex = 6
        EspecialidadLabel.Text = "Especialidad:"
        '
        'Teléfono_del_trabajoLabel
        '
        Teléfono_del_trabajoLabel.AutoSize = True
        Teléfono_del_trabajoLabel.Location = New System.Drawing.Point(12, 121)
        Teléfono_del_trabajoLabel.Name = "Teléfono_del_trabajoLabel"
        Teléfono_del_trabajoLabel.Size = New System.Drawing.Size(104, 13)
        Teléfono_del_trabajoLabel.TabIndex = 8
        Teléfono_del_trabajoLabel.Text = "Teléfono del trabajo:"
        '
        'Teléfono_particularLabel
        '
        Teléfono_particularLabel.AutoSize = True
        Teléfono_particularLabel.Location = New System.Drawing.Point(18, 147)
        Teléfono_particularLabel.Name = "Teléfono_particularLabel"
        Teléfono_particularLabel.Size = New System.Drawing.Size(98, 13)
        Teléfono_particularLabel.TabIndex = 10
        Teléfono_particularLabel.Text = "Teléfono particular:"
        '
        'Teléfono_móvilLabel
        '
        Teléfono_móvilLabel.AutoSize = True
        Teléfono_móvilLabel.Location = New System.Drawing.Point(37, 173)
        Teléfono_móvilLabel.Name = "Teléfono_móvilLabel"
        Teléfono_móvilLabel.Size = New System.Drawing.Size(79, 13)
        Teléfono_móvilLabel.TabIndex = 12
        Teléfono_móvilLabel.Text = "Teléfono móvil:"
        '
        'DirecciónLabel
        '
        DirecciónLabel.AutoSize = True
        DirecciónLabel.Location = New System.Drawing.Point(12, 212)
        DirecciónLabel.Name = "DirecciónLabel"
        DirecciónLabel.Size = New System.Drawing.Size(55, 13)
        DirecciónLabel.TabIndex = 14
        DirecciónLabel.Text = "Dirección:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(12, 238)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 16
        CiudadLabel.Text = "Ciudad:"
        '
        'Estado_ProvinciaLabel
        '
        Estado_ProvinciaLabel.AutoSize = True
        Estado_ProvinciaLabel.Location = New System.Drawing.Point(12, 264)
        Estado_ProvinciaLabel.Name = "Estado_ProvinciaLabel"
        Estado_ProvinciaLabel.Size = New System.Drawing.Size(92, 13)
        Estado_ProvinciaLabel.TabIndex = 18
        Estado_ProvinciaLabel.Text = "Estado/Provincia:"
        '
        'Código_postalLabel
        '
        Código_postalLabel.AutoSize = True
        Código_postalLabel.Location = New System.Drawing.Point(12, 290)
        Código_postalLabel.Name = "Código_postalLabel"
        Código_postalLabel.Size = New System.Drawing.Size(74, 13)
        Código_postalLabel.TabIndex = 20
        Código_postalLabel.Text = "Código postal:"
        '
        'NotasLabel
        '
        NotasLabel.AutoSize = True
        NotasLabel.Location = New System.Drawing.Point(16, 392)
        NotasLabel.Name = "NotasLabel"
        NotasLabel.Size = New System.Drawing.Size(38, 13)
        NotasLabel.TabIndex = 22
        NotasLabel.Text = "Notas:"
        '
        'RecetaLabel
        '
        RecetaLabel.AutoSize = True
        RecetaLabel.Location = New System.Drawing.Point(17, 362)
        RecetaLabel.Name = "RecetaLabel"
        RecetaLabel.Size = New System.Drawing.Size(82, 13)
        RecetaLabel.TabIndex = 28
        RecetaLabel.Text = "Emite Recetas :"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Location = New System.Drawing.Point(17, 333)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(42, 13)
        CedulaLabel.TabIndex = 30
        CedulaLabel.Text = "cedula:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(702, 568)
        Me.SplitContainer1.SplitterDistance = 49
        Me.SplitContainer1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(702, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.MedicosDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(IdLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.IdTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Dirección_de_correo_electrónicoLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Dirección_de_correo_electrónicoTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(EspecialidadLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.EspecialidadTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Teléfono_del_trabajoLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Teléfono_del_trabajoTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Teléfono_particularLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Teléfono_particularTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Teléfono_móvilLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Teléfono_móvilTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(DirecciónLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DirecciónTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(CiudadLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CiudadTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Estado_ProvinciaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Estado_ProvinciaTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Código_postalLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Código_postalTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(NotasLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NotasTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(RecetaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RecetaCheckBox)
        Me.SplitContainer2.Panel2.Controls.Add(CedulaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.CedulaTextBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(702, 515)
        Me.SplitContainer2.SplitterDistance = 354
        Me.SplitContainer2.TabIndex = 0
        '
        'MedicosDataGridView
        '
        Me.MedicosDataGridView.AllowUserToAddRows = False
        Me.MedicosDataGridView.AllowUserToDeleteRows = False
        Me.MedicosDataGridView.AllowUserToOrderColumns = True
        Me.MedicosDataGridView.AllowUserToResizeColumns = False
        Me.MedicosDataGridView.AllowUserToResizeRows = False
        Me.MedicosDataGridView.AutoGenerateColumns = False
        Me.MedicosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.receta})
        Me.MedicosDataGridView.DataSource = Me.MedicosBindingSource
        Me.MedicosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MedicosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MedicosDataGridView.Name = "MedicosDataGridView"
        Me.MedicosDataGridView.ReadOnly = True
        Me.MedicosDataGridView.RowHeadersVisible = False
        Me.MedicosDataGridView.Size = New System.Drawing.Size(354, 515)
        Me.MedicosDataGridView.TabIndex = 0
        '
        'MedicosBindingSource
        '
        Me.MedicosBindingSource.DataMember = "medicos"
        Me.MedicosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdTextBox
        '
        Me.IdTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(305, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(65, 41)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(276, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'Dirección_de_correo_electrónicoTextBox
        '
        Me.Dirección_de_correo_electrónicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Dirección de correo electrónico", True))
        Me.Dirección_de_correo_electrónicoTextBox.Location = New System.Drawing.Point(65, 67)
        Me.Dirección_de_correo_electrónicoTextBox.Name = "Dirección_de_correo_electrónicoTextBox"
        Me.Dirección_de_correo_electrónicoTextBox.Size = New System.Drawing.Size(276, 20)
        Me.Dirección_de_correo_electrónicoTextBox.TabIndex = 5
        '
        'EspecialidadTextBox
        '
        Me.EspecialidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Especialidad", True))
        Me.EspecialidadTextBox.Location = New System.Drawing.Point(88, 93)
        Me.EspecialidadTextBox.Name = "EspecialidadTextBox"
        Me.EspecialidadTextBox.Size = New System.Drawing.Size(253, 20)
        Me.EspecialidadTextBox.TabIndex = 7
        '
        'Teléfono_del_trabajoTextBox
        '
        Me.Teléfono_del_trabajoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Teléfono del trabajo", True))
        Me.Teléfono_del_trabajoTextBox.Location = New System.Drawing.Point(122, 121)
        Me.Teléfono_del_trabajoTextBox.Name = "Teléfono_del_trabajoTextBox"
        Me.Teléfono_del_trabajoTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Teléfono_del_trabajoTextBox.TabIndex = 9
        '
        'Teléfono_particularTextBox
        '
        Me.Teléfono_particularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Teléfono particular", True))
        Me.Teléfono_particularTextBox.Location = New System.Drawing.Point(122, 147)
        Me.Teléfono_particularTextBox.Name = "Teléfono_particularTextBox"
        Me.Teléfono_particularTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Teléfono_particularTextBox.TabIndex = 11
        '
        'Teléfono_móvilTextBox
        '
        Me.Teléfono_móvilTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Teléfono móvil", True))
        Me.Teléfono_móvilTextBox.Location = New System.Drawing.Point(122, 173)
        Me.Teléfono_móvilTextBox.Name = "Teléfono_móvilTextBox"
        Me.Teléfono_móvilTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Teléfono_móvilTextBox.TabIndex = 13
        '
        'DirecciónTextBox
        '
        Me.DirecciónTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Dirección", True))
        Me.DirecciónTextBox.Location = New System.Drawing.Point(65, 205)
        Me.DirecciónTextBox.Name = "DirecciónTextBox"
        Me.DirecciónTextBox.Size = New System.Drawing.Size(276, 20)
        Me.DirecciónTextBox.TabIndex = 15
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(61, 231)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(280, 20)
        Me.CiudadTextBox.TabIndex = 17
        '
        'Estado_ProvinciaTextBox
        '
        Me.Estado_ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Estado/Provincia", True))
        Me.Estado_ProvinciaTextBox.Location = New System.Drawing.Point(110, 261)
        Me.Estado_ProvinciaTextBox.Name = "Estado_ProvinciaTextBox"
        Me.Estado_ProvinciaTextBox.Size = New System.Drawing.Size(231, 20)
        Me.Estado_ProvinciaTextBox.TabIndex = 19
        '
        'Código_postalTextBox
        '
        Me.Código_postalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Código postal", True))
        Me.Código_postalTextBox.Location = New System.Drawing.Point(88, 287)
        Me.Código_postalTextBox.Name = "Código_postalTextBox"
        Me.Código_postalTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Código_postalTextBox.TabIndex = 21
        '
        'NotasTextBox
        '
        Me.NotasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "Notas", True))
        Me.NotasTextBox.Location = New System.Drawing.Point(14, 408)
        Me.NotasTextBox.Multiline = True
        Me.NotasTextBox.Name = "NotasTextBox"
        Me.NotasTextBox.Size = New System.Drawing.Size(323, 95)
        Me.NotasTextBox.TabIndex = 23
        '
        'RecetaCheckBox
        '
        Me.RecetaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MedicosBindingSource, "receta", True))
        Me.RecetaCheckBox.Location = New System.Drawing.Point(103, 357)
        Me.RecetaCheckBox.Name = "RecetaCheckBox"
        Me.RecetaCheckBox.Size = New System.Drawing.Size(25, 24)
        Me.RecetaCheckBox.TabIndex = 29
        '
        'CedulaTextBox
        '
        Me.CedulaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedicosBindingSource, "cedula", True))
        Me.CedulaTextBox.Location = New System.Drawing.Point(65, 330)
        Me.CedulaTextBox.Name = "CedulaTextBox"
        Me.CedulaTextBox.Size = New System.Drawing.Size(272, 20)
        Me.CedulaTextBox.TabIndex = 31
        '
        'MedicosTableAdapter
        '
        Me.MedicosTableAdapter.ClearBeforeFill = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Almacen.My.Resources.Resources.Log_Off
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Almacen.My.Resources.Resources.medico
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(96, 36)
        Me.ToolStripButton2.Text = "Ver Todos"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.Almacen.My.Resources.Resources.orden
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(171, 36)
        Me.ToolStripButton3.Text = "Ver solo los que Recetan"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'receta
        '
        Me.receta.DataPropertyName = "receta"
        Me.receta.HeaderText = "receta"
        Me.receta.Name = "receta"
        Me.receta.ReadOnly = True
        Me.receta.Visible = False
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Medicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicos"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.MedicosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ClinicaDataSet As Almacen.clinicaDataSet
    Friend WithEvents MedicosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicosTableAdapter As Almacen.clinicaDataSetTableAdapters.medicosTableAdapter
    Friend WithEvents MedicosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dirección_de_correo_electrónicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EspecialidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teléfono_del_trabajoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teléfono_particularTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Teléfono_móvilTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirecciónTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_ProvinciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Código_postalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RecetaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CedulaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents receta As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
