Public Class GestionProductos
    Dim i As New Implementacion

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Gestion.Show()
    End Sub
    Private Sub GestionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTODataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOTableAdapter.Fill(Me.PROYECTODataSet.PRODUCTO)
        comboCategoria.SelectedIndex = 0
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Text = ""
        txtNombreMostrar.Text = ""
        txtUnidad.Text = ""
        comboCategoria.SelectedIndex = 0
        comboSubcategoria.Text = ""
        txtPrecio.Text = ""
        txtPrecioCoste.Text = ""
        txtPrecioFinal.Text = ""
        txtBeneficio.Text = "0"
        txtMargen.Text = "0"
        txtImpuesto.Text = "0"
        txtImpuesto2.Text = "0"
        txtExistencias.Text = "0"
        chkFavorito.Checked = 0
        txtImagen.Text = ""
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
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
            If Not txtPrecio.Text(i) Like "[0-9,.]" Then
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
            Dim P As Producto
            If comboSubcategoria.SelectedIndex < 0 Then
                P = New Producto(txtNombre.Text, txtNombreMostrar.Text, txtUnidad.Text, comboCategoria.Items(comboCategoria.SelectedIndex).ToString, "0", Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtPrecioCoste.Text), Convert.ToDouble(txtPrecioFinal.Text), Convert.ToDouble(txtMargen.Text), Convert.ToDouble(txtBeneficio.Text), Convert.ToDouble(txtImpuesto.Text), Convert.ToDouble(txtImpuesto2.Text), Convert.ToInt32(txtExistencias.Text), chkFavorito.Checked, txtImagen.Text)
            Else
                P = New Producto(txtNombre.Text, txtNombreMostrar.Text, txtUnidad.Text, comboCategoria.Items(comboCategoria.SelectedIndex).ToString, comboSubcategoria.Items(comboSubcategoria.SelectedIndex).ToString, Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(txtPrecioCoste.Text), Convert.ToDouble(txtPrecioFinal.Text), Convert.ToDouble(txtMargen.Text), Convert.ToDouble(txtBeneficio.Text), Convert.ToDouble(txtImpuesto.Text), Convert.ToDouble(txtImpuesto2.Text), Convert.ToInt32(txtExistencias.Text), chkFavorito.Checked, txtImagen.Text)
            End If

            i.anadirProducto(P)
            txtNombre.Text = ""
            txtNombreMostrar.Text = ""
            txtUnidad.Text = ""
            comboCategoria.SelectedIndex = 0
            comboSubcategoria.Text = ""
            txtPrecio.Text = ""
            txtPrecioCoste.Text = ""
            txtPrecioFinal.Text = ""
            txtBeneficio.Text = "0"
            txtMargen.Text = "0"
            txtImpuesto.Text = "0"
            txtImpuesto2.Text = "0"
            txtExistencias.Text = "0"
            chkFavorito.Checked = 0
            txtImagen.Text = ""
            Me.PRODUCTOTableAdapter.Fill(Me.PROYECTODataSet.PRODUCTO)
            MessageBox.Show("Producto añadido.")
            comboCategoria.SelectedIndex = 0
        End If
    End Sub

    Private Sub comboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCategoria.SelectedIndexChanged
        Select Case comboCategoria.Text
            Case "TAPAS"
                comboSubcategoria.Text = ""
                comboSubcategoria.Items.Clear()
                'Crear 1 array con las subcategorias que pertenezcan a la categoria del case y añadirlas en un bucle for al combo
                comboSubcategoria.Items.Add("BOCATITAS")
                comboSubcategoria.Items.Add("SANDWICHES")
                comboSubcategoria.Items.Add("CAZUELITAS")
            Case "PLATOS"
                comboSubcategoria.Text = ""
                comboSubcategoria.Items.Clear()
                comboSubcategoria.Items.Add("ENTRANTES")
                comboSubcategoria.Items.Add("PRIMEROS")
                comboSubcategoria.Items.Add("SEGUNDOS")
            Case Else
                comboSubcategoria.Text = ""
                comboSubcategoria.Items.Clear()
        End Select
    End Sub

    Private Sub PRODUCTODataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PRODUCTODataGridView.CellDoubleClick
        Dim p As New Producto
        Dim t As Integer = e.RowIndex
        If PRODUCTODataGridView.Rows(t).Cells(0).Value < 0 Then
            Console.WriteLine("Error")
        Else
            p = i.obtenerProducto(PRODUCTODataGridView.Rows(t).Cells(0).Value)
        End If

        Dim f = New ModificarProducto
        f.rellenarCampos(p)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To txtImpuestoMod.Text.Length - 1
            If Not txtImpuestoMod.Text(i) Like "[0-9]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        For i As Integer = 0 To txtImpuesto2Mod.Text.Length - 1
            If Not txtImpuesto2Mod.Text(i) Like "[0-9]" Then
                MessageBox.Show("Campos erróneos")
                Exit Sub
            End If
        Next

        If (txtImpuestoMod.Text.Trim = "" Or txtImpuesto2Mod.Text.Trim = "") Then
            MessageBox.Show("Campos incompletos")
        Else
            i.modificarImpuesto(txtImpuestoMod.Text, txtImpuesto2Mod.Text)
            MessageBox.Show("Impuestos modificados.")
            txtImpuestoMod.Text = ""
            txtImpuesto2Mod.Text = ""
            Me.PRODUCTOTableAdapter.Fill(Me.PROYECTODataSet.PRODUCTO)
        End If
    End Sub
End Class