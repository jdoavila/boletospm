<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdentidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumFactura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCantBoletos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGenerarBoletos = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantBoletos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre del Cliente:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(13, 32)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.txtNombreCliente.Properties.Mask.BeepOnError = True
        Me.txtNombreCliente.Properties.Mask.ShowPlaceHolders = False
        Me.txtNombreCliente.Size = New System.Drawing.Size(428, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(12, 88)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Properties.Mask.EditMask = "\d\d\d\d\d\d\d\d\d\d\d\d\d"
        Me.txtIdentidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtIdentidad.Size = New System.Drawing.Size(428, 20)
        Me.txtIdentidad.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Identidad:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(13, 145)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.Mask.EditMask = "d"
        Me.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTelefono.Size = New System.Drawing.Size(428, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 125)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Telefono:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(13, 208)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(428, 20)
        Me.txtEmail.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 188)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Email:"
        '
        'txtNumFactura
        '
        Me.txtNumFactura.Location = New System.Drawing.Point(13, 268)
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Properties.Mask.EditMask = "d"
        Me.txtNumFactura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumFactura.Size = New System.Drawing.Size(143, 20)
        Me.txtNumFactura.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 248)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Numero de Factura:"
        '
        'txtCantBoletos
        '
        Me.txtCantBoletos.Location = New System.Drawing.Point(297, 268)
        Me.txtCantBoletos.Name = "txtCantBoletos"
        Me.txtCantBoletos.Properties.Mask.EditMask = "c2"
        Me.txtCantBoletos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantBoletos.Size = New System.Drawing.Size(143, 20)
        Me.txtCantBoletos.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(296, 248)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Valor de la Factura"
        '
        'btnGenerarBoletos
        '
        Me.btnGenerarBoletos.Location = New System.Drawing.Point(145, 309)
        Me.btnGenerarBoletos.Name = "btnGenerarBoletos"
        Me.btnGenerarBoletos.Size = New System.Drawing.Size(164, 69)
        Me.btnGenerarBoletos.TabIndex = 12
        Me.btnGenerarBoletos.Text = "Generar Boletos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 397)
        Me.Controls.Add(Me.btnGenerarBoletos)
        Me.Controls.Add(Me.txtCantBoletos)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txtNumFactura)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Generador de Boletos de Paper & More"
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantBoletos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdentidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantBoletos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGenerarBoletos As DevExpress.XtraEditors.SimpleButton

End Class
