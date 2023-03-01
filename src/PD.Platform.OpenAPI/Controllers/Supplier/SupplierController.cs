using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PD.Platform.DataAccess;
using PD.Platform.Facade.Supplier;
using PD.Platform.Utils;

namespace PD.Platform.OpenAPI.Controllers.Supplier
{
    /// <summary>
    /// 供应商控制器
    /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("config")]
        public FuncResult<string> GetConfig([FromServices] IOptions<TestConfig> options)
        {
            var config = options.Value;

            return $"{config.TestDemo.Name}+ {config.TestDemo.Age}";

        }
    }
}
