using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PD.Platform.DataAccess;
using PD.Platform.Facade.Supplier;
using PD.Platform.Utils;

namespace PD.Platform.OpenAPI.Controllers.Supplier
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        /// <summary>
        /// 供应商列表
        /// </summary>  
        /// <returns></returns>
        [HttpGet("list")]
        public FuncResult<List<AgreementDAO>> GetList()
        {
            SupplierFacade supplierFacade = new SupplierFacade();
            var result = supplierFacade.GetList();
            return result;
        }
    }
}
