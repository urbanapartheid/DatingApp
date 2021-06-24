namespace API.Helper
{
    public class PaginationParams
    {
        #region Variables
        private const int MaxPageSize = 50;

        private int _pageSize = 10; 
        #endregion

        #region Properties
        public int PageNumber { get; set; } = 1;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        #endregion
    }
}
