Imports System.Windows.Forms

Public Class frm_sel_proveedor
    Public id As Integer, nombre As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_sel_proveedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ProveedoresTableAdapter.Fill(Me.OrdenesDS.proveedores)
    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Dim f As String = "Nombre like '%" + txtfiltro.Text + "%'"
        ProveedoresBindingSource.Filter = f
    End Sub

    Private Sub ProveedoresDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellDoubleClick
        nombre = ProveedoresDataGridView.CurrentRow.Cells(1).Value
        id = ProveedoresDataGridView.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub
End Class
