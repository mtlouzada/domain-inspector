using System.Threading.Tasks;

namespace Domain.Inspector.Services
{
    public interface IWhoisClientWrapper
    {
        Task<string> QueryAsync(string domain);
    }
}
