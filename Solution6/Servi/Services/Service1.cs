using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.ServiceModel.Activation;

namespace Servi.Services
{
    public class Service1 : Interface.IService1
    {
        public string GetData2()
        {
            string sp = "Saurabh pratap";
            return sp;
        }
    }
}
