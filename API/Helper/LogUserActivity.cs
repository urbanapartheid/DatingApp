using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace API.Helper
{
    public class LogUserActivity : IAsyncActionFilter
    {
        #region Methods
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated)
                return;

            var userId = resultContext.HttpContext.User.GetUserId();

            // pay attention to how to retrieve UserRepository in this case
            var unitOfWork = resultContext.HttpContext.RequestServices.GetService<IUnitOfWork>();

            var user = await unitOfWork.UserRepository.GetUserByIdAsync(userId);
            user.LastActive = DateTime.Now;

            await unitOfWork.Complete();
        } 
        #endregion
    }
}
