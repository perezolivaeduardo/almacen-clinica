Public Class Inventario_Fisico

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub btn_generar_hoja_Click(sender As System.Object, e As System.EventArgs) Handles btn_generar_hoja.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere generar hoja de inventario en Tableta?"
        msgtitulo = "Prepara Inventrio"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub

        Dim tbl As DataTable
        Dim adap_clinica As New clinicaDataSetTableAdapters.nube_productos_para_inventariosTableAdapter
        Dim adap_nube As New nubedatasetTableAdapters.inventario_fisicoTableAdapter
        'lee la list de productos para inventarior
        Dim fe As Date
        fe = Now.ToShortDateString

        'determina si existe
        Dim i As Integer
        i = adap_nube.registros(fe)
        If i > 0 Then
            Dim dgb As New DialogResult
            dgb = MsgBox("Ya existen las hojas, quiere eliminarlas y generarlas de nuevo?", MsgBoxStyle.YesNo, "YA EXISTE")
            If dgb = Windows.Forms.DialogResult.No Then Exit Sub
            'borra registrs de determinada fecha
            adap_nube.Borra_fecha(fe)
        End If

        tbl = adap_clinica.GetData

        For j As Integer = 0 To tbl.Rows.Count - 1
            lblstatus.Text = "Registro " + j.ToString + " de " + tbl.Rows.Count.ToString
            StatusStrip1.Refresh()
            With tbl.Rows(j)
                adap_nube.Insert(fe, .Item(1), .Item(0), .Item(2), 0, 0, "")
            End With
        Next
        MsgBox("Terminado!")
        lblstatus.Text = "Terminado ...."
    End Sub
End Class