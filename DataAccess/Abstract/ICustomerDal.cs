using Entities.Concrete;
using static Core.DataAccess.EntityFrameWork.EfEntityRepositoryBase;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        void Temizle();

    }


}
