using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Helpers
{
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

    public enum ErrorCode
    {
        BadRequest = 400,
        NotFound = 404,
        InternalServerError = 500
    }
}
