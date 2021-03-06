﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {

            new Product {ProductID=1, CategoryID=1,ProductName="Bardak",UnitPrice=15, UnitInStock=15 },
            new Product {ProductID=2, CategoryID=1,ProductName="Kamere",UnitPrice=150, UnitInStock=3 },
            new Product {ProductID=3, CategoryID=2,ProductName="Telefon",UnitPrice=1500, UnitInStock=5 },
            new Product {ProductID=4, CategoryID=2,ProductName="Klavye",UnitPrice=5, UnitInStock=150 },
            new Product {ProductID=5, CategoryID=2,ProductName="Fare",UnitPrice=5, UnitInStock=150 }
            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {

            Product productToDelete = _products.SingleOrDefault(p=> p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=> p.ProductID == product.ProductID);
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

    }
}