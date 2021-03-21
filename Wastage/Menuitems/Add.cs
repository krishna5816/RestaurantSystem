using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Wastage
{
    public partial class Add : Form
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public Add()
        {
            InitializeComponent();
            foreach (var item in db.menuitems.ToList())
            {
                comboBox_foodlist.Items.Add(item);
            }
           
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (comboBox_foodlist.SelectedIndex == -1)
            {
                CustomControls.Alert.show("Select", "Please select Foodlist or Itemlist item", 2000);
                return;
            }
            if (betterTextBox_qty.decVal == 0)
            {
                CustomControls.Alert.show("QTY", "Please Enter Qty", 2000);
                return;
            }
            if (betterTextBox_unit.Text.Trim()=="")
            {
                CustomControls.Alert.show("Unit", "Please Enter Unit of item", 2000);
                return;
            }
            
        }

        private void materialButton_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
