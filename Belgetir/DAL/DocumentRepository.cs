using Belgetir.Models;

namespace Belgetir.DAL
{
    public class DocumentRepository : ICrudOperations
    {
        

        private readonly belgetirdbContext _context;

        public DocumentRepository()
        {
            _context = new belgetirdbContext(); // TODO: dependency injection eklenecek.
        }



        public Document Add(Document document)
        {
            document = new Document { Name = "BELGE1", Created = DateTime.Now, Data = "data" };
            var entity = _context.Add(document);
            int count = _context.SaveChanges();
            if(count > 0)
            {
                return document;
            }
            return null;
        }

        public ICrudOperations Delete()
        {
            throw new NotImplementedException();
        }

        public ICrudOperations Get()
        {
            throw new NotImplementedException();
        }

        public ICrudOperations Update()
        {
            throw new NotImplementedException();
        }
    }
}
