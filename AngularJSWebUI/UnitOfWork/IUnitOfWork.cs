using AngularJSWebUI.DataContext;
using AngularJSWebUI.DataContext.GenericRepo;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJSWebUI.UnitOfWork
{
   public interface IUnitOfWork
    {
        DbConnection GetDbConnection();
        IGenericRepository<tbl_student> StudentRepository { get; }
        IGenericRepository<tbl_subject> SubjectRepository { get; }
        IGenericRepository<tbl_city> CityRepository { get; }
        IGenericRepository<tbl_student_subject> StudentSubjectRepository { get; }
        IGenericRepository<tbl_country> CountryRepository { get; }
        IGenericRepository<tbl_gender> GenderRepository { get; }
        IGenericRepository<tbl_state> StateRepository { get; }
    }
}
