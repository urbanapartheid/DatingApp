using API.Entities;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ITokenService
    {
        #region Methods
        Task<string> CreateToken(AppUser user); 
        #endregion
    }
}
