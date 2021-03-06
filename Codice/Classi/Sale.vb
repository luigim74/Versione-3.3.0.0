Imports System.Data.OleDb

Public Class Sale

   Public Codice As String
   Public Descrizione As String
   Public Sfondo As String
   Public Iniziale As String
   Public ColoreStile As Integer
   Public ColoreSfondo As Integer
   Public ColoreTesto As Integer
   Public AltezzaTasto As Integer
   Public OrdineTasto As Integer

   ' Dichiara un oggetto connessione.
   Private cn As New OleDbConnection(ConnString)
   Private tr As OleDbTransaction

   Public Sub LeggiDati(ByVal tabella As String, ByVal codice As String)
      ' Dichiara un oggetto DataAdapter.
      Dim da As OleDbDataAdapter
      ' Dichiara un oggetto DataSet
      Dim ds As DataSet
      Dim sql As String

      Try
         ' Apre la connessione.
         cn.Open()

         ' Crea la stringa.
         sql = String.Format("SELECT * FROM {0} WHERE Id = {1}", tabella, codice)

         ' Dichiara un oggetto DataAdapter.
         da = New OleDbDataAdapter(sql, cn)

         ' Dichiara un oggetto DataSet
         ds = New DataSet

         ' Riempe il DataSet con i dati della tabella.
         da.Fill(ds, tabella)

         ' Assegna i valori dei campi del DataSet ai campi della classe.
         If IsDBNull(ds.Tables(tabella).Rows(0)("Id")) = False Then
            Me.Codice = ds.Tables(tabella).Rows(0)("Id").ToString
         Else
            Me.Codice = ""
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("Descrizione")) = False Then
            Me.Descrizione = ds.Tables(tabella).Rows(0)("Descrizione").ToString
         Else
            Me.Descrizione = ""
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("ColoreStile")) = False Then
            Me.ColoreStile = Convert.ToInt32(ds.Tables(tabella).Rows(0)("ColoreStile"))
         Else
            Me.ColoreStile = 0
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("Sfondo")) = False Then
            Me.Sfondo = ds.Tables(tabella).Rows(0)("Sfondo").ToString
         Else
            Me.Sfondo = ""
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("Iniziale")) = False Then
            Me.Iniziale = ds.Tables(tabella).Rows(0)("Iniziale").ToString
         Else
            Me.Iniziale = ""
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("ColoreSfondo")) = False Then
            Me.ColoreSfondo = Convert.ToInt32(ds.Tables(tabella).Rows(0)("ColoreSfondo"))
         Else
            Me.ColoreSfondo = 0
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("ColoreTesto")) = False Then
            Me.ColoreTesto = Convert.ToInt32(ds.Tables(tabella).Rows(0)("ColoreTesto"))
         Else
            Me.ColoreTesto = 0
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("AltezzaTasto")) = False Then
            Me.AltezzaTasto = Convert.ToInt32(ds.Tables(tabella).Rows(0)("AltezzaTasto"))
         Else
            Me.AltezzaTasto = 50
         End If
         If IsDBNull(ds.Tables(tabella).Rows(0)("OrdineTasto")) = False Then
            Me.OrdineTasto = Convert.ToInt32(ds.Tables(tabella).Rows(0)("OrdineTasto"))
         Else
            Me.OrdineTasto = 0
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         da.Dispose()
         ds.Dispose()
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Sub

   Public Function InserisciDati(ByVal tabella As String) As Boolean
      Dim sql As String

      Try
         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)
         ' Crea la stringa di eliminazione.
         sql = String.Format("INSERT INTO {0} (Descrizione, Sfondo, Iniziale, ColoreStile, ColoreSfondo, ColoreTesto, AltezzaTasto, OrdineTasto) " &
                                       "VALUES(@Descrizione, @Sfondo, @Iniziale, @ColoreStile, @ColoreSfondo, @ColoreTesto, @AltezzaTasto, @OrdineTasto)", tabella)

         ' Crea il comando per la connessione corrente.
         Dim cmdInsert As New OleDbCommand(sql, cn, tr)

         cmdInsert.Parameters.AddWithValue("@Descrizione", Me.Descrizione)
         cmdInsert.Parameters.AddWithValue("@Sfondo", Me.Sfondo)
         cmdInsert.Parameters.AddWithValue("@Iniziale", Me.Iniziale)
         cmdInsert.Parameters.AddWithValue("@ColoreStile", Me.ColoreStile)
         cmdInsert.Parameters.AddWithValue("@ColoreSfondo", Me.ColoreSfondo)
         cmdInsert.Parameters.AddWithValue("@ColoreTesto", Me.ColoreTesto)
         cmdInsert.Parameters.AddWithValue("@AltezzaTasto", Me.AltezzaTasto)
         cmdInsert.Parameters.AddWithValue("@OrdineTasto", Me.OrdineTasto)

         ' Esegue il comando.
         Dim Record As Integer = cmdInsert.ExecuteNonQuery()

         ' Conferma transazione.
         tr.Commit()

         Return True

      Catch ex As Exception
         ' Annulla transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   Public Function ModificaDati(ByVal tabella As String, ByVal codice As String) As Boolean
      Dim sql As String

      Try
         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("UPDATE {0} " &
                             "SET Descrizione = @Descrizione, " &
                             "Sfondo = @Sfondo, " &
                             "Iniziale = @Iniziale, " &
                             "ColoreStile = @ColoreStile, " &
                             "ColoreSfondo = @ColoreSfondo, " &
                             "ColoreTesto = @ColoreTesto, " &
                             "AltezzaTasto = @AltezzaTasto, " &
                             "OrdineTasto = @OrdineTasto " &
                             "WHERE Id = {1}",
                             tabella,
                             codice)

         ' Crea il comando per la connessione corrente.
         Dim cmdUpdate As New OleDbCommand(sql, cn, tr)

         cmdUpdate.Parameters.AddWithValue("@Descrizione", Me.Descrizione)
         cmdUpdate.Parameters.AddWithValue("@Sfondo", Me.Sfondo)
         cmdUpdate.Parameters.AddWithValue("@Iniziale", Me.Iniziale)
         cmdUpdate.Parameters.AddWithValue("@ColoreStile", Me.ColoreStile)
         cmdUpdate.Parameters.AddWithValue("@ColoreSfondo", Me.ColoreSfondo)
         cmdUpdate.Parameters.AddWithValue("@ColoreTesto", Me.ColoreTesto)
         cmdUpdate.Parameters.AddWithValue("@AltezzaTasto", Me.AltezzaTasto)
         cmdUpdate.Parameters.AddWithValue("@OrdineTasto", Me.OrdineTasto)

         ' Esegue il comando.
         Dim Record As Integer = cmdUpdate.ExecuteNonQuery()

         ' Conferma transazione.
         tr.Commit()

         Return True

      Catch ex As Exception
         ' Annulla transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Function

   Public Function ModificaDati(ByVal coloreStile As Integer, ByVal coloreSfondo As Integer, ByVal coloreTesto As Integer, ByVal altezzaTasto As Integer, ByVal descrizione As String, ByVal tabella As String) As Boolean
      Dim sql As String

      Try
         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("UPDATE {0} " &
                             "SET ColoreStile = @ColoreStile, " &
                             "ColoreSfondo = @ColoreSfondo, " &
                             "ColoreTesto = @ColoreTesto, " &
                             "AltezzaTasto = @AltezzaTasto " &
                             "WHERE Descrizione = '{1}'",
                             tabella,
                             descrizione)

         ' Crea il comando per la connessione corrente.
         Dim cmdUpdate As New OleDbCommand(sql, cn, tr)

         cmdUpdate.Parameters.AddWithValue("@ColoreStile", coloreStile)
         cmdUpdate.Parameters.AddWithValue("@ColoreSfondo", coloreSfondo)
         cmdUpdate.Parameters.AddWithValue("@ColoreTesto", coloreTesto)
         cmdUpdate.Parameters.AddWithValue("@AltezzaTasto", altezzaTasto)

         ' Esegue il comando.
         Dim Record As Integer = cmdUpdate.ExecuteNonQuery()

         ' Conferma transazione.
         tr.Commit()

         Return True

      Catch ex As Exception
         ' Annulla transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Function

   Public Function ModificaOrdineTasto(ByVal ordine As Integer, ByVal descrizione As String, ByVal tabella As String) As Boolean
      Dim sql As String

      Try
         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("UPDATE {0} " &
                             "SET OrdineTasto = @OrdineTasto " &
                             "WHERE Descrizione = '{1}'",
                             tabella,
                             descrizione)

         ' Crea il comando per la connessione corrente.
         Dim cmdUpdate As New OleDbCommand(sql, cn, tr)

         cmdUpdate.Parameters.AddWithValue("@OrdineTasto", ordine)

         ' Esegue il comando.
         Dim Record As Integer = cmdUpdate.ExecuteNonQuery()

         ' Conferma transazione.
         tr.Commit()

         Return True

      Catch ex As Exception
         ' Annulla transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Function

   Public Function ModificaCampoIniziale(ByVal tabella As String) As Boolean
      Dim sql As String
      Const valCampo As String = "No"

      Try
         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di aggiornamento.
         sql = String.Format("UPDATE {0} SET Iniziale = '{1}' ", tabella, valCampo)

         ' Crea il comando per la connessione corrente.
         Dim cmdUpdate As New OleDbCommand(sql, cn, tr)
         ' Esegue il comando.
         Dim Record As Integer = cmdUpdate.ExecuteNonQuery()

         ' Conferma transazione.
         tr.Commit()

         Return True

      Catch ex As Exception
         ' Annulla transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Function

   Public Function LeggiUltimoRecord(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim closeOnExit As Boolean
      Dim ordineTasto As Integer

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Verifica l'esistenza del record.
         Dim cmd As New OleDbCommand("SELECT MAX(OrdineTasto) FROM " & tabella, cn)

         If IsDBNull(cmd.ExecuteScalar()) = False Then
            ordineTasto = Convert.ToInt32(cmd.ExecuteScalar())
         Else
            ordineTasto = 0
         End If

         Return ordineTasto

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

End Class
