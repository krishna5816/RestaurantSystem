using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Reports
{
   
    public partial class Salesreport : UserControl
    {
        string[] categoryHeader =
        {
            "SN","Category Name","Total Quantity ","Total Amount","Margin"
        };
        string[] itemHeader =
        {
            "SN","Item Name","Total Quantity ","Average Rate","Total Amount"
        };

        string[] billHeader =
        {
            "SN","Billno","Total","Margin"
        };
        internal class categoryViwer
        {
            public string Cat_Name { get; set; }
            public decimal total { get; set; }
            public decimal amount { get; set; }

            public decimal margin { get; set; }
        }
        internal class ItemViwer
        {
            public string Item_Name { get; set; }
            public decimal total { get; set; }
            public decimal avgrate { get; set; }
            public decimal amount { get; set; }
            public decimal margin { get; set; }

        }
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public Salesreport()
        {
            InitializeComponent();
        }

        private void comboBox_sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_sales.SelectedIndex)
            {
                case 0:
                    nepaliCalender_End.Visible = false;
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_start.SelType = CustomControls.NepaliCalender.type.day;
                    break;
                case 1:
                    nepaliCalender_End.Visible = false;
                    nepaliCalender_start.SelType = CustomControls.NepaliCalender.type.week;
                    comboBox_sales_week.Visible = true;
                    break;
                case 2:
                    nepaliCalender_End.Visible = false;
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_start.SelType =CustomControls.NepaliCalender.type.month;
                    break;
                case 3:
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_start.SelType =CustomControls.NepaliCalender.type.year;
                    nepaliCalender_End.Visible = false;

                    break;
                case 4:
                    comboBox_sales_week.Visible = false;
                    nepaliCalender_start.SelType =CustomControls.NepaliCalender.type.day;
                    nepaliCalender_End.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
