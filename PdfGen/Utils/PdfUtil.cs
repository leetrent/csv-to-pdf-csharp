using System.IO;
using System.Linq;
using System.Collections.Generic;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;

namespace RetirementReporting
{
    public static class PdfUtil
    {
        public static IDictionary<string, PdfFormField> DiscoverPDFFields(string pdf)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdf));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            return form.GetFormFields();
        }

        public static void PrintPDFFields(IDictionary<string, PdfFormField> fields, string outputPath, bool addNumId)
        {
            StreamWriter sw = new StreamWriter(outputPath);
            var lines = fields.Select(kvp => kvp.Key);  //Grab PDF Fields from document
            foreach (var l in lines)  //Iterate through the fields to build the set value map
            {
                if (addNumId) { sw.WriteLine(l + "," + lines.ToList().IndexOf(l).ToString()); }
                else { sw.WriteLine(l); }

            }
            sw.Close();
        }
    }
}