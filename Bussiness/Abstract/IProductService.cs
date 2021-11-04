using Core.Mustİşlemler.Results;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

namespace Bussiness.Abstract
{
    public interface IProductService
    {

        IDataResult<List<Product>> GetAll();

        IDataResult<Product> GetById(int productId);

         List<Product> GetAllByCategoryId(int id);


        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>> GetProductsDetails();


        IResult Add(Product product);

        
    }
}
