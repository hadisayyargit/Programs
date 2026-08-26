using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using Microsoft.Reporting.WebForms;


public class ReportPrinter : IDisposable
{
    //Local variables
    private int m_currentPageIndex;
    private IList<Stream> m_streams;
    private LocalReport m_LocalReport = null;
    private ServerReport m_ServerReport = null;

    /// <summary>
    /// ReportPrinter prnt = new ReportPrinter();
    ///  prnt.Print(rpt.LocalReport);
    /// Routine to provide to the report renderer, in order to save an image for each page of the report.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="fileNameExtension"></param>
    /// <param name="encoding"></param>
    /// <param name="mimeType"></param>
    /// <param name="willSeek"></param>
    /// <returns></returns>    
    private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
    {

        Stream stream = new MemoryStream();
        m_streams.Add(stream);
        return stream;
    }

    /// <summary>
    /// Export the given report as an EMF (Enhanced Metafile) file.
    /// </summary>
    /// <param name="report"></param>
    private void Export(bool isserverreport)
    {
        string deviceInfo = "";
        Warning[] warnings;

        string mimetype = "image/EMF", filenameextension = "EMF";

        m_streams = new List<Stream>();

        if (isserverreport)
        {
            deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>" + m_ServerReport.GetDefaultPageSettings().PaperSize.Width.ToString() + @"in</PageWidth>
                <PageHeight>" + m_ServerReport.GetDefaultPageSettings().PaperSize.Height.ToString() + @"in</PageHeight>
                <MarginTop>" + m_ServerReport.GetDefaultPageSettings().Margins.Top.ToString() + @"in</MarginTop>
                <MarginLeft>" + m_ServerReport.GetDefaultPageSettings().Margins.Left.ToString() + @"in</MarginLeft>
                <MarginRight>" + m_ServerReport.GetDefaultPageSettings().Margins.Right.ToString() + @"in</MarginRight>
                <MarginBottom>" + m_ServerReport.GetDefaultPageSettings().Margins.Bottom.ToString() + @"in</MarginBottom>
            </DeviceInfo>";
            m_ServerReport.Render("Image", deviceInfo ,null,CreateStream("",filenameextension,null,mimetype,true), out mimetype,out filenameextension);
        }

        else
        {
            deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>" + m_LocalReport.GetDefaultPageSettings().PaperSize.Width.ToString() + @"in</PageWidth>
                <PageHeight>" + m_LocalReport.GetDefaultPageSettings().PaperSize.Height.ToString() + @"in</PageHeight>
                <MarginTop>" + m_LocalReport.GetDefaultPageSettings().Margins.Top.ToString() + @"in</MarginTop>
                <MarginLeft>" + m_LocalReport.GetDefaultPageSettings().Margins.Left.ToString() + @"in</MarginLeft>
                <MarginRight>" + m_LocalReport.GetDefaultPageSettings().Margins.Right.ToString() + @"in</MarginRight>
                <MarginBottom>" + m_LocalReport.GetDefaultPageSettings().Margins.Bottom.ToString() + @"in</MarginBottom>
            </DeviceInfo>";

            m_LocalReport.Render("Image", deviceInfo, CreateStream,
               out warnings);
        }

        foreach (Stream stream in m_streams)
            stream.Position = 0;

    }

    /// <summary>
    /// Handler for PrintPageEvents
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="ev"></param>
    private void PrintPage(object sender, PrintPageEventArgs ev)
    {
        Metafile pageImage = new
           Metafile(m_streams[m_currentPageIndex]);

        // Adjust rectangular area with printer margins.
        Rectangle adjustedRect = new Rectangle(
            ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            ev.PageBounds.Width,
            ev.PageBounds.Height);


        
        // Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

        // Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect);

        // Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex++;
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
    }

    /// <summary>
    /// Exports local report and tries to print
    /// </summary>
    public string Print(LocalReport myLocalReport,ServerReport myServerReport, bool isserverreport)
    {
        string strRes = "";
        try
        {
            m_LocalReport = myLocalReport;
            m_ServerReport = myServerReport;

            strRes = "1";
            Export(isserverreport);

            strRes = "2";
            if (m_streams == null || m_streams.Count == 0)
                strRes = "Error: no stream to print.";

            PrintDocument printDoc = new PrintDocument();


            //printDoc.DefaultPageSettings.Landscape = false;
            // printDoc.PrinterSettings.ToPage
            


            if (!printDoc.PrinterSettings.IsValid)
            {
                strRes = "Error: cannot find the default printer.";
                

            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();

                strRes = "ok";

            }
            
        }
        catch (Exception ex)
        {
            strRes = ex.Message;
        }


        return strRes;
    }

    /// <summary>
    /// Dispose resources
    /// </summary>
    public void Dispose()
    {
        if (m_streams != null)
        {
            foreach (Stream stream in m_streams)
                stream.Close();
            m_streams = null;
        }
    }
}
