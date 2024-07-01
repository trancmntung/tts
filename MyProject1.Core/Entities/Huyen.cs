using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.Entities
{
    public class Huyen
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int Id_Tinh { get; set; }

        public Tinh Tinh { get; set; }
        public ICollection<Xa> Xas { get; set; }
    }
}
