//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furnityra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furnityra()
        {
            this.Specification_furniture = new HashSet<Specification_furniture>();
        }
    
        public string Articyl { get; set; }
        public string Name { get; set; }
        public int Edinica_izmerenia { get; set; }
        public int Kolichestvo { get; set; }
        public int Type_complectyushih { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> Shipper_ID { get; set; }
        public Nullable<System.DateTime> DateShip { get; set; }
        public Nullable<double> Ves { get; set; }
        public Nullable<int> Quality { get; set; }
    
        public virtual Edinica_izmerenia Edinica_izmerenia1 { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual Type_complectyushih Type_complectyushih1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specification_furniture> Specification_furniture { get; set; }
        public virtual Quality Quality1 { get; set; }
    }
}
