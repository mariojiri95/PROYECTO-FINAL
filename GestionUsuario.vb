Public Class GestionUsuario
    Dim i As New Implementacion
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtNombreUsuario.Text = ""
        txtClave.Text = ""
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click

        If (txtDNI.Text.Trim = "" Or txtNombre.Text.Trim = "" Or txtNombreUsuario.Text.Trim = "" Or txtClave.Text.Trim = "") Then
            MessageBox.Show("Campos incompletos")
        Else
            Dim t = New Trabajador(txtDNI.Text, txtNombre.Text, txtNombreUsuario.Text, dtpFecha.Value.ToString.Split(" ")(0), txtClave.Text)
            i.anadirTrabajador(t)
            txtDNI.Text = ""
            txtNombre.Text = ""
            txtNombreUsuario.Text = ""
            txtClave.Text = ""
            Me.TRABAJADORTableAdapter.Fill(Me.PROYECTODataSet.TRABAJADOR)
            MessageBox.Show("Usuario añadido.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Gestion.Show()
    End Sub

    Private Sub TRABAJADORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TRABAJADORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROYECTODataSet)
    End Sub

    Private Sub GestionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PROYECTODataSet.TRABAJADOR' Puede moverla o quitarla según sea necesario.
        Me.TRABAJADORTableAdapter.Fill(Me.PROYECTODataSet.TRABAJADOR)
    End Sub

    Private Sub TRABAJADORDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TRABAJADORDataGridView.CellDoubleClick
        Dim t As New Trabajador
        Dim x As Integer = e.RowIndex
        'Dim aux As String = TRABAJADORDataGridView.Rows(x).Cells(0).Value

        If Not TRABAJADORDataGridView.Rows(x).Index + 1 = TRABAJADORDataGridView.Rows.Count Then
            Console.WriteLine("No error")
            'i.obtenerTrabajador(TRABAJADORDataGridView.Rows(x).Cells(0).Value.ToString)
            t = i.obtenerTrabajador(TRABAJADORDataGridView.Rows(x).Cells(0).Value.ToString)
            Dim f = New ModificarUsuario
            f.rellenarCampos(t)
            f.Show()
            Me.Hide()
        End If
    End Sub
End Class