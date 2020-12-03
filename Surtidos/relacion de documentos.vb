Public Class relacion_de_documentos

    Private Sub relacion_de_documentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_sql_documentos' Puede moverla o quitarla según sea necesario.
        Me.Inv_sql_documentosTableAdapter.FillBytipo(Me.ClinicaDataSet.inv_sql_documentos, 7)

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.imprimir_salida.cargar(FolioTextBox.Text, Inv_documentos_tipoTextBox.Text, "Salida de Almacen para : " + AreaTextBox.Text + " No." + FolioTextBox.Text, FechaDateTimePicker.Value.ToShortDateString)
        My.Forms.imprimir_salida.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim frm As New salida_nueva
        frm.ShowDialog()

        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_sql_documentos' Puede moverla o quitarla según sea necesario.
        Me.Inv_sql_documentosTableAdapter.FillBytipo(Me.ClinicaDataSet.inv_sql_documentos, 7)

    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere eliminar la entrada No. " + FolioTextBox.Text
        msgtitulo = "Titulo"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub
        Dim adapdoc As New clinicaDataSetTableAdapters.inv_documentosTableAdapter
        Dim adapmov As New clinicaDataSetTableAdapters.inv_movimientosTableAdapter

        adapdoc.borrar(FolioTextBox.Text, Inv_documentos_tipoTextBox.Text)
        adapmov.borrar(FolioTextBox.Text, Inv_documentos_tipoTextBox.Text)
        Me.Inv_sql_documentosTableAdapter.FillBytipo(Me.ClinicaDataSet.inv_sql_documentos, 7)


    End Sub
End Class