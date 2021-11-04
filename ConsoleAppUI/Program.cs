using Bussiness.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {


        
           // ProductTest();
          //  CategoryTest();
            ProductTest1();
        }
        private static void CategoryTest()
        {

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }

        }

        private static void ProductTest()
        {

           ProductManager productmanager = new ProductManager(new EfProductDal());

            foreach (var item in productmanager.GetAllByCategoryId(5))
            {
                Console.WriteLine(item.ProductName);
            }
        }
        private static void ProductTest1()
        {
            Product prd1 = new Product();
            prd1.ProductName = "r";
            prd1.UnitPrice = 50;
            prd1.UnitsInStock = 150;
            prd1.CategoryID = 5;
            ProductManager productmanager = new ProductManager(new EfProductDal());
            productmanager.Add(prd1);
           
        }

    }
}
