' Nome form:            StoricoPresenze.
' Autore:               Luigi Montana, Montana Software
' Data creazione:       24/06/2018
' Data ultima modifica: 24/06/2018
' Descrizione:          Visualizza l'elenco storico delle presenze delle camere divise per mese, con grafico.

Public Class StoricoPresenze

   Const TAB_STRORICO_PRESENZE_CAMERE As String = "StoricoPresenzeCamere"

   Private Sub LeggiStoricoPresenzeCamere()
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim Mese(11) As String
      Dim totalePersoneCamera As Integer
      Dim totalePersoneMese As Integer

      Try
         Mese(0) = "Gennaio"
         Mese(1) = "Febbraio"
         Mese(2) = "Marzo"
         Mese(3) = "Aprile"
         Mese(4) = "Maggio"
         Mese(5) = "Giugno"
         Mese(6) = "Luglio"
         Mese(7) = "Agosto"
         Mese(8) = "Settembre"
         Mese(9) = "Ottobre"
         Mese(10) = "Novembre"
         Mese(11) = "Dicembre"

         cn.Open()

         Dim i As Integer
         For i = 1 To 12

            Dim cmd As New OleDbCommand("SELECT * FROM " & TAB_STRORICO_PRESENZE_CAMERE & " WHERE Mese = " & i & " ORDER BY Id ASC", cn)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            Do While dr.Read()

               ' Adulti.
               Dim numAdulti As Integer
               If IsDBNull(dr.Item("Adulti")) = False Then
                  numAdulti = Convert.ToInt32(dr.Item("Adulti"))
               Else
                  numAdulti = 0
               End If

               ' Neonati.
               Dim numNeonati As Integer
               If IsDBNull(dr.Item("Neonati")) = False Then
                  numNeonati = Convert.ToInt32(dr.Item("Neonati"))
               Else
                  numNeonati = 0
               End If

               ' Bambini.
               Dim numBambini As Integer
               If IsDBNull(dr.Item("Bambini")) = False Then
                  numBambini = Convert.ToInt32(dr.Item("Bambini"))
               Else
                  numBambini = 0
               End If

               ' Ragazzi.
               Dim numRagazzi As Integer
               If IsDBNull(dr.Item("Ragazzi")) = False Then
                  numRagazzi = Convert.ToInt32(dr.Item("Ragazzi"))
               Else
                  numRagazzi = 0
               End If

               '' Data Arrivo.
               'If IsDBNull(dr.Item("DataArrivo")) = False Then
               '   dgvDettagli.CurrentRow.Cells(clnPrezzo.Name).Value = dr.Item("DataArrivo")
               'Else
               '   dgvDettagli.CurrentRow.Cells(clnPrezzo.Name).Value = VALORE_ZERO
               'End If

               '' Sconto %.
               'If IsDBNull(dr.Item("Sconto")) = False Then
               '   dgvDettagli.CurrentRow.Cells(clnSconto.Name).Value = dr.Item("Sconto")
               'Else
               '   dgvDettagli.CurrentRow.Cells(clnSconto.Name).Value = VALORE_ZERO
               'End If

               '' Importo.
               'If IsDBNull(dr.Item("ImportoNetto")) = False Then
               '   dgvDettagli.CurrentRow.Cells(clnImporto.Name).Value = dr.Item("ImportoNetto")
               'Else
               '   dgvDettagli.CurrentRow.Cells(clnImporto.Name).Value = VALORE_ZERO
               'End If

               ' Somma di tutti gli occupanti della camera.
               totalePersoneCamera = numAdulti + numNeonati + numBambini + numRagazzi

               ' Somma di tutti gli occupanti del mese.
               totalePersoneMese = totalePersoneMese + totalePersoneCamera
            Loop

            dgvDettagli.Focus()
            dgvDettagli.Rows.Add()
            dgvDettagli.Rows.Item(dgvDettagli.Rows.Count - 2).Selected = True
            dgvDettagli.Rows.Item(dgvDettagli.Rows.Count - 2).Cells.Item(0).Selected = True

            ' Mese.
            dgvDettagli.CurrentRow.Cells(clnMese.Name).Value = Mese(i - 1)

            ' Numero presenze.
            dgvDettagli.CurrentRow.Cells(clnPresenze.Name).Value = totalePersoneMese.ToString

            If totalePersoneMese > 10 Then
               dgvDettagli.CurrentRow.Cells(clnPresenze.Name).Style.ForeColor = Color.Red
            End If

            ' Percentuale di occupazione.
            dgvDettagli.CurrentRow.Cells(clnOccupazione.Name).Value = totalePersoneMese.ToString & ",00"

            totalePersoneMese = 0

         Next

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         cn.Close()

      End Try
   End Sub

   Private Sub CaricaAnniPresenze()
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim annoTrovato As Boolean

      Try
         ' Pulisce la lista da eventuali anni.
         eui_cmbAnno.Items.Clear()

         ' Inserisce nella lista l'anno corrente.
         eui_cmbAnno.Items.Add(Today.Year.ToString)

         cn.Open()

         Dim cmd As New OleDbCommand("SELECT * FROM " & TAB_STRORICO_PRESENZE_CAMERE & " ORDER BY DataArrivo ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read()

            ' Data Arrivo.
            Dim dataArrivo As Date
            If IsDBNull(dr.Item("DataArrivo")) = False Then
               dataArrivo = Convert.ToDateTime(dr.Item("DataArrivo"))
            Else
               dataArrivo = Nothing
            End If

            Dim i As Integer
            For i = 0 To eui_cmbAnno.Items.Count - 1

               If dataArrivo.Year.ToString = eui_cmbAnno.Items(i).ToString Then
                  annoTrovato = True
                  Exit For
               End If
            Next

            ' Se l'anno non è stato trovato nella lista lo inserisce.
            If annoTrovato = False Then
               eui_cmbAnno.Items.Add(dataArrivo.Year.ToString)
            End If

            annoTrovato = False
         Loop

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         cn.Close()

      End Try
   End Sub


   Private Sub StoricoPresenze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         ' Imposta l'icona del prodotto.
         ImpostaIcona(Me)

         ' Carica l'elenco degli anni in cui ci sono state presenze.
         CaricaAnniPresenze()

         ' Seleziona l'anno corrente.
         eui_cmbAnno.SelectedItem = Today.Year.ToString

         ' Carica i dati nella griglia.
         LeggiStoricoPresenzeCamere()

         dgvDettagli.Focus()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub
End Class