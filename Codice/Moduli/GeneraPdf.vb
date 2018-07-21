Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module GeneraPdf

#Region "Esempio "

   ' Dim Documento As New Document(PageSize.A4, 100, 100, 25, 25)
   ' Dim fileStream As New FileStream("E:\test.pdf", FileMode.Create, FileAccess.Write, FileShare.None)
   ' Dim Scrittura As PdfWriter = PdfWriter.GetInstance(Documento, fileStream)
   ' Documento.Open()
   ' 'Logo
   ' Dim logo = iTextSharp.text.Image.GetInstance("E:\LogoAngoloDelComputer.jpg")
   ' logo.Alignment = iTextSharp.text.Image.ALIGN_LEFT
   ' Documento.Add(logo)
   ' Documento.Add(Chunk.NEWLINE)
   ' Documento.Add(Chunk.NEWLINE)
   ' Dim titleFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD)
   ' Dim ParTitolo As New Paragraph("Titolo", titleFont)
   ' ParTitolo.Alignment = iTextSharp.text.Element.ALIGN_CENTER
   ' Documento.Add(ParTitolo)
   ' Dim ParTesto As New Paragraph("Testo")
   ' Documento.Add(ParTesto)
   ' Documento.Close()

#End Region

   Public Sub GeneraFilePDF()
      Dim DEST As String = Application.StartupPath & "\ProvaPDF.pdf"

      ' Crea un documento
      Dim Documento As New Document(PageSize.A4)

      ' Ottengo un istanza dell'oggetto PdfWriter
      PdfWriter.GetInstance(Documento, New FileStream(DEST, FileMode.Create))

      ' Apro il documento
      Documento.Open()

      ' Logo.
      Dim logo = Image.GetInstance(Application.StartupPath & "\Immagini\pizza.jpg")
      logo.Alignment = Image.ALIGN_LEFT
      Documento.Add(logo)
      Documento.Add(Chunk.NEWLINE)
      Documento.Add(Chunk.NEWLINE)

      ' Titolo.
      Dim titoloFont = FontFactory.GetFont("Arial", 20, Font.BOLD)
      Dim ParTitolo As New Paragraph("Hello World!", titoloFont)
      ParTitolo.Alignment = Element.ALIGN_CENTER
      Documento.Add(ParTitolo)
      Documento.Add(Chunk.NEWLINE)

      ' Testo.
      Dim testoFont = FontFactory.GetFont("Arial", 15, Font.NORMAL)
      Dim ParTesto As New Paragraph("Questo è il Testo del documento Pdf.")
      Documento.Add(ParTesto)

      ' Chiudo il documento
      Documento.Close()
   End Sub

End Module
