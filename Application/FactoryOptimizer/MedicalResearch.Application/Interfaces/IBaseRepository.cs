using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IBaseRepository
    {
        Task SaveChanges();
    }
}
