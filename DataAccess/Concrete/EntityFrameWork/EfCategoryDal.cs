using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal//hepsi için crud ıslemlerı yapılacak bunlar uzernden olur 
    {

    }

}
