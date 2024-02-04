using System;

namespace SallesWebMvc.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) 
            : base(message)
        {
        }
    }
}
