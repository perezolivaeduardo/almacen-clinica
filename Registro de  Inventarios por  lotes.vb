Public Class Registro_de__Inventarios_por__lotes
    Private Sub Inv_lotesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inv_lotesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Inv_lotesBindingSource.EndEdit()
        Me.Inv_lotesTableAdapter.Update(Me.ClinicaDataSet.inv_lotes)
    End Sub

    Private Sub Registro_de__Inventarios_por__lotes_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Validate()
        Me.Inv_lotesBindingSource.EndEdit()
        Me.Inv_lotesTableAdapter.Update(Me.ClinicaDataSet.inv_lotes)

        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
    End Sub

    Private Sub Registro_de__Inventarios_por__lotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_lotes' Puede moverla o quitarla según sea necesario.
        Me.Inv_lotesTableAdapter.Fill(Me.ClinicaDataSet.inv_lotes)
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim f As String
        f = "Descripcion like '%" + Me.TextBox1.Text + "%'"
        Me.ProductosBindingSource.Filter = f
    End Sub


    Private Sub ProductosDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.RowEnter
        gid.Text = Me.ProductosDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim f As String = "id_producto =" + gid.Text
        Me.Inv_lotesBindingSource.Filter = f

    End Sub

    Private Sub Inv_lotesDataGridView_RowValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Inv_lotesDataGridView.RowValidating
        Me.Inv_lotesDataGridView.Rows(e.RowIndex).Cells(1).Value = gid.Text
        Me.Inv_lotesDataGridView.Rows(e.RowIndex).Cells(2).Value = Date.Today.ToShortDateString
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.productos.ShowDialog()
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub
End Class