using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

            Console.ReadKey();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            var categories = categoryManager.GetAll();

            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
            }

            Console.WriteLine("--------------------------------------------");

            categoryManager.GetById(2);
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " | " + product.CategoryName);
            }
            
            Console.WriteLine("--------------------------------------------");
        }
    }
}
