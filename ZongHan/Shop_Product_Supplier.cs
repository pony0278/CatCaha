//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatCaha.ZongHan
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Product_Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Product_Supplier()
        {
            this.Shop_Product_Total = new HashSet<Shop_Product_Total>();
        }
    
        public int Supplier_ID { get; set; }
        public string Company_Name { get; set; }
        public string Contact_Phone { get; set; }
        public string Company_Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product_Total> Shop_Product_Total { get; set; }
    }
}
