Public Class inventarios_hojas

    Private Sub inventarios_hojas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clinicaDataSet.EnforceConstraints = False
        Me.inv_lista_productosTableAdapter.FillByInventario(Me.clinicaDataSet.inv_lista_productos)
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_productos_Xarea' Puede moverla o quitarla según sea necesario.
        '  Me.sql_alma_productos_XareaTableAdapter.Fill(Me.clinicaDataSet.sql_alma_productos_Xarea)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class