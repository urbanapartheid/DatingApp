namespace API.Entities
{
    public class Connection
    {
        #region Properties
        public string ConnectionId { get; set; } // automatically considered as PK

        public string Username { get; set; }
        #endregion

        #region CTOR
        // need this default CTOR for entityframework.
        public Connection()
        {

        }

        public Connection(string connectionId, string username)
        {
            ConnectionId = connectionId;
            Username = username;
        }
        #endregion
    }
}
