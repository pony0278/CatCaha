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
    
    public partial class Game_Coin_Exchange_Record
    {
        public Nullable<int> Member_ID { get; set; }
        public Nullable<System.DateTime> Exchange_Time { get; set; }
        public Nullable<int> Exchange_Quantity { get; set; }
        public int Coin_Exchange_Record_ID { get; set; }
    
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
    }
}
