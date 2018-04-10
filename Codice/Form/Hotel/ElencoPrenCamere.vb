' Nome form:            ElencoPrenCamere
' Autore:               Luigi Montana, Montana Software
' Data creazione:       23/08/2014
' Data ultima modifica: 10/04/2018
' Descrizione:          Elenco prenotazioni camere.

Option Strict Off
Option Explicit On 

Imports System.Data.OleDb

Public Class ElencoPrenCamere
   Inherits System.Windows.Forms.Form

   Public Const TAB_PRENOTAZIONI As String = "PrenCamere"
   Public Const TAB_CAMERE As String = "Camere"

   ' A_TODO: HOTEL - da modificare!
   Const COLONNA_ID_DOC As Short = 0
   Const COLONNA_NUMERO_PREN As Short = 1
   Const COLONNA_DATA As Short = 1
   Const COLONNA_COGNOME As Short = 3
   Const COLONNA_NOME As Short = 4
   Const COLONNA_NOTTI As Short = 7
   Const COLONNA_ADULTI As Short = 8
   Const COLONNA_NEONATI As Short = 9
   Const COLONNA_BAMBINI As Short = 10
   Const COLONNA_RAGAZZI As Short = 11
   Const COLONNA_IMPORTO_TOTALE As Short = 15

   Const TESTO_FILTRO_PERIODO As String = "Dal... Al..."

   ' Dichiara un oggetto connessione.
   Dim cn As New OleDbConnection(ConnString)
   ' Dichiara un oggetto transazione.
   Dim tr As OleDbTransaction
   Dim cmd As New OleDbCommand(sql, cn)
   Dim da As OleDbDataAdapter

   ' Numero di record.
   Dim numRecord As Integer
   ' Numero di pagine.
   Dim numPagine As Integer
   ' Pagina corrente.
   Dim pagCorrente As Integer

   Dim ds As New DataSet
   Dim dt As DataTable
   Dim sql As String
   Dim repSql As String

   Private DatiConfig As AppConfig
   Private CFormatta As New ClsFormatta
   Dim filtroDati As String

