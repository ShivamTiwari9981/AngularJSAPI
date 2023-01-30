using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class ModuleEntity : BaseEntity
    {
        public int module_id { get; set; }
        public string module_nam { get; set; }
        public string module_image { get; set; }
        public List<SubModuleEntity> subModuleList { get; set; }
        public ModuleEntity()
        {
            subModuleList = new List<SubModuleEntity>();
        }
    }
    public class SubModuleEntity
    {
        public int sub_module_id { get; set; }
        public string sub_module_nam { get; set; }
        public int module_id { get; set; }
        public string controller_nam { get; set; }
        public string action_nam { get; set; }
        public string sub_image { get; set; }
        public SubModuleEntity(){}
    }
}