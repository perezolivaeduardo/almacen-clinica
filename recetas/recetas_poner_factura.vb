Imports System.Windows.Forms

Public Class recetas_poner_factura

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Validate()
        Me.Inv_documentosBindingSource.EndEdit()
        Me.Inv_documentosTableAdapter.Update(Me.ClinicaDataSet.inv_documentos)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub CARGAR(ByVal ID As Integer)
        Me.Inv_documentosTableAdapter.FillByid(Me.ClinicaDataSet.inv_documentos, ID)

    End Sub
End Class
