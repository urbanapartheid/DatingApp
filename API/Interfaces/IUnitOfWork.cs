using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        #region Properties
        IUserRepository UserRepository { get; }

        IMessageRepository MessageRepository { get; }

        ILikesRepository LikesRepository { get; }
        #endregion

        #region Methods
        Task<bool> Complete();

        bool HasChanges(); 
        #endregion
    }
}
