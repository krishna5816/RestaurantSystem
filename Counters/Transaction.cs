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
        decimal grosstotal;
        decimal discount;
        decimal tax_amount;
        decimal nettotal;
        decimal paidamount;
        decimal dueamount;
        decimal returnamount;
        public Transaction(int _counter_id, int _date)
        {
            InitializeComponent();
            counter_id = _counter_id;
            date = _date;
            loadTransactions();
            calculation();
        }
        void calculation()
        {
            betterTextBox_grosstotal.decVal = 0;
            betterTextBox_discount.decVal = 0;
            betterTextBox_dueamount.decVal = 0;
            betterTextBox_tax.decVal = 0;
            betterTextBox_paidamount.decVal = 0;
            betterTextBox_return.decVal = 0;
            betterTextBox_nettotal.decVal = 0;
            foreach (ListViewItem lstItem in betterListView.Items)
            {
                grosstotal += Convert.ToDecimal(lstItem.SubItems[2].Text);
                discount += Convert.ToDecimal(lstItem.SubItems[3].Text);
                tax_amount += Convert.ToDecimal(lstItem.SubItems[4].Text);
                nettotal += Convert.ToDecimal(lstItem.SubItems[5].Text);
                paidamount += Convert.ToDecimal(lstItem.SubItems[6].Text);
                dueamount += Convert.ToDecimal(lstItem.SubItems[7].Text);
                returnamount += Convert.ToDecimal(lstItem.SubItems[8].Text);
                betterTextBox_grosstotal.decVal = grosstotal;
                betterTextBox_discount.decVal = discount;
                betterTextBox_tax.decVal = tax_amount;
                betterTextBox_nettotal.decVal = nettotal;
                betterTextBox_paidamount.decVal = paidamount;
                betterTextBox_dueamount.decVal = dueamount;
                betterTextBox_return.decVal = returnamount;
            }

        }
        void loadTransactions()
        {
            betterListView.Items.Clear();
            using (var db = new Model.ResturantManagementEntities())
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
            calculation();
        }
    }
}
