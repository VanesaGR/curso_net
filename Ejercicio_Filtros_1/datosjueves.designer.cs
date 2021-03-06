#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio_Filtros
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FiltrosLINQ")]
	public partial class datosjuevesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertdatosjueves(datosjueves instance);
    partial void Updatedatosjueves(datosjueves instance);
    partial void Deletedatosjueves(datosjueves instance);
    #endregion
		
		public datosjuevesDataContext() : 
				base(global::Ejercicio_Filtros.Properties.Settings.Default.FiltrosLINQConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public datosjuevesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosjuevesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosjuevesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datosjuevesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<datosjueves> datosjueves
		{
			get
			{
				return this.GetTable<datosjueves>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.datosjueves")]
	public partial class datosjueves : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Apellidos;
		
		private System.Nullable<System.DateTime> _Fecha_Insc;
		
		private System.Nullable<System.DateTime> _Fecha_Cont;
		
		private string _Curso;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidosChanging(string value);
    partial void OnApellidosChanged();
    partial void OnFecha_InscChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_InscChanged();
    partial void OnFecha_ContChanging(System.Nullable<System.DateTime> value);
    partial void OnFecha_ContChanged();
    partial void OnCursoChanging(string value);
    partial void OnCursoChanged();
    #endregion
		
		public datosjueves()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellidos", DbType="NVarChar(50)")]
		public string Apellidos
		{
			get
			{
				return this._Apellidos;
			}
			set
			{
				if ((this._Apellidos != value))
				{
					this.OnApellidosChanging(value);
					this.SendPropertyChanging();
					this._Apellidos = value;
					this.SendPropertyChanged("Apellidos");
					this.OnApellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Insc", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_Insc
		{
			get
			{
				return this._Fecha_Insc;
			}
			set
			{
				if ((this._Fecha_Insc != value))
				{
					this.OnFecha_InscChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Insc = value;
					this.SendPropertyChanged("Fecha_Insc");
					this.OnFecha_InscChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha_Cont", DbType="DateTime")]
		public System.Nullable<System.DateTime> Fecha_Cont
		{
			get
			{
				return this._Fecha_Cont;
			}
			set
			{
				if ((this._Fecha_Cont != value))
				{
					this.OnFecha_ContChanging(value);
					this.SendPropertyChanging();
					this._Fecha_Cont = value;
					this.SendPropertyChanged("Fecha_Cont");
					this.OnFecha_ContChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Curso", DbType="NVarChar(50)")]
		public string Curso
		{
			get
			{
				return this._Curso;
			}
			set
			{
				if ((this._Curso != value))
				{
					this.OnCursoChanging(value);
					this.SendPropertyChanging();
					this._Curso = value;
					this.SendPropertyChanged("Curso");
					this.OnCursoChanged();
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
