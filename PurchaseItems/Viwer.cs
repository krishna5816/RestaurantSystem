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

namespace RestaurantSystem.PurchaseItems
{
    public partial class Viwer : UserControl
    {
        Model.ResturantManagementEntities db = Model.DatabaseConfigure.getConfigure();
        public Model.purchaseitem Menuitem { get; set; }

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
       
        public decimal unit
        {
            get
            {
                return unit;
            }
            set
            {
                lbl_unit.Text = value.ToString();
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

            var edititem = new PurchaseItems.Edit(id);
            edititem.editdata += Edititem_editdata;
            var trance = new CustomControls.Modal(edititem);
            trance.ShowDialog();

        }

        private void Edititem_editdata(purchaseitem purchaseitem)
        {
            var viwer = new PurchaseItems.Viwer();
            viwer.name = purchaseitem.name;
            viwer.unit = purchaseitem.qty;
            viwer.category_id = ((purchaseitem.purchasecategory as Model.purchasecategory).name);
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
    }
}
    

