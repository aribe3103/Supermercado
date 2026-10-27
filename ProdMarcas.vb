Public Class ProdMarcas
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles gpbProdMarcas4.Enter

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pbProdMarcas8.Click

    End Sub

    Private Sub pbProdMarcas1_Click(sender As Object, e As EventArgs) Handles pbProdMarcas1.Click

    End Sub

    Private Sub btnAddProdMarcas1_Click(sender As Object, e As EventArgs) Handles btnAddProdMarcas1.Click, btnAddProdMarcas2.Click, btnAddProdMarcas3.Click, btnAddProdMarcas4.Click, btnAddProdMarcas5.Click, btnAddProdMarcas6.Click, btnAddProdMarcas7.Click, btnAddProdMarcas8.Click
        Dim botonPresionado = CType(sender, Button)

        If botonPresionado.Tag IsNot Nothing Then
            ListaCarrito.Add(botonPresionado.Tag.ToString)
            MessageBox.Show("¡Agregado al carrito!", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCerrarProdMarcas_Click(sender As Object, e As EventArgs) Handles btnCerrarProdMarcas.Click
        Me.Close() ' Cierra esta ventana actual y regresa a la anterior
    End Sub
End Class