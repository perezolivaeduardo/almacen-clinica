Public Class Recepcion_de_Mercancia

    Private Sub Recepcion_de_Mercancia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.ClinicaDataSet.proveedores)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.inv_recepcion_mercancia' Puede moverla o quitarla según sea necesario.
        Me.Inv_recepcion_mercanciaTableAdapter.FillBystatus(Me.ClinicaDataSet.inv_recepcion_mercancia, 0)
        SplitContainer1.Panel2Collapsed = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        barra.Enabled = False
        SplitContainer1.Panel2Collapsed = False
        txtproveedor.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.Inv_recepcion_mercanciaBindingSource.EndEdit()
        Me.Inv_recepcion_mercanciaTableAdapter.Update(Me.ClinicaDataSet.inv_recepcion_mercancia)

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inv_recepcion_mercanciaBindingSource.CancelEdit()
        barra.Enabled = True
        SplitContainer1.Panel2Collapsed = True
    End Sub 'Btn_cancelar

    Private Sub btn_proveedor_Click(sender As System.Object, e As System.EventArgs) Handles btn_proveedor.Click
        Dim frm As New dlg_proveedores
        frm.ShowDialog()
        txtproveedor.Text = frm.pv
        Id_proveedorTextBox.Text = frm.id_pv
    End Sub

    Private Sub btn_guardar_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Id_user_capturoTextBox.Text = user_id
        FechaDateTimePicker.Value = Now

        Me.Validate()
        Me.Inv_recepcion_mercanciaBindingSource.EndEdit()
        Me.Inv_recepcion_mercanciaTableAdapter.Update(Me.ClinicaDataSet.inv_recepcion_mercancia)
        Me.Inv_recepcion_mercanciaTableAdapter.FillBystatus(Me.ClinicaDataSet.inv_recepcion_mercancia, 0)

        SplitContainer1.Panel2Collapsed = True
        barra.Enabled = True
    End Sub

    Private Sub Inv_recepcion_mercanciaDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Inv_recepcion_mercanciaDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Inv_recepcion_mercanciaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Inv_recepcion_mercanciaDataGridView.CellClick
        btn_Eliminar.Visible = True
    End Sub

    Private Sub btn_Eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Eliminar.Click
        Dim f As String = ""
        Try
            With Inv_recepcion_mercanciaDataGridView.CurrentRow
                f = "Prov. " + nombre_proveedor(.Cells(1).Value) + .Cells(3).Value
            End With

        Catch ex As Exception

        End Try
        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere eliminar el registro? "
        msgtitulo = "Eliminar "
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub

        Dim motivo As String = ""
        While motivo.Length = 0
            motivo = InputBox(user_nombre + ", cual es el motivo para eliminar el registro ", "Eliminar registro")
        End While
        cobalsky(f + " Motivo: " + motivo + " Fecha : " + Now.ToString)
        Inv_recepcion_mercanciaBindingSource.RemoveCurrent()
        Me.Inv_recepcion_mercanciaTableAdapter.Update(Me.ClinicaDataSet.inv_recepcion_mercancia)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim idpv, idrelacion As Integer, factura As String, ct As Boolean
        With Inv_recepcion_mercanciaDataGridView.CurrentRow
            idrelacion = .Cells(0).Value
            idpv = .Cells(1).Value
            factura = .Cells(4).Value
            ct = .Cells(8).Value ' contra Recibo
        End With
        ' valida si ya existe la factura
        Dim sql = "select * from inv_documentos where factura ='" + factura + "' and id_proveedor=" + idpv.ToString
        Dim tbl As DataTable = leer_tabla(sql)
        If tbl.Rows.Count > 0 Then
            MsgBox("Ya existe una factura " + factura)
            Beep()
            Exit Sub
        End If


        Dim frmEntrada As New entrada_nueva
        frmEntrada.Show()
        frmEntrada.TXTFACTURA.Text = factura
        frmEntrada.TXTIDPROV.Text = idpv
        frmEntrada.ProveedoresBindingSource.Position = frmEntrada.ProveedoresBindingSource.Find("id", idpv)
        frmEntrada.idRelacion = idrelacion
        frmEntrada.ContrareciboCheckBox.Checked = ct
        frmEntrada.lblstatus.Text = "Id referencia : " + idrelacion.ToString
    End Sub

    Private Sub Inv_recepcion_mercanciaDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Inv_recepcion_mercanciaDataGridView.DataBindingComplete
        lblpendinentes.Text = "Existen " + Inv_recepcion_mercanciaDataGridView.Rows.Count.ToString + " registros."
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Inv_recepcion_mercanciaTableAdapter.FillBystatus(Me.ClinicaDataSet.inv_recepcion_mercancia, 0)
    End Sub

    Private Sub btn_ver_capturadas_Click(sender As System.Object, e As System.EventArgs) Handles btn_ver_capturadas.Click
        Me.Inv_recepcion_mercanciaTableAdapter.FillBystatus(Me.ClinicaDataSet.inv_recepcion_mercancia, 1)
    End Sub
End Class