Public Class ModificarExistencias

    Dim i As New Implementacion
    Dim id As Integer
    Dim existenciasActuales As Integer
    Dim existenciasModif As Integer

    Sub rellenarCampos(aid As String, nombre As String, existencias As String)
        id = CInt(aid)
        existenciasActuales = CInt(existencias)
        txtNombre.Text = nombre
        txtExistenciasActuales.Text = existencias
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        For i As Integer = 0 To txtExistencias.Text.Length - 1
            If Not txtExistencias.Text(i) Like "[0-9]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        If (txtExistencias.Text.Trim = "") Then
            MessageBox.Show("Campos incompletos")
        Else
            existenciasModif = CInt(txtExistencias.Text)
            i.anadirExistencias(existenciasActuales + existenciasModif, id)
            MessageBox.Show("Existencias añadidas")
            Dim f = New GestionExistencia
            f.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        For i As Integer = 0 To txtExistencias.Text.Length - 1
            If Not txtExistencias.Text(i) Like "[0-9]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        If (txtExistencias.Text.Trim = "") Then
            MessageBox.Show("Campos incompletos")
        Else
            existenciasModif = CInt(txtExistencias.Text)
            i.anadirExistencias(existenciasActuales - existenciasModif, id)
            MessageBox.Show("Existencias borradas")
            Dim f = New GestionExistencia
            f.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        GestionExistencia.Show()
    End Sub
End Class