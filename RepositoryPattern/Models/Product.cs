using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepositoryPattern.Models
{
    public class Product
    {
        public int p_id { get; set; }
        public string p_name { get; set; }
        public string p_desc { get; set; } 
        public double p_unitPerPerize { get; set; }
        public double p_Stock { get; set; }
    }
}
