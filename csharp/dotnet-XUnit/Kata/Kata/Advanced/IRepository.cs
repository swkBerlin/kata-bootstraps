namespace Kata.Advanced
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(int id);
        int Add(T entity);
        void Update(int id, T Entity);
        bool Delete(int id);
    }
}
