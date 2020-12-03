Public Class reporte_de_inventario

    Private Sub reporte_de_inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.inventarios' Puede moverla o quitarla según sea necesario.
        Me.inventariosTableAdapter.FillByarea(Me.clinicaDataSet.inventarios, fecha.Value.ToShortDateString)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class