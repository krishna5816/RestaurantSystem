using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Party;
using RestaurantSystem.Model;

namespace RestaurantSystem.Parties
{
   
    public partial class List : Form
    {
        Model.ResturantManagementEntities db;
        public List()
        {
           
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            foreach(var party in db.parties.ToList())
            {
                add(party);
                
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddParty i = new AddParty();
            var trance = new CustomControls.Modal(i);
            i.adddata += I_adddata;
            trance.Show();
        }

        private void I_adddata(party party)
        {
            add(party);
        }

      
        private void add(Model.party party)
        {

            var viwer = new party_viwer();
            viwer.id = party.id;
            viwer.partyname = party.name;
            viwer.addre = party.address;
            viwer.phone = party.phone;
            viwer.pan = party.pannumber;
            viwer.due = party.due.Value;
            viwer.Dock = DockStyle.Top;
            panel_menu.Controls.Add(viwer);
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control p_list in panel_menu.Controls)
            {
                var p_viwer = p_list as party_viwer;
                if (p_viwer.Name.ToLower().Contains(betterTextBox_search.Text.ToLower()))
                {
                    p_viwer.Show();
                }
                else
                {
                    p_viwer.Hide();
                }
            }
        }
    }
}
