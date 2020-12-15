using System.Threading.Tasks;

namespace MiguelBeneditProgramacion3_Core.Interfaces
{
    public interface IUnitOfWork
    {
        public void Save();
        public Task SaveAsync();
    }
}
