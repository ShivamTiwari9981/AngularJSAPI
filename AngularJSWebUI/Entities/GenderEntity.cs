using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class GenderEntity : BaseEntity
    {
        public string gender_cd { get; set; }
        public string gender_nam { get; set; }
    }
}