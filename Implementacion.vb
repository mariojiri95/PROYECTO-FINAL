Imports System.Data.SqlClient

Public Class Implementacion

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Dim dr As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim dt As DataTable

    Public Sub New()

    End Sub

    Public Function conectar() As SqlConnection
        Try
            'comprobar si es mejor abrirla y cerrarla cada vez o solo al principio y final
            conexion = New SqlConnection("Data Source=DESKTOP-206CMBT;Initial Catalog=PROYECTO;Integrated Security=True")
            conexion.Open()
            Console.WriteLine("Conectado")
        Catch ex As Exception
            Console.WriteLine("Error en la conexión")
        End Try
        Return conexion
    End Function

    Public Function desconectar() As SqlConnection
        Try
            'comprobar si es mejor abrirla y cerrarla cada vez o solo al principio y final
            conexion.Close()
            Console.WriteLine("Desconectado")
        Catch ex As Exception
            Console.WriteLine("Error en la desconexión")
        End Try
        Return conexion
    End Function
    Function obtenerProductos(tipo As String) As Producto()
        Dim productos() As Producto = New Producto() {}
        Dim consulta As String = "SELECT ID_PRODUCTO, NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN FROM PRODUCTO WHERE TIPO = '" + tipo + "';"

        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()

        While dr.Read
            Dim b As Boolean
            If dr.GetInt32(14) = 1 Then
                b = True
            Else
                b = False
            End If

            Dim p = New Producto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), Decimal.ToDouble(dr.GetDecimal(6)), Decimal.ToDouble(dr.GetDecimal(7)), Decimal.ToDouble(dr.GetDecimal(8)), Decimal.ToDouble(dr.GetDecimal(9)), Decimal.ToDouble(dr.GetDecimal(10)), Decimal.ToDouble(dr.GetDecimal(11)), Decimal.ToDouble(dr.GetDecimal(12)), dr.GetInt32(13), b, dr.GetString(15))
            ReDim Preserve productos(productos.Length)
            productos(productos.Length - 1) = p
        End While

        desconectar()
        Return productos
    End Function

    Function obtenerProductosSubtipo(subtipo As String) As Producto()
        Dim productos() As Producto = New Producto() {}
        Dim consulta As String = "SELECT ID_PRODUCTO, NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN FROM PRODUCTO WHERE SUBTIPO = '" + subtipo + "';"

        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()

        While dr.Read
            Dim b As Boolean
            If dr.GetInt32(14) = 1 Then
                b = True
            Else
                b = False
            End If

            Dim p = New Producto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), Decimal.ToDouble(dr.GetDecimal(6)), Decimal.ToDouble(dr.GetDecimal(7)), Decimal.ToDouble(dr.GetDecimal(8)), Decimal.ToDouble(dr.GetDecimal(9)), Decimal.ToDouble(dr.GetDecimal(10)), Decimal.ToDouble(dr.GetDecimal(11)), Decimal.ToDouble(dr.GetDecimal(12)), dr.GetInt32(13), b, dr.GetString(15))
            ReDim Preserve productos(productos.Length)
            productos(productos.Length - 1) = p
        End While

        desconectar()
        Return productos
    End Function

    Function obtenerFavoritos() As Producto()
        Dim productos() As Producto = New Producto() {}
        Dim consulta As String = "SELECT ID_PRODUCTO, NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN FROM PRODUCTO WHERE FAVORITO = 1;"

        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()

        While dr.Read
            Dim b As Boolean
            If dr.GetInt32(14) = 1 Then
                b = True
            Else
                b = False
            End If

            Dim p = New Producto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), Decimal.ToDouble(dr.GetDecimal(6)), Decimal.ToDouble(dr.GetDecimal(7)), Decimal.ToDouble(dr.GetDecimal(8)), Decimal.ToDouble(dr.GetDecimal(9)), Decimal.ToDouble(dr.GetDecimal(10)), Decimal.ToDouble(dr.GetDecimal(11)), Decimal.ToDouble(dr.GetDecimal(12)), dr.GetInt32(13), b, dr.GetString(15))
            ReDim Preserve productos(productos.Length)
            productos(productos.Length - 1) = p
        End While

        desconectar()
        Return productos
    End Function

    Function obtenerProducto(ByVal idProducto As Integer) As Producto
        Dim consulta As String = "SELECT ID_PRODUCTO, NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN FROM PRODUCTO
                                  WHERE ID_PRODUCTO = " + idProducto.ToString + ";"
        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()
        dr.Read()

        Dim b As Boolean
        If dr.GetInt32(14) = 1 Then
            b = True
        Else
            b = False
        End If

        Dim p = New Producto(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), Decimal.ToDouble(dr.GetDecimal(6)), Decimal.ToDouble(dr.GetDecimal(7)), Decimal.ToDouble(dr.GetDecimal(8)), Decimal.ToDouble(dr.GetDecimal(9)), Decimal.ToDouble(dr.GetDecimal(10)), Decimal.ToDouble(dr.GetDecimal(11)), Decimal.ToDouble(dr.GetDecimal(12)), dr.GetInt32(13), b, dr.GetString(15))

        desconectar()
        Return p
    End Function

    Sub anadirProducto(ByVal producto As Producto)
        Dim cadena As String
        Dim precio As String = producto.getPrecio.ToString.Replace(",", ".")
        Dim precioCoste As String = producto.getPrecioCoste.ToString.Replace(",", ".")
        Dim precioFinal As String = producto.getPrecioFinal.ToString.Replace(",", ".")
        Dim margen As String = producto.getMargen.ToString.Replace(",", ".")
        Dim beneficio As String = producto.getBeneficio.ToString.Replace(",", ".")
        Dim impuesto As String = producto.getImpuesto.ToString.Replace(",", ".")
        Dim impuesto2 As String = producto.getImpuesto2.ToString.Replace(",", ".")

        If producto.getFavorito Then
            cadena = "INSERT INTO PRODUCTO (NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN) VALUES ('" + producto.getNombre + "', '" + producto.getNombreMostrar + "', '" + producto.getUnidad + "', '" + producto.getTipo + "', '" + producto.getSubtipo + "', " + precio + ", " + precioCoste + ", " + precioFinal + ", " + margen + ", " + beneficio + ", " + impuesto + ", " + impuesto2 + ", " + producto.getExistencias.ToString + ", 1, '" + producto.getImagen + "');"
        Else
            cadena = "INSERT INTO PRODUCTO (NOMBRE, NOMBRE_A_MOSTRAR, UNIDAD_DE_MEDIDA, TIPO, SUBTIPO, PRECIO, PRECIO_COSTE, PRECIO_FINAL, MARGEN, BENEFICIO, IMPUESTO, IMPUESTO2, EXISTENCIAS, FAVORITO, IMAGEN) VALUES ('" + producto.getNombre + "', '" + producto.getNombreMostrar + "', '" + producto.getUnidad + "', '" + producto.getTipo + "', '" + producto.getSubtipo + "', " + precio + ", " + precioCoste + ", " + precioFinal + ", " + margen + ", " + beneficio + ", " + impuesto + ", " + impuesto2 + ", " + producto.getExistencias.ToString + ", 0, '" + producto.getImagen + "');"
        End If

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Registro añadido.")
        desconectar()
    End Sub

    Sub modificarProducto(p As Producto)
        Dim f As Integer
        Dim precio As String = p.getPrecio.ToString.Replace(",", ".")
        Dim precioCoste As String = p.getPrecioCoste.ToString.Replace(",", ".")
        Dim precioFinal As String = p.getPrecioFinal.ToString.Replace(",", ".")
        Dim margen As String = p.getMargen.ToString.Replace(",", ".")
        Dim beneficio As String = p.getBeneficio.ToString.Replace(",", ".")
        Dim impuesto As String = p.getImpuesto.ToString.Replace(",", ".")
        Dim impuesto2 As String = p.getImpuesto2.ToString.Replace(",", ".")

        If p.getFavorito() Then
            f = 1
        Else
            f = 0
        End If

        Dim cadena As String
        If f = 1 Then
            cadena = "UPDATE PRODUCTO SET NOMBRE = '" + p.getNombre + "', NOMBRE_A_MOSTRAR = '" + p.getNombreMostrar + "', UNIDAD_DE_MEDIDA = '" + p.getUnidad + "', TIPO = '" + p.getTipo + "', SUBTIPO = '" + p.getSubtipo + "', PRECIO = " + precio + ", PRECIO_COSTE = " + precioCoste + ", PRECIO_FINAL = " + precioFinal + ", MARGEN = " + margen + ", BENEFICIO = " + beneficio + ", IMPUESTO = " + impuesto + ", IMPUESTO2 = " + impuesto + ", EXISTENCIAS = '" + p.getExistencias.ToString + "', FAVORITO = '" + f.ToString + "', IMAGEN = '" + p.getImagen + "' WHERE ID_PRODUCTO = '" + p.getId.ToString + "';"
        Else
            cadena = "UPDATE PRODUCTO SET NOMBRE = '" + p.getNombre + "', NOMBRE_A_MOSTRAR = '" + p.getNombreMostrar + "', UNIDAD_DE_MEDIDA = '" + p.getUnidad + "', TIPO = '" + p.getTipo + "', SUBTIPO = '" + p.getSubtipo + "', PRECIO = " + precio + ", PRECIO_COSTE = " + precioCoste + ", PRECIO_FINAL = " + precioFinal + ", MARGEN = " + margen + ", BENEFICIO = " + beneficio + ", IMPUESTO = " + impuesto + ", IMPUESTO2 = " + impuesto + ", EXISTENCIAS = '" + p.getExistencias.ToString + "', FAVORITO = '" + f.ToString + "', IMAGEN = '" + p.getImagen + "' WHERE ID_PRODUCTO = '" + p.getId.ToString + "';"
        End If

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Registro modificado.")
        desconectar()
    End Sub

    Sub borrarProducto(p As Producto)
        Dim cadena As String = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO = '" + p.getId.ToString + "';"

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Producto eliminado.")
        desconectar()
    End Sub

    Function obtenerTrabajador(ByVal dni As String) As Trabajador
        Dim consulta As String = "SELECT DNI, NOMBRE, NOMBRE_USUARIO, FECHA_NACIMIENTO, CLAVE FROM TRABAJADOR WHERE DNI = '" + dni + "';"
        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()
        dr.Read()
        Dim t As Trabajador = New Trabajador(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetValue(3).ToString.Split(" ")(0), dr.GetString(4))
        desconectar()
        Return t
    End Function
    Sub anadirTrabajador(ByVal trabajador As Trabajador)
        Dim cadena As String
        cadena = "INSERT INTO TRABAJADOR (DNI, NOMBRE, NOMBRE_USUARIO, FECHA_NACIMIENTO, CLAVE) VALUES ('" + trabajador.getDni + "', '" + trabajador.getNombre + "', '" + trabajador.getNombreUsuario + "', '" + trabajador.getFechaNacimiento + "', '" + trabajador.getClave + "');"

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Registro añadido.")
        desconectar()
    End Sub
    Sub modificarTrabajador(t As Trabajador)
        Dim cadena As String = "UPDATE TRABAJADOR SET NOMBRE = '" + t.getNombre + "', NOMBRE_USUARIO ='" + t.getNombreUsuario + "', FECHA_NACIMIENTO ='" + t.getFechaNacimiento + "', CLAVE = '" + t.getClave + "' WHERE dni = '" + t.getDni + "';"

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Registro modificado.")
        desconectar()
    End Sub

    Sub borrarTrabajador(t As Trabajador)
        Dim cadena As String = "UPDATE TRABAJADOR SET NOMBRE_USUARIO = '***', CLAVE = '***' WHERE DNI = '" + t.getDni + "';"

        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Usuario eliminado.")
        desconectar()
    End Sub

    Function anadirPedido(ped As Pedido) As Integer
        Dim cadena As String
        Dim aux As String = ped.getImporte.ToString.Replace(",", ".")

        cadena = "INSERT INTO PEDIDO (DNI, FECHA, IMPORTE) VALUES ('" + ped.getDni + "', '" + Date.Now.ToString.Split(" ")(0) + "', '" + aux + "');"
        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Pedido añadido.")
        desconectar()

        Dim consulta As String
        Dim pedidos() As Pedido = New Pedido() {}
        consulta = "SELECT ID_PEDIDO FROM PEDIDO"
        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()
        While dr.Read()
            Dim p As Pedido = New Pedido(dr.GetInt32(0))
            ReDim Preserve pedidos(pedidos.Length)
            pedidos(pedidos.Length - 1) = p
        End While

        desconectar()
        Return pedidos(pedidos.Length - 1).getId
    End Function

    Sub anadirProdsPedido(idPedido As Integer, producto As Producto, cantidad As String)
        Dim cadena As String
        Dim aux As String = producto.getPrecioFinal.ToString.Replace(",", ".")

        cadena = "INSERT INTO TIENE_PROD_PED(ID_PRODUCTO, ID_PEDIDO, CANTIDAD, PRECIO_ACTUAL) VALUES (" + producto.getId.ToString + ", " + idPedido.ToString + ", " + cantidad + ", " + aux + ");"
        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        desconectar()
    End Sub

    Sub obtenerPedidos(fechaInicio As String, fechaFin As String, ByVal dgv As DataGridView)
        Dim consulta As String
        consulta = "SELECT ID_PEDIDO, DNI, FECHA, IMPORTE FROM PEDIDO WHERE FECHA >= '" + fechaInicio + "' AND FECHA <= '" + fechaFin + "'"
        conectar()
        adapter = New SqlDataAdapter(consulta, conexion)
        dt = New DataTable
        adapter.Fill(dt)
        dgv.DataSource = dt
        desconectar()
    End Sub

    Sub rellenarExistencias(ByVal dgv As DataGridView)
        Dim consulta As String
        consulta = "SELECT ID_PRODUCTO, NOMBRE, NOMBRE_A_MOSTRAR, TIPO, SUBTIPO, PRECIO_FINAL, EXISTENCIAS FROM PRODUCTO"
        conectar()
        adapter = New SqlDataAdapter(consulta, conexion)
        dt = New DataTable
        adapter.Fill(dt)
        dgv.DataSource = dt
        desconectar()
    End Sub

    Sub anadirExistencias(cantidad As Integer, id As Integer)
        Dim cadena As String
        cadena = "UPDATE PRODUCTO SET EXISTENCIAS = '" + cantidad.ToString + "' WHERE ID_PRODUCTO = '" + id.ToString + "';"
        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Existencias añadidas.")
        desconectar()
    End Sub

    Sub borrarExistencias(cantidad As Integer, id As Integer)
        Dim cadena As String
        cadena = "UPDATE PRODUCTO SET EXISTENCIAS = '" + cantidad.ToString + "' WHERE ID_PRODUCTO = '" + id.ToString + "';"
        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        Console.WriteLine("Existencias añadidas.")
        desconectar()
    End Sub

    Sub modificarImpuesto(impuesto As String, impuesto2 As String)
        Dim cadena As String

        cadena = "UPDATE PRODUCTO SET IMPUESTO = '" + impuesto.Replace(",", ".") + "', IMPUESTO2 = '" + impuesto2.Replace(",", ".") + "' ;"
        conectar()
        comando = New SqlCommand(cadena, conexion)
        comando.ExecuteNonQuery()
        desconectar()
    End Sub

    Function obtenerUsuario(nombreUsuario As String, clave As String) As Trabajador
        Dim consulta As String = "SELECT DNI, NOMBRE FROM TRABAJADOR WHERE NOMBRE_USUARIO = '" + nombreUsuario + "' AND CLAVE = '" + clave + "';"
        Dim t As Trabajador
        conectar()
        comando = New SqlCommand(consulta, conexion)
        dr = comando.ExecuteReader()

        If dr.Read() Then
            t = New Trabajador(dr.GetString(0), dr.GetString(1))
        Else
            t = New Trabajador("-1")
        End If

        desconectar()
        Return t
    End Function
End Class

