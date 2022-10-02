using System;
using System.Collections.Generic;

namespace Belgetir.Models
{
    public partial class Document
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Created { get; set; }
        public byte[]? Pdf { get; set; }
        public string? Data { get; set; }
    }
}
