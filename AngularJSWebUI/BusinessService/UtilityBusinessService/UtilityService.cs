using AngularJSWebUI.Entities;
using AngularJSWebUI.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.BusinessService.UtilityBusinessService
{
    public class UtilityService:IUtilityService
    {
        private readonly IUnitOfWork _unitOfwork;
        public UtilityService()
        {
            _unitOfwork = new UnitOfWork.UnitOfWork();
        }
        public UtilityService(IUnitOfWork unitOfwork)
        {
            this._unitOfwork = unitOfwork;
        }

        public List<ModuleEntity> GetModule()
        {
            var cnn = _unitOfwork.GetDbConnection();
            var param = new List<SqlParameter>();
            var resultSet=  Global.ExecuteStoredProcedure("sp_get_all_module", param, _unitOfwork.GetDbConnection());
            var moduleList = new List<ModuleEntity>();
            var subModuleList = new List<SubModuleEntity>();
            moduleList = Global.CommonMethod.ConvertToList<ModuleEntity>(resultSet.Tables[0]);
            subModuleList = Global.CommonMethod.ConvertToList<SubModuleEntity>(resultSet.Tables[1]);
            foreach(var e in moduleList)
            {
              e.subModuleList = subModuleList.Where(x => x.module_id == e.module_id).ToList();
            }
            return moduleList;
        }

    }
}