using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_HOST
{
    public class ProductService : IProductService
    {
        public List<Product> GetProduct()
        {
            VoresDB db = new VoresDB();
            return db.Products.ToList();
        }
    }
}
