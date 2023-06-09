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

namespace PhysiotherapyCare.Model.Doctors
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
	public partial class DataClassesDoctorsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_Doctor(TBL_Doctor instance);
    partial void UpdateTBL_Doctor(TBL_Doctor instance);
    partial void DeleteTBL_Doctor(TBL_Doctor instance);
    #endregion
		
		public DataClassesDoctorsDataContext() : 
				base(global::PhysiotherapyCare.Model.Properties.Settings.Default.PhysiotherapyCareConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDoctorsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDoctorsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDoctorsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDoctorsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<VW_Doctor> VW_Doctors
		{
			get
			{
				return this.GetTable<VW_Doctor>();
			}
		}
		
		public System.Data.Linq.Table<TBL_Doctor> TBL_Doctors
		{
			get
			{
				return this.GetTable<TBL_Doctor>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_DoctorsDelete")]
		public int SP_DoctorsDelete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(2000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, msgRet);
			msgRet = ((string)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_DoctorsInsert")]
		public int SP_DoctorsInsert(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] ref System.Nullable<int> id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorParent_Id", DbType="Int")] System.Nullable<int> doctorParent_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MedicalCode", DbType="VarChar(20)")] string medicalCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CreateDate", DbType="VarChar(20)")] string createDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorPic", DbType="Image")] System.Data.Linq.Binary doctorPic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorName", DbType="NVarChar(50)")] string doctorName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorFamily", DbType="NVarChar(50)")] string doctorFamily, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentName", DbType="NVarChar(50)")] string parentName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNO", DbType="VarChar(20)")] string iDNO, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NationalCode", DbType="VarChar(20)")] string nationalCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BrithDate", DbType="VarChar(10)")] string brithDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BrithCityName", DbType="NVarChar(50)")] string brithCityName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorType_Id", DbType="SmallInt")] System.Nullable<short> doctorType_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AddressPart", DbType="SmallInt")] System.Nullable<short> addressPart, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Address", DbType="NVarChar(4000)")] string address, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelHome", DbType="VarChar(50)")] string telHome, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelBusiness", DbType="VarChar(50)")] string telBusiness, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mobile", DbType="VarChar(50)")] string mobile, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bank_Id", DbType="SmallInt")] System.Nullable<short> bank_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CardBankNo1", DbType="VarChar(100)")] string cardBankNo1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CardBankNo2", DbType="VarChar(100)")] string cardBankNo2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorPrice", DbType="BigInt")] System.Nullable<long> doctorPrice, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorTaxPercent", DbType="SmallInt")] System.Nullable<short> doctorTaxPercent, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Active", DbType="Bit")] System.Nullable<bool> active, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, doctorParent_Id, medicalCode, createDate, doctorPic, doctorName, doctorFamily, parentName, iDNO, nationalCode, brithDate, brithCityName, doctorType_Id, addressPart, address, telHome, telBusiness, mobile, email, bank_Id, cardBankNo1, cardBankNo2, doctorPrice, doctorTaxPercent, active, user_Id, changeDateTime, msgRet);
			id = ((System.Nullable<int>)(result.GetParameterValue(0)));
			msgRet = ((string)(result.GetParameterValue(27)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SP_DoctorsUpdate")]
		public int SP_DoctorsUpdate(
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorParent_Id", DbType="Int")] System.Nullable<int> doctorParent_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="MedicalCode", DbType="VarChar(20)")] string medicalCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CreateDate", DbType="VarChar(20)")] string createDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorPic", DbType="Image")] System.Data.Linq.Binary doctorPic, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorName", DbType="NVarChar(50)")] string doctorName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorFamily", DbType="NVarChar(50)")] string doctorFamily, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ParentName", DbType="NVarChar(50)")] string parentName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDNO", DbType="VarChar(20)")] string iDNO, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="NationalCode", DbType="VarChar(20)")] string nationalCode, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BrithDate", DbType="VarChar(10)")] string brithDate, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="BrithCityName", DbType="NVarChar(50)")] string brithCityName, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorType_Id", DbType="SmallInt")] System.Nullable<short> doctorType_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="AddressPart", DbType="SmallInt")] System.Nullable<short> addressPart, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Address", DbType="NVarChar(4000)")] string address, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelHome", DbType="VarChar(50)")] string telHome, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="TelBusiness", DbType="VarChar(50)")] string telBusiness, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Mobile", DbType="VarChar(50)")] string mobile, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(50)")] string email, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Bank_Id", DbType="SmallInt")] System.Nullable<short> bank_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CardBankNo1", DbType="VarChar(100)")] string cardBankNo1, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="CardBankNo2", DbType="VarChar(100)")] string cardBankNo2, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorPrice", DbType="BigInt")] System.Nullable<long> doctorPrice, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="DoctorTaxPercent", DbType="SmallInt")] System.Nullable<short> doctorTaxPercent, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="Active", DbType="Bit")] System.Nullable<bool> active, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="User_Id", DbType="Int")] System.Nullable<int> user_Id, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChangeDateTime", DbType="VarChar(20)")] string changeDateTime, 
					[global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1000)")] ref string msgRet)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, doctorParent_Id, medicalCode, createDate, doctorPic, doctorName, doctorFamily, parentName, iDNO, nationalCode, brithDate, brithCityName, doctorType_Id, addressPart, address, telHome, telBusiness, mobile, email, bank_Id, cardBankNo1, cardBankNo2, doctorPrice, doctorTaxPercent, active, user_Id, changeDateTime, msgRet);
			msgRet = ((string)(result.GetParameterValue(27)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VW_Doctors")]
	public partial class VW_Doctor
	{
		
		private int _Id;
		
		private string _MedicalCode;
		
		private string _CreateDate;
		
		private string _DoctorName;
		
		private string _DoctorFamily;
		
		private string _ParentName;
		
		private string _IDNO;
		
		private string _NationalCode;
		
		private string _BrithDate;
		
		private string _BrithCityName;
		
		private System.Nullable<short> _DoctorType_Id;
		
		private System.Nullable<short> _AddressPart;
		
		private string _Address;
		
		private string _TelHome;
		
		private string _TelBusiness;
		
		private string _Mobile;
		
		private string _Email;
		
		private string _CardBankNo1;
		
		private string _CardBankNo2;
		
		private System.Nullable<long> _DoctorPrice;
		
		private System.Nullable<bool> _Active;
		
		private string _DoctorTypeTitleName;
		
		private System.Nullable<short> _Bank_Id;
		
		private string _BankName;
		
		private string _ContractNo;
		
		private string _ContractDate;
		
		private string _ContractEndDate;
		
		private string _LocationPart;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
		private string _UsersNameFamily;
		
		private System.Nullable<int> _DoctorParent_Id;
		
		private string _DoctorParentsNameFamily;
		
		private System.Nullable<short> _DoctorTaxPercent;
		
		public VW_Doctor()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicalCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MedicalCode
		{
			get
			{
				return this._MedicalCode;
			}
			set
			{
				if ((this._MedicalCode != value))
				{
					this._MedicalCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="VarChar(20)")]
		public string CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this._CreateDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorFamily", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentName", DbType="NVarChar(50)")]
		public string ParentName
		{
			get
			{
				return this._ParentName;
			}
			set
			{
				if ((this._ParentName != value))
				{
					this._ParentName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNO", DbType="VarChar(20)")]
		public string IDNO
		{
			get
			{
				return this._IDNO;
			}
			set
			{
				if ((this._IDNO != value))
				{
					this._IDNO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NationalCode", DbType="VarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrithDate", DbType="VarChar(10)")]
		public string BrithDate
		{
			get
			{
				return this._BrithDate;
			}
			set
			{
				if ((this._BrithDate != value))
				{
					this._BrithDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrithCityName", DbType="NVarChar(50)")]
		public string BrithCityName
		{
			get
			{
				return this._BrithCityName;
			}
			set
			{
				if ((this._BrithCityName != value))
				{
					this._BrithCityName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorType_Id", DbType="SmallInt")]
		public System.Nullable<short> DoctorType_Id
		{
			get
			{
				return this._DoctorType_Id;
			}
			set
			{
				if ((this._DoctorType_Id != value))
				{
					this._DoctorType_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressPart", DbType="SmallInt")]
		public System.Nullable<short> AddressPart
		{
			get
			{
				return this._AddressPart;
			}
			set
			{
				if ((this._AddressPart != value))
				{
					this._AddressPart = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(4000)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelHome", DbType="VarChar(50)")]
		public string TelHome
		{
			get
			{
				return this._TelHome;
			}
			set
			{
				if ((this._TelHome != value))
				{
					this._TelHome = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelBusiness", DbType="VarChar(50)")]
		public string TelBusiness
		{
			get
			{
				return this._TelBusiness;
			}
			set
			{
				if ((this._TelBusiness != value))
				{
					this._TelBusiness = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="VarChar(50)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this._Mobile = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardBankNo1", DbType="VarChar(100)")]
		public string CardBankNo1
		{
			get
			{
				return this._CardBankNo1;
			}
			set
			{
				if ((this._CardBankNo1 != value))
				{
					this._CardBankNo1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardBankNo2", DbType="VarChar(100)")]
		public string CardBankNo2
		{
			get
			{
				return this._CardBankNo2;
			}
			set
			{
				if ((this._CardBankNo2 != value))
				{
					this._CardBankNo2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorPrice", DbType="BigInt")]
		public System.Nullable<long> DoctorPrice
		{
			get
			{
				return this._DoctorPrice;
			}
			set
			{
				if ((this._DoctorPrice != value))
				{
					this._DoctorPrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this._Active = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorTypeTitleName", DbType="NVarChar(50)")]
		public string DoctorTypeTitleName
		{
			get
			{
				return this._DoctorTypeTitleName;
			}
			set
			{
				if ((this._DoctorTypeTitleName != value))
				{
					this._DoctorTypeTitleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank_Id", DbType="SmallInt")]
		public System.Nullable<short> Bank_Id
		{
			get
			{
				return this._Bank_Id;
			}
			set
			{
				if ((this._Bank_Id != value))
				{
					this._Bank_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BankName", DbType="NVarChar(50)")]
		public string BankName
		{
			get
			{
				return this._BankName;
			}
			set
			{
				if ((this._BankName != value))
				{
					this._BankName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContractNo", DbType="VarChar(20)")]
		public string ContractNo
		{
			get
			{
				return this._ContractNo;
			}
			set
			{
				if ((this._ContractNo != value))
				{
					this._ContractNo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContractDate", DbType="VarChar(20)")]
		public string ContractDate
		{
			get
			{
				return this._ContractDate;
			}
			set
			{
				if ((this._ContractDate != value))
				{
					this._ContractDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContractEndDate", DbType="VarChar(20)")]
		public string ContractEndDate
		{
			get
			{
				return this._ContractEndDate;
			}
			set
			{
				if ((this._ContractEndDate != value))
				{
					this._ContractEndDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocationPart", DbType="NVarChar(2000)")]
		public string LocationPart
		{
			get
			{
				return this._LocationPart;
			}
			set
			{
				if ((this._LocationPart != value))
				{
					this._LocationPart = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorParent_Id", DbType="Int")]
		public System.Nullable<int> DoctorParent_Id
		{
			get
			{
				return this._DoctorParent_Id;
			}
			set
			{
				if ((this._DoctorParent_Id != value))
				{
					this._DoctorParent_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorParentsNameFamily", DbType="NVarChar(101)")]
		public string DoctorParentsNameFamily
		{
			get
			{
				return this._DoctorParentsNameFamily;
			}
			set
			{
				if ((this._DoctorParentsNameFamily != value))
				{
					this._DoctorParentsNameFamily = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorTaxPercent", DbType="SmallInt")]
		public System.Nullable<short> DoctorTaxPercent
		{
			get
			{
				return this._DoctorTaxPercent;
			}
			set
			{
				if ((this._DoctorTaxPercent != value))
				{
					this._DoctorTaxPercent = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_Doctors")]
	public partial class TBL_Doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _DoctorParent_Id;
		
		private string _MedicalCode;
		
		private string _CreateDate;
		
		private System.Data.Linq.Binary _DoctorPic;
		
		private string _DoctorName;
		
		private string _DoctorFamily;
		
		private string _ParentName;
		
		private string _IDNO;
		
		private string _NationalCode;
		
		private string _BrithDate;
		
		private string _BrithCityName;
		
		private System.Nullable<short> _DoctorType_Id;
		
		private System.Nullable<short> _AddressPart;
		
		private string _Address;
		
		private string _TelHome;
		
		private string _TelBusiness;
		
		private string _Mobile;
		
		private string _Email;
		
		private System.Nullable<short> _Bank_Id;
		
		private string _CardBankNo1;
		
		private string _CardBankNo2;
		
		private System.Nullable<long> _DoctorPrice;
		
		private System.Nullable<short> _DoctorTaxPercent;
		
		private System.Nullable<bool> _Active;
		
		private System.Nullable<int> _User_Id;
		
		private string _ChangeDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDoctorParent_IdChanging(System.Nullable<int> value);
    partial void OnDoctorParent_IdChanged();
    partial void OnMedicalCodeChanging(string value);
    partial void OnMedicalCodeChanged();
    partial void OnCreateDateChanging(string value);
    partial void OnCreateDateChanged();
    partial void OnDoctorPicChanging(System.Data.Linq.Binary value);
    partial void OnDoctorPicChanged();
    partial void OnDoctorNameChanging(string value);
    partial void OnDoctorNameChanged();
    partial void OnDoctorFamilyChanging(string value);
    partial void OnDoctorFamilyChanged();
    partial void OnParentNameChanging(string value);
    partial void OnParentNameChanged();
    partial void OnIDNOChanging(string value);
    partial void OnIDNOChanged();
    partial void OnNationalCodeChanging(string value);
    partial void OnNationalCodeChanged();
    partial void OnBrithDateChanging(string value);
    partial void OnBrithDateChanged();
    partial void OnBrithCityNameChanging(string value);
    partial void OnBrithCityNameChanged();
    partial void OnDoctorType_IdChanging(System.Nullable<short> value);
    partial void OnDoctorType_IdChanged();
    partial void OnAddressPartChanging(System.Nullable<short> value);
    partial void OnAddressPartChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnTelHomeChanging(string value);
    partial void OnTelHomeChanged();
    partial void OnTelBusinessChanging(string value);
    partial void OnTelBusinessChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnBank_IdChanging(System.Nullable<short> value);
    partial void OnBank_IdChanged();
    partial void OnCardBankNo1Changing(string value);
    partial void OnCardBankNo1Changed();
    partial void OnCardBankNo2Changing(string value);
    partial void OnCardBankNo2Changed();
    partial void OnDoctorPriceChanging(System.Nullable<long> value);
    partial void OnDoctorPriceChanged();
    partial void OnDoctorTaxPercentChanging(System.Nullable<short> value);
    partial void OnDoctorTaxPercentChanged();
    partial void OnActiveChanging(System.Nullable<bool> value);
    partial void OnActiveChanged();
    partial void OnUser_IdChanging(System.Nullable<int> value);
    partial void OnUser_IdChanged();
    partial void OnChangeDateTimeChanging(string value);
    partial void OnChangeDateTimeChanged();
    #endregion
		
		public TBL_Doctor()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorParent_Id", DbType="Int")]
		public System.Nullable<int> DoctorParent_Id
		{
			get
			{
				return this._DoctorParent_Id;
			}
			set
			{
				if ((this._DoctorParent_Id != value))
				{
					this.OnDoctorParent_IdChanging(value);
					this.SendPropertyChanging();
					this._DoctorParent_Id = value;
					this.SendPropertyChanged("DoctorParent_Id");
					this.OnDoctorParent_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicalCode", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string MedicalCode
		{
			get
			{
				return this._MedicalCode;
			}
			set
			{
				if ((this._MedicalCode != value))
				{
					this.OnMedicalCodeChanging(value);
					this.SendPropertyChanging();
					this._MedicalCode = value;
					this.SendPropertyChanged("MedicalCode");
					this.OnMedicalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="VarChar(20)")]
		public string CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorPic", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary DoctorPic
		{
			get
			{
				return this._DoctorPic;
			}
			set
			{
				if ((this._DoctorPic != value))
				{
					this.OnDoctorPicChanging(value);
					this.SendPropertyChanging();
					this._DoctorPic = value;
					this.SendPropertyChanged("DoctorPic");
					this.OnDoctorPicChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnDoctorNameChanging(value);
					this.SendPropertyChanging();
					this._DoctorName = value;
					this.SendPropertyChanged("DoctorName");
					this.OnDoctorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorFamily", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
					this.OnDoctorFamilyChanging(value);
					this.SendPropertyChanging();
					this._DoctorFamily = value;
					this.SendPropertyChanged("DoctorFamily");
					this.OnDoctorFamilyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentName", DbType="NVarChar(50)")]
		public string ParentName
		{
			get
			{
				return this._ParentName;
			}
			set
			{
				if ((this._ParentName != value))
				{
					this.OnParentNameChanging(value);
					this.SendPropertyChanging();
					this._ParentName = value;
					this.SendPropertyChanged("ParentName");
					this.OnParentNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNO", DbType="VarChar(20)")]
		public string IDNO
		{
			get
			{
				return this._IDNO;
			}
			set
			{
				if ((this._IDNO != value))
				{
					this.OnIDNOChanging(value);
					this.SendPropertyChanging();
					this._IDNO = value;
					this.SendPropertyChanged("IDNO");
					this.OnIDNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NationalCode", DbType="VarChar(20)")]
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
					this.OnNationalCodeChanging(value);
					this.SendPropertyChanging();
					this._NationalCode = value;
					this.SendPropertyChanged("NationalCode");
					this.OnNationalCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrithDate", DbType="VarChar(10)")]
		public string BrithDate
		{
			get
			{
				return this._BrithDate;
			}
			set
			{
				if ((this._BrithDate != value))
				{
					this.OnBrithDateChanging(value);
					this.SendPropertyChanging();
					this._BrithDate = value;
					this.SendPropertyChanged("BrithDate");
					this.OnBrithDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrithCityName", DbType="NVarChar(50)")]
		public string BrithCityName
		{
			get
			{
				return this._BrithCityName;
			}
			set
			{
				if ((this._BrithCityName != value))
				{
					this.OnBrithCityNameChanging(value);
					this.SendPropertyChanging();
					this._BrithCityName = value;
					this.SendPropertyChanged("BrithCityName");
					this.OnBrithCityNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorType_Id", DbType="SmallInt")]
		public System.Nullable<short> DoctorType_Id
		{
			get
			{
				return this._DoctorType_Id;
			}
			set
			{
				if ((this._DoctorType_Id != value))
				{
					this.OnDoctorType_IdChanging(value);
					this.SendPropertyChanging();
					this._DoctorType_Id = value;
					this.SendPropertyChanged("DoctorType_Id");
					this.OnDoctorType_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressPart", DbType="SmallInt")]
		public System.Nullable<short> AddressPart
		{
			get
			{
				return this._AddressPart;
			}
			set
			{
				if ((this._AddressPart != value))
				{
					this.OnAddressPartChanging(value);
					this.SendPropertyChanging();
					this._AddressPart = value;
					this.SendPropertyChanged("AddressPart");
					this.OnAddressPartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(4000)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelHome", DbType="VarChar(50)")]
		public string TelHome
		{
			get
			{
				return this._TelHome;
			}
			set
			{
				if ((this._TelHome != value))
				{
					this.OnTelHomeChanging(value);
					this.SendPropertyChanging();
					this._TelHome = value;
					this.SendPropertyChanged("TelHome");
					this.OnTelHomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelBusiness", DbType="VarChar(50)")]
		public string TelBusiness
		{
			get
			{
				return this._TelBusiness;
			}
			set
			{
				if ((this._TelBusiness != value))
				{
					this.OnTelBusinessChanging(value);
					this.SendPropertyChanging();
					this._TelBusiness = value;
					this.SendPropertyChanged("TelBusiness");
					this.OnTelBusinessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="VarChar(50)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bank_Id", DbType="SmallInt")]
		public System.Nullable<short> Bank_Id
		{
			get
			{
				return this._Bank_Id;
			}
			set
			{
				if ((this._Bank_Id != value))
				{
					this.OnBank_IdChanging(value);
					this.SendPropertyChanging();
					this._Bank_Id = value;
					this.SendPropertyChanged("Bank_Id");
					this.OnBank_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardBankNo1", DbType="VarChar(100)")]
		public string CardBankNo1
		{
			get
			{
				return this._CardBankNo1;
			}
			set
			{
				if ((this._CardBankNo1 != value))
				{
					this.OnCardBankNo1Changing(value);
					this.SendPropertyChanging();
					this._CardBankNo1 = value;
					this.SendPropertyChanged("CardBankNo1");
					this.OnCardBankNo1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardBankNo2", DbType="VarChar(100)")]
		public string CardBankNo2
		{
			get
			{
				return this._CardBankNo2;
			}
			set
			{
				if ((this._CardBankNo2 != value))
				{
					this.OnCardBankNo2Changing(value);
					this.SendPropertyChanging();
					this._CardBankNo2 = value;
					this.SendPropertyChanged("CardBankNo2");
					this.OnCardBankNo2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorPrice", DbType="BigInt")]
		public System.Nullable<long> DoctorPrice
		{
			get
			{
				return this._DoctorPrice;
			}
			set
			{
				if ((this._DoctorPrice != value))
				{
					this.OnDoctorPriceChanging(value);
					this.SendPropertyChanging();
					this._DoctorPrice = value;
					this.SendPropertyChanged("DoctorPrice");
					this.OnDoctorPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorTaxPercent", DbType="SmallInt")]
		public System.Nullable<short> DoctorTaxPercent
		{
			get
			{
				return this._DoctorTaxPercent;
			}
			set
			{
				if ((this._DoctorTaxPercent != value))
				{
					this.OnDoctorTaxPercentChanging(value);
					this.SendPropertyChanging();
					this._DoctorTaxPercent = value;
					this.SendPropertyChanged("DoctorTaxPercent");
					this.OnDoctorTaxPercentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Active", DbType="Bit")]
		public System.Nullable<bool> Active
		{
			get
			{
				return this._Active;
			}
			set
			{
				if ((this._Active != value))
				{
					this.OnActiveChanging(value);
					this.SendPropertyChanging();
					this._Active = value;
					this.SendPropertyChanged("Active");
					this.OnActiveChanged();
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
}
#pragma warning restore 1591
