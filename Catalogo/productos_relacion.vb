Public Class productos_relacion

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)

    End Sub

    Private Sub productos_relacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Recetas_dataset.inventario_inicial' Puede moverla o quitarla según sea necesario.
        Me.Inventario_inicialTableAdapter.Fill(Me.Recetas_dataset.inventario_inicial)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ClinicaDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ProductosDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ProductosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtro.TextChanged
        Dim f As String = "Descripcion like '%" + filtro.Text + "%'"
        Me.ProductosBindingSource.Filter = f

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As String = "id_categoria = " + Me.CAT.SelectedValue.ToString
        Me.ProductosBindingSource.Filter = f
    End Sub

    Private Sub CAT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CAT.SelectedIndexChanged
        Try
            Dim f As String = "id_categoria = " + Me.CAT.SelectedValue.ToString
            Me.ProductosBindingSource.Filter = f
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub ProductosDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        Dim sql As String = "SELECT areas.area as Area, stocks.maximo as Stock FROM stocks INNER JOIN areas ON stocks.id_area = areas.id_area WHERE stocks.id_producto=[id]"
        Dim id As Integer
        id = Me.ProductosDataGridView.CurrentRow.Cells("dgvid").Value
        sql = sql.Replace("[id]", id)
        dgv.DataSource = leer_tabla(sql)
        Try
            Me.Inventario_inicialBindingSource.Filter = "id =" + id.ToString
        Catch ex As Exception
            FisicoTextBox.Text = "?"
        End Try

    End Sub

    Private Sub FisicoLabel_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FisicoTextBox.ReadOnly = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Dim id As Integer
        'id = Me.ProductosDataGridView.CurrentRow.Cells("dgvid").Value
        'Dim frm As New kardex_inventario
        'frm.cargar(id)
        'frm.ShowDialog()
    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        global_producto = ProductosDataGridView.CurrentRow.Cells(0).Value
        Dim frm As New Productos_modificar
        frm.ShowDialog()
    End Sub

    Private Sub VerStocksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerStocksToolStripMenuItem.Click

    End Sub
End Class