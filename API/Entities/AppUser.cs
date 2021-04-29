namespace API.Entities
{
    public class AppUser
    {
        #region Properties
        public int Id { get; set; }
        
        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
        #endregion
    }
}
