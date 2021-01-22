Public Class CambiarUsuario

    Dim i As New Implementacion
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim trabajador As Trabajador = i.obtenerUsuario(txtNombreUsuario.Text, txtClave.Text)
        If trabajador.getDni <> "-1" Then
            Terminal.txtUsuario.Text = trabajador.getNombre
            Terminal.dniEmpleado = trabajador.getDni
            Terminal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario no encontrado")
            txtNombreUsuario.Text = ""
            txtClave.Text = ""
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Terminal.Show()
        Me.Hide()
    End Sub
End Class