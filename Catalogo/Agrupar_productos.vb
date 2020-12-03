Public Class Agrupar_productos

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)

    End Sub

    Private Sub Agrupar_productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.grupos' Puede moverla o quitarla según sea necesario.
        Me.GruposTableAdapter.Fill(Me.ClinicaDataSet.grupos)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ClinicaDataSet.Productos)
        Try
            Me.Text = "Selecciona Productos para grupo " + GRUPO.SelectedValue.ToString
            Dim f As String = "grupo =" + GRUPO.SelectedValue.ToString
            gruposBS.Filter = f
        Catch ex As Exception

        End Try
        Me.SplitContainer2.Panel1Collapsed = True
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.ClinicaDataSet.Productos)
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.SplitContainer2.Panel1Collapsed = Not Me.SplitContainer2.Panel1Collapsed
    End Sub

    Private Sub filtro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filtro.TextChanged
        Try
            Dim f As String = "descripcion like '%" + filtro.Text + "%'"
            Me.ProductosBindingSource.Filter = f
        Catch ex As Exception
            Me.ProductosBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub GRUPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRUPO.SelectedIndexChanged
        Try
            Me.Text = "Selecciona Productos para grupo " + GRUPO.SelectedValue.ToString
            Dim f As String = "grupo =" + GRUPO.SelectedValue.ToString
            gruposBS.Filter = f
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProductosDataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellDoubleClick
        Dim g As String = GRUPO.SelectedValue.ToString
        Me.GrupoTextBox.Text = g
        Me.ProductosBindingSource.EndEdit()
    End Sub

    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        TextBox1.Text = 0
        Me.gruposBS.EndEdit()
    End Sub
End Class