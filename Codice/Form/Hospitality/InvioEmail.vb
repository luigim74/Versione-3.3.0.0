Public Class InvioEmail

   Dim eMail_Mittente As String
   Dim eMail_Destinatario As String
   Dim eMail_Oggetto As String
   Dim eMail_Messaggio As String
   Dim eMail_allegati As String

   Public Sub New(ByVal mittente As String, ByVal destinatario As String, ByVal oggetto As String, ByVal messaggio As String, ByVal allegati As String)

      ' La chiamata è richiesta dalla finestra di progettazione.
      InitializeComponent()

      eMail_Mittente = mittente
      eMail_Destinatario = destinatario
      eMail_Oggetto = oggetto
      eMail_Messaggio = messaggio
      eMail_allegati = allegati

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub

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
         ' Assegna i dati ai rispettivi controlli.
         eui_txtMittente.Text = eMail_Mittente
         eui_txtDestinatario.Text = eMail_Destinatario
         eui_txtOggetto.Text = eMail_Oggetto
         eui_txtMessaggio.Text = eMail_Messaggio
         eui_txtAllegati.Text = eMail_allegati

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub

End Class