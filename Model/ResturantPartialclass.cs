using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace RestaurantSystem.Model
{
    public partial class ResturantManagementEntities : DbContext
    {
        public ResturantManagementEntities (string ConnectionString) : base(ConnectionString)
        {

        }
    }
}
