//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model_First_II
{
    using System;
    using System.Collections.Generic;
    
    public partial class PUESTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PUESTO()
        {
            this.EMPLEADO = new HashSet<EMPLEADO>();
        }
    
        public int ID_PUESTO { get; set; }
        public string NOMBRE_PUESTO { get; set; }
        public int ID_NIVEL_RIESGO { get; set; }
        public double NIVEL_SALARIO_MIN { get; set; }
        public double NIVEL_SALARIO_MAX { get; set; }
    
        public virtual NIVEL_RIESGO NIVEL_RIESGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLEADO> EMPLEADO { get; set; }
    }
}
