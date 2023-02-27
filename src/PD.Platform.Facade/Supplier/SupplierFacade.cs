using PD.Platform.DataAccess;
using PD.Platform.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.Facade.Supplier
{
    /// <summary>
    /// 供应商业务类
    /// </summary>
    public class SupplierFacade
    {
        public List<AgreementDAO> GetList()
        {
            AgreementDAO agreementDAO = new AgreementDAO();
            var datas = agreementDAO.ListAll();
            return datas;
        }
    }
}
