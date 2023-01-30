using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Areas
{
    public class APIResponseModel<T>
    {
        public T result { get; private set; }
        public ResponseCode response { get; private set; }
        public APIResponseModel(T dataToSend, ResponseCode responseStatus)
        {
            result = dataToSend;
            response = responseStatus;
        }
    }
    public class ResponseCode
    {
        public string status { get; private set; }
        public string code { get; private set; }
        public string message { get; private set; }
        public ResponseCode(string status, string code, string message)
        {
            this.status = status;
            this.code = code;
            this.message = message;
        }
    }
}