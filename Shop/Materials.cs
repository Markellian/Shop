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
    
    public partial class Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materials()
        {
            this.Specification_material = new HashSet<Specification_material>();
        }
    
        public string Articyl { get; set; }
        public string Name { get; set; }
        public int Edinica_izmerenia { get; set; }
        public int Kolichestvo { get; set; }
        public int Type_material { get; set; }
        public decimal Price { get; set; }
        public string GOST { get; set; }
        public Nullable<double> Dlina { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> Shipper_ID { get; set; }
        public Nullable<System.DateTime> DateShip { get; set; }
        public string characteristic { get; set; }
        public Nullable<int> Quality { get; set; }
    
        public virtual Edinica_izmerenia Edinica_izmerenia1 { get; set; }
        public virtual GOST GOST1 { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual Type_material Type_material1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specification_material> Specification_material { get; set; }
        public virtual Quality Quality1 { get; set; }
    }
}
