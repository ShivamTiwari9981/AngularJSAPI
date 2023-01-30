using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class SubjectEntity : BaseEntity
    {
        public string subject_cd { get; set; }
        public string subject_nam { get; set; }
        public string country_cd { get; set; }
    }
}