using AngularJSWebUI.DataContext;
using AngularJSWebUI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string student_cd { get; set; }
        public string student_nam { get; set; }
        public string student_mob { get; set; }
        public string email { get; set; }
        public string gender_cd { get; set; }
        public string country_cd { get; set; }
        public string state_cd { get; set; }
        public string img { get; set; }

        public StudentEntity()
        {
            student_cd = string.Empty;
            student_nam = string.Empty;
            student_mob = string.Empty;
            email = string.Empty;
            gender_cd = string.Empty;
            country_cd = string.Empty;
            state_cd = string.Empty;
            img = string.Empty;
            rec_stus = string.Empty;
        }

        public StudentEntity(tbl_student data)
        {
            student_cd = data.student_cd;
            student_nam = data.student_nam;
            student_mob = data.student_mob;
            email = data.email;
            gender_cd = data.gender_cd;
            country_cd = data.country_cd;
            state_cd = data.state_cd;
            img = data.img;
            rec_stus = data.rec_stus;
        }

    }
}