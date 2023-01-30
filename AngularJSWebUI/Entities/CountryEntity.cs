using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class CountryEntity:BaseEntity
    {
        public string country_cd { get; set; }
        public string country_nam { get; set; }
    }
}