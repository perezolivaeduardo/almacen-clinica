Public Class KardexGlobal

    Private Sub KardexGlobal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.sql_movimientos_al_inventario_x_area' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.rpt_productos' Puede moverla o quitarla según sea necesario.
        Me.Rpt_productosTableAdapter.Fill(Me.ClinicaDataSet.rpt_productos)
    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Dim f As String = "Descripcion like '%" + txtfiltro.Text + "%'"
        Rpt_productosBindingSource.Filter = f
    End Sub

    Private Sub Rpt_productosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Rpt_productosDataGridView.CellClick
        Dim id As Integer
        id = Rpt_productosDataGridView.CurrentRow.Cells(2).Value
        SplitContainer3.Panel2Collapsed = True

        cargar(id)
    End Sub

    Private Sub cargar(ByVal id As String)
        Cursor.Current = Cursors.WaitCursor
        Dim invini As tinvent
        invini = fnExistencia_inicial(id)
        Me.Inventario_finalTableAdapter.FillByid(Me.ClinicaDataSet.Inventario_final, id)
        If chk_cargarresumen.Checked Then
            Me.Sql_movimintos_al_inventario_area_resumenTableAdapter.FillByid(Me.ClinicaDataSet.sql_movimintos_al_inventario_area_resumen, id)
            SplitContainer3.Panel2Collapsed = False
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Cursor.Current = Cursors.WaitCursor
        Dim id As Integer = Rpt_productosDataGridView.CurrentRow.Cells(2).Value
        Me.Sql_movimintos_al_inventario_area_resumenTableAdapter.FillByid(Me.ClinicaDataSet.sql_movimintos_al_inventario_area_resumen, id)
        SplitContainer3.Panel2Collapsed = False
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub Sql_movimintos_al_inventario_area_resumenDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_movimintos_al_inventario_area_resumenDataGridView.CellDoubleClick
        cursor_wait()
        Dim id As Integer, area As String
        id = Rpt_productosDataGridView.CurrentRow.Cells(2).Value
        area = Sql_movimintos_al_inventario_area_resumenDataGridView.CurrentRow.Cells(1).Value

        Me.Sql_movimientos_al_inventario_x_areaTableAdapter.FillByid_Area(Me.ClinicaDataSet.sql_movimientos_al_inventario_x_area, id, area)
        SplitContainer4.Panel2Collapsed = False
        cursor_wait()
    End Sub

    Private Sub Sql_movimintos_al_inventario_area_resumenDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Sql_movimintos_al_inventario_area_resumenDataGridView.DataBindingComplete
        SplitContainer4.Panel2Collapsed = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class