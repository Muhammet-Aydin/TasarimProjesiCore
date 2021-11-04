using Bussiness.Abstract;
using Bussiness.ErrorMessages;
using Core.Mustİşlemler.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.Concrete
{
    public class ProductManager:IProductService//cagetroyle ılgılı şsleri yoneticegiz.
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //Busıness code;
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            else
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            }
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==10)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductNameInvalid);

            }
            else
            {
                return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductListed);  
            }
        }


        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new DataResult<Product>(_productDal.Get(x => x.ProductID==productId),true,Messages.ProductListed);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new DataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice > min && p.UnitPrice < max),true,Messages.ProductListed);
        }

        public IDataResult<List<ProductDetailDto>> GetProductsDetails()
        {
            throw new System.NotImplementedException();
        }

        List<Product> IProductService.GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryID == id);
        }
    }

}
