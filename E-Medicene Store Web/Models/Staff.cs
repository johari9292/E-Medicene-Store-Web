using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Medicene_Store_Web.Models
{
    public class Staff
    {
        
       
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public Staff()
            {
                this.StaffSaleries = new HashSet<StaffSalery>();
            }

            public string UserName { get; set; }
            public string Password { get; set; }
            public string StaffID { get; set; }
            public string Name { get; set; }
            public double Contact { get; set; }
            public string Address { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<StaffSalery> StaffSaleries { get; set; }
        
    }
    public partial class StaffSalery
    {  
        [Key]
        public int Salarey_ID { get; set; }
        public string StaffID { get; set; }
        public double Salery { get; set; }

        public virtual Staff Staff { get; set; }
    }


}