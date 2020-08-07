using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.PurchaseCategories
{
    public partial class AddViwer : UserControl
    {
        Model.ResturantManagementEntities db=Model.DatabaseConfigure.getConfigure();
        Model.purchasecategory purchasecategory { get; set; }
        bool savedatabase;
        public AddViwer()
        {
            InitializeComponent();
            savedatabase = false;

        }
        public int id { get; set; }
        public AddViwer(int id)
        {
            InitializeComponent();
            purchasecategory = db.purchasecategories.Find(id);
            betterTextBox_name.Text = purchasecategory.name;
            savedatabase = true;
        }
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (savedatabase)
            {
                purchasecategory.name = betterTextBox_name.Text;
                purchasecategory.updated_at = DateTime.Now;
                purchasecategory.created_at = DateTime.Now;
                purchasecategory.admin_id = INFO.admin_id;
                db.SaveChanges();
            }
            else
            {
                var db = Model.DatabaseConfigure.getConfigure();
                var newpcate = new Model.purchasecategory()
                {
                    name = betterTextBox_name.Text,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now,
                    admin_id = INFO.admin_id
                };
                db.purchasecategories.Add(newpcate);
                db.SaveChanges();
            }
        }
    }
}
