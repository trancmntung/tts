using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.Entities
{
    public class Tinh
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public int Id_QuocGia { get; set; }

        public QuocGia QuocGia { get; set; }
        public ICollection<Huyen> Huyens { get; set; }
    }
}
