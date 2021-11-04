using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {


   


        public List<ProductDetailDto> GetProductDetails()
        {
            using(NorthwindContext context= new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryID equals c.CategoryID
                             select new ProductDetailDto
                             {

                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitInStock = p.UnitsInStock,
                             };
                return result.ToList();
            }


        }




    }

}
