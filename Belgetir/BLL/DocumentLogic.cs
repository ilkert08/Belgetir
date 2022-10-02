using Belgetir.DAL;
using Belgetir.Model;
using Belgetir.Utils;
using static Belgetir.Enums.DocumentEnums;

namespace Belgetir.BLL
{
    public class DocumentLogic
    {
        private DocRouter _docRouter;
        private readonly DocumentRepository _documentRepository;
        public DocumentLogic()
        {
            _docRouter = new DocRouter();
            _documentRepository = new DocumentRepository();
        }


        public IDocument RetrieveDocument(int id, int documentTypeId)
        {
            _documentRepository.Add();
            DocumentType type = (DocumentType) documentTypeId;
            var document = _docRouter.Route(type).BuildDocument();
            return document;
        }

        public IEnumerable<IDocument> RetrieveDocumentList()
        {
            var documents = new List<IDocument>();
            return documents;
        }

    }
}
