using System.Threading.Tasks;

namespace KioscoAPI.Services
{
    public interface IAuthService
    {
        Task<string?> LoginAsync(string usuario, string password);
    }
}