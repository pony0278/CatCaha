//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatChaEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shop_Product_Image_Table
    {
        public Nullable<int> Product_ID { get; set; }
        public byte[] Product_Photo { get; set; }
        public int Product_Image_ID { get; set; }
    
        public virtual Shop_Product_Total Shop_Product_Total { get; set; }
    }
}
