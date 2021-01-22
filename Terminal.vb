Public Class Terminal

    Dim i As New Implementacion
    Dim productosPedidoActivo() As Producto
    Public descuento As Double = 0
    Public dniEmpleado As String = "16636822W"

    Private Sub Terminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productosPedidoActivo = New Producto() {}
        ListView1.View = View.Details
        ListView1.Columns.Add("Eliminar", 20)
        ListView1.Columns.Add("Producto", 200)
        ListView1.Columns.Add("Precio", 50)
        ListView1.Columns.Add("Cant", 50)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Sub crearBotonesProductos(productos As Producto())
        'Crear y rellenar la coleccion de botones
        Dim botones(productos.Length - 1) As Button
        Dim i As Integer
        For i = 0 To botones.Length - 1
            botones(i) = New Button()
            botones(i).Text = productos(i).getNombreMostrar
            botones(i).Name = productos(i).getId.ToString
            botones(i).Size = New System.Drawing.Size(90, 75)

            AddHandler botones(i).Click, AddressOf clickBtnProd
        Next

        'Limpiar botones anteriores
        Panel2.Controls.Clear()

        'Pintar los botones
        Dim j As Integer
        Dim fila As Integer = 0
        Dim p As New System.Drawing.Point(5, 5)

        For j = 0 To botones.Length - 1
            If j = 6 + fila * 6 Then
                p.X = 5
                p.Y = p.Y + 80
                fila += 1
            ElseIf j = 0 Then

            Else
                p.X = p.X + 95
            End If

            botones(j).Location = New System.Drawing.Point(p)
            Panel2.Controls.Add(botones(j))
        Next
    End Sub

    Sub clickBtnProd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim b As Button
        Dim idProducto As Integer
        Dim p As Producto

        b = CType(sender, Button)
        idProducto = b.Name

        p = i.obtenerProducto(idProducto)
        anadirProductoLista(p)
        actualizarTotal()
    End Sub

    Sub actualizarTotal()
        Dim importe As Double
        Dim cantidad As Integer

        For aux As Integer = 1 To productosPedidoActivo.Length
            cantidad = ListView1.Items(aux - 1).SubItems(3).Text
            importe = importe + productosPedidoActivo(aux - 1).getPrecioFinal() * cantidad
        Next

        lblImporte.Text = importe.ToString + " €"
    End Sub

    Sub anadirProductoLista(p As Producto)
        Dim activo As Boolean = False
        Dim x As Integer = productosPedidoActivo.Length

        Dim cantidad As Integer = 1
        If lblCantidad.Text <> 0 Then
            cantidad = lblCantidad.Text
        End If


        If Not productosPedidoActivo.Length = 0 Then
            For aux As Integer = 1 To productosPedidoActivo.Length
                If productosPedidoActivo(aux - 1).getId = p.getId Then
                    ListView1.Items(aux - 1).SubItems(3).Text = ListView1.Items(aux - 1).SubItems(3).Text + cantidad
                    activo = True
                End If
            Next
        Else
            Dim item As ListViewItem
            item = New ListViewItem("X")
            item.SubItems.Add(p.getNombreMostrar)
            item.SubItems.Add(p.getPrecioFinal.ToString)
            item.SubItems.Add(cantidad.ToString)
            ListView1.Items.Add(item)

            ReDim Preserve productosPedidoActivo(productosPedidoActivo.Length)
            productosPedidoActivo(productosPedidoActivo.Length - 1) = p
        End If

        If Not activo And Not x = 0 Then
            Dim item As ListViewItem
            item = New ListViewItem("X")
            item.SubItems.Add(p.getNombreMostrar)
            item.SubItems.Add(p.getPrecioFinal.ToString)
            item.SubItems.Add(cantidad.ToString)
            ListView1.Items.Add(item)

            ReDim Preserve productosPedidoActivo(productosPedidoActivo.Length)
            productosPedidoActivo(productosPedidoActivo.Length - 1) = p
        End If

        lblCantidad.Text = 0
        cantidad = 1
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblCantidad.Text = "0"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If lblCantidad.Text <> 0 And lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn0.Text
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn1.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn1.Text
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn2.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn2.Text
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn3.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn3.Text
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn4.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn4.Text
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn5.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn5.Text
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn6.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn6.Text
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn7.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn7.Text
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn8.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn8.Text
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblCantidad.Text = 0 Then
            lblCantidad.Text = btn9.Text
        ElseIf lblCantidad.Text.Length <= 6 Then
            lblCantidad.Text = lblCantidad.Text + btn9.Text
        End If
    End Sub

    Private Sub btnTapas_Click(sender As Object, e As EventArgs) Handles btnTapas.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("TAPASS")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = True
        btnBocatitas.Visible = True
        btnSandwich.Visible = True
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnPlatos_Click(sender As Object, e As EventArgs) Handles btnPlatos.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("PLATOSS")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = True
        btnPrimeros.Visible = True
        btnSegundos.Visible = True
    End Sub

    Private Sub btnCafe_Click(sender As Object, e As EventArgs) Handles btnCafe.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("CAFÉS")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnRefrescos_Click(sender As Object, e As EventArgs) Handles btnRefrescos.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("REFRESCOS")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnAlcohol_Click(sender As Object, e As EventArgs) Handles btnAlcohol.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("ALCOHOL")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnPostres_Click(sender As Object, e As EventArgs) Handles btnPostres.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("POSTRES")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnCopas_Click(sender As Object, e As EventArgs) Handles btnCopas.Click
        Dim productos() As Producto
        productos = i.obtenerProductos("COPAS")
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnFavorito_Click(sender As Object, e As EventArgs) Handles btnFavorito.Click
        Dim productos() As Producto
        productos = i.obtenerFavoritos()
        crearBotonesProductos(productos)
        btnCazuelitas.Visible = False
        btnBocatitas.Visible = False
        btnSandwich.Visible = False
        btnEntrantes.Visible = False
        btnPrimeros.Visible = False
        btnSegundos.Visible = False
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        Erase productosPedidoActivo
        productosPedidoActivo = New Producto() {}
        actualizarTotal()
        ListView1.Items.Clear()
    End Sub

    Private Sub btnFinalizarVenta_Click(sender As Object, e As EventArgs) Handles btnFinalizarVenta.Click
        Dim ped As Pedido = New Pedido(dniEmpleado, lblImporte.Text.Split(" ")(0))
        Dim idPedido As Integer = i.anadirPedido(ped)
        For aux As Integer = 1 To productosPedidoActivo.Length
            Dim producto As Producto = New Producto(productosPedidoActivo(aux - 1).getId)
            i.anadirProdsPedido(idPedido, producto, ListView1.Items(aux - 1).SubItems(3).Text)
        Next

        Erase productosPedidoActivo
        productosPedidoActivo = New Producto() {}
        actualizarTotal()
        ListView1.Items.Clear()
        MessageBox.Show("Pedido añadido")
    End Sub

    Private Sub btnBocatitas_Click(sender As Object, e As EventArgs) Handles btnBocatitas.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("BOCATITAS")
        crearBotonesProductos(productos)
    End Sub

    Private Sub btnSandwich_Click(sender As Object, e As EventArgs) Handles btnSandwich.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("SANDWICHES")
        crearBotonesProductos(productos)
    End Sub

    Private Sub btnCazuelitas_Click(sender As Object, e As EventArgs) Handles btnCazuelitas.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("CAZUELITAS")
        crearBotonesProductos(productos)
    End Sub

    Private Sub btnEntrantes_Click(sender As Object, e As EventArgs) Handles btnEntrantes.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("ENTRANTES")
        crearBotonesProductos(productos)
    End Sub

    Private Sub btnPrimeros_Click(sender As Object, e As EventArgs) Handles btnPrimeros.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("PRIMEROS")
        crearBotonesProductos(productos)
    End Sub

    Private Sub btnSegundos_Click(sender As Object, e As EventArgs) Handles btnSegundos.Click
        Dim productos() As Producto
        productos = i.obtenerProductosSubtipo("SEGUNDOS")
        crearBotonesProductos(productos)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim d As New CambiarUsuario
        d.Show()
        Me.Hide()
    End Sub
End Class