namespace Belgetir.Model
{
    public class Doc1 : IDocument
    {
        public override byte[] RenderPdf()
        {
            return Pdf;
        }

        public override IDocument BuildDocument()
        {
            return this; // TODO
        }
    }
}
