namespace Belgetir.Entities
{
    public class Document
    {


        public Document(string name, DateTime createDate, byte[] pdf, string data)
        {
            this.Name = name;
            this.CreateDate = createDate;
            this.Pdf = pdf;
            this.Data = data;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] Pdf { get; set; }
        public string Data { get; set; }

    }
}
