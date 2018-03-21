namespace Covalyzer.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EarningcallsDate")]
    public partial class EarningcallsDate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EarningcallsDate()
        {
            Stock = new HashSet<Stock>();
        }


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int day_id { get; set; }

        public virtual Day Day { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
