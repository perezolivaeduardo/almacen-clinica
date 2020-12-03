Imports System.Windows.Forms

Public Class lotes_modificar_fechas

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Validate()
        Me.Inv_lotesBindingSource.EndEdit()
        Me.Inv_lotesTableAdapter.Update(Me.Recetas_dataset.inv_lotes)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub cargar(ByVal id As Integer)
        Me.Inv_lotesTableAdapter.FillByid(Me.Recetas_dataset.inv_lotes, id)
    End Sub

End Class
