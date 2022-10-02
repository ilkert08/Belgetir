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



        public void Add()
        {
            var entity = _context.Add(new Document { Name = "BELGE1", Created = DateTime.Now, Data = "data"});
            _context.SaveChanges();
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
