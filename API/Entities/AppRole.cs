using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace API.Entities
{
    public class AppRole : IdentityRole<int>
    {
        #region Properties
        public ICollection<AppUserRole> UserRoles { get; set; } 
        #endregion
    }
}
