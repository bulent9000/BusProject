using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace oto.core.Entities
{
 
    public class Sehirler
    {
        public override string ToString()
        {
            return sehirIsim; 
        }

        public string sehirIsim { get; set; }
       




    }
}
