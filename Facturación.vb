Public Class Facturación

    Dim i As New Implementacion
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        i.obtenerPedidos(dtpFechaInicio.Value.ToString.Split(" ")(0), dtpFechaFin.Value.ToString.Split(" ")(0), DataGridView1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class