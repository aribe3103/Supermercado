Public Class FormProductos

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrarFormProd.Click
        Me.Close() ' Cierra esta ventana actual y regresa a la anterior
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTituloProd.Click

    End Sub

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub BotonesProductos_Click(sender As Object, e As EventArgs) Handles btnAddProd1.Click, btnAddProd2.Click, btnAddProd3.Click, btnAddProd4.Click, btnAddProd5.Click, btnAddProd6.Click, btnAddProd7.Click, btnAddProd8.Click
        Dim botonPresionado = CType(sender, Button)

        ' En lugar de usar .Text, usamos .Tag (donde pusiste el nombre y precio real)
        If botonPresionado.Tag IsNot Nothing Then
            ListaCarrito.Add(botonPresionado.Tag.ToString)
            MessageBox.Show("¡Agregado al carrito!", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class