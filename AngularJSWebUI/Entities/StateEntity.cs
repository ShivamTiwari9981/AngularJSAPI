using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class StateEntity : BaseEntity
    {
        public string state_cd { get; set; }
        public string state_nam { get; set; }
        public string country_cd { get; set; }
    }
}