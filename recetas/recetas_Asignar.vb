Public Class recetas_Asignar

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.ProductosTableAdapter.Update(Me.Recetas_dataset.Productos)

    End Sub

    Private Sub recetas_Asignar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Recetas_dataset.recetas' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'Recetas_dataset.inv_lotes' Puede moverla o quitarla según sea necesario.

        'TODO: esta línea de código carga datos en la tabla 'Recetas_dataset.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.FillByantibiotico(Me.Recetas_dataset.Productos)

    End Sub

    Private Sub RecetasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RecetasDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim id As Integer = Me.Id_productoTextBox.Text
        Dim tlotes, trecetas As DataTable

        Me.RecetasTableAdapter.FillByproducto(Me.Recetas_dataset.recetas, id)
        Me.Inv_lotesTableAdapter.FillByproducto(Me.Recetas_dataset.inv_lotes, id)

        Dim adap As New recetas_datasetTableAdapters.recetasTableAdapter

        tlotes = Me.Inv_lotesTableAdapter.GetDataByproducto(id)
        trecetas = Me.RecetasTableAdapter.GetDataByproducto(id)
        For nl As Integer = 0 To tlotes.Rows.Count - 1
            Dim lcant As Integer, asignadas As Integer, rcant, r As Integer
            asignadas = 0 : r = 0
            lcant = tlotes.Rows(nl).Item("cantidad")
            Dim id_lote As Integer = tlotes.Rows(nl).Item("id")
            Dim lote As String = tlotes.Rows(nl).Item("lote")

            While asignadas < lcant
                If r <= trecetas.Rows.Count - 1 Then
                    rcant = trecetas.Rows(r).Item("cantidad")
                    If rcant > 0 Then
                        Dim rid As Integer = trecetas.Rows(r).Item("id")
                        Dim disponibles As Integer = lcant - asignadas
                        If rcant <= disponibles Then
                            adap.Actualiza_lote(id_lote, lote, rid)
                            trecetas.Rows(r).Item("cantidad") = 0
                            asignadas += rcant
                        End If
                    End If

                    r += 1
                Else
                    asignadas = lcant
                End If
            End While
        Next
    End Sub

    Private Sub SplitContainer2_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim id As Integer = Me.Id_productoTextBox.Text
        Me.RecetasTableAdapter.FillByproducto(Me.Recetas_dataset.recetas, id)
        Me.Inv_lotesTableAdapter.FillByproducto(Me.Recetas_dataset.inv_lotes, id)
    End Sub

    Private Sub CambiarDeMedicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class