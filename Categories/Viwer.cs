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
namespace RestaurantSystem.Category
{
    public partial class Viwer : UserControl
    {
        Model.ResturantManagementEntities db = new ResturantManagementEntities();
        public Model.category Category { get; set; }
        bool saveondatabase;
        public Viwer()
        {
            InitializeComponent();
            saveondatabase = false;
        }
        public Viwer(int id)
        {
            InitializeComponent();
            Category = db.categories.Find(id);
            betterTextBox1.Text = Category.name;
            saveondatabase = true;
        }
        public int id { get; set; }
        private void Viwer_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveondatabase)
                {
                    db.Entry(Category).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                this.Parent.Controls.Remove(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("not deleted");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (saveondatabase)
            {
                Category.name = betterTextBox1.Text;
                Category.updated_at = DateTime.Now;
                Category.created_at = DateTime.Now;
                Category.admin_id = INFO.admin_id;
                db.SaveChanges();
            }
            else
            {
                var db = Model.DatabaseConfigure.getConfigure();
                var newcate= new Model.category()
                {
                    name = betterTextBox1.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    admin_id = INFO.admin_id,                
                };
                db.categories.Add(newcate);
                db.SaveChanges();
                saveondatabase = true;
            }
        }

        private void betterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                e.Handled = true;
            }
            }
        }
    }

