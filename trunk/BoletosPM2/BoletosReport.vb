Public Class BoletosReport

    Public Sub GenerarReporte(Fact As Integer)
        Try
            Me.SP_ImprimirBoletosTableAdapter.Fill(BoletosPM2DataSet1.SP_ImprimirBoletos, Fact)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

End Class