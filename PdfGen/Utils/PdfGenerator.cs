using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using iText.Kernel.Pdf;
using iText.Forms;
using iText.Forms.Fields;
using PdfGen.Models;

namespace PdfGen.Utils
{
    public class PdfGenerator
    {
        dynamic _etlRecords; 
        string _pdfTemplateFileName;

        string _password;

        public PdfGenerator(dynamic etlRecs, string templateFileName, string password)
        {
            _etlRecords = etlRecs;
            _pdfTemplateFileName= templateFileName;
            _password = password;
        }

        public byte[] GeneratePdf()
        {
            using (MemoryStream outerMemoryStream = new MemoryStream())
            {
                PdfWriter pdfWriter = new PdfWriter(outerMemoryStream).SetSmartMode(true);
                PdfDocument toPdfDoc = new PdfDocument(pdfWriter);
                toPdfDoc.InitializeOutlines();

                 PdfDocument fromPdfDoc = null;

                 foreach (var etlRec in _etlRecords)
                 {
                     byte[] formFieldsInRow = this.fillFormFieldsInRow(etlRec);
                     MemoryStream innerMemoryStream = new MemoryStream(formFieldsInRow);;
                     PdfReader pdfReader = new PdfReader(innerMemoryStream);
                     fromPdfDoc = new PdfDocument(pdfReader);
                     fromPdfDoc.CopyPagesTo(1, fromPdfDoc.GetNumberOfPages(), toPdfDoc);
                 }
                 toPdfDoc.Close();
                 return outerMemoryStream.ToArray();
            }
        }

        private byte[] fillFormFieldsInRow<T>(T rec)
        {
            //string logSnippet = "[PdfGenerator][fillFormFieldsInRow] => ";
   
            using (var memoryStream = new MemoryStream())
            {
                PdfReader pdfReader = new PdfReader(_pdfTemplateFileName, 
                                        new ReaderProperties().SetPassword(Encoding.ASCII.GetBytes(_password))); //Iput
                PdfWriter pdfWriter = new PdfWriter(memoryStream);
                PdfDocument pdfDoc = new PdfDocument(pdfReader, pdfWriter);
                PdfAcroForm pdfForm = PdfAcroForm.GetAcroForm(pdfDoc, true);
                IDictionary<string, PdfFormField> pdfFormFields = pdfForm.GetFormFields();

                PropertyInfo[] properties = (PropertyInfo[])typeof(T).GetProperties()
                                            .Where(x => x.GetCustomAttributes(typeof(PdfFieldAttribute), true).Any());

                foreach (var prop in properties)
                {
                    var attribute = prop.GetCustomAttribute<PdfFieldAttribute>();

                    if (!pdfFormFields.TryGetValue(attribute.FieldName, out var pdfField))
                    {
                        continue;
                    }
                    pdfField.SetValue(prop.GetValue(rec)?.ToString() ?? String.Empty);
                }
                pdfForm.FlattenFields();
                pdfDoc.Close();
                return memoryStream.ToArray();
            }
        }
    }
}