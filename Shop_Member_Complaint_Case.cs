//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatChaForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Member_Complaint_Case
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Member_Complaint_Case()
        {
            this.Shop_Reply_Data = new HashSet<Shop_Reply_Data>();
        }
    
        public int Complaint_Case_ID { get; set; }
        public string Complaint_Title { get; set; }
        public Nullable<int> Member_ID { get; set; }
        public string Complaint_Content { get; set; }
        public Nullable<int> Complaint_Status_ID { get; set; }
        public Nullable<int> Complaint_Category_ID { get; set; }
        public Nullable<System.DateTime> Creation_Time { get; set; }
    
        public virtual Shop_Appeal_Category_Data Shop_Appeal_Category_Data { get; set; }
        public virtual Shop_Complaint_Status_Data Shop_Complaint_Status_Data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Reply_Data> Shop_Reply_Data { get; set; }
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
    }
}
