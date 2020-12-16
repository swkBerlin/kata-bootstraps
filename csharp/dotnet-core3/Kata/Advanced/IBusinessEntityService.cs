namespace Kata.Advanced
{
    public interface IBusinessEntityService
    {
        int Store(BusinessEntity entity);
        BusinessEntity Get(int id);
    }

    public class BusinessEntityService : IBusinessEntityService
    {
        private readonly IRepository<BusinessEntity> _repo;

        public BusinessEntityService(IRepository<BusinessEntity> repo)
        {
            _repo = repo;
        }

        public BusinessEntity Get(int id)
        {
            return _repo.Get(id);
        }

        public int Store(BusinessEntity entity)
        {
            return _repo.Add(entity);
        }
    }
}