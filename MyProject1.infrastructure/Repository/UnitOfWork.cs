using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Application.Interfaces;

namespace MyProject.infrastructure.Repository
{
    public class UnitOfWork :IUnitOfWork
    {
        public UnitOfWork(IQuocGiaRepository quocGiaRepository)
        {
            QuocGias = quocGiaRepository;
        }
        public IQuocGiaRepository QuocGias { get; set; }


        public UnitOfWork(ITinhRepository tinhRepository)
        {
            Tinhs = tinhRepository;
        }
        public ITinhRepository Tinhs { get; set; }

        public UnitOfWork(IHuyenRepository huyenRepository)
        {
            Huyens = huyenRepository;
        }

        public IHuyenRepository Huyens { get; set; }

        public UnitOfWork(IXaRepository xaRepository)
        {
            Xas = xaRepository;
        }

        public IXaRepository Xas { get; set; }
        public UnitOfWork(IHoSoUngVienRepository hoSoUngVienRepository)
        {
            HoSoUngViens = hoSoUngVienRepository;
        }

        public IHoSoUngVienRepository HoSoUngViens { get; set; }

    }

}
