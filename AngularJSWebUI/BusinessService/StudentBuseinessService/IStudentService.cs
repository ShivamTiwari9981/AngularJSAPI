using AngularJSWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSWebUI.BusinessService.StudentBuseinessService
{
   public interface IStudentService
    {
        List<StudentEntity> GetAllStudent();
        string GetString();
    }
}
