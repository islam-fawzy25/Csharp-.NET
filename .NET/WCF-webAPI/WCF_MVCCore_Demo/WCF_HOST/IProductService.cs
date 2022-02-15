using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_HOST
{

    [ServiceContract]
    public interface IProductService
    {

        [OperationContract]
        List<Product> GetProduct();
    }
}
