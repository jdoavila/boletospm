Imports System.Data.SqlClient
Public Class Form1

    Private Sub btnGenerarBoletos_Click(sender As Object, e As EventArgs) Handles btnGenerarBoletos.Click
        If Me.txtIdentidad.Text <> Nothing And Me.txtNombreCliente.Text <> Nothing And Me.txtNumFactura.Text <> Nothing And Me.txtCantBoletos.Text <> Nothing Then
            GuardarDatos2()
        Else
            MessageBox.Show("Faltan algunos datos, revise antes de continuar.", "Boletos Paper & More", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GuardarDatos2()
        Dim max As Integer = ObtenerMax()
        Dim cantBols As Integer = CalCantBol()
        Dim nMax As Integer = max + cantBols

        While max < nMax
            GuardarDatos()
            max += 1
        End While

        ImprimirBoletos()
    End Sub

    Private Sub GuardarDatos()
        If varConexion.State = ConnectionState.Open Then
            varConexion.Close()
        End If
        Try
            varConexion.Open()

            Dim sql As String = "INSERT INTO Boletos (RNPCliente, NombreCompleto, Telefono, Email, NumFactura, ValorFactura) VALUES (@RNP, @Cliente, @Tel, @Email, @Factura, " + Me.txtCantBoletos.Text + ")"

            Dim cmd As New SqlCommand(sql, varConexion)
            cmd.Parameters.Add("@RNP", SqlDbType.NVarChar, 15).Value = Me.txtIdentidad.Text
            cmd.Parameters.Add("@Cliente", SqlDbType.NVarChar, 70).Value = Me.txtNombreCliente.Text
            cmd.Parameters.Add("@Tel", SqlDbType.NVarChar, 10).Value = Me.txtTelefono.Text
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 70).Value = Me.txtEmail.Text
            cmd.Parameters.Add("@Factura", SqlDbType.Int).Value = Me.txtNumFactura.Text
            'cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Date.Today

            cmd.ExecuteNonQuery()

            varConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function ObtenerMax() As Integer
        Dim NB As Integer = 0
        If varConexion.State = ConnectionState.Open Then
            varConexion.Close()
        End If
        Try
            varConexion.Open()

            Const sql As String = "SELECT MAX(NumBoleto) AS NB FROM Boletos"

            Dim cmd As New SqlCommand(sql, varConexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader

            If reader.Read Then
                If IsDBNull(reader.Item("NB")) Then
                    NB = 0
                Else
                    NB = reader.Item("NB")
                End If

            End If

            varConexion.Close()
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return NB

    End Function

    Private Sub ImprimirBoletos()
        Dim reporte As New BoletosReport
        reporte.GenerarReporte(Me.txtNumFactura.Text)
        reporte.ShowRibbonPreviewDialog()

        Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtNombreCliente.Text = Nothing
        Me.txtCantBoletos.Text = Nothing
        Me.txtEmail.Text = Nothing
        Me.txtIdentidad.Text = Nothing
        Me.txtNumFactura.Text = Nothing
        Me.txtTelefono.Text = Nothing
    End Sub

    Private Function CalCantBol()
        Dim CantBol As Integer = Math.Round(CDbl(Me.txtCantBoletos.Text) / 500)

        Return CantBol
    End Function

    Private Sub txtNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCliente.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Me.txtNombreCliente.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub
End Class
