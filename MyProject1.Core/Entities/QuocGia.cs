using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyProject.Core.Entities
{
    public class QuocGia
    {

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public ICollection<Tinh> Tinhs { get; set; }
    }
}
