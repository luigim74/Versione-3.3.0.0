﻿Imports System.Data.SQLite

Public Class CmdComandeSQLite

   Public IdTavolo As String
   Public IdPiatto As String
   Public Quantità As String
   Public Piatto As String
   Public Importo As String
   Public Variante As String
   Public ConVar As Boolean

   Dim connStrSQLite As String

   Public Sub New()
      ' Crea la stringa di connessione.
      connStrSQLite = "Data Source=" & Application.StartupPath & NOME_PERCORSO_FILE_COMANDI_ANDROID
   End Sub

   Public Function CreaTabella(ByVal tabella As String) As Boolean
      ' Dichiara un oggetto connessione.
      Dim cnSQLite As New SQLiteConnection(connStrSQLite)
      Dim tr As SQLiteTransaction
      Dim sql As String

      Try
         ' Apre la connessione.
         cnSQLite.Open()

         ' Avvia una transazione.
         tr = cnSQLite.BeginTransaction(IsolationLevel.ReadCommitted)
         ' Crea la stringa per la creazione delle tabella.
         sql = String.Format("CREATE TABLE {0} (" &
                             "Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " &
                             "IdTavolo VARCHAR(10) NULL, " &
                             "IdPiatto VARCHAR(10) NULL, " &
                             "Quantita VARCHAR(5) NULL, " &
                             "Piatto VARCHAR(100) NULL, " &
                             "Importo VARCHAR(50) NULL, " &
                             "Variante VARCHAR(2) NULL, " &
                             "ConVar BOOLEAN NULL" &
                             ")", tabella)

         ' Crea il comando per la connessione corrente.
         Dim cmdCreaTabella As New SQLiteCommand(sql, cnSQLite, tr)

         ' Esegue il comando.
         Dim Record As Integer = cmdCreaTabella.ExecuteNonQuery()

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
         cnSQLite.Close()

      End Try
   End Function

   Public Function InserisciDati(ByVal tabella As String) As Boolean
      ' Dichiara un oggetto connessione.
      Dim cnSQLite As New SQLiteConnection(connStrSQLite)
      Dim tr As SQLiteTransaction
      Dim sql As String

      Try
         ' Apre la connessione.
         cnSQLite.Open()

         ' Avvia una transazione.
         tr = cnSQLite.BeginTransaction(IsolationLevel.ReadCommitted)
         ' Crea la stringa di inserimento dati.
         sql = String.Format("INSERT INTO {0} (IdTavolo, IdPiatto, Quantita, Piatto, Importo, Variante, ConVar) " & _
                                       "VALUES('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", tabella,
                                       Me.IdTavolo,
                                       Me.IdPiatto,
                                       Me.Quantità,
                                       Me.Piatto,
                                       Me.Importo,
                                       Me.Variante,
                                       Me.ConVar)

         ' Crea il comando per la connessione corrente.
         Dim cmdInsert As New SQLiteCommand(sql, cnSQLite, tr)

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
         cnSQLite.Close()

      End Try
   End Function

   Public Sub CancellaCampi()
      Try
         ' Pulisce tutti i campi da eventuali dati.
         With Me
            .IdTavolo = String.Empty
            .IdPiatto = String.Empty
            .Quantità = String.Empty
            .Piatto = String.Empty
            .Importo = String.Empty
            .Variante = String.Empty
            .ConVar = False
         End With

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

End Class
