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
    
    public partial class Game_Item_Purchase_Record
    {
        public byte[] Member_ID { get; set; }
        public Nullable<int> Product_ID { get; set; }
        public string Character_Name { get; set; }
        public string Purchase_Time { get; set; }
        public string Item_Name { get; set; }
        public int Game_Item_Purchase_Record_ID { get; set; }
    
        public virtual Game_Product_Total Game_Product_Total { get; set; }
    }
}
