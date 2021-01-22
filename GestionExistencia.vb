Public Class GestionExistencia

    Dim i As New Implementacion
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Gestion.Show()
    End Sub

    Private Sub GestionExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i.rellenarExistencias(DataGridView1)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim x As Integer = e.RowIndex

        If Not DataGridView1.Rows(x).Index + 1 = DataGridView1.Rows.Count Then
            Dim f = New ModificarExistencias
            f.rellenarCampos(DataGridView1.Rows(x).Cells(0).Value.ToString, DataGridView1.Rows(x).Cells(2).Value.ToString, DataGridView1.Rows(x).Cells(6).Value.ToString)
            f.Show()
            Me.Hide()
        End If
    End Sub
End Class