Public Class InvioEmail

   Const NOME_TABELLA As String = "Email"
   Const TITOLO_FINESTRA = "Invio E-mail"

   Public IEmail As New Email

   Dim eMail_Mittente As String
   Dim eMail_Destinatario As String
   Dim eMail_Oggetto As String
   Dim eMail_Messaggio As String
   Dim eMail_Allegati As String

   Dim eMail_IdCliente As String
   Dim eMail_Nome As String
   Dim eMail_Cognome As String
   Dim eMail_Categoria As String

   Public Sub New(ByVal mittente As String, ByVal destinatario As String, ByVal oggetto As String, ByVal messaggio As String, ByVal allegati As String,
                  ByVal idCliente As String, ByVal nome As String, ByVal cognome As String, ByVal categoria As String)

      ' La chiamata è richiesta dalla finestra di progettazione.
      InitializeComponent()

      eMail_Mittente = mittente
      eMail_Destinatario = destinatario
      eMail_Oggetto = oggetto
      eMail_Messaggio = messaggio
      eMail_Allegati = allegati

      eMail_IdCliente = idCliente
      eMail_Nome = nome
      eMail_Cognome = cognome
      eMail_Categoria = categoria

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub

   Private Function SalvaDati() As Boolean
      Try
         With IEmail

            ' Assegna i dati dei campi della classe alle caselle di testo.
            .Mittente = eui_txtMittente.Text
            .Destinatario = eui_txtDestinatario.Text
            .Oggetto = FormattaApici(eui_txtOggetto.Text)
            .Messaggio = FormattaApici(eui_txtMessaggio.Text)
            .Allegati = eui_txtAllegati.Text
            .Cognome = eui_txtCognome.Text
            .Nome = eui_txtNome.Text
            .DataInvio = eui_txtDataInvio.Text
            .OraInvio = eui_txtOraInvio.Text
            .IdCliente = eui_txtIdCliente.Text
            .Stato = eui_txtStato.Text
            .Categoria = eui_txtCategoria.Text

            ' Assegna un colore per la categoria.
            Select Case .Categoria
               Case CATEGORIA_PREN_CAMERE
                  .Colore = Convert.ToInt32(Color.Brown.ToArgb)

               Case CATEGORIA_ARCHIVI

               Case Else
                  .Colore = Convert.ToInt32(Color.White.ToArgb)

            End Select

            '  Se la proprietà 'Tag' contiene un valore viene richiamata la procedura
            ' di modifica dati, altrimenti viene richiamata la procedura di inserimento dati.
            If Me.Tag <> String.Empty Then
               Return .ModificaDati(NOME_TABELLA, Me.Tag)
            Else
               Return .InserisciDati(NOME_TABELLA)
            End If

         End With

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Function

   Public Sub InviaEmail(ByVal eMailMittente As String, ByVal eMailDestinatario As String)
      Try
         If WebCommunication.VerificaConnessione = True Then

            Dim nomeMailServer As String = NOME_MAIL_SERVER_SMTP

            If eMailMittente = String.Empty Then
               MessageBox.Show("E' necessario specificare un'e-mail per il mittente!" & vbNewLine &
                               "Verificare nell'anagrafica 'Dati generali Azienda' la presenza di un'indirizzo e-mail valido.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Exit Sub
            End If

            If eMailDestinatario = String.Empty Then
               MessageBox.Show("E' necessario specificare un'e-mail per il destinatario!" & vbNewLine &
                               "Verificare nell'anagrafica 'Cliente' intestatario della prenotazione la presenza di un'indirizzo e-mail valido.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               Exit Sub
            End If

            ' Modifica il cursore del mouse.
            Cursor.Current = Cursors.AppStarting

            Dim oggetto As String = "Prenotazione N. 34239"

            Dim corpoMessaggio As String = "Prenotazione"

            Dim File As String = "Data.pdf"

            Dim messaggio As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage(eMailMittente, eMailDestinatario)
            messaggio.Subject = oggetto
            messaggio.Body = corpoMessaggio

            Dim Data As System.Net.Mail.Attachment = New System.Net.Mail.Attachment(File, System.Net.Mime.MediaTypeNames.Application.Octet)

            Dim disposition As System.Net.Mime.ContentDisposition = Data.ContentDisposition
            disposition.CreationDate = System.IO.File.GetCreationTime(File)
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(File)
            disposition.ReadDate = System.IO.File.GetLastAccessTime(File)

            messaggio.Attachments.Add(Data)

            Dim smtp As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient(nomeMailServer, 25)

            smtp.Credentials = New System.Net.NetworkCredential(USER_NAME_MAIL_SERVER_SMTP, PWD_MAIL_SERVER_SMTP)

            smtp.Send(messaggio)

            ' Modifica il cursore del mouse.
            Cursor.Current = Cursors.Default

            MessageBox.Show("E-mail inviata con successo!", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Information)
         End If

      Catch ex As Exception

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Exit Sub
      End Try
   End Sub

   Private Sub InvioEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         ' Imposta l'icona della finestra in base al prodotto installato.
         ImpostaIcona(Me)

         If Me.Tag <> String.Empty Then
            With IEmail
               ' Comando Modifica.

               ' Visualizza i dati nei rispettivi campi.
               .LeggiDati(NOME_TABELLA, Me.Tag)

               ' Assegna i dati ai rispettivi controlli.
               eui_txtMittente.Text = .Mittente
               eui_txtDestinatario.Text = .Destinatario
               eui_txtOggetto.Text = .Oggetto
               eui_txtMessaggio.Text = .Messaggio
               eui_txtAllegati.Text = .Allegati
               eui_txtCognome.Text = .Cognome
               eui_txtNome.Text = .Nome
               eui_txtDataInvio.Text = .DataInvio
               eui_txtOraInvio.Text = .OraInvio
               eui_txtIdCliente.Text = .IdCliente
               eui_txtStato.Text = .Stato
               eui_txtCategoria.Text = .Categoria

               ' Messaggio barra di stato.
               If .DataInvio <> String.Empty Then
                  eui_Informazioni.Text = "Inviato il " & .DataInvio & " alle ore " & .OraInvio & "." '& " a " & eMail_nome & " " & eMail_cognome & " (" & eMail_Destinatario & ")."
               Else
                  eui_Informazioni.Text = "Da inviare."
               End If

               ' Assegna il titolo alla finestra.
               Me.Text = TITOLO_FINESTRA & " - Modifica messaggio"

            End With
         Else
            ' Comando Nuovo.

            ' Assegna i dati ai rispettivi controlli.
            eui_txtMittente.Text = eMail_Mittente
            eui_txtDestinatario.Text = eMail_Destinatario
            eui_txtOggetto.Text = eMail_Oggetto
            eui_txtMessaggio.Text = eMail_Messaggio
            eui_txtAllegati.Text = eMail_allegati
            eui_txtCognome.Text = eMail_Cognome
            eui_txtNome.Text = eMail_Nome
            eui_txtIdCliente.Text = eMail_IdCliente
            eui_txtDataInvio.Text = String.Empty
            eui_txtOraInvio.Text = String.Empty
            eui_txtStato.Text = "Bozza"
            eui_txtCategoria.Text = eMail_Categoria

            ' Messaggio barra di stato.
            eui_Informazioni.Text = "Bozza."

            ' Assegna il titolo alla finestra.
            Me.Text = TITOLO_FINESTRA & " - Nuovo messaggio"

         End If

         ' Imposta lo stato attivo.
         eui_txtDestinatario.Focus()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Modifica il cursore del mouse.
         Cursor.Current = Cursors.Default

      End Try
   End Sub

   Private Sub eui_cmdInvia_Click(sender As Object, e As EventArgs) Handles eui_cmdInvia.Click

   End Sub

   Private Sub eui_cmdSalva_Click(sender As Object, e As EventArgs) Handles eui_cmdSalva.Click
      Try
         ' Verifica la presenza di un Destinatario.
         If eui_txtDestinatario.Text = String.Empty Then
            MessageBox.Show("Specificare il destinatario del messaggio.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            eui_txtDestinatario.Focus()
            Exit Sub
         End If

         ' Verifica la presenza di un Oggetto.
         If eui_txtOggetto.Text = String.Empty Then
            MessageBox.Show("Specificare l'oggetto del messaggio.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            eui_txtOggetto.Focus()
            Exit Sub
         End If

         ' Salva i dati nel database.
         If SalvaDati() = True Then

            ' Aggiorna la griglia dati.
            g_frmEmail.AggiornaDati()

            ' Chiude la finestra.
            Me.Close()
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdAnnulla_Click(sender As Object, e As EventArgs) Handles eui_cmdAnnulla.Click
      Try
         Me.Close()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdAllegaFile_Click(sender As Object, e As EventArgs) Handles eui_cmdAllegaFile.Click

   End Sub

End Class