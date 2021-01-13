Public Class Stock_por__Area

    
    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub

    Public Sub cargar_area(ByVal area As Integer)
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_stocks' Puede moverla o quitarla según sea necesario.
        clinicaDataSet.EnforceConstraints = False
        Me.sql_alma_stocksTableAdapter.FillByarea(Me.clinicaDataSet.sql_alma_stocks, area)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub cargar_todos()
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_stocks' Puede moverla o quitarla según sea necesario.
        Me.sql_alma_stocksTableAdapter.Fill(Me.clinicaDataSet.sql_alma_stocks)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub cargar_consumibles()
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_stocks' Puede moverla o quitarla según sea necesario.
        Me.sql_alma_stocksTableAdapter.FillByConsumibles(Me.clinicaDataSet.sql_alma_stocks)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class