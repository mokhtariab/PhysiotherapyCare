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

namespace MKH.Permission.Model.SoftwareAccess
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
	public partial class DataClassesSoftwareAccessDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_SoftwareAccess(TBL_SoftwareAccess instance);
    partial void UpdateTBL_SoftwareAccess(TBL_SoftwareAccess instance);
    partial void DeleteTBL_SoftwareAccess(TBL_SoftwareAccess instance);
    #endregion
		
		public DataClassesSoftwareAccessDataContext() : 
				base(global::MKH.Permission.Model.Properties.Settings.Default.PhysiotherapyCareConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSoftwareAccessDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSoftwareAccessDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSoftwareAccessDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesSoftwareAccessDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VW_SoftwareAccess> VW_SoftwareAccesses
		{
			get
			{
				return this.GetTable<VW_SoftwareAccess>();
			}
		}
		
		public System.Data.Linq.Table<TBL_SoftwareAccess> TBL_SoftwareAccesses
		{
			get
			{
				return this.GetTable<TBL_SoftwareAccess>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SEC.SP_SoftwareAccessDelete")]
		public int SP_SoftwareAccessDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, msgRet);
			msgRet = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SEC.SP_SoftwareAccessInsert")]
		public int SP_SoftwareAccessInsert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] ref System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentId", DbType="Int")] System.Nullable<int> parentId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceNameFarsi", DbType="NVarChar(100)")] string resourceNameFarsi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceName", DbType="VarChar(100)")] string resourceName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceLevel", DbType="Int")] System.Nullable<int> resourceLevel, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, parentId, resourceNameFarsi, resourceName, resourceLevel, isActive, msgRet);
			id = ((System.Nullable<int>)(result.GetParameterValue(0)));
			msgRet = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="SEC.SP_SoftwareAccessUpdate")]
		public int SP_SoftwareAccessUpdate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentId", DbType="Int")] System.Nullable<int> parentId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceNameFarsi", DbType="NVarChar(100)")] string resourceNameFarsi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceName", DbType="VarChar(100)")] string resourceName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ResourceLevel", DbType="Int")] System.Nullable<int> resourceLevel, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IsActive", DbType="Bit")] System.Nullable<bool> isActive, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, parentId, resourceNameFarsi, resourceName, resourceLevel, isActive, msgRet);
			msgRet = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="SEC.VW_SoftwareAccess")]
	public partial class VW_SoftwareAccess
	{
		
		private int _Id;
		
		private System.Nullable<int> _ParentId;
		
		private string _ResourceNameFarsi;
		
		private string _ResourceName;
		
		private System.Nullable<int> _ResourceLevel;
		
		private System.Nullable<bool> _IsActive;
		
		public VW_SoftwareAccess()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentId", DbType="Int")]
		public System.Nullable<int> ParentId
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					this._ParentId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceNameFarsi", DbType="NVarChar(100)")]
		public string ResourceNameFarsi
		{
			get
			{
				return this._ResourceNameFarsi;
			}
			set
			{
				if ((this._ResourceNameFarsi != value))
				{
					this._ResourceNameFarsi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceName", DbType="VarChar(100)")]
		public string ResourceName
		{
			get
			{
				return this._ResourceName;
			}
			set
			{
				if ((this._ResourceName != value))
				{
					this._ResourceName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceLevel", DbType="Int")]
		public System.Nullable<int> ResourceLevel
		{
			get
			{
				return this._ResourceLevel;
			}
			set
			{
				if ((this._ResourceLevel != value))
				{
					this._ResourceLevel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this._IsActive = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="SEC.TBL_SoftwareAccess")]
	public partial class TBL_SoftwareAccess : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _ParentId;
		
		private string _ResourceNameFarsi;
		
		private string _ResourceName;
		
		private System.Nullable<int> _ResourceLevel;
		
		private System.Nullable<bool> _IsActive;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnParentIdChanging(System.Nullable<int> value);
    partial void OnParentIdChanged();
    partial void OnResourceNameFarsiChanging(string value);
    partial void OnResourceNameFarsiChanged();
    partial void OnResourceNameChanging(string value);
    partial void OnResourceNameChanged();
    partial void OnResourceLevelChanging(System.Nullable<int> value);
    partial void OnResourceLevelChanged();
    partial void OnIsActiveChanging(System.Nullable<bool> value);
    partial void OnIsActiveChanged();
    #endregion
		
		public TBL_SoftwareAccess()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentId", DbType="Int")]
		public System.Nullable<int> ParentId
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					this.OnParentIdChanging(value);
					this.SendPropertyChanging();
					this._ParentId = value;
					this.SendPropertyChanged("ParentId");
					this.OnParentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceNameFarsi", DbType="NVarChar(100)")]
		public string ResourceNameFarsi
		{
			get
			{
				return this._ResourceNameFarsi;
			}
			set
			{
				if ((this._ResourceNameFarsi != value))
				{
					this.OnResourceNameFarsiChanging(value);
					this.SendPropertyChanging();
					this._ResourceNameFarsi = value;
					this.SendPropertyChanged("ResourceNameFarsi");
					this.OnResourceNameFarsiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceName", DbType="VarChar(100)")]
		public string ResourceName
		{
			get
			{
				return this._ResourceName;
			}
			set
			{
				if ((this._ResourceName != value))
				{
					this.OnResourceNameChanging(value);
					this.SendPropertyChanging();
					this._ResourceName = value;
					this.SendPropertyChanged("ResourceName");
					this.OnResourceNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResourceLevel", DbType="Int")]
		public System.Nullable<int> ResourceLevel
		{
			get
			{
				return this._ResourceLevel;
			}
			set
			{
				if ((this._ResourceLevel != value))
				{
					this.OnResourceLevelChanging(value);
					this.SendPropertyChanging();
					this._ResourceLevel = value;
					this.SendPropertyChanged("ResourceLevel");
					this.OnResourceLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsActive", DbType="Bit")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this._IsActive;
			}
			set
			{
				if ((this._IsActive != value))
				{
					this.OnIsActiveChanging(value);
					this.SendPropertyChanging();
					this._IsActive = value;
					this.SendPropertyChanged("IsActive");
					this.OnIsActiveChanged();
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
}
#pragma warning restore 1591