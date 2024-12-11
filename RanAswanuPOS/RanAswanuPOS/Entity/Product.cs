using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanAswanuPOS.Entity
{
    class Product
    {
        private long productId;
        private String productName;
        private double availableStock;

        public Product(long productId, String productName)
        {
            this.productId = productId;
            this.productName = productName;

        }

        public long ProductId { get => productId; set => productId = value; }
        public String ProductName { get => productName; set => productName = value; }
        public double AvailableStock { get => availableStock; set => availableStock = value; }
    }
}
