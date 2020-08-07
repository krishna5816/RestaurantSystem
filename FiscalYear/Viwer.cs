using System;
using System.Windows.Forms;
using System.Linq;
namespace RestaurantSystem.FiscalYear
{
    public partial class Viwer : UserControl
    {
        Model.ResturantManagementEntities db;
        bool loaded;
        public Model.fiscalyear Fiscalyear { get; set; }
        public Viwer()
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
        }

        public Viwer(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            this.Fiscalyear = db.fiscalyears.Find(id);
            betterTextBox_name.Text = this.Fiscalyear.name;
            nepaliCalender_startdate.Datestamp = this.Fiscalyear.startdate.Value;
            nepaliCalender_endate.Datestamp = this.Fiscalyear.enddate.Value;
            loaded = true;
        }



        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                this.Fiscalyear.name = betterTextBox_name.Text;
                this.Fiscalyear.startdate = nepaliCalender_startdate.Datestamp;
                this.Fiscalyear.enddate = nepaliCalender_endate.Datestamp;
                this.Fiscalyear.updated_at = DateTime.Now;
                db.Entry(this.Fiscalyear).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                this.Fiscalyear = new Model.fiscalyear()
                {
                    name = betterTextBox_name.Text,
                    startdate = nepaliCalender_startdate.Datestamp,
                    enddate = nepaliCalender_endate.Datestamp,
                    created_at=DateTime.Now,
                    updated_at=DateTime.Now,
                    admin_id=INFO.admin_id
                };
                db.fiscalyears.Add(this.Fiscalyear);
                db.SaveChanges();
                loaded = true;
            }
        }

        private void materialButton_setDefault_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    setting.fiscalyear_id = this.Fiscalyear.id;
                    db.Entry(setting).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    var setting =new Model.systemsetting()
                    {
                    fiscalyear_id = this.Fiscalyear.id
                    };
                    db.systemsettings.Add(setting);
                    db.SaveChanges();
                }
                INFO.ShowAlert("", this.Fiscalyear.name + " set as current Fiscal Year", 3000);
            }
        }
    }

}
