Public Class frm_Ocompra_relacion

    Private Sub frm_Ocompra_relacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OrdenesDS.sql_Ocompra' Puede moverla o quitarla según sea necesario.
        Me.Sql_OcompraTableAdapter.Fill(Me.OrdenesDS.sql_Ocompra)

    End Sub

    Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
        Dim proveedor, capturo As String, norden As Integer
        proveedor = Sql_OcompraDataGridView.CurrentRow.Cells("dgvproveedor").Value
        capturo = Sql_OcompraDataGridView.CurrentRow.Cells("dgvcapturo").Value
        norden = Sql_OcompraDataGridView.CurrentRow.Cells(0).Value
        Dim frm As New Ocompra_Impresion
        frm.cargar(norden, proveedor, capturo)
        frm.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frm As New frm_Ocompra_nuevo
        frm.ShowDialog()
    End Sub
End Class