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
    
    public partial class Game_Friend_List_Chat_Data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game_Friend_List_Chat_Data()
        {
            this.Game_Member_B_Message_Data = new HashSet<Game_Member_B_Message_Data>();
        }
    
        public int Friend_ID { get; set; }
        public int Chat_Room_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Member_B_Message_Data> Game_Member_B_Message_Data { get; set; }
    }
}
