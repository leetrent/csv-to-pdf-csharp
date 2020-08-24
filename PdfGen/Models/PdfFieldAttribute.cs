using System;

namespace PdfGen.Models
{
    public class PdfFieldAttribute : Attribute
    {
        public string FieldName { get; }
        public PdfFieldAttribute(string fieldName)
        {
            FieldName = fieldName;
        }
    }
}