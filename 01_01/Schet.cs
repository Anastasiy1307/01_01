//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01_01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schet()
        {
            this.Client1 = new HashSet<Client>();
        }
    
        public int ID { get; set; }
        public Nullable<int> id_client { get; set; }
        public Nullable<double> summa { get; set; }
        public Nullable<int> id_uslugi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client1 { get; set; }
        public virtual USl USl { get; set; }
    }
}