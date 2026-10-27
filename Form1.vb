Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInterfacex.Click

    End Sub

    'BOTONES DE CATEGORIAS PARA ABRIR FORMULARIO PRODUCTOS

    Private Sub btnFrutas_Click(sender As Object, e As EventArgs) Handles btnCatFrutas.Click, btnFrutasDestacadas.Click
        ' 1. Creamos la ventanita plantilla
        Dim ventana As New FormProductos

        ' 2. Cambiamos el título de arriba
        ventana.lblTituloProd.Text = "Frutas y Verduras"

        ' 3. Ponemos la información del producto 1
        ventana.lblNombreProd1.Text = "Manzana Red"
        ventana.lblPrecioProd1.Text = "$35.00 / kg"
        ventana.btnAddProd1.Tag = "Manzana Red - $35.00 / kg" ' Guardamos el nombre y precio real en el Tag
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\WhatsApp Image 2026-10-26 at 11.20.17 AM (1).jpeg") ' (Asegúrate de que 'manzanaRed' sea el nombre exacto de tu imagen en recursos)
        'Y así podemos poner la información de los demás productos si es necesario, solo les ponemos lblNombre2 y así
        ' 4. Mostramos la ventana
        ventana.Show()


    End Sub

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnCatBebidas.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Bebidas"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()

    End Sub

    Private Sub btnRopa_Click(sender As Object, e As EventArgs) Handles btnCatRopa.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Ropa"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()

    End Sub

    Private Sub btnLimp_Click(sender As Object, e As EventArgs) Handles btnCatLimp.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Limpieza del hogar"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()

    End Sub

    Private Sub btnMascotas_Click(sender As Object, e As EventArgs) Handles btnCatMascotas.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Mascotas"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()

    End Sub

    Private Sub btnDespensa_Click(sender As Object, e As EventArgs) Handles btnCatDespensa.Click, btnDespensaDestacadas.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Abarrotes y Despensa"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()


    End Sub

    Private Sub btnCarnes_Click(sender As Object, e As EventArgs) Handles btnCatCarnes.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Carnes"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()


    End Sub

    Private Sub btnPanaderia_Click(sender As Object, e As EventArgs) Handles btnCatPanaderia.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Panadería"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()


    End Sub

    Private Sub btnHigiene_Click(sender As Object, e As EventArgs) Handles btnCatHigiene.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Higiene y Cuidado Personal"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        ventana.pbProd1.Image = Image.FromFile("C:\Users\alexi\Downloads\refresco.png")
        ventana.Show()


    End Sub

    Private Sub btnMuebles_Click(sender As Object, e As EventArgs) Handles btnCatMuebles.Click
        Dim ventana As New FormProductos()

        ventana.lblTituloProd.Text = "Muebles"

        ventana.lblNombreProd1.Text = "Refresco Coca-Cola 600ml"
        ventana.lblPrecioProd1.Text = "$20.00"
        'ventana.pbProd1.Image = My.Resources.refresco
        ventana.pbProd1.Image = Image.FromFile(IO.Path.Combine(Application.StartupPath, "Resources", "refresco.jpg"))
        ventana.Show()


    End Sub
    'BOTON AGREGAR AL CARRITO PARA AGREGAR PRODUCTOS A LA LISTA
    Private Sub Botones_Click(sender As Object, e As EventArgs) Handles btnAddOfDestacada1.Click, btnAddOfDestacada2.Click, btnAddOf1.Click, btnAddOf2.Click, btnAddOf3.Click, btnAddOf4.Click, btnAddOf5.Click, btnAddOf6.Click, btnAddOf7.Click, btnAddOf8.Click
        Dim botonPresionado = CType(sender, Button)

        ' En lugar de usar .Text, usamos .Tag (donde pusiste el nombre y precio real)
        If botonPresionado.Tag IsNot Nothing Then
            ListaCarrito.Add(botonPresionado.Tag.ToString)
            MessageBox.Show("¡Agregado al carrito!", "Tienda", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'BOTON CARRITO PARA IR A formCarrito, ver la lista (NO TOCAR)
    Private Sub AddCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click

        ' 1. Creamos una instancia de tu formulario de carrito
        ' (Asegúrate de cambiar "FormCarrito" si tu formulario tiene otro nombre en el explorador de soluciones)
        Dim ventanaCarrito As New FormCarrito()

        ' 2. Mostramos el formulario del carrito
        ventanaCarrito.Show()

        ' (Opcional) Si quieres ocultar el formulario principal actual para que no estorbe:
        ' Me.Hide()


    End Sub
    'BOTONES DE MARCAS PARA ABRIR FORMULARIO PRODMARCAS

    Private Sub btnBimbo_Click(sender As Object, e As EventArgs) Handles btnIrInterfaFood.Click 'AGREAGR OTROS BOTONES
        ' 1. Creamos la ventanita plantilla usando FormProductos
        Dim ventana As New ProdMarcas

        ' 2. Cambiamos el título al nombre de la marca
        ventana.lblSeccionProdMarcas.Text = "Productos Bimbo"

        ' 3. Llenamos los productos específicos de esta marca
        'Dim rutaImagen As String = IO.Path.Combine(Application.StartupPath, "Resources", "manzana")
        ventana.pbProdMarcas1.Image = Image.FromFile("C:\Users\alexi\Downloads\WhatsApp Image 2026-10-26 at 11.20.17 AM (1).jpeg")
        ventana.lblNombreProdMarcas1.Text = "Pan Blanco Bimbo 680g"
        ventana.lblPrecioProdMarcas1.Text = "$48.00"



        ' Si quieres guardar los datos para el carrito usando el Tag:


        ' 4. Mostramos la ventana


        'ventana.lblNombreProdMarcas1.Text = "Refresco Coca-Cola 600ml"
        'ventana.lblPrecioProdMarcas1.Text = "$20.00"
        'ventana.pbProdMarcas1.Image = My.Resources.ResourceManager.GetObject("refresco") ' Asegúrate de que la imagen esté en los recursos del proyecto

        ventana.Show()

    End Sub


End Class
