using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class CityEntity: BaseEntity
    {
        public string city_cd { get; set; }
        public string city_nam { get; set; }
        public string state_cd { get; set; }
    }
}