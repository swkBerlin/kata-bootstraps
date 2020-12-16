namespace Kata.Advanced
{
    public class BusinessController
    {
        private readonly IBusinessEntityService _service;

        public BusinessController(IBusinessEntityService service)
        {
            _service = service;
        }

        public BusinessEntity Add(BusinessEntity entity)
        {
            var id = _service.Store(entity);
            return _service.Get(id);
        }
    }
}