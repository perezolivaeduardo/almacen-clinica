Public Class stocks_definir
    Dim fil As String = "1"
    Private Sub stocks_definir_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub



    Private Sub stocks_definir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.FillByinventario(Me.ClinicaDataSet.areas)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.stocks' Puede moverla o quitarla según sea necesario.
        Me.StocksTableAdapter.Fill(Me.ClinicaDataSet.stocks)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ClinicaDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
        Me.SplitContainer1.Panel1Collapsed = True


    End Sub



    Private Sub buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscar.TextChanged
        Dim fa As String
        Try
            fa = "descripcion like '%" + buscar.Text + "%'"
            Me.ProductosBindingSource.Filter = fa
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CategoriaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaComboBox.SelectedIndexChanged
        Dim ff As String
        Try
            ff = "id_categoria = " + CategoriaComboBox.SelectedValue.ToString
            Me.ProductosBindingSource.Filter = ff
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub agregar()

        Dim id, area, categoria As Integer, descripcion As String
        area = AreaComboBox.SelectedValue.ToString
        id = Me.ProductosDataGridView.CurrentRow.Cells("id_producto").Value
        categoria = Me.ProductosDataGridView.CurrentRow.Cells("id_categoria").Value.ToString
        descripcion = Me.ProductosDataGridView.CurrentRow.Cells("Descripcion").Value.ToString
        If descripcion.Length > 35 Then
            descripcion = descripcion.Substring(0, 35)
        End If
        Try
            StocksTableAdapter.Insert(area, categoria, id, 0, 0, descripcion, 0, False, False)
            Me.StocksTableAdapter.Fill(Me.ClinicaDataSet.stocks)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       

    End Sub

   

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ProductosDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles ProductosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub


    Private Sub StocksDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles StocksDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AreaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaComboBox.SelectedIndexChanged
        Try
            Me.StocksBindingSource.Filter = "id_area = " + AreaComboBox.SelectedValue.ToString
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ProductosDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosDataGridView.DoubleClick
        agregar()
    End Sub

    Private Sub StocksDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StocksDataGridView.DoubleClick
       eliminar_del_stock()

    End Sub

   


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        eliminar_del_stock()

    End Sub

    Private Sub eliminar_del_stock()
        Dim ix As MsgBoxResult, d As String
        d = Me.StocksDataGridView.CurrentRow.Cells("dgvd").Value.ToString
        ix = MsgBox("Seguro que quiere quitar del Stock este producto: " + d + " ?", MsgBoxStyle.YesNo, "Quitar un producto del Stock")
        If ix = MsgBoxResult.Yes Then
            Me.StocksBindingSource.RemoveCurrent()
            Me.Validate()
            Me.StocksBindingSource.EndEdit()
            Me.StocksTableAdapter.Update(Me.ClinicaDataSet.stocks)
        End If


    End Sub

    Private Sub HojaDeGastosUnAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HojaDeGastosUnAreaToolStripMenuItem.Click
        Dim area As Integer
        area = AreaComboBox.SelectedValue.ToString
        My.Forms.hoja_gastos.cargar(area)
        My.Forms.hoja_gastos.Show()
    End Sub

    Private Sub StocksDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StocksDataGridView.CellContentClick

    End Sub

    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        Me.Validate()
        Me.StocksBindingSource.EndEdit()
        Me.StocksTableAdapter.Update(Me.ClinicaDataSet.stocks)
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub EstaAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstaAreaToolStripMenuItem.Click
        My.Forms.Stock_por__Area.cargar_area(Me.AreaComboBox.SelectedValue)
        My.Forms.Stock_por__Area.Show()
    End Sub

    Private Sub TodasLasAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodasLasAreasToolStripMenuItem.Click
        My.Forms.Stock_por__Area.cargar_todos()
        My.Forms.Stock_por__Area.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.SplitContainer1.Panel1Collapsed = False
        Me.ToolStripButton3.Enabled = False
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.SplitContainer1.Panel1Collapsed = True
        Me.ToolStripButton3.Enabled = True
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        My.Forms.productos.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.ClinicaDataSet.areas)
        MsgBox("Se cargaron todas las areas para definir hoja de trabajo")

    End Sub

    Private Sub btn_consumible_Click(sender As System.Object, e As System.EventArgs) Handles btn_consumible.Click
        If fil = "1" Then
            StocksBindingSource.Filter = "consumible=0"
            fil = "0"
        Else
            StocksBindingSource.Filter = "consumible=1"
            fil = "1"
        End If

    End Sub

    Private Sub ImprimirConsumiblesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirConsumiblesToolStripMenuItem.Click
        My.Forms.Stock_por__Area.cargar_consumibles()
        My.Forms.Stock_por__Area.Show()
    End Sub
End Class