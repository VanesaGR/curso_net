using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Code_First.Models
{
    public class ContextoEmpleados:DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }//representa cada tabla que tenemos(ojo con los nombres)

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public ContextoEmpleados() : base("cadenaempleados") { }//la base tiene que tener el mismo nombre de la cadena de conexion
    }
}