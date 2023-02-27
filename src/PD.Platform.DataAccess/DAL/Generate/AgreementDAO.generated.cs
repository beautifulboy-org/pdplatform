/***************************************************
*
* Entity Model Of SqlSugar
* FileName : AgreementDAO.generated.cs
* CreateTime : 2023-02-25 14:37:12
* CodeGenerateVersion : 1.0.0.0
* TemplateVersion: 2.0.0
* TemplateName: DataAccessObject For SqlSugar
* E_Mail : jason.geek@qq.com
* Blog : 
* Copyright (C) ZYS
* 
***************************************************/
using SqlSugar;
using System.ComponentModel;
using System.Linq.Expressions;
using PD.Platform.Entity;
using PD.Platform.Enums;
using PD.Platform.Utils;

//DO NOT MODIFY PLEASE!!!!! this file was created by auto generated, if you want modify indeed please modify the template and regenerate this file
//请不要尝试修改此文件！！！！这个文件是由代码生成器生成的。如果确实需要修改此文件，请修改模板后重新生成。
namespace PD.Platform.DataAccess
{
    /// <summary>
    ///  TABLE
    /// </summary>
    public partial class AgreementDAO : AgreementEntity
    {
        private readonly DbContext dbContext;
        public AgreementDAO()
        {
            this.PropertyChanged += OnPropertyChanged;
            this.dbContext = new DbContext();
        }
        /// <summary>
        /// 必填字段构造器
        /// </summary>
        public AgreementDAO(long id, string ownerId, string agreementNo, string agreementName, long channelId, LimitMode limitMode, string templatePath, string templateParameters, string extJson, AgreementStatus status) : this()
        {
            this.Id = id;
            this.OwnerId = ownerId;
            this.AgreementNo = agreementNo;
            this.AgreementName = agreementName;
            this.ChannelId = channelId;
            this.LimitMode = limitMode;
            this.TemplatePath = templatePath;
            this.TemplateParameters = templateParameters;
            this.ExtJson = extJson;
            this.Status = status;
        }
        public AgreementDAO(AgreementEntity entity) : this()
        {
            Map(entity);
        }
        public static AgreementDAO From(AgreementEntity entity)
        {
            return new AgreementDAO(entity);
        }
        private SqlSugarClient GetDb()
        {
            return dbContext.Db;
        }
        private ISugarQueryable<AgreementDAO> Queryable()
        {
            return GetDb().Queryable<AgreementDAO>();
        }
        /// <summary>
        /// 主键查询，查不到数据则返回false
        /// </Summary>
        /// <param name="id">主键</param>
        /// <returns>true represent query success, otherwise false</returns>
		public bool GetById(long id)
        {
            var res = this.Queryable().Where(t => t.Id == id).First();
            if (res == null)
            {
                return false;
            }
            Map(res);
            return true;
        }
        public List<AgreementDAO> ListAll()
        {
            return this.Queryable().ToList();
        }
        public List<AgreementDAO> ListPage(IPagination page)
        {
            var queryable = this.Queryable();
            if (page == null)
            {
                return queryable.ToList();
            }
            int total = 0;
            var datalist = queryable.ToPageList(page.CurrentPageIndex, page.PageSize, ref total);
            page.Total = total;
            return datalist;
        }
        public bool Insert()
        {
            int eff = this.GetDb().Insertable(this).ExecuteCommand();
            ResetChangeProperties();
            return eff == 1;
        }
        /// <summary>
        /// 更新实体到数据库，仅修改变更过的属性
        /// </summary>
        /// <returns></returns>        
        public bool Update()
        {
            var updatable = this.GetDb().Updateable(this);
            if (IsDirty())
            {
                updatable.UpdateColumns(changedProperties.ToArray());
            }
            int eff = updatable.ExecuteCommand();
            ResetChangeProperties();
            return eff == 1;
        }
        /// <summary>
        /// 仅修改变更过的属性，指定where条件，where条件只能指定更新字段，不允许赋值，where条件值取自实体属性
        /// <para><code>
        /// UpdateBy(m=> new { m.AccountId, m.UserCode})
        /// </code></para>
        /// </summary>
        /// <returns></returns>        
        public bool UpdateBy(Expression<Func<AgreementDAO, object>> where)
        {
            var updatable = this.GetDb().Updateable(this);
            if (IsDirty())
            {
                updatable.UpdateColumns(changedProperties.ToArray());
            }
            int eff = updatable.WhereColumns(where).ExecuteCommand();
            ResetChangeProperties();
            return eff == 1;
        }
        public bool Delete()
        {
            int eff = this.GetDb().Deleteable(this).ExecuteCommand();
            return eff == 1;
        }
        public bool DeleteById(long id)
        {
            var res = this.GetDb().Deleteable<AgreementEntity>().Where(t => t.Id == id).ExecuteCommand();
            return res == 1;
        }
        #region PropertyChangedNotification Implemention
        private void Map(AgreementEntity entity)
        {
            entity.CopyTo(this);
            ResetChangeProperties();
        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!changedProperties.Contains(e.PropertyName))
            {
                changedProperties.Add(e.PropertyName);
            }
        }

        private readonly List<string> changedProperties = new List<string>();
        private bool IsDirty()
        {
            return changedProperties.Count > 0;
        }

        private void ResetChangeProperties()
        {
            changedProperties.Clear();
        }
        #endregion
    }
}