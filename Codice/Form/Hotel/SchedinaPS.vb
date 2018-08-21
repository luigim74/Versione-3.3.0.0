#Region " DATI FILE.VB "
' ******************************************************************
' Nome form:            frmSchedinaPS
' Autore:               Luigi Montana, Montana Software
' Data creazione:       13/08/2018
' Data ultima modifica: 17/08/2018
' Descrizione:          Anagrafica Schedine pubblica sicurezza.
' Note:

' Elenco Attivita:

' DA_FARE: Sviluppare! Aggiungere Tabella Componenti.
' DA_FARE: Modificare lo Storico presenze prelevando i dati dalle schedine e non dalle prenotazioni.

' ******************************************************************
#End Region

Option Strict Off
Option Explicit On 

Imports System.IO
Imports System.Data.OleDb

Public Class frmSchedinaPS
   Inherits System.Windows.Forms.Form

#Region " Codice generato da Progettazione Windows Form "

   Public Sub New()
      MyBase.New()

      'Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      'Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent()

   End Sub

   'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
   Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Richiesto da Progettazione Windows Form
   Private components As System.ComponentModel.IContainer

   'NOTA: la procedura che segue è richiesta da Progettazione Windows Form.
   'Può essere modificata in Progettazione Windows Form.  
   'Non modificarla nell'editor del codice.
   Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents lblIntestazione As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
   Public WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Salva As System.Windows.Forms.ToolBarButton
   Friend WithEvents Annulla As System.Windows.Forms.ToolBarButton
   Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
   Public WithEvents txtCodice As System.Windows.Forms.TextBox
   Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
   Public WithEvents txtNumero As System.Windows.Forms.TextBox
   Public WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents cmbNumeroCamera As System.Windows.Forms.ComboBox
   Public WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents lvwOccupanti As System.Windows.Forms.ListView
   Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
   Public WithEvents txtLuogoNascita As System.Windows.Forms.TextBox
   Public WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cmdInserisciOccupanti As Elegant.Ui.Button
   Friend WithEvents cmdEliminaOccupanti As Elegant.Ui.Button
   Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
   Friend WithEvents cmbStato As System.Windows.Forms.ComboBox
   Public WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Public WithEvents lblPartenza As System.Windows.Forms.Label
   Public WithEvents lblArrivo As System.Windows.Forms.Label
   Friend WithEvents mcDataPartenza As System.Windows.Forms.MonthCalendar
   Public WithEvents txtNumeroNotti As System.Windows.Forms.TextBox
   Public WithEvents Label27 As System.Windows.Forms.Label
   Friend WithEvents mcDataArrivo As System.Windows.Forms.MonthCalendar
   Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
   Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
   Friend WithEvents dtpDataStampa As DateTimePicker
   Public WithEvents Label3 As Label
   Public WithEvents txtNumeroPren As TextBox
   Public WithEvents Label8 As Label
   Friend WithEvents cmbNome As ComboBox
   Friend WithEvents cmbIdCliente As ComboBox
   Public WithEvents txtNome As TextBox
   Friend WithEvents cmbCognome As ComboBox
   Friend WithEvents dtpDataNascita As DateTimePicker
   Public WithEvents Label7 As Label
   Friend WithEvents cmdApriIntestatario As Button
   Public WithEvents Label20 As Label
   Friend WithEvents cmbSesso As ComboBox
   Public WithEvents Label4 As Label
   Public WithEvents Label1 As Label
   Friend WithEvents cmbCittadinanza As ComboBox
   Public WithEvents Label21 As Label
   Friend WithEvents cmbNazioneNascita As ComboBox
   Public WithEvents Label19 As Label
   Public WithEvents txtProvNascita As TextBox
   Public WithEvents txtComuneRilascioDoc As TextBox
   Public WithEvents Label29 As Label
   Public WithEvents txtNumeroDoc As TextBox
   Public WithEvents Label16 As Label
   Public WithEvents Label17 As Label
   Friend WithEvents cmbTipoDoc As ComboBox
   Public WithEvents Label9 As Label
   Public WithEvents Label2 As Label
   Friend WithEvents dtpDataRilascioDoc As DateTimePicker
   Friend WithEvents cmbNazioneRilascioDoc As ComboBox
   Public WithEvents Label35 As Label
   Friend WithEvents ColumnHeader1 As ColumnHeader
   Public WithEvents txtRilasciatoDaDoc As TextBox
   Friend WithEvents cmdNuovoIntestatario As Button
   Friend WithEvents cmbTipologia As ComboBox
   Public WithEvents Label14 As Label
   Public WithEvents Label10 As Label
   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchedinaPS))
      Me.ToolBar1 = New System.Windows.Forms.ToolBar()
      Me.Salva = New System.Windows.Forms.ToolBarButton()
      Me.Annulla = New System.Windows.Forms.ToolBarButton()
      Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.lblIntestazione = New System.Windows.Forms.Label()
      Me.TabControl1 = New System.Windows.Forms.TabControl()
      Me.TabPage1 = New System.Windows.Forms.TabPage()
      Me.txtNumeroPren = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.dtpDataStampa = New System.Windows.Forms.DateTimePicker()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.mcDataArrivo = New System.Windows.Forms.MonthCalendar()
      Me.txtNumeroNotti = New System.Windows.Forms.TextBox()
      Me.Label27 = New System.Windows.Forms.Label()
      Me.lblPartenza = New System.Windows.Forms.Label()
      Me.lblArrivo = New System.Windows.Forms.Label()
      Me.mcDataPartenza = New System.Windows.Forms.MonthCalendar()
      Me.cmbStato = New System.Windows.Forms.ComboBox()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.txtNumero = New System.Windows.Forms.TextBox()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.cmbNumeroCamera = New System.Windows.Forms.ComboBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.txtCodice = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.TabPage4 = New System.Windows.Forms.TabPage()
      Me.cmbTipologia = New System.Windows.Forms.ComboBox()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.cmdNuovoIntestatario = New System.Windows.Forms.Button()
      Me.cmbCittadinanza = New System.Windows.Forms.ComboBox()
      Me.Label21 = New System.Windows.Forms.Label()
      Me.cmbNazioneNascita = New System.Windows.Forms.ComboBox()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.txtProvNascita = New System.Windows.Forms.TextBox()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.cmbSesso = New System.Windows.Forms.ComboBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.cmbNome = New System.Windows.Forms.ComboBox()
      Me.cmbIdCliente = New System.Windows.Forms.ComboBox()
      Me.txtNome = New System.Windows.Forms.TextBox()
      Me.cmbCognome = New System.Windows.Forms.ComboBox()
      Me.dtpDataNascita = New System.Windows.Forms.DateTimePicker()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.cmdApriIntestatario = New System.Windows.Forms.Button()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.txtLuogoNascita = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.TabPage5 = New System.Windows.Forms.TabPage()
      Me.txtRilasciatoDaDoc = New System.Windows.Forms.TextBox()
      Me.cmbNazioneRilascioDoc = New System.Windows.Forms.ComboBox()
      Me.Label35 = New System.Windows.Forms.Label()
      Me.dtpDataRilascioDoc = New System.Windows.Forms.DateTimePicker()
      Me.txtComuneRilascioDoc = New System.Windows.Forms.TextBox()
      Me.Label29 = New System.Windows.Forms.Label()
      Me.txtNumeroDoc = New System.Windows.Forms.TextBox()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.Label17 = New System.Windows.Forms.Label()
      Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.TabPage3 = New System.Windows.Forms.TabPage()
      Me.cmdInserisciOccupanti = New Elegant.Ui.Button()
      Me.cmdEliminaOccupanti = New Elegant.Ui.Button()
      Me.lvwOccupanti = New System.Windows.Forms.ListView()
      Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
      Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
      Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
      Me.Panel1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.TabPage4.SuspendLayout()
      Me.TabPage5.SuspendLayout()
      Me.TabPage3.SuspendLayout()
      CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'ToolBar1
      '
      Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
      Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.Salva, Me.Annulla})
      Me.ToolBar1.ButtonSize = New System.Drawing.Size(22, 22)
      Me.ToolBar1.Divider = False
      Me.ToolBar1.DropDownArrows = True
      Me.ToolBar1.ImageList = Me.ImageList1
      Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
      Me.ToolBar1.Name = "ToolBar1"
      Me.ToolBar1.ShowToolTips = True
      Me.ToolBar1.Size = New System.Drawing.Size(645, 26)
      Me.ToolBar1.TabIndex = 0
      Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
      '
      'Salva
      '
      Me.Salva.ImageIndex = 0
      Me.Salva.Name = "Salva"
      Me.Salva.Tag = "Salva"
      Me.Salva.Text = "Salva"
      Me.Salva.ToolTipText = "Salva"
      '
      'Annulla
      '
      Me.Annulla.ImageIndex = 1
      Me.Annulla.Name = "Annulla"
      Me.Annulla.Tag = "Annulla"
      Me.Annulla.Text = "Annulla"
      Me.Annulla.ToolTipText = "Annulla"
      '
      'ImageList1
      '
      Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
      Me.ImageList1.Images.SetKeyName(0, "saveHS.png")
      Me.ImageList1.Images.SetKeyName(1, "Edit_UndoHS.png")
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Gray
      Me.Panel1.Controls.Add(Me.lblIntestazione)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel1.Location = New System.Drawing.Point(0, 26)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(645, 20)
      Me.Panel1.TabIndex = 0
      '
      'lblIntestazione
      '
      Me.lblIntestazione.AutoSize = True
      Me.lblIntestazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblIntestazione.ForeColor = System.Drawing.SystemColors.Window
      Me.lblIntestazione.Location = New System.Drawing.Point(4, 2)
      Me.lblIntestazione.Name = "lblIntestazione"
      Me.lblIntestazione.Size = New System.Drawing.Size(16, 16)
      Me.lblIntestazione.TabIndex = 0
      Me.lblIntestazione.Text = "#"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Controls.Add(Me.TabPage4)
      Me.TabControl1.Controls.Add(Me.TabPage5)
      Me.TabControl1.Controls.Add(Me.TabPage3)
      Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TabControl1.Location = New System.Drawing.Point(0, 46)
      Me.TabControl1.Multiline = True
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(645, 464)
      Me.TabControl1.TabIndex = 0
      '
      'TabPage1
      '
      Me.TabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.TabPage1.Controls.Add(Me.txtNumeroPren)
      Me.TabPage1.Controls.Add(Me.Label8)
      Me.TabPage1.Controls.Add(Me.dtpDataStampa)
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.Panel2)
      Me.TabPage1.Controls.Add(Me.cmbStato)
      Me.TabPage1.Controls.Add(Me.Label13)
      Me.TabPage1.Controls.Add(Me.txtNumero)
      Me.TabPage1.Controls.Add(Me.Label12)
      Me.TabPage1.Controls.Add(Me.cmbNumeroCamera)
      Me.TabPage1.Controls.Add(Me.Label11)
      Me.TabPage1.Controls.Add(Me.txtCodice)
      Me.TabPage1.Controls.Add(Me.Label5)
      Me.TabPage1.ForeColor = System.Drawing.Color.Black
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Size = New System.Drawing.Size(637, 438)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati schedina"
      '
      'txtNumeroPren
      '
      Me.txtNumeroPren.AcceptsReturn = True
      Me.txtNumeroPren.BackColor = System.Drawing.SystemColors.Window
      Me.txtNumeroPren.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtNumeroPren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroPren.ForeColor = System.Drawing.Color.Black
      Me.txtNumeroPren.Location = New System.Drawing.Point(386, 55)
      Me.txtNumeroPren.MaxLength = 0
      Me.txtNumeroPren.Name = "txtNumeroPren"
      Me.txtNumeroPren.ReadOnly = True
      Me.txtNumeroPren.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtNumeroPren.Size = New System.Drawing.Size(134, 20)
      Me.txtNumeroPren.TabIndex = 3
      Me.txtNumeroPren.TabStop = False
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label8.ForeColor = System.Drawing.Color.Black
      Me.Label8.Location = New System.Drawing.Point(269, 59)
      Me.Label8.Name = "Label8"
      Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label8.Size = New System.Drawing.Size(111, 13)
      Me.Label8.TabIndex = 245
      Me.Label8.Text = "Numero prenotazione:"
      '
      'dtpDataStampa
      '
      Me.dtpDataStampa.Checked = False
      Me.dtpDataStampa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDataStampa.Location = New System.Drawing.Point(386, 92)
      Me.dtpDataStampa.Name = "dtpDataStampa"
      Me.dtpDataStampa.ShowCheckBox = True
      Me.dtpDataStampa.Size = New System.Drawing.Size(134, 20)
      Me.dtpDataStampa.TabIndex = 5
      Me.dtpDataStampa.Value = New Date(2005, 8, 17, 15, 37, 0, 654)
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label3.ForeColor = System.Drawing.Color.Black
      Me.Label3.Location = New System.Drawing.Point(269, 95)
      Me.Label3.Name = "Label3"
      Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label3.Size = New System.Drawing.Size(81, 13)
      Me.Label3.TabIndex = 243
      Me.Label3.Text = "Data di stampa:"
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.Color.White
      Me.Panel2.Controls.Add(Me.mcDataArrivo)
      Me.Panel2.Controls.Add(Me.txtNumeroNotti)
      Me.Panel2.Controls.Add(Me.Label27)
      Me.Panel2.Controls.Add(Me.lblPartenza)
      Me.Panel2.Controls.Add(Me.lblArrivo)
      Me.Panel2.Controls.Add(Me.mcDataPartenza)
      Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.Panel2.Location = New System.Drawing.Point(0, 203)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(637, 235)
      Me.Panel2.TabIndex = 232
      '
      'mcDataArrivo
      '
      Me.mcDataArrivo.Location = New System.Drawing.Point(32, 40)
      Me.mcDataArrivo.MaxSelectionCount = 1
      Me.mcDataArrivo.Name = "mcDataArrivo"
      Me.mcDataArrivo.ShowToday = False
      Me.mcDataArrivo.ShowTodayCircle = False
      Me.mcDataArrivo.TabIndex = 0
      Me.mcDataArrivo.TodayDate = New Date(2014, 8, 27, 0, 0, 0, 0)
      '
      'txtNumeroNotti
      '
      Me.txtNumeroNotti.AcceptsReturn = True
      Me.txtNumeroNotti.BackColor = System.Drawing.SystemColors.Window
      Me.txtNumeroNotti.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtNumeroNotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroNotti.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtNumeroNotti.Location = New System.Drawing.Point(440, 202)
      Me.txtNumeroNotti.MaxLength = 0
      Me.txtNumeroNotti.Name = "txtNumeroNotti"
      Me.txtNumeroNotti.ReadOnly = True
      Me.txtNumeroNotti.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtNumeroNotti.Size = New System.Drawing.Size(80, 20)
      Me.txtNumeroNotti.TabIndex = 2
      Me.txtNumeroNotti.TabStop = False
      Me.txtNumeroNotti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label27
      '
      Me.Label27.AutoSize = True
      Me.Label27.BackColor = System.Drawing.Color.Transparent
      Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label27.ForeColor = System.Drawing.Color.Black
      Me.Label27.Location = New System.Drawing.Point(325, 205)
      Me.Label27.Name = "Label27"
      Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label27.Size = New System.Drawing.Size(109, 13)
      Me.Label27.TabIndex = 237
      Me.Label27.Text = "Giorni di permanenza:"
      '
      'lblPartenza
      '
      Me.lblPartenza.AutoSize = True
      Me.lblPartenza.BackColor = System.Drawing.Color.Transparent
      Me.lblPartenza.Cursor = System.Windows.Forms.Cursors.Default
      Me.lblPartenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblPartenza.ForeColor = System.Drawing.Color.Green
      Me.lblPartenza.Location = New System.Drawing.Point(295, 19)
      Me.lblPartenza.Name = "lblPartenza"
      Me.lblPartenza.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.lblPartenza.Size = New System.Drawing.Size(68, 15)
      Me.lblPartenza.TabIndex = 233
      Me.lblPartenza.Text = "Partenza:"
      '
      'lblArrivo
      '
      Me.lblArrivo.AutoSize = True
      Me.lblArrivo.BackColor = System.Drawing.Color.Transparent
      Me.lblArrivo.Cursor = System.Windows.Forms.Cursors.Default
      Me.lblArrivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblArrivo.ForeColor = System.Drawing.Color.Red
      Me.lblArrivo.Location = New System.Drawing.Point(31, 19)
      Me.lblArrivo.Name = "lblArrivo"
      Me.lblArrivo.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.lblArrivo.Size = New System.Drawing.Size(47, 15)
      Me.lblArrivo.TabIndex = 232
      Me.lblArrivo.Text = "Arrivo:"
      '
      'mcDataPartenza
      '
      Me.mcDataPartenza.Location = New System.Drawing.Point(295, 40)
      Me.mcDataPartenza.MaxSelectionCount = 1
      Me.mcDataPartenza.Name = "mcDataPartenza"
      Me.mcDataPartenza.ShowToday = False
      Me.mcDataPartenza.ShowTodayCircle = False
      Me.mcDataPartenza.TabIndex = 1
      '
      'cmbStato
      '
      Me.cmbStato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbStato.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbStato.Items.AddRange(New Object() {"Inserita", "Inviata", "Stampata"})
      Me.cmbStato.Location = New System.Drawing.Point(118, 92)
      Me.cmbStato.Name = "cmbStato"
      Me.cmbStato.Size = New System.Drawing.Size(134, 21)
      Me.cmbStato.TabIndex = 4
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label13.ForeColor = System.Drawing.Color.Black
      Me.Label13.Location = New System.Drawing.Point(31, 95)
      Me.Label13.Name = "Label13"
      Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label13.Size = New System.Drawing.Size(81, 13)
      Me.Label13.TabIndex = 231
      Me.Label13.Text = "Stato schedina:"
      '
      'txtNumero
      '
      Me.txtNumero.AcceptsReturn = True
      Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
      Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumero.ForeColor = System.Drawing.Color.Red
      Me.txtNumero.Location = New System.Drawing.Point(386, 20)
      Me.txtNumero.MaxLength = 0
      Me.txtNumero.Name = "txtNumero"
      Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtNumero.Size = New System.Drawing.Size(134, 20)
      Me.txtNumero.TabIndex = 1
      Me.txtNumero.TabStop = False
      Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label12.ForeColor = System.Drawing.Color.Black
      Me.Label12.Location = New System.Drawing.Point(269, 23)
      Me.Label12.Name = "Label12"
      Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label12.Size = New System.Drawing.Size(93, 13)
      Me.Label12.TabIndex = 200
      Me.Label12.Text = "Numero schedina:"
      '
      'cmbNumeroCamera
      '
      Me.cmbNumeroCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbNumeroCamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbNumeroCamera.Location = New System.Drawing.Point(118, 55)
      Me.cmbNumeroCamera.Name = "cmbNumeroCamera"
      Me.cmbNumeroCamera.Size = New System.Drawing.Size(134, 21)
      Me.cmbNumeroCamera.TabIndex = 2
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label11.ForeColor = System.Drawing.Color.Black
      Me.Label11.Location = New System.Drawing.Point(29, 59)
      Me.Label11.Name = "Label11"
      Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label11.Size = New System.Drawing.Size(46, 13)
      Me.Label11.TabIndex = 197
      Me.Label11.Text = "Camera:"
      '
      'txtCodice
      '
      Me.txtCodice.AcceptsReturn = True
      Me.txtCodice.BackColor = System.Drawing.SystemColors.Window
      Me.txtCodice.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtCodice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCodice.ForeColor = System.Drawing.Color.Red
      Me.txtCodice.Location = New System.Drawing.Point(118, 20)
      Me.txtCodice.MaxLength = 0
      Me.txtCodice.Name = "txtCodice"
      Me.txtCodice.ReadOnly = True
      Me.txtCodice.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtCodice.Size = New System.Drawing.Size(134, 20)
      Me.txtCodice.TabIndex = 0
      Me.txtCodice.TabStop = False
      Me.txtCodice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label5.ForeColor = System.Drawing.Color.Black
      Me.Label5.Location = New System.Drawing.Point(29, 23)
      Me.Label5.Name = "Label5"
      Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label5.Size = New System.Drawing.Size(43, 13)
      Me.Label5.TabIndex = 164
      Me.Label5.Text = "Codice:"
      '
      'TabPage4
      '
      Me.TabPage4.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.TabPage4.Controls.Add(Me.cmbTipologia)
      Me.TabPage4.Controls.Add(Me.Label14)
      Me.TabPage4.Controls.Add(Me.cmdNuovoIntestatario)
      Me.TabPage4.Controls.Add(Me.cmbCittadinanza)
      Me.TabPage4.Controls.Add(Me.Label21)
      Me.TabPage4.Controls.Add(Me.cmbNazioneNascita)
      Me.TabPage4.Controls.Add(Me.Label19)
      Me.TabPage4.Controls.Add(Me.txtProvNascita)
      Me.TabPage4.Controls.Add(Me.Label10)
      Me.TabPage4.Controls.Add(Me.cmbSesso)
      Me.TabPage4.Controls.Add(Me.Label4)
      Me.TabPage4.Controls.Add(Me.Label1)
      Me.TabPage4.Controls.Add(Me.cmbNome)
      Me.TabPage4.Controls.Add(Me.cmbIdCliente)
      Me.TabPage4.Controls.Add(Me.txtNome)
      Me.TabPage4.Controls.Add(Me.cmbCognome)
      Me.TabPage4.Controls.Add(Me.dtpDataNascita)
      Me.TabPage4.Controls.Add(Me.Label7)
      Me.TabPage4.Controls.Add(Me.cmdApriIntestatario)
      Me.TabPage4.Controls.Add(Me.Label20)
      Me.TabPage4.Controls.Add(Me.txtLuogoNascita)
      Me.TabPage4.Controls.Add(Me.Label6)
      Me.TabPage4.Location = New System.Drawing.Point(4, 22)
      Me.TabPage4.Name = "TabPage4"
      Me.TabPage4.Size = New System.Drawing.Size(637, 438)
      Me.TabPage4.TabIndex = 8
      Me.TabPage4.Text = "Dati Anagrafici"
      '
      'cmbTipologia
      '
      Me.cmbTipologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbTipologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbTipologia.Items.AddRange(New Object() {"Ospite Singolo", "Capo Famiglia", "Capo Gruppo"})
      Me.cmbTipologia.Location = New System.Drawing.Point(394, 96)
      Me.cmbTipologia.Name = "cmbTipologia"
      Me.cmbTipologia.Size = New System.Drawing.Size(112, 21)
      Me.cmbTipologia.TabIndex = 5
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label14.ForeColor = System.Drawing.Color.Black
      Me.Label14.Location = New System.Drawing.Point(305, 99)
      Me.Label14.Name = "Label14"
      Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label14.Size = New System.Drawing.Size(79, 13)
      Me.Label14.TabIndex = 266
      Me.Label14.Text = "Tipo alloggiato:"
      '
      'cmdNuovoIntestatario
      '
      Me.cmdNuovoIntestatario.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.cmdNuovoIntestatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmdNuovoIntestatario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdNuovoIntestatario.Location = New System.Drawing.Point(482, 58)
      Me.cmdNuovoIntestatario.Name = "cmdNuovoIntestatario"
      Me.cmdNuovoIntestatario.Size = New System.Drawing.Size(24, 22)
      Me.cmdNuovoIntestatario.TabIndex = 3
      Me.cmdNuovoIntestatario.Tag = ""
      Me.cmdNuovoIntestatario.Text = "+"
      Me.ToolTip1.SetToolTip(Me.cmdNuovoIntestatario, "Apre la finestra Clienti per un nuovo inserimento.")
      '
      'cmbCittadinanza
      '
      Me.cmbCittadinanza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbCittadinanza.Location = New System.Drawing.Point(379, 223)
      Me.cmbCittadinanza.Name = "cmbCittadinanza"
      Me.cmbCittadinanza.Size = New System.Drawing.Size(127, 21)
      Me.cmbCittadinanza.TabIndex = 10
      '
      'Label21
      '
      Me.Label21.AutoSize = True
      Me.Label21.BackColor = System.Drawing.Color.Transparent
      Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label21.ForeColor = System.Drawing.Color.Black
      Me.Label21.Location = New System.Drawing.Point(305, 223)
      Me.Label21.Name = "Label21"
      Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label21.Size = New System.Drawing.Size(68, 13)
      Me.Label21.TabIndex = 263
      Me.Label21.Text = "Cittadinanza:"
      '
      'cmbNazioneNascita
      '
      Me.cmbNazioneNascita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbNazioneNascita.Location = New System.Drawing.Point(125, 223)
      Me.cmbNazioneNascita.Name = "cmbNazioneNascita"
      Me.cmbNazioneNascita.Size = New System.Drawing.Size(160, 21)
      Me.cmbNazioneNascita.TabIndex = 9
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.BackColor = System.Drawing.Color.Transparent
      Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label19.ForeColor = System.Drawing.Color.Black
      Me.Label19.Location = New System.Drawing.Point(21, 223)
      Me.Label19.Name = "Label19"
      Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label19.Size = New System.Drawing.Size(97, 13)
      Me.Label19.TabIndex = 261
      Me.Label19.Text = "Nazione di nascita:"
      '
      'txtProvNascita
      '
      Me.txtProvNascita.AcceptsReturn = True
      Me.txtProvNascita.BackColor = System.Drawing.SystemColors.Window
      Me.txtProvNascita.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtProvNascita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtProvNascita.ForeColor = System.Drawing.Color.Black
      Me.txtProvNascita.Location = New System.Drawing.Point(411, 188)
      Me.txtProvNascita.MaxLength = 0
      Me.txtProvNascita.Name = "txtProvNascita"
      Me.txtProvNascita.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtProvNascita.Size = New System.Drawing.Size(94, 20)
      Me.txtProvNascita.TabIndex = 8
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label10.ForeColor = System.Drawing.Color.Black
      Me.Label10.Location = New System.Drawing.Point(305, 188)
      Me.Label10.Name = "Label10"
      Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label10.Size = New System.Drawing.Size(102, 13)
      Me.Label10.TabIndex = 259
      Me.Label10.Text = "Provincia di nascita:"
      '
      'cmbSesso
      '
      Me.cmbSesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbSesso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbSesso.Items.AddRange(New Object() {"M", "F"})
      Me.cmbSesso.Location = New System.Drawing.Point(124, 95)
      Me.cmbSesso.Name = "cmbSesso"
      Me.cmbSesso.Size = New System.Drawing.Size(53, 21)
      Me.cmbSesso.TabIndex = 4
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label4.ForeColor = System.Drawing.Color.Black
      Me.Label4.Location = New System.Drawing.Point(21, 96)
      Me.Label4.Name = "Label4"
      Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label4.Size = New System.Drawing.Size(39, 13)
      Me.Label4.TabIndex = 257
      Me.Label4.Text = "Sesso:"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(22, 61)
      Me.Label1.Name = "Label1"
      Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label1.Size = New System.Drawing.Size(38, 13)
      Me.Label1.TabIndex = 255
      Me.Label1.Text = "Nome:"
      '
      'cmbNome
      '
      Me.cmbNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbNome.Location = New System.Drawing.Point(512, 58)
      Me.cmbNome.Name = "cmbNome"
      Me.cmbNome.Size = New System.Drawing.Size(24, 21)
      Me.cmbNome.TabIndex = 254
      Me.cmbNome.Visible = False
      '
      'cmbIdCliente
      '
      Me.cmbIdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbIdCliente.Location = New System.Drawing.Point(511, 22)
      Me.cmbIdCliente.Name = "cmbIdCliente"
      Me.cmbIdCliente.Size = New System.Drawing.Size(24, 21)
      Me.cmbIdCliente.TabIndex = 253
      Me.cmbIdCliente.Visible = False
      '
      'txtNome
      '
      Me.txtNome.AcceptsReturn = True
      Me.txtNome.BackColor = System.Drawing.SystemColors.Window
      Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtNome.Location = New System.Drawing.Point(124, 59)
      Me.txtNome.MaxLength = 0
      Me.txtNome.Name = "txtNome"
      Me.txtNome.ReadOnly = True
      Me.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtNome.Size = New System.Drawing.Size(336, 20)
      Me.txtNome.TabIndex = 1
      Me.txtNome.TabStop = False
      '
      'cmbCognome
      '
      Me.cmbCognome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmbCognome.Location = New System.Drawing.Point(124, 22)
      Me.cmbCognome.Name = "cmbCognome"
      Me.cmbCognome.Size = New System.Drawing.Size(381, 21)
      Me.cmbCognome.TabIndex = 0
      '
      'dtpDataNascita
      '
      Me.dtpDataNascita.Checked = False
      Me.dtpDataNascita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDataNascita.Location = New System.Drawing.Point(124, 150)
      Me.dtpDataNascita.Name = "dtpDataNascita"
      Me.dtpDataNascita.ShowCheckBox = True
      Me.dtpDataNascita.Size = New System.Drawing.Size(112, 20)
      Me.dtpDataNascita.TabIndex = 6
      Me.dtpDataNascita.Value = New Date(2005, 8, 17, 15, 37, 0, 654)
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label7.ForeColor = System.Drawing.Color.Black
      Me.Label7.Location = New System.Drawing.Point(21, 150)
      Me.Label7.Name = "Label7"
      Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label7.Size = New System.Drawing.Size(81, 13)
      Me.Label7.TabIndex = 252
      Me.Label7.Text = "Data di nascita:"
      '
      'cmdApriIntestatario
      '
      Me.cmdApriIntestatario.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.cmdApriIntestatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cmdApriIntestatario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdApriIntestatario.Location = New System.Drawing.Point(460, 58)
      Me.cmdApriIntestatario.Name = "cmdApriIntestatario"
      Me.cmdApriIntestatario.Size = New System.Drawing.Size(24, 22)
      Me.cmdApriIntestatario.TabIndex = 2
      Me.cmdApriIntestatario.Tag = ""
      Me.cmdApriIntestatario.Text = "..."
      Me.ToolTip1.SetToolTip(Me.cmdApriIntestatario, "Apre la finestra Clienti per un nuovo inserimento.")
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.BackColor = System.Drawing.Color.Transparent
      Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label20.ForeColor = System.Drawing.Color.Black
      Me.Label20.Location = New System.Drawing.Point(21, 25)
      Me.Label20.Name = "Label20"
      Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label20.Size = New System.Drawing.Size(55, 13)
      Me.Label20.TabIndex = 251
      Me.Label20.Text = "Cognome:"
      '
      'txtLuogoNascita
      '
      Me.txtLuogoNascita.AcceptsReturn = True
      Me.txtLuogoNascita.BackColor = System.Drawing.SystemColors.Window
      Me.txtLuogoNascita.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtLuogoNascita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtLuogoNascita.ForeColor = System.Drawing.Color.Black
      Me.txtLuogoNascita.Location = New System.Drawing.Point(125, 188)
      Me.txtLuogoNascita.MaxLength = 0
      Me.txtLuogoNascita.Name = "txtLuogoNascita"
      Me.txtLuogoNascita.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtLuogoNascita.Size = New System.Drawing.Size(160, 20)
      Me.txtLuogoNascita.TabIndex = 7
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label6.ForeColor = System.Drawing.Color.Black
      Me.Label6.Location = New System.Drawing.Point(21, 188)
      Me.Label6.Name = "Label6"
      Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label6.Size = New System.Drawing.Size(88, 13)
      Me.Label6.TabIndex = 246
      Me.Label6.Text = "Luogo di nascita:"
      '
      'TabPage5
      '
      Me.TabPage5.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.TabPage5.Controls.Add(Me.txtRilasciatoDaDoc)
      Me.TabPage5.Controls.Add(Me.cmbNazioneRilascioDoc)
      Me.TabPage5.Controls.Add(Me.Label35)
      Me.TabPage5.Controls.Add(Me.dtpDataRilascioDoc)
      Me.TabPage5.Controls.Add(Me.txtComuneRilascioDoc)
      Me.TabPage5.Controls.Add(Me.Label29)
      Me.TabPage5.Controls.Add(Me.txtNumeroDoc)
      Me.TabPage5.Controls.Add(Me.Label16)
      Me.TabPage5.Controls.Add(Me.Label17)
      Me.TabPage5.Controls.Add(Me.cmbTipoDoc)
      Me.TabPage5.Controls.Add(Me.Label9)
      Me.TabPage5.Controls.Add(Me.Label2)
      Me.TabPage5.Location = New System.Drawing.Point(4, 22)
      Me.TabPage5.Name = "TabPage5"
      Me.TabPage5.Size = New System.Drawing.Size(637, 438)
      Me.TabPage5.TabIndex = 4
      Me.TabPage5.Text = "Documento di riconoscimento"
      '
      'txtRilasciatoDaDoc
      '
      Me.txtRilasciatoDaDoc.AcceptsReturn = True
      Me.txtRilasciatoDaDoc.BackColor = System.Drawing.SystemColors.Window
      Me.txtRilasciatoDaDoc.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtRilasciatoDaDoc.ForeColor = System.Drawing.SystemColors.WindowText
      Me.txtRilasciatoDaDoc.Location = New System.Drawing.Point(389, 100)
      Me.txtRilasciatoDaDoc.MaxLength = 0
      Me.txtRilasciatoDaDoc.Name = "txtRilasciatoDaDoc"
      Me.txtRilasciatoDaDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtRilasciatoDaDoc.Size = New System.Drawing.Size(149, 20)
      Me.txtRilasciatoDaDoc.TabIndex = 5
      '
      'cmbNazioneRilascioDoc
      '
      Me.cmbNazioneRilascioDoc.Location = New System.Drawing.Point(389, 63)
      Me.cmbNazioneRilascioDoc.Name = "cmbNazioneRilascioDoc"
      Me.cmbNazioneRilascioDoc.Size = New System.Drawing.Size(149, 21)
      Me.cmbNazioneRilascioDoc.TabIndex = 3
      '
      'Label35
      '
      Me.Label35.AutoSize = True
      Me.Label35.BackColor = System.Drawing.Color.Transparent
      Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label35.ForeColor = System.Drawing.Color.Black
      Me.Label35.Location = New System.Drawing.Point(288, 65)
      Me.Label35.Name = "Label35"
      Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label35.Size = New System.Drawing.Size(95, 13)
      Me.Label35.TabIndex = 301
      Me.Label35.Text = "Nazione di rilascio:"
      '
      'dtpDataRilascioDoc
      '
      Me.dtpDataRilascioDoc.Checked = False
      Me.dtpDataRilascioDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpDataRilascioDoc.Location = New System.Drawing.Point(113, 100)
      Me.dtpDataRilascioDoc.Name = "dtpDataRilascioDoc"
      Me.dtpDataRilascioDoc.ShowCheckBox = True
      Me.dtpDataRilascioDoc.Size = New System.Drawing.Size(161, 20)
      Me.dtpDataRilascioDoc.TabIndex = 4
      Me.dtpDataRilascioDoc.Value = New Date(2005, 8, 17, 15, 37, 0, 654)
      '
      'txtComuneRilascioDoc
      '
      Me.txtComuneRilascioDoc.AcceptsReturn = True
      Me.txtComuneRilascioDoc.BackColor = System.Drawing.SystemColors.Window
      Me.txtComuneRilascioDoc.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtComuneRilascioDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtComuneRilascioDoc.ForeColor = System.Drawing.Color.Black
      Me.txtComuneRilascioDoc.Location = New System.Drawing.Point(113, 63)
      Me.txtComuneRilascioDoc.MaxLength = 0
      Me.txtComuneRilascioDoc.Name = "txtComuneRilascioDoc"
      Me.txtComuneRilascioDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtComuneRilascioDoc.Size = New System.Drawing.Size(161, 20)
      Me.txtComuneRilascioDoc.TabIndex = 2
      Me.txtComuneRilascioDoc.TabStop = False
      Me.txtComuneRilascioDoc.Visible = False
      '
      'Label29
      '
      Me.Label29.AutoSize = True
      Me.Label29.BackColor = System.Drawing.Color.Transparent
      Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label29.ForeColor = System.Drawing.Color.Black
      Me.Label29.Location = New System.Drawing.Point(12, 65)
      Me.Label29.Name = "Label29"
      Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label29.Size = New System.Drawing.Size(95, 13)
      Me.Label29.TabIndex = 284
      Me.Label29.Text = "Comune di rilascio:"
      Me.Label29.Visible = False
      '
      'txtNumeroDoc
      '
      Me.txtNumeroDoc.BackColor = System.Drawing.SystemColors.Window
      Me.txtNumeroDoc.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtNumeroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNumeroDoc.ForeColor = System.Drawing.Color.Black
      Me.txtNumeroDoc.Location = New System.Drawing.Point(389, 22)
      Me.txtNumeroDoc.MaxLength = 0
      Me.txtNumeroDoc.Name = "txtNumeroDoc"
      Me.txtNumeroDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtNumeroDoc.Size = New System.Drawing.Size(150, 20)
      Me.txtNumeroDoc.TabIndex = 1
      Me.txtNumeroDoc.TabStop = False
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.BackColor = System.Drawing.Color.Transparent
      Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label16.ForeColor = System.Drawing.Color.Black
      Me.Label16.Location = New System.Drawing.Point(12, 100)
      Me.Label16.Name = "Label16"
      Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label16.Size = New System.Drawing.Size(68, 13)
      Me.Label16.TabIndex = 274
      Me.Label16.Text = "Data rilascio:"
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label17.ForeColor = System.Drawing.Color.Black
      Me.Label17.Location = New System.Drawing.Point(288, 22)
      Me.Label17.Name = "Label17"
      Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label17.Size = New System.Drawing.Size(47, 13)
      Me.Label17.TabIndex = 273
      Me.Label17.Text = "Numero:"
      '
      'cmbTipoDoc
      '
      Me.cmbTipoDoc.Location = New System.Drawing.Point(113, 22)
      Me.cmbTipoDoc.Name = "cmbTipoDoc"
      Me.cmbTipoDoc.Size = New System.Drawing.Size(161, 21)
      Me.cmbTipoDoc.TabIndex = 0
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label9.ForeColor = System.Drawing.Color.Black
      Me.Label9.Location = New System.Drawing.Point(12, 22)
      Me.Label9.Name = "Label9"
      Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label9.Size = New System.Drawing.Size(87, 13)
      Me.Label9.TabIndex = 272
      Me.Label9.Text = "Tipo documento:"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
      Me.Label2.ForeColor = System.Drawing.Color.Black
      Me.Label2.Location = New System.Drawing.Point(288, 100)
      Me.Label2.Name = "Label2"
      Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.Label2.Size = New System.Drawing.Size(71, 13)
      Me.Label2.TabIndex = 271
      Me.Label2.Text = "Rilasciato da:"
      '
      'TabPage3
      '
      Me.TabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.TabPage3.Controls.Add(Me.cmdInserisciOccupanti)
      Me.TabPage3.Controls.Add(Me.cmdEliminaOccupanti)
      Me.TabPage3.Controls.Add(Me.lvwOccupanti)
      Me.TabPage3.Location = New System.Drawing.Point(4, 22)
      Me.TabPage3.Name = "TabPage3"
      Me.TabPage3.Size = New System.Drawing.Size(637, 438)
      Me.TabPage3.TabIndex = 7
      Me.TabPage3.Text = "Altri componenti"
      '
      'cmdInserisciOccupanti
      '
      Me.cmdInserisciOccupanti.Id = "5cb4629d-8026-4d6c-9815-611d4bacb7c7"
      Me.cmdInserisciOccupanti.Location = New System.Drawing.Point(346, 331)
      Me.cmdInserisciOccupanti.Name = "cmdInserisciOccupanti"
      Me.cmdInserisciOccupanti.Size = New System.Drawing.Size(104, 32)
      Me.cmdInserisciOccupanti.TabIndex = 1
      Me.cmdInserisciOccupanti.Text = "&Inserisci"
      '
      'cmdEliminaOccupanti
      '
      Me.cmdEliminaOccupanti.Id = "f4c880ee-0846-4e54-a486-3bc390ef19a6"
      Me.cmdEliminaOccupanti.Location = New System.Drawing.Point(458, 331)
      Me.cmdEliminaOccupanti.Name = "cmdEliminaOccupanti"
      Me.cmdEliminaOccupanti.Size = New System.Drawing.Size(104, 32)
      Me.cmdEliminaOccupanti.TabIndex = 2
      Me.cmdEliminaOccupanti.Text = "&Elimina"
      '
      'lvwOccupanti
      '
      Me.lvwOccupanti.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader14, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader13, Me.ColumnHeader12})
      Me.lvwOccupanti.Dock = System.Windows.Forms.DockStyle.Top
      Me.lvwOccupanti.FullRowSelect = True
      Me.lvwOccupanti.Location = New System.Drawing.Point(0, 0)
      Me.lvwOccupanti.MultiSelect = False
      Me.lvwOccupanti.Name = "lvwOccupanti"
      Me.lvwOccupanti.Size = New System.Drawing.Size(637, 327)
      Me.lvwOccupanti.TabIndex = 0
      Me.lvwOccupanti.UseCompatibleStateImageBehavior = False
      Me.lvwOccupanti.View = System.Windows.Forms.View.Details
      '
      'ColumnHeader14
      '
      Me.ColumnHeader14.Text = "Indice"
      Me.ColumnHeader14.Width = 0
      '
      'ColumnHeader7
      '
      Me.ColumnHeader7.Text = "Cognome"
      Me.ColumnHeader7.Width = 100
      '
      'ColumnHeader8
      '
      Me.ColumnHeader8.Text = "Nome"
      Me.ColumnHeader8.Width = 100
      '
      'ColumnHeader1
      '
      Me.ColumnHeader1.Text = "Sesso"
      Me.ColumnHeader1.Width = 50
      '
      'ColumnHeader9
      '
      Me.ColumnHeader9.Text = "Data di Nascita"
      Me.ColumnHeader9.Width = 90
      '
      'ColumnHeader10
      '
      Me.ColumnHeader10.Text = "Luogo di Nascita"
      Me.ColumnHeader10.Width = 120
      '
      'ColumnHeader13
      '
      Me.ColumnHeader13.Text = "Nazionalità"
      Me.ColumnHeader13.Width = 75
      '
      'ColumnHeader12
      '
      Me.ColumnHeader12.Text = "Codice"
      Me.ColumnHeader12.Width = 0
      '
      'ErrorProvider1
      '
      Me.ErrorProvider1.ContainerControl = Me
      '
      'formFrameSkinner
      '
      Me.formFrameSkinner.AllowGlass = False
      Me.formFrameSkinner.Form = Me
      '
      'frmSchedinaPS
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.ClientSize = New System.Drawing.Size(645, 510)
      Me.Controls.Add(Me.TabControl1)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.ToolBar1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "frmSchedinaPS"
      Me.ShowInTaskbar = False
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Schedina P.S."
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.TabPage4.ResumeLayout(False)
      Me.TabPage4.PerformLayout()
      Me.TabPage5.ResumeLayout(False)
      Me.TabPage5.PerformLayout()
      Me.TabPage3.ResumeLayout(False)
      CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

