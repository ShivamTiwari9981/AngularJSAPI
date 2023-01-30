using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJSWebUI.Entities;
using AngularJSWebUI.UnitOfWork;

namespace AngularJSWebUI.BusinessService.StudentBuseinessService
{
    public class StudentService:IStudentService
    {
        private readonly IUnitOfWork _unitOfwork;
        public StudentService()
        {
            _unitOfwork = new UnitOfWork.UnitOfWork();
        }

        public StudentService(IUnitOfWork unitOfwork) 
        {
            this._unitOfwork = unitOfwork;
        }

        public List<StudentEntity>GetAllStudent()
        {
            try
            {
                var dbData = _unitOfwork.StudentRepository.GetAll().ToList();
                var studentList = dbData.Select(x => new StudentEntity(x)).ToList();
                return studentList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string  GetString()
        {
            try
            {
                
                return "hello";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}