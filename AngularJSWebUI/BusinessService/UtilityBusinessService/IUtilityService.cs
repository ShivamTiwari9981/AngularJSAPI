using AngularJSWebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSWebUI.BusinessService.UtilityBusinessService
{
   public interface IUtilityService
    {
        List<ModuleEntity> GetModule();
    }
}
