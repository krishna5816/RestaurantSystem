using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
using RestaurantSystem.Party;

namespace RestaurantSystem.Party
{

    public partial class party_viwer : UserControl
    {
     
        public party_viwer()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string partyname 
        {
        
            get
            {
                return lbl_name.Text;
            }
            set
            {
                lbl_name.Text = value;
            }
        }
        public string addre
        {
            get
            {
                return lbl_address.Text;
            }
            set
            {
                lbl_address.Text = value;
            }
        }
        public string phone
        {
            get
            {
                return lbl_phone.Text;
            }
            set
            {
                lbl_phone.Text = value;
            }
        }
        public  decimal due
        {
            get
            {
                return Convert.ToDecimal(label_due.Text);
            }
            set
            {
                label_due.Text = value.ToString();
            }
        }
        public string pan
        {
            get
            {
                return label_pan.Text;
            }
            set
            {
                label_pan.Text = value;
            }
            
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var i = new Parties.EditParty();
            i.loaddata(this.id);
            var trance = new CustomControls.Modal(i);
            i.edit += I_edit;
            trance.Show();


        }

        private void I_edit(party party)
        {
            var viwer = new Party.party_viwer();
            viwer.id = party.id;
            viwer.partyname = party.name;
            viwer.addre = party.address;
            viwer.pan = party.pannumber;
            viwer.due = party.due.Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model.ResturantManagementEntities())
                {
                    var i = db.parties.Where(o => o.id == this.id).Single();
                    db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    this.Parent.Controls.Remove(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void materialButton_details_Click(object sender, EventArgs e)
        {
            var details = new Party.Details(id);
            var trace = new CustomControls.Modal(details);
            trace.Show();
        }
    }
}
