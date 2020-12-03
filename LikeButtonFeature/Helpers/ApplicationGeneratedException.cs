using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Helpers
{
    /// <summary>
    /// Custom exception class to handle application generated exceptions with 
    /// appropriate HTTP response code (Code) and user friendly message (ResponseMessage0 
    /// </summary>
    public class ApplicationGeneratedException : Exception
    {
        public ApplicationGeneratedException(ErrorCode Code, string ResponseMessage)
        {
            this.Code = Code;
            this.ResponseMessage = ResponseMessage;
        }
        public ErrorCode Code { get; private set; }
        public string ResponseMessage { get; private set; }
    }

    /// <summary>
    /// Error response code equivalents of HTTP status codes to be used for the http response.
    /// </summary>
    public enum ErrorCode
    {
        BadRequest = 400,
        NotFound = 404,
        InternalServerError = 500
    }
}
