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
    
    public partial class Game_Member_Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game_Member_Task()
        {
            this.Game_Task_List = new HashSet<Game_Task_List>();
        }
    
        public Nullable<int> Member_ID { get; set; }
        public int Task_ID { get; set; }
        public Nullable<System.DateTime> Complete_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_Task_List> Game_Task_List { get; set; }
        public virtual Shop_Member_Info Shop_Member_Info { get; set; }
    }
}
