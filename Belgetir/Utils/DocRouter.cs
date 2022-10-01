using Belgetir.Model;
using static Belgetir.Enums.DocumentEnums;

namespace Belgetir.Utils
{
    public class DocRouter
    {


        public DocRouter()
        {

        }

        public IDocument Route(DocumentType type)
        {
            IDocument document;
            switch (type)
            {
                case DocumentType.Doc1:
                    document = new Doc1();
                    break;
                case DocumentType.Doc2:
                    document = new Doc2();
                    break;
                default: 
                    throw new ArgumentException();
                    break;
            }
            return document;
        }

    }
}
