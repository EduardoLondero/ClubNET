using Domain.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;

namespace Domain.Reports
{
    public class ReporteDeporteService
    {
        public void GenerarReporteInscritos(string directoryPath, Deporte deporte, List<Usuario> usuarios)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string fileName = $"ReporteInscritos_{deporte.nombreDeporte}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string filePath = Path.Combine(directoryPath, fileName);

            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Reporte de Inscritos - {deporte.nombreDeporte}";

            double marginLeft = 40;
            double marginTop = 40;
            double marginRight = 40;

            XFont fontTitle = new XFont("Arial", 18);
            XFont fontNormal = new XFont("Arial", 12);
            XFont fontHeader = new XFont("Arial", 14);

            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            double startY = marginTop;

            gfx.DrawString($"Reporte de Inscritos - {deporte.nombreDeporte}", fontTitle, XBrushes.Black, new XRect(0, startY, page.Width, 0), XStringFormats.TopCenter);
            startY += 40;

            gfx.DrawString($"Deporte: {deporte.nombreDeporte}", fontNormal, XBrushes.Black, new XRect(marginLeft, startY, page.Width - 2 * marginLeft, 0), XStringFormats.TopLeft);
            startY += 20;
            gfx.DrawString($"Horario: {deporte.horaInicio} - {deporte.horaFin}", fontNormal, XBrushes.Black, new XRect(marginLeft, startY, page.Width - 2 * marginLeft, 0), XStringFormats.TopLeft);
            startY += 20;
            gfx.DrawString($"Precio: {deporte.precio:C}", fontNormal, XBrushes.Black, new XRect(marginLeft, startY, page.Width - 2 * marginLeft, 0), XStringFormats.TopLeft);
            startY += 30;

            gfx.DrawString("Usuarios Inscritos:", fontHeader, XBrushes.Black, new XRect(marginLeft, startY, page.Width - 2 * marginLeft, 0), XStringFormats.TopLeft);
            startY += 30;

            gfx.DrawRectangle(XBrushes.LightGray, marginLeft, startY, 50, 20);
            gfx.DrawRectangle(XBrushes.LightGray, marginLeft + 60, startY, 200, 20);
            gfx.DrawRectangle(XBrushes.LightGray, marginLeft + 270, startY, 100, 20);
            gfx.DrawRectangle(XBrushes.LightGray, marginLeft + 380, startY, 200, 20);
            gfx.DrawString("ID", fontNormal, XBrushes.Black, new XRect(marginLeft, startY, 50, 20), XStringFormats.TopLeft);
            gfx.DrawString("Email", fontNormal, XBrushes.Black, new XRect(marginLeft + 60, startY, 200, 20), XStringFormats.TopLeft);
            gfx.DrawString("Teléfono", fontNormal, XBrushes.Black, new XRect(marginLeft + 270, startY, 100, 20), XStringFormats.TopLeft);
            gfx.DrawString("Dirección", fontNormal, XBrushes.Black, new XRect(marginLeft + 380, startY, 200, 20), XStringFormats.TopLeft);
            startY += 20;

            int rowIndex = 0;
            foreach (var usuario in usuarios)
            {
                if (rowIndex % 2 == 0)
                {
                    gfx.DrawRectangle(XBrushes.LightBlue, marginLeft, startY, 50, 20);
                    gfx.DrawRectangle(XBrushes.LightBlue, marginLeft + 60, startY, 200, 20);
                    gfx.DrawRectangle(XBrushes.LightBlue, marginLeft + 270, startY, 100, 20);
                    gfx.DrawRectangle(XBrushes.LightBlue, marginLeft + 380, startY, 200, 20);
                }

                gfx.DrawString(usuario.Id.ToString(), fontNormal, XBrushes.Black, new XRect(marginLeft, startY, 50, 20), XStringFormats.TopLeft);
                gfx.DrawString(usuario.email, fontNormal, XBrushes.Black, new XRect(marginLeft + 60, startY, 200, 20), XStringFormats.TopLeft);
                gfx.DrawString(usuario.telefono.ToString(), fontNormal, XBrushes.Black, new XRect(marginLeft + 270, startY, 100, 20), XStringFormats.TopLeft);
                gfx.DrawString(usuario.direccion, fontNormal, XBrushes.Black, new XRect(marginLeft + 380, startY, 200, 20), XStringFormats.TopLeft);

                startY += 20;
                rowIndex++;

                if (startY > page.Height - marginTop - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    startY = marginTop;
                }
            }

            startY += 30;
            gfx.DrawString($"Total de inscritos: {usuarios.Count}", fontHeader, XBrushes.Black, new XRect(marginLeft, startY, page.Width - 2 * marginLeft, 0), XStringFormats.TopLeft);

            document.Save(filePath);
        }
    }
}
