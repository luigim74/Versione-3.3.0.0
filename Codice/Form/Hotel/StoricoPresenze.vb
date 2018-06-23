Public Class StoricoPresenze

   Private Sub StoricoPresenze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         ImpostaIcona(Me)

         Dim i As Integer

         For i = 1 To 12
            dgvDettagli.Focus()
            dgvDettagli.Rows.Add()
            dgvDettagli.Rows.Item(dgvDettagli.Rows.Count - 2).Selected = True
            dgvDettagli.Rows.Item(dgvDettagli.Rows.Count - 2).Cells.Item(0).Selected = True

            ' Codice.
            dgvDettagli.CurrentRow.Cells(clnMese.Name).Value = "Gennaio"

            ' Descrizione.
            dgvDettagli.CurrentRow.Cells(clnPresenze.Name).Value = "10"

            ' Unità di misura.
            dgvDettagli.CurrentRow.Cells(clnOccupazione.Name).Value = "45"
         Next

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub
End Class