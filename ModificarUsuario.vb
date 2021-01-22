Public Class ModificarUsuario

    Dim i As New Implementacion
    Private Sub ModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim f = New GestionUsuario
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim t = New Trabajador(txtDni.Text)
        i.borrarTrabajador(t)
        MessageBox.Show("Usuario eliminado.")
        Dim f = New GestionUsuario
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        For i As Integer = 0 To txtNombre.Text.Length - 1
            If Not txtNombre.Text(i) Like "[A-Za-z ]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        If (txtDni.Text.Trim = "" Or txtNombre.Text.Trim = "" Or txtNombreUsuario.Text.Trim = "" Or txtClave.Text.Trim = "") Then
            MessageBox.Show("Campos incompletos")
        Else
            Dim t = New Trabajador(txtDni.Text, txtNombre.Text, txtNombreUsuario.Text, dtpFecha.Value.ToString.Split(" ")(0), txtClave.Text)
            i.modificarTrabajador(t)
            MessageBox.Show("Usuario modificado.")
            Dim f = New GestionUsuario
            f.Show()
            Me.Hide()
        End If
    End Sub

    Sub rellenarCampos(t As Trabajador)
        txtDni.Text = t.getDni
        txtNombre.Text = t.getNombre
        txtNombreUsuario.Text = t.getNombreUsuario
        dtpFecha.Value = t.getFechaNacimiento
        txtClave.Text = t.getClave
    End Sub
End Class