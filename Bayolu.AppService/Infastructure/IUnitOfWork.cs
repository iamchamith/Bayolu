using Bayolu.Domain;
using System;
using System.Threading.Tasks;

namespace Bayolu.AppService.Infastructure
{
    public interface IUnitOfWork
    {
        GenaricRepository<User, Guid> UserGenaricRepository { get; set; }
        Task SaveAsync();
    }
}
