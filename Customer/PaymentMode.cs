using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Customer
{
    public partial class PaymentMode : Form
    {
        int id;
        public PaymentMode(int id)
        {
            InitializeComponent();
           using(var db= Model.DatabaseConfigure.getConfigure())
            {
                var loaddata = db.accounts.Find(id);
                betterTextBox_due.decVal = loaddata.currentdue.Value;
            }
            this.id = id;
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_due.decVal == 0)
            {
                CustomControls.Alert.show("0 due amount", "this customer due amount is 0", 2000);
                return;
            }
            if (checkBo_bank.Checked)
            {
                if (betterTextBox_bankname.Text.Trim() == "")
                {
                    CustomControls.Alert.show("Bank name", "please enter bank name", 2000);
                    betterTextBox_bankname.Focus();
                    return;
                }
                if (betterTextBox_accountnum.Text.Trim() == "")
                {
                    CustomControls.Alert.show("enter account number", "please enter account number", 2000);
                    betterTextBox_accountnum.Focus();
                    return;
                }
                if (betterTextBox_depositer.Text.Trim()=="")
                {
                    CustomControls.Alert.show("depostied by", "please enter deposited by name", 2000);
                    betterTextBox_depositer.Focus();
                    return;
                }
                
            }
            
              if (betterTextBox_paidby.Text.Trim() == "")
                {
                    CustomControls.Alert.show("entry by", "pleae entry by name", 2000);
                betterTextBox_paidby.Focus();
                    return;
                }
                if (betterTextBox_paid.decVal == 0)
                {
                    CustomControls.Alert.show("paid amount", "pleae enter paid amount", 2000);
                betterTextBox_paid.Focus();
                    return;
                }

            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var paidamount = betterTextBox_paid.decVal;
                var temp = paidamount;
                decimal duepaid = 0;
                {
                    foreach (var bill in db.bills.Where(o => o.cusotomer_id == this.id).Where(o => o.dueamount > 0).ToList())
                    {
                        if (temp >= bill.dueamount)
                        {
                            var temp1 = bill.dueamount;
                            bill.dueamount = 0;
                            bill.dueamount = bill.nettotal.Value;
                            db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            temp -= (decimal)temp1;
                            duepaid += (decimal)temp1;
                        }
                        else
                        {

                            bill.dueamount = bill.dueamount- temp;
                            bill.paidamount = bill.paidamount + temp;
                            db.Entry(bill).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            duepaid += temp;
                            temp = 0;

                        }
                        if (temp == 0)
                        {
                            break;
                        }


                    }
                    var part = db.accounts.Find(this.id);
                    part.currentdue -= duepaid;
                    if (part.currentdue > 0 && temp > 0)
                    {
                        if (temp >= part.currentdue.Value)
                        {
                            duepaid += part.currentdue.Value;
                            part.currentdue = 0;
                        }
                        else
                        {
                            duepaid += temp;
                            part.currentdue -= temp;
                        }
                    }
                    betterTextBox_due.decVal = part.currentdue.Value;
                    db.Entry(part).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.customerpayments.Add(new Model.customerpayment()
                    {
                        customer_id = this.id,
                        bankname = betterTextBox_bankname.Text,
                        accountno = betterTextBox_accountnum.Text,
                        depositername = betterTextBox_depositer.Text,
                        amountreceived = betterTextBox_due.decVal,
                        receivedby = betterTextBox_paidby.Text,
                        returnamount = betterTextBox_retrun.decVal,
                        dueamount = betterTextBox_due.decVal,
                        paidamount = betterTextBox_paid.decVal,
                        date = INFO.currentdate,
                        updated_at = DateTime.Now,
                        created_at = DateTime.Now
                    });
                    db.SaveChanges();
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        decimal retrunamount;
        public void refresh()
        {
            if (betterTextBox_due.decVal < betterTextBox_paid.decVal)
            {
                retrunamount = (betterTextBox_paid.decVal - betterTextBox_due.decVal);
                betterTextBox_retrun.decVal = retrunamount;
            }
            else
            {
                betterTextBox_retrun.decVal = 0;
            }
        }
           
        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_paid_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void betterTextBox_retrun_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void checkBo_bank_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBo_bank.Checked)
            {
                panel_bank.Enabled = true;
            }
            else
            {
                panel_bank.Enabled = false;
            }
        }
    }
}