#End Region

   ' DA_FARE: Modificare!
   Public CSchedina As New SchedinaPS
   Public CSchedinaComponenti As New PrenCamereOccupanti

   Const NOME_TABELLA As String = "SchedinePS"
   Const TAB_CLIENTI As String = "Clienti"
   Const TAB_CAMERE As String = "Camere"
   Const TAB_NAZIONI As String = "Nazioni"
   Const TAB_DOC_IDENTITA As String = "DocIdentità"

   ' DA_FARE: Modificare!
   Const TAB_PREN_OCCUPANTI As String = "PrenCamereOccupanti"

   Private CFormatta As New ClsFormatta
   Private CConvalida As New ConvalidaKeyPress
   Private DatiConfig As AppConfig

   ' DA_FARE: Verificare!
   ' Servono a sapere se il periodo di prenotazione è stato modificato.
   Dim numCameraPren As String
   Dim dataArrivoPren As Date
   Dim dataPartenzaPren As Date

   ' Dichiara un oggetto connessione.
   Dim cn As New OleDbConnection(ConnString)
   ' Dichiara un oggetto transazione.
   Dim tr As OleDbTransaction
   Dim cmd As New OleDbCommand(sql, cn)
   Dim ds As New DataSet
   ' Numero di record.
   Dim numRecord As Integer
   Dim sql As String

   Private Function SalvaDati() As Boolean

      '' Salva eventuali nuovi valori nelle rispettive tabelle dati.
      'AggiornaTabella(cmbPagamento, TAB_PAGAMENTO)

      'Try
      '   With IPren
      '      ' Assegna i dati dei campi della classe alle caselle di testo.
      '      .IdCliente = Convert.ToInt32(cmbIdCliente.Text)
      '      .Numero = Convert.ToInt32(txtNumero.Text)
      '      .Data = dtpData.Text
      '      .Tipologia = cmbTipologia.Text
      '      .Stato = cmbStatoPren.Text
      '      .Cognome = FormattaApici(cmbCognome.Text)
      '      .Nome = FormattaApici(txtNome.Text)
      '      .Adulti = nudAdulti.Value
      '      .Neonati = nudNeonati.Value
      '      .Bambini = nudBambini.Value
      '      .Ragazzi = nudRagazzi.Value
      '      .NumeroCamera = FormattaApici(cmbNumeroCamera.Text)
      '      .DescrizioneCamera = txtDescrizioneCamera.Text
      '      .Trattamento = cmbTrattamento.Text
      '      .DataArrivo = FormattaData(mcDataArrivo.SelectionRange.Start.Date, True)
      '      .DataPartenza = FormattaData(mcDataPartenza.SelectionRange.Start.Date, True)
      '      .OraArrivo = dtpOraArrivo.Text
      '      .NumeroNotti = Convert.ToInt32(txtNumeroNotti.Text)
      '      .Listino = cmbListino.Text
      '      .Pagamento = FormattaApici(cmbPagamento.Text)

      '      If IsNumeric(txtPrezzoCamera.Text) = True Then
      '         .CostoCamera = CFormatta.FormattaEuro(Convert.ToDouble(txtPrezzoCamera.Text))
      '      Else
      '         .CostoCamera = VALORE_ZERO
      '      End If
      '      If IsNumeric(txtTassaSoggiorno.Text) = True Then
      '         .TassaSoggiorno = CFormatta.FormattaEuro(Convert.ToDouble(txtTassaSoggiorno.Text))
      '      Else
      '         .TassaSoggiorno = VALORE_ZERO
      '      End If
      '      If IsNumeric(txtAccontoCamera.Text) = True Then
      '         .AccontoCamera = CFormatta.FormattaEuro(Convert.ToDouble(txtAccontoCamera.Text))
      '      Else
      '         .AccontoCamera = VALORE_ZERO
      '      End If
      '      If IsNumeric(txtTotaleConto.Text) = True Then
      '         .TotaleConto = CFormatta.FormattaEuro(Convert.ToDouble(txtTotaleConto.Text))
      '      Else
      '         .TotaleConto = VALORE_ZERO
      '      End If

      '      If IsNumeric(txtSconto.Text) = True Then
      '         .Sconto = CFormatta.FormattaEuro(Convert.ToDouble(txtSconto.Text))
      '      Else
      '         .Sconto = VALORE_ZERO
      '      End If
      '      If IsNumeric(txtServizio.Text) = True Then
      '         .Servizio = CFormatta.FormattaEuro(Convert.ToDouble(txtServizio.Text))
      '      Else
      '         .Servizio = VALORE_ZERO
      '      End If

      '      ' Utilizzare per sconto camera o totale conto.
      '      '.ApplicaSconto = cmbApplicaSconto.SelectedIndex.ToString

      '      .ApplicaSconto = txtTotaleImporto.Text

      '      If ckbSchedina.Checked = True Then
      '         .Schedina = "Inserita"
      '      Else
      '         .Schedina = String.Empty
      '      End If

      '      .Note = FormattaApici(txtNote.Text)

      '      If .Colore = 0 Then
      '         .Colore = Convert.ToInt32(Color.White.ToArgb)
      '      End If

      '      '  Se la proprietà 'Tag' contiene un valore viene richiamata la procedura
      '      ' di modifica dati, altrimenti viene richiamata la procedura di inserimento dati.
      '      If Me.Tag <> "" Then
      '         Return .ModificaDati(NOME_TABELLA, Me.Tag)
      '      Else
      '         Return .InserisciDati(NOME_TABELLA)
      '      End If

      '   End With

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Function

   ' DA_FARE: Verificare!
   Private Function SalvaOccupanti(ByVal id As String) As Boolean
      ' Salva i dati per il Tavolo selezionato.
      Try
         Dim idPren As Integer

         If id <> String.Empty Then
            idPren = id
         Else
            idPren = LeggiUltimaPren(NOME_TABELLA)
         End If

         With CSchedinaComponenti
            .EliminaDati(TAB_PREN_OCCUPANTI, idPren)

            Dim i As Integer
            For i = 0 To lvwOccupanti.Items.Count - 1
               .RifPren = idPren
               .Cognome = lvwOccupanti.Items(i).SubItems(1).Text
               .Nome = lvwOccupanti.Items(i).SubItems(2).Text
               .DataNascita = lvwOccupanti.Items(i).SubItems(3).Text
               .LuogoNascita = lvwOccupanti.Items(i).SubItems(4).Text
               .ProvNascita = lvwOccupanti.Items(i).SubItems(5).Text
               .Nazionalità = lvwOccupanti.Items(i).SubItems(6).Text
               .CodiceCliente = lvwOccupanti.Items(i).SubItems(7).Text

               .InserisciDati(TAB_PREN_OCCUPANTI)
            Next
         End With

         Return True

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False
      End Try
   End Function

   Private Function SalvaAddebitiExtra(ByVal id As String) As Boolean
      '' Salva i dati per gli addebiti extra.
      'Try
      '   Dim idPren As Integer

      '   If id <> String.Empty Then
      '      idPren = id
      '   Else
      '      idPren = LeggiUltimaPren(NOME_TABELLA)
      '   End If

      '   With IPrenAddebiti
      '      .EliminaDati(TAB_PREN_ADDEBITI, idPren)

      '      Dim i As Integer
      '      For i = 0 To lvwAddebiti.Items.Count - 1
      '         .RifPren = idPren
      '         .Data = lvwAddebiti.Items(i).Text
      '         .Descrizione = lvwAddebiti.Items(i).SubItems(1).Text
      '         .Quantità = lvwAddebiti.Items(i).SubItems(2).Text
      '         .Importo = lvwAddebiti.Items(i).SubItems(3).Text
      '         .Codice = lvwAddebiti.Items(i).SubItems(4).Text
      '         .AliquotaIva = lvwAddebiti.Items(i).SubItems(6).Text
      '         .Categoria = lvwAddebiti.Items(i).SubItems(7).Text
      '         .Colore = lvwAddebiti.Items(i).ForeColor.ToArgb
      '         .Gruppo = lvwAddebiti.Items(i).Group.ToString
      '         .InserisciDati(TAB_PREN_ADDEBITI)
      '      Next

      '   End With

      '   Return True

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      '   Return False
      'End Try
   End Function

   Private Function SalvaStoricoPresenze(ByVal id As String, ByVal valMese As Integer, ByVal valAnno As Integer, ByVal valNumNotti As Integer) As Boolean
      'Try
      '   With IPrenStorico
      '      ' Assegna i dati dei campi della classe alle caselle di testo.
      '      .RifPren = id
      '      .Numero = Convert.ToInt32(txtNumero.Text)
      '      .Mese = valMese
      '      .Anno = valAnno
      '      .Adulti = nudAdulti.Value
      '      .Neonati = nudNeonati.Value
      '      .Bambini = nudBambini.Value
      '      .Ragazzi = nudRagazzi.Value
      '      .NumeroNotti = valNumNotti

      '      .InserisciDati(TAB_PREN_STORICO)
      '   End With

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Function

   Private Sub SalvaStoricoPresenzeMeseAnno()
      'Try
      '   Dim valNumNotti As Integer = Convert.ToInt32(txtNumeroNotti.Text)
      '   Dim valDataArrivo As Date = FormattaData(mcDataArrivo.SelectionRange.Start.Date, True)
      '   Dim valMese As Integer = valDataArrivo.Month
      '   Dim valAnno As Integer = valDataArrivo.Year
      '   Dim NumNottiTemp As Integer
      '   Dim salvato As Boolean

      '   ' In caso di nuova prenotazione dove l'Id non è ancora disponibile.
      '   Dim idPren As Integer
      '   If Me.Tag <> String.Empty Then
      '      idPren = Me.Tag
      '   Else
      '      idPren = LeggiUltimaPren(NOME_TABELLA)
      '   End If

      '   ' Elimina eventuali dati esistenti.
      '   IPrenStorico.EliminaDati(TAB_PREN_STORICO, idPren)

      '   Dim i As Integer
      '   For i = 1 To valNumNotti
      '      If valDataArrivo.Month <> valMese Then
      '         ' Salva lo storico delle presenze.
      '         SalvaStoricoPresenze(idPren, valMese, valAnno, NumNottiTemp)

      '         ' Salvo in nuovo mese e l'eventuale nuovo anno.
      '         valMese = valDataArrivo.Month
      '         valAnno = valDataArrivo.Year

      '         NumNottiTemp = 0
      '      End If

      '      ' Incrementa di un giorno.
      '      valDataArrivo = valDataArrivo.AddDays(1)

      '      ' Conta le notti.
      '      NumNottiTemp += 1
      '   Next

      '   ' Salva lo storico delle presenze.
      '   SalvaStoricoPresenze(idPren, valMese, valAnno, NumNottiTemp)

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Sub

   Private Function SalvaSchedinaPS() As Boolean
      Dim CSchedina As New SchedinaPS
      Dim CClienti As New Anagrafiche.Cliente(ConnStringAnagrafiche)

      ' Legge i dati del cliente.
      CClienti.LeggiDati("Clienti", CSchedina.IdCliente)

      Try
         With CSchedina
            ' Assegna i dati dei campi della classe alle caselle di testo.
            .Numero = 0
            .IdCliente = CClienti.Codice
            .TipologiaCliente = cmbTipologia.Text
            .Cognome = CClienti.Cognome
            .Nome = CClienti.Nome
            .Sesso = CClienti.Sesso
            .DataNascita = CClienti.DataNascita
            .LuogoNascita = CClienti.LuogoNascita
            .ProvNascita = CClienti.ProvNascita
            .NazioneNascita = CClienti.NazioneNascita
            .Cittadinanza = CClienti.Nazionalità
            .TipoDoc = CClienti.TipoDoc
            .NumeroDoc = CClienti.NumeroDocIdentità
            .RilasciatoDoc = CClienti.RilasciatoDa
            .ComuneRilascioDoc = CClienti.CittàRilascioDoc
            .DataRilascioDoc = CClienti.DataRilascioDoc
            .DataScadenzaDoc = String.Empty ' DA_FARE_B: Sviluppare! Campo mancante nella tabelle Clienti.
            .NazioneRilascioDoc = CClienti.NazioneRilascioDoc
            .DataArrivo = FormattaData(mcDataArrivo.SelectionRange.Start.Date, True)
            .DataPartenza = FormattaData(mcDataPartenza.SelectionRange.Start.Date, True)
            .Permanenza = txtNumeroNotti.Text
            .NumCamera = cmbNumeroCamera.Text
            .IdPren = 0
            .NumPren = txtNumero.Text
            .Stato = "Inserita"
            .DataStampa = String.Empty

            ' Inserisce i dati nel database.
            'Return .InserisciDati(TAB_SCHEDINE_PS)

         End With

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      End Try
   End Function

   Public Sub EliminaScedinePS(ByVal numPren As String)
      Try
         Dim sql As String

         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("DELETE FROM SchedinePS WHERE NumPren = '{0}'", numPren)

         ' Crea il comando per la connessione corrente.
         Dim cmdDelete As New OleDbCommand(sql, cn, tr)

         ' Esegue il comando.
         Dim Record As Integer = cmdDelete.ExecuteNonQuery()

         ' Conferma la transazione.
         tr.Commit()

         ' DA_FARE_B: Modificare!
         ' Registra loperazione effettuata dall'operatore identificato.
         'g_frmMain.RegistraOperazione(TipoOperazione.Elimina, Descrizione, MODULO_GESTIONE_PLANNING_RISORSE)

      Catch ex As Exception
         ' Annulla la transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

         If IsNothing(g_frmSchedinePS) = False Then
            ' Aggiorna la griglia dati.
            g_frmSchedinePS.AggiornaDati()

            ' Se nella tabella non ci sono record disattiva i pulsanti.
            g_frmSchedinePS.ConvalidaDati()
         End If

      End Try
   End Sub

   Private Sub LeggiComponenti()
      Try
         With CSchedinaComponenti
            .LeggiDati(lvwOccupanti, TAB_PREN_OCCUPANTI, Me.Tag)
         End With

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub LeggiAddebitiExtra()
      'Try
      '   With IPrenAddebiti
      '      .LeggiDati(lvwAddebiti, TAB_PREN_ADDEBITI, Me.Tag)
      '   End With

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Sub

   Private Function LeggiTotaleTassaSoggiorno(ByVal numAdulti As Integer, ByVal numNeonati As Integer, ByVal numBambini As Integer, ByVal numRagazzi As Integer) As Decimal
      Try
         DatiConfig = New AppConfig
         DatiConfig.ConfigType = ConfigFileType.AppConfig

         ' Legge il prezzo della Tassa di soggiorno.
         Dim tassaSoggiorno As Double
         If IsNumeric(DatiConfig.GetValue("TassaSoggiornoHotel")) = True Then
            tassaSoggiorno = Convert.ToDouble(DatiConfig.GetValue("TassaSoggiornoHotel"))
         Else
            tassaSoggiorno = 0
         End If

         ' Aggiunge gli Adulti al numero di persone che pagheranno la tassa.
         Dim numPersone As Integer = numAdulti

         ' Verifica se i Neonati pagheranno la tassa.
         Dim applicaTassaNeonati As Boolean
         If DatiConfig.GetValue("ApplicaTassaNeonati") <> String.Empty Then
            applicaTassaNeonati = DatiConfig.GetValue("ApplicaTassaNeonati")
         Else
            applicaTassaNeonati = False
         End If

         ' Aggiunge i Neonati al numero di persone che pagheranno la tassa.
         If applicaTassaNeonati = True Then
            numPersone = numPersone + numNeonati
         End If

         ' Verifica se i Bambini pagheranno la tassa.
         Dim applicaTassaBambini As Boolean
         If DatiConfig.GetValue("ApplicaTassaBambini") <> String.Empty Then
            applicaTassaBambini = DatiConfig.GetValue("ApplicaTassaBambini")
         Else
            applicaTassaBambini = False
         End If

         ' Aggiunge i Bambini al numero di persone che pagheranno la tassa.
         If applicaTassaBambini = True Then
            numPersone = numPersone + numBambini
         End If

         ' Verifica se i Ragazzi pagheranno la tassa.
         Dim applicaTassaRagazzi As Boolean
         If DatiConfig.GetValue("ApplicaTassaRagazzi") <> String.Empty Then
            applicaTassaRagazzi = DatiConfig.GetValue("ApplicaTassaRagazzi")
         Else
            applicaTassaRagazzi = False
         End If

         ' Aggiunge i Ragazzi al numero di persone che pagheranno la tassa.
         If applicaTassaRagazzi = True Then
            numPersone = numPersone + numRagazzi
         End If

         Return (tassaSoggiorno * numPersone).ToString

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      End Try
   End Function

   Private Sub LeggiServizio()
      'Try
      '   DatiConfig = New AppConfig
      '   DatiConfig.ConfigType = ConfigFileType.AppConfig

      '   ' Percentuale per il Servizio.
      '   txtServizio.Text = DatiConfig.GetValue("ServizioHotel")
      '   If txtServizio.Text.Length = 0 Then
      '      txtServizio.Text = VALORE_ZERO
      '   End If

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Sub

   Public Function LeggiScontoCliente(ByVal tabella As String, ByVal id As Integer) As String
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT * FROM " & tabella & " WHERE Id = " & id & " ORDER BY Id ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read
            Return dr.Item("Sconto")
         Loop

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         cn.Close()

      End Try
   End Function

   Private Function LeggiUltimaPren(ByVal tabella As String) As Integer
      Dim closeOnExit As Boolean
      Dim id As Integer

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Verifica l'esistenza del record.
         cmd.CommandText = String.Format("SELECT MAX(Id) FROM {0}", tabella)

         id = CInt(cmd.ExecuteScalar())

         Return id

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   ' DA_FARE_A: Verificare il funzionamento della procedura 'VerificaDisponibilitàCamera'.
   Private Function VerificaDisponibilitàCamera1(ByVal numeroCamera As String, ByVal dataDal As Date, ByVal dataAl As Date) As Integer
      Dim closeOnExit As Boolean
      Dim numRec As Integer

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Ottiene il numero di record.
         cmd.CommandText = String.Format("SELECT COUNT(*) FROM {0} " &
                                         "WHERE NumeroCamera = '{1}' " &
                                         "AND (DataArrivo BETWEEN #{2}# AND #{3}#)",
                                         NOME_TABELLA, numeroCamera, CFormatta.FormattaData_IT(dataDal), CFormatta.FormattaData_IT(dataAl.AddDays(-1)))

         numRec = CInt(cmd.ExecuteScalar())

         ' Se un operazione di modifica sottrae la prenotazione in fase di modifica.
         Dim numRecDataArrivo As Integer
         If Me.Tag <> String.Empty Then
            numRecDataArrivo = numRec - 1
         Else
            numRecDataArrivo = numRec
         End If

         numRec = 0

         ' Chiude la connessione.
         cn.Close()

         If numRecDataArrivo = 0 Then
            cn.Open()

            cmd.CommandText = String.Format("SELECT COUNT(*) FROM {0} " &
                                         "WHERE NumeroCamera = '{1}' " &
                                         "AND (DataPartenza BETWEEN #{2}# AND #{3}#)",
                                         NOME_TABELLA, numeroCamera, CFormatta.FormattaData_IT(dataDal.AddDays(1)), CFormatta.FormattaData_IT(dataAl))

            numRec = CInt(cmd.ExecuteScalar())

            ' Se un operazione di modifica sottrae la prenotazione in fase di modifica.
            If Me.Tag <> String.Empty Then
               Return numRec - 1
            Else
               Return numRec
            End If
         Else
            Return numRecDataArrivo
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   Private Function VerificaDisponibilitàCamera(ByVal numeroCamera As String, ByVal dataDal As Date, ByVal dataAl As Date) As Boolean
      Try
         ' In caso di prenotazione esistente se il periodo e la camera non sono cambiati non verifica la disponibilità della camera. 
         If numCameraPren = numeroCamera And dataArrivoPren = dataDal And dataPartenzaPren = dataAl Then
            Return False
         End If

         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
         End If

         '  Leggo tutte le prenotazioni della camera.
         Dim cmd As New OleDbCommand("SELECT * FROM " & NOME_TABELLA & " WHERE NumeroCamera = '" & numeroCamera & "' ORDER BY DataArrivo ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read()
            ' Data arrivo.
            Dim valDataArrivo As Date
            If IsDate(dr.Item("DataArrivo")) = True Then
               valDataArrivo = Convert.ToDateTime(dr.Item("DataArrivo"))
            Else
               Return False
            End If

            ' Data partenza.
            Dim valDataPartenza As Date
            If IsDate(dr.Item("DataPartenza")) = True Then
               valDataPartenza = Convert.ToDateTime(dr.Item("DataPartenza"))
            Else
               Return False
            End If

            ' Numero notti.
            Dim valNumNotti As Integer
            If IsDBNull(dr.Item("NumeroNotti")) = False Then
               valNumNotti = Convert.ToInt32(dr.Item("NumeroNotti"))
            Else
               Return False
            End If

            Dim dataDalTemp As Date = dataDal

            Do
               ' Viene incrementato di uno perchè il primo giorno dell'intervallo può incrociarsi con l'ultimo giorno di eventuali prenotazioni.
               dataDalTemp = dataDalTemp.AddDays(1)

               Dim valDatatemp As Date = valDataArrivo
               Dim i As Integer
               For i = 0 To valNumNotti
                  If valDatatemp = dataDalTemp Then
                     If dataDalTemp <> valDataArrivo Then
                        ' Prenotazione esistente!
                        Return True
                     End If
                  Else
                     ' Incrementa di un giorno.
                     valDatatemp = valDatatemp.AddDays(1)
                  End If
               Next

               ' Non tiene conto dell'ultimo giorno dell'intervallo perchè può incrociarsi con il primo giorno di eventuali prenotazioni.
            Loop Until dataDalTemp = dataAl

         Loop

         Return False

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   Public Function ApriClienti(ByVal val As String) As Boolean
      Try
         ' Modifica il cursore del mouse.
         Cursor.Current = Cursors.AppStarting

         ' Per la versione demo.
         ' Se è un nuovo inserimento verifica il numero dei record.
         If val = String.Empty Then
            If g_VerDemo = True Then
               ' Test per la versione demo.
               If VerificaNumRecord(LeggiNumRecord(TAB_CLIENTI, cn, cmd)) = True Then
                  Exit Function
               End If
            End If
         End If

         Dim frm As New frmClienti
         frm.Tag = val

         If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return True
         Else
            Return False
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return False
      End Try
   End Function

   Private Function ImpostaDatiAllegati(ByVal note As String, ByVal ins As Boolean) As Boolean
      'Try
      '   OpenFileDialog1.Filter = "Tutti i file |*.*"

      '   OpenFileDialog1.FilterIndex = 1

      '   IAllegati.IdCliente = CInt(IPren.Codice)

      '   If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
      '      ' Assegna i dati dei campi della classe alle caselle di testo.
      '      IAllegati.Documento = Path.GetFileName(OpenFileDialog1.FileName)
      '      IAllegati.Data = CStr(Today)
      '      IAllegati.Ora = CStr(TimeOfDay)
      '      IAllegati.Percorso = OpenFileDialog1.FileName
      '      IAllegati.Estensione = Path.GetExtension(OpenFileDialog1.FileName)
      '   Else
      '      If ins = True Then
      '         Return False
      '      End If
      '   End If

      '   Dim val As String
      '   val = InputBox("Digitare il testo per il campo Note.", "Note", note)
      '   If val <> "" Then
      '      IAllegati.Note = val
      '   Else
      '      IAllegati.Note = note
      '   End If

      '   Return True

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Function

   Public Sub RimuoviAllegati(ByVal tabella As String, ByVal id As Integer)
      'Try
      '   Dim Risposta As Short
      '   Dim sql As String

      '   ' Dim Documento As String = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(0).Text

      '   ' Chiede conferma per l'eliminazione.
      '   Risposta = MsgBox("Si desidera rimuovere il documento """ & Documento & """?" & vbCrLf & vbCrLf &
      '                     "Non sarà più possibile recuperare i dati.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Conferma rimozione")

      '   If Risposta = MsgBoxResult.Yes Then
      '      ' Apre la connessione.
      '      cn.Open()

      '      ' Avvia una transazione.
      '      tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

      '      ' Crea la stringa di eliminazione.
      '      sql = String.Format("DELETE FROM {0} WHERE Id = {1}", tabella, id)

      '      ' Crea il comando per la connessione corrente.
      '      Dim cmdDelete As New OleDbCommand(sql, cn, tr)

      '      ' Esegue il comando.
      '      Dim Record As Integer = cmdDelete.ExecuteNonQuery()

      '      ' Conferma la transazione.
      '      tr.Commit()

      '   End If

      'Catch ex As Exception
      '   ' Annulla la transazione.
      '   tr.Rollback()

      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'Finally
      '   ' Chiude la connessione.
      '   cn.Close()
      'End Try
   End Sub

   Private Sub ConvalidaAllegati()
      ' Carica la lista dei componenti aggiuntivi.
      'If IAllegati.LeggiDati(lvwAllegati, TAB_ALLEGATI, IPren.Codice) = True Then
      '   eui_cmdModifica.Enabled = True
      '   eui_cmdElimina.Enabled = True
      'Else
      '   eui_cmdModifica.Enabled = False
      '   eui_cmdElimina.Enabled = False
      'End If
   End Sub

   Private Sub CaricaDatiCliente()
      Try
         ' Legge il nome relativo alla lista Cognome.
         cmbIdCliente.SelectedIndex = cmbCognome.SelectedIndex

         Dim AClienti As New Anagrafiche.Cliente(ConnString)

         With AClienti
            .LeggiDati(TAB_CLIENTI, cmbIdCliente.Text)

            ' DATI ANAGRAFICI.
            txtNome.Text = .Nome
            cmbSesso.Text = .Sesso

            If IsDate(.DataNascita) Then
               dtpDataNascita.Value = Convert.ToDateTime(.DataNascita)
            Else
               dtpDataNascita.Value = Today
               dtpDataNascita.Checked = False
            End If

            txtLuogoNascita.Text = .LuogoNascita
            txtProvNascita.Text = .ProvNascita
            cmbNazioneNascita.Text = .NazioneNascita
            cmbCittadinanza.Text = .Nazionalità

            ' DOCUMENTO DI RICONOSCIMENTO.
            cmbTipoDoc.Text = .TipoDoc
            txtNumeroDoc.Text = .NumeroDocIdentità
            txtComuneRilascioDoc.Text = .CittàRilascioDoc
            cmbNazioneRilascioDoc.Text = .NazioneRilascioDoc
            txtRilasciatoDaDoc.Text = .RilasciatoDa

            If .DataRilascioDoc <> String.Empty Then
               dtpDataRilascioDoc.Value = Convert.ToDateTime(.DataRilascioDoc)
            Else
               dtpDataRilascioDoc.Value = Today
               dtpDataRilascioDoc.Checked = False
            End If
         End With

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
      Select Case e.Button.Tag
         Case "Salva"
            ' Verifica la presenza di un nome Intestatario.
            If cmbCognome.Text = String.Empty Then
               MessageBox.Show("Inserire un nominativo per l'intestatario della prenotazione.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
               cmbCognome.Focus()
               Exit Sub
            End If

            If VerificaDisponibilitàCamera(cmbNumeroCamera.Text, mcDataArrivo.SelectionRange.Start.Date, mcDataPartenza.SelectionRange.Start.Date) = True Then
               MessageBox.Show("La camera che si vuole prenotare non è disponibile per il periodo selezionato!", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
               ' Esegue i calcoli per il totale degli importi.
               CalcolaTotaleConto()

               ' Salva i dati nel database.
               If SalvaDati() = True Then

                  ' Salva eventuali clienti occupanti.
                  SalvaOccupanti(Me.Tag)

                  ' Salva eventuali addebiti extra.
                  SalvaAddebitiExtra(Me.Tag)

                  ' Salva lo storico delle presenze.
                  SalvaStoricoPresenzeMeseAnno()

                  'Salva i dati per la schedina PS.
                  'If ckbSchedina.Checked = True Then
                  '   If SalvaSchedinaPS() = True Then
                  '      If IsNothing(g_frmSchedinePS) = False Then
                  '         ' Aggiorna la griglia dati.
                  '         g_frmSchedinePS.AggiornaDati()
                  '      End If
                  '   End If
                  'Else
                  '   ' Elimina tutte le schedine della prenotazione.
                  '   EliminaScedinePS(txtNumero.Text)
                  'End If

                  ' Aggiorna la griglia dati.
                  g_frmSchedinePS.AggiornaDati()

                  ' Chiude la finestra.
                  Me.Close()
               End If
            End If

         Case "Annulla"

            ' Chiude la finestra.
            Me.Close()

      End Select
   End Sub

   Private Sub frmSchedinaPS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Try
         ' Imposta l'icona della finestra in base al prodotto installato.
         ImpostaIcona(Me)

         ' Carica le liste.
         CaricaListaClienti(cmbCognome, cmbNome, cmbIdCliente, TAB_CLIENTI)
         CaricaListaCamere(cmbNumeroCamera, TAB_CAMERE)
         CaricaLista(cmbNazioneNascita, TAB_NAZIONI)
         CaricaLista(cmbCittadinanza, TAB_NAZIONI)
         CaricaLista(cmbNazioneRilascioDoc, TAB_NAZIONI)
         CaricaLista(cmbTipoDoc, TAB_DOC_IDENTITA)

         If Me.Tag <> String.Empty Then
            With CSchedina
               ' Comando Modifica.

               ' Visualizza i dati nei rispettivi campi.
               .LeggiDati(NOME_TABELLA, Me.Tag)

               ' Assegna i dati dei campi della classe alle caselle di testo.
               txtCodice.Text = .Codice
               txtNumero.Text = .Numero
               cmbCognome.Text = .Cognome
               txtNome.Text = .Nome
               cmbSesso.Text = .Sesso

               If .DataNascita <> String.Empty Then
                  dtpDataNascita.Value = Convert.ToDateTime(.DataNascita)
               End If

               txtLuogoNascita.Text = .LuogoNascita
               txtProvNascita.Text = .ProvNascita
               cmbNazioneNascita.Text = .NazioneNascita
               cmbCittadinanza.Text = .Cittadinanza
               cmbTipoDoc.Text = .TipoDoc
               txtNumeroDoc.Text = .NumeroDoc
               txtRilasciatoDaDoc.Text = .RilasciatoDoc
               txtComuneRilascioDoc.Text = .ComuneRilascioDoc

               If .DataRilascioDoc <> String.Empty Then
                  dtpDataRilascioDoc.Value = Convert.ToDateTime(.DataRilascioDoc)
               End If

               cmbNazioneRilascioDoc.Text = .NazioneRilascioDoc
               mcDataArrivo.SetDate(Convert.ToDateTime(.DataArrivo))
               mcDataPartenza.SetDate(Convert.ToDateTime(.DataPartenza))
               txtNumeroNotti.Text = .Permanenza.ToString
               cmbNumeroCamera.Text = .NumCamera
               txtNumeroPren.Text = .NumPren
               cmbStato.Text = .Stato

               If .DataStampa <> String.Empty Then
                  dtpDataStampa.Value = Convert.ToDateTime(.DataStampa)
               End If

               ' Aggiorna la nuova data di arrivo.
               lblArrivo.Text = "Arrivo: " & Convert.ToDateTime(.DataArrivo).ToLongDateString

               ' Aggiorna la nuova data di partenza.
               lblPartenza.Text = "Partenza: " & Convert.ToDateTime(.DataPartenza).ToLongDateString

               ' Carica eventuali clienti occupanti.
               LeggiComponenti()

            End With
         Else
            ' Comando Nuovo.

            ' DA_FARE: Modificare! generare il numero progressivo.
            ' Genera il numero progressivo.
            txtNumero.Text = "0"

            ' Seleziona il valore Inserita.
            cmbStato.SelectedIndex = 0

            ' Seleziona il valore Nessuna.
            cmbNumeroCamera.SelectedIndex = 0

            ' Data e ora di arrivo
            mcDataArrivo.SetDate(Today)
            mcDataPartenza.MinDate = Today.AddDays(1)
            mcDataPartenza.SetDate(Today.AddDays(1))

            ' Aggiorna la nuova data di arrivo.
            lblArrivo.Text = "Arrivo: " & Today.ToLongDateString

            ' Aggiorna la nuova data di partenza.
            lblPartenza.Text = "Partenza: " & Today.AddDays(1).ToLongDateString

            ' Aggiorna il numero delle notti.
            txtNumeroNotti.Text = CalcolaNumGiorni(Today, mcDataPartenza.SelectionRange.Start.Date).ToString

         End If

         ' Genera l'intestazione con i dati del form.
         If txtNumero.Text <> String.Empty Then
            lblIntestazione.Text = VisIntestazione("Schedina N. " & txtNumero.Text, cmbCognome.Text, txtNome.Text)
         Else
            lblIntestazione.Text = VisIntestazione(txtNumero.Text, cmbCognome.Text, txtNome.Text)
         End If

         ' Imposta lo stato attivo.
         txtNumero.Focus()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally

         ' Modifica il cursore del mouse.
         Cursor.Current = Cursors.Default

      End Try
   End Sub

   ' DA_FARE_A: HOTEL - da modificare!
   Private Sub frmSchedinaPS_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      If Me.Tag <> "0" Then
         ' Registra loperazione effettuata dall'operatore identificato.
         'g_frmMain.RegistraOperazione(TipoOperazione.Annulla, String.Empty, MODULO_GESTIONE_PREN_RISORSE)
      End If
   End Sub

   Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
      ' Imposta lo stato attivo.
      Select Case TabControl1.SelectedIndex()
         Case 0
            ' Dati principali.
            txtNumero.Focus()

         Case 1
            ' Occupanti.
            lvwOccupanti.Focus()

         Case 2
            ' Addebiti extra.
            'lvwAddebiti.Focus()

         Case 3
            ' Contabile.
            cmbTipoDoc.Focus()

            ' Inserisce il prezzo della camera in base al Listino elezionato.
            ApplicaListino()

         Case 4
            ' Allegati.
            'lvwAllegati.Focus()

         Case 5
            ' Note.
            'txtNote.Focus()

      End Select
   End Sub

   Private Sub cmdNuovoIntestatario_Click(sender As Object, e As EventArgs) Handles cmdNuovoIntestatario.Click
      Try
         ' Se è stato inserito un nuovo cliente...
         If ApriClienti(String.Empty) = True Then
            CaricaListaClienti(cmbCognome, cmbIdCliente, TAB_CLIENTI)

            ' DATI ANAGRAFICI.
            cmbIdCliente.Text = String.Empty
            cmbCognome.Text = String.Empty
            txtNome.Text = String.Empty
            cmbSesso.Text = "M"

            dtpDataNascita.Value = Today
            dtpDataNascita.Checked = False

            txtLuogoNascita.Text = String.Empty
            txtProvNascita.Text = String.Empty
            cmbNazioneNascita.Text = String.Empty
            cmbCittadinanza.Text = String.Empty

            ' DOCUMENTO DI RICONOSCIMENTO.
            cmbTipoDoc.Text = String.Empty
            txtNumeroDoc.Text = String.Empty
            txtComuneRilascioDoc.Text = String.Empty
            cmbNazioneRilascioDoc.Text = String.Empty
            txtRilasciatoDaDoc.Text = String.Empty

            dtpDataRilascioDoc.Value = Today
            dtpDataRilascioDoc.Checked = False

         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub cmdApriIntestatario_Click(sender As Object, e As EventArgs) Handles cmdApriIntestatario.Click
      Try
         ' Modifica cliente esistente...
         If ApriClienti(cmbIdCliente.Text) = True Then
            CaricaListaClienti(cmbCognome, cmbIdCliente, TAB_CLIENTI)

            ' DATI ANAGRAFICI.
            cmbIdCliente.Text = String.Empty
            cmbCognome.Text = String.Empty
            txtNome.Text = String.Empty
            cmbSesso.Text = "M"

            dtpDataNascita.Value = Today
            dtpDataNascita.Checked = False

            txtLuogoNascita.Text = String.Empty
            txtProvNascita.Text = String.Empty
            cmbNazioneNascita.Text = String.Empty
            cmbCittadinanza.Text = String.Empty

            ' DOCUMENTO DI RICONOSCIMENTO.
            cmbTipoDoc.Text = String.Empty
            txtNumeroDoc.Text = String.Empty
            txtComuneRilascioDoc.Text = String.Empty
            cmbNazioneRilascioDoc.Text = String.Empty
            txtRilasciatoDaDoc.Text = String.Empty

            dtpDataRilascioDoc.Value = Today
            dtpDataRilascioDoc.Checked = False
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub cmbStatoPren_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStato.SelectedIndexChanged
      'Try
      '   cmdColore.BackColor = Color.FromArgb(AssegnaColore(cmbStatoPren.Text, TAB_STATO_PREN))
      '   IPren.Colore = Convert.ToString(cmdColore.BackColor.ToArgb)

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)
      'End Try

   End Sub

   Private Sub mcDataArrivo_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcDataArrivo.DateChanged
      Try
         ' Aggiorna la nuova data di arrivo.
         lblArrivo.Text = "Arrivo: " & e.Start.Date.ToLongDateString

         ' Se la data di arrivo è maggiore o uguale alla data di partenza.
         If e.Start.Date.Date >= mcDataPartenza.SelectionRange.Start.Date Then

            ' Imposta nuovamente il calendario.
            mcDataPartenza.MinDate = e.Start.Date.AddDays(1)

            ' Aggiorna la nuova data di partenza.
            lblPartenza.Text = "Partenza: " & mcDataPartenza.SelectionRange.Start.Date.ToLongDateString

            ' Aggiorna il numero delle notti.
            txtNumeroNotti.Text = CalcolaNumGiorni(e.Start.Date, mcDataPartenza.SelectionRange.Start.Date).ToString

            Exit Sub
         End If

         ' Imposta nuovamente il calendario.
         mcDataPartenza.MinDate = e.Start.Date.AddDays(1)

         ' Aggiorna il numero delle notti.
         txtNumeroNotti.Text = CalcolaNumGiorni(e.Start.Date, mcDataPartenza.SelectionRange.Start.Date).ToString

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub

   Private Sub mcDataPartenza_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles mcDataPartenza.DateChanged
      Try
         ' Aggiorna la nuova data di partenza.
         lblPartenza.Text = "Partenza: " & e.Start.Date.ToLongDateString

         ' Aggiorna il numero delle notti.
         txtNumeroNotti.Text = CalcolaNumGiorni(mcDataArrivo.SelectionRange.Start.Date, e.Start.Date).ToString

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub

   Private Sub cmbNumeroCamera_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNumeroCamera.SelectedIndexChanged
      'Try
      '   ' Imposta la descrizione della camera selezionata.
      '   txtDescrizioneCamera.Text = LeggiDescrizioneCamera(cmbNumeroCamera.Text, TAB_CAMERE)

      '   ' Se non è impostato un listino prezzi, Imposta il listino della camera selezionata.
      '   If cmbListino.Text = String.Empty Then
      '      cmbListino.Text = LeggiListinoCamera(cmbNumeroCamera.Text, TAB_CAMERE)
      '   End If

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Sub

   Private Sub cmbCognome_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCognome.SelectedIndexChanged
      Try
         ' Legge il nome relativo alla lista Cognome.
         CaricaDatiCliente()

         ' Genera l'intestazione con i dati del form.
         If txtNumero.Text <> String.Empty Then
            lblIntestazione.Text = VisIntestazione("Schedina N. " & txtNumero.Text, cmbCognome.Text, txtNome.Text)
         Else
            lblIntestazione.Text = VisIntestazione(txtNumero.Text, cmbCognome.Text, txtNome.Text)
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtPrezzoCamera_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
      Try
         e.Handled = CConvalida.DigitaSoloNumeriPuntegg(e.KeyChar)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtAccontoCamera_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
      Try
         e.Handled = CConvalida.DigitaSoloNumeriPuntegg(e.KeyChar)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtPrezzoCamera_LostFocus(sender As Object, e As System.EventArgs)
      Try
         If IsNumeric(sender.Text) Then
            sender.Text = CFormatta.FormattaEuro(Convert.ToDecimal(sender.Text))
         Else
            sender.Text = VALORE_ZERO
         End If

         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtAccontoCamera_LostFocus(sender As Object, e As System.EventArgs)
      Try
         If IsNumeric(sender.Text) Then
            sender.Text = CFormatta.FormattaEuro(Convert.ToDecimal(sender.Text))
         Else
            sender.Text = VALORE_ZERO
         End If

         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub CalcolaTotaleAddebiti()
      'Try
      '   If lvwAddebiti.Items.Count <> 0 Then
      '      Dim i As Integer = 0
      '      Dim TotRiga As Decimal
      '      Dim TotaleConto As Decimal

      '      For i = 0 To lvwAddebiti.Items.Count - 1
      '         TotRiga = Convert.ToDecimal(lvwAddebiti.Items(i).SubItems(3).Text)
      '         TotaleConto = TotaleConto + TotRiga
      '      Next i

      '      txtTotaleAddebitiExtra.Text = CFormatta.FormattaEuro(TotaleConto)
      '   Else
      '      txtTotaleAddebitiExtra.Text = VALORE_ZERO
      '   End If

      '   ' Aggiorna il campo nella scheda Contabile.
      '   txtTotaleAddebiti.Text = txtTotaleAddebitiExtra.Text

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Sub

   Public Sub CalcolaTotaleConto()
      'Try
      '   Dim numNotti As Integer
      '   If IsNumeric(txtNumeroNotti.Text) = True Then
      '      numNotti = Convert.ToInt32(txtNumeroNotti.Text)
      '   Else
      '      numNotti = 0
      '   End If

      '   Dim prezzoCamera As Double
      '   If IsNumeric(txtPrezzoCamera.Text) = True Then
      '      prezzoCamera = Convert.ToDouble(txtPrezzoCamera.Text)
      '   Else
      '      prezzoCamera = 0
      '   End If

      '   Dim addebitiExtra As Double
      '   If IsNumeric(txtTotaleAddebiti.Text) = True Then
      '      addebitiExtra = Convert.ToDouble(txtTotaleAddebiti.Text)
      '   Else
      '      addebitiExtra = 0
      '   End If

      '   Dim accontoCamera As Double
      '   If IsNumeric(txtAccontoCamera.Text) = True Then
      '      accontoCamera = Convert.ToDouble(txtAccontoCamera.Text)
      '   Else
      '      accontoCamera = 0
      '   End If

      '   ' Calcola il totale del costo della camera in base al tipo di listino applicato.
      '   Dim totCamera As Double
      '   Dim numAdulti As Integer = Convert.ToInt32(nudAdulti.Value)
      '   Dim numNeonati As Integer = Convert.ToInt32(nudNeonati.Value)
      '   Dim numBambini As Integer = Convert.ToInt32(nudBambini.Value)
      '   Dim numRagazzi As Integer = Convert.ToInt32(nudRagazzi.Value)

      '   ' Totale camera complessivo.
      '   totCamera = (prezzoCamera * numNotti)
      '   txtTotaleCostoCamera.Text = CFormatta.FormattaEuro(totCamera)

      '   ' Legge e calcola il totale per la Tassa di Soggiorno.
      '   Dim totaleTassaSoggiorno As Double
      '   totaleTassaSoggiorno = LeggiTotaleTassaSoggiorno(numAdulti, numNeonati, numBambini, numRagazzi)
      '   txtTassaSoggiorno.Text = CFormatta.FormattaEuro(totaleTassaSoggiorno)
      '   txtTotaleTassaSoggiorno.Text = CFormatta.FormattaEuro(totaleTassaSoggiorno * numNotti)

      '   ' Calcola il totale parziale del conto.
      '   Dim totConto As Double = (totCamera + addebitiExtra + totaleTassaSoggiorno) ' - accontoCamera)

      '   ' Calcola il valore del servizio sul totale del conto.
      '   Dim valServizio As Double
      '   Dim servizio As Double
      '   'Dim percServizio As Integer = txtServizio.Text.IndexOf("%")
      '   'If percServizio <> -1 Then
      '   If IsNumeric((txtServizio.Text)) Then
      '      servizio = Convert.ToDouble(txtServizio.Text) '.Remove(txtServizio.Text.Length - 1, 1))
      '      valServizio = CalcolaPercentuale(totConto, servizio)
      '   Else
      '      valServizio = 0 'Convert.ToDouble(txtServizio.Text)
      '      txtServizio.Text = VALORE_ZERO
      '   End If

      '   ' Calcola il valore dello sconto.
      '   Dim valSconto As Double
      '   Dim sconto As Double
      '   'Dim percSconto As Integer = txtSconto.Text.IndexOf("%")
      '   'If percSconto <> -1 Then
      '   If IsNumeric((txtSconto.Text)) Then
      '      sconto = Convert.ToDouble(txtSconto.Text) '.Remove(txtSconto.Text.Length - 1, 1))

      '      'If cmbApplicaSconto.SelectedIndex = 1 Then
      '      ' Sul totale del conto.
      '      valSconto = CalcolaPercentuale(totConto, sconto)
      '      'Else
      '      '   ' Sul totale della camera.
      '      '   valSconto = CalcolaPercentuale(totCamera, sconto)
      '      'End If
      '   Else
      '      valSconto = 0 'Convert.ToDouble(txtSconto.Text)
      '      txtSconto.Text = VALORE_ZERO
      '   End If

      '   ' Calcola il totale del conto.
      '   Dim valDaPagare As Double = (totConto + valServizio - valSconto)
      '   txtTotaleConto.Text = CFormatta.FormattaEuro(valDaPagare)

      '   ' Utilizzato per calcolare lo sconto nella creazione documento.
      '   Dim valTotale As Double = (totConto + valServizio)
      '   txtTotaleImporto.Text = CFormatta.FormattaEuro(valTotale)

      '   ' Calcola il totale da incassare sottraendo eventuali acconti.
      '   Dim totIncassare As Double = (valDaPagare - accontoCamera)
      '   txtTotaleIncassare.Text = CFormatta.FormattaEuro(totIncassare)

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Sub

   Private Sub cmdInserisciOccupanti_Click(sender As System.Object, e As System.EventArgs) Handles cmdInserisciOccupanti.Click
      Try
         ' Modifica il cursore del mouse.
         Cursor.Current = Cursors.AppStarting

         Dim frm As New frmInsClienti
         'frm.Tag = ""
         frm.ShowDialog()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub

   Private Sub cmdEliminaOccupanti_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminaOccupanti.Click
      Try
         If lvwOccupanti.Items.Count <> 0 Then

            lvwOccupanti.Focus()

            ' L'elemento inserito viene rimosso dall'elenco.
            lvwOccupanti.Items(lvwOccupanti.FocusedItem.Index).Remove()

         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try

   End Sub

   Private Sub eui_cmdAccessori_Click(sender As System.Object, e As System.EventArgs)
      Try
         Dim frm As New ListaAccessoriServizi("Accessorio")
         frm.Tag = "PrenCamera"
         frm.ShowDialog()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdServizi_Click(sender As System.Object, e As System.EventArgs)
      Try
         Dim frm As New ListaAccessoriServizi("Servizio")
         frm.Tag = "PrenCamera"
         frm.ShowDialog()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdApriPos_Click(sender As Object, e As EventArgs)
      ' Apre il punto cassa.
      'g_frmMain.ApriPos(Convert.ToInt32(txtNumero.Text), "Hotel", txtTotaleConto.Text, String.Empty)
   End Sub

   Private Sub eui_cmdEliminaRiga_Click(sender As System.Object, e As System.EventArgs)
      EliminaRiga()
      CalcolaTotaleAddebiti()
   End Sub

   Private Sub EliminaRiga()
      Try
         ' Registra loperazione effettuata dall'operatore identificato.
         'lvwAddebiti.Focus()
         'Dim strDescrizione As String = "(" & lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(1).Text & _
         '                               " " & lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(2).Text & _
         '                               " € " & lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(3).Text & ")"

         'g_frmMain.RegistraOperazione(TipoOperazione.Cancella, strDescrizione, MODULO_GESTIONE_POS)

         'If lvwAddebiti.Items.Count <> 0 Then
         '   lvwAddebiti.Focus()
         '   lvwAddebiti.Items.RemoveAt(lvwAddebiti.FocusedItem.Index)
         'End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdQuantitàPiù_Click(sender As System.Object, e As System.EventArgs)
      AumentaDiminuisciQta(True)
      CalcolaTotaleAddebiti()
   End Sub

   Private Sub eui_QuantitàMeno_Click(sender As System.Object, e As System.EventArgs)
      AumentaDiminuisciQta(False)
      CalcolaTotaleAddebiti()
   End Sub

   Private Function AumentaDiminuisciQta(ByVal val As Boolean) As Boolean
      ' Vero: aumenta di 1 - Falso: diminuisce di 1.
      'Try
      '   If lvwAddebiti.Items.Count <> 0 Then
      '      lvwAddebiti.Focus()

      '      Dim quantità As Integer = Convert.ToInt32(lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(2).Text)
      '      Dim totPrezzo As Decimal = Convert.ToDecimal(lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(3).Text)
      '      Dim prezzo As Decimal

      '      ' Ottiene il prezzo di una singola unità.
      '      prezzo = totPrezzo / quantità

      '      If val = True Then
      '         quantità += 1
      '      Else
      '         If quantità = 1 Then
      '            EliminaRiga()

      '            Return False
      '         Else
      '            quantità -= 1
      '         End If
      '      End If

      '      ' Calcola il prezzo totale in base alla quantità inserita.
      '      totPrezzo = prezzo * quantità
      '      lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(3).Text = String.Format("{0:0.00}", totPrezzo)

      '      lvwAddebiti.Items(lvwAddebiti.FocusedItem.Index).SubItems(2).Text = quantità

      '      Return True
      '   End If

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      '   Return False

      'End Try
   End Function

   Private Sub txtServizio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
      Try
         e.Handled = CConvalida.DigitaSoloNumeriPuntegg(e.KeyChar)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtServizio_LostFocus(sender As Object, e As System.EventArgs)
      Try
         If IsNumeric(sender.Text) Then
            sender.Text = CFormatta.FormattaEuro(Convert.ToDecimal(sender.Text))
         Else
            sender.Text = VALORE_ZERO
         End If

         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtSconto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
      Try
         e.Handled = CConvalida.DigitaSoloNumeriPuntegg(e.KeyChar)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub txtSconto_LostFocus(sender As Object, e As System.EventArgs)
      Try
         If IsNumeric(sender.Text) Then
            sender.Text = CFormatta.FormattaEuro(Convert.ToDecimal(sender.Text))
         Else
            sender.Text = VALORE_ZERO
         End If

         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub cmbApplicaSconto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
      Try
         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Function LeggiBassaStagione1(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio1_Bassa) = True And IsDate(.DataFine1_Bassa) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio1_Bassa & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine1_Bassa & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return BASSA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return BASSA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiBassaStagione2(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio2_Bassa) = True And IsDate(.DataFine2_Bassa) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio2_Bassa & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine2_Bassa & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return BASSA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return BASSA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiBassaStagione3(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio3_Bassa) = True And IsDate(.DataFine3_Bassa) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio3_Bassa & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine3_Bassa & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return BASSA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return BASSA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiMediaStagione1(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio1_Media) = True And IsDate(.DataFine1_Media) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio1_Media & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine1_Media & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return MEDIA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return MEDIA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiMediaStagione2(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio2_Media) = True And IsDate(.DataFine2_Media) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio2_Media & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine2_Media & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return MEDIA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return MEDIA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiMediaStagione3(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio3_Media) = True And IsDate(.DataFine3_Media) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio3_Media & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine3_Media & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return MEDIA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return MEDIA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiAltaStagione1(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio1_Alta) = True And IsDate(.DataFine1_Alta) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio1_Alta & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine1_Alta & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return ALTA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return ALTA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiAltaStagione2(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio2_Alta) = True And IsDate(.DataFine2_Alta) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio2_Alta & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine2_Alta & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return ALTA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return ALTA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiAltaStagione3(ByVal dataPren As Date) As String
      'Try
      '   ' Verifico la data per sapere il periodo di stagione.
      '   Dim AStagioni As New Stagioni

      '   With AStagioni

      '      ' Leggo i dati.
      '      .LeggiDati(TAB_STAGIONI)

      '      If IsDate(.DataInizio3_Alta) = True And IsDate(.DataFine3_Alta) = True Then
      '         Dim dataTemp As Date = Convert.ToDateTime(.DataInizio3_Alta & Today.Year.ToString)
      '         Dim dataTempFine As Date = Convert.ToDateTime(.DataFine3_Alta & Today.Year.ToString)

      '         If dataTemp <> dataTempFine Then
      '            Do
      '               If dataTemp = dataPren Then
      '                  Return ALTA_STAGIONE
      '               Else
      '                  dataTemp = dataTemp.AddDays(1)
      '               End If
      '            Loop Until dataTemp = dataTempFine
      '         Else
      '            If dataTemp = dataPren Then
      '               Return ALTA_STAGIONE
      '            End If
      '         End If
      '      End If

      '   End With

      '   Return String.Empty

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try

   End Function

   Private Function LeggiPrezzoListino(ByVal tipoStagione As String) As String
      'Try
      '   Const PERNOTTAMENTO As String = "PN"
      '   Const BED_AND_BREAKFAST As String = "BB"
      '   Const MEZZA_PENSIONE As String = "MP"
      '   Const PENSIONE_COMPLETA As String = "PC"

      '   If cmbListino.SelectedIndex = -1 Then
      '      Return VALORE_ZERO
      '   End If

      '   ' Leggo l'Id del listino selezionato.
      '   cmbIdListino.SelectedIndex = cmbListino.SelectedIndex

      '   ' Estraggo i dati del listino selezionato.
      '   Dim AListinoCamera As New ListinoCamera
      '   With AListinoCamera
      '      .LeggiDati(TAB_LISTINO, cmbIdListino.Text)

      '      ' Leggo il tipo di Listino - Prezzo a persona o Camera.
      '      tipoListino = .Tipologia

      '      ' Leggo il Trattamento selezionato.
      '      Dim trattamento As String = cmbTrattamento.Text.Substring(0, 2)

      '      ' Leggo il prezzo da applicare.
      '      Select Case tipoStagione
      '         Case BASSA_STAGIONE
      '            scontoNeonato = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoNeonato_Bassa))
      '            scontoBambino = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoBambino_Bassa))
      '            scontoRagazzo = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoRagazzo_Bassa))

      '            Select Case trattamento
      '               Case PERNOTTAMENTO
      '                  Return .SoloPernottamento_Bassa
      '               Case BED_AND_BREAKFAST
      '                  Return .BB_Bassa
      '               Case MEZZA_PENSIONE
      '                  Return .MezzaPensione_Bassa
      '               Case PENSIONE_COMPLETA
      '                  Return .PensioneCompleta_Bassa
      '            End Select

      '         Case MEDIA_STAGIONE
      '            scontoNeonato = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoNeonato_Media))
      '            scontoBambino = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoBambino_Media))
      '            scontoRagazzo = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoRagazzo_Media))

      '            Select Case trattamento
      '               Case PERNOTTAMENTO
      '                  Return .SoloPernottamento_Media
      '               Case BED_AND_BREAKFAST
      '                  Return .BB_Media
      '               Case MEZZA_PENSIONE
      '                  Return .MezzaPensione_Media
      '               Case PENSIONE_COMPLETA
      '                  Return .PensioneCompleta_Media
      '            End Select

      '         Case ALTA_STAGIONE
      '            scontoNeonato = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoNeonato_Alta))
      '            scontoBambino = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoBambino_Alta))
      '            scontoRagazzo = CFormatta.FormattaNumeroDouble(Convert.ToDouble(.ScontoRagazzo_Alta))

      '            Select Case trattamento
      '               Case PERNOTTAMENTO
      '                  Return .SoloPernottamento_Alta
      '               Case BED_AND_BREAKFAST
      '                  Return .BB_Alta
      '               Case MEZZA_PENSIONE
      '                  Return .MezzaPensione_Alta
      '               Case PENSIONE_COMPLETA
      '                  Return .PensioneCompleta_Alta
      '            End Select

      '         Case Else
      '            Return VALORE_ZERO

      '      End Select

      '   End With

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      '   Return VALORE_ZERO
      'End Try
   End Function

   Private Sub ApplicaListino()
      Try
         Dim tipoStagione As String
         Dim prezzoCamera As String

         ' Leggo la data di inizio prenotazione.
         Dim dataPrenotazione As Date = mcDataArrivo.SelectionRange.Start.Date

         ' Bassa stagione - Intervallo 1.
         tipoStagione = LeggiBassaStagione1(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Bassa stagione - Intervallo 2.
         tipoStagione = LeggiBassaStagione2(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Bassa stagione - Intervallo 3.
         tipoStagione = LeggiBassaStagione3(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Media stagione - Intervallo 1.
         tipoStagione = LeggiMediaStagione1(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Media stagione - Intervallo 2.
         tipoStagione = LeggiMediaStagione2(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Media stagione - Intervallo 3.
         tipoStagione = LeggiMediaStagione3(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Alta stagione - Intervallo 1.
         tipoStagione = LeggiAltaStagione1(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Alta stagione - Intervallo 2.
         tipoStagione = LeggiAltaStagione2(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Alta stagione - Intervallo 3.
         tipoStagione = LeggiAltaStagione3(dataPrenotazione)
         If tipoStagione <> String.Empty Then
            prezzoCamera = LeggiPrezzoListino(tipoStagione)
         End If

         ' Calcola il totale del costo della camera in base al tipo di listino applicato.
         Dim totCameraAdulti As Double
         Dim totCameraNeonati As Double
         Dim totCameraBambini As Double
         Dim totCameraRagazzi As Double

         'Dim numAdulti As Integer = Convert.ToInt32(nudAdulti.Value)
         'Dim numNeonati As Integer = Convert.ToInt32(nudNeonati.Value)
         'Dim numBambini As Integer = Convert.ToInt32(nudBambini.Value)
         'Dim numRagazzi As Integer = Convert.ToInt32(nudRagazzi.Value)

         'Select Case tipoListino

         '   Case "Tariffa a Persona"
         '      ' Adulti.
         '      totCameraAdulti = (prezzoCamera * numAdulti)

         '      ' Neonati.
         '      If scontoNeonato = VALORE_ZERO Or scontoNeonato = String.Empty Then
         '         totCameraNeonati = (prezzoCamera * numNeonati)
         '      Else
         '         Dim scontoPrezzoCamera As Double = ((prezzoCamera * Convert.ToDouble(scontoNeonato)) / 100)
         '         totCameraNeonati = (scontoPrezzoCamera * numNeonati)
         '      End If

         '      ' Bambini.
         '      If scontoBambino = VALORE_ZERO Or scontoBambino = String.Empty Then
         '         totCameraBambini = (prezzoCamera * numBambini)
         '      Else
         '         Dim scontoPrezzoCamera As Double = ((prezzoCamera * Convert.ToDouble(scontoBambino)) / 100)
         '         totCameraBambini = (scontoPrezzoCamera * numBambini)
         '      End If

         '      ' Ragazzi.
         '      If scontoRagazzo = VALORE_ZERO Or scontoRagazzo = String.Empty Then
         '         totCameraRagazzi = (prezzoCamera * numRagazzi)
         '      Else
         '         Dim scontoPrezzoCamera As Double = ((prezzoCamera * Convert.ToDouble(scontoRagazzo)) / 100)
         '         totCameraRagazzi = (scontoPrezzoCamera * numRagazzi)
         '      End If

         '      ' Assegna il prezzo alla camera.
         '      txtPrezzoCamera.Text = CFormatta.FormattaEuro((totCameraAdulti + totCameraNeonati + totCameraBambini + totCameraRagazzi))

         '   Case "Tariffa a Camera"
         '      ' Assegna il prezzo alla camera.
         '      txtPrezzoCamera.Text = CFormatta.FormattaEuro(prezzoCamera)

         'End Select

         ' Esegue i calcoli per il totale degli importi.
         CalcolaTotaleConto()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub eui_cmdInserisci_Click(sender As Object, e As EventArgs)
      'Try
      '   If ImpostaDatiAllegati(String.Empty, True) = True Then
      '      IAllegati.InserisciDati(TAB_ALLEGATI)
      '      ConvalidaAllegati()
      '   End If

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      'End Try
   End Sub

   Private Sub eui_cmdModifica_Click(sender As Object, e As EventArgs)
      'Try
      '   'cmdInserimento.NotifyDefault(False)

      '   With IAllegati
      '      .Documento = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(0).Text
      '      .Data = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(1).Text
      '      .Ora = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(2).Text
      '      .Note = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(3).Text
      '      .Percorso = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(4).Text

      '      If ImpostaDatiAllegati(.Note, False) = True Then
      '         .ModificaDati(TAB_ALLEGATI, lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(5).Text)
      '         ConvalidaAllegati()
      '      End If
      '   End With

      'Catch ex As NullReferenceException
      '   ' Visualizza un messaggio.
      '   MessageBox.Show("Selezionare un elemento dalla lista.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'End Try
   End Sub

   Private Sub eui_cmdElimina_Click(sender As Object, e As EventArgs)
      'Try
      '   'cmdInserimento.NotifyDefault(False)

      '   RimuoviAllegati(TAB_ALLEGATI, lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(5).Text)
      '   ConvalidaAllegati()

      'Catch ex As NullReferenceException
      '   ' Visualizza un messaggio.
      '   MessageBox.Show("Selezionare un elemento dalla lista.", NOME_PRODOTTO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

      'End Try
   End Sub

   Private Sub lvwAllegati_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
      ' DA_FARE_A: DA TERMINARE - IMPOSTARE TUTTI I PROGRAMMI APRIBILI.
      Dim Estensione As String
      Dim NomeFile As String
      Dim Percorso As String
      Dim PercorsoApp As String
      Dim NomeApp As String
      Dim Proc As New Process

      Try

         ' Nome del file.
         'NomeFile = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(0).Text
         ' Percorso del file.
         'Percorso = lvwAllegati.Items(lvwAllegati.FocusedItem.Index).SubItems(4).Text

         ' Ottiene l'estensione del file.
         Estensione = Path.GetExtension(Percorso)

         Select Case Estensione.ToUpper
            Case ".DOC", ".RTF"
               ' Word
               NomeApp = "WINWORD.EXE"

            Case ".XLS"
               ' Excel
               NomeApp = "EXCEL.EXE"

            Case ".MDB"
               ' Access
               NomeApp = "MSACCESS.EXE"

            Case ".PPT"
               ' Power Point
               NomeApp = "POWERPNT.EXE"

            Case ".TXT"
               ' Blocco note.
               NomeApp = "NOTEPAD.EXE"

            Case ".PDF"
               ' Acrobat Reader
               NomeApp = "ACRORD32.EXE"

            Case ".HTM"
               ' Internet Explorer
               NomeApp = "IEXPLORE.EXE"
         End Select

         ' Avvia l'applicazione.
         Proc.StartInfo.FileName = NomeApp
         Proc.StartInfo.Arguments = Percorso
         Proc.StartInfo.ErrorDialog = True
         Proc.StartInfo.ErrorDialogParentHandle = Me.Handle
         Proc.StartInfo.UseShellExecute = True
         Proc.Start()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

End Class
