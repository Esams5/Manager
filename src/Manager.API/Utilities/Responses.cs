using System.Net;
using Manager.API.ViewModels;

namespace Manager.API.Utilities
{
    public static class Responses
    {
        public static ResultViewModel ApplicationErrorMessage()
        {
            return new ResultViewModel
            {
                Message = "An error occured.",
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErrorMessage(string message)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = null
            };
        }

        public static ResultViewModel DomainErrorMessage(string message, IReadOnlyCollection<string> errors)
        {
            return new ResultViewModel
            {
                Message = message,
                Success = false,
                Data = errors

            };
        }

        public static ResultViewModel UnauthorizedErrorMessage()
        {
            return new ResultViewModel()
            {
                Message = "A combinação de login e senha está incorreta.",
                Success = false,
                Data = null
            };
        }
    
    }
}

