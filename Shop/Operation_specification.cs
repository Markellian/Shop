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
    
    public partial class Operation_specification
    {
        public string Product { get; set; }
        public int Operation_ID { get; set; }
        public int Specification_ID { get; set; }
        public string Equipment_type { get; set; }
        public int Operation_second { get; set; }
    
        public virtual Equipment_type Equipment_type1 { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual Product Product1 { get; set; }
    }
}