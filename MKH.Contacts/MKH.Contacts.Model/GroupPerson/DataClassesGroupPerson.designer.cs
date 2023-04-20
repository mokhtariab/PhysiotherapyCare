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

namespace MKH.Contacts.Model.GroupPerson
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
	public partial class DataClassesGroupPersonDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_GroupPerson(TBL_GroupPerson instance);
    partial void UpdateTBL_GroupPerson(TBL_GroupPerson instance);
    partial void DeleteTBL_GroupPerson(TBL_GroupPerson instance);
    #endregion
		
		public DataClassesGroupPersonDataContext() : 
				base(global::MKH.Contacts.Model.Properties.Settings.Default.PhysiotherapyCareConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesGroupPersonDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesGroupPersonDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesGroupPersonDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesGroupPersonDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_GroupPerson> TBL_GroupPersons
		{
			get
			{
				return this.GetTable<TBL_GroupPerson>();
			}
		}
		
		public System.Data.Linq.Table<VW_GroupPerson> VW_GroupPersons
		{
			get
			{
				return this.GetTable<VW_GroupPerson>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="TEL.SP_GroupPersonDelete")]
		public int SP_GroupPersonDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Group_ID", DbType="Int")] System.Nullable<int> group_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Person_ID", DbType="Int")] System.Nullable<int> person_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), group_ID, person_ID, msgRet);
			msgRet = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="TEL.SP_GroupPersonInsert")]
		public int SP_GroupPersonInsert([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Group_ID", DbType="Int")] System.Nullable<int> group_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Person_ID", DbType="Int")] System.Nullable<int> person_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), group_ID, person_ID, msgRet);
			msgRet = ((string)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="TEL.TBL_GroupPerson")]
	public partial class TBL_GroupPerson : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Group_ID;
		
		private int _Person_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGroup_IDChanging(int value);
    partial void OnGroup_IDChanged();
    partial void OnPerson_IDChanging(int value);
    partial void OnPerson_IDChanged();
    #endregion
		
		public TBL_GroupPerson()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Group_ID
		{
			get
			{
				return this._Group_ID;
			}
			set
			{
				if ((this._Group_ID != value))
				{
					this.OnGroup_IDChanging(value);
					this.SendPropertyChanging();
					this._Group_ID = value;
					this.SendPropertyChanged("Group_ID");
					this.OnGroup_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Person_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Person_ID
		{
			get
			{
				return this._Person_ID;
			}
			set
			{
				if ((this._Person_ID != value))
				{
					this.OnPerson_IDChanging(value);
					this.SendPropertyChanging();
					this._Person_ID = value;
					this.SendPropertyChanged("Person_ID");
					this.OnPerson_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="TEL.VW_GroupPerson")]
	public partial class VW_GroupPerson
	{
		
		private int _Group_ID;
		
		private int _Person_ID;
		
		public VW_GroupPerson()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Group_ID", DbType="Int NOT NULL")]
		public int Group_ID
		{
			get
			{
				return this._Group_ID;
			}
			set
			{
				if ((this._Group_ID != value))
				{
					this._Group_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Person_ID", DbType="Int NOT NULL")]
		public int Person_ID
		{
			get
			{
				return this._Person_ID;
			}
			set
			{
				if ((this._Person_ID != value))
				{
					this._Person_ID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591