//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace buttonHelper
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Member_Coupon_Data
    {
        public Nullable<int> Member_ID { get; set; }
        public Nullable<int> Coupon_ID { get; set; }
        public Nullable<bool> Coupon_Status_ID { get; set; }
        public int Member_Coupon_Data_ID { get; set; }
    
        public virtual Shop_Coupon_Total Shop_Coupon_Total { get; set; }
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
    }
}
