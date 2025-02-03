using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using Domain.Model;

namespace Reports
{
    public class ReporteService
    {
        public void GenerarReportePagos(string directoryPath, Usuario usuario, List<Pago> pagos)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = $"ReportePagos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(directoryPath, fileName);

            PdfDocument document = new PdfDocument();
            document.Info.Title = "Reporte de Pagos";

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont fontTitle = new XFont("Times New Roman", 18); 
            XFont fontSubTitle = new XFont("Times New Roman", 14); 
            XFont fontNormal = new XFont("Times New Roman", 12); 
            XFont fontTableHeader = new XFont("Times New Roman", 12); 

            gfx.DrawString("Reporte de Pagos", fontTitle, XBrushes.Black, new XRect(0, 20, page.Width, 0), XStringFormats.TopCenter);

            gfx.DrawString($"Usuario: {usuario.email}", fontNormal, XBrushes.Black, new XRect(40, 80, page.Width - 80, 0), XStringFormats.TopLeft);
            gfx.DrawString($"Teléfono: {usuario.telefono}", fontNormal, XBrushes.Black, new XRect(40, 100, page.Width - 80, 0), XStringFormats.TopLeft);

            gfx.DrawLine(XPens.Black, 40, 120, page.Width - 40, 120);

            int startY = 140;
            int rowHeight = 25;

            XSolidBrush headerBackground = new XSolidBrush(XColors.LightGray);
            gfx.DrawRectangle(headerBackground, 40, startY, page.Width - 80, rowHeight);

            gfx.DrawString("ID Pago", fontTableHeader, XBrushes.Black, new XRect(50, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
            gfx.DrawString("Estado", fontTableHeader, XBrushes.Black, new XRect(130, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
            gfx.DrawString("Fecha de Pago", fontTableHeader, XBrushes.Black, new XRect(220, startY + 5, 100, rowHeight), XStringFormats.TopLeft);
            gfx.DrawString("Precio Total", fontTableHeader, XBrushes.Black, new XRect(330, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
            gfx.DrawString("Descripción", fontTableHeader, XBrushes.Black, new XRect(420, startY + 5, 150, rowHeight), XStringFormats.TopLeft);

            startY += rowHeight;

            foreach (var pago in pagos)
            {
                gfx.DrawRectangle(XPens.Black, 40, startY, page.Width - 80, rowHeight);

                gfx.DrawString(pago.id.ToString(), fontNormal, XBrushes.Black, new XRect(50, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(pago.estado, fontNormal, XBrushes.Black, new XRect(130, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(pago.fechaPago?.ToString("dd/MM/yyyy") ?? "No disponible", fontNormal, XBrushes.Black, new XRect(220, startY + 5, 100, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(pago.precioTotal.ToString("C"), fontNormal, XBrushes.Black, new XRect(330, startY + 5, 80, rowHeight), XStringFormats.TopLeft);
                gfx.DrawString(pago.oMembresia?.oTipo_Membresia?.descripcion ?? "Sin descripción", fontNormal, XBrushes.Black, new XRect(420, startY + 5, 150, rowHeight), XStringFormats.TopLeft);

                startY += rowHeight;

                if (startY > page.Height - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    startY = 40;
                }
            }
                document.Save(filePath);
        }
    }
}
