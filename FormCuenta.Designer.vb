<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        gpbTituloProdMarcas = New GroupBox()
        pbLogoProdMarcas = New PictureBox()
        lbEsloganProdMarcas = New Label()
        lblnterfacexProdMarcas = New Label()
        btnCerrarProdMarcas = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        gpbTituloProdMarcas.SuspendLayout()
        CType(pbLogoProdMarcas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gpbTituloProdMarcas
        ' 
        gpbTituloProdMarcas.Controls.Add(pbLogoProdMarcas)
        gpbTituloProdMarcas.Controls.Add(lbEsloganProdMarcas)
        gpbTituloProdMarcas.Controls.Add(lblnterfacexProdMarcas)
        gpbTituloProdMarcas.Location = New Point(24, 75)
        gpbTituloProdMarcas.Name = "gpbTituloProdMarcas"
        gpbTituloProdMarcas.Size = New Size(712, 118)
        gpbTituloProdMarcas.TabIndex = 23
        gpbTituloProdMarcas.TabStop = False
        ' 
        ' pbLogoProdMarcas
        ' 
        pbLogoProdMarcas.Location = New Point(451, 30)
        pbLogoProdMarcas.Name = "pbLogoProdMarcas"
        pbLogoProdMarcas.Size = New Size(150, 75)
        pbLogoProdMarcas.TabIndex = 2
        pbLogoProdMarcas.TabStop = False
        ' 
        ' lbEsloganProdMarcas
        ' 
        lbEsloganProdMarcas.AutoSize = True
        lbEsloganProdMarcas.Location = New Point(23, 80)
        lbEsloganProdMarcas.Name = "lbEsloganProdMarcas"
        lbEsloganProdMarcas.Size = New Size(272, 25)
        lbEsloganProdMarcas.TabIndex = 1
        lbEsloganProdMarcas.Text = "Compras en línea al mejor precio"
        ' 
        ' lblnterfacexProdMarcas
        ' 
        lblnterfacexProdMarcas.AutoSize = True
        lblnterfacexProdMarcas.Location = New Point(104, 40)
        lblnterfacexProdMarcas.Name = "lblnterfacexProdMarcas"
        lblnterfacexProdMarcas.Size = New Size(88, 25)
        lblnterfacexProdMarcas.TabIndex = 0
        lblnterfacexProdMarcas.Text = "Interfacex"
        ' 
        ' btnCerrarProdMarcas
        ' 
        btnCerrarProdMarcas.Location = New Point(16, 23)
        btnCerrarProdMarcas.Name = "btnCerrarProdMarcas"
        btnCerrarProdMarcas.Size = New Size(112, 34)
        btnCerrarProdMarcas.TabIndex = 22
        btnCerrarProdMarcas.Text = "Atrás"
        btnCerrarProdMarcas.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(847, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 24
        Label1.Text = "AlexPro_677"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(832, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' FormCuenta
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1035, 595)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(gpbTituloProdMarcas)
        Controls.Add(btnCerrarProdMarcas)
        Name = "FormCuenta"
        Text = "FormCuenta"
        gpbTituloProdMarcas.ResumeLayout(False)
        gpbTituloProdMarcas.PerformLayout()
        CType(pbLogoProdMarcas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gpbTituloProdMarcas As GroupBox
    Friend WithEvents pbLogoProdMarcas As PictureBox
    Friend WithEvents lbEsloganProdMarcas As Label
    Friend WithEvents lblnterfacexProdMarcas As Label
    Friend WithEvents btnCerrarProdMarcas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
