using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Counters
{
    public partial class Transaction : Form
    {
        int counter_id;
        int date;
        public Transaction(int _counter_id, int _date)
        {
            InitializeComponent();
            counter_id = _counter_id;
            date = _date;
            loadTransactions();
        }
        void loadTransactions()
        {
            betterListView.Items.Clear();
            using (var db =new Model.ResturantManagementEntities())
            {
                var bills = db.bills.Where(o => o.counter_id == counter_id && o.date == date).ToList();
                foreach (var bill in bills)
                {
                    betterListView.Items.Add(new ListViewItem(new string[] {
                        (betterListView.Items.Count+1).ToString(),
                        bill.id.ToString(),
                        bill.grosstotal.ToString(),
                        bill.discount.ToString(),
                        bill.tax_amount.ToString(),
                        bill.nettotal.ToString(),
                        bill.paidamount.ToString(),
                        bill.dueamount.ToString("0"),
                        bill.returnamount.ToString("0")
                    }));
                }
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_refresh_Click(object sender, EventArgs e)
        {
            loadTransactions();
        }
    }
}
