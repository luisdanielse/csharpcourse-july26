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

namespace ExternalDB_Console
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBTest")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertZoo(Zoo instance);
    partial void UpdateZoo(Zoo instance);
    partial void DeleteZoo(Zoo instance);
    partial void InsertAnimalZoo(AnimalZoo instance);
    partial void UpdateAnimalZoo(AnimalZoo instance);
    partial void DeleteAnimalZoo(AnimalZoo instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ExternalDB_Console.Properties.Settings.Default.DBTestConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<Zoo> Zoos
		{
			get
			{
				return this.GetTable<Zoo>();
			}
		}
		
		public System.Data.Linq.Table<AnimalZoo> AnimalZoos
		{
			get
			{
				return this.GetTable<AnimalZoo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animal")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<AnimalZoo> _AnimalZoos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Animal()
		{
			this._AnimalZoos = new EntitySet<AnimalZoo>(new Action<AnimalZoo>(this.attach_AnimalZoos), new Action<AnimalZoo>(this.detach_AnimalZoos));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_AnimalZoo", Storage="_AnimalZoos", ThisKey="Id", OtherKey="AnimalId")]
		public EntitySet<AnimalZoo> AnimalZoos
		{
			get
			{
				return this._AnimalZoos;
			}
			set
			{
				this._AnimalZoos.Assign(value);
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
		
		private void attach_AnimalZoos(AnimalZoo entity)
		{
			this.SendPropertyChanging();
			entity.Animal = this;
		}
		
		private void detach_AnimalZoos(AnimalZoo entity)
		{
			this.SendPropertyChanging();
			entity.Animal = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Zoo")]
	public partial class Zoo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Location;
		
		private EntitySet<AnimalZoo> _AnimalZoos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    #endregion
		
		public Zoo()
		{
			this._AnimalZoos = new EntitySet<AnimalZoo>(new Action<AnimalZoo>(this.attach_AnimalZoos), new Action<AnimalZoo>(this.detach_AnimalZoos));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="NVarChar(50)")]
		public string Location
		{
			get
			{
				return this._Location;
			}
			set
			{
				if ((this._Location != value))
				{
					this.OnLocationChanging(value);
					this.SendPropertyChanging();
					this._Location = value;
					this.SendPropertyChanged("Location");
					this.OnLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Zoo_AnimalZoo", Storage="_AnimalZoos", ThisKey="Id", OtherKey="ZooId")]
		public EntitySet<AnimalZoo> AnimalZoos
		{
			get
			{
				return this._AnimalZoos;
			}
			set
			{
				this._AnimalZoos.Assign(value);
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
		
		private void attach_AnimalZoos(AnimalZoo entity)
		{
			this.SendPropertyChanging();
			entity.Zoo = this;
		}
		
		private void detach_AnimalZoos(AnimalZoo entity)
		{
			this.SendPropertyChanging();
			entity.Zoo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AnimalZoo")]
	public partial class AnimalZoo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _ZooId;
		
		private int _AnimalId;
		
		private EntityRef<Animal> _Animal;
		
		private EntityRef<Zoo> _Zoo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnZooIdChanging(int value);
    partial void OnZooIdChanged();
    partial void OnAnimalIdChanging(int value);
    partial void OnAnimalIdChanged();
    #endregion
		
		public AnimalZoo()
		{
			this._Animal = default(EntityRef<Animal>);
			this._Zoo = default(EntityRef<Zoo>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZooId", DbType="Int NOT NULL")]
		public int ZooId
		{
			get
			{
				return this._ZooId;
			}
			set
			{
				if ((this._ZooId != value))
				{
					if (this._Zoo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnZooIdChanging(value);
					this.SendPropertyChanging();
					this._ZooId = value;
					this.SendPropertyChanged("ZooId");
					this.OnZooIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalId", DbType="Int NOT NULL")]
		public int AnimalId
		{
			get
			{
				return this._AnimalId;
			}
			set
			{
				if ((this._AnimalId != value))
				{
					if (this._Animal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimalIdChanging(value);
					this.SendPropertyChanging();
					this._AnimalId = value;
					this.SendPropertyChanged("AnimalId");
					this.OnAnimalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_AnimalZoo", Storage="_Animal", ThisKey="AnimalId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Animal Animal
		{
			get
			{
				return this._Animal.Entity;
			}
			set
			{
				Animal previousValue = this._Animal.Entity;
				if (((previousValue != value) 
							|| (this._Animal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal.Entity = null;
						previousValue.AnimalZoos.Remove(this);
					}
					this._Animal.Entity = value;
					if ((value != null))
					{
						value.AnimalZoos.Add(this);
						this._AnimalId = value.Id;
					}
					else
					{
						this._AnimalId = default(int);
					}
					this.SendPropertyChanged("Animal");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Zoo_AnimalZoo", Storage="_Zoo", ThisKey="ZooId", OtherKey="Id", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Zoo Zoo
		{
			get
			{
				return this._Zoo.Entity;
			}
			set
			{
				Zoo previousValue = this._Zoo.Entity;
				if (((previousValue != value) 
							|| (this._Zoo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Zoo.Entity = null;
						previousValue.AnimalZoos.Remove(this);
					}
					this._Zoo.Entity = value;
					if ((value != null))
					{
						value.AnimalZoos.Add(this);
						this._ZooId = value.Id;
					}
					else
					{
						this._ZooId = default(int);
					}
					this.SendPropertyChanged("Zoo");
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