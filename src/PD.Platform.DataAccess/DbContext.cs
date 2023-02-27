using PD.Platform.Utils;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.DataAccess
{
    public class DbContext
    {
        public SqlSugarClient Db => InitSugarClient();
        const string conn = "server=47.107.64.250;port=3306;uid=root;pwd=123456;database=test";

        /// <summary>
        /// 初始化数据库对象
        /// </summary>
        /// <returns></returns>
        private SqlSugarClient InitSugarClient()
        {
            var Client = new SqlSugarClient(new ConnectionConfig
            {
                //数据库连接字符串            
                ConnectionString = conn,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                //从特性读取主键自增信息
                InitKeyType = InitKeyType.Attribute
            });


            //调式代码 用来打印SQL 
            Client.Aop.OnLogExecuting = (sql, pars) =>
            {
#if DEBUG
                foreach (var item in pars)
                {
                    sql = sql.Replace(item.ParameterName, $"'{item.Value}'");
                }
                Console.WriteLine();
                Console.WriteLine(sql);
#endif
            };

            //执行sql后
            Client.Aop.OnLogExecuted = (sql, pars) => //SQL执行完事件
            {
                if ("Development".Equals(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.AppendLine(sql);
                    pars.Aggregate(builder, (b, sp) => b.AppendLine($"{sp.ParameterName}={sp.Value}"));
                    builder.AppendLine($"执行耗时：{Client.Ado.SqlExecutionTime.TotalMilliseconds}ms");
                    Log<DbContext>.Debug(builder.ToString());
                }
            };

            return Client;
        }



    }
}
