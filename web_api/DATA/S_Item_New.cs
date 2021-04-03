//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_Item_New
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_Item_New()
        {
            this.S_User_Items = new HashSet<S_User_Items>();
        }
    
        public int itemId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string image4 { get; set; }
        public Nullable<int> numberOfPoints { get; set; }
        public Nullable<int> sizeId { get; set; }
        public Nullable<int> typeId { get; set; }
        public Nullable<int> styleId { get; set; }
        public Nullable<int> conditionId { get; set; }
    
        public virtual S_ConditionPrices S_ConditionPrices { get; set; }
        public virtual S_ItemSize S_ItemSize { get; set; }
        public virtual S_ItemStyle S_ItemStyle { get; set; }
        public virtual S_ItemPrice S_ItemPrice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_User_Items> S_User_Items { get; set; }
    }
}
