using System.Threading.Tasks;
using TrashBountyLib.Models.Results;
using TrashBountyLib.Models;

namespace TrashBountyWebsite.Client.Authentication
{
    public interface IAuthService
    {
        Task<RegisterResult> Register(NewUser user);
        Task<LoginResult> Login(ReturningUser user);
        Task Logout();
    }
}