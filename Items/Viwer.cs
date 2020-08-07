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

namespace RestaurantSystem.Items
{
    public partial class Viwer : UserControl
    {
        Model.ResturantManagementEntities db = Model.DatabaseConfigure.getConfigure();
        public Model.menuitem Menuitem { get; set; }

        public Viwer()
        {
            InitializeComponent();


        }
        public int id { get; set; }
        public string name
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
        public decimal price
        {
            get
            {
                return Convert.ToDecimal(lbl_price.Text);
            }
            set
            {
                lbl_price.Text = value.ToString()
;
            }
        }
        public string unit
        {
            get
            {
                return (lbl_unit.Text);
            }
            set
            {
                lbl_unit.Text = value;
            }
        }
        public string category_id
        {
            get
            {
                return lbl_category.Text;
            }
            set
            {
                lbl_category.Text = value;
            }
        }

        private void materialButton_edit_Click(object sender, EventArgs e)
        {

            EditItems edititem = new EditItems();
            edititem.loaddata(this.id);
            edititem.edit += Edititem_edit1; ; ;
            var trance = new CustomControls.Modal(edititem);
            trance.ShowDialog();

        }

        private void Edititem_edit1(menuitem menuitem)
        {
            var viwer = new Items.Viwer();
            viwer.id = menuitem.id;
            viwer.name = menuitem.name;
            viwer.price = menuitem.price.Value;
            viwer.category_id = menuitem.category.name;
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model.ResturantManagementEntities())
                {
                    var i = db.menuitems.Where(o => o.id == this.id).Single();
                    db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("not deleted");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }

        private void materialButton_details_Click(object sender, EventArgs e)
        {
            var d = new Items.ItemDetails(id);
            var t = new CustomControls.Modal(d);
            t.Show();
        }
    }
}
    

