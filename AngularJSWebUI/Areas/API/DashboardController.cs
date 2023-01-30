using AngularJSWebUI.BusinessService.UtilityBusinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AngularJSWebUI.Areas.API
{


    public class DashboardController: BaseAPIController
    {
        private readonly IUtilityService _utilityService;
        public DashboardController()
        {
            _utilityService = new UtilityService();
        }
        public DashboardController (IUtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        [HttpGet]
        [Route("~/api/Dashboard/getAllModule")]
        public IHttpActionResult GetAllModule()
        {
            try
            {
                var moduleList = _utilityService.GetModule();
                var apiResponse = GetAPIResponse(moduleList);
                return Ok(moduleList);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
