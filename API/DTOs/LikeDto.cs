namespace API.DTOs
{
    public class LikeDto
    {
        #region Properties
        // user Id
        public int Id { get; set; }

        public string Username { get; set; }

        public int Age { get; set; }

        public string KnownAs { get; set; }

        public string PhotoUrl { get; set; }

        public string City { get; set; } 
        #endregion
    }
}
