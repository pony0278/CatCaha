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
    
    public partial class Shop_Order_Detail_Table
    {
        public Nullable<int> Order_ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public Nullable<int> Product_Quantity { get; set; }
        public int Order_Detail_ID { get; set; }
    
        public virtual Shop_Order_Total_Table Shop_Order_Total_Table { get; set; }
        public virtual Shop_Product_Total Shop_Product_Total { get; set; }
    }
}
