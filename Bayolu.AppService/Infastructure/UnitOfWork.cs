using Bayolu.Domain;
using System;
using System.Threading.Tasks;

namespace Bayolu.AppService.Infastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BayolyDbContext _contaxt;
        public GenaricRepository<User, Guid> UserGenaricRepository { get; set; }
        public UnitOfWork(BayolyDbContext contaxt)
        {
            _contaxt = contaxt;
            UserGenaricRepository = new GenaricRepository<User, Guid>(_contaxt);
        }

        public async Task SaveAsync()
        {
            await _contaxt.SaveChangesAsync();
        }
    }
}
