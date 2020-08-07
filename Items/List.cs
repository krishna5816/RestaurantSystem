using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
namespace RestaurantSystem.Items
{
    public partial class List : Form
    { 
        Model.ResturantManagementEntities db = new ResturantManagementEntities();
        public List()
        {
            InitializeComponent();
            foreach (var item in db.menuitems.ToList())
            {
                add(item);
            }
         
        }

       private void add_load(object sender, EventArgs e)
        {
        }
        private  void add(Model.menuitem menuitem)
        {
            var viwer = new Items.Viwer();
            viwer.id = menuitem.id;
            viwer.name = menuitem.name;
            viwer.unit = menuitem.unit;
            viwer.price =(decimal)menuitem.price;
            viwer.category_id = menuitem.category == null ? "" :menuitem.category.name;
            viwer.Dock = DockStyle.Top;
            panel_menuitem.Controls.Add(viwer);
           
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddItems newitem = new AddItems();
            newitem.adddata += Newitem_savedata;
            var trans = new CustomControls.Modal(newitem);
            trans.ShowDialog();
        }

        private void Newitem_savedata(Model.menuitem menuitem)
        {
            add(menuitem);
        }

        private void panel_menuitem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control itm in panel_menuitem.Controls)
            {
                var item = itm as Viwer;
                if (item.name.ToLower().Contains(betterTextBox_search.Text.ToLower()))
                {
                    item.Show();
                }
                else
                {
                    item.Hide();
                }
            }
        }
    }
}
