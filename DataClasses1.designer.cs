﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bibliotheque")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser_detail(user_detail instance);
    partial void Updateuser_detail(user_detail instance);
    partial void Deleteuser_detail(user_detail instance);
    partial void Insertbook_detail(book_detail instance);
    partial void Updatebook_detail(book_detail instance);
    partial void Deletebook_detail(book_detail instance);
    partial void Insertborrower_detail(borrower_detail instance);
    partial void Updateborrower_detail(borrower_detail instance);
    partial void Deleteborrower_detail(borrower_detail instance);
    partial void Insertstudent_detail(student_detail instance);
    partial void Updatestudent_detail(student_detail instance);
    partial void Deletestudent_detail(student_detail instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Library.Properties.Settings.Default.BibliothequeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user_detail> user_details
		{
			get
			{
				return this.GetTable<user_detail>();
			}
		}
		
		public System.Data.Linq.Table<book_detail> book_details
		{
			get
			{
				return this.GetTable<book_detail>();
			}
		}
		
		public System.Data.Linq.Table<borrower_detail> borrower_details
		{
			get
			{
				return this.GetTable<borrower_detail>();
			}
		}
		
		public System.Data.Linq.Table<student_detail> student_details
		{
			get
			{
				return this.GetTable<student_detail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_details")]
	public partial class user_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _user_id;
		
		private string _designation;
		
		private int _is_admin;
		
		private string _password;
		
		private string _user_name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser_idChanging(long value);
    partial void Onuser_idChanged();
    partial void OndesignationChanging(string value);
    partial void OndesignationChanged();
    partial void Onis_adminChanging(int value);
    partial void Onis_adminChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onuser_nameChanging(string value);
    partial void Onuser_nameChanged();
    #endregion
		
		public user_detail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_designation", DbType="NVarChar(50)")]
		public string designation
		{
			get
			{
				return this._designation;
			}
			set
			{
				if ((this._designation != value))
				{
					this.OndesignationChanging(value);
					this.SendPropertyChanging();
					this._designation = value;
					this.SendPropertyChanged("designation");
					this.OndesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_admin", DbType="Int NOT NULL")]
		public int is_admin
		{
			get
			{
				return this._is_admin;
			}
			set
			{
				if ((this._is_admin != value))
				{
					this.Onis_adminChanging(value);
					this.SendPropertyChanging();
					this._is_admin = value;
					this.SendPropertyChanged("is_admin");
					this.Onis_adminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(255)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_name", DbType="VarChar(255)")]
		public string user_name
		{
			get
			{
				return this._user_name;
			}
			set
			{
				if ((this._user_name != value))
				{
					this.Onuser_nameChanging(value);
					this.SendPropertyChanging();
					this._user_name = value;
					this.SendPropertyChanged("user_name");
					this.Onuser_nameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.book_details")]
	public partial class book_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _book_title;
		
		private string _language_book;
		
		private int _no_copies;
		
		private int _publication_year;
		
		private string _category;
		
		private EntitySet<borrower_detail> _borrower_details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onbook_titleChanging(string value);
    partial void Onbook_titleChanged();
    partial void Onlanguage_bookChanging(string value);
    partial void Onlanguage_bookChanged();
    partial void Onno_copiesChanging(int value);
    partial void Onno_copiesChanged();
    partial void Onpublication_yearChanging(int value);
    partial void Onpublication_yearChanged();
    partial void OncategoryChanging(string value);
    partial void OncategoryChanged();
    #endregion
		
		public book_detail()
		{
			this._borrower_details = new EntitySet<borrower_detail>(new Action<borrower_detail>(this.attach_borrower_details), new Action<borrower_detail>(this.detach_borrower_details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_book_title", DbType="VarChar(255)")]
		public string book_title
		{
			get
			{
				return this._book_title;
			}
			set
			{
				if ((this._book_title != value))
				{
					this.Onbook_titleChanging(value);
					this.SendPropertyChanging();
					this._book_title = value;
					this.SendPropertyChanged("book_title");
					this.Onbook_titleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_language_book", DbType="VarChar(255)")]
		public string language_book
		{
			get
			{
				return this._language_book;
			}
			set
			{
				if ((this._language_book != value))
				{
					this.Onlanguage_bookChanging(value);
					this.SendPropertyChanging();
					this._language_book = value;
					this.SendPropertyChanged("language_book");
					this.Onlanguage_bookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_no_copies", DbType="Int NOT NULL")]
		public int no_copies
		{
			get
			{
				return this._no_copies;
			}
			set
			{
				if ((this._no_copies != value))
				{
					this.Onno_copiesChanging(value);
					this.SendPropertyChanging();
					this._no_copies = value;
					this.SendPropertyChanged("no_copies");
					this.Onno_copiesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_publication_year", DbType="Int NOT NULL")]
		public int publication_year
		{
			get
			{
				return this._publication_year;
			}
			set
			{
				if ((this._publication_year != value))
				{
					this.Onpublication_yearChanging(value);
					this.SendPropertyChanging();
					this._publication_year = value;
					this.SendPropertyChanged("publication_year");
					this.Onpublication_yearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_category", DbType="NVarChar(50)")]
		public string category
		{
			get
			{
				return this._category;
			}
			set
			{
				if ((this._category != value))
				{
					this.OncategoryChanging(value);
					this.SendPropertyChanging();
					this._category = value;
					this.SendPropertyChanged("category");
					this.OncategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="book_detail_borrower_detail", Storage="_borrower_details", ThisKey="id", OtherKey="id_book")]
		public EntitySet<borrower_detail> borrower_details
		{
			get
			{
				return this._borrower_details;
			}
			set
			{
				this._borrower_details.Assign(value);
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
		
		private void attach_borrower_details(borrower_detail entity)
		{
			this.SendPropertyChanging();
			entity.book_detail = this;
		}
		
		private void detach_borrower_details(borrower_detail entity)
		{
			this.SendPropertyChanging();
			entity.book_detail = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.borrower_details")]
	public partial class borrower_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private int _id_book;
		
		private System.DateTime _borrowed_from;
		
		private System.DateTime _borrowed_to;
		
		private string _returned;
		
		private int _student_id;
		
		private System.Nullable<int> _borrower_id;
		
		private EntityRef<book_detail> _book_detail;
		
		private EntityRef<student_detail> _student_detail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onid_bookChanging(int value);
    partial void Onid_bookChanged();
    partial void Onborrowed_fromChanging(System.DateTime value);
    partial void Onborrowed_fromChanged();
    partial void Onborrowed_toChanging(System.DateTime value);
    partial void Onborrowed_toChanged();
    partial void OnreturnedChanging(string value);
    partial void OnreturnedChanged();
    partial void Onstudent_idChanging(int value);
    partial void Onstudent_idChanged();
    partial void Onborrower_idChanging(System.Nullable<int> value);
    partial void Onborrower_idChanged();
    #endregion
		
		public borrower_detail()
		{
			this._book_detail = default(EntityRef<book_detail>);
			this._student_detail = default(EntityRef<student_detail>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_book", DbType="Int NOT NULL")]
		public int id_book
		{
			get
			{
				return this._id_book;
			}
			set
			{
				if ((this._id_book != value))
				{
					if (this._book_detail.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_bookChanging(value);
					this.SendPropertyChanging();
					this._id_book = value;
					this.SendPropertyChanged("id_book");
					this.Onid_bookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_borrowed_from", DbType="Date NOT NULL")]
		public System.DateTime borrowed_from
		{
			get
			{
				return this._borrowed_from;
			}
			set
			{
				if ((this._borrowed_from != value))
				{
					this.Onborrowed_fromChanging(value);
					this.SendPropertyChanging();
					this._borrowed_from = value;
					this.SendPropertyChanged("borrowed_from");
					this.Onborrowed_fromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_borrowed_to", DbType="Date NOT NULL")]
		public System.DateTime borrowed_to
		{
			get
			{
				return this._borrowed_to;
			}
			set
			{
				if ((this._borrowed_to != value))
				{
					this.Onborrowed_toChanging(value);
					this.SendPropertyChanging();
					this._borrowed_to = value;
					this.SendPropertyChanged("borrowed_to");
					this.Onborrowed_toChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_returned", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string returned
		{
			get
			{
				return this._returned;
			}
			set
			{
				if ((this._returned != value))
				{
					this.OnreturnedChanging(value);
					this.SendPropertyChanging();
					this._returned = value;
					this.SendPropertyChanged("returned");
					this.OnreturnedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_id", DbType="Int NOT NULL")]
		public int student_id
		{
			get
			{
				return this._student_id;
			}
			set
			{
				if ((this._student_id != value))
				{
					if (this._student_detail.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onstudent_idChanging(value);
					this.SendPropertyChanging();
					this._student_id = value;
					this.SendPropertyChanged("student_id");
					this.Onstudent_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_borrower_id", DbType="Int")]
		public System.Nullable<int> borrower_id
		{
			get
			{
				return this._borrower_id;
			}
			set
			{
				if ((this._borrower_id != value))
				{
					this.Onborrower_idChanging(value);
					this.SendPropertyChanging();
					this._borrower_id = value;
					this.SendPropertyChanged("borrower_id");
					this.Onborrower_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="book_detail_borrower_detail", Storage="_book_detail", ThisKey="id_book", OtherKey="id", IsForeignKey=true)]
		public book_detail book_detail
		{
			get
			{
				return this._book_detail.Entity;
			}
			set
			{
				book_detail previousValue = this._book_detail.Entity;
				if (((previousValue != value) 
							|| (this._book_detail.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._book_detail.Entity = null;
						previousValue.borrower_details.Remove(this);
					}
					this._book_detail.Entity = value;
					if ((value != null))
					{
						value.borrower_details.Add(this);
						this._id_book = value.id;
					}
					else
					{
						this._id_book = default(int);
					}
					this.SendPropertyChanged("book_detail");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_detail_borrower_detail", Storage="_student_detail", ThisKey="student_id", OtherKey="student_id", IsForeignKey=true)]
		public student_detail student_detail
		{
			get
			{
				return this._student_detail.Entity;
			}
			set
			{
				student_detail previousValue = this._student_detail.Entity;
				if (((previousValue != value) 
							|| (this._student_detail.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._student_detail.Entity = null;
						previousValue.borrower_details.Remove(this);
					}
					this._student_detail.Entity = value;
					if ((value != null))
					{
						value.borrower_details.Add(this);
						this._student_id = value.student_id;
					}
					else
					{
						this._student_id = default(int);
					}
					this.SendPropertyChanged("student_detail");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.student_details")]
	public partial class student_detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _student_id;
		
		private System.Nullable<int> _contact_number;
		
		private System.Nullable<System.DateTime> _date_of_birth;
		
		private string _departement;
		
		private string _sex;
		
		private string _student_name;
		
		private int _borrower_id;
		
		private EntitySet<borrower_detail> _borrower_details;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onstudent_idChanging(int value);
    partial void Onstudent_idChanged();
    partial void Oncontact_numberChanging(System.Nullable<int> value);
    partial void Oncontact_numberChanged();
    partial void Ondate_of_birthChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_of_birthChanged();
    partial void OndepartementChanging(string value);
    partial void OndepartementChanged();
    partial void OnsexChanging(string value);
    partial void OnsexChanged();
    partial void Onstudent_nameChanging(string value);
    partial void Onstudent_nameChanged();
    partial void Onborrower_idChanging(int value);
    partial void Onborrower_idChanged();
    #endregion
		
		public student_detail()
		{
			this._borrower_details = new EntitySet<borrower_detail>(new Action<borrower_detail>(this.attach_borrower_details), new Action<borrower_detail>(this.detach_borrower_details));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int student_id
		{
			get
			{
				return this._student_id;
			}
			set
			{
				if ((this._student_id != value))
				{
					this.Onstudent_idChanging(value);
					this.SendPropertyChanging();
					this._student_id = value;
					this.SendPropertyChanged("student_id");
					this.Onstudent_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contact_number", DbType="Int")]
		public System.Nullable<int> contact_number
		{
			get
			{
				return this._contact_number;
			}
			set
			{
				if ((this._contact_number != value))
				{
					this.Oncontact_numberChanging(value);
					this.SendPropertyChanging();
					this._contact_number = value;
					this.SendPropertyChanged("contact_number");
					this.Oncontact_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_of_birth", DbType="Date")]
		public System.Nullable<System.DateTime> date_of_birth
		{
			get
			{
				return this._date_of_birth;
			}
			set
			{
				if ((this._date_of_birth != value))
				{
					this.Ondate_of_birthChanging(value);
					this.SendPropertyChanging();
					this._date_of_birth = value;
					this.SendPropertyChanged("date_of_birth");
					this.Ondate_of_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_departement", DbType="NChar(30)")]
		public string departement
		{
			get
			{
				return this._departement;
			}
			set
			{
				if ((this._departement != value))
				{
					this.OndepartementChanging(value);
					this.SendPropertyChanging();
					this._departement = value;
					this.SendPropertyChanged("departement");
					this.OndepartementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sex", DbType="NChar(10)")]
		public string sex
		{
			get
			{
				return this._sex;
			}
			set
			{
				if ((this._sex != value))
				{
					this.OnsexChanging(value);
					this.SendPropertyChanging();
					this._sex = value;
					this.SendPropertyChanged("sex");
					this.OnsexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_student_name", DbType="NChar(30)")]
		public string student_name
		{
			get
			{
				return this._student_name;
			}
			set
			{
				if ((this._student_name != value))
				{
					this.Onstudent_nameChanging(value);
					this.SendPropertyChanging();
					this._student_name = value;
					this.SendPropertyChanged("student_name");
					this.Onstudent_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_borrower_id", DbType="Int NOT NULL")]
		public int borrower_id
		{
			get
			{
				return this._borrower_id;
			}
			set
			{
				if ((this._borrower_id != value))
				{
					this.Onborrower_idChanging(value);
					this.SendPropertyChanging();
					this._borrower_id = value;
					this.SendPropertyChanged("borrower_id");
					this.Onborrower_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="student_detail_borrower_detail", Storage="_borrower_details", ThisKey="student_id", OtherKey="student_id")]
		public EntitySet<borrower_detail> borrower_details
		{
			get
			{
				return this._borrower_details;
			}
			set
			{
				this._borrower_details.Assign(value);
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
		
		private void attach_borrower_details(borrower_detail entity)
		{
			this.SendPropertyChanging();
			entity.student_detail = this;
		}
		
		private void detach_borrower_details(borrower_detail entity)
		{
			this.SendPropertyChanging();
			entity.student_detail = null;
		}
	}
}
#pragma warning restore 1591