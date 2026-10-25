<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpbTitulo = New GroupBox()
        lblInterfacex = New Label()
        gpbCarrito = New GroupBox()
        btnCarrito = New Button()
        gpbCuenta = New GroupBox()
        btnCuenta = New Button()
        tbcPanel = New TabControl()
        tbcInicio = New TabPage()
        lblCatDes = New Label()
        gpbPresImag = New GroupBox()
        gpbCatDes = New GroupBox()
        gpbPresentacion = New GroupBox()
        lblBienvenida = New Label()
        lblPresDesc = New Label()
        tbcCategorias = New TabPage()
        tbcOfertas = New TabPage()
        tbcMarcas = New TabPage()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        lblOfertas = New Label()
        lblMarcas = New Label()
        gpbTitulo.SuspendLayout()
        gpbCarrito.SuspendLayout()
        gpbCuenta.SuspendLayout()
        tbcPanel.SuspendLayout()
        tbcInicio.SuspendLayout()
        gpbPresentacion.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpbTitulo
        ' 
        gpbTitulo.Controls.Add(lblInterfacex)
        gpbTitulo.Controls.Add(gpbCarrito)
        gpbTitulo.Controls.Add(gpbCuenta)
        gpbTitulo.Location = New Point(18, 17)
        gpbTitulo.Name = "gpbTitulo"
        gpbTitulo.Size = New Size(1031, 140)
        gpbTitulo.TabIndex = 0
        gpbTitulo.TabStop = False
        ' 
        ' lblInterfacex
        ' 
        lblInterfacex.AutoSize = True
        lblInterfacex.Location = New Point(188, 64)
        lblInterfacex.Name = "lblInterfacex"
        lblInterfacex.Size = New Size(88, 25)
        lblInterfacex.TabIndex = 2
        lblInterfacex.Text = "Interfacex"
        ' 
        ' gpbCarrito
        ' 
        gpbCarrito.Controls.Add(btnCarrito)
        gpbCarrito.Location = New Point(828, 36)
        gpbCarrito.Name = "gpbCarrito"
        gpbCarrito.Size = New Size(183, 83)
        gpbCarrito.TabIndex = 1
        gpbCarrito.TabStop = False
        ' 
        ' btnCarrito
        ' 
        btnCarrito.Location = New Point(33, 30)
        btnCarrito.Name = "btnCarrito"
        btnCarrito.Size = New Size(112, 34)
        btnCarrito.TabIndex = 0
        btnCarrito.Text = "Carrito"
        btnCarrito.UseVisualStyleBackColor = True
        ' 
        ' gpbCuenta
        ' 
        gpbCuenta.Controls.Add(btnCuenta)
        gpbCuenta.Location = New Point(545, 34)
        gpbCuenta.Name = "gpbCuenta"
        gpbCuenta.Size = New Size(252, 81)
        gpbCuenta.TabIndex = 0
        gpbCuenta.TabStop = False
        ' 
        ' btnCuenta
        ' 
        btnCuenta.Location = New Point(63, 30)
        btnCuenta.Name = "btnCuenta"
        btnCuenta.Size = New Size(112, 34)
        btnCuenta.TabIndex = 0
        btnCuenta.Text = "Mi Cuenta"
        btnCuenta.UseVisualStyleBackColor = True
        ' 
        ' tbcPanel
        ' 
        tbcPanel.Controls.Add(tbcInicio)
        tbcPanel.Controls.Add(tbcCategorias)
        tbcPanel.Controls.Add(tbcOfertas)
        tbcPanel.Controls.Add(tbcMarcas)
        tbcPanel.Location = New Point(18, 173)
        tbcPanel.Name = "tbcPanel"
        tbcPanel.SelectedIndex = 0
        tbcPanel.Size = New Size(1031, 787)
        tbcPanel.TabIndex = 2
        ' 
        ' tbcInicio
        ' 
        tbcInicio.Controls.Add(lblMarcas)
        tbcInicio.Controls.Add(lblOfertas)
        tbcInicio.Controls.Add(GroupBox1)
        tbcInicio.Controls.Add(GroupBox2)
        tbcInicio.Controls.Add(lblCatDes)
        tbcInicio.Controls.Add(gpbPresImag)
        tbcInicio.Controls.Add(gpbCatDes)
        tbcInicio.Controls.Add(gpbPresentacion)
        tbcInicio.Location = New Point(4, 34)
        tbcInicio.Name = "tbcInicio"
        tbcInicio.Padding = New Padding(3)
        tbcInicio.Size = New Size(1023, 749)
        tbcInicio.TabIndex = 0
        tbcInicio.Text = "Inicio"
        tbcInicio.UseVisualStyleBackColor = True
        ' 
        ' lblCatDes
        ' 
        lblCatDes.AutoSize = True
        lblCatDes.Location = New Point(35, 257)
        lblCatDes.Name = "lblCatDes"
        lblCatDes.Size = New Size(191, 25)
        lblCatDes.TabIndex = 5
        lblCatDes.Text = "Categorías Destacadas"
        ' 
        ' gpbPresImag
        ' 
        gpbPresImag.Location = New Point(541, 16)
        gpbPresImag.Name = "gpbPresImag"
        gpbPresImag.Size = New Size(466, 210)
        gpbPresImag.TabIndex = 4
        gpbPresImag.TabStop = False
        ' 
        ' gpbCatDes
        ' 
        gpbCatDes.Location = New Point(21, 305)
        gpbCatDes.Name = "gpbCatDes"
        gpbCatDes.Size = New Size(986, 171)
        gpbCatDes.TabIndex = 3
        gpbCatDes.TabStop = False
        ' 
        ' gpbPresentacion
        ' 
        gpbPresentacion.Controls.Add(lblBienvenida)
        gpbPresentacion.Controls.Add(lblPresDesc)
        gpbPresentacion.Location = New Point(21, 16)
        gpbPresentacion.Name = "gpbPresentacion"
        gpbPresentacion.Size = New Size(497, 210)
        gpbPresentacion.TabIndex = 2
        gpbPresentacion.TabStop = False
        ' 
        ' lblBienvenida
        ' 
        lblBienvenida.AutoSize = True
        lblBienvenida.Location = New Point(114, 55)
        lblBienvenida.Name = "lblBienvenida"
        lblBienvenida.Size = New Size(202, 25)
        lblBienvenida.TabIndex = 0
        lblBienvenida.Text = "Bienvenidos a Interfacex"
        ' 
        ' lblPresDesc
        ' 
        lblPresDesc.AutoSize = True
        lblPresDesc.Location = New Point(100, 114)
        lblPresDesc.Name = "lblPresDesc"
        lblPresDesc.Size = New Size(257, 25)
        lblPresDesc.TabIndex = 1
        lblPresDesc.Text = "compras online al mejor precio"
        ' 
        ' tbcCategorias
        ' 
        tbcCategorias.Location = New Point(4, 34)
        tbcCategorias.Name = "tbcCategorias"
        tbcCategorias.Padding = New Padding(3)
        tbcCategorias.Size = New Size(1023, 749)
        tbcCategorias.TabIndex = 1
        tbcCategorias.Text = "Cateogorias"
        tbcCategorias.UseVisualStyleBackColor = True
        ' 
        ' tbcOfertas
        ' 
        tbcOfertas.Location = New Point(4, 34)
        tbcOfertas.Name = "tbcOfertas"
        tbcOfertas.Padding = New Padding(3)
        tbcOfertas.Size = New Size(1023, 749)
        tbcOfertas.TabIndex = 2
        tbcOfertas.Text = "Ofertas"
        tbcOfertas.UseVisualStyleBackColor = True
        ' 
        ' tbcMarcas
        ' 
        tbcMarcas.Location = New Point(4, 34)
        tbcMarcas.Name = "tbcMarcas"
        tbcMarcas.Padding = New Padding(3)
        tbcMarcas.Size = New Size(1023, 749)
        tbcMarcas.TabIndex = 3
        tbcMarcas.Text = "Marcas"
        tbcMarcas.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(541, 565)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(448, 165)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(35, 565)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(485, 156)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' lblOfertas
        ' 
        lblOfertas.AutoSize = True
        lblOfertas.Location = New Point(39, 499)
        lblOfertas.Name = "lblOfertas"
        lblOfertas.Size = New Size(70, 25)
        lblOfertas.TabIndex = 8
        lblOfertas.Text = "Ofertas"
        ' 
        ' lblMarcas
        ' 
        lblMarcas.AutoSize = True
        lblMarcas.Location = New Point(574, 512)
        lblMarcas.Name = "lblMarcas"
        lblMarcas.Size = New Size(142, 25)
        lblMarcas.TabIndex = 9
        lblMarcas.Text = "Nuestras Marcas"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 1015)
        Controls.Add(tbcPanel)
        Controls.Add(gpbTitulo)
        Name = "Form1"
        Text = "Form1"
        gpbTitulo.ResumeLayout(False)
        gpbTitulo.PerformLayout()
        gpbCarrito.ResumeLayout(False)
        gpbCuenta.ResumeLayout(False)
        tbcPanel.ResumeLayout(False)
        tbcInicio.ResumeLayout(False)
        tbcInicio.PerformLayout()
        gpbPresentacion.ResumeLayout(False)
        gpbPresentacion.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gpbTitulo As GroupBox
    Friend WithEvents lblInterfacex As Label
    Friend WithEvents gpbCarrito As GroupBox
    Friend WithEvents gpbCuenta As GroupBox
    Friend WithEvents tbcPanel As TabControl
    Friend WithEvents tbcInicio As TabPage
    Friend WithEvents tbcCategorias As TabPage
    Friend WithEvents tbcOfertas As TabPage
    Friend WithEvents tbcMarcas As TabPage
    Friend WithEvents btnCarrito As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents gpbCatDes As GroupBox
    Friend WithEvents gpbPresentacion As GroupBox
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblPresDesc As Label
    Friend WithEvents gpbPresImag As GroupBox
    Friend WithEvents lblCatDes As Label
    Friend WithEvents lblMarcas As Label
    Friend WithEvents lblOfertas As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
