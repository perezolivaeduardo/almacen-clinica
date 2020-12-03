Public Class Inv_crear_hoja

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim msg As String, ix As MsgBoxResult
        msg = "Quiere generar hojas de inventario para esta fecha " + fecha.Value.ToShortDateString
        ix = MsgBox(msg, MsgBoxStyle.YesNo)
        If ix = MsgBoxResult.No Then Exit Sub
        Dim cmd As String, f As String
        cmd = "INSERT INTO inventarios ( fecha, id_area, area, id_categoria, Categoria, id_producto, Descripcion, stock, contado, consumo, cexterna ) " _
        & " SELECT [kfecha] AS fecha, stocks.id_area, areas.area, stocks.id_categoria, categorias.Categoria, stocks.id_producto, Productos.Descripcion, stocks.maximo, stocks.maximo, 0 AS Expr1, 0 AS Expr2 " _
        & "FROM (categorias INNER JOIN (stocks INNER JOIN areas ON stocks.id_area = areas.id_area) ON categorias.Id_categoria = stocks.id_categoria) INNER JOIN Productos ON stocks.id_producto = Productos.id_producto where stocks.maximo>0 and stocks.consumible=0"
        f = "#" + Format(fecha.Value, "MM/dd/yyyy") + "#"
        cmd = cmd.Replace("[kfecha]", f)
        commando(cmd)
        MsgBox("Hojas de inventarios creadas con fecha de " + fecha.Value.ToShortDateString)
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd, f As String, ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere borrar esta hoja", MsgBoxStyle.YesNo)
        If ix = MsgBoxResult.Yes Then
            cmd = "DELETE inventarios.fecha, inventarios.* FROM(inventarios) WHERE inventarios.fecha=[fe] "
            f = "#" + Format(fecha.Value, "MM/dd/yyyy") + "#"
            cmd = cmd.Replace("[fe]", f)
            If commando(cmd) = True Then
                MsgBox("Hoja Borrada!!!")
            End If
        End If
    End Sub
End Class