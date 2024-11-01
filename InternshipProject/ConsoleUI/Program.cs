﻿using Business.Concrete;
using DataAccess;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2)){
                Console.WriteLine(product.ProductName);
            }

        }

    }
}