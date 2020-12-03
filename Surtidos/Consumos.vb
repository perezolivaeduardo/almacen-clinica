Public Class Consumos
    Dim bs As New BindingSource
    Private Sub Consumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'clinicaDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.FillByinventario(Me.clinicaDataSet.areas)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CDate(Now.Date) = CDate(del.Value.Date) And My.Settings.trabajaenred = False Then
            Dim ix As MsgBoxResult = MsgBox("Recuerde que esta trabajando con una copia de la base de datos, si quiere informacion actualizada , cambie el modo de trabajar en Tiempo real, Quiere Continuar", MsgBoxStyle.YesNo, "Trabajo en modo local")
            If ix = MsgBoxResult.No Then Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        cargar(Me.del.Value.Date)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cargar(ByVal fecha As Date)
        Dim cmd, cg, f As String
        cmd = " SELECT areas.area, hs_productos.id_hs, hs_productos.Tipo, hs_productos.Id_producto, Productos.Descripcion, hs_productos.Cantidad, Productos.tipo, Productos.consigna, categorias.Categoria, CVDate([hs_productos].[fecha]) AS fecha, categorias.Id_categoria, areas.id_area, hs_productos.turno, stocks.minimo, stocks.maximo, stocks.dosis, stocks.consumible, areas.inventario " _
        & "FROM stocks INNER JOIN (((hs_productos INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN areas ON hs_productos.area = areas.id_area) INNER JOIN categorias ON Productos.id_categoria = categorias.Id_categoria) ON (hs_productos.area = stocks.id_area) AND (stocks.id_producto = hs_productos.Id_producto) " _
        & "WHERE (((CVDate([hs_productos].[fecha]))>#[mifecha]# And (CVDate([hs_productos].[fecha]))<=#[mifechaal] 23:59:59#) AND ((categorias.Id_categoria)<>4) AND ((areas.id_area)<>11)) "
        f = Format(fecha, "MM-dd-yyyy")
        cg = cmd.Replace("[mifecha]", f)
        cg = cg.Replace("[mifechaal]", f)
        bs.DataSource = leer_tabla(cg)
        dgv.DataSource = bs
        Try
            With dgv
                .Columns(2).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargar_cerradas(ByVal fecha As Date)
        Dim cmd, cg, f As String
        cmd = " SELECT areas.area, hs_productos_x_surtir.id_hs, hs_productos_x_surtir.Tipo, hs_productos_x_surtir.Id_producto, Productos.Descripcion, hs_productos_x_surtir.Cantidad, Productos.tipo, Productos.consigna, categorias.Categoria, CVDate([hs_productos_x_surtir].[fecha Cierre]) AS fecha, categorias.Id_categoria, areas.id_area, hs_productos_x_surtir.turno, stocks.minimo, stocks.maximo, stocks.dosis, stocks.consumible, areas.inventario " _
        & "FROM stocks INNER JOIN (((hs_productos_x_surtir INNER JOIN Productos ON hs_productos_x_surtir.Id_producto = Productos.id_producto) INNER JOIN areas ON hs_productos_x_surtir.area = areas.id_area) INNER JOIN categorias ON Productos.id_categoria = categorias.Id_categoria) ON (hs_productos_x_surtir.area = stocks.id_area) AND (stocks.id_producto = hs_productos_x_surtir.Id_producto) " _
        & "WHERE ((CVDate([hs_productos_x_surtir].[fecha Cierre]))=#[mifecha]#  AND ((categorias.Id_categoria)<>4) AND ((areas.id_area)<>11)) "
        f = Format(fecha, "MM-dd-yyyy")
        cg = cmd.Replace("[mifecha]", f)
        cg = cg.Replace("[mifechaal]", f)
        bs.DataSource = leer_tabla(cg)
        dgv.DataSource = bs
        Try
            With dgv
                .Columns(2).Visible = False
                .Columns(6).Visible = False
                .Columns(7).Visible = False
                .Columns(10).Visible = False
                .Columns(11).Visible = False
                .Columns(12).Visible = False
                .Columns(13).Visible = False
                .Columns(15).Visible = False
                .Columns(16).Visible = False
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AreaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaComboBox.SelectedIndexChanged
        Dim filtro As String = "area = '" + AreaComboBox.Text + "'"
        Me.Text = "Prodcutos del " + filtro
        bs.Filter = filtro
    End Sub

    Private Sub boton_quitar_filtros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_quitar_filtros.Click
        descripciontxt.Text = ""
        bs.Filter = ""
        Me.Text = "Todos los productos del Dia"
    End Sub

    Private Sub descripciontxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles descripciontxt.TextChanged
        Dim filtro As String = ""
        If Me.Filtrar_area.Checked = True Then
            filtro = "area = '" + AreaComboBox.Text + "' and "
        End If

        Try
            filtro += "Descripcion like '%" + descripciontxt.Text + "%'"
            Me.Text = "Todos los registros que contengan '" + descripciontxt.Text + "'"
            bs.Filter = filtro
        Catch ex As Exception
            bs.Filter = ""
            Me.Text = "Todos los productos del Dia"
        End Try

    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Me.descripciontxt.Text = dgv.CurrentRow.Cells("Descripcion").Value
    End Sub

    Private Sub Filtrar_area_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtrar_area.CheckedChanged
        Me.AreaComboBox.Enabled = Me.Filtrar_area.Checked
        descripciontxt.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CDate(Now.Date) = CDate(del.Value.Date) And My.Settings.trabajaenred = False Then
            Dim ix As MsgBoxResult = MsgBox("Recuerde que esta trabajando con una copia de la base de datos, si quiere informacion actualizada , cambie el modo de trabajar en Tiempo real, Quiere Continuar", MsgBoxStyle.YesNo, "Trabajo en modo local")
            If ix = MsgBoxResult.No Then Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        cargar_cerradas(Me.del.Value.Date)
        Me.Cursor = Cursors.Default
    End Sub
End Class