namespace Belgetir.DAL
{
    public interface ICrudOperations
    {

        void Add();
        ICrudOperations Update();
        ICrudOperations Delete();
        ICrudOperations Get();

    }
}
