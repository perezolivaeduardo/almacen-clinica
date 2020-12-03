Imports System.Windows.Forms

Public Class dlg_proveedores
    Public id_pv As Integer, pv As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        id_pv = ProveedoresDataGridView.CurrentRow.Cells(0).Value
        pv = ProveedoresDataGridView.CurrentRow.Cells(1).Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ProveedoresBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProveedoresBindingSource.EndEdit()
        Me.ProveedoresTableAdapter.Update(Me.ClinicaDataSet.proveedores)

    End Sub

    Private Sub dlg_proveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)

    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Try
            Dim f As String = "nombre like '%" + txtfiltro.Text + "%'"
            ProveedoresBindingSource.Filter = f
        Catch ex As Exception
            ProveedoresBindingSource.Filter = ""
        End Try
    End Sub

    Private Sub ProveedoresDataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresDataGridView.CellDoubleClick
        id_pv = ProveedoresDataGridView.CurrentRow.Cells(0).Value
        pv = ProveedoresDataGridView.CurrentRow.Cells(1).Value

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
