//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatCaha
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Order_Total_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Order_Total_Table()
        {
            this.Shop_Order_Detail_Table = new HashSet<Shop_Order_Detail_Table>();
        }
    
        public Nullable<int> Member_ID { get; set; }
        public int Order_ID { get; set; }
        public Nullable<System.DateTime> Order_Creation_Date { get; set; }
        public Nullable<System.DateTime> Last_Update_Time { get; set; }
        public Nullable<int> Address_ID { get; set; }
        public Nullable<int> Recipient_Name { get; set; }
        public Nullable<int> Recipient_Phone { get; set; }
        public Nullable<int> Order_Status_ID { get; set; }
        public Nullable<int> Payment_Method_ID { get; set; }
        public Nullable<int> Coupon_ID { get; set; }
    
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Order_Detail_Table> Shop_Order_Detail_Table { get; set; }
        public virtual Shop_Order_Status_Data Shop_Order_Status_Data { get; set; }
        public virtual Shop_Payment_Method_Data Shop_Payment_Method_Data { get; set; }
        public virtual Shop_Return_Data_Table Shop_Return_Data_Table { get; set; }
    }
}
