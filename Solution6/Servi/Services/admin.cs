using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.ServiceModel.Activation;

namespace Servi.Services
{
    public class admin : Interface.Iadmin
    {
        public string name()
        {
            string sp1 = "Arif khan";
            return sp1;
        }
        public string work()
        {
            string sp1 = "s/w developer eng";
            return sp1;
        }
    }
}
