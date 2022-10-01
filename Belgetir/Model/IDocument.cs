
namespace Belgetir.Model
{

    public abstract class IDocument
    {



        public IDocument()
        {

        }

        public IDocument(string name, DateTime createDate, byte[] pdf, string data )
        {
            this.Name = name;   
            this.CreateDate = createDate;
            this.Pdf = pdf;
            this.Data = data;
        }


        public abstract byte[] RenderPdf();

        public abstract IDocument BuildDocument();


        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] Pdf { get; set; }
        public string Data { get; set; }

    }
}
