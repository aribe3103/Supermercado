<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarrito
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
        ListBox1 = New ListBox()
        gpbTituloProd = New GroupBox()
        pbLogoProd = New PictureBox()
        lbEsloganProd = New Label()
        lblnterfacexProd = New Label()
        btnCerrarProdMarcas = New Button()
        gpbTituloProd.SuspendLayout()
        CType(pbLogoProd, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(26, 196)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(486, 354)
        ListBox1.TabIndex = 0
        ' 
        ' gpbTituloProd
        ' 
        gpbTituloProd.Controls.Add(pbLogoProd)
        gpbTituloProd.Controls.Add(lbEsloganProd)
        gpbTituloProd.Controls.Add(lblnterfacexProd)
        gpbTituloProd.Location = New Point(12, 52)
        gpbTituloProd.Name = "gpbTituloProd"
        gpbTituloProd.Size = New Size(521, 118)
        gpbTituloProd.TabIndex = 23
        gpbTituloProd.TabStop = False
        ' 
        ' pbLogoProd
        ' 
        pbLogoProd.Location = New Point(339, 30)
        pbLogoProd.Name = "pbLogoProd"
        pbLogoProd.Size = New Size(150, 75)
        pbLogoProd.TabIndex = 2
        pbLogoProd.TabStop = False
        ' 
        ' lbEsloganProd
        ' 
        lbEsloganProd.AutoSize = True
        lbEsloganProd.Location = New Point(23, 80)
        lbEsloganProd.Name = "lbEsloganProd"
        lbEsloganProd.Size = New Size(272, 25)
        lbEsloganProd.TabIndex = 1
        lbEsloganProd.Text = "Compras en línea al mejor precio"
        ' 
        ' lblnterfacexProd
        ' 
        lblnterfacexProd.AutoSize = True
        lblnterfacexProd.Location = New Point(104, 40)
        lblnterfacexProd.Name = "lblnterfacexProd"
        lblnterfacexProd.Size = New Size(88, 25)
        lblnterfacexProd.TabIndex = 0
        lblnterfacexProd.Text = "Interfacex"
        ' 
        ' btnCerrarProdMarcas
        ' 
        btnCerrarProdMarcas.Location = New Point(12, 12)
        btnCerrarProdMarcas.Name = "btnCerrarProdMarcas"
        btnCerrarProdMarcas.Size = New Size(112, 34)
        btnCerrarProdMarcas.TabIndex = 24
        btnCerrarProdMarcas.Text = "Atrás"
        btnCerrarProdMarcas.UseVisualStyleBackColor = True
        ' 
        ' FormCarrito
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 622)
        Controls.Add(btnCerrarProdMarcas)
        Controls.Add(gpbTituloProd)
        Controls.Add(ListBox1)
        Name = "FormCarrito"
        Text = "FormCarrito"
        gpbTituloProd.ResumeLayout(False)
        gpbTituloProd.PerformLayout()
        CType(pbLogoProd, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents gpbTituloProd As GroupBox
    Friend WithEvents pbLogoProd As PictureBox
    Friend WithEvents lbEsloganProd As Label
    Friend WithEvents lblnterfacexProd As Label
    Friend WithEvents btnCerrarProdMarcas As Button
End Class
