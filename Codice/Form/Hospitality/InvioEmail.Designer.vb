<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvioEmail
   Inherits System.Windows.Forms.Form

   'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

   'Richiesto da Progettazione Windows Form
   Private components As System.ComponentModel.IContainer

   'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
   'Può essere modificata in Progettazione Windows Form.  
   'Non modificarla mediante l'editor del codice.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InvioEmail))
      Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
      Me.StatusBar1 = New Elegant.Ui.StatusBar()
      Me.StatusBarNotificationsArea1 = New Elegant.Ui.StatusBarNotificationsArea()
      Me.StatusBarPane2 = New Elegant.Ui.StatusBarPane()
      Me.StatusBarControlsArea1 = New Elegant.Ui.StatusBarControlsArea()
      Me.eui_txtMittente = New Elegant.Ui.TextBox()
      Me.eui_txtDestinatario = New Elegant.Ui.TextBox()
      Me.eui_txtOggetto = New Elegant.Ui.TextBox()
      Me.eui_txtAllegati = New Elegant.Ui.TextBox()
      Me.TabControl1 = New Elegant.Ui.TabControl()
      Me.TabPage1 = New Elegant.Ui.TabPage()
      Me.eui_txtMessaggio = New Elegant.Ui.TextBox()
      Me.Label1 = New Elegant.Ui.Label()
      Me.Label2 = New Elegant.Ui.Label()
      Me.Label4 = New Elegant.Ui.Label()
      Me.Label5 = New Elegant.Ui.Label()
      Me.eui_cmdAnnulla = New Elegant.Ui.Button()
      Me.eui_cmdSalva = New Elegant.Ui.Button()
      Me.eui_cmdAllegaFile = New Elegant.Ui.Button()
      Me.eui_cmdInvia = New Elegant.Ui.Button()
      Me.PictureBox19 = New Elegant.Ui.PictureBox()
      Me.eui_Informazioni = New Elegant.Ui.Label()
      Me.StatusBar1.SuspendLayout()
      Me.StatusBarNotificationsArea1.SuspendLayout()
      Me.StatusBarPane2.SuspendLayout()
      CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'formFrameSkinner
      '
      Me.formFrameSkinner.AllowGlass = False
      Me.formFrameSkinner.Form = Me
      '
      'StatusBar1
      '
      Me.StatusBar1.Controls.Add(Me.StatusBarNotificationsArea1)
      Me.StatusBar1.Controls.Add(Me.StatusBarControlsArea1)
      Me.StatusBar1.ControlsArea = Me.StatusBarControlsArea1
      Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.StatusBar1.Location = New System.Drawing.Point(0, 456)
      Me.StatusBar1.Name = "StatusBar1"
      Me.StatusBar1.NotificationsArea = Me.StatusBarNotificationsArea1
      Me.StatusBar1.Size = New System.Drawing.Size(700, 22)
      Me.StatusBar1.TabIndex = 1
      Me.StatusBar1.Text = "StatusBar1"
      '
      'StatusBarNotificationsArea1
      '
      Me.StatusBarNotificationsArea1.Controls.Add(Me.StatusBarPane2)
      Me.StatusBarNotificationsArea1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.StatusBarNotificationsArea1.Location = New System.Drawing.Point(0, 0)
      Me.StatusBarNotificationsArea1.MaximumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarNotificationsArea1.MinimumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarNotificationsArea1.Name = "StatusBarNotificationsArea1"
      Me.StatusBarNotificationsArea1.Size = New System.Drawing.Size(680, 22)
      Me.StatusBarNotificationsArea1.TabIndex = 1
      '
      'StatusBarPane2
      '
      Me.StatusBarPane2.Controls.Add(Me.PictureBox19)
      Me.StatusBarPane2.Controls.Add(Me.eui_Informazioni)
      Me.StatusBarPane2.Location = New System.Drawing.Point(0, 0)
      Me.StatusBarPane2.MaximumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarPane2.MinimumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarPane2.Name = "StatusBarPane2"
      Me.StatusBarPane2.Size = New System.Drawing.Size(287, 22)
      Me.StatusBarPane2.TabIndex = 0
      '
      'StatusBarControlsArea1
      '
      Me.StatusBarControlsArea1.Dock = System.Windows.Forms.DockStyle.Right
      Me.StatusBarControlsArea1.Location = New System.Drawing.Point(680, 0)
      Me.StatusBarControlsArea1.MaximumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarControlsArea1.MinimumSize = New System.Drawing.Size(0, 22)
      Me.StatusBarControlsArea1.Name = "StatusBarControlsArea1"
      Me.StatusBarControlsArea1.Size = New System.Drawing.Size(20, 22)
      Me.StatusBarControlsArea1.TabIndex = 0
      '
      'eui_txtMittente
      '
      Me.eui_txtMittente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_txtMittente.Id = "9011353d-a173-4211-b7dd-29bc596c81d9"
      Me.eui_txtMittente.Location = New System.Drawing.Point(81, 9)
      Me.eui_txtMittente.Name = "eui_txtMittente"
      Me.eui_txtMittente.Size = New System.Drawing.Size(468, 21)
      Me.eui_txtMittente.TabIndex = 0
      Me.eui_txtMittente.TextEditorWidth = 593
      '
      'eui_txtDestinatario
      '
      Me.eui_txtDestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_txtDestinatario.Id = "6ab5f488-b5a2-4511-9193-113cce88e36e"
      Me.eui_txtDestinatario.Location = New System.Drawing.Point(81, 35)
      Me.eui_txtDestinatario.Name = "eui_txtDestinatario"
      Me.eui_txtDestinatario.Size = New System.Drawing.Size(468, 21)
      Me.eui_txtDestinatario.TabIndex = 1
      Me.eui_txtDestinatario.TextEditorWidth = 593
      '
      'eui_txtOggetto
      '
      Me.eui_txtOggetto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_txtOggetto.Id = "d2d36a2b-2e99-4bf8-9cc9-33fb02fee0c5"
      Me.eui_txtOggetto.Location = New System.Drawing.Point(81, 62)
      Me.eui_txtOggetto.Name = "eui_txtOggetto"
      Me.eui_txtOggetto.Size = New System.Drawing.Size(468, 21)
      Me.eui_txtOggetto.TabIndex = 2
      Me.eui_txtOggetto.TextEditorWidth = 593
      '
      'eui_txtAllegati
      '
      Me.eui_txtAllegati.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_txtAllegati.Id = "c922073b-59c7-4925-ae70-814be60f3234"
      Me.eui_txtAllegati.Location = New System.Drawing.Point(81, 89)
      Me.eui_txtAllegati.Multiline = True
      Me.eui_txtAllegati.Name = "eui_txtAllegati"
      Me.eui_txtAllegati.Size = New System.Drawing.Size(468, 86)
      Me.eui_txtAllegati.TabIndex = 3
      Me.eui_txtAllegati.TextEditorWidth = 372
      '
      'TabControl1
      '
      Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TabControl1.Location = New System.Drawing.Point(0, 188)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedTabPage = Me.TabPage1
      Me.TabControl1.Size = New System.Drawing.Size(692, 257)
      Me.TabControl1.TabIndex = 6
      Me.TabControl1.TabPages.AddRange(New Elegant.Ui.TabPage() {Me.TabPage1})
      Me.TabControl1.Text = "TabControl1"
      '
      'TabPage1
      '
      Me.TabPage1.ActiveControl = Nothing
      Me.TabPage1.Controls.Add(Me.eui_txtMessaggio)
      Me.TabPage1.KeyTip = Nothing
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Size = New System.Drawing.Size(690, 236)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Messaggio"
      '
      'eui_txtMessaggio
      '
      Me.eui_txtMessaggio.Dock = System.Windows.Forms.DockStyle.Fill
      Me.eui_txtMessaggio.Id = "323c86ba-61c3-4765-9ad4-6a07eb2e4b6e"
      Me.eui_txtMessaggio.Location = New System.Drawing.Point(0, 0)
      Me.eui_txtMessaggio.Multiline = True
      Me.eui_txtMessaggio.Name = "eui_txtMessaggio"
      Me.eui_txtMessaggio.Size = New System.Drawing.Size(690, 236)
      Me.eui_txtMessaggio.TabIndex = 0
      Me.eui_txtMessaggio.TextEditorWidth = 790
      '
      'Label1
      '
      Me.Label1.Location = New System.Drawing.Point(7, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(45, 17)
      Me.Label1.TabIndex = 8
      Me.Label1.Text = "Mittente:"
      '
      'Label2
      '
      Me.Label2.Location = New System.Drawing.Point(7, 35)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(59, 17)
      Me.Label2.TabIndex = 9
      Me.Label2.Text = "Destinatario:"
      '
      'Label4
      '
      Me.Label4.Location = New System.Drawing.Point(7, 62)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(45, 17)
      Me.Label4.TabIndex = 11
      Me.Label4.Text = "Oggetto:"
      '
      'Label5
      '
      Me.Label5.Location = New System.Drawing.Point(7, 89)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(45, 17)
      Me.Label5.TabIndex = 12
      Me.Label5.Text = "Allegati:"
      '
      'eui_cmdAnnulla
      '
      Me.eui_cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.eui_cmdAnnulla.Id = "8b59c6d8-d387-4a57-b565-aeb3ed3dde9a"
      Me.eui_cmdAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.eui_cmdAnnulla.Location = New System.Drawing.Point(563, 93)
      Me.eui_cmdAnnulla.Name = "eui_cmdAnnulla"
      Me.eui_cmdAnnulla.ScreenTip.Caption = "Esci"
      Me.eui_cmdAnnulla.ScreenTip.Text = "Annula le modifiche e chiude il documento."
      Me.eui_cmdAnnulla.Size = New System.Drawing.Size(120, 39)
      Me.eui_cmdAnnulla.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdAnnulla.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdAnnulla.TabIndex = 6
      Me.eui_cmdAnnulla.Text = "Annulla"
      '
      'eui_cmdSalva
      '
      Me.eui_cmdSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdSalva.Id = "0e02334c-1eaa-4c90-b151-b3bf2232591a"
      Me.eui_cmdSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.eui_cmdSalva.Location = New System.Drawing.Point(563, 51)
      Me.eui_cmdSalva.Name = "eui_cmdSalva"
      Me.eui_cmdSalva.ScreenTip.Caption = "Salva"
      Me.eui_cmdSalva.ScreenTip.Text = "Salva il documento."
      Me.eui_cmdSalva.Size = New System.Drawing.Size(120, 39)
      Me.eui_cmdSalva.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdSalva.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdSalva.TabIndex = 5
      Me.eui_cmdSalva.Text = "Salva"
      '
      'eui_cmdAllegaFile
      '
      Me.eui_cmdAllegaFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdAllegaFile.Id = "84fe1553-fd8a-4625-ad32-47331fbc3a63"
      Me.eui_cmdAllegaFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.eui_cmdAllegaFile.Location = New System.Drawing.Point(563, 135)
      Me.eui_cmdAllegaFile.Name = "eui_cmdAllegaFile"
      Me.eui_cmdAllegaFile.ScreenTip.Caption = "Emetti"
      Me.eui_cmdAllegaFile.ScreenTip.Text = "Salva ed emette il documento eseguendo le operazioni contabili."
      Me.eui_cmdAllegaFile.Size = New System.Drawing.Size(120, 39)
      Me.eui_cmdAllegaFile.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdAllegaFile.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdAllegaFile.TabIndex = 7
      Me.eui_cmdAllegaFile.Text = "Allega file"
      '
      'eui_cmdInvia
      '
      Me.eui_cmdInvia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdInvia.Id = "5cc6dc80-e953-465d-9d21-2bcaa657e76a"
      Me.eui_cmdInvia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.eui_cmdInvia.Location = New System.Drawing.Point(563, 9)
      Me.eui_cmdInvia.Name = "eui_cmdInvia"
      Me.eui_cmdInvia.ScreenTip.Caption = "Emetti"
      Me.eui_cmdInvia.ScreenTip.Text = "Salva ed emette il documento eseguendo le operazioni contabili."
      Me.eui_cmdInvia.Size = New System.Drawing.Size(120, 39)
      Me.eui_cmdInvia.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdInvia.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdInvia.TabIndex = 4
      Me.eui_cmdInvia.Text = "Invia"
      '
      'PictureBox19
      '
      Me.PictureBox19.Dock = System.Windows.Forms.DockStyle.Fill
      Me.PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), System.Drawing.Image)
      Me.PictureBox19.Location = New System.Drawing.Point(2, 3)
      Me.PictureBox19.Name = "PictureBox19"
      Me.PictureBox19.Size = New System.Drawing.Size(16, 16)
      Me.PictureBox19.SizeMode = Elegant.Ui.PictureBoxSizeMode.StretchImage
      Me.PictureBox19.TabIndex = 5
      Me.PictureBox19.TabStop = False
      Me.PictureBox19.Text = "PictureBox19"
      '
      'eui_Informazioni
      '
      Me.eui_Informazioni.Location = New System.Drawing.Point(21, 5)
      Me.eui_Informazioni.Name = "eui_Informazioni"
      Me.eui_Informazioni.Size = New System.Drawing.Size(231, 13)
      Me.eui_Informazioni.TabIndex = 4
      Me.eui_Informazioni.Text = "Inviato il 20/07/2018 alle 21.30 a Luigi Montana."
      '
      'InvioEmail
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.ClientSize = New System.Drawing.Size(700, 478)
      Me.Controls.Add(Me.eui_cmdInvia)
      Me.Controls.Add(Me.eui_cmdAllegaFile)
      Me.Controls.Add(Me.eui_cmdSalva)
      Me.Controls.Add(Me.eui_cmdAnnulla)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.eui_txtAllegati)
      Me.Controls.Add(Me.eui_txtOggetto)
      Me.Controls.Add(Me.eui_txtDestinatario)
      Me.Controls.Add(Me.eui_txtMittente)
      Me.Controls.Add(Me.StatusBar1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "InvioEmail"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Invio E-mail - Nuovo messaggio "
      Me.StatusBar1.ResumeLayout(False)
      Me.StatusBar1.PerformLayout()
      Me.StatusBarNotificationsArea1.ResumeLayout(False)
      Me.StatusBarNotificationsArea1.PerformLayout()
      Me.StatusBarPane2.ResumeLayout(False)
      Me.StatusBarPane2.PerformLayout()
      CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
   Friend WithEvents StatusBar1 As Elegant.Ui.StatusBar
   Friend WithEvents StatusBarNotificationsArea1 As Elegant.Ui.StatusBarNotificationsArea
   Friend WithEvents StatusBarPane2 As Elegant.Ui.StatusBarPane
   Friend WithEvents StatusBarControlsArea1 As Elegant.Ui.StatusBarControlsArea
   Friend WithEvents TabControl1 As Elegant.Ui.TabControl
   Friend WithEvents eui_txtAllegati As Elegant.Ui.TextBox
   Friend WithEvents eui_txtOggetto As Elegant.Ui.TextBox
   Friend WithEvents eui_txtDestinatario As Elegant.Ui.TextBox
   Friend WithEvents eui_txtMittente As Elegant.Ui.TextBox
   Friend WithEvents Label5 As Elegant.Ui.Label
   Friend WithEvents Label4 As Elegant.Ui.Label
   Friend WithEvents Label2 As Elegant.Ui.Label
   Friend WithEvents Label1 As Elegant.Ui.Label
   Friend WithEvents TabPage1 As Elegant.Ui.TabPage
   Friend WithEvents eui_txtMessaggio As Elegant.Ui.TextBox
   Friend WithEvents eui_cmdAnnulla As Elegant.Ui.Button
   Friend WithEvents eui_cmdSalva As Elegant.Ui.Button
   Friend WithEvents eui_cmdAllegaFile As Elegant.Ui.Button
   Friend WithEvents eui_cmdInvia As Elegant.Ui.Button
   Friend WithEvents PictureBox19 As Elegant.Ui.PictureBox
   Friend WithEvents eui_Informazioni As Elegant.Ui.Label
End Class
