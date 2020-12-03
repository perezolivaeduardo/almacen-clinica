Public Class solicitud_solicitar

  
    Private Sub solicitud_solicitar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_movimientos' Puede moverla o quitarla según sea necesario.
        Me.Inv_movimientosTableAdapter.Fill(Me.ClinicaDataSet.inv_movimientos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByActivo(Me.ClinicaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_documentos' Puede moverla o quitarla según sea necesario.
        Me.Inv_documentosTableAdapter.Fill(Me.ClinicaDataSet.inv_documentos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.ClinicaDataSet.areas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.ClinicaDataSet.areas)
        PlantilaTableAdapter.inicializa()
        Me.PlantilaTableAdapter.Fill(Me.ClinicaDataSet.plantila)

    End Sub


    Private Sub filtro_TextChanged(sender As System.Object, e As System.EventArgs) Handles filtro.TextChanged
        Dim f As String
        Try
            f = "descripcion like '%" + filtro.Text + "%'"
            ProductosBindingSource.Filter = f
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        agregar()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere inicializar la el surtido", MsgBoxStyle.YesNo, "Inicializa")
        If ix = MsgBoxResult.Yes Then
            PlantilaTableAdapter.inicializa()
            Me.PlantilaTableAdapter.Fill(Me.ClinicaDataSet.plantila)
        End If

    End Sub

    Private Sub PlantilaDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PlantilaDataGridView.CellDoubleClick
        Dim id As Integer, descripcion As String
        id = PlantilaDataGridView.CurrentRow.Cells(0).Value
        descripcion = PlantilaDataGridView.CurrentRow.Cells(2).Value
        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere borrar " + descripcion + "?", MsgBoxStyle.YesNo, "Inicializa")
        If ix = MsgBoxResult.Yes Then
            PlantilaTableAdapter.borrar(id)
            Me.PlantilaTableAdapter.Fill(Me.ClinicaDataSet.plantila)
        End If

    End Sub

    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        agregar()
    End Sub
    Private Sub agregar()
        Dim id, cant As Integer, descripcion As String
        id = dgv.CurrentRow.Cells(0).Value
        descripcion = dgv.CurrentRow.Cells(1).Value

        cant = InputBox("Teclee la cantidad de productos", "")
        If cant < 1 Then
            MsgBox("Teclee la cantidad de producto que quiere registrar")
        Else
            PlantilaTableAdapter.Insert(id, descripcion, cant)
            Me.PlantilaTableAdapter.Fill(Me.ClinicaDataSet.plantila)
            filtro.Text = ""
            filtro.Focus()
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Dim sql As String = "SELECT  Max(inv_documentos.folio) AS MáxDefolio FROM inv_documentos where inv_documentos.tipo=6"
        Dim folio As Integer
        Try
            folio = leer_tabla(sql).Rows(0).Item(0) + 1
        Catch ex As Exception
            folio = 1
        End Try
        FolioTextBox.Text = folio
        If ObservacionesTextBox.TextLength = 0 Then
            MsgBox("Escriba algun comentario ")
        End If

        guardar_documento()
    End Sub
    Private Sub guardar_documento()
        Inv_documentosTableAdapter.Insert(FolioTextBox.Text, 6, Id_areaTextBox.Text, FechaDateTimePicker.Value, user_id, 0, "", Now.Date, ObservacionesTextBox.Text, Now, False, 0, Now)
        For j As Integer = 0 To PlantilaDataGridView.Rows.Count - 1
            With PlantilaDataGridView.Rows(j)
                Dim id, cant As Integer, descripcion As String
                id = .Cells(1).Value
                descripcion = .Cells(2).Value
                cant = .Cells(3).Value
                Inv_movimientosTableAdapter.Insert(FolioTextBox.Text, id, Id_areaTextBox.Text, 0, user_id, 6, FechaDateTimePicker.Value, cant, 0, descripcion)
            End With
        Next
    End Sub
End Class