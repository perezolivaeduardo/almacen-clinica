Module clinica
    Public sql_consumoxareaxfecha As String
    Public sql_consumoxfechaxarea_detalle As String
    Public sql_surtidoxareaxfecha As String
    Public sql_consulta_externa As String
    Public sql_Actualiza_descripcion As String
    Public user_id As Integer = 0
    Public user_nick As String = ""
    Public user_nombre As String = ""
    Public fileini As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\clinica.ini"
    Public global_producto As Integer


    Function leer_tabla(ByVal cmd As String) As DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.clinicaCS
        da = New Data.OleDb.OleDbDataAdapter(cmd, cs)
        da.Fill(tbl)
        leer_tabla = tbl
    End Function
    Public Function sqlfecha(ByVal fecha As Date) As String
        sqlfecha = "#" + Format(fecha, "MM/dd/yyyy") + "#"
    End Function

    Sub ini()

        sql_Actualiza_descripcion = "UPDATE stocks INNER JOIN Productos ON stocks.id_producto = Productos.id_producto SET stocks.descripcion = [productos].[Descripcion];"

        sql_consumoxareaxfecha = "SELECT areas.id_area, areas.area, hs_productos.Id_producto, Productos.Descripcion, Sum(hs_productos.Cantidad) AS Cant, hs_productos.id_usuario, usuarios.Nombre, Format(CVDate(hs_productos.fecha),'dd/mm/yyyy') AS fecha, " _
        & "IIf([hs_productos].[Tipo]=9,'C.Externa','Hospital') AS T,hs_productos.id_receta FROM ((areas INNER JOIN hs_productos ON areas.id_area = hs_productos.area) INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN usuarios ON hs_productos.id_usuario = usuarios.id_user " _
        & " GROUP BY areas.id_area, areas.area, hs_productos.Id_producto, Productos.Descripcion, hs_productos.id_usuario, usuarios.Nombre, Format(CVDate(hs_productos.fecha),'dd/mm/yyyy'), IIf([hs_productos].[Tipo]=9,'C.Externa','Hospital'),hs_productos.id_receta " _
        & " HAVING (((hs_productos.Id_producto)=*id) AND ((Format(CVDate(hs_productos.fecha),'dd/mm/yyyy'))=*fecha))"

        sql_consumoxfechaxarea_detalle = "SELECT areas.id_area, areas.area, hs_productos.Id_producto, Productos.Descripcion, hs_productos.Cantidad, hs_productos.id_usuario, usuarios.Nombre, Format(CVDate(hs_productos.fecha),'dd/mm/yyyy') AS fecha, IIf([hs_productos].[Tipo]=9,'C.Externa','Hospital') AS T " _
        & " FROM ((areas INNER JOIN hs_productos ON areas.id_area = hs_productos.area) INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) INNER JOIN usuarios ON hs_productos.id_usuario = usuarios.id_user " _
        & " WHERE (((hs_productos.Id_producto)=*id) AND ((Format(CVDate(hs_productos.fecha),'dd/mm/yyyy'))=*fecha))"

        sql_surtidoxareaxfecha = "SELECT areas.area, Productos.Descripcion, inv_movimientos.cantidad " _
        & " FROM (inv_movimientos INNER JOIN Productos ON inv_movimientos.id_producto = Productos.id_producto) INNER JOIN areas ON inv_movimientos.id_Area = areas.id_area " _
        & "  WHERE(((inv_movimientos.id_producto) = *id) And ((inv_movimientos.fecha) = *fecha) And ((inv_movimientos.tipo) = 2)) " _
        & " ORDER BY areas.area"

        sql_consulta_externa = "SELECT notas_de_venta.id_nota, notas_de_venta.fecha, hs_productos.Id_producto, Productos.Descripcion, hs_productos.Cantidad, hs_productos.Tipo " _
        & "FROM areas INNER JOIN ((notas_de_venta INNER JOIN hs_productos ON notas_de_venta.id_nota = hs_productos.id_hs) INNER JOIN Productos ON hs_productos.Id_producto = Productos.id_producto) ON areas.id_area = hs_productos.area" _
        & " WHERE (((notas_de_venta.fecha)=*fecha) AND ((hs_productos.Id_producto)<>538) AND ((hs_productos.Tipo)=9))"

    End Sub

    Public Function resumen_de_consumo(ByVal id As Integer, ByVal fecha As Date) As DataTable
        Dim cmd As String
        cmd = sql_consumoxareaxfecha.Replace("*id", id.ToString)
        cmd = cmd.Replace("*fecha", sqlfecha(fecha))
        resumen_de_consumo = leer_tabla(cmd)
    End Function
    Function commando(ByVal comando As String) As Boolean
        Using conection As New OleDb.OleDbConnection(My.Settings.clinicacs)
            conection.Open()
            Dim AdaptadorDeDatos As New Data.OleDb.OleDbDataAdapter
            Dim cs As String = My.Settings.clinicacs.ToString
            Dim Command As New Data.OleDb.OleDbCommand(comando, conection)
            AdaptadorDeDatos.DeleteCommand = Command
            Try
                AdaptadorDeDatos.DeleteCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        End Using
        commando = True
    End Function

End Module
