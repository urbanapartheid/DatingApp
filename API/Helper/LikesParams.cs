namespace API.Helper
{
    public class LikesParams : PaginationParams
    {
        #region Properties
        public int UserId { get; set; }

        public string Predicate { get; set; } 
        #endregion
    }
}
