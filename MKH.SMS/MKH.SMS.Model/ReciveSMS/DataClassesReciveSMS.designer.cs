﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MKH.SMS.Model.ReciveSMS
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PhysiotherapyCare")]
	public partial class DataClassesReciveSMSDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_ReciveSM(TBL_ReciveSM instance);
    partial void UpdateTBL_ReciveSM(TBL_ReciveSM instance);
    partial void DeleteTBL_ReciveSM(TBL_ReciveSM instance);
    #endregion
		
		public DataClassesReciveSMSDataContext() : 
				base(global::MKH.SMS.Model.Properties.Settings.Default.PhysiotherapyCareConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesReciveSMSDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesReciveSMSDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesReciveSMSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesReciveSMSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_ReciveSM> TBL_ReciveSMs
		{
			get
			{
				return this.GetTable<TBL_ReciveSM>();
			}
		}
		
		public System.Data.Linq.Table<VW_ReciveSM> VW_ReciveSMs
		{
			get
			{
				return this.GetTable<VW_ReciveSM>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SMS.SP_ReciveSMSDelete")]
		public int SP_ReciveSMSDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, msgRet);
			msgRet = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SMS.SP_ReciveSMSUpdate")]
		public int SP_ReciveSMSUpdate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MessageID", DbType="BigInt")] System.Nullable<long> messageID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverNumber", DbType="VarChar(50)")] string reciverNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverName", DbType="NVarChar(50)")] string reciverName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverJob", DbType="NVarChar(50)")] string reciverJob, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciveDateTime", DbType="VarChar(20)")] string reciveDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MessageText", DbType="NVarChar(500)")] string messageText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RecipientNumber", DbType="VarChar(20)")] string recipientNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMS_Few", DbType="Int")] System.Nullable<int> sMS_Few, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(500)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Archive", DbType="Bit")] System.Nullable<bool> archive, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, messageID, reciverNumber, reciverName, reciverJob, reciveDateTime, messageText, recipientNumber, sMS_Few, description, archive, user_Id, changeDateTime, msgRet);
			msgRet = ((string)(result.GetParameterValue(13)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SMS.SP_ReciveSMSInsert")]
		public int SP_ReciveSMSInsert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] ref System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MessageID", DbType="BigInt")] System.Nullable<long> messageID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverNumber", DbType="VarChar(50)")] string reciverNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverName", DbType="NVarChar(50)")] string reciverName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciverJob", DbType="NVarChar(50)")] string reciverJob, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ReciveDateTime", DbType="VarChar(20)")] string reciveDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MessageText", DbType="NVarChar(500)")] string messageText, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RecipientNumber", DbType="VarChar(20)")] string recipientNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SMS_Few", DbType="Int")] System.Nullable<int> sMS_Few, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(500)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Archive", DbType="Bit")] System.Nullable<bool> archive, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, messageID, reciverNumber, reciverName, reciverJob, reciveDateTime, messageText, recipientNumber, sMS_Few, description, archive, user_Id, changeDateTime, msgRet);
			id = ((System.Nullable<long>)(result.GetParameterValue(0)));
			msgRet = ((string)(result.GetParameterValue(13)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="SMS.TBL_ReciveSMS")]
	public partial class TBL_ReciveSM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<long> _MessageID;
		
		private string _ReciverNumber;
		
		private string _ReciverName;
		
		private string _ReciverJob;
		
		private string _ReciveDateTime;
		
		private string _MessageText;
		
		private string _RecipientNumber;
		
		private System.Nullable<int> _SMS_Few;
		
		private string _Description;
		
		private System.Nullable<bool> _Archive;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnMessageIDChanging(System.Nullable<long> value);
    partial void OnMessageIDChanged();
    partial void OnReciverNumberChanging(string value);
    partial void OnReciverNumberChanged();
    partial void OnReciverNameChanging(string value);
    partial void OnReciverNameChanged();
    partial void OnReciverJobChanging(string value);
    partial void OnReciverJobChanged();
    partial void OnReciveDateTimeChanging(string value);
    partial void OnReciveDateTimeChanged();
    partial void OnMessageTextChanging(string value);
    partial void OnMessageTextChanged();
    partial void OnRecipientNumberChanging(string value);
    partial void OnRecipientNumberChanged();
    partial void OnSMS_FewChanging(System.Nullable<int> value);
    partial void OnSMS_FewChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnArchiveChanging(System.Nullable<bool> value);
    partial void OnArchiveChanged();
    partial void OnUser_IdChanging(System.Nullable<int> value);
    partial void OnUser_IdChanged();
    partial void OnChangeDateTimeChanging(string value);
    partial void OnChangeDateTimeChanged();
    #endregion
		
		public TBL_ReciveSM()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageID", DbType="BigInt")]
		public System.Nullable<long> MessageID
		{
			get
			{
				return this._MessageID;
			}
			set
			{
				if ((this._MessageID != value))
				{
					this.OnMessageIDChanging(value);
					this.SendPropertyChanging();
					this._MessageID = value;
					this.SendPropertyChanged("MessageID");
					this.OnMessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverNumber", DbType="VarChar(50)")]
		public string ReciverNumber
		{
			get
			{
				return this._ReciverNumber;
			}
			set
			{
				if ((this._ReciverNumber != value))
				{
					this.OnReciverNumberChanging(value);
					this.SendPropertyChanging();
					this._ReciverNumber = value;
					this.SendPropertyChanged("ReciverNumber");
					this.OnReciverNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverName", DbType="NVarChar(50)")]
		public string ReciverName
		{
			get
			{
				return this._ReciverName;
			}
			set
			{
				if ((this._ReciverName != value))
				{
					this.OnReciverNameChanging(value);
					this.SendPropertyChanging();
					this._ReciverName = value;
					this.SendPropertyChanged("ReciverName");
					this.OnReciverNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverJob", DbType="NVarChar(50)")]
		public string ReciverJob
		{
			get
			{
				return this._ReciverJob;
			}
			set
			{
				if ((this._ReciverJob != value))
				{
					this.OnReciverJobChanging(value);
					this.SendPropertyChanging();
					this._ReciverJob = value;
					this.SendPropertyChanged("ReciverJob");
					this.OnReciverJobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciveDateTime", DbType="VarChar(20)")]
		public string ReciveDateTime
		{
			get
			{
				return this._ReciveDateTime;
			}
			set
			{
				if ((this._ReciveDateTime != value))
				{
					this.OnReciveDateTimeChanging(value);
					this.SendPropertyChanging();
					this._ReciveDateTime = value;
					this.SendPropertyChanged("ReciveDateTime");
					this.OnReciveDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageText", DbType="NVarChar(500)")]
		public string MessageText
		{
			get
			{
				return this._MessageText;
			}
			set
			{
				if ((this._MessageText != value))
				{
					this.OnMessageTextChanging(value);
					this.SendPropertyChanging();
					this._MessageText = value;
					this.SendPropertyChanged("MessageText");
					this.OnMessageTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipientNumber", DbType="VarChar(20)")]
		public string RecipientNumber
		{
			get
			{
				return this._RecipientNumber;
			}
			set
			{
				if ((this._RecipientNumber != value))
				{
					this.OnRecipientNumberChanging(value);
					this.SendPropertyChanging();
					this._RecipientNumber = value;
					this.SendPropertyChanged("RecipientNumber");
					this.OnRecipientNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMS_Few", DbType="Int")]
		public System.Nullable<int> SMS_Few
		{
			get
			{
				return this._SMS_Few;
			}
			set
			{
				if ((this._SMS_Few != value))
				{
					this.OnSMS_FewChanging(value);
					this.SendPropertyChanging();
					this._SMS_Few = value;
					this.SendPropertyChanged("SMS_Few");
					this.OnSMS_FewChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Archive", DbType="Bit")]
		public System.Nullable<bool> Archive
		{
			get
			{
				return this._Archive;
			}
			set
			{
				if ((this._Archive != value))
				{
					this.OnArchiveChanging(value);
					this.SendPropertyChanging();
					this._Archive = value;
					this.SendPropertyChanged("Archive");
					this.OnArchiveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int")]
		public System.Nullable<int> User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this.OnUser_IdChanging(value);
					this.SendPropertyChanging();
					this._User_Id = value;
					this.SendPropertyChanged("User_Id");
					this.OnUser_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeDateTime", DbType="VarChar(20)")]
		public string ChangeDateTime
		{
			get
			{
				return this._ChangeDateTime;
			}
			set
			{
				if ((this._ChangeDateTime != value))
				{
					this.OnChangeDateTimeChanging(value);
					this.SendPropertyChanging();
					this._ChangeDateTime = value;
					this.SendPropertyChanged("ChangeDateTime");
					this.OnChangeDateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="SMS.VW_ReciveSMS")]
	public partial class VW_ReciveSM
	{
		
		private long _Id;
		
		private System.Nullable<long> _MessageID;
		
		private string _ReciverNumber;
		
		private string _ReciverName;
		
		private string _ReciverJob;
		
		private string _ReciveDateTime;
		
		private string _MessageText;
		
		private string _RecipientNumber;
		
		private System.Nullable<int> _SMS_Few;
		
		private string _Description;
		
		private System.Nullable<bool> _Archive;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
		private string _UsersNameFamily;
		
		public VW_ReciveSM()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="BigInt NOT NULL")]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageID", DbType="BigInt")]
		public System.Nullable<long> MessageID
		{
			get
			{
				return this._MessageID;
			}
			set
			{
				if ((this._MessageID != value))
				{
					this._MessageID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverNumber", DbType="VarChar(50)")]
		public string ReciverNumber
		{
			get
			{
				return this._ReciverNumber;
			}
			set
			{
				if ((this._ReciverNumber != value))
				{
					this._ReciverNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverName", DbType="NVarChar(50)")]
		public string ReciverName
		{
			get
			{
				return this._ReciverName;
			}
			set
			{
				if ((this._ReciverName != value))
				{
					this._ReciverName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciverJob", DbType="NVarChar(50)")]
		public string ReciverJob
		{
			get
			{
				return this._ReciverJob;
			}
			set
			{
				if ((this._ReciverJob != value))
				{
					this._ReciverJob = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReciveDateTime", DbType="VarChar(20)")]
		public string ReciveDateTime
		{
			get
			{
				return this._ReciveDateTime;
			}
			set
			{
				if ((this._ReciveDateTime != value))
				{
					this._ReciveDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageText", DbType="NVarChar(500)")]
		public string MessageText
		{
			get
			{
				return this._MessageText;
			}
			set
			{
				if ((this._MessageText != value))
				{
					this._MessageText = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RecipientNumber", DbType="VarChar(20)")]
		public string RecipientNumber
		{
			get
			{
				return this._RecipientNumber;
			}
			set
			{
				if ((this._RecipientNumber != value))
				{
					this._RecipientNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMS_Few", DbType="Int")]
		public System.Nullable<int> SMS_Few
		{
			get
			{
				return this._SMS_Few;
			}
			set
			{
				if ((this._SMS_Few != value))
				{
					this._SMS_Few = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(500)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Archive", DbType="Bit")]
		public System.Nullable<bool> Archive
		{
			get
			{
				return this._Archive;
			}
			set
			{
				if ((this._Archive != value))
				{
					this._Archive = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Id", DbType="Int")]
		public System.Nullable<int> User_Id
		{
			get
			{
				return this._User_Id;
			}
			set
			{
				if ((this._User_Id != value))
				{
					this._User_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChangeDateTime", DbType="VarChar(20)")]
		public string ChangeDateTime
		{
			get
			{
				return this._ChangeDateTime;
			}
			set
			{
				if ((this._ChangeDateTime != value))
				{
					this._ChangeDateTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsersNameFamily", DbType="NVarChar(201)")]
		public string UsersNameFamily
		{
			get
			{
				return this._UsersNameFamily;
			}
			set
			{
				if ((this._UsersNameFamily != value))
				{
					this._UsersNameFamily = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
