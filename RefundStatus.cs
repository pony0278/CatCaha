﻿using CatCaha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqLabs
{
    public partial class RefundStatus : Form
    {
        public RefundStatus()
        {
            InitializeComponent();

            prepareMaterials();
        }

        //載入預設資料
        private void prepareMaterials()
        {
            try
            {

                var q = from p in dbContext.Shop_Order_Total_Table
                        //join s in dbContext.Shop_Order_Status_Data on p.Order_Status_ID equals s.Order_Status_ID
                        join s in dbContext.Shop_Return_Data_Table on p.Order_ID equals s.Order_ID
                        where p.Member_ID == 4
                        select new
                        {
                            訂單編號 = p.Order_ID,
                            成立日期 = (DateTime)p.Order_Creation_Date,
                            訂單狀態 = p.Shop_Order_Status_Data.Status_Name,
                            付款方式 = p.Shop_Payment_Method_Data.Payment_Method_Name
                        };

                //逐行將資料加入到指定格子內
                foreach (var item in q)
                {
                    dataGridView1.Rows.Add(new object[] { item.訂單編號, item.成立日期, item.訂單狀態, item.付款方式 });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        貓抓抓Entities1 dbContext = new 貓抓抓Entities1();
        //放在類別中供各地方可使用全域，先讓dbContext取得資料

        //明細按鈕
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = clickedCell.Value.ToString();

                if (cellText == "明細")
                {
                    ReturnDetails detailForm = new ReturnDetails();
                    detailForm.StartPosition = FormStartPosition.Manual;
                    detailForm.Location = new Point(
                        this.Location.X + (this.Width - detailForm.Width) / 2,
                        this.Location.Y + (this.Height - detailForm.Height) / 2
                    );
                    detailForm.ShowDialog();
                    detailForm.BringToFront();


                }
            }
        }

        //搜尋按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool found = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }
    }
}
