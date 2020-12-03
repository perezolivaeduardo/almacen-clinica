Public Class Bitacora

    Private Sub BitacoraBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Bitacora_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.bitacora' Puede moverla o quitarla según sea necesario.
        Me.BitacoraTableAdapter.FillByAlmacen(Me.ClinicaDataSet.bitacora)

    End Sub
End Class