using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularJSWebUI.Areas.API
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class BaseAPIController : ApiController
    {
        protected HttpResponseMessage GetAPIResponse<T>(T dataToSend,  string errorCode = "", string errorMessage = "OK")
        {
            var status = "s";
            if (errorCode != string.Empty)
                status = "f";
            else
                errorCode = "200";

            var responseCode = new ResponseCode(status, errorCode, errorMessage);
            var response = new APIResponseModel<T>(dataToSend, responseCode);
            return Request.CreateResponse(response);
        }

        protected IHttpActionResult GetAPIResponses<T>(T dataToSend, string errorCode = "", string errorMessage = "OK")
        {
            var status = "s";
            if (errorCode != string.Empty)
                status = "f";
            else
                errorCode = "200";

            var responseCode = new ResponseCode(status, errorCode, errorMessage);
            var response = new APIResponseModel<T>(dataToSend, responseCode);
            return Ok(response);
        }
    }
}
