using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEpic.Data
{
    public class ProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product(){ProductID=1, ProductName="Computer", Price=50000, PurchaseDate=Convert.ToDateTime("01-Mar-2019")},
            new Product(){ProductID=2, ProductName="Laptop", Price=50000, PurchaseDate=Convert.ToDateTime("02-Mar-2019")},
            new Product(){ProductID=3, ProductName="Mouse", Price=3000, PurchaseDate=Convert.ToDateTime("03-Mar-2019")},
            new Product(){ProductID=4, ProductName="KeyBoard", Price=5000, PurchaseDate=Convert.ToDateTime("01-Mar-2019")},
            new Product(){ProductID=5, ProductName="Microphone", Price=7000, PurchaseDate=Convert.ToDateTime("06-Mar-2019")},
            new Product(){ProductID=6, ProductName="WebCam", Price=5000, PurchaseDate=Convert.ToDateTime("01-Mar-2019")},
            new Product(){ProductID=7, ProductName="HDMonitor", Price=15000, PurchaseDate=Convert.ToDateTime("01-Apr-2019")},
            new Product(){ProductID=8, ProductName="Headset", Price=10000, PurchaseDate=Convert.ToDateTime("01-May-2019")},
        };
        public async Task<List<Product>> ProductList()
        {
            return await Task.FromResult(products);
        }
    }
}
