Public Class recetas_modificar

    Private Sub RecetasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     

    End Sub

    Private Sub recetas_modificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.RecetasBindingSource.EndEdit()
        Me.RecetasTableAdapter.Update(Me.Recetas_dataset.recetas)
        Me.Close()
    End Sub
    Public Sub cargar(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.medicos' Puede moverla o quitarla según sea necesario.
        Me.MedicosTableAdapter.FillByrecetan(Me.ClinicaDataSet.medicos)
        Me.RecetasTableAdapter.FillByid(Me.Recetas_dataset.recetas, id)
        Me.MedicosBindingSource.Position = Me.MedicosBindingSource.Find("Id", id.ToString)
    End Sub


    Private Sub NombreComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Id_medicoTextBox.Text = NombreComboBox.SelectedValue
    End Sub
End Class