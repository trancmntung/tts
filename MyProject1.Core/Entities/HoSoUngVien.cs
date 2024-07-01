using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Core.Entities
{ 
 
    public class HoSoUngVien
    {
      
        public string Code { get; set; }
        public string Name { get; set; }
        public string GioiTinh { get; set; } // Gender
        public DateTime NamSinh { get; set; } // Birth Year
        public string CMND { get; set; } // ID Card Number
        public string QuocGia { get; set; } // Country
        public string Tinh { get; set; } // Province
        public string Huyen { get; set; } // District
        public string Xa { get; set; } // Commune

    }
}
