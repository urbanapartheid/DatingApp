namespace API.DTOs
{
    public class CreateMessageDto
    {
        #region Properties
        public string RecipientUsername { get; set; }

        public string Content { get; set; } 
        #endregion
    }
}
