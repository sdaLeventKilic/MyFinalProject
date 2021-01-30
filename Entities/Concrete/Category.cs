using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
        public int ProductID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public short UnitInStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal UnitPrice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
    