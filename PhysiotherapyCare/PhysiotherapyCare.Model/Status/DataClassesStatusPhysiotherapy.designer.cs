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

namespace PhysiotherapyCare.Model.Status
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
	public partial class DataClassesStatusPhysiotherapyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_StatusTypeDetailPhysiotherapy(TBL_StatusTypeDetailPhysiotherapy instance);
    partial void UpdateTBL_StatusTypeDetailPhysiotherapy(TBL_StatusTypeDetailPhysiotherapy instance);
    partial void DeleteTBL_StatusTypeDetailPhysiotherapy(TBL_StatusTypeDetailPhysiotherapy instance);
    #endregion
		
		public DataClassesStatusPhysiotherapyDataContext() : 
				base(global::PhysiotherapyCare.Model.Properties.Settings.Default.PhysiotherapyCareConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusPhysiotherapyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusPhysiotherapyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusPhysiotherapyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesStatusPhysiotherapyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_StatusTypeDetailPhysiotherapy> TBL_StatusTypeDetailPhysiotherapies
		{
			get
			{
				return this.GetTable<TBL_StatusTypeDetailPhysiotherapy>();
			}
		}
		
		public System.Data.Linq.Table<VW_StatusTypeDetailPhysiotherapy> VW_StatusTypeDetailPhysiotherapies
		{
			get
			{
				return this.GetTable<VW_StatusTypeDetailPhysiotherapy>();
			}
		}
		
		public System.Data.Linq.Table<VW_StatusTypeDetailPhysiotherapyReport> VW_StatusTypeDetailPhysiotherapyReports
		{
			get
			{
				return this.GetTable<VW_StatusTypeDetailPhysiotherapyReport>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="STA.SP_StatusTypeDetailPhysiotherapyUpdate")]
		public int SP_StatusTypeDetailPhysiotherapyUpdate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VisitPatientPhysiotherapy_Id", DbType="BigInt")] System.Nullable<long> visitPatientPhysiotherapy_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatusTypeDetail_Id", DbType="Int")] System.Nullable<int> statusTypeDetail_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ConfirmSet", DbType="Bit")] System.Nullable<bool> confirmSet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(1000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StartDateAlarm", DbType="VarChar(10)")] string startDateAlarm, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FReserve1", DbType="NVarChar(1000)")] string fReserve1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, visitPatientPhysiotherapy_Id, statusTypeDetail_Id, confirmSet, description, startDateAlarm, fReserve1, user_Id, changeDateTime, msgRet);
			msgRet = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="STA.SP_StatusTypeDetailPhysiotherapyInsert")]
		public int SP_StatusTypeDetailPhysiotherapyInsert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] ref System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VisitPatientPhysiotherapy_Id", DbType="BigInt")] System.Nullable<long> visitPatientPhysiotherapy_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StatusTypeDetail_Id", DbType="Int")] System.Nullable<int> statusTypeDetail_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ConfirmSet", DbType="Bit")] System.Nullable<bool> confirmSet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Description", DbType="NVarChar(1000)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="StartDateAlarm", DbType="VarChar(10)")] string startDateAlarm, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="FReserve1", DbType="NVarChar(1000)")] string fReserve1, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, visitPatientPhysiotherapy_Id, statusTypeDetail_Id, confirmSet, description, startDateAlarm, fReserve1, user_Id, changeDateTime, msgRet);
			id = ((System.Nullable<long>)(result.GetParameterValue(0)));
			msgRet = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="STA.SP_StatusTypeDetailPhysiotherapyDeleteWithPhysiotherapyId")]
		public int SP_StatusTypeDetailPhysiotherapyDeleteWithPhysiotherapyId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="VisitPatientPhysiotherapy_Id", DbType="BigInt")] System.Nullable<long> visitPatientPhysiotherapy_Id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), visitPatientPhysiotherapy_Id, msgRet);
			msgRet = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="STA.SP_StatusTypeDetailPhysiotherapyDelete")]
		public int SP_StatusTypeDetailPhysiotherapyDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, msgRet);
			msgRet = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="STA.TBL_StatusTypeDetailPhysiotherapy")]
	public partial class TBL_StatusTypeDetailPhysiotherapy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _Id;
		
		private System.Nullable<long> _VisitPatientPhysiotherapy_Id;
		
		private System.Nullable<int> _StatusTypeDetail_Id;
		
		private System.Nullable<bool> _ConfirmSet;
		
		private string _Description;
		
		private string _StartDateAlarm;
		
		private string _FReserve1;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnVisitPatientPhysiotherapy_IdChanging(System.Nullable<long> value);
    partial void OnVisitPatientPhysiotherapy_IdChanged();
    partial void OnStatusTypeDetail_IdChanging(System.Nullable<int> value);
    partial void OnStatusTypeDetail_IdChanged();
    partial void OnConfirmSetChanging(System.Nullable<bool> value);
    partial void OnConfirmSetChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnStartDateAlarmChanging(string value);
    partial void OnStartDateAlarmChanged();
    partial void OnFReserve1Changing(string value);
    partial void OnFReserve1Changed();
    partial void OnUser_IdChanging(System.Nullable<int> value);
    partial void OnUser_IdChanged();
    partial void OnChangeDateTimeChanging(string value);
    partial void OnChangeDateTimeChanged();
    #endregion
		
		public TBL_StatusTypeDetailPhysiotherapy()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitPatientPhysiotherapy_Id", DbType="BigInt")]
		public System.Nullable<long> VisitPatientPhysiotherapy_Id
		{
			get
			{
				return this._VisitPatientPhysiotherapy_Id;
			}
			set
			{
				if ((this._VisitPatientPhysiotherapy_Id != value))
				{
					this.OnVisitPatientPhysiotherapy_IdChanging(value);
					this.SendPropertyChanging();
					this._VisitPatientPhysiotherapy_Id = value;
					this.SendPropertyChanged("VisitPatientPhysiotherapy_Id");
					this.OnVisitPatientPhysiotherapy_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeDetail_Id", DbType="Int")]
		public System.Nullable<int> StatusTypeDetail_Id
		{
			get
			{
				return this._StatusTypeDetail_Id;
			}
			set
			{
				if ((this._StatusTypeDetail_Id != value))
				{
					this.OnStatusTypeDetail_IdChanging(value);
					this.SendPropertyChanging();
					this._StatusTypeDetail_Id = value;
					this.SendPropertyChanged("StatusTypeDetail_Id");
					this.OnStatusTypeDetail_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmSet", DbType="Bit")]
		public System.Nullable<bool> ConfirmSet
		{
			get
			{
				return this._ConfirmSet;
			}
			set
			{
				if ((this._ConfirmSet != value))
				{
					this.OnConfirmSetChanging(value);
					this.SendPropertyChanging();
					this._ConfirmSet = value;
					this.SendPropertyChanged("ConfirmSet");
					this.OnConfirmSetChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDateAlarm", DbType="VarChar(10)")]
		public string StartDateAlarm
		{
			get
			{
				return this._StartDateAlarm;
			}
			set
			{
				if ((this._StartDateAlarm != value))
				{
					this.OnStartDateAlarmChanging(value);
					this.SendPropertyChanging();
					this._StartDateAlarm = value;
					this.SendPropertyChanged("StartDateAlarm");
					this.OnStartDateAlarmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FReserve1", DbType="NVarChar(500)")]
		public string FReserve1
		{
			get
			{
				return this._FReserve1;
			}
			set
			{
				if ((this._FReserve1 != value))
				{
					this.OnFReserve1Changing(value);
					this.SendPropertyChanging();
					this._FReserve1 = value;
					this.SendPropertyChanged("FReserve1");
					this.OnFReserve1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="STA.VW_StatusTypeDetailPhysiotherapy")]
	public partial class VW_StatusTypeDetailPhysiotherapy
	{
		
		private long _Id;
		
		private System.Nullable<long> _VisitPatientPhysiotherapy_Id;
		
		private System.Nullable<int> _StatusTypeDetail_Id;
		
		private System.Nullable<bool> _ConfirmSet;
		
		private string _Description;
		
		private string _StartDateAlarm;
		
		private string _FReserve1;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
		private string _UsersNameFamily;
		
		private string _StatusTypeName;
		
		private string _StatusTypeDetailName;
		
		public VW_StatusTypeDetailPhysiotherapy()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitPatientPhysiotherapy_Id", DbType="BigInt")]
		public System.Nullable<long> VisitPatientPhysiotherapy_Id
		{
			get
			{
				return this._VisitPatientPhysiotherapy_Id;
			}
			set
			{
				if ((this._VisitPatientPhysiotherapy_Id != value))
				{
					this._VisitPatientPhysiotherapy_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeDetail_Id", DbType="Int")]
		public System.Nullable<int> StatusTypeDetail_Id
		{
			get
			{
				return this._StatusTypeDetail_Id;
			}
			set
			{
				if ((this._StatusTypeDetail_Id != value))
				{
					this._StatusTypeDetail_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmSet", DbType="Bit")]
		public System.Nullable<bool> ConfirmSet
		{
			get
			{
				return this._ConfirmSet;
			}
			set
			{
				if ((this._ConfirmSet != value))
				{
					this._ConfirmSet = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDateAlarm", DbType="VarChar(10)")]
		public string StartDateAlarm
		{
			get
			{
				return this._StartDateAlarm;
			}
			set
			{
				if ((this._StartDateAlarm != value))
				{
					this._StartDateAlarm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FReserve1", DbType="NVarChar(500)")]
		public string FReserve1
		{
			get
			{
				return this._FReserve1;
			}
			set
			{
				if ((this._FReserve1 != value))
				{
					this._FReserve1 = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeName", DbType="VarChar(50)")]
		public string StatusTypeName
		{
			get
			{
				return this._StatusTypeName;
			}
			set
			{
				if ((this._StatusTypeName != value))
				{
					this._StatusTypeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeDetailName", DbType="VarChar(100)")]
		public string StatusTypeDetailName
		{
			get
			{
				return this._StatusTypeDetailName;
			}
			set
			{
				if ((this._StatusTypeDetailName != value))
				{
					this._StatusTypeDetailName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="STA.VW_StatusTypeDetailPhysiotherapyReport")]
	public partial class VW_StatusTypeDetailPhysiotherapyReport
	{
		
		private long _Id;
		
		private System.Nullable<long> _VisitPatientPhysiotherapy_Id;
		
		private System.Nullable<int> _StatusTypeDetail_Id;
		
		private System.Nullable<bool> _ConfirmSet;
		
		private string _Description;
		
		private string _StartDateAlarm;
		
		private string _FReserve1;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
		private string _UsersNameFamily;
		
		private string _StatusTypeName;
		
		private string _StatusTypeDetailName;
		
		private string _PatientName;
		
		private string _PatientFamily;
		
		private string _NationalCode;
		
		private string _DoctorName;
		
		private string _DoctorFamily;
		
		public VW_StatusTypeDetailPhysiotherapyReport()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VisitPatientPhysiotherapy_Id", DbType="BigInt")]
		public System.Nullable<long> VisitPatientPhysiotherapy_Id
		{
			get
			{
				return this._VisitPatientPhysiotherapy_Id;
			}
			set
			{
				if ((this._VisitPatientPhysiotherapy_Id != value))
				{
					this._VisitPatientPhysiotherapy_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeDetail_Id", DbType="Int")]
		public System.Nullable<int> StatusTypeDetail_Id
		{
			get
			{
				return this._StatusTypeDetail_Id;
			}
			set
			{
				if ((this._StatusTypeDetail_Id != value))
				{
					this._StatusTypeDetail_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmSet", DbType="Bit")]
		public System.Nullable<bool> ConfirmSet
		{
			get
			{
				return this._ConfirmSet;
			}
			set
			{
				if ((this._ConfirmSet != value))
				{
					this._ConfirmSet = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDateAlarm", DbType="VarChar(10)")]
		public string StartDateAlarm
		{
			get
			{
				return this._StartDateAlarm;
			}
			set
			{
				if ((this._StartDateAlarm != value))
				{
					this._StartDateAlarm = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FReserve1", DbType="NVarChar(500)")]
		public string FReserve1
		{
			get
			{
				return this._FReserve1;
			}
			set
			{
				if ((this._FReserve1 != value))
				{
					this._FReserve1 = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeName", DbType="VarChar(50)")]
		public string StatusTypeName
		{
			get
			{
				return this._StatusTypeName;
			}
			set
			{
				if ((this._StatusTypeName != value))
				{
					this._StatusTypeName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StatusTypeDetailName", DbType="VarChar(100)")]
		public string StatusTypeDetailName
		{
			get
			{
				return this._StatusTypeDetailName;
			}
			set
			{
				if ((this._StatusTypeDetailName != value))
				{
					this._StatusTypeDetailName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="NVarChar(50)")]
		public string PatientName
		{
			get
			{
				return this._PatientName;
			}
			set
			{
				if ((this._PatientName != value))
				{
					this._PatientName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientFamily", DbType="NVarChar(50)")]
		public string PatientFamily
		{
			get
			{
				return this._PatientFamily;
			}
			set
			{
				if ((this._PatientFamily != value))
				{
					this._PatientFamily = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NationalCode", DbType="NVarChar(50)")]
		public string NationalCode
		{
			get
			{
				return this._NationalCode;
			}
			set
			{
				if ((this._NationalCode != value))
				{
					this._NationalCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="NVarChar(50)")]
		public string DoctorName
		{
			get
			{
				return this._DoctorName;
			}
			set
			{
				if ((this._DoctorName != value))
				{
					this._DoctorName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorFamily", DbType="NVarChar(50)")]
		public string DoctorFamily
		{
			get
			{
				return this._DoctorFamily;
			}
			set
			{
				if ((this._DoctorFamily != value))
				{
					this._DoctorFamily = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
