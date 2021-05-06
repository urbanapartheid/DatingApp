using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        #region Methods
        public static int CaluculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age))
                age--;

            return age;
        } 
        #endregion
    }
}
