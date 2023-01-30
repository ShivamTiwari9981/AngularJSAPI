using AngularJSWebUI.BusinessService.StudentBuseinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSWebUI.Areas.API
{
    public class StudentAPIController : BaseAPIController
    {
        private IStudentService _studentService;
        public StudentAPIController() 
        {
            _studentService = new StudentService();
        } 
        public StudentAPIController(IStudentService studentService)
        {
            _studentService =new StudentService();
        }
        [HttpGet]
        [Route("~/api/StudentAPI/getAllStudent")]
        public HttpResponseMessage GetAllStudent()
        {
            var studentList = _studentService.GetAllStudent();
            var apiResponse = GetAPIResponse(studentList);
            return apiResponse;
        }
    }
}
