namespace Kata.Advanced
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(int id);
        int Add(T entity);
        void Update(int id, T entity);
        bool Delete(int id);
    }
}