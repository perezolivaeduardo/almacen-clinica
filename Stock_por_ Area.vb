Public Class Stock_por__Area

    Private Sub Stock_por__Area_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.sql_alma_stocks' Puede moverla o quitarla según sea necesario.
        Me.sql_alma_stocksTableAdapter.Fill(Me.clinicaDataSet.sql_alma_stocks)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub boton_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_salir.Click
        Me.Close()
    End Sub
End Class