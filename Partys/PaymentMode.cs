using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Partys
{
    public partial class PaymentMode : Form
    {
        int id;
        public PaymentMode(int id)
        {
            
            InitializeComponent();
            
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var load = db.parties.Find(id);
                betterTextBox_due.decVal = load.due.Value;
            }
            this.id = id;
        }
     
        private void radioButton_cash_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void radioButton_bybank_CheckedChanged(object sender, EventArgs e)
        {
            
        }
      
        private void PaymentMode_Load(object sender, EventArgs e)
        {

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
                if (betterTextBox_depositer.Text.Trim() == "")
                {
                    CustomControls.Alert.show("depostied by", "please enter deposited by name", 2000);
                    betterTextBox_depositer.Focus();
                    return;
                }
                
            }

            if (betterTextBox_paid.decVal == 0)
            {
                CustomControls.Alert.show("paid amount", "pleae enter paid amount", 2000);
                betterTextBox_paid.Focus();
                return;
            }
            if (betterTextBox_paidby.Text.Trim() == "")
            {
                CustomControls.Alert.show("entry by", "pleae entry by name", 2000);
                betterTextBox_paidby.Focus();
                return;
            }
           
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var paidamount = betterTextBox_paid.decVal;
                var temp = paidamount;
                decimal duepaid = 0;
                {
                    foreach (var purchaseinvoice in db.purchaseinvoices.Where(o => o.parties_id == this.id).Where(o => o.due > 0).ToList())
                    {
                        if (temp >= purchaseinvoice.due)
                        {
                            var temp1 = purchaseinvoice.due;
                            purchaseinvoice.due = 0;
                            purchaseinvoice.due = purchaseinvoice.nettotal;
                            db.Entry(purchaseinvoice).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                           temp -=(decimal) temp1;
                            duepaid += (decimal)temp1;
                        }
                        else
                        {

                            purchaseinvoice.due = purchaseinvoice.due - temp;
                            purchaseinvoice.paid = purchaseinvoice.paid + temp;
                            db.Entry(purchaseinvoice).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            duepaid += temp;
                            temp = 0;

                        }
                        if (temp == 0)
                        {
                            break;
                        }


                    }
                    var part = db.parties.Find(this.id);
                    part.due -= duepaid;
                    if (part.due > 0 && temp > 0)
                    {
                        if (temp >= part.due.Value)
                        {
                            duepaid += part.due.Value;
                            part.due = 0;
                        }
                        else
                        {
                            duepaid += temp;
                            part.due -= temp;
                        }
                    }
                    betterTextBox_due.decVal = part.due.Value;
                    db.Entry(part).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    db.partypayments.Add(new Model.partypayment()
                    {
                        party_id = this.id,
                        bankname = betterTextBox_bankname.Text,
                        accountno = betterTextBox_accountnum.Text,
                        depositername = betterTextBox_depositer.Text,
                        amountreceived = betterTextBox_due.decVal,
                        receivedby = betterTextBox_paidby.Text,
                        returnamount = betterTextBox_return.decVal,
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
        decimal total;
        public void refresh()
        {
            if (betterTextBox_due.decVal < betterTextBox_paid.decVal)
            {
                total = (betterTextBox_paid.decVal - betterTextBox_due.decVal);
                betterTextBox_return.decVal = total;
            }
            else
            {
                betterTextBox_return.decVal = 0;
            }
        }
        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_return_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void betterTextBox_paid_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
