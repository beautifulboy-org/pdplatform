using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.Utils
{

    /// <summary>
    /// 分页器
    /// </summary>
    public interface IPagination
    {

        /// <summary>
        /// 数据总行数
        /// </summary>
        int Total { get; set; }

        /// <summary>
        /// 每页数据量
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        int CurrentPageIndex { get; set; }
    }
}
