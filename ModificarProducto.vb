Public Class ModificarProducto

    Dim i As New Implementacion
    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim f = New GestionProductos
        f.Show()
        Me.Hide()
    End Sub

    Sub rellenarCampos(p As Producto)
        txtId.Text = p.getId
        txtNombre.Text = p.getNombre
        txtNombreMostrar.Text = p.getNombreMostrar
        txtUnidad.Text = p.getUnidad
        txtCategoria.Text = p.getTipo
        txtSubcategoria.Text = p.getSubtipo
        txtPrecio.Text = p.getPrecio
        txtPrecioCoste.Text = p.getPrecioCoste
        txtPrecioFinal.Text = p.getPrecioFinal
        txtMargen.Text = p.getMargen
        txtBeneficio.Text = p.getBeneficio
        txtImpuesto.Text = p.getImpuesto
        txtImpuesto2.Text = p.getImpuesto2
        txtExistencias.Text = p.getExistencias
        chkFavorito.Checked = p.getFavorito
        txtImagen.Text = p.getImagen
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim p = New Producto(txtId.Text)
        i.borrarProducto(p)
        MessageBox.Show("Producto borrado.")
        Dim f = New GestionProductos
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        For i As Integer = 0 To txtNombre.Text.Length - 1
            If Not txtNombre.Text(i) Like "[A-Za-z ]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtNombreMostrar.Text.Length - 1
            If Not txtNombreMostrar.Text(i) Like "[A-Za-z ]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtUnidad.Text.Length - 1
            If Not txtUnidad.Text(i) Like "[A-Za-z ]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtPrecio.Text.Length - 1
            If Not txtPrecio.Text(i) Like "[0-9.,]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtPrecioCoste.Text.Length - 1
            If Not txtPrecioCoste.Text(i) Like "[0-9.,]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtPrecioFinal.Text.Length - 1
            If Not txtPrecioFinal.Text(i) Like "[0-9.,]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtImagen.Text.Length - 1
            If Not txtImagen.Text(i) Like "[A-Za-z ]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        If txtNombre.Text.Trim = "" Or txtNombreMostrar.Text.Trim = "" Or txtUnidad.Text.Trim = "" Or txtPrecio.Text.Trim = "" Or txtPrecioCoste.Text.Trim = "" Or txtPrecioFinal.Text.Trim = "" Or txtImagen.Text.Trim = "" Then
            MessageBox.Show("Campos incompletos")
        Else
            Dim p = New Producto(txtId.Text, txtNombre.Text, txtNombreMostrar.Text, txtUnidad.Text, txtCategoria.Text, txtSubcategoria.Text, txtPrecio.Text, txtPrecioCoste.Text, txtPrecioFinal.Text, txtMargen.Text, txtBeneficio.Text, txtImpuesto.Text, txtImpuesto2.Text, txtExistencias.Text, chkFavorito.Checked, txtImagen.Text)
            i.modificarProducto(p)
            MessageBox.Show("Producto modificado.")
            Dim f = New GestionProductos
            f.Show()
            Me.Hide()
        End If
    End Sub
End Class