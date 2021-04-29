using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        #region Methods
        string CreateToken(AppUser user); 
        #endregion
    }
}
