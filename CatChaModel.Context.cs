﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class 貓抓抓Entities : DbContext
    {
        public 貓抓抓Entities()
            : base("name=貓抓抓Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Announcement_Type_datum> Announcement_Type_Data { get; set; }
        public virtual DbSet<Game_1on1MessageData> Game_1on1MessageData { get; set; }
        public virtual DbSet<Game_Achievement_List> Game_Achievement_List { get; set; }
        public virtual DbSet<Game_Achievement_Reward_List> Game_Achievement_Reward_List { get; set; }
        public virtual DbSet<Game_CheckIn> Game_CheckIn { get; set; }
        public virtual DbSet<Game_Coin_Exchange_Record> Game_Coin_Exchange_Record { get; set; }
        public virtual DbSet<Game_Friend_Data> Game_Friend_Data { get; set; }
        public virtual DbSet<Game_Friend_List_Chat_Data> Game_Friend_List_Chat_Data { get; set; }
        public virtual DbSet<Game_Global_Chat_Data> Game_Global_Chat_Data { get; set; }
        public virtual DbSet<Game_Item_Purchase_Record> Game_Item_Purchase_Record { get; set; }
        public virtual DbSet<Game_Member_B_Message_Data> Game_Member_B_Message_Data { get; set; }
        public virtual DbSet<Game_Member_Task> Game_Member_Task { get; set; }
        public virtual DbSet<Game_Pet_Total> Game_Pet_Total { get; set; }
        public virtual DbSet<Game_Product_Category> Game_Product_Category { get; set; }
        public virtual DbSet<Game_Product_Total> Game_Product_Total { get; set; }
        public virtual DbSet<Game_Rank_Data> Game_Rank_Data { get; set; }
        public virtual DbSet<Game_Shop_Blog_Data> Game_Shop_Blog_Data { get; set; }
        public virtual DbSet<Game_ShopAnnouncement> Game_ShopAnnouncement { get; set; }
        public virtual DbSet<Game_shopArticleType> Game_shopArticleType { get; set; }
        public virtual DbSet<Game_Task_Condition_Data> Game_Task_Condition_Data { get; set; }
        public virtual DbSet<Game_Task_List> Game_Task_List { get; set; }
        public virtual DbSet<Message_Type_datum> Message_Type_Data { get; set; }
        public virtual DbSet<Shop_Appeal_Category_Data> Shop_Appeal_Category_Data { get; set; }
        public virtual DbSet<Shop_Case_Data_Table> Shop_Case_Data_Table { get; set; }
        public virtual DbSet<Shop_Common_Address_Data> Shop_Common_Address_Data { get; set; }
        public virtual DbSet<Shop_Complaint_Status_Data> Shop_Complaint_Status_Data { get; set; }
        public virtual DbSet<Shop_Coupon_Total> Shop_Coupon_Total { get; set; }
        public virtual DbSet<Shop_Favorite_Data_Table> Shop_Favorite_Data_Table { get; set; }
        public virtual DbSet<Shop_Game_Admin_Data> Shop_Game_Admin_Data { get; set; }
        public virtual DbSet<Shop_Member_Complaint_Case> Shop_Member_Complaint_Case { get; set; }
        public virtual DbSet<Shop_Member_Coupon_Data> Shop_Member_Coupon_Data { get; set; }
        public virtual DbSet<Shop_Member_Info> Shop_Member_Info { get; set; }
        public virtual DbSet<Shop_Order_Detail_Table> Shop_Order_Detail_Table { get; set; }
        public virtual DbSet<Shop_Order_Status_Data> Shop_Order_Status_Data { get; set; }
        public virtual DbSet<Shop_Order_Total_Table> Shop_Order_Total_Table { get; set; }
        public virtual DbSet<Shop_Payment_Method_Data> Shop_Payment_Method_Data { get; set; }
        public virtual DbSet<Shop_Product_Category> Shop_Product_Category { get; set; }
        public virtual DbSet<Shop_Product_Image_Table> Shop_Product_Image_Table { get; set; }
        public virtual DbSet<Shop_Product_Review_Table> Shop_Product_Review_Table { get; set; }
        public virtual DbSet<Shop_Product_Supplier> Shop_Product_Supplier { get; set; }
        public virtual DbSet<Shop_Product_Total> Shop_Product_Total { get; set; }
        public virtual DbSet<Shop_Reply_Data> Shop_Reply_Data { get; set; }
        public virtual DbSet<Shop_Return_Reason_Data_Table> Shop_Return_Reason_Data_Table { get; set; }
        public virtual DbSet<Shop_Return_Status_Data_Table> Shop_Return_Status_Data_Table { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Game_Character_Info> Game_Character_Info { get; set; }
        public virtual DbSet<Shop_Return_Data_Table> Shop_Return_Data_Table { get; set; }
    }
}
