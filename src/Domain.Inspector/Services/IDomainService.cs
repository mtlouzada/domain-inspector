using System.Threading.Tasks;
using Domain.Inspector.Models;

namespace Domain.Inspector.Services
{
    public interface IDomainService
    {
        Task<Domain> GetDomainInfoAsync(string domainName);
    }
}
