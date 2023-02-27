 /***************************************************
 *
 * Entity Model Of SqlSugar
 * FileName : AgreementEntity.cs
 * CreateTime : 2023-02-25 14:37:53
 * CodeGenerateVersion : 1.0.0.0
 * TemplateVersion: 2.0.0
 * TemplateName: 数据实体对象.txt
 * E_Mail : jason.geek@qq.com
 * Blog : 
 * Copyright (C) ZYS
 * 
 ***************************************************/
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SqlSugar;
using PD.Platform.Enums;
using PD.Platform.Utils;

//DO NOT MODIFY PLEASE!!!!! this file was created by auto generated, if you want modify indeed please modify the template and regenerate this file
//请不要尝试修改此文件！！！！这个文件是由代码生成器生成的。如果确实需要修改此文件，请修改模板后重新生成。
namespace PD.Platform.Entity
{
    /// <summary>
    ///  TABLE
    /// </summary>
    [SugarTable("tuas_agreement")]
    public class AgreementEntity : INotifyPropertyChanged
    {
        public AgreementEntity() 
        {
            this._id = Snowflake.Next();
            this._ownerId = null;
            this._agreementNo = null;
            this._agreementName = null;
            this._channelId = 0;
            this._limitMode = 0;
            this._templatePath = null;
            this._templateParameters = null;
            this._extJson = null;
            this._status = 0;
        }
        /// <summary>
        /// 必填字段构造器
        /// </summary>
        public AgreementEntity(long id, string ownerId, string agreementNo, string agreementName, long channelId, LimitMode limitMode, string templatePath, string templateParameters, string extJson, AgreementStatus status) : this()
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
        private long _id;
		/// <summary>
		/// 主键(必填)
		/// <para>
		/// defaultValue: DBNull.Value;   bigint(0)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "id",IsPrimaryKey = true)]
        public long Id
		{
            get { return _id; }
            set { OnPropertyChanged(_id, value); _id = value; }
		}
        private string _ownerId;
		/// <summary>
		/// 协议拥有者(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(50)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "owner_id")]
        public string OwnerId
		{
            get { return _ownerId; }
            set { OnPropertyChanged(_ownerId, value); _ownerId = value; }
		}
        private string _agreementNo;
		/// <summary>
		/// 协议编号(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(50)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "agreement_no")]
        public string AgreementNo
		{
            get { return _agreementNo; }
            set { OnPropertyChanged(_agreementNo, value); _agreementNo = value; }
		}
        private string _agreementName;
		/// <summary>
		/// 协议标题(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(1000)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "agreement_name")]
        public string AgreementName
		{
            get { return _agreementName; }
            set { OnPropertyChanged(_agreementName, value); _agreementName = value; }
		}
        private long _channelId;
		/// <summary>
		/// 通道编号(必填)
		/// <para>
		/// defaultValue: DBNull.Value;   bigint(0)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "channel_id")]
        public long ChannelId
		{
            get { return _channelId; }
            set { OnPropertyChanged(_channelId, value); _channelId = value; }
		}
        private LimitMode _limitMode;
		/// <summary>
		/// 限制模式$LimitMode${单一签署=0,重复签署=1}(必填)
		/// <para>
		/// defaultValue: 0;   int(0)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "limit_mode")]
        public LimitMode LimitMode
		{
            get { return _limitMode; }
            set { OnPropertyChanged(_limitMode, value); _limitMode = value; }
		}
        private string _templatePath;
		/// <summary>
		/// 协议内容模板路径，支持http地址(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(2000)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "template_path")]
        public string TemplatePath
		{
            get { return _templatePath; }
            set { OnPropertyChanged(_templatePath, value); _templatePath = value; }
		}
        private string _templateParameters;
		/// <summary>
		/// 模板需要用到的参数，使用Json格式保存，无参数时则默认为{}(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(2000)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "template_parameters")]
        public string TemplateParameters
		{
            get { return _templateParameters; }
            set { OnPropertyChanged(_templateParameters, value); _templateParameters = value; }
		}
        private string _extJson;
		/// <summary>
		/// 预留扩展字段(必填)
		/// <para>
		/// defaultValue: string.Empty;   varchar(2000)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "ext_json")]
        public string ExtJson
		{
            get { return _extJson; }
            set { OnPropertyChanged(_extJson, value); _extJson = value; }
		}
        private AgreementStatus _status;
		/// <summary>
		/// 协议状态$AgreementStatus${未启用=0,已启用=1,已删除=2}(必填)
		/// <para>
		/// defaultValue: 0;   int(0)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "status")]
        public AgreementStatus Status
		{
            get { return _status; }
            set { OnPropertyChanged(_status, value); _status = value; }
		}
        private DateTime? _createTime;
		/// <summary>
		/// (可空)
		/// <para>
		/// defaultValue: DateTime.Now;   datetime(0)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "create_time", IsOnlyIgnoreUpdate = true, IsOnlyIgnoreInsert = true)]
        public DateTime? CreateTime
		{
            get { return _createTime; }
            set { OnPropertyChanged(_createTime, value); _createTime = value; }
		}
        private string _remark;
		/// <summary>
		/// 备注(可空)
		/// <para>
		/// defaultValue: DBNull.Value;   varchar(255)
		/// </para>
		/// </summary>	
		[SugarColumn(ColumnName = "remark")]
        public string Remark
		{
            get { return _remark; }
            set { OnPropertyChanged(_remark, value); _remark = value; }
		}
        #region NotifyPropertyChanged Implemention
        public event PropertyChangedEventHandler PropertyChanged;
        public void CopyTo(AgreementEntity entity)
        {
            entity.Id = this.Id;
            entity.OwnerId = this.OwnerId;
            entity.AgreementNo = this.AgreementNo;
            entity.AgreementName = this.AgreementName;
            entity.ChannelId = this.ChannelId;
            entity.LimitMode = this.LimitMode;
            entity.TemplatePath = this.TemplatePath;
            entity.TemplateParameters = this.TemplateParameters;
            entity.ExtJson = this.ExtJson;
            entity.Status = this.Status;
            entity.CreateTime = this.CreateTime;
            entity.Remark = this.Remark;
        }
        private void OnPropertyChanged<T>(T originalValue, T newValue, [CallerMemberName] string name = null)
        {
            if (!object.Equals(originalValue, newValue) || object.Equals(default(T), newValue))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedArgs(name, originalValue, newValue));
            }
        }
        #endregion
    }
}