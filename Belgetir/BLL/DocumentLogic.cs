using AutoMapper;
using Belgetir.DAL;
using Belgetir.Model;
using Belgetir.Models;
using Belgetir.Models.Requests;
using Belgetir.Models.Responses;
using Belgetir.Utils;
using static Belgetir.Enums.DocumentEnums;

namespace Belgetir.BLL
{
    public class DocumentLogic
    {
        private DocRouter _docRouter;
        private readonly DocumentRepository _documentRepository;
        private readonly IMapper _mapper;

        public DocumentLogic(IMapper mapper)
        {
            _docRouter = new DocRouter();
            _documentRepository = new DocumentRepository();
            _mapper = mapper;
        }


        /*
        public IDocument RetrieveDocument(int id, int documentTypeId)
        {
            _documentRepository.Add();
            DocumentType type = (DocumentType) documentTypeId;
            var document = _docRouter.Route(type).BuildDocument();
            return document;
        } */

        public IEnumerable<IDocument> RetrieveDocumentList()
        {
            var documents = new List<IDocument>();
            return documents;
        }

        public StoreResponse StoreDocument(StoreRequest request)
        {
            var document = _docRouter.Route(DocumentType.Doc1);
            IDocument domainDocument = _mapper.Map<StoreRequest, IDocument>(request, document);
            Document dbDocument = _mapper.Map<IDocument, Document>(domainDocument, new Document());

            Document dbDocumentResponse = _documentRepository.Add(dbDocument);

            IDocument domainDocumentResponse = _mapper.Map<Document, IDocument>(dbDocumentResponse);
            StoreResponse response = _mapper.Map<IDocument, StoreResponse>(domainDocumentResponse);

            return response;
        }
    }
}
