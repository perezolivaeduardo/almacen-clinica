Public Class inv_calcula_Existencia

    Private Sub inv_calcula_Existencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AreasTableAdapter.FillByinventario(Me.ClinicaDataSet.areas)
        For j As Integer = 0 To Me.ClinicaDataSet.areas.Rows.Count - 1
            Dim a As String = Me.ClinicaDataSet.areas.Rows(j).Item(1)
            lista.Items.Add(a)
        Next

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer, s As String = "", sql As String
        Dim adap As New clinicaDataSetTableAdapters.areasTableAdapter
        sql = "DELETE inventarios.fecha, inventarios.id_area, inventarios.* FROM inventarios WHERE inventarios.fecha=#[FE]# "
        sql = sql.Replace("[FE]", Format(fecha_mov.Value, "MM/dd/yyyy").ToString)
        For j As Integer = 0 To lista.CheckedItems.Count - 1
            s = lista.CheckedItems(j)
            sql += " AND inventarios.id_area <> " + adap.id(s).ToString
        Next
        'MsgBox(sql)
        Dim ok As Boolean = commando(sql)

        calcular()
    End Sub
    Private Sub calcular()
        Status.Visible = True
        Dim cmd, f1, f2 As String
        cmd = "SELECT hs_productos.Id_producto as id, hs_productos.area as area, Sum(hs_productos.Cantidad) AS cantidad " _
        & " FROM hs_productos WHERE hs_productos.fecha >= #[f1]# And hs_productos.fecha <= #[f2]# " _
        & " GROUP BY hs_productos.Id_producto, hs_productos.area "
        f1 = Format(fecha.Value, "MM/dd/yyyy") + " 00:00:00"
        f2 = Format(fecha_mov.Value, "MM/dd/yyyy") + " " + Format(hinicio.Value, "HH:mm:00")
        cmd = cmd.Replace("[f1]", f1)
        cmd = cmd.Replace("[f2]", f2)
        Dim tbl As DataTable = leer_tabla(cmd)
        tr.Text = tbl.Rows.Count
        bar.Maximum = tbl.Rows.Count
        Dim adap As New clinicaDataSetTableAdapters.inventariosTableAdapter
        Status.Refresh()
        Dim f As Date = fecha_mov.Value.ToShortDateString
        adap.Borra_consumo_del_dia(f) 'pone a ceros consumos del inventario
        For j As Integer = 0 To tbl.Rows.Count - 1
            Dim a As Integer, id As Integer, cant As Integer
            a = tbl.Rows(j).Item("area")
            id = tbl.Rows(j).Item("id")
            cant = tbl.Rows(j).Item("cantidad")
            adap.Actualiza_consumo(cant, f, a, id)
            bar.Value = j
            Status.Refresh()
        Next
        MsgBox("Calculo terminado")
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AreasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AreasBindingSource.EndEdit()
        Me.AreasTableAdapter.Update(Me.ClinicaDataSet.areas)

    End Sub

    Private Sub AreasBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AreasBindingSource.EndEdit()
        Me.AreasTableAdapter.Update(Me.ClinicaDataSet.areas)
    End Sub
End Class