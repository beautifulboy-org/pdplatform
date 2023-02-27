using SqlSugar;
using System.Text;

namespace PD.Platform.OpenAPI.Utils
{
    public class DbContext
    {
        const string conn = "server=47.107.64.250;port=3306;uid=root;pwd=123456;database=test";
        /// <summary>
        /// 创建数据库对象
        /// </summary>
        SqlSugarClient db = new SqlSugarClient(new ConnectionConfig
        {
            //数据库连接字符串            
            ConnectionString = conn,
            DbType = DbType.MySql,
            IsAutoCloseConnection = true,
            //从特性读取主键自增信息
            InitKeyType = InitKeyType.Attribute
        });



    }
}
