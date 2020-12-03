Public Class capturar_inventarios

    Private Sub InventariosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventariosBindingSource.EndEdit()
        Me.InventariosTableAdapter.Update(Me.ClinicaDataSet.inventarios)

    End Sub

    Private Sub capturar_inventarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.ClinicaDataSet.areas)
        Me.AreasBindingSource.Filter = "inventario =true"
        fecha.Visible = True
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inventarios' Puede moverla o quitarla según sea necesario.
        Me.InventariosTableAdapter.FillByarea(Me.ClinicaDataSet.inventarios, fecha.Value.ToShortDateString)
        Dim a As Integer = Comboarea.SelectedValue
        Me.InventariosBindingSource.Filter = "id_area =" + a.ToString
        Me.Text = "Captura de Inventario del " + fecha.Value.ToShortDateString
        fecha.Visible = False
    End Sub

    Private Sub Comboarea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comboarea.SelectedIndexChanged
        Dim a As Integer = Comboarea.SelectedValue
        Me.InventariosBindingSource.Filter = "id_area =" + a.ToString
        lblcantidad.Text = dgv.Rows.Count - 1
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        My.Forms.reporte_de_inventario.Show()
    End Sub
End Class