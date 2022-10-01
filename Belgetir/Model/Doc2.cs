namespace Belgetir.Model
{
    public class Doc2 : IDocument
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
