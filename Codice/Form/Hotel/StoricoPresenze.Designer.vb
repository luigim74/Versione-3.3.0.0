<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StoricoPresenze
   Inherits System.Windows.Forms.Form

   'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
   <System.Diagnostics.DebuggerNonUserCode()>
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
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
      Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
      Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StoricoPresenze))
      Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
      Me.eui_tpcPresenze = New Elegant.Ui.TabControl()
      Me.TabPage1 = New Elegant.Ui.TabPage()
      Me.TextBox1 = New Elegant.Ui.TextBox()
      Me.Label2 = New Elegant.Ui.Label()
      Me.eui_txtTotaleDocumento = New Elegant.Ui.TextBox()
      Me.Label18 = New Elegant.Ui.Label()
      Me.dgvDettagli = New System.Windows.Forms.DataGridView()
      Me.clnMese = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.clnPresenze = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.clnOccupazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.TabPage2 = New Elegant.Ui.TabPage()
      Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
      Me.Label1 = New Elegant.Ui.Label()
      Me.eui_cmbTipoDocumento = New Elegant.Ui.ComboBox()
      Me.eui_cmdStampa = New Elegant.Ui.Button()
      Me.eui_cmdAnnulla = New Elegant.Ui.Button()
      Me.Label3 = New Elegant.Ui.Label()
      Me.ComboBox1 = New Elegant.Ui.ComboBox()
      CType(Me.eui_tpcPresenze, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabPage1.SuspendLayout()
      CType(Me.dgvDettagli, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabPage2.SuspendLayout()
      CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'formFrameSkinner
      '
      Me.formFrameSkinner.AllowGlass = False
      Me.formFrameSkinner.Form = Me
      '
      'eui_tpcPresenze
      '
      Me.eui_tpcPresenze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_tpcPresenze.EndScrollButtonVisible = True
      Me.eui_tpcPresenze.EqualTabHeight = True
      Me.eui_tpcPresenze.EqualTabWidth = True
      Me.eui_tpcPresenze.Location = New System.Drawing.Point(9, 9)
      Me.eui_tpcPresenze.Name = "eui_tpcPresenze"
      Me.eui_tpcPresenze.SelectedTabPage = Me.TabPage1
      Me.eui_tpcPresenze.Size = New System.Drawing.Size(596, 468)
      Me.eui_tpcPresenze.TabIndex = 1
      Me.eui_tpcPresenze.TabPages.AddRange(New Elegant.Ui.TabPage() {Me.TabPage1, Me.TabPage2})
      Me.eui_tpcPresenze.Text = " "
      '
      'TabPage1
      '
      Me.TabPage1.ActiveControl = Nothing
      Me.TabPage1.Controls.Add(Me.TextBox1)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Controls.Add(Me.eui_txtTotaleDocumento)
      Me.TabPage1.Controls.Add(Me.Label18)
      Me.TabPage1.Controls.Add(Me.dgvDettagli)
      Me.TabPage1.KeyTip = Nothing
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Size = New System.Drawing.Size(594, 447)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Elenco"
      '
      'TextBox1
      '
      Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.TextBox1.Id = "93e5be5f-7b2f-45ff-a3b6-f0e2c54977b0"
      Me.TextBox1.Location = New System.Drawing.Point(174, 413)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(99, 21)
      Me.TextBox1.TabIndex = 45
      Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      Me.TextBox1.TextEditorWidth = 93
      '
      'Label2
      '
      Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label2.Location = New System.Drawing.Point(86, 414)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(79, 16)
      Me.Label2.TabIndex = 46
      Me.Label2.Text = "Totale presenze:"
      '
      'eui_txtTotaleDocumento
      '
      Me.eui_txtTotaleDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_txtTotaleDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.eui_txtTotaleDocumento.Id = "e683d444-c6d4-41ea-9bda-3901b401a822"
      Me.eui_txtTotaleDocumento.Location = New System.Drawing.Point(489, 413)
      Me.eui_txtTotaleDocumento.Name = "eui_txtTotaleDocumento"
      Me.eui_txtTotaleDocumento.Size = New System.Drawing.Size(92, 21)
      Me.eui_txtTotaleDocumento.TabIndex = 43
      Me.eui_txtTotaleDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      Me.eui_txtTotaleDocumento.TextEditorWidth = 86
      '
      'Label18
      '
      Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label18.Location = New System.Drawing.Point(309, 413)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(167, 16)
      Me.Label18.TabIndex = 44
      Me.Label18.Text = "Totale percentuale di occupazione:"
      '
      'dgvDettagli
      '
      Me.dgvDettagli.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      Me.dgvDettagli.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.dgvDettagli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.dgvDettagli.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.dgvDettagli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.dgvDettagli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnMese, Me.clnPresenze, Me.clnOccupazione})
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.dgvDettagli.DefaultCellStyle = DataGridViewCellStyle4
      Me.dgvDettagli.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.dgvDettagli.Location = New System.Drawing.Point(3, 3)
      Me.dgvDettagli.MultiSelect = False
      Me.dgvDettagli.Name = "dgvDettagli"
      Me.dgvDettagli.ReadOnly = True
      Me.dgvDettagli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.dgvDettagli.Size = New System.Drawing.Size(588, 395)
      Me.dgvDettagli.TabIndex = 1
      '
      'clnMese
      '
      Me.clnMese.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
      DataGridViewCellStyle2.Format = "N0"
      DataGridViewCellStyle2.NullValue = Nothing
      Me.clnMese.DefaultCellStyle = DataGridViewCellStyle2
      Me.clnMese.HeaderText = "Mese"
      Me.clnMese.Name = "clnMese"
      Me.clnMese.ReadOnly = True
      Me.clnMese.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.clnMese.ToolTipText = "Mese"
      '
      'clnPresenze
      '
      DataGridViewCellStyle3.NullValue = Nothing
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.clnPresenze.DefaultCellStyle = DataGridViewCellStyle3
      Me.clnPresenze.HeaderText = "Presenze"
      Me.clnPresenze.Name = "clnPresenze"
      Me.clnPresenze.ReadOnly = True
      Me.clnPresenze.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
      Me.clnPresenze.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.clnPresenze.ToolTipText = "Numero presenze"
      Me.clnPresenze.Width = 120
      '
      'clnOccupazione
      '
      Me.clnOccupazione.HeaderText = "% Occupazione"
      Me.clnOccupazione.Name = "clnOccupazione"
      Me.clnOccupazione.ReadOnly = True
      Me.clnOccupazione.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.clnOccupazione.ToolTipText = "Percentuale di occupazione"
      Me.clnOccupazione.Width = 120
      '
      'TabPage2
      '
      Me.TabPage2.ActiveControl = Nothing
      Me.TabPage2.Controls.Add(Me.Chart1)
      Me.TabPage2.KeyTip = Nothing
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Size = New System.Drawing.Size(594, 488)
      Me.TabPage2.TabIndex = 1
      Me.TabPage2.Text = "Grafico"
      '
      'Chart1
      '
      Me.Chart1.BackColor = System.Drawing.SystemColors.AppWorkspace
      ChartArea1.Name = "ChartArea1"
      Me.Chart1.ChartAreas.Add(ChartArea1)
      Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Legend1.Name = "Legend1"
      Me.Chart1.Legends.Add(Legend1)
      Me.Chart1.Location = New System.Drawing.Point(0, 0)
      Me.Chart1.Name = "Chart1"
      Series1.ChartArea = "ChartArea1"
      Series1.Legend = "Legend1"
      Series1.Name = "Series1"
      Me.Chart1.Series.Add(Series1)
      Me.Chart1.Size = New System.Drawing.Size(594, 488)
      Me.Chart1.TabIndex = 0
      Me.Chart1.Text = "Chart1"
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.Location = New System.Drawing.Point(617, 4)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(46, 16)
      Me.Label1.TabIndex = 11
      Me.Label1.Text = "Tipologia:"
      '
      'eui_cmbTipoDocumento
      '
      Me.eui_cmbTipoDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmbTipoDocumento.Editable = False
      Me.eui_cmbTipoDocumento.FormattingEnabled = False
      Me.eui_cmbTipoDocumento.Id = "e3bad87f-e4ea-4c52-87fc-b9ef1d206b88"
      Me.eui_cmbTipoDocumento.Location = New System.Drawing.Point(617, 20)
      Me.eui_cmbTipoDocumento.Name = "eui_cmbTipoDocumento"
      Me.eui_cmbTipoDocumento.Size = New System.Drawing.Size(113, 21)
      Me.eui_cmbTipoDocumento.Sorted = True
      Me.eui_cmbTipoDocumento.TabIndex = 10
      Me.eui_cmbTipoDocumento.TextEditorWidth = 94
      '
      'eui_cmdStampa
      '
      Me.eui_cmdStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdStampa.Id = "63b7281d-2400-4a95-b56e-3706f3912fe3"
      Me.eui_cmdStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.eui_cmdStampa.Location = New System.Drawing.Point(617, 333)
      Me.eui_cmdStampa.Name = "eui_cmdStampa"
      Me.eui_cmdStampa.ScreenTip.Caption = "Stampa"
      Me.eui_cmdStampa.ScreenTip.Text = "Salva e stampa il documento."
      Me.eui_cmdStampa.Size = New System.Drawing.Size(114, 65)
      Me.eui_cmdStampa.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdStampa.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdStampa.TabIndex = 12
      Me.eui_cmdStampa.Text = "Stampa..."
      Me.eui_cmdStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      '
      'eui_cmdAnnulla
      '
      Me.eui_cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.eui_cmdAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.eui_cmdAnnulla.Id = "939bbe43-2558-40f8-9053-da695bc51ddd"
      Me.eui_cmdAnnulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.eui_cmdAnnulla.Location = New System.Drawing.Point(617, 412)
      Me.eui_cmdAnnulla.Name = "eui_cmdAnnulla"
      Me.eui_cmdAnnulla.ScreenTip.Caption = "Esci"
      Me.eui_cmdAnnulla.ScreenTip.Text = "Annula le modifiche e chiude il documento."
      Me.eui_cmdAnnulla.Size = New System.Drawing.Size(114, 65)
      Me.eui_cmdAnnulla.SmallImages.Images.AddRange(New Elegant.Ui.ControlImage() {New Elegant.Ui.ControlImage("Normal", CType(resources.GetObject("eui_cmdAnnulla.SmallImages.Images"), System.Drawing.Image))})
      Me.eui_cmdAnnulla.TabIndex = 13
      Me.eui_cmdAnnulla.Text = "Esci"
      Me.eui_cmdAnnulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.Location = New System.Drawing.Point(617, 51)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(42, 16)
      Me.Label3.TabIndex = 15
      Me.Label3.Text = "Anno:"
      '
      'ComboBox1
      '
      Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.ComboBox1.Editable = False
      Me.ComboBox1.FormattingEnabled = False
      Me.ComboBox1.Id = "9a06333f-b42a-49f3-9cad-415d7360ffd5"
      Me.ComboBox1.Location = New System.Drawing.Point(617, 67)
      Me.ComboBox1.Name = "ComboBox1"
      Me.ComboBox1.Size = New System.Drawing.Size(113, 21)
      Me.ComboBox1.Sorted = True
      Me.ComboBox1.TabIndex = 14
      Me.ComboBox1.TextEditorWidth = 94
      '
      'StoricoPresenze
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.SystemColors.AppWorkspace
      Me.ClientSize = New System.Drawing.Size(740, 486)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.ComboBox1)
      Me.Controls.Add(Me.eui_cmdAnnulla)
      Me.Controls.Add(Me.eui_cmdStampa)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.eui_cmbTipoDocumento)
      Me.Controls.Add(Me.eui_tpcPresenze)
      Me.Name = "StoricoPresenze"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Storico Presenze"
      CType(Me.eui_tpcPresenze, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      CType(Me.dgvDettagli, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabPage2.ResumeLayout(False)
      CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
   Friend WithEvents eui_tpcPresenze As Elegant.Ui.TabControl
   Friend WithEvents TabPage1 As Elegant.Ui.TabPage
   Friend WithEvents TabPage2 As Elegant.Ui.TabPage
   Friend WithEvents Label1 As Elegant.Ui.Label
   Friend WithEvents eui_cmbTipoDocumento As Elegant.Ui.ComboBox
   Friend WithEvents dgvDettagli As DataGridView
   Friend WithEvents eui_cmdStampa As Elegant.Ui.Button
   Friend WithEvents eui_cmdAnnulla As Elegant.Ui.Button
   Friend WithEvents Label3 As Elegant.Ui.Label
   Friend WithEvents ComboBox1 As Elegant.Ui.ComboBox
   Friend WithEvents TextBox1 As Elegant.Ui.TextBox
   Friend WithEvents Label2 As Elegant.Ui.Label
   Friend WithEvents eui_txtTotaleDocumento As Elegant.Ui.TextBox
   Friend WithEvents Label18 As Elegant.Ui.Label
   Friend WithEvents clnMese As DataGridViewTextBoxColumn
   Friend WithEvents clnPresenze As DataGridViewTextBoxColumn
   Friend WithEvents clnOccupazione As DataGridViewTextBoxColumn
   Friend WithEvents Chart1 As DataVisualization.Charting.Chart

   Public Sub New()

      ' La chiamata è richiesta dalla finestra di progettazione.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub


End Class
