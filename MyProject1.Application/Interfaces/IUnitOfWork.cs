
namespace MyProject.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IQuocGiaRepository QuocGias { get; set; }

        ITinhRepository Tinhs { get; set; }

        IHuyenRepository Huyens { get; set; }

        IXaRepository Xas { get; set; }

        IHoSoUngVienRepository HoSoUngViens { get; set; }
    }
}
