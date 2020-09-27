using Microsoft.EntityFrameworkCore;
using MiguelBeneditProgramacion3_Core.Interfaces;
using System.Threading.Tasks;

namespace MiguelBeneditProgramacion3_Infrastructure.Data.EntityFramework
{
    public class EntityFrameworkUnitOfWork<TContext> : IUnitOfWork where TContext:DbContext
    {
        private TContext _context { get; set; }
        public EntityFrameworkUnitOfWork(TContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
