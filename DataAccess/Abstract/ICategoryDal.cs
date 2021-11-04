using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.DataAccess.EntityFrameWork.EfEntityRepositoryBase;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>//somut classların soyutlarıda yaılır daha sonra o modele aıt bir özel ıslem yapılcaksa buradan yapılır.
    {


    }


}