#Region " Codice generato da Progettazione Windows Form "

   Public Sub New()
      MyBase.New()

      'Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      dt = ds.Tables.Add(TAB_PRENOTAZIONI)

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

   'NOTA: la procedura che segue � richiesta da Progettazione Windows Form.
   'Pu� essere modificata in Progettazione Windows Form.  
   'Non modificarla nell'editor del codice.
   Public WithEvents DataGrid1 As System.Windows.Forms.DataGrid
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents CampoRicerca As System.Windows.Forms.ComboBox
   Friend WithEvents TestoRicerca As System.Windows.Forms.TextBox
   Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
   Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Public WithEvents txtTotaleNotti As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Public WithEvents txtTotaleAdulti As System.Windows.Forms.TextBox
   Friend WithEvents lblCampo As System.Windows.Forms.Label
   Friend WithEvents lblTesto As System.Windows.Forms.Label
   Public WithEvents txtTotaleImporto As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
   Public WithEvents txtCamereConsegna As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Public WithEvents txtCamereOccupate As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Public WithEvents txtCamereLibere As System.Windows.Forms.TextBox
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Public WithEvents txtOspitiPartenza As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Public WithEvents txtOspitiCasa As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Public WithEvents txtOspitiArrivo As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Public WithEvents txtTotaleRagazzi As System.Windows.Forms.TextBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Public WithEvents txtTotaleBambini As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Public WithEvents txtTotaleNeonati As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label

   <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElencoPrenCamere))
      Me.DataGrid1 = New System.Windows.Forms.DataGrid()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.TestoRicerca = New System.Windows.Forms.TextBox()
      Me.txtCamereConsegna = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.txtCamereOccupate = New System.Windows.Forms.TextBox()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtCamereLibere = New System.Windows.Forms.TextBox()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.txtOspitiPartenza = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.txtOspitiCasa = New System.Windows.Forms.TextBox()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.txtOspitiArrivo = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.CampoRicerca = New System.Windows.Forms.ComboBox()
      Me.lblCampo = New System.Windows.Forms.Label()
      Me.lblTesto = New System.Windows.Forms.Label()
      Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
      Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.txtTotaleRagazzi = New System.Windows.Forms.TextBox()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.txtTotaleBambini = New System.Windows.Forms.TextBox()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.txtTotaleNeonati = New System.Windows.Forms.TextBox()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.txtTotaleImporto = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.txtTotaleAdulti = New System.Windows.Forms.TextBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtTotaleNotti = New System.Windows.Forms.TextBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
      CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.SuspendLayout()
      '
      'DataGrid1
      '
      Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
      Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Gray
      Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.DataGrid1.CaptionForeColor = System.Drawing.Color.White
      Me.DataGrid1.DataMember = ""
      Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
      Me.DataGrid1.Location = New System.Drawing.Point(0, 120)
      Me.DataGrid1.Name = "DataGrid1"
      Me.DataGrid1.ReadOnly = True
      Me.DataGrid1.Size = New System.Drawing.Size(952, 324)
      Me.DataGrid1.TabIndex = 0
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Gray
      Me.Panel1.Controls.Add(Me.TestoRicerca)
      Me.Panel1.Controls.Add(Me.txtCamereConsegna)
      Me.Panel1.Controls.Add(Me.Label7)
      Me.Panel1.Controls.Add(Me.txtCamereOccupate)
      Me.Panel1.Controls.Add(Me.Label8)
      Me.Panel1.Controls.Add(Me.txtCamereLibere)
      Me.Panel1.Controls.Add(Me.Label9)
      Me.Panel1.Controls.Add(Me.txtOspitiPartenza)
      Me.Panel1.Controls.Add(Me.Label5)
      Me.Panel1.Controls.Add(Me.txtOspitiCasa)
      Me.Panel1.Controls.Add(Me.Label4)
      Me.Panel1.Controls.Add(Me.txtOspitiArrivo)
      Me.Panel1.Controls.Add(Me.Label2)
      Me.Panel1.Controls.Add(Me.CampoRicerca)
      Me.Panel1.Controls.Add(Me.lblCampo)
      Me.Panel1.Controls.Add(Me.lblTesto)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel1.Location = New System.Drawing.Point(0, 0)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(952, 120)
      Me.Panel1.TabIndex = 0
      '
      'TestoRicerca
      '
      Me.TestoRicerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TestoRicerca.Location = New System.Drawing.Point(16, 32)
      Me.TestoRicerca.Name = "TestoRicerca"
      Me.TestoRicerca.Size = New System.Drawing.Size(682, 20)
      Me.TestoRicerca.TabIndex = 7
      '
      'txtCamereConsegna
      '
      Me.txtCamereConsegna.AcceptsReturn = True
      Me.txtCamereConsegna.BackColor = System.Drawing.SystemColors.Window
      Me.txtCamereConsegna.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtCamereConsegna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCamereConsegna.ForeColor = System.Drawing.Color.Red
      Me.txtCamereConsegna.Location = New System.Drawing.Point(168, 88)
      Me.txtCamereConsegna.MaxLength = 0
      Me.txtCamereConsegna.Name = "txtCamereConsegna"
      Me.txtCamereConsegna.ReadOnly = True
      Me.txtCamereConsegna.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtCamereConsegna.Size = New System.Drawing.Size(72, 20)
      Me.txtCamereConsegna.TabIndex = 5
      Me.txtCamereConsegna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label7
      '
      Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label7.ForeColor = System.Drawing.Color.White
      Me.Label7.Location = New System.Drawing.Point(16, 88)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(143, 15)
      Me.Label7.TabIndex = 55684
      Me.Label7.Text = "Camere in consegna:"
      '
      'txtCamereOccupate
      '
      Me.txtCamereOccupate.AcceptsReturn = True
      Me.txtCamereOccupate.BackColor = System.Drawing.SystemColors.Window
      Me.txtCamereOccupate.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtCamereOccupate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCamereOccupate.ForeColor = System.Drawing.Color.Blue
      Me.txtCamereOccupate.Location = New System.Drawing.Point(384, 88)
      Me.txtCamereOccupate.MaxLength = 0
      Me.txtCamereOccupate.Name = "txtCamereOccupate"
      Me.txtCamereOccupate.ReadOnly = True
      Me.txtCamereOccupate.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtCamereOccupate.Size = New System.Drawing.Size(72, 20)
      Me.txtCamereOccupate.TabIndex = 4
      Me.txtCamereOccupate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label8
      '
      Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label8.ForeColor = System.Drawing.Color.White
      Me.Label8.Location = New System.Drawing.Point(256, 88)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(123, 15)
      Me.Label8.TabIndex = 55682
      Me.Label8.Text = "Camere occupate:"
      '
      'txtCamereLibere
      '
      Me.txtCamereLibere.AcceptsReturn = True
      Me.txtCamereLibere.BackColor = System.Drawing.SystemColors.Window
      Me.txtCamereLibere.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtCamereLibere.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtCamereLibere.ForeColor = System.Drawing.Color.Green
      Me.txtCamereLibere.Location = New System.Drawing.Point(600, 88)
      Me.txtCamereLibere.MaxLength = 0
      Me.txtCamereLibere.Name = "txtCamereLibere"
      Me.txtCamereLibere.ReadOnly = True
      Me.txtCamereLibere.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtCamereLibere.Size = New System.Drawing.Size(72, 20)
      Me.txtCamereLibere.TabIndex = 3
      Me.txtCamereLibere.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label9
      '
      Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label9.ForeColor = System.Drawing.Color.White
      Me.Label9.Location = New System.Drawing.Point(472, 88)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(114, 15)
      Me.Label9.TabIndex = 55680
      Me.Label9.Text = "Camere liberate:"
      '
      'txtOspitiPartenza
      '
      Me.txtOspitiPartenza.AcceptsReturn = True
      Me.txtOspitiPartenza.BackColor = System.Drawing.SystemColors.Window
      Me.txtOspitiPartenza.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtOspitiPartenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtOspitiPartenza.ForeColor = System.Drawing.Color.Green
      Me.txtOspitiPartenza.Location = New System.Drawing.Point(600, 64)
      Me.txtOspitiPartenza.MaxLength = 0
      Me.txtOspitiPartenza.Name = "txtOspitiPartenza"
      Me.txtOspitiPartenza.ReadOnly = True
      Me.txtOspitiPartenza.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtOspitiPartenza.Size = New System.Drawing.Size(72, 20)
      Me.txtOspitiPartenza.TabIndex = 2
      Me.txtOspitiPartenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.ForeColor = System.Drawing.Color.White
      Me.Label5.Location = New System.Drawing.Point(472, 64)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(124, 15)
      Me.Label5.TabIndex = 55678
      Me.Label5.Text = "Ospiti in partenza:"
      '
      'txtOspitiCasa
      '
      Me.txtOspitiCasa.AcceptsReturn = True
      Me.txtOspitiCasa.BackColor = System.Drawing.SystemColors.Window
      Me.txtOspitiCasa.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtOspitiCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtOspitiCasa.ForeColor = System.Drawing.Color.Blue
      Me.txtOspitiCasa.Location = New System.Drawing.Point(384, 64)
      Me.txtOspitiCasa.MaxLength = 0
      Me.txtOspitiCasa.Name = "txtOspitiCasa"
      Me.txtOspitiCasa.ReadOnly = True
      Me.txtOspitiCasa.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtOspitiCasa.Size = New System.Drawing.Size(72, 20)
      Me.txtOspitiCasa.TabIndex = 1
      Me.txtOspitiCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.ForeColor = System.Drawing.Color.White
      Me.Label4.Location = New System.Drawing.Point(256, 64)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(98, 15)
      Me.Label4.TabIndex = 55676
      Me.Label4.Text = "Ospiti in casa:"
      '
      'txtOspitiArrivo
      '
      Me.txtOspitiArrivo.AcceptsReturn = True
      Me.txtOspitiArrivo.BackColor = System.Drawing.SystemColors.Window
      Me.txtOspitiArrivo.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtOspitiArrivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtOspitiArrivo.ForeColor = System.Drawing.Color.Red
      Me.txtOspitiArrivo.Location = New System.Drawing.Point(168, 64)
      Me.txtOspitiArrivo.MaxLength = 0
      Me.txtOspitiArrivo.Name = "txtOspitiArrivo"
      Me.txtOspitiArrivo.ReadOnly = True
      Me.txtOspitiArrivo.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtOspitiArrivo.Size = New System.Drawing.Size(72, 20)
      Me.txtOspitiArrivo.TabIndex = 0
      Me.txtOspitiArrivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.ForeColor = System.Drawing.Color.White
      Me.Label2.Location = New System.Drawing.Point(16, 64)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(104, 15)
      Me.Label2.TabIndex = 55674
      Me.Label2.Text = "Ospiti in arrivo:"
      '
      'CampoRicerca
      '
      Me.CampoRicerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.CampoRicerca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.CampoRicerca.Location = New System.Drawing.Point(706, 32)
      Me.CampoRicerca.Name = "CampoRicerca"
      Me.CampoRicerca.Size = New System.Drawing.Size(232, 21)
      Me.CampoRicerca.TabIndex = 8
      '
      'lblCampo
      '
      Me.lblCampo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblCampo.AutoSize = True
      Me.lblCampo.BackColor = System.Drawing.Color.Transparent
      Me.lblCampo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblCampo.ForeColor = System.Drawing.Color.White
      Me.lblCampo.Location = New System.Drawing.Point(706, 16)
      Me.lblCampo.Name = "lblCampo"
      Me.lblCampo.Size = New System.Drawing.Size(85, 15)
      Me.lblCampo.TabIndex = 8
      Me.lblCampo.Text = "Ricerca per:"
      '
      'lblTesto
      '
      Me.lblTesto.AutoSize = True
      Me.lblTesto.BackColor = System.Drawing.Color.Transparent
      Me.lblTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblTesto.ForeColor = System.Drawing.Color.White
      Me.lblTesto.Location = New System.Drawing.Point(16, 16)
      Me.lblTesto.Name = "lblTesto"
      Me.lblTesto.Size = New System.Drawing.Size(110, 15)
      Me.lblTesto.TabIndex = 6
      Me.lblTesto.Text = "Testo di ricerca:"
      '
      'PrintDialog1
      '
      Me.PrintDialog1.Document = Me.PrintDocument1
      '
      'PrintDocument1
      '
      Me.PrintDocument1.DocumentName = "Risorse.rpt"
      '
      'Panel2
      '
      Me.Panel2.BackColor = System.Drawing.Color.Gray
      Me.Panel2.Controls.Add(Me.txtTotaleRagazzi)
      Me.Panel2.Controls.Add(Me.Label12)
      Me.Panel2.Controls.Add(Me.txtTotaleBambini)
      Me.Panel2.Controls.Add(Me.Label11)
      Me.Panel2.Controls.Add(Me.txtTotaleNeonati)
      Me.Panel2.Controls.Add(Me.Label10)
      Me.Panel2.Controls.Add(Me.txtTotaleImporto)
      Me.Panel2.Controls.Add(Me.Label1)
      Me.Panel2.Controls.Add(Me.txtTotaleAdulti)
      Me.Panel2.Controls.Add(Me.Label3)
      Me.Panel2.Controls.Add(Me.txtTotaleNotti)
      Me.Panel2.Controls.Add(Me.Label6)
      Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.Panel2.Location = New System.Drawing.Point(0, 450)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(952, 35)
      Me.Panel2.TabIndex = 13
      '
      'txtTotaleRagazzi
      '
      Me.txtTotaleRagazzi.AcceptsReturn = True
      Me.txtTotaleRagazzi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleRagazzi.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleRagazzi.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleRagazzi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleRagazzi.ForeColor = System.Drawing.Color.Blue
      Me.txtTotaleRagazzi.Location = New System.Drawing.Point(701, 11)
      Me.txtTotaleRagazzi.MaxLength = 0
      Me.txtTotaleRagazzi.Name = "txtTotaleRagazzi"
      Me.txtTotaleRagazzi.ReadOnly = True
      Me.txtTotaleRagazzi.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleRagazzi.Size = New System.Drawing.Size(48, 20)
      Me.txtTotaleRagazzi.TabIndex = 4
      Me.txtTotaleRagazzi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label12
      '
      Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label12.AutoSize = True
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label12.ForeColor = System.Drawing.Color.White
      Me.Label12.Location = New System.Drawing.Point(636, 11)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(63, 15)
      Me.Label12.TabIndex = 244
      Me.Label12.Text = "Ragazzi:"
      '
      'txtTotaleBambini
      '
      Me.txtTotaleBambini.AcceptsReturn = True
      Me.txtTotaleBambini.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleBambini.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleBambini.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleBambini.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleBambini.ForeColor = System.Drawing.Color.Blue
      Me.txtTotaleBambini.Location = New System.Drawing.Point(573, 11)
      Me.txtTotaleBambini.MaxLength = 0
      Me.txtTotaleBambini.Name = "txtTotaleBambini"
      Me.txtTotaleBambini.ReadOnly = True
      Me.txtTotaleBambini.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleBambini.Size = New System.Drawing.Size(48, 20)
      Me.txtTotaleBambini.TabIndex = 3
      Me.txtTotaleBambini.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label11
      '
      Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label11.AutoSize = True
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label11.ForeColor = System.Drawing.Color.White
      Me.Label11.Location = New System.Drawing.Point(508, 11)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(64, 15)
      Me.Label11.TabIndex = 242
      Me.Label11.Text = "Bambini:"
      '
      'txtTotaleNeonati
      '
      Me.txtTotaleNeonati.AcceptsReturn = True
      Me.txtTotaleNeonati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleNeonati.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleNeonati.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleNeonati.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleNeonati.ForeColor = System.Drawing.Color.Blue
      Me.txtTotaleNeonati.Location = New System.Drawing.Point(445, 11)
      Me.txtTotaleNeonati.MaxLength = 0
      Me.txtTotaleNeonati.Name = "txtTotaleNeonati"
      Me.txtTotaleNeonati.ReadOnly = True
      Me.txtTotaleNeonati.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleNeonati.Size = New System.Drawing.Size(48, 20)
      Me.txtTotaleNeonati.TabIndex = 2
      Me.txtTotaleNeonati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label10
      '
      Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label10.AutoSize = True
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label10.ForeColor = System.Drawing.Color.White
      Me.Label10.Location = New System.Drawing.Point(380, 11)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(61, 15)
      Me.Label10.TabIndex = 240
      Me.Label10.Text = "Neonati:"
      '
      'txtTotaleImporto
      '
      Me.txtTotaleImporto.AcceptsReturn = True
      Me.txtTotaleImporto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleImporto.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleImporto.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleImporto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleImporto.ForeColor = System.Drawing.Color.Red
      Me.txtTotaleImporto.Location = New System.Drawing.Point(818, 11)
      Me.txtTotaleImporto.MaxLength = 0
      Me.txtTotaleImporto.Name = "txtTotaleImporto"
      Me.txtTotaleImporto.ReadOnly = True
      Me.txtTotaleImporto.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleImporto.Size = New System.Drawing.Size(120, 20)
      Me.txtTotaleImporto.TabIndex = 5
      Me.txtTotaleImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ForeColor = System.Drawing.Color.White
      Me.Label1.Location = New System.Drawing.Point(764, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(51, 15)
      Me.Label1.TabIndex = 238
      Me.Label1.Text = "Totale:"
      '
      'txtTotaleAdulti
      '
      Me.txtTotaleAdulti.AcceptsReturn = True
      Me.txtTotaleAdulti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleAdulti.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleAdulti.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleAdulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleAdulti.ForeColor = System.Drawing.Color.Blue
      Me.txtTotaleAdulti.Location = New System.Drawing.Point(317, 11)
      Me.txtTotaleAdulti.MaxLength = 0
      Me.txtTotaleAdulti.Name = "txtTotaleAdulti"
      Me.txtTotaleAdulti.ReadOnly = True
      Me.txtTotaleAdulti.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleAdulti.Size = New System.Drawing.Size(48, 20)
      Me.txtTotaleAdulti.TabIndex = 1
      Me.txtTotaleAdulti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.ForeColor = System.Drawing.Color.White
      Me.Label3.Location = New System.Drawing.Point(268, 11)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(47, 15)
      Me.Label3.TabIndex = 236
      Me.Label3.Text = "Adulti:"
      '
      'txtTotaleNotti
      '
      Me.txtTotaleNotti.AcceptsReturn = True
      Me.txtTotaleNotti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtTotaleNotti.BackColor = System.Drawing.SystemColors.Window
      Me.txtTotaleNotti.Cursor = System.Windows.Forms.Cursors.IBeam
      Me.txtTotaleNotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtTotaleNotti.ForeColor = System.Drawing.Color.Red
      Me.txtTotaleNotti.Location = New System.Drawing.Point(170, 11)
      Me.txtTotaleNotti.MaxLength = 0
      Me.txtTotaleNotti.Name = "txtTotaleNotti"
      Me.txtTotaleNotti.ReadOnly = True
      Me.txtTotaleNotti.RightToLeft = System.Windows.Forms.RightToLeft.No
      Me.txtTotaleNotti.Size = New System.Drawing.Size(80, 20)
      Me.txtTotaleNotti.TabIndex = 0
      Me.txtTotaleNotti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label6
      '
      Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.ForeColor = System.Drawing.Color.White
      Me.Label6.Location = New System.Drawing.Point(124, 11)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(41, 15)
      Me.Label6.TabIndex = 16
      Me.Label6.Text = "Notti:"
      '
      'formFrameSkinner
      '
      Me.formFrameSkinner.AllowGlass = False
      Me.formFrameSkinner.Form = Me
      '
      'ElencoPrenCamere
      '
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.ClientSize = New System.Drawing.Size(952, 485)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.DataGrid1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "ElencoPrenCamere"
      Me.ShowInTaskbar = False
      Me.Text = "Elenco prenotazioni camere"
      CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub

#End Region

   Private Sub LeggiDatiConfig()
      Try
         ' Nel caso la directory corrente venga cambiata.
         Environment.CurrentDirectory = Application.StartupPath

         ' A_TODO: HOTEL - da modificare!
         If DatiConfig.GetValue("FiltroPeriodo") <> "" Then
            filtroDati = DatiConfig.GetValue("FiltroPeriodo")
         Else
            filtroDati = "Tutti"
         End If

         If DatiConfig.GetValue("WSPrenCamere") = CStr(FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Maximized
            Exit Sub
         ElseIf DatiConfig.GetValue("WSPrenCamere") = CStr(FormWindowState.Minimized) Then
            Me.WindowState = FormWindowState.Minimized
            Exit Sub
         Else
            If DatiConfig.GetValue("APrenCamere") <> "" Then
               Me.Height = CInt(DatiConfig.GetValue("APrenCamere"))
            Else
               Me.Height = FORM_ALTEZZA
            End If

            If DatiConfig.GetValue("LPrenCamere") <> "" Then
               Me.Width = CInt(DatiConfig.GetValue("LPrenCamere"))
            Else
               Me.Width = FORM_LARGHEZZA
            End If

            If DatiConfig.GetValue("PrenCamereX") <> "" Then
               Me.Location = New Point(CInt(DatiConfig.GetValue("PrenCamereX")), Me.Location.Y)
            End If

            If DatiConfig.GetValue("PrenCamereY") <> "" Then
               Me.Location = New Point(Me.Location.X, CInt(DatiConfig.GetValue("PrenCamereY")))
            End If

            Exit Sub
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub SalvaDatiConfig()
      Try
         ' Nel caso la directory corrente venga cambiata.
         Environment.CurrentDirectory = Application.StartupPath

         DatiConfig.SetValue("FiltroPeriodo", filtroDati)
         DatiConfig.SetValue("WSPrenCamere", Me.WindowState)
         DatiConfig.SetValue("PrenCamereX", Me.Location.X)
         DatiConfig.SetValue("PrenCamereY", Me.Location.Y)
         DatiConfig.SetValue("APrenCamere", Me.Height)
         DatiConfig.SetValue("LPrenCamere", Me.Width)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Function ImpostaFunzioniOperatore(ByVal wnd As String) As Boolean
      'Try
      '   Select Case wnd
      '      Case Finestra.Documenti
      '         If operatore.ContDoc = VALORE_LETTURA Then
      '            tbrAnnulla.Enabled = False
      '            tbrSospeso.Enabled = False
      '            tbrPassaSospeso.Enabled = False
      '            tbrAnnullaSospeso.Enabled = False
      '            tbrBuoni.Enabled = False
      '            tbrModifica.Enabled = False
      '            tbrAggiorna.Enabled = False
      '         Else
      '            tbrAnnulla.Enabled = True
      '            tbrSospeso.Enabled = True
      '            tbrPassaSospeso.Enabled = True
      '            tbrAnnullaSospeso.Enabled = True
      '            tbrBuoni.Enabled = True
      '            tbrModifica.Enabled = True
      '            tbrAggiorna.Enabled = True
      '         End If

      '   End Select

      '   Return tbrModifica.Enabled

      'Catch ex As Exception
      '   ' Visualizza un messaggio di errore e lo registra nell'apposito file.
      '   err.GestisciErrore(ex.StackTrace, ex.Message)

      '   Return True
      'End Try

   End Function

   ' A_TODO: HOTEL - da modificare!
   Private Sub EliminaDettagliDocumento()
      Try
         Dim rifDoc As Integer

         ' Legge il numero dell'ultimo documento creato.
         rifDoc = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_ID_DOC)

         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("DELETE FROM {0} WHERE RifDoc = {1}", "DettagliDoc", rifDoc)

         ' Crea il comando per la connessione corrente.
         Dim cmdDelete As New OleDbCommand(sql, cn, tr)

         ' Esegue il comando.
         Dim Record As Integer = cmdDelete.ExecuteNonQuery()

         ' Conferma la transazione.
         tr.Commit()

      Catch ex As Exception
         ' Annulla la transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub EliminaDocumento()
      Try
         Dim rifDoc As Integer

         ' Legge il numero dell'ultimo documento creato.
         rifDoc = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_ID_DOC)

         ' Apre la connessione.
         cn.Open()

         ' Avvia una transazione.
         tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

         ' Crea la stringa di eliminazione.
         sql = String.Format("DELETE FROM {0} WHERE Id = {1}", "Documenti", rifDoc)

         ' Crea il comando per la connessione corrente.
         Dim cmdDelete As New OleDbCommand(sql, cn, tr)

         ' Esegue il comando.
         Dim Record As Integer = cmdDelete.ExecuteNonQuery()

         ' Conferma la transazione.
         tr.Commit()

         ' Aggiorna la lista dati.
         AggiornaDati()

      Catch ex As Exception
         ' Annulla la transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()
      End Try
   End Sub

   Public Sub LeggiDati(ByVal tabella As String, ByVal sql As String)
      Try
         ' Calcola il numero delle pagine da visualizzare.
         LeggiNumPagine(tabella)

         DataGrid1.DataSource = dt

         ' Visualizza la prima pagina di dati.
         VisualizzaPagina(1, sql)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)
      End Try
   End Sub

   Public Sub LeggiNumPagine(ByVal tabella As String)
      Dim closeOnExit As Boolean

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Ottiene il numero di record.
         cmd.CommandText = String.Format("SELECT COUNT(*) FROM {0}", tabella)
         numRecord = CInt(cmd.ExecuteScalar())

         ' Chiude la connessione se � da chiudere.
         If closeOnExit Then cn.Close()

         If TestoRicerca.Text <> "" Then
            numPagine = 1
         Else
            ' Ottiene il numero di pagine.
            numPagine = (numRecord + DIM_PAGINA_GRANDE - 1) \ DIM_PAGINA_GRANDE 'dimPagina
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Sub

   Public Sub VisualizzaPagina(ByVal n As Integer, ByVal sql As String)
      Try
         ' Apre la connessione.
         cn.Open()

         ' Crea un nuovo oggetto DataAdapter.
         Dim da As New OleDbDataAdapter(sql, cn)

         ' Pulisce la tabella da precedenti dati.
         dt.Clear()

         ' Visualizza la pagina dati.
         da.Fill(dt)

         ' Salva il numero di pagina corrente.
         pagCorrente = n

         ' Abilita/disabilita i pulsanti.
         'Primo.Enabled = (n > 1)
         'Precedente.Enabled = (n > 1)
         'Successivo.Enabled = (n < numPagine)
         'Ultimo.Enabled = (n < numPagine)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub EliminaDati(ByVal tabella As String, ByVal id As Integer)
      Try
         Dim Risposta As Short
         Dim sql As String

         Dim Numero As String = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_NUMERO_PREN)
         Dim Data As String = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_DATA)
         Dim Cognome As String = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_COGNOME)
         Dim Nome As String = DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, COLONNA_NOME)
         Dim descrizione As String

         If Nome = String.Empty Then
            descrizione = Cognome & " numero " & Numero & " del " & Data
         Else
            descrizione = Cognome & " " & Nome & " numero " & Numero & " del " & Data
         End If

         ' Chiede conferma per l'eliminazione.
         Risposta = MsgBox("Si desidera eliminare la prenotazione del Cliente """ & descrizione & """?" &
                           vbCrLf & vbCrLf & "Non sar� pi� possibile recuperare i dati.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Conferma eliminazione")

         If Risposta = MsgBoxResult.Yes Then
            ' Apre la connessione.
            cn.Open()

            ' Avvia una transazione.
            tr = cn.BeginTransaction(IsolationLevel.ReadCommitted)

            ' Crea la stringa di eliminazione.
            sql = String.Format("DELETE FROM {0} WHERE Id = {1}", tabella, id)

            ' Crea il comando per la connessione corrente.
            Dim cmdDelete As New OleDbCommand(sql, cn, tr)

            ' Esegue il comando.
            Dim Record As Integer = cmdDelete.ExecuteNonQuery()

            ' Elimina i dati degli Occupanti per la prenotazione.
            '-------------------------------------------------------------------------------
            ' Crea la stringa di eliminazione.
            sql = String.Format("DELETE FROM PrenCamereOccupanti WHERE RifPren = {0}", id)

            ' Crea il comando per la connessione corrente.
            Dim cmdDelete1 As New OleDbCommand(sql, cn, tr)

            ' Esegue il comando.
            Dim Record1 As Integer = cmdDelete1.ExecuteNonQuery()
            '-------------------------------------------------------------------------------

            ' Elimina i dati degli Addebiti per la prenotazione.
            '-------------------------------------------------------------------------------
            ' Crea la stringa di eliminazione.
            sql = String.Format("DELETE FROM PrenCamereAddebiti WHERE RifPren = {0}", id)

            ' Crea il comando per la connessione corrente.
            Dim cmdDelete2 As New OleDbCommand(sql, cn, tr)

            ' Esegue il comando.
            Dim Record2 As Integer = cmdDelete2.ExecuteNonQuery()
            '-------------------------------------------------------------------------------

            ' A_TODO: Inserire qui il codice per eliminare anche gli Allegati.

            ' Conferma la transazione.
            tr.Commit()

            ' A_TODO: HOTEL - da modificare!
            ' Registra loperazione effettuata dall'operatore identificato.
            'g_frmMain.RegistraOperazione(TipoOperazione.Elimina, Descrizione, MODULO_GESTIONE_PLANNING_RISORSE)
         End If

      Catch ex As Exception
         ' Annulla la transazione.
         tr.Rollback()

         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

         'If tbrSospesi.Pushed = True Then
         '   ' Aggiorna la griglia dati.
         '   AggiornaDatiSospesi()
         'ElseIf tbrMese.Pushed = True Then
         '   ' Aggiorna la griglia dati.
         '   AggiornaDatiMese()
         'ElseIf tbrAnno.Pushed = True Then
         '   ' Aggiorna la griglia dati.
         '   AggiornaDatiAnno()
         'ElseIf tbrPeriodo.Pushed = True Then
         '   ' Aggiorna la griglia dati.
         '   AggiornaDatiPeriodo()
         'Else
         '   ' Aggiorna la griglia dati.
         '   AggiornaDati()
         'End If

         ' Aggiorna la griglia dati.
         AggiornaDati()

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()
      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub AggiornaDati()
      Try
         If TestoRicerca.Text <> "" Then
            ' Collega la tabella clienti al controllo griglia dati.
            DataGrid1.DataSource = dt

            FiltraDati(TestoRicerca.Text, CampoRicerca.Text)
         Else
            ' Calcola il numero delle pagine da visualizzare.
            LeggiNumPagine(TAB_PRENOTAZIONI)

            ' Collega la tabella clienti al controllo griglia dati.
            DataGrid1.DataSource = dt

            Select Case filtroDati
               Case "Tutti"
                  ' Filtra i dati in base al testo digitato.
                  FiltraDati(TestoRicerca.Text, CampoRicerca.Text)

               Case "Mese"
                  ' Aggiorna la griglia dati.
                  AggiornaDatiMese()

               Case "Anno"
                  ' Aggiorna la griglia dati.
                  AggiornaDatiAnno()

               Case "Periodo"
                  ' Aggiorna la griglia dati.
                  AggiornaDatiPeriodo()

               Case "Sospesi"
                  ' Aggiorna la griglia dati.
                  'AggiornaDatiSospesi()
            End Select
         End If

         ' Aggiorna i valori per gli Ospiti e le camere.
         AggiornaValoriOspiti()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub VisualizzaDate()
      'lblAl.Location = New Point(lblAl.Location.X, 8)
      'lblDal.Location = New Point(lblDal.Location.X, 8)
      'dtpAl.Location = New Point(dtpAl.Location.X, 8)
      'dtpDal.Location = New Point(dtpDal.Location.X, 8)
      'lblAl.Visible = True
      'lblDal.Visible = True
      'dtpAl.Visible = True
      'dtpDal.Visible = True

      'lblTesto.Visible = False
      'lblCampo.Visible = False
      'TestoRicerca.Visible = False
      'CampoRicerca.Visible = False
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub NascondiDate()
      'lblAl.Visible = False
      'lblDal.Visible = False
      'dtpAl.Visible = False
      'dtpDal.Visible = False

      lblTesto.Visible = True
      lblCampo.Visible = True
      TestoRicerca.Visible = True
      CampoRicerca.Visible = True
   End Sub

   Public Sub AggiornaDatiTutte()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         ' Crea la stringa di selezione dei dati.
         sql = String.Format("SELECT TOP {0} * FROM {1} ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI)
         repSql = sql
         LeggiDati("(" & sql & ")", sql)

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Somma i valori delle colonne.
         SommaValoriColonne()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub AggiornaDatiMese()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         ' Crea la stringa di selezione dei dati.
         Dim anno As Integer = Now.Year
         Dim mese As Integer = Now.Month
         Dim inizioMese As String = CFormatta.FormattaData("01/" & mese & "/" & anno)
         Dim ultimoGiornoMese As String = DateTime.DaysInMonth(anno, mese)
         Dim fineMese As String = CFormatta.FormattaData(ultimoGiornoMese & "/" & mese & "/" & anno)

         sql = String.Format("SELECT TOP {0} * FROM {1} WHERE DataArrivo BETWEEN #{2}# AND #{3}# ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI, inizioMese, fineMese)
         repSql = sql
         LeggiDati("(" & sql & ")", sql)

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Somma i valori delle colonne.
         SommaValoriColonne()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub AggiornaDatiAnno()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         ' Crea la stringa di selezione dei dati.
         Dim Anno As String = Year(Now)
         Dim inizioAnno As String = CFormatta.FormattaData("01/01/" & Anno)
         Dim ultimoGiornoAnno As String = DateTime.DaysInMonth(Anno, 12)
         Dim fineAnno As String = CFormatta.FormattaData(ultimoGiornoAnno & "/12/" & Anno)

         sql = String.Format("SELECT TOP {0} * FROM {1} WHERE DataArrivo BETWEEN #{2}# AND #{3}# ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI, inizioAnno, fineAnno)
         repSql = sql
         LeggiDati("(" & sql & ")", sql)

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Somma i valori delle colonne.
         SommaValoriColonne()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub AggiornaDatiPeriodo()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         Dim frmFiltroPerido As New FiltroPeriodo()
         If frmFiltroPerido.ShowDialog = Windows.Forms.DialogResult.OK Then

            ' Crea la stringa di selezione dei dati.
            Dim dataDal As String = CFormatta.FormattaData(frmFiltroPerido.eui_dtpDataDal.Value.GetValueOrDefault.ToShortDateString)
            Dim dataAl As String = CFormatta.FormattaData(frmFiltroPerido.eui_dtpDataAl.Value.GetValueOrDefault.ToShortDateString)
            sql = String.Format("SELECT TOP {0} * FROM {1} WHERE DataArrivo BETWEEN #{2}# AND #{3}# ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI, dataDal, dataAl)
            repSql = sql
            LeggiDati("(" & sql & ")", sql)

            ' Se nella tabella non ci sono record disattiva i pulsanti.
            ConvalidaDati()

            ' Aggiorna l 'intestazione della griglia dati.
            AggIntGriglia()

            ' Aggiorna il titolo della finestra.
            AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

            ' Somma i valori delle colonne.
            SommaValoriColonne()

         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub AggiornaDatiArrivoOggi()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         ' Crea la stringa di selezione dei dati.
         Dim oggi As String = Today.ToShortDateString

         sql = String.Format("SELECT TOP {0} * FROM {1} WHERE DataArrivo = #{2}# ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI, oggi)
         repSql = sql
         LeggiDati("(" & sql & ")", sql)

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Somma i valori delle colonne.
         SommaValoriColonne()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub AggiornaDatiPartenzaOggi()
      Try
         ' Rimuove i dati di un'eventuale ricerca.
         TestoRicerca.Text = String.Empty

         ' Crea la stringa di selezione dei dati.
         Dim oggi As String = Today.ToShortDateString

         sql = String.Format("SELECT TOP {0} * FROM {1} WHERE DataPartenza = #{2}# ORDER BY Numero ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI, oggi)
         repSql = sql
         LeggiDati("(" & sql & ")", sql)

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Somma i valori delle colonne.
         SommaValoriColonne()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub SommaValoriColonne()
      ' Somma i valori delle rispettive colonne.
      txtTotaleNotti.Text = SommaColonna(DataGrid1, COLONNA_NOTTI, numRecord).ToString
      txtTotaleAdulti.Text = SommaColonna(DataGrid1, COLONNA_ADULTI, numRecord).ToString
      txtTotaleNeonati.Text = SommaColonna(DataGrid1, COLONNA_NEONATI, numRecord).ToString
      txtTotaleBambini.Text = SommaColonna(DataGrid1, COLONNA_BAMBINI, numRecord).ToString
      txtTotaleRagazzi.Text = SommaColonna(DataGrid1, COLONNA_RAGAZZI, numRecord).ToString

      txtTotaleImporto.Text = CFormatta.FormattaEuro(SommaColonna(DataGrid1, COLONNA_IMPORTO_TOTALE, numRecord))
   End Sub

   Public Sub ImpostaComandi()
      If numRecord = 0 Then
         ' Disattiva i pulsanti appropriati.
         g_frmMain.eui_Strumenti_Modifica.Enabled = False
         g_frmMain.eui_Strumenti_Elimina.Enabled = False
         g_frmMain.eui_Strumenti_Duplica.Enabled = False
         g_frmMain.eui_Strumenti_Aggiorna.Enabled = False
         g_frmMain.eui_Strumenti_Esporta.Enabled = False
         g_frmMain.eui_Strumenti_Stampa_Anteprima.Enabled = False
         g_frmMain.eui_Strumenti_Stampa_Elenco.Enabled = False
      Else
         ' Attiva i pulsanti appropriati.
         g_frmMain.eui_Strumenti_Modifica.Enabled = True
         g_frmMain.eui_Strumenti_Elimina.Enabled = True
         g_frmMain.eui_Strumenti_Duplica.Enabled = False
         g_frmMain.eui_Strumenti_Aggiorna.Enabled = True
         g_frmMain.eui_Strumenti_Esporta.Enabled = True
         g_frmMain.eui_Strumenti_Stampa_Anteprima.Enabled = True
         g_frmMain.eui_Strumenti_Stampa_Elenco.Enabled = True
      End If
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub ConvalidaDati()
      'If ImpostaFunzioniOperatore(Finestra.Documenti) = True Then
      ImpostaComandi()
      'End If
   End Sub

   Private Sub ApriDati(ByVal nomeFrm As String, ByVal val As String)
      Try
         ' Modifica il cursore del mouse.
         Cursor.Current = Cursors.AppStarting

         ' Per la versione demo.
         ' Se � un nuovo inserimento verifica il numero dei record.
         If val = String.Empty Then
            If g_VerDemo = True Then
               ' Test per la versione demo.
               If VerificaNumRecord(LeggiNumRecord(TAB_PRENOTAZIONI)) = True Then
                  Exit Sub
               End If
            End If
         End If

         g_frmPrenCamera = New frmPrenCamera(nomeFrm)
         g_frmPrenCamera.Tag = val
         g_frmPrenCamera.ShowDialog()

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Public Sub AggIntGriglia()
      Try
         If numRecord <> 0 Then
            DataGrid1.CaptionText = Strings.UCase(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 3) & " " &
                                                  DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4) & " - Prenotazione N. " &
                                                  DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1) & " del " &
                                                  DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2))
         Else
            DataGrid1.CaptionText = ""
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Function LeggiNumeroMax(ByVal tabella As String, ByVal tipoDoc As String) As Integer
      Dim closeOnExit As Boolean
      Dim numRec As Integer

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Ottiene il numero di record.
         'cmd.CommandText = String.Format("SELECT MAX(NumDoc) FROM {0} WHERE TipoDoc = '{1}'", tabella, tipoDoc)

         ' Ottiene i dati per l'anno corrente.
         Dim Anno As String = Year(Now)
         Dim primoGiornoAnno As String = CFormatta.FormattaData("01/01/" & Anno)
         Dim numUltimoGiornoAnno As String = DateTime.DaysInMonth(Anno, 12)
         Dim ultimoGiornoAnno As String = CFormatta.FormattaData(numUltimoGiornoAnno & "/12/" & Anno)

         cmd.CommandText = String.Format("SELECT MAX(NumDoc) FROM {0} WHERE TipoDoc = '{1}' AND DataDoc BETWEEN #{2}# AND #{3}#", tabella, tipoDoc, primoGiornoAnno, ultimoGiornoAnno)

         If IsDBNull(cmd.ExecuteScalar()) = False Then
            numRec = CInt(cmd.ExecuteScalar())
         Else
            numRec = 0
         End If

         Return numRec

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   Public Sub AggTitoloFinestra(ByVal titolo As String)
      ' Imposta il titolo della tabella.
      Me.Text = titolo & " (n� totale: " & numRecord & ")"
   End Sub

   Private Sub CreaColonne(ByVal tabella As String)
      Try
         Dim gridStyle As New DataGridTableStyle
         gridStyle.MappingName = tabella

         ' Id - Codice
         Dim codiceStyle As New ColonnaColorata(DataGrid1, Color.FromArgb(COLORE_ROSA), Color.Black)
         codiceStyle.MappingName = "Id"
         codiceStyle.HeaderText = "Codice"
         codiceStyle.Width = 50
         codiceStyle.NullText = ""
         codiceStyle.Alignment = HorizontalAlignment.Right
         codiceStyle.TextBox.BackColor = Color.FromArgb(COLORE_ROSA)
         gridStyle.GridColumnStyles.Add(codiceStyle)
         ' Numero
         Dim numeroStyle As New ColonnaColorata(DataGrid1, Color.FromArgb(COLORE_ROSA), Color.Black)
         numeroStyle.MappingName = "Numero"
         numeroStyle.HeaderText = "Numero"
         numeroStyle.Width = 60
         numeroStyle.NullText = ""
         numeroStyle.Alignment = HorizontalAlignment.Right
         numeroStyle.TextBox.BackColor = Color.FromArgb(COLORE_ROSA)
         gridStyle.GridColumnStyles.Add(numeroStyle)
         'Data
         Dim dataStyle As New DataGridTextBoxColumn
         dataStyle.MappingName = "Data"
         dataStyle.HeaderText = "Data"
         dataStyle.Width = 80
         dataStyle.NullText = ""
         dataStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(dataStyle)
         ' Ragione Sociale / Cognome
         Dim intestatariostyle As New ColonnaColorata(DataGrid1, Color.FromArgb(COLORE_AZZURRO), Color.Black)
         intestatariostyle.MappingName = "Cognome"
         intestatariostyle.HeaderText = "Rag. Soc. / Cognome"
         intestatariostyle.Width = 150
         intestatariostyle.NullText = ""
         intestatariostyle.TextBox.BackColor = Color.FromArgb(COLORE_AZZURRO)
         gridStyle.GridColumnStyles.Add(intestatariostyle)
         ' Nome
         Dim nomestyle As New ColonnaColorata(DataGrid1, Color.FromArgb(COLORE_AZZURRO), Color.Black)
         nomestyle.MappingName = "Nome"
         nomestyle.HeaderText = "Nome"
         nomestyle.Width = 100
         nomestyle.NullText = ""
         nomestyle.TextBox.BackColor = Color.FromArgb(COLORE_AZZURRO)
         gridStyle.GridColumnStyles.Add(nomestyle)
         ' Data arrivo
         Dim dataArrivoStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Red)
         dataArrivoStyle.MappingName = "DataArrivo"
         dataArrivoStyle.HeaderText = "Data di arrivo"
         dataArrivoStyle.Width = 90
         dataArrivoStyle.NullText = ""
         dataArrivoStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(dataArrivoStyle)
         ' Data partenza
         Dim dataPartenzaStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Green)
         dataPartenzaStyle.MappingName = "DataPartenza"
         dataPartenzaStyle.HeaderText = "Data di partenza"
         dataPartenzaStyle.Width = 90
         dataPartenzaStyle.NullText = ""
         dataPartenzaStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(dataPartenzaStyle)
         ' Numero notti.
         Dim nottiStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Red)
         nottiStyle.MappingName = "NumeroNotti"
         nottiStyle.HeaderText = "Notti"
         nottiStyle.Width = 50
         nottiStyle.NullText = ""
         nottiStyle.Alignment = HorizontalAlignment.Right
         nottiStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(nottiStyle)
         ' Adulti.
         Dim adultiStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Blue)
         adultiStyle.MappingName = "Adulti"
         adultiStyle.HeaderText = "Adulti"
         adultiStyle.Width = 50
         adultiStyle.NullText = ""
         adultiStyle.Alignment = HorizontalAlignment.Right
         adultiStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(adultiStyle)
         ' Neonati.
         Dim neonatiStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Blue)
         neonatiStyle.MappingName = "Neonati"
         neonatiStyle.HeaderText = "Neonati"
         neonatiStyle.Width = 50
         neonatiStyle.NullText = ""
         neonatiStyle.Alignment = HorizontalAlignment.Right
         neonatiStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(neonatiStyle)
         ' Bambini.
         Dim bambiniStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Blue)
         bambiniStyle.MappingName = "Bambini"
         bambiniStyle.HeaderText = "Bambini"
         bambiniStyle.Width = 50
         bambiniStyle.NullText = ""
         bambiniStyle.Alignment = HorizontalAlignment.Right
         bambiniStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(bambiniStyle)
         ' Ragazzi.
         Dim ragazziStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Blue)
         ragazziStyle.MappingName = "Ragazzi"
         ragazziStyle.HeaderText = "Ragazzi"
         ragazziStyle.Width = 50
         ragazziStyle.NullText = ""
         ragazziStyle.Alignment = HorizontalAlignment.Right
         ragazziStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(ragazziStyle)
         ' Numero camera.
         Dim numCameraStyle As New DataGridTextBoxColumn
         numCameraStyle.MappingName = "NumeroCamera"
         numCameraStyle.HeaderText = "Camera"
         numCameraStyle.Width = 60
         numCameraStyle.NullText = ""
         numCameraStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(numCameraStyle)
         ' Arrangiamento.
         Dim trattamentoPagStyle As New DataGridTextBoxColumn
         trattamentoPagStyle.MappingName = "Trattamento"
         trattamentoPagStyle.HeaderText = "Arrangiamento"
         trattamentoPagStyle.Width = 150
         trattamentoPagStyle.NullText = ""
         trattamentoPagStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(trattamentoPagStyle)
         ' Acconto.
         Dim accontoStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Red)
         accontoStyle.MappingName = "AccontoCamera"
         accontoStyle.HeaderText = "Acconto"
         accontoStyle.Width = 80
         accontoStyle.NullText = ""
         accontoStyle.Format = "##,##0.00"
         accontoStyle.Alignment = HorizontalAlignment.Right
         accontoStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(accontoStyle)
         ' Totale conto
         Dim totContoStyle As New ColonnaColorata(DataGrid1, Color.White, Color.Red)
         totContoStyle.MappingName = "TotaleConto"
         totContoStyle.HeaderText = "Totale conto"
         totContoStyle.Width = 80
         totContoStyle.NullText = ""
         totContoStyle.Format = "##,##0.00"
         totContoStyle.Alignment = HorizontalAlignment.Right
         totContoStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(totContoStyle)
         ' Stato.
         Dim statoStyle As New DataGridTextBoxColumn
         statoStyle.MappingName = "Stato"
         statoStyle.HeaderText = "Stato prenotazione"
         statoStyle.Width = 140
         statoStyle.NullText = ""
         statoStyle.TextBox.BackColor = Color.White
         gridStyle.GridColumnStyles.Add(statoStyle)
         ' Colore.
         Dim coloreStyle As New CellaColorata(DataGrid1)
         coloreStyle.MappingName = "Colore"
         coloreStyle.HeaderText = "Colore"
         coloreStyle.Width = 50
         coloreStyle.NullText = ""
         coloreStyle.TextBox.BackColor = Color.White
         coloreStyle.TextBox.ForeColor = Color.White
         gridStyle.GridColumnStyles.Add(coloreStyle)

         DataGrid1.TableStyles.Clear()
         DataGrid1.TableStyles.Add(gridStyle)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub FiltraDati(ByVal testoRicerca As String, ByVal campoRicerca As String)
      Try
         Dim sql As String

         testoRicerca = FormattaApici(testoRicerca)

         Select Case campoRicerca
            Case "Codice"
               campoRicerca = "Id"
            Case "Rag, Soc. / Cognome"
               campoRicerca = "Cognome"
            Case "Data di arrivo"
               campoRicerca = "DataArrivo"
            Case "Data di partenza"
               campoRicerca = "DataPartenza"
            Case "Notti"
               campoRicerca = "NumeroNotti"
            Case "Arrangiamento"
               campoRicerca = "Trattamento"
            Case "Acconto"
               campoRicerca = "AccontoCamera"
            Case "Totale conto"
               campoRicerca = "TotaleConto"
            Case "Camera"
               campoRicerca = "NumeroCamera"
            Case "Stato prenotazione"
               campoRicerca = "Stato"
         End Select

         If testoRicerca <> "" Then
            ' Rimuove eventuali filtri impostati.
            g_frmMain.eui_Strumenti_Periodo_Tutte.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Mese.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Anno.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Arrivo.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Partenza.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_DalAl.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_DalAl.Text = TESTO_FILTRO_PERIODO

            ' Crea la stringa sql.
            sql = String.Format("SELECT * FROM {0} WHERE {1} LIKE '" & testoRicerca & "%' ORDER BY {2} ASC", TAB_PRENOTAZIONI, campoRicerca, campoRicerca)
            repSql = String.Format("SELECT * FROM {0} WHERE {1} LIKE '" & testoRicerca & "%' ORDER BY {2} ASC", TAB_PRENOTAZIONI, campoRicerca, campoRicerca)

            ' Legge i dati e ottiene il numero totale dei record.
            LeggiDati("(" & sql & ")", sql)
         Else
            ' Rimuove eventuali filtri impostati.
            g_frmMain.eui_Strumenti_Periodo_Tutte.Pressed = True
            g_frmMain.eui_Strumenti_Periodo_Mese.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Anno.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Arrivo.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_Partenza.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_DalAl.Pressed = False
            g_frmMain.eui_Strumenti_Periodo_DalAl.Text = TESTO_FILTRO_PERIODO

            sql = String.Format("SELECT TOP {0} * FROM {1} ORDER BY DataArrivo ASC", DIM_PAGINA_GRANDE, TAB_PRENOTAZIONI)
            repSql = String.Format("SELECT * FROM {0} ORDER BY DataArrivo ASC", TAB_PRENOTAZIONI)

            ' Legge i dati e ottiene il numero totale dei record.
            LeggiDati(TAB_PRENOTAZIONI, sql)
         End If

         ' Somma i valori delle colonne.
         SommaValoriColonne()

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub CaricaCampiRic()
      Try
         CampoRicerca.Items.Add("Codice")
         CampoRicerca.Items.Add("Numero")
         CampoRicerca.Items.Add("Data")
         CampoRicerca.Items.Add("Rag, Soc. / Cognome")
         CampoRicerca.Items.Add("Nome")
         CampoRicerca.Items.Add("Data di arrivo")
         CampoRicerca.Items.Add("Data di partenza")
         CampoRicerca.Items.Add("Notti")
         CampoRicerca.Items.Add("Adulti")
         CampoRicerca.Items.Add("Neonati")
         CampoRicerca.Items.Add("Bambini")
         CampoRicerca.Items.Add("Ragazzi")
         CampoRicerca.Items.Add("Arrangiamento")
         CampoRicerca.Items.Add("Acconto")
         CampoRicerca.Items.Add("Totale conto")
         CampoRicerca.Items.Add("Camera")
         CampoRicerca.Items.Add("Stato prenotazione")

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)
      End Try
   End Sub

   Private Function LeggiNumRecord(ByVal tabella As String) As Integer
      Dim closeOnExit As Boolean
      Dim numRec As Integer

      Try
         ' Se necessario apre la connessione.
         If cn.State = ConnectionState.Closed Then
            cn.Open()
            closeOnExit = True
         End If

         ' Ottiene il numero di record.
         cmd.CommandText = String.Format("SELECT COUNT(*) FROM {0}", tabella)
         numRec = CInt(cmd.ExecuteScalar())

         Return numRec

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      Finally
         ' Chiude la connessione.
         cn.Close()

      End Try
   End Function

   ' A_TODO: HOTEL - da modificare!
   Private Sub StampaDocumento(ByVal nomeDoc As String, ByVal tabella As String, ByVal sqlRep As String)
      Try

         If PrintDialog1.ShowDialog() = DialogResult.OK Then

            'Utilizzare il modello di oggetti ADO .NET per impostare le informazioni di connessione. 
            Dim cn As New OleDbConnection(ConnString)

            cn.Open()

            Dim oleAdapter As New OleDbDataAdapter

            oleAdapter.SelectCommand = New OleDbCommand(sqlRep, cn)

            Dim ds As New Dataset1

            ds.Clear()

            oleAdapter.Fill(ds, tabella)

            Dim rep As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            rep.Load(Application.StartupPath & nomeDoc)

            rep.SetDataSource(ds)

            rep.PrintToPrinter(PrintDialog1.PrinterSettings.Copies, True,
                               PrintDialog1.PrinterSettings.FromPage,
                               PrintDialog1.PrinterSettings.ToPage)

            cn.Close()
         End If

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   Private Sub ElencoPrenCamere_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

#Region "Strumenti di Modifica - (Condivisa) "
      ' Visualizza i comandi Strumenti di modifica sul Ribbon.
      g_frmMain.rtgStrumentiModifica.Visible = True

#Region "Modifica - (Condivisa) "
      ' TabPage.
      g_frmMain.eui_StrumentiModifica.Visible = True

      ' Dati.
      g_frmMain.eui_Strumenti_Nuovo.Visible = True
      g_frmMain.eui_Strumenti_Modifica.Visible = True
      g_frmMain.eui_Strumenti_Duplica.Visible = False
      g_frmMain.eui_Strumenti_Elimina.Visible = True
      g_frmMain.eui_Strumenti_Annulla.Visible = False
      g_frmMain.eui_Strumenti_Aggiorna.Visible = True
      g_frmMain.eui_Strumenti_Esporta.Visible = True

      ' Stampa.
      g_frmMain.eui_Strumenti_Stampa_Anteprima.Visible = True
      g_frmMain.eui_Strumenti_Stampa_Elenco.Visible = True

#End Region

#Region "Periodo - (Condivisa) "
      ' TabPage.
      g_frmMain.eui_StrumentiPeriodo.Visible = True

      ' Periodo.
      g_frmMain.eui_Strumenti_Periodo_Tutte.Visible = True
      g_frmMain.eui_Strumenti_Periodo_Anno.Visible = True
      g_frmMain.eui_Strumenti_Periodo_Mese.Visible = True
      g_frmMain.eui_Strumenti_Periodo_DalAl.Visible = True
      g_frmMain.eui_Strumenti_Periodo_Sep1.Visible = True
      g_frmMain.eui_Strumenti_Periodo_Arrivo.Visible = True
      g_frmMain.eui_Strumenti_Periodo_Partenza.Visible = True

      ' Visualizza.
      g_frmMain.eui_Strumenti_Visualizza_Presenze.Visible = True
      g_frmMain.eui_rib_Visualizza.Visible = True

#End Region

#Region "Documenti "
      ' TabPage.
      g_frmMain.eui_StrumentiDocumenti.Visible = True

#End Region

#Region "Sospesi / Buoni pasto "
      ' TabPage.
      g_frmMain.eui_StrumentiSospesiBuoni.Visible = False

#End Region

      ' Serve ad attivare/disattivare i vari comandi in base ai dati visualizzati.
      AggiornaDati()

#End Region

   End Sub

   Private Sub ElencoPrenCamere_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
#Region "Strumenti di Modifica - (Condivisa) "
      ' Visualizza i comandi Strumenti di modifica sul Ribbon.
      g_frmMain.rtgStrumentiModifica.Visible = False

#End Region

   End Sub

   Private Sub ElencoPrenCamere_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
      Try
         SalvaDatiConfig()

         ' Ottiene l'effetto a scomparsa.
         Me.WindowState = FormWindowState.Minimized

         ' Rimuove la finestra aperta dal menu Finestra/Seleziona.
         g_frmMain.RimuoviFormMenuSeleziona(g_frmPrenCamere)

         ' Distrugge l'oggetto e libera le risorse.
         g_frmPrenCamere.Dispose()
         g_frmPrenCamere = Nothing

         ' Registra loperazione effettuata dall'operatore identificato.
         g_frmMain.RegistraOperazione(TipoOperazione.Chiudi, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)
      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub ElencoPrenCamere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Try
         ' Imposta l'icona della finestra in base al prodotto installato.
         ImpostaIcona(Me)

         DatiConfig = New AppConfig
         DatiConfig.ConfigType = ConfigFileType.AppConfig
         ' Imposta le dimensioni del form.
         LeggiDatiConfig()

         ' Crea le colonne della griglia dati.
         CreaColonne(TAB_PRENOTAZIONI)

         ' Carica l'elenco dei campi di ricerca.
         CaricaCampiRic()

         ' Imposta l'elenco dei campi di ricerca sul valore predefinito.
         CampoRicerca.SelectedIndex = 0

         ' Select Case filtroDati
         '   Case "Tutti"
         '      tbrTutti.Pushed = True
         '      tbrPeriodo.Pushed = False
         '      tbrMese.Pushed = False
         '      tbrAnno.Pushed = False
         '      tbrSospesi.Pushed = False
         '      NascondiDate()
         ' Filtra i dati in base al testo digitato.
         FiltraDati(TestoRicerca.Text, CampoRicerca.Text)
         '   Case "Mese"
         '      tbrMese.Pushed = True
         '      tbrTutti.Pushed = False
         '      tbrPeriodo.Pushed = False
         '      tbrAnno.Pushed = False
         '      tbrSospesi.Pushed = False
         '      NascondiDate()
         '      ' Aggiorna la griglia dati.
         '      AggiornaDatiMese()
         '   Case "Anno"
         '      tbrAnno.Pushed = True
         '      tbrTutti.Pushed = False
         '      tbrPeriodo.Pushed = False
         '      tbrMese.Pushed = False
         '      tbrSospesi.Pushed = False
         '      NascondiDate()
         '      ' Aggiorna la griglia dati.
         '      AggiornaDatiAnno()
         '   Case "Periodo"
         '      tbrPeriodo.Pushed = True
         '      tbrTutti.Pushed = False
         '      tbrMese.Pushed = False
         '      tbrAnno.Pushed = False
         '      tbrSospesi.Pushed = False
         '      VisualizzaDate()
         '      ' Aggiorna la griglia dati.
         '      AggiornaDatiPeriodo()
         '   Case "Sospesi"
         '      tbrSospesi.Pushed = True
         '      tbrTutti.Pushed = False
         '      tbrMese.Pushed = False
         '      tbrAnno.Pushed = False
         '      tbrPeriodo.Pushed = False
         '      NascondiDate()
         '      ' Aggiorna la griglia dati.
         '      AggiornaDatiSospesi()
         'End Select

         ' Se nella tabella non ci sono record disattiva i pulsanti.
         ConvalidaDati()

         'If tbrModifica.Enabled = True Then
         '   ' Attiva/disattiva il pulsante per annullare un documento.
         '   AttivaDisattivaAnnullaDoc()

         '   ' Attiva/disattiva il pulsanti per i sospesi.
         '   AttivaDisattivaSospeso()
         '   AttivaDisattivaPassaSospeso()
         '   AttivaDisattivaAnnullaSospeso()

         '   ' Attiva/Disattiva il pulsante per i Buoni.
         '   AttivaDisattivaBuoni()
         'End If

         ' Aggiorna il titolo della finestra.
         AggTitoloFinestra(TITOLO_FINESTRA_ELENCO_PREN_CAMERE)

         ' Aggiorna i valori per gli Ospiti e le camere.
         AggiornaValoriOspiti()

         ' Aggiorna l'intestazione della griglia dati.
         AggIntGriglia()

         ' Registra loperazione effettuata dall'operatore identificato.
         'g_frmMain.RegistraOperazione(TipoOperazione.Apri, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

      End Try
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub DataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
      ' Visualizza un'intestazione per la griglia dati.
      AggIntGriglia()

      ' Attiva/disattiva il pulsante per annullare un documento.
      'AttivaDisattivaAnnullaDoc()

      '' Attiva/disattiva i pulsanti per i sospesi.
      'AttivaDisattivaSospeso()
      'AttivaDisattivaPassaSospeso()
      'AttivaDisattivaAnnullaSospeso()

      '' Attiva/Disattiva il pulsante per i Buoni.
      'AttivaDisattivaBuoni()
   End Sub

   Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs)
      Select Case e.Button.Tag
         Case "Tutti"
            'tbrPeriodo.Pushed = False
            'tbrMese.Pushed = False
            'tbrAnno.Pushed = False
            'tbrSospesi.Pushed = False
            'filtroDati = "Tutti"
            'NascondiDate()
            'TestoRicerca.Text = ""
            '' Filtra i dati in base al testo digitato.
            'FiltraDati(TestoRicerca.Text, CampoRicerca.Text)

         Case "Sospesi"
            'tbrTutti.Pushed = False
            'tbrPeriodo.Pushed = False
            'tbrMese.Pushed = False
            'tbrAnno.Pushed = False
            'filtroDati = "Sospesi"
            'NascondiDate()
            'TestoRicerca.Text = ""
            'AggiornaDatiSospesi()

         Case "Periodo"
            'tbrTutti.Pushed = False
            'tbrMese.Pushed = False
            'tbrAnno.Pushed = False
            'tbrSospesi.Pushed = False
            'filtroDati = "Periodo"
            'VisualizzaDate()
            'TestoRicerca.Text = ""
            'AggiornaDatiPeriodo()

         Case "Mese"
            'tbrTutti.Pushed = False
            'tbrPeriodo.Pushed = False
            'tbrAnno.Pushed = False
            'tbrSospesi.Pushed = False
            'filtroDati = "Mese"
            'NascondiDate()
            'TestoRicerca.Text = ""
            'AggiornaDatiMese()

         Case "Anno"
            'tbrTutti.Pushed = False
            'tbrPeriodo.Pushed = False
            'tbrMese.Pushed = False
            'tbrSospesi.Pushed = False
            'filtroDati = "Anno"
            'NascondiDate()
            'TestoRicerca.Text = ""
            'AggiornaDatiAnno()

         Case "Annulla"
            ' Annulla l'ultimo documento selezionato.
            'AnnullaDocumento()

         Case "Nuovo"
            '' Apre la finestra per l'inserimento di nuovi dati.
            'ApriDati("")

            '' Se nella tabella non ci sono record disattiva i pulsanti.
            'ConvalidaDati()

         Case "Modifica"
            '' Apre la finestra per l'inserimento di nuovi dati.
            'ApriDati(CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0)))

         Case "Elimina"
            ' NON UTILIZZATA.
            ' Elimina il valore selezionato.
            'EliminaDati(TAB_DOCUMENTI, DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0))

         Case "Buoni"
            ' Apre l'elenco dei buoni contenuti nel documento selezionato.
            'ApriElencoBuoni()

         Case "Sospeso"
            ' Apre la finestra per l'incasso del sospeso.
            Dim frm As New IncassaSospeso(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0),
                                          DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 1),
                                          DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 2),
                                          DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 4),
                                          DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 5),
                                          DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 8))
            frm.ShowDialog()

         Case "PassaSospeso"
            ' Apre la finestra per l'incasso del sospeso.
            'PassaSospeso(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0), _
            '             DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 7))

         Case "AnnullaSospeso"
            ' Apre la finestra per l'incasso del sospeso.
            'AnnullaSospeso(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0))

         Case "Stampa"
            ' Registra loperazione effettuata dall'operatore identificato.
            g_frmMain.RegistraOperazione(TipoOperazione.Stampa, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

            StampaDocumento(PERCORSO_REP_DOC, TAB_PRENOTAZIONI, repSql)

         Case "Anteprima"
            ' Registra loperazione effettuata dall'operatore identificato.
            g_frmMain.RegistraOperazione(TipoOperazione.Anteprima, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

            g_frmMain.ApriReports(repSql, TAB_PRENOTAZIONI, PERCORSO_REP_DOC)

         Case "Primo"
            '' Crea la stringa sql.
            'sql = String.Format("SELECT TOP {0} * FROM {1} ORDER BY Id", dimPagina, TAB_ACQUISTI)

            '' Visualizza la prima pagina di dati.
            'VisualizzaPagina(1, sql)

            '' Visualizza un'intestazione per la griglia dati.
            'AggIntGriglia()

         Case "Precedente"
            '' Crea la stringa sql.
            'sql = String.Format("SELECT * FROM {0} WHERE Id IN (SELECT TOP {1} Id FROM {2} WHERE Id < {3} ORDER BY Id DESC) ORDER BY Id", TAB_ACQUISTI, dimPagina, TAB_ACQUISTI, dt.Rows(0)("Id"))

            '' Visualizza la pagina di dati precedente.
            'VisualizzaPagina(pagCorrente - 1, sql)

            '' Visualizza un'intestazione per la griglia dati.
            'AggIntGriglia()

         Case "Successivo"
            '' Crea la stringa sql.
            'sql = String.Format("SELECT TOP {0} * FROM {1} WHERE Id > {2} ORDER BY Id", dimPagina, TAB_ACQUISTI, dt.Rows(dt.Rows.Count - 1)("Id"))

            '' Visualizza la pagina di dati successiva.
            'VisualizzaPagina(pagCorrente + 1, sql)

            '' Visualizza un'intestazione per la griglia dati.
            'AggIntGriglia()

         Case "Ultimo"
            'Dim num As Integer = numRecord - dimPagina * (numPagine - 1)

            '' Crea la stringa sql.
            'sql = String.Format("SELECT * FROM {0} WHERE Id IN (SELECT TOP {1} Id FROM {2} ORDER BY Id DESC) ORDER BY Id", TAB_ACQUISTI, num, TAB_ACQUISTI)

            '' Visualizza l'ultima pagina di dati.
            'VisualizzaPagina(numPagine, sql)

            '' Visualizza un'intestazione per la griglia dati.
            'AggIntGriglia()

         Case "Aggiorna"
            ' Registra loperazione effettuata dall'operatore identificato.
            g_frmMain.RegistraOperazione(TipoOperazione.Aggiorna, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

            'If tbrSospesi.Pushed = True Then
            '   ' Aggiorna la griglia dati.
            '   AggiornaDatiSospesi()
            '   Exit Sub
            'ElseIf tbrMese.Pushed = True Then
            '   ' Aggiorna la griglia dati.
            '   AggiornaDatiMese()
            '   Exit Sub
            'ElseIf tbrAnno.Pushed = True Then
            '   ' Aggiorna la griglia dati.
            '   AggiornaDatiAnno()
            '   Exit Sub
            'ElseIf tbrPeriodo.Pushed = True Then
            '   ' Aggiorna la griglia dati.
            '   AggiornaDatiPeriodo()
            '   Exit Sub
            'Else
            '   ' Aggiorna la griglia dati.
            '   AggiornaDati()
            '   Exit Sub
            'End If
      End Select
   End Sub

   Private Sub TestoRicerca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestoRicerca.TextChanged
      ' Filtra i dati in base al testo digitato.
      FiltraDati(TestoRicerca.Text, CampoRicerca.Text)
   End Sub

   Private Sub CampoRicerca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CampoRicerca.SelectedIndexChanged
      ' Filtra i dati in base al testo digitato.
      FiltraDati(TestoRicerca.Text, CampoRicerca.Text)
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
      'If Modifica.Enabled = True Then
      '   ' Registra loperazione efettuata dall'operatore identificato.
      '   registraModifica()

      '   ' Apre la finestra Cliente per la modifica dei dati.
      '   ApriDati(CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0)))
      'End If
   End Sub

   Private Sub dtpDal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      AggiornaDatiPeriodo()
   End Sub

   Private Sub dtpAl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      AggiornaDatiPeriodo()
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub Nuovo()
      ' Apre la finestra per l'inserimento di nuovi dati.
      ApriDati(Me.Name, "")

      ' Se nella tabella non ci sono record disattiva i pulsanti.
      ConvalidaDati()

      ' Registra loperazione effettuata dall'operatore identificato.
      'g_frmMain.RegistraOperazione(TipoOperazione.Aggiorna, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)
   End Sub

   ' A_TODO: HOTEL - da modificare!
   Public Sub Modifica()
      ' Apre la finestra Cliente per la modifica dei dati.
      ApriDati(Me.Name, CStr(DataGrid1.Item(DataGrid1.CurrentCell.RowNumber, 0)))

      ' Registra loperazione effettuata dall'operatore identificato.
      'g_frmMain.RegistraOperazione(TipoOperazione.Aggiorna, STR_CONTABILITA_DOCUMENTI, MODULO_CONTABILITA_DOCUMENTI)

   End Sub

   Public Function LeggiNumeroOspitiArrivo(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleOspiti As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT * FROM " & tabella & " WHERE DataArrivo = #" & dataCorrente & "# ORDER BY Id ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read()
            ' Calcola il numero di persone totali.
            Dim adulti As Integer = Convert.ToInt32(dr.Item("Adulti"))
            Dim ragazzi As Integer = Convert.ToInt32(dr.Item("Ragazzi"))
            Dim bambini As Integer = Convert.ToInt32(dr.Item("Bambini"))
            Dim neonati As Integer = Convert.ToInt32(dr.Item("Neonati"))
            Dim numPersone As Integer = adulti + ragazzi + bambini + neonati

            ' Calcola il totale degli ospiti.
            totaleOspiti = totaleOspiti + numPersone
         Loop

         Return totaleOspiti

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Public Function LeggiNumeroOspitiPartenza(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleOspiti As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT * FROM " & tabella & " WHERE DataPartenza = #" & dataCorrente & "# ORDER BY Id ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read()
            ' Calcola il numero di persone totali.
            Dim adulti As Integer = Convert.ToInt32(dr.Item("Adulti"))
            Dim ragazzi As Integer = Convert.ToInt32(dr.Item("Ragazzi"))
            Dim bambini As Integer = Convert.ToInt32(dr.Item("Bambini"))
            Dim neonati As Integer = Convert.ToInt32(dr.Item("Neonati"))
            Dim numPersone As Integer = adulti + ragazzi + bambini + neonati

            ' Calcola il totale degli ospiti.
            totaleOspiti = totaleOspiti + numPersone
         Loop

         Return totaleOspiti

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Public Function LeggiNumeroOspitiInCasa(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleOspiti As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT * FROM " & tabella & " WHERE DataArrivo < #" & dataCorrente & "# AND DataPartenza > #" & dataCorrente & "# ORDER BY Id ASC", cn)
         Dim dr As OleDbDataReader = cmd.ExecuteReader()

         Do While dr.Read()
            ' Calcola il numero di persone totali.
            Dim adulti As Integer = Convert.ToInt32(dr.Item("Adulti"))
            Dim ragazzi As Integer = Convert.ToInt32(dr.Item("Ragazzi"))
            Dim bambini As Integer = Convert.ToInt32(dr.Item("Bambini"))
            Dim neonati As Integer = Convert.ToInt32(dr.Item("Neonati"))
            Dim numPersone As Integer = adulti + ragazzi + bambini + neonati

            ' Calcola il totale degli ospiti.
            totaleOspiti = totaleOspiti + numPersone
         Loop

         Return totaleOspiti

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Public Function LeggiNumeroCamereOccupate(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleCamereOccupate As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM " & tabella & " WHERE DataArrivo < #" & dataCorrente & "# AND DataPartenza > #" & dataCorrente & "#", cn)
         totaleCamereOccupate = Convert.ToInt32(cmd.ExecuteScalar())

         Return totaleCamereOccupate

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Public Function LeggiNumeroCamereLiberate(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleCamereLiberate As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM " & tabella & " WHERE DataPartenza = #" & dataCorrente & "#", cn)
         totaleCamereLiberate = Convert.ToInt32(cmd.ExecuteScalar())

         Return totaleCamereLiberate

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Public Function LeggiNumeroCamereInConsegna(ByVal tabella As String) As Integer
      ' Dichiara un oggetto connessione.
      Dim cn As New OleDbConnection(ConnString)
      Dim totaleCamereInConsegna As Integer
      Dim dataCorrente As String = Today.ToShortDateString

      Try
         cn.Open()

         Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM " & tabella & " WHERE DataArrivo = #" & dataCorrente & "#", cn)
         totaleCamereInConsegna = Convert.ToInt32(cmd.ExecuteScalar())

         Return totaleCamereInConsegna

      Catch ex As Exception
         ' Visualizza un messaggio di errore e lo registra nell'apposito file.
         err.GestisciErrore(ex.StackTrace, ex.Message)

         Return 0

      Finally
         cn.Close()

      End Try
   End Function

   Private Sub AggiornaValoriOspiti()
      ' Legge il numero di ospiti in arrivo oggi.
      txtOspitiArrivo.Text = LeggiNumeroOspitiArrivo(TAB_PRENOTAZIONI)
      ' Legge il numero di ospiti in casa.
      txtOspitiCasa.Text = LeggiNumeroOspitiInCasa(TAB_PRENOTAZIONI)
      ' Legge il numero di ospiti in partenza oggi.
      txtOspitiPartenza.Text = LeggiNumeroOspitiPartenza(TAB_PRENOTAZIONI)

      ' Legge il numero di camere in consegna oggi.
      txtCamereConsegna.Text = LeggiNumeroCamereInConsegna(TAB_PRENOTAZIONI)
      ' Legge il numero di camere occupate oggi.
      txtCamereOccupate.Text = LeggiNumeroCamereOccupate(TAB_PRENOTAZIONI)
      ' Legge il numero di camere occupate oggi.
      txtCamereLibere.Text = LeggiNumeroCamereLiberate(TAB_PRENOTAZIONI)
   End Sub

End Class
