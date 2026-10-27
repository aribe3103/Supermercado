Public Class FormCarrito
    Private Sub FormCarrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Limpiamos la lista visual por si acaso
        ListBox1.Items.Clear()

        ' Recorremos lo que se guardó en el Módulo y lo mostramos
        For Each producto As String In ListaCarrito
            ListBox1.Items.Add(producto)
        Next
    End Sub

    Private Sub btnCerrarProdMarcas_Click(sender As Object, e As EventArgs) Handles btnCerrarProdMarcas.Click
        Me.Close()
    End Sub
End Class

