using Belgetir.Models;

namespace Belgetir.DAL
{
    public interface ICrudOperations
    {

        Document Add(Document document);
        ICrudOperations Update();
        ICrudOperations Delete();
        ICrudOperations Get();

    }
}
